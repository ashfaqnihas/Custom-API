﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Shop.Application.Common;
using T_Shop.Application.Services;
using T_Shop.Application.Services.Interface;

namespace T_Shop.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices( this IServiceCollection services) 
        {

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICategoryServics, CategoryService>();

           return services;
        }
    }
}
