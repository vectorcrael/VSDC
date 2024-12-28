using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models;

[Keyless]
public class ZraStockMaster
{
    public required string ItemCode { get; set; }
    public required string ItemClassificationCode { get; set; }
    public string? PackagingUnitCode { get; set; }
    public string? QuantityUnitCode { get; set; }
    public string? ItemTypeCode { get; set; }
    public string? OriginNationCode { get; set; }
    public string? Description { get; set; }
    [Column(TypeName = "decimal(18, 4)")]
    public decimal Quantity { get; set; }
    public string? TaxLabel { get; set; }
    public string? BranchId { get; set; }
    public double? Prc { get; set; } = 0;
    public double? SplyAmt { get; set; } = 0;
    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TaxblAmt { get; set; } = 0;
    public string? VatCatCd { get; set; } = "";
    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TaxAmt { get; set; } = 0;
    public double? TotAmt { get; set; } = 0;
}