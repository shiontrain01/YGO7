using AirplaneProject.Application.Bases;
using AirplaneProject.Core.Services;
using AirplaneProject.CrossCutting.IoC;
using AirplaneProject.Domain.Models;
using AirplaneProject.WebApi.Configurations;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace AirplaneProject.WebApi
{
    public class Startup
    {

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IConfiguration Configuration { get; }
        public static IWebHostEnvironment Env { get; set; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            //Adicionando a entendidade de carta
            
            services.Configure<CardDatabaseSettings>(
                Configuration.GetSection(nameof(CardDatabaseSettings)));

            services.AddSingleton<ICardDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<CardDatabaseSettings>>().Value);


            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                  .RequireAuthenticatedUser()
                  .Build();
            });

            
            // ASP.NET Identity Settings & JWT
            services.AddIdentitySetup(Configuration);

            // WebAPI Config
            services.AddControllers();

            // AutoMapper Settings
            services.AddAutoMapperSetup();

            // Authorization
            services.AddAuthSetup(Configuration);

            // Swagger Config
            services.AddSwaggerSetup();

            // Adding MediatR for Domain Events and Notifications
            services.AddMediatR(typeof(Startup));

            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<CardService>();

            services.RegisterServices(Configuration, false);
            
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Autenticacao/Login");
                options.AccessDeniedPath = new PathString("/Error/401");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerSetup();

        }
    }
}
