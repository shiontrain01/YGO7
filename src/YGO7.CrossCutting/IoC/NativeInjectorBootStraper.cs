using YGO7.Core.Interfaces;
using YGO7.Core.Models.Validations;
using YGO7.Core.Services;
using YGO7.CrossCutting.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YGO7.Application.Interfaces;

namespace YGO7.CrossCutting.IoC
{
    public static class NativeInjectorBootStraper
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration config, bool isTest)
        {
            // AspNetUser
           // services.AddScoped<IUser, AspNetUser>();
           
           // AspNetUser
           //services.AddScoped<IUser, AspNetUser>();
            
           // Application - Services
         //  services.AddScoped< ICardAppService, CardService>();

           // Core - Services
           services.AddScoped<ICardService, CardService>();

           // Core - Validations
          // services.AddScoped<IAirplaneValidation, AirplaneValidation>(); aqui vai ficar minhas regras de negocio

           // Infra - Data
          // services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
        
            
            
        }
}
