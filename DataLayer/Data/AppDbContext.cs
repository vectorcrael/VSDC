using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(Func<object, object> value, DbContextOptions<AppDbContext> options)
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FiscalInfo> FiscalInfos { get; set; }
    public virtual DbSet<ZRASTockAdjustment> ZRASTockAdjustments { get; set; }
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
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}