using System;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models2
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
    }
}

