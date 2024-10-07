using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvJctxLinesFull
{
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

    [Column("UOMStockingUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomstockingUnitCode { get; set; }

    [Column("UOMUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomunitCode { get; set; }

    [Column("UOMfStockingTransQty")]
    public double? UomfStockingTransQty { get; set; }

    [Column("UOMfStockingTransQtyAdjusted")]
    public double? UomfStockingTransQtyAdjusted { get; set; }

    [Column("UOMfStockingTransQtyInvoiced")]
    public double? UomfStockingTransQtyInvoiced { get; set; }

    [Column("UOMfStockingUnitCost")]
    public double? UomfStockingUnitCost { get; set; }

    [Column("UOMfStockingUnitPriceExcl")]
    public double? UomfStockingUnitPriceExcl { get; set; }

    [Column("UOMfStockingUnitPriceIncl")]
    public double? UomfStockingUnitPriceIncl { get; set; }

    [Column("UOMfStockingUnitPriceExclForeign")]
    public double? UomfStockingUnitPriceExclForeign { get; set; }

    [Column("UOMfStockingUnitPriceInclForeign")]
    public double? UomfStockingUnitPriceInclForeign { get; set; }

    [Column("UOMfStockingBudgetUnitPriceExcl")]
    public double? UomfStockingBudgetUnitPriceExcl { get; set; }

    [Column("UOMfStockingBudgetUnitPriceIncl")]
    public double? UomfStockingBudgetUnitPriceIncl { get; set; }

    [Column("UOMfStockingBudgetUnitPriceExclForeign")]
    public double? UomfStockingBudgetUnitPriceExclForeign { get; set; }

    [Column("UOMfStockingBudgetUnitPriceInclForeign")]
    public double? UomfStockingBudgetUnitPriceInclForeign { get; set; }

    public double? ActTxQty { get; set; }

    [Column("UOMActStockingTxQty")]
    public double? UomactStockingTxQty { get; set; }

    public double? ActLineTotal { get; set; }

    public double? ActLineTotalCost { get; set; }

    public double? ActUnitCost { get; set; }

    public double? ActLineTotalForeign { get; set; }

    public double? ActLineInvSales { get; set; }

    public double? ActLineInvSalesForeign { get; set; }

    public double? ActLineInvCost { get; set; }

    public double? ActPostedLineCost { get; set; }

    public double? ActPostedLineTax { get; set; }

    public double? ActPostedLineTaxForeign { get; set; }

    public double? ActBudgetSales { get; set; }

    public double? ActBudgetCost { get; set; }

    public double? ActBudgetTax { get; set; }

    public double? ActBudgetSalesForeign { get; set; }

    public double? ActBudgetTaxForeign { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? TxStatusDesc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? TxTypeDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TxTypeCode { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? TxSource { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? TxAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? TxAccDescription { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemGroup { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemBin { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ItemPack { get; set; }

    public double ItemQtyAvail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WarehouseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    [Column("WhseMst_iBranchID")]
    public int? WhseMstIBranchId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Supplier { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SupplierName { get; set; }

    [Column("GLAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? Glaccount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkerCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkerName { get; set; }

    [Column("GRVNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Grvnumber { get; set; }

    [Column("InvNumID")]
    public int? InvNumId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LotExpiryDate { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }
}
