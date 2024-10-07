using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPOPRequisitionLines")]
[Index("EtblPoprequisitionLinesChecksum", Name = "idx__etblPOPRequisitionLines__etblPOPRequisitionLines_Checksum")]
[Index("EtblPoprequisitionLinesIChangeSetId", Name = "idx__etblPOPRequisitionLines_iChangeSetID")]
[Index("IPoinvoiceId", Name = "idx__etblPOPRequisitionLines_iPOInvoiceID")]
[Index("EtblPoprequisitionLinesDModifiedDate", Name = "idx_etblPOPRequisitionLines_dModifiedDate")]
[Index("EtblPoprequisitionLinesIBranchId", Name = "idx_etblPOPRequisitionLines_iBranchID")]
public partial class EtblPoprequisitionLine
{
    [Key]
    [Column("idPOPRequisitionLines")]
    public int IdPoprequisitionLines { get; set; }

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
    public int? IPoinvoiceId { get; set; }

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

    [Column("_etblPOPRequisitionLines_iBranchID")]
    public int? EtblPoprequisitionLinesIBranchId { get; set; }

    [Column("_etblPOPRequisitionLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionLinesDCreatedDate { get; set; }

    [Column("_etblPOPRequisitionLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionLinesDModifiedDate { get; set; }

    [Column("_etblPOPRequisitionLines_iCreatedBranchID")]
    public int? EtblPoprequisitionLinesICreatedBranchId { get; set; }

    [Column("_etblPOPRequisitionLines_iModifiedBranchID")]
    public int? EtblPoprequisitionLinesIModifiedBranchId { get; set; }

    [Column("_etblPOPRequisitionLines_iCreatedAgentID")]
    public int? EtblPoprequisitionLinesICreatedAgentId { get; set; }

    [Column("_etblPOPRequisitionLines_iModifiedAgentID")]
    public int? EtblPoprequisitionLinesIModifiedAgentId { get; set; }

    [Column("_etblPOPRequisitionLines_iChangeSetID")]
    public int? EtblPoprequisitionLinesIChangeSetId { get; set; }

    [Column("iActionAgentID")]
    public int? IActionAgentId { get; set; }

    [Column("_etblPOPRequisitionLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPoprequisitionLinesChecksum { get; set; }

    [Column("cSector")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSector { get; set; }

    [Column("cCostCentre")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CCostCentre { get; set; }

    [Column("iGenRFQAgentID")]
    public int? IGenRfqagentId { get; set; }

    [Column("iAreaID")]
    public int? IAreaId { get; set; }
}
