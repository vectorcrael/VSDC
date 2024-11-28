using System;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZraPurchaseItem
{
    public string RefId { get; set; }
    public int ItemSequenceNumber { get; set; }
    public string ItemDesc { get; set; }
    public string ItemClassificationCode { get; set; }
    public string ItemCode { get; set; }
    public decimal Quantity { get; set; }
    public string? TaxLabel { get; set; }
    public string PackagingUnitCode { get; set; }
     public string vatCatCd { get; set; }
    public string QuantityUnitCode { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalAmount { get; set; }
    public int IsTaxInclusive { get; set; }
    public decimal RRP { get; set; }
    public decimal taxAmt { get; set; }
    public decimal taxblAmt { get; set; }
    
    public int itemTyCd { get; set; }
}
