using BackgroundWorkerService;
using DataLayer.Services;
using VSDCAPI;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddDbContext<AppDBContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IFiscalInfoService, FiscalInfoService>();
builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<IVSDCAPIApiClient, VSDCAPI.VSDCAPIApiClient>();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
