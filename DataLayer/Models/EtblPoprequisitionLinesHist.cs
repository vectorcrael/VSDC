using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPOPRequisitionLinesHist")]
[Index("EtblPoprequisitionLinesHistChecksum", Name = "idx__etblPOPRequisitionLinesHist__etblPOPRequisitionLinesHist_Checksum")]
[Index("EtblPoprequisitionLinesHistIChangeSetId", Name = "idx__etblPOPRequisitionLinesHist_iChangeSetID")]
[Index("EtblPoprequisitionLinesHistDModifiedDate", Name = "idx_etblPOPRequisitionLinesHist_dModifiedDate")]
[Index("EtblPoprequisitionLinesHistIBranchId", Name = "idx_etblPOPRequisitionLinesHist_iBranchID")]
public partial class EtblPoprequisitionLinesHist
{
    [Key]
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
}
