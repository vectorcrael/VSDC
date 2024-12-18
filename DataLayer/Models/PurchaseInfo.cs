using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class PurchaseInfo
{
    public int Id { get; set; } 
    public required string InvoiceNumber { get; set; } 
    public string? Message { get; set; } 

    public string? CreateDate { get; set; } =
        DateTime.UtcNow.ToString("yyyyMMddHHmmss"); 
}