using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentLog_Archive")]
[Index("RtblIncidentLogArchiveChecksum", Name = "idx__rtblIncidentLog_Archive__rtblIncidentLog_Archive_Checksum")]
[Index("RtblIncidentLogArchiveIChangeSetId", Name = "idx__rtblIncidentLog_Archive_iChangeSetID")]
[Index("RtblIncidentLogArchiveDModifiedDate", Name = "idx_rtblIncidentLog_Archive_dModifiedDate")]
[Index("RtblIncidentLogArchiveIBranchId", Name = "idx_rtblIncidentLog_Archive_iBranchID")]
public partial class RtblIncidentLogArchive
{
    [Key]
    [Column("idIncidentLog")]
    public int IdIncidentLog { get; set; }

    [Column("iIncidentID")]
    public int IIncidentId { get; set; }

    [Column("dActionDate", TypeName = "datetime")]
    public DateTime DActionDate { get; set; }

    [Column("iIncidentActionID")]
    public int IIncidentActionId { get; set; }

    [Column("cResolution", TypeName = "text")]
    public string? CResolution { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("bProxy")]
    public bool BProxy { get; set; }

    [Column("iNewAgentID")]
    public int? INewAgentId { get; set; }

    [Column("cSourceContent", TypeName = "text")]
    public string? CSourceContent { get; set; }

    [Column("cSourceID")]
    [StringLength(128)]
    [Unicode(false)]
    public string CSourceId { get; set; } = null!;

    [Column("iRejectReasonID")]
    public int? IRejectReasonId { get; set; }

    [Column("_rtblIncidentLog_Archive_iBranchID")]
    public int? RtblIncidentLogArchiveIBranchId { get; set; }

    [Column("_rtblIncidentLog_Archive_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentLogArchiveDCreatedDate { get; set; }

    [Column("_rtblIncidentLog_Archive_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentLogArchiveDModifiedDate { get; set; }

    [Column("_rtblIncidentLog_Archive_iCreatedBranchID")]
    public int? RtblIncidentLogArchiveICreatedBranchId { get; set; }

    [Column("_rtblIncidentLog_Archive_iModifiedBranchID")]
    public int? RtblIncidentLogArchiveIModifiedBranchId { get; set; }

    [Column("_rtblIncidentLog_Archive_iCreatedAgentID")]
    public int? RtblIncidentLogArchiveICreatedAgentId { get; set; }

    [Column("_rtblIncidentLog_Archive_iModifiedAgentID")]
    public int? RtblIncidentLogArchiveIModifiedAgentId { get; set; }

    [Column("_rtblIncidentLog_Archive_iChangeSetID")]
    public int? RtblIncidentLogArchiveIChangeSetId { get; set; }

    [Column("_rtblIncidentLog_Archive_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentLogArchiveChecksum { get; set; }
}
