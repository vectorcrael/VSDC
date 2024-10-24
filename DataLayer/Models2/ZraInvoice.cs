using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models2
{
    [Keyless]
    public class ZraInvoice
    {
        public int totItemCnts;
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

        public List<ZraInvoiceItem>? Items { get; set; } = new List<ZraInvoiceItem>();
        public double invtottax { get; set; }
        public double invtotincl { get; set; }
        public double invtotexcl { get; set; }
        public int totItemCnt {get;set; }
    }
}

