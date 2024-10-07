using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvArtopSale
{
    public long AutoIdx { get; set; }

    [Column("ID")]
    [StringLength(5)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? TxDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [Column("TransRepID")]
    public int? TransRepId { get; set; }

    public double? LineSales { get; set; }

    public double? LineTax { get; set; }

    [Column("LineItemID")]
    public int? LineItemId { get; set; }

    public int? DrCrAccount { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Module { get; set; } = null!;

    [Column("DefaultRepID")]
    public int? DefaultRepId { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    [Column("TRCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Trcode { get; set; }
}
