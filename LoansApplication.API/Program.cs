using LoansApplication.API.Extensions;
using LoansApplication.API.Extensions.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.AddControllerCustom();

builder.Services.AddEndpointsApiExplorer();

// Config swagger
builder.AddSwagger();

builder
    .AddDbContext()
    .AddDbInitializer()
    .AddRegisterServices()
    .AddRegisterRepositories();

var app = builder.Build();

app.UseSwaggerCustom();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseDbInitializer();

app.Run();
