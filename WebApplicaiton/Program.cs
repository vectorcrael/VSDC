using DataLayer.Data;
using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using ServicesLayer.Services;
using VSDCAPI;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddSingleton<IFiscalInfoServiceFactory, FiscalInfoServiceFactory>();
builder.Services.AddSingleton<HttpClient, HttpClient>();
builder.Services.AddSingleton<IVSDCAPIApiClient, VSDCAPIApiClient>();
builder.Services.AddScoped<IFiscalService, FiscalService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();
app.Run();