using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Demo.Service.Implementations;

namespace Demo.Service.Configurations
{
    public class ServiceConfig
    {
        public static void InitializeInterfaces(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
