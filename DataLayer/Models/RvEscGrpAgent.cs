using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvEscGrpAgent
{
    [Column("AgentID")]
    public int? AgentId { get; set; }

    [Column("idEscalateGrpMembers")]
    public int IdEscalateGrpMembers { get; set; }

    [Column("iEscalateGrpID")]
    public int IEscalateGrpId { get; set; }

    [Column("iAgentGroupID")]
    public int IAgentGroupId { get; set; }

    [Column("iSequence")]
    public int ISequence { get; set; }

    [Column("iEscalateMins")]
    public int IEscalateMins { get; set; }

    [Column("_rtblEscalateGrpMembers_iBranchID")]
    public int? RtblEscalateGrpMembersIBranchId { get; set; }

    [Column("_rtblEscalateGrpMembers_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblEscalateGrpMembersDCreatedDate { get; set; }

    [Column("_rtblEscalateGrpMembers_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblEscalateGrpMembersDModifiedDate { get; set; }

    [Column("_rtblEscalateGrpMembers_iCreatedBranchID")]
    public int? RtblEscalateGrpMembersICreatedBranchId { get; set; }

    [Column("_rtblEscalateGrpMembers_iModifiedBranchID")]
    public int? RtblEscalateGrpMembersIModifiedBranchId { get; set; }

    [Column("_rtblEscalateGrpMembers_iCreatedAgentID")]
    public int? RtblEscalateGrpMembersICreatedAgentId { get; set; }

    [Column("_rtblEscalateGrpMembers_iModifiedAgentID")]
    public int? RtblEscalateGrpMembersIModifiedAgentId { get; set; }

    [Column("_rtblEscalateGrpMembers_iChangeSetID")]
    public int? RtblEscalateGrpMembersIChangeSetId { get; set; }

    [Column("_rtblEscalateGrpMembers_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblEscalateGrpMembersChecksum { get; set; }

    [Column("idAgents")]
    public int? IdAgents { get; set; }

    [Column("bSysAccount")]
    public bool? BSysAccount { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cPassword")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CPassword { get; set; }

    [Column("cFirstName")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CFirstName { get; set; }

    [Column("cInitials")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CInitials { get; set; }

    [Column("cLastName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CLastName { get; set; }

    [Column("cTitle")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTitle { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cTelWork")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelWork { get; set; }

    [Column("cTelFax")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelFax { get; set; }

    [Column("cTelMobile")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelMobile { get; set; }

    [Column("cTelHome")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelHome { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [Column("cComments")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CComments { get; set; }

    [Column("cAddressStreet")]
    [StringLength(512)]
    [Unicode(false)]
    public string? CAddressStreet { get; set; }

    [Column("cAddressPOBox")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAddressPobox { get; set; }

    [Column("cAddressCity")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAddressCity { get; set; }

    [Column("cAddressState")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAddressState { get; set; }

    [Column("cAddressZip")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CAddressZip { get; set; }

    [Column("cAddressCountry")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAddressCountry { get; set; }

    [Column("bCanAssign")]
    public bool? BCanAssign { get; set; }

    [Column("bPwdCanChange")]
    public bool? BPwdCanChange { get; set; }

    [Column("bPwdMustChange")]
    public bool? BPwdMustChange { get; set; }

    [Column("bPwdChangeEvery")]
    public bool? BPwdChangeEvery { get; set; }

    [Column("iPwdChangeDays")]
    public int? IPwdChangeDays { get; set; }

    [Column("dPwdLastChange", TypeName = "smalldatetime")]
    public DateTime? DPwdLastChange { get; set; }

    [Column("cPwdRemind")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CPwdRemind { get; set; }

    [Column("bAgentOutOffice")]
    public bool? BAgentOutOffice { get; set; }

    [Column("bExitWarning")]
    public bool? BExitWarning { get; set; }

    [Column("bCanSetOutOfOffice")]
    public bool? BCanSetOutOfOffice { get; set; }

    [Column("bKnowledgeBaseWarning")]
    public bool? BKnowledgeBaseWarning { get; set; }

    [Column("bNewIncidentNotification")]
    public bool? BNewIncidentNotification { get; set; }

    [Column("bUseDefaultTree")]
    public bool? BUseDefaultTree { get; set; }

    [Column("bAutoSpellCheck")]
    public bool? BAutoSpellCheck { get; set; }

    [Column("iDefIncidentTypeGroupID")]
    public int? IDefIncidentTypeGroupId { get; set; }

    [Column("iDefTillId")]
    public int? IDefTillId { get; set; }

    [Column("iDefCashAccount")]
    public int? IDefCashAccount { get; set; }

    [Column("iDefWhseId")]
    public int? IDefWhseId { get; set; }

    [Column("iNotifyEscalateMinutes")]
    public int? INotifyEscalateMinutes { get; set; }

    [Column("iNotifyDueMinutes")]
    public int? INotifyDueMinutes { get; set; }

    [Column("bForceThisWarehouse")]
    public bool? BForceThisWarehouse { get; set; }

    [Column("bAgentActive")]
    public bool? BAgentActive { get; set; }

    [Column("bCBAgNoneVisible")]
    public bool? BCbagNoneVisible { get; set; }

    [Column("bCBAgAllVisible")]
    public bool? BCbagAllVisible { get; set; }

    [Column("bJRAgNoneVisible")]
    public bool? BJragNoneVisible { get; set; }

    [Column("bJRAgAllVisible")]
    public bool? BJragAllVisible { get; set; }

    [Column("bCBUseGrpDefaults")]
    public bool? BCbuseGrpDefaults { get; set; }

    [Column("bJRUseGrpDefaults")]
    public bool? BJruseGrpDefaults { get; set; }

    [Column("bCBAgOwnVisible")]
    public bool? BCbagOwnVisible { get; set; }

    [Column("bJRAgOwnVisible")]
    public bool? BJragOwnVisible { get; set; }

    [Column("iPOAuthType")]
    public int? IPoauthType { get; set; }

    [Column("iPOIncidentTypeID")]
    public int? IPoincidentTypeId { get; set; }

    [Column("bPOExclusive")]
    public bool? BPoexclusive { get; set; }

    [Column("fPOLimit")]
    public double? FPolimit { get; set; }

    [Column("bPOUseGrpDefaults")]
    public bool? BPouseGrpDefaults { get; set; }

    [Column("cAccessPurchaseWhIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessPurchaseWhIdlst { get; set; }

    [Column("cAccessSalesWhIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessSalesWhIdlst { get; set; }

    [Column("cAccessOtherTxWhIDList")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessOtherTxWhIdlist { get; set; }

    [Column("cAccessPurchaseWhChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessPurchaseWhChkLstInd { get; set; }

    [Column("cAccessSalesWhChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessSalesWhChkLstInd { get; set; }

    [Column("cAccessOtherTxWhChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessOtherTxWhChkLstInd { get; set; }

    [Column("iDefProjectID")]
    public int? IDefProjectId { get; set; }

    [Column("cAccessProjectIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessProjectIdlst { get; set; }

    [Column("cAccessProjectChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessProjectChkLstInd { get; set; }

    [Column("iDefRepID")]
    public int? IDefRepId { get; set; }

    [Column("cAccessRepIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessRepIdlst { get; set; }

    [Column("cAccessRepChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessRepChkLstInd { get; set; }

    [Column("_rtblAgents_iBranchID")]
    public int? RtblAgentsIBranchId { get; set; }

    [Column("_rtblAgents_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblAgentsDCreatedDate { get; set; }

    [Column("_rtblAgents_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblAgentsDModifiedDate { get; set; }

    [Column("_rtblAgents_iCreatedBranchID")]
    public int? RtblAgentsICreatedBranchId { get; set; }

    [Column("_rtblAgents_iModifiedBranchID")]
    public int? RtblAgentsIModifiedBranchId { get; set; }

    [Column("_rtblAgents_iCreatedAgentID")]
    public int? RtblAgentsICreatedAgentId { get; set; }

    [Column("_rtblAgents_iModifiedAgentID")]
    public int? RtblAgentsIModifiedAgentId { get; set; }

    [Column("_rtblAgents_iChangeSetID")]
    public int? RtblAgentsIChangeSetId { get; set; }

    [Column("Max_LDisc")]
    public double? MaxLdisc { get; set; }

    [Column("Max_Disc")]
    public double? MaxDisc { get; set; }

    [Column("cOperatorCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COperatorCode { get; set; }

    [Column("cOperatorPassword")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COperatorPassword { get; set; }

    [Column("cOperatorNewPassword")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COperatorNewPassword { get; set; }

    [Column("cAccessBranchIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessBranchIdlst { get; set; }

    [Column("cAccessBranchChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessBranchChkLstInd { get; set; }

    [Column("iDocketInputMode")]
    public int? IDocketInputMode { get; set; }

    [Column("cOperatorCodePOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COperatorCodePos { get; set; }

    [Column("cOperatorPasswordPOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COperatorPasswordPos { get; set; }

    [Column("cOperatorNewPasswordPOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COperatorNewPasswordPos { get; set; }

    [Column("bCanChangeSessionDate")]
    public bool? BCanChangeSessionDate { get; set; }

    [Column("bQuoteAir")]
    public bool? BQuoteAir { get; set; }

    [Column("cEFTOperatorCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CEftoperatorCode { get; set; }

    [Column("bSupervisorAgent")]
    public bool? BSupervisorAgent { get; set; }

    [Column("fDefMax_LDisc")]
    public double? FDefMaxLdisc { get; set; }

    [Column("fDefMax_Disc")]
    public double? FDefMaxDisc { get; set; }

    [Column("bLockedOut")]
    public bool? BLockedOut { get; set; }

    [Column("cAccessARGroupIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessArgroupIdlst { get; set; }

    [Column("cAccessARGroupChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessArgroupChkLstInd { get; set; }

    [Column("bIncludeARNoGroups")]
    public bool? BIncludeArnoGroups { get; set; }

    [Column("bApplyARGroupsToEnqRep")]
    public bool? BApplyArgroupsToEnqRep { get; set; }

    [Column("cAccessAPGroupIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessApgroupIdlst { get; set; }

    [Column("cAccessAPGroupChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessApgroupChkLstInd { get; set; }

    [Column("bIncludeAPNoGroups")]
    public bool? BIncludeApnoGroups { get; set; }

    [Column("bApplyAPGroupsToEnqRep")]
    public bool? BApplyApgroupsToEnqRep { get; set; }

    [Column("vbBiometric")]
    [Unicode(false)]
    public string? VbBiometric { get; set; }

    [Column("bApplyAccessRepsToReports")]
    public bool? BApplyAccessRepsToReports { get; set; }

    [Column("bApplyAccessProjectsToReports")]
    public bool? BApplyAccessProjectsToReports { get; set; }

    [Column("idPOSMenuSetup")]
    public int? IdPosmenuSetup { get; set; }

    [Column("bAgentIsBuyer")]
    public bool? BAgentIsBuyer { get; set; }

    [Column("bUseBiometric")]
    public bool? BUseBiometric { get; set; }

    public int? FiscalPrinterId { get; set; }

    public int? FiscalDeviceId { get; set; }

    [Column("cAccessDocCatGroupIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessDocCatGroupIdlst { get; set; }

    [Column("cAccessDocCatGroupChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessDocCatGroupChkLstInd { get; set; }

    [Column("iDefDocCatID")]
    public int? IDefDocCatId { get; set; }

    [Column("cAccessDocCatIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessDocCatIdlst { get; set; }

    [Column("cAccessDocCatChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessDocCatChkLstInd { get; set; }

    [Column("cAccessIncidentTypeGroupIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessIncidentTypeGroupIdlst { get; set; }

    [Column("cAccessIncidentTypeGroupChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessIncidentTypeGroupChkLstInd { get; set; }

    [Column("cAccessIncidentTypeIDLst")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAccessIncidentTypeIdlst { get; set; }

    [Column("cAccessIncidentTypeChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAccessIncidentTypeChkLstInd { get; set; }

    [Column("_rtblAgents_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblAgentsChecksum { get; set; }

    [Column("cSagePayUserName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSagePayUserName { get; set; }

    [Column("cSagePayPassword")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CSagePayPassword { get; set; }

    [Column("cSagePayPIN")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CSagePayPin { get; set; }

    [Column("iAgentLoginScreen")]
    public int? IAgentLoginScreen { get; set; }

    [Column("iGroupID")]
    public int? IGroupId { get; set; }
}
