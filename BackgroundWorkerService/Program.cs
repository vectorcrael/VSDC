using BackgroundWorkerService;
using DataLayer.Data;
using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using ServicesLayer.Services;
using VSDCAPI;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddSingleton<HttpClient, HttpClient>();
builder.Services.AddSingleton<IVSDCAPIApiClient, VSDCAPIApiClient>();
builder.Services.AddHostedService<Worker>();
builder.Services.AddHostedService<TimerService>();
builder.Services.AddSingleton<IFiscalInfoServiceFactory, FiscalInfoServiceFactory>();
builder.Services.AddScoped<IFiscalService, FiscalService>();
var host = builder.Build();
host.Run();