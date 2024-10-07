using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models2
{
    public class PurchaseInfo
    {
        [Key]
        public int Id { get; set; } // Unique identifier
        public required string InvoiceNumber { get; set; } // Invoice number associated with the purchase
        public string? Message { get; set; } // Message or notes related to the purchase
        public DateTime CreateDate { get; set; } = DateTime.UtcNow; // Creation date of the purchase record
    }
}

