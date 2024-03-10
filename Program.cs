var builder = WebApplication.CreateBuilder(args);


string connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddControllers();


var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
