using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblOpportunity")]
[Index("RtblOpportunityChecksum", Name = "idx__rtblOpportunity__rtblOpportunity_Checksum")]
[Index("RtblOpportunityIChangeSetId", Name = "idx__rtblOpportunity_iChangeSetID")]
[Index("RtblOpportunityDModifiedDate", Name = "idx_rtblOpportunity_dModifiedDate")]
[Index("RtblOpportunityIBranchId", Name = "idx_rtblOpportunity_iBranchID")]
public partial class RtblOpportunity
{
    [Key]
    [Column("IDOpportunity")]
    public int Idopportunity { get; set; }

    [Column("cOpportunityNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COpportunityNumber { get; set; }

    [Column("iClientID")]
    public int IClientId { get; set; }

    [Column("iProspectID")]
    public int IProspectId { get; set; }

    [Column("iPeopleID")]
    public int IPeopleId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("iOpportunityStageID")]
    public int IOpportunityStageId { get; set; }

    [Column("iOpportunityStatusID")]
    public int IOpportunityStatusId { get; set; }

    [Column("iOpportunitySourceID")]
    public int IOpportunitySourceId { get; set; }

    [Column("iOppSourceClientID")]
    public int IOppSourceClientId { get; set; }

    [Column("iOppSourceSupplierID")]
    public int IOppSourceSupplierId { get; set; }

    [Column("iOppSourceAgentID")]
    public int IOppSourceAgentId { get; set; }

    [Column("dDateStart", TypeName = "datetime")]
    public DateTime? DDateStart { get; set; }

    [Column("dDateClose", TypeName = "datetime")]
    public DateTime? DDateClose { get; set; }

    [Column("dDateActualClose", TypeName = "datetime")]
    public DateTime? DDateActualClose { get; set; }

    [Column("fClosedAmount")]
    public double? FClosedAmount { get; set; }

    [Column("fProbabilityPerc")]
    public double? FProbabilityPerc { get; set; }

    [Column("bPublic")]
    public bool BPublic { get; set; }

    [Column("iActiveInvNumID")]
    public int IActiveInvNumId { get; set; }

    [Column("fForecastAmount")]
    public double? FForecastAmount { get; set; }

    [Column("fBudgetedAmount")]
    public double? FBudgetedAmount { get; set; }

    [Column("cOpportunityDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? COpportunityDescription { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("_rtblOpportunity_iBranchID")]
    public int? RtblOpportunityIBranchId { get; set; }

    [Column("_rtblOpportunity_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityDCreatedDate { get; set; }

    [Column("_rtblOpportunity_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityDModifiedDate { get; set; }

    [Column("_rtblOpportunity_iCreatedBranchID")]
    public int? RtblOpportunityICreatedBranchId { get; set; }

    [Column("_rtblOpportunity_iModifiedBranchID")]
    public int? RtblOpportunityIModifiedBranchId { get; set; }

    [Column("_rtblOpportunity_iCreatedAgentID")]
    public int? RtblOpportunityICreatedAgentId { get; set; }

    [Column("_rtblOpportunity_iModifiedAgentID")]
    public int? RtblOpportunityIModifiedAgentId { get; set; }

    [Column("_rtblOpportunity_iChangeSetID")]
    public int? RtblOpportunityIChangeSetId { get; set; }

    [Column("_rtblOpportunity_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblOpportunityChecksum { get; set; }
}
