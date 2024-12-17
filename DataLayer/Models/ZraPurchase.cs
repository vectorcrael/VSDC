using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZraPurchase
{
    public int Origin { get; set; }
    public string orgnNatCd { get; set; }
    public string Id { get; set; }
    public int InvoiceNumber { get; set; }
    public string SupplierInvoiceNumber { get; set; }
    public int OriginalInvoiceNumber { get; set; }
    public string BranchId { get; set; }
    public string PaymentTypeCode { get; set; }
    public string IssuerName { get; set; }
    public string IssuerId { get; set; }
    public string CurrencyType { get; set; }
    public decimal ConversionRate { get; set; }
    public string CustomerName { get; set; }
    public string BuyerTaxAccountName { get; set; }
    public string ReceiptTypeCode { get; set; }
    public string regTyCd { get; set; }
    public string? CustomerTpin { get; set; }
    public DateTime SaleDate { get; set; }
    public string? RefundedReasonCode { get; set; }
    public string sartycd { get; set; }
    public List<ZraPurchaseItem>? Items { get; set; } = new();
}