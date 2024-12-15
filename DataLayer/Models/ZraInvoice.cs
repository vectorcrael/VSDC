using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZraInvoice
{
    public required string Id { get; set; }
    public required string InvoiceNumber { get; set; }
    public int? OriginalInvoiceNumber { get; set; }
    public string? DestinationCountryCode { get; set; }
    public string? LocalPurchaseOrder { get; set; }
    public string? BranchId { get; set; }
    public string? PaymentTypeCode { get; set; }
    public string? IssuerName { get; set; }
    public string? IssuerId { get; set; }
    public required string CurrencyType { get; set; }
    public required decimal ConversionRate { get; set; }
    public required string CustomerName { get; set; }
    public string? BuyerTaxAccountName { get; set; }
    public string? ReceiptTypeCode { get; set; }
    public string? CustomerTpin { get; set; }
    public DateTime SaleDate { get; set; }
    public string? RefundReasonCode { get; set; }
    //public double ? taxAmtA{get;set;}
    public double invtottax { get; set; }
    public double invtotincl { get; set; }
    public double invtotexcl { get; set; }
    public int totItemCnt { get; set; }    
    public string? regtycd { get; set; }
    public string sartycd { get; set; }
    public List<ZraInvoiceItem>? Items { get; set; } = new();
}