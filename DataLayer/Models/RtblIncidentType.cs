﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentType")]
[Index("RtblIncidentTypeChecksum", Name = "idx__rtblIncidentType__rtblIncidentType_Checksum")]
[Index("RtblIncidentTypeIChangeSetId", Name = "idx__rtblIncidentType_iChangeSetID")]
[Index("RtblIncidentTypeDModifiedDate", Name = "idx_rtblIncidentType_dModifiedDate")]
[Index("RtblIncidentTypeIBranchId", Name = "idx_rtblIncidentType_iBranchID")]
public partial class RtblIncidentType
{
    [Key]
    [Column("idIncidentType")]
    public int IdIncidentType { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("iEscGroupID")]
    public int? IEscGroupId { get; set; }

    [Column("bAllowOverride")]
    public bool BAllowOverride { get; set; }

    [Column("bRequireContract")]
    public bool BRequireContract { get; set; }

    [Column("iIncidentTypeGroupID")]
    public int? IIncidentTypeGroupId { get; set; }

    [Column("iWorkflowID")]
    public int? IWorkflowId { get; set; }

    [Column("bAllowOverrideIncidentType")]
    public bool BAllowOverrideIncidentType { get; set; }

    [Column("bPOIncidentType")]
    public bool BPoincidentType { get; set; }

    [Column("cDefaultOutline")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CDefaultOutline { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_rtblIncidentType_iBranchID")]
    public int? RtblIncidentTypeIBranchId { get; set; }

    [Column("_rtblIncidentType_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentTypeDCreatedDate { get; set; }

    [Column("_rtblIncidentType_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentTypeDModifiedDate { get; set; }

    [Column("_rtblIncidentType_iCreatedBranchID")]
    public int? RtblIncidentTypeICreatedBranchId { get; set; }

    [Column("_rtblIncidentType_iModifiedBranchID")]
    public int? RtblIncidentTypeIModifiedBranchId { get; set; }

    [Column("_rtblIncidentType_iCreatedAgentID")]
    public int? RtblIncidentTypeICreatedAgentId { get; set; }

    [Column("_rtblIncidentType_iModifiedAgentID")]
    public int? RtblIncidentTypeIModifiedAgentId { get; set; }

    [Column("_rtblIncidentType_iChangeSetID")]
    public int? RtblIncidentTypeIChangeSetId { get; set; }

    [Column("_rtblIncidentType_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentTypeChecksum { get; set; }
}
