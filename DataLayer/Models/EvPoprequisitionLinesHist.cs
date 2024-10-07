using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvPoprequisitionLinesHist
{
    [Column("idPOPRequisitionLinesHist")]
    public int IdPoprequisitionLinesHist { get; set; }

    [Column("iRequisitionHistID")]
    public int IRequisitionHistId { get; set; }

    [Column("iRequisitionID")]
    public int IRequisitionId { get; set; }

    [Column("iModuleID")]
    public int IModuleId { get; set; }

    [Column("iAccountID")]
    public int IAccountId { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iSupplierID")]
    public int ISupplierId { get; set; }

    [Column("fQuantity")]
    public double FQuantity { get; set; }

    [Column("fExpectedPrice")]
    public double FExpectedPrice { get; set; }

    [Column("dExpectedDate", TypeName = "datetime")]
    public DateTime? DExpectedDate { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("iJobID")]
    public int IJobId { get; set; }

    [Column("iIncidentTypeID")]
    public int IIncidentTypeId { get; set; }

    [Column("iEscalateGroupID")]
    public int IEscalateGroupId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("iLineStatus")]
    public int ILineStatus { get; set; }

    [Column("iIncidentID")]
    public int IIncidentId { get; set; }

    [Column("iPOInvoiceID")]
    public int IPoinvoiceId { get; set; }

    [Column("fActualPrice")]
    public double? FActualPrice { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fExpectedPriceForeign")]
    public double? FExpectedPriceForeign { get; set; }

    [Column("fActualPriceForeign")]
    public double? FActualPriceForeign { get; set; }

    [Column("dApprovalDate", TypeName = "datetime")]
    public DateTime? DApprovalDate { get; set; }

    [Column("_etblPOPRequisitionLinesHist_iBranchID")]
    public int? EtblPoprequisitionLinesHistIBranchId { get; set; }

    [Column("_etblPOPRequisitionLinesHist_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionLinesHistDCreatedDate { get; set; }

    [Column("_etblPOPRequisitionLinesHist_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionLinesHistDModifiedDate { get; set; }

    [Column("_etblPOPRequisitionLinesHist_iCreatedBranchID")]
    public int? EtblPoprequisitionLinesHistICreatedBranchId { get; set; }

    [Column("_etblPOPRequisitionLinesHist_iModifiedBranchID")]
    public int? EtblPoprequisitionLinesHistIModifiedBranchId { get; set; }

    [Column("_etblPOPRequisitionLinesHist_iCreatedAgentID")]
    public int? EtblPoprequisitionLinesHistICreatedAgentId { get; set; }

    [Column("_etblPOPRequisitionLinesHist_iModifiedAgentID")]
    public int? EtblPoprequisitionLinesHistIModifiedAgentId { get; set; }

    [Column("_etblPOPRequisitionLinesHist_iChangeSetID")]
    public int? EtblPoprequisitionLinesHistIChangeSetId { get; set; }

    [Column("iActionAgentID")]
    public int? IActionAgentId { get; set; }

    [Column("_etblPOPRequisitionLinesHist_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPoprequisitionLinesHistChecksum { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Module { get; set; } = null!;

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ItemDescription { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? LineStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SupplierAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SupplierName { get; set; }

    public int? ProjectLink { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(41)]
    [Unicode(false)]
    public string? MasterSubProject { get; set; }

    public int? ProjectLevel { get; set; }

    public int? SubProjectOfLink { get; set; }

    [Column("Project_iBranchID")]
    public int? ProjectIBranchId { get; set; }

    [Column("Project_dCreatedDate", TypeName = "datetime")]
    public DateTime? ProjectDCreatedDate { get; set; }

    [Column("Project_dModifiedDate", TypeName = "datetime")]
    public DateTime? ProjectDModifiedDate { get; set; }

    [Column("Project_iCreatedBranchID")]
    public int? ProjectICreatedBranchId { get; set; }

    [Column("Project_iModifiedBranchID")]
    public int? ProjectIModifiedBranchId { get; set; }

    [Column("Project_iCreatedAgentID")]
    public int? ProjectICreatedAgentId { get; set; }

    [Column("Project_iModifiedAgentID")]
    public int? ProjectIModifiedAgentId { get; set; }

    [Column("Project_iChangeSetID")]
    public int? ProjectIChangeSetId { get; set; }

    [Column("Project_Checksum")]
    [MaxLength(20)]
    public byte[]? ProjectChecksum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? LineAgentDisplayName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineActionAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? LineActionAgentDisplayName { get; set; }

    [Column("cJobCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CJobCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? JobDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IncidentTypeDescription { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencySymbol { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UnitCode { get; set; }

    public double LineExpectedPriceTotal { get; set; }

    public double LineActualPriceTotal { get; set; }

    public double LineExpectedPriceForeignTotal { get; set; }

    public double LineActualPriceForeignTotal { get; set; }
}
