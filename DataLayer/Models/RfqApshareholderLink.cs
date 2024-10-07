using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_APShareholderLinks")]
public partial class RfqApshareholderLink
{
    [Key]
    [Column("idAPShareholderLinks")]
    public int IdApshareholderLinks { get; set; }

    [Column("iAPShareholderID")]
    public int IApshareholderId { get; set; }

    [Column("iSupplierID")]
    public int ISupplierId { get; set; }

    [Column("fPercentage")]
    public double FPercentage { get; set; }

    [Column("cPositionHeld")]
    [StringLength(50)]
    [Unicode(false)]
    public string CPositionHeld { get; set; } = null!;

    [Column("bDirector")]
    public bool? BDirector { get; set; }

    [Column("iBranchID")]
    public int? IBranchId { get; set; }

    [Column("dCreatedDate", TypeName = "datetime")]
    public DateTime? DCreatedDate { get; set; }

    [Column("dModifiedDate", TypeName = "datetime")]
    public DateTime? DModifiedDate { get; set; }

    [Column("iCreatedBranchID")]
    public int? ICreatedBranchId { get; set; }

    [Column("iModifiedBranchID")]
    public int? IModifiedBranchId { get; set; }

    [Column("iCreatedAgentID")]
    public int? ICreatedAgentId { get; set; }

    [Column("iModifiedAgentID")]
    public int? IModifiedAgentId { get; set; }

    [Column("iChangeSetID")]
    public int? IChangeSetId { get; set; }
}
