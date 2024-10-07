using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCbMatchRules")]
public partial class BtblCbMatchRule
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keywords { get; set; }

    public int? Module { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxRate { get; set; }

    public int? Priority { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? Project { get; set; }

    public int? Effect { get; set; }

    [Column("CashbookID")]
    public int? CashbookId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUsed { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LedgerDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Source { get; set; }
}
