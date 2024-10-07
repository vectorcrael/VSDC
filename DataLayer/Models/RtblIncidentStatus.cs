using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentStatus")]
[Index("RtblIncidentStatusChecksum", Name = "idx__rtblIncidentStatus__rtblIncidentStatus_Checksum")]
[Index("RtblIncidentStatusIChangeSetId", Name = "idx__rtblIncidentStatus_iChangeSetID")]
[Index("RtblIncidentStatusDModifiedDate", Name = "idx_rtblIncidentStatus_dModifiedDate")]
[Index("RtblIncidentStatusIBranchId", Name = "idx_rtblIncidentStatus_iBranchID")]
public partial class RtblIncidentStatus
{
    [Key]
    [Column("idIncidentStatus")]
    public int IdIncidentStatus { get; set; }

    [Column("cDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_rtblIncidentStatus_iBranchID")]
    public int? RtblIncidentStatusIBranchId { get; set; }

    [Column("_rtblIncidentStatus_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentStatusDCreatedDate { get; set; }

    [Column("_rtblIncidentStatus_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentStatusDModifiedDate { get; set; }

    [Column("_rtblIncidentStatus_iCreatedBranchID")]
    public int? RtblIncidentStatusICreatedBranchId { get; set; }

    [Column("_rtblIncidentStatus_iModifiedBranchID")]
    public int? RtblIncidentStatusIModifiedBranchId { get; set; }

    [Column("_rtblIncidentStatus_iCreatedAgentID")]
    public int? RtblIncidentStatusICreatedAgentId { get; set; }

    [Column("_rtblIncidentStatus_iModifiedAgentID")]
    public int? RtblIncidentStatusIModifiedAgentId { get; set; }

    [Column("_rtblIncidentStatus_iChangeSetID")]
    public int? RtblIncidentStatusIChangeSetId { get; set; }

    [Column("_rtblIncidentStatus_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentStatusChecksum { get; set; }
}
