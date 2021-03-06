﻿using FluentValidation;
using KT.JwtProje.Business.Concrete;
using KT.JwtProje.Business.Interfaces;
using KT.JwtProje.Business.ValidationRules;
using KT.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using KT.JwtProje.DataAccess.Interfaces;
using KT.JwtProje.Entities.DTOs.AppUserDtos;
using KT.JwtProje.Entities.DTOs.ProductDtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KT.JwtProje.Business.Containers.MicrosoftIoc
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppRoleService, AppRoleManager>();

            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();
            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddDtoValidator>();

        }
    }
}
