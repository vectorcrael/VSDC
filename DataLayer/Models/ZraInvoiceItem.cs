using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Keyless]
    public class ZraInvoiceItem
    {
        public int RefId { get; set; } // Invoice ID
        public int ItemSequenceNumber { get; set; } // Sequence number of the item
        public string? ItemDesc { get; set; } // Description of the item
        public string? ItemClassificationCode { get; set; } // Classification code
        public string? ItemCode { get; set; } // Item code
        public decimal Quantity { get; set; } // Quantity of the item
        public string? TaxLabel { get; set; } // Tax label associated with the item
        public string? PackagingUnitCode { get; set; } // Packaging unit code
        public string? QuantityUnitCode { get; set; } // Quantity unit code
        public decimal DiscountAmount { get; set; } // Discount amount
        public decimal UnitPrice { get; set; } // Price per unit
        public decimal TotalAmount { get; set; } // Total amount for the item
        public int IsTaxInclusive { get; set; } // Indicates if tax is included in the price
        public decimal RRP { get; set; } // Recommended retail price
        public double fQuantityLineTaxAmount { get; set; }
        public double fQuantityLineTotExcl { get; set; }
        public decimal VatableAmount {get;set; }
         public decimal TaxAmount {get;set; }
    }
}

