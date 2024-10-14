using DataLayer.Models;
using DataLayer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VSDCAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDBContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),  ServiceLifetime.Transient);
builder.Services.AddScoped<IFiscalInfoService, FiscalInfoService>();
builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<IVSDCAPIApiClient, VSDCAPI.VSDCAPIApiClient>();
builder.Services.AddHostedService<TimerService>(); //do not start up the Timer service
var app = builder.Build();
app.Run();