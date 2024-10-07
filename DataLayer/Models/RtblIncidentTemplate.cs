using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentTemplates")]
[Index("RtblIncidentTemplatesChecksum", Name = "idx__rtblIncidentTemplates__rtblIncidentTemplates_Checksum")]
[Index("RtblIncidentTemplatesIChangeSetId", Name = "idx__rtblIncidentTemplates_iChangeSetID")]
[Index("RtblIncidentTemplatesDModifiedDate", Name = "idx_rtblIncidentTemplates_dModifiedDate")]
[Index("RtblIncidentTemplatesIBranchId", Name = "idx_rtblIncidentTemplates_iBranchID")]
public partial class RtblIncidentTemplate
{
    [Key]
    [Column("idIncidentTemplates")]
    public int IdIncidentTemplates { get; set; }

    [Column("cTemplateName")]
    [StringLength(32)]
    [Unicode(false)]
    public string CTemplateName { get; set; } = null!;

    [Column("iIncidentID")]
    public int IIncidentId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("_rtblIncidentTemplates_iBranchID")]
    public int? RtblIncidentTemplatesIBranchId { get; set; }

    [Column("_rtblIncidentTemplates_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentTemplatesDCreatedDate { get; set; }

    [Column("_rtblIncidentTemplates_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentTemplatesDModifiedDate { get; set; }

    [Column("_rtblIncidentTemplates_iCreatedBranchID")]
    public int? RtblIncidentTemplatesICreatedBranchId { get; set; }

    [Column("_rtblIncidentTemplates_iModifiedBranchID")]
    public int? RtblIncidentTemplatesIModifiedBranchId { get; set; }

    [Column("_rtblIncidentTemplates_iCreatedAgentID")]
    public int? RtblIncidentTemplatesICreatedAgentId { get; set; }

    [Column("_rtblIncidentTemplates_iModifiedAgentID")]
    public int? RtblIncidentTemplatesIModifiedAgentId { get; set; }

    [Column("_rtblIncidentTemplates_iChangeSetID")]
    public int? RtblIncidentTemplatesIChangeSetId { get; set; }

    [Column("_rtblIncidentTemplates_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentTemplatesChecksum { get; set; }
}
