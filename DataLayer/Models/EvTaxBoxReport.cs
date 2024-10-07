using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvTaxBoxReport
{
    [Column("BranchID")]
    public int? BranchId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TxDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TrDescription { get; set; }

    public int? TaxTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [Column("Order_No")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    public int? Project { get; set; }

    [Column("DTStamp", TypeName = "datetime")]
    public DateTime? Dtstamp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxDescription { get; set; }

    public double? TaxRate { get; set; }

    public double? ExclAmount { get; set; }

    public double? TaxAmount { get; set; }

    public double? InclAmount { get; set; }

    [Column("iTaxGroupID")]
    public int? ITaxGroupId { get; set; }

    [Column("iTaxBoxSetupID")]
    public int? ITaxBoxSetupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxGroupCode { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? TaxGroupDescription { get; set; }

    [Column("iBoxNumber")]
    public int? IBoxNumber { get; set; }

    [Column("cBoxLabel")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CBoxLabel { get; set; }

    [Column("cBoxHeading")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CBoxHeading { get; set; }
}
