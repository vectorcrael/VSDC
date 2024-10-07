using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidents")]
[Index("RtblIncidentsChecksum", Name = "idx__rtblIncidents__rtblIncidents_Checksum")]
[Index("RtblIncidentsIChangeSetId", Name = "idx__rtblIncidents_iChangeSetID")]
[Index("RtblIncidentsDModifiedDate", Name = "idx_rtblIncidents_dModifiedDate")]
[Index("RtblIncidentsIBranchId", Name = "idx_rtblIncidents_iBranchID")]
public partial class RtblIncident
{
    [Key]
    [Column("idIncidents")]
    public int IdIncidents { get; set; }

    [Column("dCreated", TypeName = "datetime")]
    public DateTime DCreated { get; set; }

    [Column("dLastModified", TypeName = "datetime")]
    public DateTime DLastModified { get; set; }

    [Column("iClassID")]
    public int IClassId { get; set; }

    [Column("iIncidentStatusID")]
    public int IIncidentStatusId { get; set; }

    [Column("bRequireAck")]
    public bool BRequireAck { get; set; }

    [Column("iDebtorID")]
    public int IDebtorId { get; set; }

    [Column("iPersonID")]
    public int IPersonId { get; set; }

    [Column("iIncidentCatID")]
    public int? IIncidentCatId { get; set; }

    [Column("cOurRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COurRef { get; set; }

    [Column("cYourRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CYourRef { get; set; }

    [Column("cOutline")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? COutline { get; set; }

    [Column("iPriorityID")]
    public int IPriorityId { get; set; }

    [Column("iEscalateGrpID")]
    public int IEscalateGrpId { get; set; }

    [Column("iAgentGroupID")]
    public int IAgentGroupId { get; set; }

    [Column("iCurrentAgentID")]
    public int ICurrentAgentId { get; set; }

    [Column("iContractTxID")]
    public int IContractTxId { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iPrivNode")]
    public int? IPrivNode { get; set; }

    [Column("iIncidentTypeID")]
    public int IIncidentTypeId { get; set; }

    [Column("dDueBy", TypeName = "datetime")]
    public DateTime? DDueBy { get; set; }

    [Column("iDuration")]
    public int? IDuration { get; set; }

    [Column("iContractID")]
    public int? IContractId { get; set; }

    [Column("cChangeLog", TypeName = "text")]
    public string? CChangeLog { get; set; }

    [Column("iIncidentTypeGroupID")]
    public int? IIncidentTypeGroupId { get; set; }

    [Column("iWorkflowID")]
    public int? IWorkflowId { get; set; }

    [Column("iWorkflowStatusID")]
    public int? IWorkflowStatusId { get; set; }

    [Column("bHasBeenRejected")]
    public bool BHasBeenRejected { get; set; }

    [Column("iSupplierID")]
    public int? ISupplierId { get; set; }

    [Column("iFixedAssetID")]
    public int? IFixedAssetId { get; set; }

    [Column("iEmployeeID")]
    public int? IEmployeeId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iJobCostingID")]
    public int? IJobCostingId { get; set; }

    [Column("iProspectID")]
    public int IProspectId { get; set; }

    [Column("iOpportunityID")]
    public int IOpportunityId { get; set; }

    [Column("iPOInvoiceID")]
    public int IPoinvoiceId { get; set; }

    [Column("bPOViewed")]
    public bool BPoviewed { get; set; }

    [Column("iRequisitionID")]
    public int IRequisitionId { get; set; }

    [Column("_rtblIncidents_iBranchID")]
    public int? RtblIncidentsIBranchId { get; set; }

    [Column("_rtblIncidents_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentsDCreatedDate { get; set; }

    [Column("_rtblIncidents_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentsDModifiedDate { get; set; }

    [Column("_rtblIncidents_iCreatedBranchID")]
    public int? RtblIncidentsICreatedBranchId { get; set; }

    [Column("_rtblIncidents_iModifiedBranchID")]
    public int? RtblIncidentsIModifiedBranchId { get; set; }

    [Column("_rtblIncidents_iCreatedAgentID")]
    public int? RtblIncidentsICreatedAgentId { get; set; }

    [Column("_rtblIncidents_iModifiedAgentID")]
    public int? RtblIncidentsIModifiedAgentId { get; set; }

    [Column("_rtblIncidents_iChangeSetID")]
    public int? RtblIncidentsIChangeSetId { get; set; }

    [Column("iLinkID")]
    public int? ILinkId { get; set; }

    [Column("iRfqID")]
    public int? IRfqId { get; set; }

    [Column("iSIMReqID")]
    public int? ISimreqId { get; set; }

    [Column("_rtblIncidents_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentsChecksum { get; set; }
}
