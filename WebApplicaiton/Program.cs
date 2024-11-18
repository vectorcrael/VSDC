using DataLayer.Models;
using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using ServicesLayer.Services;
using VSDCAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer("DefaultConnection"));

builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddSingleton<IFiscalInfoServiceFactory, FiscalInfoServiceFactory>(); 
builder.Services.AddSingleton<HttpClient, HttpClient>();
builder.Services.AddSingleton<IVSDCAPIApiClient, VSDCAPI.VSDCAPIApiClient>();
builder.Services.AddScoped<IFiscalService, FiscalService>();

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication(); 
app.MapControllers();
app.Run();

