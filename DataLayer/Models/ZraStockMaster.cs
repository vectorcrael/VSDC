using System;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
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
        public decimal Quantity { get; set; }
        public string? TaxLabel { get; set; }
        public string? BranchId { get; set; }
        public double? Prc { get; set; } = 0;
        public double? SplyAmt { get; set; } = 0;
        public decimal? TaxblAmt { get; set; } = 0;
        public string? VatCatCd { get; set; } = "";
        public decimal? TaxAmt { get; set; } = 0;
        public double? TotAmt { get; set; } = 0;
    }
}

