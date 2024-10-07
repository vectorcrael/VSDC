using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidents_Archive")]
[Index("RtblIncidentsArchiveChecksum", Name = "idx__rtblIncidents_Archive__rtblIncidents_Archive_Checksum")]
[Index("RtblIncidentsArchiveIChangeSetId", Name = "idx__rtblIncidents_Archive_iChangeSetID")]
[Index("RtblIncidentsArchiveDModifiedDate", Name = "idx_rtblIncidents_Archive_dModifiedDate")]
[Index("RtblIncidentsArchiveIBranchId", Name = "idx_rtblIncidents_Archive_iBranchID")]
public partial class RtblIncidentsArchive
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

    [Column("iRequisitionID")]
    public int IRequisitionId { get; set; }

    [Column("bPOViewed")]
    public bool? BPoviewed { get; set; }

    [Column("iPOInvoiceID")]
    public int IPoinvoiceId { get; set; }

    [Column("_rtblIncidents_Archive_iBranchID")]
    public int? RtblIncidentsArchiveIBranchId { get; set; }

    [Column("_rtblIncidents_Archive_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentsArchiveDCreatedDate { get; set; }

    [Column("_rtblIncidents_Archive_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentsArchiveDModifiedDate { get; set; }

    [Column("_rtblIncidents_Archive_iCreatedBranchID")]
    public int? RtblIncidentsArchiveICreatedBranchId { get; set; }

    [Column("_rtblIncidents_Archive_iModifiedBranchID")]
    public int? RtblIncidentsArchiveIModifiedBranchId { get; set; }

    [Column("_rtblIncidents_Archive_iCreatedAgentID")]
    public int? RtblIncidentsArchiveICreatedAgentId { get; set; }

    [Column("_rtblIncidents_Archive_iModifiedAgentID")]
    public int? RtblIncidentsArchiveIModifiedAgentId { get; set; }

    [Column("_rtblIncidents_Archive_iChangeSetID")]
    public int? RtblIncidentsArchiveIChangeSetId { get; set; }

    [Column("iLinkID")]
    public int? ILinkId { get; set; }

    [Column("iRfqID")]
    public int? IRfqId { get; set; }

    [Column("iSIMReqID")]
    public int? ISimreqId { get; set; }

    [Column("_rtblIncidents_Archive_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentsArchiveChecksum { get; set; }
}
