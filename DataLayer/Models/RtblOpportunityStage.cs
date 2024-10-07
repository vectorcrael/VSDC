using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblOpportunityStage")]
[Index("RtblOpportunityStageChecksum", Name = "idx__rtblOpportunityStage__rtblOpportunityStage_Checksum")]
[Index("RtblOpportunityStageIChangeSetId", Name = "idx__rtblOpportunityStage_iChangeSetID")]
[Index("RtblOpportunityStageDModifiedDate", Name = "idx_rtblOpportunityStage_dModifiedDate")]
[Index("RtblOpportunityStageIBranchId", Name = "idx_rtblOpportunityStage_iBranchID")]
public partial class RtblOpportunityStage
{
    [Key]
    [Column("IDOpportunityStage")]
    public int IdopportunityStage { get; set; }

    [Column("cStageName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CStageName { get; set; }

    [Column("cStageDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CStageDescription { get; set; }

    [Column("iOpportunityStatusID")]
    public int? IOpportunityStatusId { get; set; }

    [Column("iStageSequence")]
    public int? IStageSequence { get; set; }

    [Column("fDefProbabilityPerc")]
    public double? FDefProbabilityPerc { get; set; }

    [Column("_rtblOpportunityStage_iBranchID")]
    public int? RtblOpportunityStageIBranchId { get; set; }

    [Column("_rtblOpportunityStage_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityStageDCreatedDate { get; set; }

    [Column("_rtblOpportunityStage_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityStageDModifiedDate { get; set; }

    [Column("_rtblOpportunityStage_iCreatedBranchID")]
    public int? RtblOpportunityStageICreatedBranchId { get; set; }

    [Column("_rtblOpportunityStage_iModifiedBranchID")]
    public int? RtblOpportunityStageIModifiedBranchId { get; set; }

    [Column("_rtblOpportunityStage_iCreatedAgentID")]
    public int? RtblOpportunityStageICreatedAgentId { get; set; }

    [Column("_rtblOpportunityStage_iModifiedAgentID")]
    public int? RtblOpportunityStageIModifiedAgentId { get; set; }

    [Column("_rtblOpportunityStage_iChangeSetID")]
    public int? RtblOpportunityStageIChangeSetId { get; set; }

    [Column("_rtblOpportunityStage_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblOpportunityStageChecksum { get; set; }
}
