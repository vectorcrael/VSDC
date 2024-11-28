using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("FiscalInfo")]
[Index("InvoiceNumber", Name = "idx_FiscalInfo_InvoiceNumber")]
public class FiscalInfo
{
    [Key] public int Id { get; set; }

    [StringLength(50)] public string? InvoiceNumber { get; set; }

    public string? Message { get; set; }

    public DateTime? CreateDate { get; set; }
}