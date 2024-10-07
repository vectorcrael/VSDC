using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblCMRejectReason")]
[Index("EtblCmrejectReasonChecksum", Name = "idx__etblCMRejectReason__etblCMRejectReason_Checksum")]
[Index("EtblCmrejectReasonDModifiedDate", Name = "idx__etblCMRejectReason__etblCMRejectReason_dModifiedDate")]
[Index("EtblCmrejectReasonIBranchId", Name = "idx__etblCMRejectReason__etblCMRejectReason_iBranchID")]
[Index("EtblCmrejectReasonIChangeSetId", Name = "idx__etblCMRejectReason__etblCMRejectReason_iChangeSetID")]
public partial class EtblCmrejectReason
{
    [Key]
    [Column("idRejectReason")]
    public int IdRejectReason { get; set; }

    [Column("cRejectCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CRejectCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblCMRejectReason_iBranchID")]
    public int? EtblCmrejectReasonIBranchId { get; set; }

    [Column("_etblCMRejectReason_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblCmrejectReasonDCreatedDate { get; set; }

    [Column("_etblCMRejectReason_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblCmrejectReasonDModifiedDate { get; set; }

    [Column("_etblCMRejectReason_iCreatedBranchID")]
    public int? EtblCmrejectReasonICreatedBranchId { get; set; }

    [Column("_etblCMRejectReason_iModifiedBranchID")]
    public int? EtblCmrejectReasonIModifiedBranchId { get; set; }

    [Column("_etblCMRejectReason_iCreatedAgentID")]
    public int? EtblCmrejectReasonICreatedAgentId { get; set; }

    [Column("_etblCMRejectReason_iModifiedAgentID")]
    public int? EtblCmrejectReasonIModifiedAgentId { get; set; }

    [Column("_etblCMRejectReason_iChangeSetID")]
    public int? EtblCmrejectReasonIChangeSetId { get; set; }

    [Column("_etblCMRejectReason_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblCmrejectReasonChecksum { get; set; }
}
