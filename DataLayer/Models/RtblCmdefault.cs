using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblCMDefaults")]
[Index("RtblCmdefaultsChecksum", Name = "idx__rtblCMDefaults__rtblCMDefaults_Checksum")]
[Index("RtblCmdefaultsIChangeSetId", Name = "idx__rtblCMDefaults_iChangeSetID")]
public partial class RtblCmdefault
{
    [Key]
    [Column("idCMDefaults")]
    public int IdCmdefaults { get; set; }

    [Column("iPeopleFilterStLength")]
    public int? IPeopleFilterStLength { get; set; }

    [Column("bAutoContracts")]
    public bool BAutoContracts { get; set; }

    [Column("vContractPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VContractPrefix { get; set; }

    [Column("iContractPadLength")]
    public int? IContractPadLength { get; set; }

    [Column("iContractFilterStLength")]
    public int? IContractFilterStLength { get; set; }

    [Column("vKBPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VKbprefix { get; set; }

    [Column("iKBPadLength")]
    public int? IKbpadLength { get; set; }

    [Column("vIncidentPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VIncidentPrefix { get; set; }

    [Column("iIncidentPadLength")]
    public int? IIncidentPadLength { get; set; }

    [Column("bIncDefAgentName")]
    public bool BIncDefAgentName { get; set; }

    [Column("bIncDispCustNotes")]
    public bool BIncDispCustNotes { get; set; }

    [Column("vDocStorePath")]
    [StringLength(256)]
    [Unicode(false)]
    public string? VDocStorePath { get; set; }

    [Column("bRestrictAgents")]
    public bool? BRestrictAgents { get; set; }

    [Column("bRestrictInActiveAgents")]
    public bool? BRestrictInActiveAgents { get; set; }

    [Column("bColorCodeOverDueDate")]
    public bool? BColorCodeOverDueDate { get; set; }

    [Column("iOverDueColor")]
    public int? IOverDueColor { get; set; }

    [Column("bSpellCheck")]
    public bool BSpellCheck { get; set; }

    [Column("bAutoIncidents")]
    public bool BAutoIncidents { get; set; }

    [Column("bAutoKB")]
    public bool BAutoKb { get; set; }

    [Column("iDueDateIncrement")]
    public int? IDueDateIncrement { get; set; }

    [Column("iDueTimeIncrement")]
    public int? IDueTimeIncrement { get; set; }

    [Column("bUseExpContracts")]
    public bool BUseExpContracts { get; set; }

    [Column("bUseBlockedContracts")]
    public bool BUseBlockedContracts { get; set; }

    [Column("bPostIncidentOnHoldCust")]
    public bool BPostIncidentOnHoldCust { get; set; }

    [Column("bSFAOpportunityAutoNum")]
    public bool BSfaopportunityAutoNum { get; set; }

    [Column("cSFAOpportunityNextNum")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CSfaopportunityNextNum { get; set; }

    [Column("iSFAOpportunityPadTo")]
    public int? ISfaopportunityPadTo { get; set; }

    [Column("cSFAOpportunityPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSfaopportunityPrefix { get; set; }

    [Column("iDeftOpportunityIncidentTypeID")]
    public int? IDeftOpportunityIncidentTypeId { get; set; }

    [Column("bSFAApplyAgentFilter")]
    public bool BSfaapplyAgentFilter { get; set; }

    [Column("bSFAUseSalesOrders")]
    public bool BSfauseSalesOrders { get; set; }

    [Column("iSFAReopenOppStatusID")]
    public int ISfareopenOppStatusId { get; set; }

    [Column("iSFAFilterStLength")]
    public int ISfafilterStLength { get; set; }

    [Column("_rtblCMDefaults_iBranchID")]
    public int? RtblCmdefaultsIBranchId { get; set; }

    [Column("_rtblCMDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblCmdefaultsDCreatedDate { get; set; }

    [Column("_rtblCMDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblCmdefaultsDModifiedDate { get; set; }

    [Column("_rtblCMDefaults_iCreatedBranchID")]
    public int? RtblCmdefaultsICreatedBranchId { get; set; }

    [Column("_rtblCMDefaults_iModifiedBranchID")]
    public int? RtblCmdefaultsIModifiedBranchId { get; set; }

    [Column("_rtblCMDefaults_iCreatedAgentID")]
    public int? RtblCmdefaultsICreatedAgentId { get; set; }

    [Column("_rtblCMDefaults_iModifiedAgentID")]
    public int? RtblCmdefaultsIModifiedAgentId { get; set; }

    [Column("_rtblCMDefaults_iChangeSetID")]
    public int? RtblCmdefaultsIChangeSetId { get; set; }

    [Column("bAutoEmailAssignedAgent")]
    public bool BAutoEmailAssignedAgent { get; set; }

    [Column("iDocumentFilterStLength")]
    public int IDocumentFilterStLength { get; set; }

    [Column("bSourceDocLinked")]
    public bool BSourceDocLinked { get; set; }

    [Column("iSourceDocLinkDisplay")]
    public int ISourceDocLinkDisplay { get; set; }

    [Column("_rtblCMDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblCmdefaultsChecksum { get; set; }
}
