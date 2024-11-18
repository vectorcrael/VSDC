using System;
using System.Collections.Generic;
using DataLayer.Models2;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class AppDBContext : DbContext
{
    public AppDBContext(Func<object, object> value, DbContextOptions<AppDBContext> options)
    {
    }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FiscalInfo> FiscalInfos { get; set; }
    public virtual DbSet<ZraInvoice> ZraInvoices { get; set; }
    public virtual DbSet<ZraInvoiceItem> ZraInvoiceItems { get; set; }
    public virtual DbSet<PurchaseInfo> PurchaseInfos { get; set; }
    public virtual DbSet<ZraSelectCode> ZraSelectCodes { get; set; }
    public virtual DbSet<ZraClassCode> ZraClassCodes { get; set; }
    public virtual DbSet<DeviceInit> DeviceInits { get; set; }
    public virtual DbSet<ZraStockMaster> ZraStockMasters { get; set; }
    public virtual DbSet<ZraPurchase> ZraPurchases { get; set; }
    public virtual DbSet<ZraImportData> ZraImportDatas { get; set; }
    public virtual DbSet<ZraPurchaseItem> ZraPurchaseItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
