using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblOrderCancelReason")]
[Index("EtblOrderCancelReasonChecksum", Name = "idx__etblOrderCancelReason__etblOrderCancelReason_Checksum")]
[Index("EtblOrderCancelReasonIChangeSetId", Name = "idx__etblOrderCancelReason_iChangeSetID")]
[Index("EtblOrderCancelReasonDModifiedDate", Name = "idx_etblOrderCancelReason_dModifiedDate")]
[Index("EtblOrderCancelReasonIBranchId", Name = "idx_etblOrderCancelReason_iBranchID")]
public partial class EtblOrderCancelReason
{
    [Key]
    [Column("idOrderCancelReason")]
    public int IdOrderCancelReason { get; set; }

    [Column("cCancellationReasonCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CCancellationReasonCode { get; set; }

    [Column("cCancellationReasonDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string CCancellationReasonDesc { get; set; } = null!;

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_etblOrderCancelReason_iBranchID")]
    public int? EtblOrderCancelReasonIBranchId { get; set; }

    [Column("_etblOrderCancelReason_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblOrderCancelReasonDCreatedDate { get; set; }

    [Column("_etblOrderCancelReason_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblOrderCancelReasonDModifiedDate { get; set; }

    [Column("_etblOrderCancelReason_iCreatedBranchID")]
    public int? EtblOrderCancelReasonICreatedBranchId { get; set; }

    [Column("_etblOrderCancelReason_iModifiedBranchID")]
    public int? EtblOrderCancelReasonIModifiedBranchId { get; set; }

    [Column("_etblOrderCancelReason_iCreatedAgentID")]
    public int? EtblOrderCancelReasonICreatedAgentId { get; set; }

    [Column("_etblOrderCancelReason_iModifiedAgentID")]
    public int? EtblOrderCancelReasonIModifiedAgentId { get; set; }

    [Column("_etblOrderCancelReason_iChangeSetID")]
    public int? EtblOrderCancelReasonIChangeSetId { get; set; }

    [Column("_etblOrderCancelReason_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblOrderCancelReasonChecksum { get; set; }
}
