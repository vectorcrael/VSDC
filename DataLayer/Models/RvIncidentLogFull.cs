using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvIncidentLogFull
{
    [Column("IncidentID")]
    public int? IncidentId { get; set; }

    [Column("IncidentClassID")]
    public int? IncidentClassId { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? IncidentClassDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IncidentCreatedDateStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IncidentLastModifiedDateStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueByDate { get; set; }

    [Column("IncidentStatusID")]
    public int? IncidentStatusId { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? IncidentStatusDescription { get; set; }

    public bool? RequireAck { get; set; }

    public int? DurationSecs { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InternalReference { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? YourReference { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string? IncidentOutline { get; set; }

    [Column("PriorityID")]
    public int? PriorityId { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? PriorityDescription { get; set; }

    [Column("EscalateGroupID")]
    public int? EscalateGroupId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? EscalateGroupName { get; set; }

    [Column("AssignedGroupID")]
    public int? AssignedGroupId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AssignedGroupName { get; set; }

    [Column("CurrentAgentID")]
    public int? CurrentAgentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CurrentAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? CurrentAgentFullName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CurrentAgentTelWork { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CurrentAgentTelMobile { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? CurrentAgentEmail { get; set; }

    [Column("DebtorID")]
    public int? DebtorId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DebtorAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DebtorName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DebtorTelephone { get; set; }

    [Column("CreditorID")]
    public int? CreditorId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CreditorAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CreditorName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? CreditorTelephone { get; set; }

    [Column("WorkerID")]
    public int? WorkerId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkerCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkerName { get; set; }

    [Column("FixedAssetID")]
    public int? FixedAssetId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FixedAssetCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? FixedAssetDescription { get; set; }

    [Column("ProjectID")]
    public int? ProjectId { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [Column("JobCostingID")]
    public int? JobCostingId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobCostingCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? JobCostingName { get; set; }

    [Column("PersonID")]
    public int? PersonId { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? PersonName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PersonTelWork { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PersonTelMobile { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? PersonEmail { get; set; }

    [Column("IncidentCatID")]
    public int? IncidentCatId { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? IncidentCatDescription { get; set; }

    [Column("IncidentTypeGroupID")]
    public int? IncidentTypeGroupId { get; set; }

    [Column("ITGrpName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ItgrpName { get; set; }

    [Column("IncidentTypeID")]
    public int? IncidentTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IncidentTypeDescription { get; set; }

    [Column("WorkflowID")]
    public int? WorkflowId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? WorkflowName { get; set; }

    [Column("WorkflowStatusID")]
    public int? WorkflowStatusId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkflowStatusCode { get; set; }

    [Column("ContractID")]
    public int? ContractId { get; set; }

    [Column("ContractTxID")]
    public int? ContractTxId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractReference { get; set; }

    [Column("StockID")]
    public int? StockId { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? StockCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StockDescription1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StockDescription2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StockDescription3 { get; set; }

    [Column("idEvent")]
    public int? IdEvent { get; set; }

    [Column("iHasDocs")]
    public int? IHasDocs { get; set; }

    [Column("ProspectID")]
    public int? ProspectId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProspectCompanyName { get; set; }

    [Column("OpportunityID")]
    public int? OpportunityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OpportunityNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OpportunityDescription { get; set; }

    [Column("iPOInvoiceID")]
    public int? IPoinvoiceId { get; set; }

    [Column("iRequisitionID")]
    public int? IRequisitionId { get; set; }

    [Column("iLinkID")]
    public int? ILinkId { get; set; }

    [Column("iRfqID")]
    public int? IRfqId { get; set; }

    [Column("iSIMReqID")]
    public int? ISimreqId { get; set; }

    [Column("MasterProjectID")]
    public int? MasterProjectId { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? MasterProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MasterProjectName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? MasterProjectDescription { get; set; }

    [Column("_rtblIncidents_iBranchID")]
    public int? RtblIncidentsIBranchId { get; set; }

    [Column("IncidentLogID")]
    public int? IncidentLogId { get; set; }

    [Column(TypeName = "text")]
    public string? IncidentActionResolution { get; set; }

    [Column("dActionDate", TypeName = "datetime")]
    public DateTime? DActionDate { get; set; }

    [Column("ActionTypeID")]
    public int? ActionTypeId { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? ActionTypeDescription { get; set; }

    [Column("ActionTypePDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? ActionTypePdescription { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ActionReceiverText { get; set; } = null!;

    [Column("ActionByAgentID")]
    public int? ActionByAgentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActionByAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionByAgentFullName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionByAgentTelWork { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionByAgentTelMobile { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionByAgentEmail { get; set; }

    public bool? ProxyAction { get; set; }

    [Column("ActionToAgentID")]
    public int? ActionToAgentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActionToAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionToAgentFullName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionToAgentTelWork { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionToAgentTelMobile { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionToAgentEmail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RejectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RejectReason { get; set; }

    [Column("_rtblIncidentLog_iBranchID")]
    public int? RtblIncidentLogIBranchId { get; set; }
}
