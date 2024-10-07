using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCbStatement")]
public partial class BtblCbStatement
{
    [Column("BatchID")]
    public int BatchId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Module { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LedgerDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxRate { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    [Column("UniqueID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? UniqueId { get; set; }

    public bool? Posted { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? Project { get; set; }

    public int? Batch { get; set; }

    public int? RowNumber { get; set; }

    public int? AutoMapped { get; set; }

    [Unicode(false)]
    public string? SagePayExtra1 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra2 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra3 { get; set; }
}
