using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZRAImportsRec
{
    public string? taskCd { get; set; }
    public string? dclDe { get; set; }
    public string? hsCd { get; set; }
    public string? dclNo { get; set; }
    public List<ZRAImportsRecItem> lines { get; set; } = [];
    public string? vatCatCd { get; set; }
    public string? SupplierInvoiceNumber { get; set; }
    public string? OriginalInvoiceNumber { get; set; }
    public int? InvoiceNumber { get; set; }
    public string? regtycd { get; set; }
    public string? CustomerTpin { get; set; }
    public string? CustomerName { get; set; }
    public string? BranchId { get; set; }
    public string? sartycd { get; set; }
    public DateTime? SaleDate { get; set; }
}

[Keyless]
public class ZRAImportsRecItem
{
    public string? itemClsCd { get; set; }
    public string? itemCd { get; set; }
    public int? imptItemSttsCd { get; set; }
    public string? ItemDesc { get; set; }
    public string? PackagingUnitCode { get; set; }
    public decimal Quantity { get; set; }
    public string? QuantityUnitCode { get; set; }
    public double? UnitPrice { get; set; }
    public double? DiscountAmount { get; set; }
    public double? VatableAmount { get; set; }
    public string? vatCatCd { get; set; }
    public double? TaxAmount { get; set; }
    public double? TotalAmount { get; set; }
}