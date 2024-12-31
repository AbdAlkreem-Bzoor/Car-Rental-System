using Car_Rental.Db.Data;
using Car_Rental.Web.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    });

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["Databases:ConnectionStrings:SqlServer"]);
});

builder.Services.AddScoped<IAppRepository, AppRepository>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();

