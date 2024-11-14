using BackgroundWorkerService;
using DataLayer.Models;
using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using VSDCAPI;
using VSDCAPIApiClient.Services;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddDbContext<AppDBContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IFiscalInfoService, FiscalInfoService>();
builder.Services.AddSingleton<HttpClient, HttpClient>();
builder.Services.AddSingleton<IVSDCAPIApiClient, VSDCAPI.VSDCAPIApiClient>();
builder.Services.AddHostedService<Worker>();
builder.Services.AddHostedService<TimerService>();
builder.Services.AddSingleton<IFiscalInfoServiceFactory, FiscalInfoServiceFactory>();
builder.Services.AddSingleton<IFiscalService, FiscalService>(); 
var host = builder.Build();
host.Run();
