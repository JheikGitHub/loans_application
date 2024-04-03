using LoansApplication.API.Data.DbInitializer;

namespace LoansApplication.API.Extensions
{
    public static class AppExtension
    {
        public static void UseDbInitializer(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var provider = scope.ServiceProvider;
            var DbInitializer = provider.GetRequiredService<IDbInitializer>();
            DbInitializer.Initialize();
        }

        public static void UseSwaggerCustom(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                //options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                //options.RoutePrefix = string.Empty;
            });
        }
    }
}
