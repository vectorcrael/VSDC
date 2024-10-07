using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvPbttransactionsFull
{
    [StringLength(2)]
    [Unicode(false)]
    public string Module { get; set; } = null!;

    [StringLength(91)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? AccountName { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? TaxProvisionAccount { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TaxProvisionDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxDescription { get; set; }

    public double? TaxRate { get; set; }

    public double? PaidExclusive { get; set; }

    public double? PaidTax { get; set; }

    public double? PaidInclusive { get; set; }

    [Column("BatchID")]
    public int? BatchId { get; set; }

    public int AllocatedStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TrCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? TrDesc { get; set; }

    [Column("TransID")]
    [StringLength(5)]
    [Unicode(false)]
    public string TransId { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    public double? TransAmount { get; set; }

    public double? TransTax { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransReference { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransOrderNumber { get; set; }

    public double? TransOutstanding { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransAuditNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string AllocatedTrCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? AllocatedTrDesc { get; set; }

    [Column("AllocatedID")]
    [StringLength(5)]
    [Unicode(false)]
    public string AllocatedId { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? AllocatedDate { get; set; }

    public double? AllocatedAmount { get; set; }

    public double? AllocatedTax { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AllocatedReference { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AllocatedDescription { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AllocatedOrderNumber { get; set; }

    public double? AllocatedOutstanding { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AllocatedAuditNumber { get; set; }
}
