using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPriceOverrideReason")]
[Index("RetPriceOverrideReasonChecksum", Name = "idx__retPriceOverrideReason__retPriceOverrideReason_Checksum")]
[Index("RetPriceOverrideReasonIChangeSetId", Name = "idx__retPriceOverrideReason_iChangeSetID")]
[Index("RetPriceOverrideReasonDModifiedDate", Name = "idx_retPriceOverrideReason_dModifiedDate")]
[Index("RetPriceOverrideReasonIBranchId", Name = "idx_retPriceOverrideReason_iBranchID")]
public partial class RetPriceOverrideReason
{
    [Key]
    [Column("idPriceOverrideReason")]
    public int IdPriceOverrideReason { get; set; }

    [Column("cPriceOverrideReasonCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CPriceOverrideReasonCode { get; set; }

    [Column("cPriceOverrideReasonDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CPriceOverrideReasonDesc { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_retPriceOverrideReason_iBranchID")]
    public int? RetPriceOverrideReasonIBranchId { get; set; }

    [Column("_retPriceOverrideReason_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPriceOverrideReasonDCreatedDate { get; set; }

    [Column("_retPriceOverrideReason_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPriceOverrideReasonDModifiedDate { get; set; }

    [Column("_retPriceOverrideReason_iCreatedBranchID")]
    public int? RetPriceOverrideReasonICreatedBranchId { get; set; }

    [Column("_retPriceOverrideReason_iModifiedBranchID")]
    public int? RetPriceOverrideReasonIModifiedBranchId { get; set; }

    [Column("_retPriceOverrideReason_iCreatedAgentID")]
    public int? RetPriceOverrideReasonICreatedAgentId { get; set; }

    [Column("_retPriceOverrideReason_iModifiedAgentID")]
    public int? RetPriceOverrideReasonIModifiedAgentId { get; set; }

    [Column("_retPriceOverrideReason_iChangeSetID")]
    public int? RetPriceOverrideReasonIChangeSetId { get; set; }

    [Column("_retPriceOverrideReason_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPriceOverrideReasonChecksum { get; set; }
}
