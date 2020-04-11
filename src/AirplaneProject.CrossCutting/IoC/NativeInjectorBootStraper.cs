using AirplaneProject.Application.Interfaces;
using AirplaneProject.Core.Interfaces;
using AirplaneProject.Core.Models.Validations;
using AirplaneProject.Core.Services;
using AirplaneProject.CrossCutting.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AirplaneProject.CrossCutting.IoC
{
    public static class NativeInjectorBootStraper
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration config, bool isTest)
        {
            // AspNetUser
            services.AddScoped<IUser, AspNetUser>();
            
            
        }

    }
}
