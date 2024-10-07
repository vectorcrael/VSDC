using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblJCTxLines")]
[Index("BtblJctxLinesChecksum", Name = "idx__btblJCTxLines__btblJCTxLines_Checksum")]
[Index("BtblJctxLinesIChangeSetId", Name = "idx__btblJCTxLines_iChangeSetID")]
[Index("BtblJctxLinesDModifiedDate", Name = "idx_btblJCTxLines_dModifiedDate")]
[Index("BtblJctxLinesIBranchId", Name = "idx_btblJCTxLines_iBranchID")]
[Index("IJcmasterId", Name = "idx_btblJCTxLines_iJCMasterID")]
public partial class BtblJctxLine
{
    [Key]
    [Column("idJCTxLines")]
    public long IdJctxLines { get; set; }

    [Column("iJCMasterID")]
    public int? IJcmasterId { get; set; }

    [Column("iJobTxTpID")]
    public int? IJobTxTpId { get; set; }

    [Column("iSource")]
    public int? ISource { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iSupplierID")]
    public int? ISupplierId { get; set; }

    [Column("iLedgerID")]
    public int? ILedgerId { get; set; }

    [Column("cDescription")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }

    [Column("iDuration")]
    public int? IDuration { get; set; }

    [Column("dStartDate", TypeName = "datetime")]
    public DateTime? DStartDate { get; set; }

    [Column("dEndDate", TypeName = "datetime")]
    public DateTime? DEndDate { get; set; }

    [Column("fMainDiscount")]
    public double? FMainDiscount { get; set; }

    [Column("fUnitPriceExcl")]
    public double? FUnitPriceExcl { get; set; }

    [Column("fUnitPriceIncl")]
    public double? FUnitPriceIncl { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("fLineDiscount")]
    public double? FLineDiscount { get; set; }

    [Column("iTaxTypeIDInv")]
    public int? ITaxTypeIdinv { get; set; }

    [Column("fTaxRateInv")]
    public double? FTaxRateInv { get; set; }

    [Column("fTransQty")]
    public double? FTransQty { get; set; }

    [Column("fTransQtyToInvoice")]
    public double? FTransQtyToInvoice { get; set; }

    [Column("fTransQtyInvoiced")]
    public double? FTransQtyInvoiced { get; set; }

    [Column("fTransQtyAvailable")]
    public double? FTransQtyAvailable { get; set; }

    [Column("fTransQtyAdjusted")]
    public double FTransQtyAdjusted { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("iPriceListNameID")]
    public int? IPriceListNameId { get; set; }

    [Column("iTaxTypeIDGrv")]
    public int? ITaxTypeIdgrv { get; set; }

    [Column("fTaxRateGrv")]
    public double? FTaxRateGrv { get; set; }

    [Column("fTaxAmountGrv")]
    public double? FTaxAmountGrv { get; set; }

    [Column("iEmployeeID")]
    public int? IEmployeeId { get; set; }

    [Column("fBudgetUnitPriceExcl")]
    public double? FBudgetUnitPriceExcl { get; set; }

    [Column("fBudgetUnitPriceIncl")]
    public double? FBudgetUnitPriceIncl { get; set; }

    [Column("fBudgetUnitCost")]
    public double? FBudgetUnitCost { get; set; }

    [Column("fBudgetLineTotalExcl")]
    public double? FBudgetLineTotalExcl { get; set; }

    [Column("fBudgetLineTotalIncl")]
    public double? FBudgetLineTotalIncl { get; set; }

    [Column("fBudgetLineTotalTaxAmountInv")]
    public double? FBudgetLineTotalTaxAmountInv { get; set; }

    [Column("fBudgetLineTotalTaxAmountGrv")]
    public double? FBudgetLineTotalTaxAmountGrv { get; set; }

    [Column("fBudgetLineTotalCost")]
    public double? FBudgetLineTotalCost { get; set; }

    [Column("fLineTotalExcl")]
    public double? FLineTotalExcl { get; set; }

    [Column("fLineTotalIncl")]
    public double? FLineTotalIncl { get; set; }

    [Column("fLineTotalTaxAmountInv")]
    public double? FLineTotalTaxAmountInv { get; set; }

    [Column("fLineTotalExclToInvoice")]
    public double? FLineTotalExclToInvoice { get; set; }

    [Column("fLineTotalInclToInvoice")]
    public double? FLineTotalInclToInvoice { get; set; }

    [Column("fLineTotalExclForeign")]
    public double? FLineTotalExclForeign { get; set; }

    [Column("fLineTotalInclForeign")]
    public double? FLineTotalInclForeign { get; set; }

    [Column("fLineTotalTaxAmountInvForeign")]
    public double? FLineTotalTaxAmountInvForeign { get; set; }

    [Column("fLineTotalExclForeignToInvoice")]
    public double? FLineTotalExclForeignToInvoice { get; set; }

    [Column("fLineTotalInclForeignToInvoice")]
    public double? FLineTotalInclForeignToInvoice { get; set; }

    [Column("fLineTotalTaxAmountInvForeignToInvoice")]
    public double? FLineTotalTaxAmountInvForeignToInvoice { get; set; }

    [Column("fLineTotalTaxAmountInvToInvoice")]
    public double? FLineTotalTaxAmountInvToInvoice { get; set; }

    [Column("fLineTotalExclInvoiced")]
    public double? FLineTotalExclInvoiced { get; set; }

    [Column("fLineTotalInclInvoiced")]
    public double? FLineTotalInclInvoiced { get; set; }

    [Column("fLineTotalTaxAmountInvInvoiced")]
    public double? FLineTotalTaxAmountInvInvoiced { get; set; }

    [Column("fLineTotalExclForeignInvoiced")]
    public double? FLineTotalExclForeignInvoiced { get; set; }

    [Column("fLineTotalInclForeignInvoiced")]
    public double? FLineTotalInclForeignInvoiced { get; set; }

    [Column("fLineTotalTaxAmountInvForeignInvoiced")]
    public double? FLineTotalTaxAmountInvForeignInvoiced { get; set; }

    [Column("fLineTotalCost")]
    public double? FLineTotalCost { get; set; }

    [Column("fLineTotalCostInvoiced")]
    public double? FLineTotalCostInvoiced { get; set; }

    [Column("bPosted")]
    public bool BPosted { get; set; }

    [Column("bInvoiced")]
    public bool BInvoiced { get; set; }

    [Column("iJobNumID")]
    public int? IJobNumId { get; set; }

    [Column("cinvNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CinvNumber { get; set; }

    [Column("cUserName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CUserName { get; set; }

    [Column("iJobStockGroupID")]
    public int? IJobStockGroupId { get; set; }

    [Column("iSerialNumberGroupID")]
    public int? ISerialNumberGroupId { get; set; }

    [Column("iSerialNumberInvoicedGroupID")]
    public int? ISerialNumberInvoicedGroupId { get; set; }

    [Column("iSerialNumberToInvoiceGroupID")]
    public int? ISerialNumberToInvoiceGroupId { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("iInvNumID")]
    public int? IInvNumId { get; set; }

    [Column("bPicked")]
    public bool BPicked { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fUnitPriceExclForeign")]
    public double? FUnitPriceExclForeign { get; set; }

    [Column("fUnitPriceInclForeign")]
    public double? FUnitPriceInclForeign { get; set; }

    [Column("fExchangeRateGrv")]
    public double? FExchangeRateGrv { get; set; }

    [Column("fTaxAmountGrvForeign")]
    public double? FTaxAmountGrvForeign { get; set; }

    [Column("fBudgetUnitPriceExclForeign")]
    public double? FBudgetUnitPriceExclForeign { get; set; }

    [Column("fBudgetUnitPriceInclForeign")]
    public double? FBudgetUnitPriceInclForeign { get; set; }

    [Column("fBudgetLineTotalExclForeign")]
    public double? FBudgetLineTotalExclForeign { get; set; }

    [Column("fBudgetLineTotalInclForeign")]
    public double? FBudgetLineTotalInclForeign { get; set; }

    [Column("fBudgetLineTotalTaxAmountInvForeign")]
    public double? FBudgetLineTotalTaxAmountInvForeign { get; set; }

    [Column("fBudgetLineTotalTaxAmountGrvForeign")]
    public double? FBudgetLineTotalTaxAmountGrvForeign { get; set; }

    [Column("iGrvCurrencyID")]
    public int? IGrvCurrencyId { get; set; }

    [Column("iLineRepID")]
    public int? ILineRepId { get; set; }

    [Column("iLineProjectID")]
    public int? ILineProjectId { get; set; }

    [Column("bChargeCom")]
    public bool BChargeCom { get; set; }

    [Column("iMFPID")]
    public int? IMfpid { get; set; }

    [Column("iLotID")]
    public int? ILotId { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iInvSettlementTermsID")]
    public int IInvSettlementTermsId { get; set; }

    [Column("iAPSettlementTermsID")]
    public int IApsettlementTermsId { get; set; }

    [Column("iEUNoTCID")]
    public int IEunoTcid { get; set; }

    [Column("iLineID")]
    public int? ILineId { get; set; }

    [Column("_btblJCTxLines_iBranchID")]
    public int? BtblJctxLinesIBranchId { get; set; }

    [Column("_btblJCTxLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJctxLinesDCreatedDate { get; set; }

    [Column("_btblJCTxLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJctxLinesDModifiedDate { get; set; }

    [Column("_btblJCTxLines_iCreatedBranchID")]
    public int? BtblJctxLinesICreatedBranchId { get; set; }

    [Column("_btblJCTxLines_iModifiedBranchID")]
    public int? BtblJctxLinesIModifiedBranchId { get; set; }

    [Column("_btblJCTxLines_iCreatedAgentID")]
    public int? BtblJctxLinesICreatedAgentId { get; set; }

    [Column("_btblJCTxLines_iModifiedAgentID")]
    public int? BtblJctxLinesIModifiedAgentId { get; set; }

    [Column("_btblJCTxLines_iChangeSetID")]
    public int? BtblJctxLinesIChangeSetId { get; set; }

    [Column("_btblJCTxLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJctxLinesChecksum { get; set; }

    [Column("fTransWIPAvailable")]
    public double FTransWipavailable { get; set; }

    [Column("fTransQtyLastInvoiced")]
    public double? FTransQtyLastInvoiced { get; set; }

    [Column("bFiscalInvoiced")]
    public bool? BFiscalInvoiced { get; set; }

    [Column("fRecommendedRetailPrice")]
    public double? FRecommendedRetailPrice { get; set; }
}
