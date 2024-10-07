using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblContractTemplates")]
[Index("IdContractTemplates", Name = "IX__rtblContractTemplates", IsUnique = true)]
[Index("RtblContractTemplatesChecksum", Name = "idx__rtblContractTemplates__rtblContractTemplates_Checksum")]
[Index("RtblContractTemplatesIChangeSetId", Name = "idx__rtblContractTemplates_iChangeSetID")]
[Index("RtblContractTemplatesDModifiedDate", Name = "idx_rtblContractTemplates_dModifiedDate")]
[Index("RtblContractTemplatesIBranchId", Name = "idx_rtblContractTemplates_iBranchID")]
public partial class RtblContractTemplate
{
    [Key]
    [Column("idContractTemplates")]
    public int IdContractTemplates { get; set; }

    [Column("cTemplateName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CTemplateName { get; set; } = null!;

    [Column("iDefYears")]
    public int IDefYears { get; set; }

    [Column("iDefMonths")]
    public int IDefMonths { get; set; }

    [Column("iDefDays")]
    public int IDefDays { get; set; }

    [Column("iBillType")]
    public int IBillType { get; set; }

    [Column("iTimeUnit")]
    public int ITimeUnit { get; set; }

    [Column("fAmount")]
    public double FAmount { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("bAllowOverride")]
    public bool BAllowOverride { get; set; }

    [Column("iCInvTemplateID")]
    public int? ICinvTemplateId { get; set; }

    [Column("iRRConfigurationID")]
    public int? IRrconfigurationId { get; set; }

    [Column("_rtblContractTemplates_iBranchID")]
    public int? RtblContractTemplatesIBranchId { get; set; }

    [Column("_rtblContractTemplates_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblContractTemplatesDCreatedDate { get; set; }

    [Column("_rtblContractTemplates_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblContractTemplatesDModifiedDate { get; set; }

    [Column("_rtblContractTemplates_iCreatedBranchID")]
    public int? RtblContractTemplatesICreatedBranchId { get; set; }

    [Column("_rtblContractTemplates_iModifiedBranchID")]
    public int? RtblContractTemplatesIModifiedBranchId { get; set; }

    [Column("_rtblContractTemplates_iCreatedAgentID")]
    public int? RtblContractTemplatesICreatedAgentId { get; set; }

    [Column("_rtblContractTemplates_iModifiedAgentID")]
    public int? RtblContractTemplatesIModifiedAgentId { get; set; }

    [Column("_rtblContractTemplates_iChangeSetID")]
    public int? RtblContractTemplatesIChangeSetId { get; set; }

    [Column("_rtblContractTemplates_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblContractTemplatesChecksum { get; set; }
}
