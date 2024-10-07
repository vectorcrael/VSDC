using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentAction")]
[Index("RtblIncidentActionChecksum", Name = "idx__rtblIncidentAction__rtblIncidentAction_Checksum")]
[Index("RtblIncidentActionIChangeSetId", Name = "idx__rtblIncidentAction_iChangeSetID")]
[Index("RtblIncidentActionDModifiedDate", Name = "idx_rtblIncidentAction_dModifiedDate")]
[Index("RtblIncidentActionIBranchId", Name = "idx_rtblIncidentAction_iBranchID")]
public partial class RtblIncidentAction
{
    [Key]
    [Column("idIncidentAction")]
    public int IdIncidentAction { get; set; }

    [Column("cDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cPDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CPdescription { get; set; }

    [Column("_rtblIncidentAction_iBranchID")]
    public int? RtblIncidentActionIBranchId { get; set; }

    [Column("_rtblIncidentAction_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentActionDCreatedDate { get; set; }

    [Column("_rtblIncidentAction_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentActionDModifiedDate { get; set; }

    [Column("_rtblIncidentAction_iCreatedBranchID")]
    public int? RtblIncidentActionICreatedBranchId { get; set; }

    [Column("_rtblIncidentAction_iModifiedBranchID")]
    public int? RtblIncidentActionIModifiedBranchId { get; set; }

    [Column("_rtblIncidentAction_iCreatedAgentID")]
    public int? RtblIncidentActionICreatedAgentId { get; set; }

    [Column("_rtblIncidentAction_iModifiedAgentID")]
    public int? RtblIncidentActionIModifiedAgentId { get; set; }

    [Column("_rtblIncidentAction_iChangeSetID")]
    public int? RtblIncidentActionIChangeSetId { get; set; }

    [Column("_rtblIncidentAction_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentActionChecksum { get; set; }
}
