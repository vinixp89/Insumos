using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Infra.Ioc
{
    public static class DependecyInjectionSwagger
    {
        public static IServiceCollection AddInfrastuctureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description ="Teste da jwt"


                });
                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement() 
                {

                    {
                        new OpenApiSecurityScheme()
                        { 

                            Reference =new OpenApiReference()
                            {
                            
                            Type = ReferenceType.SecurityScheme,
                            
                            Id = "Bearer",


                            }

                    
                        
                    
                        },

                        new string []{ }

                    }
                
                });

            });

            return services;
        }


    }
}