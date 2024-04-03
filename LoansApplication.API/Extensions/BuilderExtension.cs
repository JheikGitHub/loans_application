using LoansApplication.API.Data.Context;
using LoansApplication.API.Data.DbInitializer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

namespace LoansApplication.API.Extensions
{
    public static class BuilderExtension
    {
        public static void AddControllerCustom(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.SnakeCaseLower;
            });
        }

        public static WebApplicationBuilder AddDbContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DataContext>(options =>
            {
                var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LoanApplication;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                options.UseSqlServer(connectionString);
            });
            return builder;
        }

        public static WebApplicationBuilder AddDbInitializer(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IDbInitializer, DbInitializer>();

            return builder;
        }

        public static void AddSwagger(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Desafio empréstimo ",
                    Description = "Implementação de um serviço que determine quais modalidades de empréstimo uma pessoa tem acesso.",
                    TermsOfService = new Uri("https://github.com/backend-br/desafios/blob/master/loans/PROBLEM.md"),
                    Contact = new OpenApiContact
                    {
                        Name = "Codigo fonte",
                        Url = new Uri("https://github.com/JheikGitHub/loans_application")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "License",
                        Url = new Uri("https://github.com/backend-br/desafios/blob/master/loans/PROBLEM.md")
                    }
                });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }

    }
}
