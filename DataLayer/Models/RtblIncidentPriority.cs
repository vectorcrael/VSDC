using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentPriority")]
[Index("RtblIncidentPriorityChecksum", Name = "idx__rtblIncidentPriority__rtblIncidentPriority_Checksum")]
[Index("RtblIncidentPriorityIChangeSetId", Name = "idx__rtblIncidentPriority_iChangeSetID")]
[Index("RtblIncidentPriorityDModifiedDate", Name = "idx_rtblIncidentPriority_dModifiedDate")]
[Index("RtblIncidentPriorityIBranchId", Name = "idx_rtblIncidentPriority_iBranchID")]
public partial class RtblIncidentPriority
{
    [Key]
    [Column("idIncidentPriority")]
    public int IdIncidentPriority { get; set; }

    [Column("cDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iColor")]
    public int? IColor { get; set; }

    [Column("bDefault")]
    public bool? BDefault { get; set; }

    [Column("_rtblIncidentPriority_iBranchID")]
    public int? RtblIncidentPriorityIBranchId { get; set; }

    [Column("_rtblIncidentPriority_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentPriorityDCreatedDate { get; set; }

    [Column("_rtblIncidentPriority_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentPriorityDModifiedDate { get; set; }

    [Column("_rtblIncidentPriority_iCreatedBranchID")]
    public int? RtblIncidentPriorityICreatedBranchId { get; set; }

    [Column("_rtblIncidentPriority_iModifiedBranchID")]
    public int? RtblIncidentPriorityIModifiedBranchId { get; set; }

    [Column("_rtblIncidentPriority_iCreatedAgentID")]
    public int? RtblIncidentPriorityICreatedAgentId { get; set; }

    [Column("_rtblIncidentPriority_iModifiedAgentID")]
    public int? RtblIncidentPriorityIModifiedAgentId { get; set; }

    [Column("_rtblIncidentPriority_iChangeSetID")]
    public int? RtblIncidentPriorityIChangeSetId { get; set; }

    [Column("_rtblIncidentPriority_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentPriorityChecksum { get; set; }
}
