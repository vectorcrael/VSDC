using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class PurchaseInfo
{
    public int Id { get; set; } // Unique identifier
    public required string InvoiceNumber { get; set; } // Invoice number associated with the purchase
    public string? Message { get; set; } // Message or notes related to the purchase

    public string? CreateDate { get; set; } =
        DateTime.UtcNow.ToString("yyyyMMddHHmmss"); // Creation date of the purchase record
}