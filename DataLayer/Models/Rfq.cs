using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ")]
[Index("RfqChecksum", Name = "idx_RFQ_RFQ_Checksum")]
[Index("RfqDModifiedDate", Name = "idx_RFQ_RFQ_dModifiedDate")]
[Index("RfqIBranchId", Name = "idx_RFQ_RFQ_iBranchID")]
[Index("RfqIChangeSetId", Name = "idx_RFQ_RFQ_iChangeSetID")]
public partial class Rfq
{
    [Key]
    [Column("iRFQID")]
    public int IRfqid { get; set; }

    [Column("iRequisitionLinesID")]
    public int IRequisitionLinesId { get; set; }

    [Column("iModuleID")]
    public int IModuleId { get; set; }

    [Column("iStockCodeID")]
    public int? IStockCodeId { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    public string? CDescription { get; set; }

    [Column("iWareHouseID")]
    public int? IWareHouseId { get; set; }

    [Column("fQuantity")]
    public double FQuantity { get; set; }

    [Column("fQtyProcessed")]
    public double FQtyProcessed { get; set; }

    [Column("fQtyConfirm")]
    public double FQtyConfirm { get; set; }

    [Column("fUnitPrice")]
    public double FUnitPrice { get; set; }

    [Column("iTaxType")]
    public int? ITaxType { get; set; }

    [Column("fTaxRate")]
    public double? FTaxRate { get; set; }

    [Column("fLineDiscount")]
    public double? FLineDiscount { get; set; }

    [Column("fQuantityLineTotExcl")]
    public double? FQuantityLineTotExcl { get; set; }

    [Column("fQuantityLineTaxAmount")]
    public double? FQuantityLineTaxAmount { get; set; }

    [Column("dExpectedDate", TypeName = "datetime")]
    public DateTime? DExpectedDate { get; set; }

    [Column("iRequisitionID")]
    public int? IRequisitionId { get; set; }

    [StringLength(50)]
    public string? OrderNum { get; set; }

    [Column("iState")]
    public int IState { get; set; }

    [Column("iSupplierID")]
    public int ISupplierId { get; set; }

    [Column("dOrderDate", TypeName = "datetime")]
    public DateTime? DOrderDate { get; set; }

    [Column("fQuotedPrice")]
    public double? FQuotedPrice { get; set; }

    [Column("fQuotedQuantity")]
    public double? FQuotedQuantity { get; set; }

    public bool? Archived { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [Column("dReceivedDate", TypeName = "datetime")]
    public DateTime? DReceivedDate { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    public string? CLineNotes { get; set; }

    [Column("dEvaluationdate", TypeName = "datetime")]
    public DateTime? DEvaluationdate { get; set; }

    [Column("cEvaluationComments")]
    [StringLength(1024)]
    public string? CEvaluationComments { get; set; }

    [Column("cFileName")]
    [StringLength(100)]
    public string? CFileName { get; set; }

    [Column("cFileContent")]
    public byte[]? CFileContent { get; set; }

    [Column("dQuotationDeadLine", TypeName = "datetime")]
    public DateTime? DQuotationDeadLine { get; set; }

    [Column("bApprovePO")]
    public bool? BApprovePo { get; set; }

    [Column("bAuthorizePO")]
    public bool? BAuthorizePo { get; set; }

    [Column("iHODAgent1")]
    public int? IHodagent1 { get; set; }

    [Column("iHODAgent2")]
    public int? IHodagent2 { get; set; }

    [Column("fQuotedPriceForeign")]
    public double? FQuotedPriceForeign { get; set; }

    [Column("fQuotedPriceIncl")]
    public double? FQuotedPriceIncl { get; set; }

    [Column("iCriteriaID")]
    public int? ICriteriaId { get; set; }

    [Column("bRecommend")]
    public bool? BRecommend { get; set; }

    [Column("RFQ_iBranchID")]
    public int? RfqIBranchId { get; set; }

    [Column("RFQ_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqDCreatedDate { get; set; }

    [Column("RFQ_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqDModifiedDate { get; set; }

    [Column("RFQ_iCreatedBranchID")]
    public int? RfqICreatedBranchId { get; set; }

    [Column("RFQ_iModifiedBranchID")]
    public int? RfqIModifiedBranchId { get; set; }

    [Column("RFQ_iCreatedAgentID")]
    public int? RfqICreatedAgentId { get; set; }

    [Column("RFQ_iModifiedAgentID")]
    public int? RfqIModifiedAgentId { get; set; }

    [Column("RFQ_iChangeSetID")]
    public int? RfqIChangeSetId { get; set; }

    [Column("RFQ_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqChecksum { get; set; }
}
