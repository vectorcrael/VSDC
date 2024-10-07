using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvOpportunityFull
{
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

    [StringLength(50)]
    [Unicode(false)]
    public string? CustomerProspect { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPhysicalAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPhysicalAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPhysicalAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPhysicalAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPhysicalAddress5 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerPhysicalCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPostalAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPostalAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPostalAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPostalAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CustomerPostalAddress5 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerPostalCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProspectCompanyName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPhysicalAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPhysicalAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPhysicalAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPhysicalAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPhysicalAddress5 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ProspectPhysicalCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPostalAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPostalAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPostalAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPostalAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ProspectPostalAddress5 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ProspectPostalCode { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountManager { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OpportunityStageName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OpportunityStageDescription { get; set; }

    public int? OpportunityStageSeq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OpportunityStatus { get; set; }

    public bool? OpportunityStatusIsFinal { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? OpportunitySource { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? OpportunitySourceDesc { get; set; }

    public double ExpectedValue { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Area { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AreaDescription { get; set; }
}
