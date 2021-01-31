using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using FluentValidation;
using Application.DTO.Category;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            //services.AddValidatorsFromAssembly(typeof(ServiceExtensions).Assembly);
            //services.AddValidatorsFromAssemblyContaining(typeof(ServiceExtensions), ServiceLifetime.Transient);
            //services.AddTransient<IValidator<CreateInputDTO>, CreateValidator>();

        }
    }
}
