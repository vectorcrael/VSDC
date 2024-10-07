using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentLog")]
[Index("RtblIncidentLogChecksum", Name = "idx__rtblIncidentLog__rtblIncidentLog_Checksum")]
[Index("RtblIncidentLogIChangeSetId", Name = "idx__rtblIncidentLog_iChangeSetID")]
[Index("RtblIncidentLogDModifiedDate", Name = "idx_rtblIncidentLog_dModifiedDate")]
[Index("RtblIncidentLogIBranchId", Name = "idx_rtblIncidentLog_iBranchID")]
public partial class RtblIncidentLog
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
    public string? CSourceId { get; set; }

    [Column("iRejectReasonID")]
    public int? IRejectReasonId { get; set; }

    [Column("_rtblIncidentLog_iBranchID")]
    public int? RtblIncidentLogIBranchId { get; set; }

    [Column("_rtblIncidentLog_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentLogDCreatedDate { get; set; }

    [Column("_rtblIncidentLog_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentLogDModifiedDate { get; set; }

    [Column("_rtblIncidentLog_iCreatedBranchID")]
    public int? RtblIncidentLogICreatedBranchId { get; set; }

    [Column("_rtblIncidentLog_iModifiedBranchID")]
    public int? RtblIncidentLogIModifiedBranchId { get; set; }

    [Column("_rtblIncidentLog_iCreatedAgentID")]
    public int? RtblIncidentLogICreatedAgentId { get; set; }

    [Column("_rtblIncidentLog_iModifiedAgentID")]
    public int? RtblIncidentLogIModifiedAgentId { get; set; }

    [Column("_rtblIncidentLog_iChangeSetID")]
    public int? RtblIncidentLogIChangeSetId { get; set; }

    [Column("_rtblIncidentLog_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentLogChecksum { get; set; }
}
