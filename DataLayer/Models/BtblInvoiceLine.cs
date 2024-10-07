using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvoiceLines")]
[Index("BtblInvoiceLinesChecksum", Name = "idx__btblInvoiceLines__btblInvoiceLines_Checksum")]
[Index("BtblInvoiceLinesIChangeSetId", Name = "idx__btblInvoiceLines_iChangeSetID")]
[Index("ISolinkedPolineId", Name = "idx__btblInvoiceLines_iSOLinkedPOLineID")]
[Index("BtblInvoiceLinesDModifiedDate", Name = "idx_btblInvoiceLines_dModifiedDate")]
[Index("BtblInvoiceLinesIBranchId", Name = "idx_btblInvoiceLines_iBranchID")]
public partial class BtblInvoiceLine
{
    [Key]
    [Column("idInvoiceLines")]
    public long IdInvoiceLines { get; set; }

    [Column("iInvoiceID")]
    public int IInvoiceId { get; set; }

    [Column("iOrigLineID")]
    public long? IOrigLineId { get; set; }

    [Column("iGrvLineID")]
    public long? IGrvLineId { get; set; }

    [Column("iLineDocketMode")]
    public int? ILineDocketMode { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("fQuantity")]
    public double? FQuantity { get; set; }

    [Column("fQtyChange")]
    public double? FQtyChange { get; set; }

    [Column("fQtyToProcess")]
    public double? FQtyToProcess { get; set; }

    [Column("fQtyLastProcess")]
    public double? FQtyLastProcess { get; set; }

    [Column("fQtyProcessed")]
    public double? FQtyProcessed { get; set; }

    [Column("fQtyReserved")]
    public double? FQtyReserved { get; set; }

    [Column("fQtyReservedChange")]
    public double? FQtyReservedChange { get; set; }

    [Column("cLineNotes")]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("fUnitPriceExcl")]
    public double? FUnitPriceExcl { get; set; }

    [Column("fUnitPriceIncl")]
    public double? FUnitPriceIncl { get; set; }

    [Column("iUnitPriceOverrideReasonID")]
    public int? IUnitPriceOverrideReasonId { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("fLineDiscount")]
    public double? FLineDiscount { get; set; }

    [Column("iLineDiscountReasonID")]
    public int? ILineDiscountReasonId { get; set; }

    [Column("iReturnReasonID")]
    public int? IReturnReasonId { get; set; }

    [Column("fTaxRate")]
    public double? FTaxRate { get; set; }

    [Column("bIsSerialItem")]
    public bool BIsSerialItem { get; set; }

    [Column("bIsWhseItem")]
    public bool BIsWhseItem { get; set; }

    [Column("fAddCost")]
    public double? FAddCost { get; set; }

    [Column("cTradeinItem")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTradeinItem { get; set; }

    [Column("iStockCodeID")]
    public int? IStockCodeId { get; set; }

    [Column("iJobID")]
    public int? IJobId { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iPriceListNameID")]
    public int? IPriceListNameId { get; set; }

    [Column("fQuantityLineTotIncl")]
    public double? FQuantityLineTotIncl { get; set; }

    [Column("fQuantityLineTotExcl")]
    public double? FQuantityLineTotExcl { get; set; }

    [Column("fQuantityLineTotInclNoDisc")]
    public double? FQuantityLineTotInclNoDisc { get; set; }

    [Column("fQuantityLineTotExclNoDisc")]
    public double? FQuantityLineTotExclNoDisc { get; set; }

    [Column("fQuantityLineTaxAmount")]
    public double? FQuantityLineTaxAmount { get; set; }

    [Column("fQuantityLineTaxAmountNoDisc")]
    public double? FQuantityLineTaxAmountNoDisc { get; set; }

    [Column("fQtyChangeLineTotIncl")]
    public double? FQtyChangeLineTotIncl { get; set; }

    [Column("fQtyChangeLineTotExcl")]
    public double? FQtyChangeLineTotExcl { get; set; }

    [Column("fQtyChangeLineTotInclNoDisc")]
    public double? FQtyChangeLineTotInclNoDisc { get; set; }

    [Column("fQtyChangeLineTotExclNoDisc")]
    public double? FQtyChangeLineTotExclNoDisc { get; set; }

    [Column("fQtyChangeLineTaxAmount")]
    public double? FQtyChangeLineTaxAmount { get; set; }

    [Column("fQtyChangeLineTaxAmountNoDisc")]
    public double? FQtyChangeLineTaxAmountNoDisc { get; set; }

    [Column("fQtyToProcessLineTotIncl")]
    public double? FQtyToProcessLineTotIncl { get; set; }

    [Column("fQtyToProcessLineTotExcl")]
    public double? FQtyToProcessLineTotExcl { get; set; }

    [Column("fQtyToProcessLineTotInclNoDisc")]
    public double? FQtyToProcessLineTotInclNoDisc { get; set; }

    [Column("fQtyToProcessLineTotExclNoDisc")]
    public double? FQtyToProcessLineTotExclNoDisc { get; set; }

    [Column("fQtyToProcessLineTaxAmount")]
    public double? FQtyToProcessLineTaxAmount { get; set; }

    [Column("fQtyToProcessLineTaxAmountNoDisc")]
    public double? FQtyToProcessLineTaxAmountNoDisc { get; set; }

    [Column("fQtyLastProcessLineTotIncl")]
    public double? FQtyLastProcessLineTotIncl { get; set; }

    [Column("fQtyLastProcessLineTotExcl")]
    public double? FQtyLastProcessLineTotExcl { get; set; }

    [Column("fQtyLastProcessLineTotInclNoDisc")]
    public double? FQtyLastProcessLineTotInclNoDisc { get; set; }

    [Column("fQtyLastProcessLineTotExclNoDisc")]
    public double? FQtyLastProcessLineTotExclNoDisc { get; set; }

    [Column("fQtyLastProcessLineTaxAmount")]
    public double? FQtyLastProcessLineTaxAmount { get; set; }

    [Column("fQtyLastProcessLineTaxAmountNoDisc")]
    public double? FQtyLastProcessLineTaxAmountNoDisc { get; set; }

    [Column("fQtyProcessedLineTotIncl")]
    public double? FQtyProcessedLineTotIncl { get; set; }

    [Column("fQtyProcessedLineTotExcl")]
    public double? FQtyProcessedLineTotExcl { get; set; }

    [Column("fQtyProcessedLineTotInclNoDisc")]
    public double? FQtyProcessedLineTotInclNoDisc { get; set; }

    [Column("fQtyProcessedLineTotExclNoDisc")]
    public double? FQtyProcessedLineTotExclNoDisc { get; set; }

    [Column("fQtyProcessedLineTaxAmount")]
    public double? FQtyProcessedLineTaxAmount { get; set; }

    [Column("fQtyProcessedLineTaxAmountNoDisc")]
    public double? FQtyProcessedLineTaxAmountNoDisc { get; set; }

    [Column("fUnitPriceExclForeign")]
    public double? FUnitPriceExclForeign { get; set; }

    [Column("fUnitPriceInclForeign")]
    public double? FUnitPriceInclForeign { get; set; }

    [Column("fUnitCostForeign")]
    public double? FUnitCostForeign { get; set; }

    [Column("fAddCostForeign")]
    public double? FAddCostForeign { get; set; }

    [Column("fQuantityLineTotInclForeign")]
    public double? FQuantityLineTotInclForeign { get; set; }

    [Column("fQuantityLineTotExclForeign")]
    public double? FQuantityLineTotExclForeign { get; set; }

    [Column("fQuantityLineTotInclNoDiscForeign")]
    public double? FQuantityLineTotInclNoDiscForeign { get; set; }

    [Column("fQuantityLineTotExclNoDiscForeign")]
    public double? FQuantityLineTotExclNoDiscForeign { get; set; }

    [Column("fQuantityLineTaxAmountForeign")]
    public double? FQuantityLineTaxAmountForeign { get; set; }

    [Column("fQuantityLineTaxAmountNoDiscForeign")]
    public double? FQuantityLineTaxAmountNoDiscForeign { get; set; }

    [Column("fQtyChangeLineTotInclForeign")]
    public double? FQtyChangeLineTotInclForeign { get; set; }

    [Column("fQtyChangeLineTotExclForeign")]
    public double? FQtyChangeLineTotExclForeign { get; set; }

    [Column("fQtyChangeLineTotInclNoDiscForeign")]
    public double? FQtyChangeLineTotInclNoDiscForeign { get; set; }

    [Column("fQtyChangeLineTotExclNoDiscForeign")]
    public double? FQtyChangeLineTotExclNoDiscForeign { get; set; }

    [Column("fQtyChangeLineTaxAmountForeign")]
    public double? FQtyChangeLineTaxAmountForeign { get; set; }

    [Column("fQtyChangeLineTaxAmountNoDiscForeign")]
    public double? FQtyChangeLineTaxAmountNoDiscForeign { get; set; }

    [Column("fQtyToProcessLineTotInclForeign")]
    public double? FQtyToProcessLineTotInclForeign { get; set; }

    [Column("fQtyToProcessLineTotExclForeign")]
    public double? FQtyToProcessLineTotExclForeign { get; set; }

    [Column("fQtyToProcessLineTotInclNoDiscForeign")]
    public double? FQtyToProcessLineTotInclNoDiscForeign { get; set; }

    [Column("fQtyToProcessLineTotExclNoDiscForeign")]
    public double? FQtyToProcessLineTotExclNoDiscForeign { get; set; }

    [Column("fQtyToProcessLineTaxAmountForeign")]
    public double? FQtyToProcessLineTaxAmountForeign { get; set; }

    [Column("fQtyToProcessLineTaxAmountNoDiscForeign")]
    public double? FQtyToProcessLineTaxAmountNoDiscForeign { get; set; }

    [Column("fQtyLastProcessLineTotInclForeign")]
    public double? FQtyLastProcessLineTotInclForeign { get; set; }

    [Column("fQtyLastProcessLineTotExclForeign")]
    public double? FQtyLastProcessLineTotExclForeign { get; set; }

    [Column("fQtyLastProcessLineTotInclNoDiscForeign")]
    public double? FQtyLastProcessLineTotInclNoDiscForeign { get; set; }

    [Column("fQtyLastProcessLineTotExclNoDiscForeign")]
    public double? FQtyLastProcessLineTotExclNoDiscForeign { get; set; }

    [Column("fQtyLastProcessLineTaxAmountForeign")]
    public double? FQtyLastProcessLineTaxAmountForeign { get; set; }

    [Column("fQtyLastProcessLineTaxAmountNoDiscForeign")]
    public double? FQtyLastProcessLineTaxAmountNoDiscForeign { get; set; }

    [Column("fQtyProcessedLineTotInclForeign")]
    public double? FQtyProcessedLineTotInclForeign { get; set; }

    [Column("fQtyProcessedLineTotExclForeign")]
    public double? FQtyProcessedLineTotExclForeign { get; set; }

    [Column("fQtyProcessedLineTotInclNoDiscForeign")]
    public double? FQtyProcessedLineTotInclNoDiscForeign { get; set; }

    [Column("fQtyProcessedLineTotExclNoDiscForeign")]
    public double? FQtyProcessedLineTotExclNoDiscForeign { get; set; }

    [Column("fQtyProcessedLineTaxAmountForeign")]
    public double? FQtyProcessedLineTaxAmountForeign { get; set; }

    [Column("fQtyProcessedLineTaxAmountNoDiscForeign")]
    public double? FQtyProcessedLineTaxAmountNoDiscForeign { get; set; }

    [Column("iLineRepID")]
    public int? ILineRepId { get; set; }

    [Column("iLineProjectID")]
    public int? ILineProjectId { get; set; }

    [Column("iLedgerAccountID")]
    public int? ILedgerAccountId { get; set; }

    [Column("iModule")]
    public int IModule { get; set; }

    [Column("bChargeCom")]
    public bool BChargeCom { get; set; }

    [Column("bIsLotItem")]
    public bool BIsLotItem { get; set; }

    [Column("iLotID")]
    public int? ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("iMFPID")]
    public int? IMfpid { get; set; }

    [Column("iLineID")]
    public int ILineId { get; set; }

    [Column("iLinkedLineID")]
    public long ILinkedLineId { get; set; }

    [Column("fQtyLinkedUsed")]
    public double? FQtyLinkedUsed { get; set; }

    [Column("_btblInvoiceLines_iBranchID")]
    public int? BtblInvoiceLinesIBranchId { get; set; }

    [Column("_btblInvoiceLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceLinesDCreatedDate { get; set; }

    [Column("_btblInvoiceLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceLinesDModifiedDate { get; set; }

    [Column("_btblInvoiceLines_iCreatedBranchID")]
    public int? BtblInvoiceLinesICreatedBranchId { get; set; }

    [Column("_btblInvoiceLines_iModifiedBranchID")]
    public int? BtblInvoiceLinesIModifiedBranchId { get; set; }

    [Column("_btblInvoiceLines_iCreatedAgentID")]
    public int? BtblInvoiceLinesICreatedAgentId { get; set; }

    [Column("_btblInvoiceLines_iModifiedAgentID")]
    public int? BtblInvoiceLinesIModifiedAgentId { get; set; }

    [Column("_btblInvoiceLines_iChangeSetID")]
    public int? BtblInvoiceLinesIChangeSetId { get; set; }

    [Column("fUnitPriceInclOrig")]
    public double? FUnitPriceInclOrig { get; set; }

    [Column("fUnitPriceExclOrig")]
    public double? FUnitPriceExclOrig { get; set; }

    [Column("fUnitPriceInclForeignOrig")]
    public double? FUnitPriceInclForeignOrig { get; set; }

    [Column("fUnitPriceExclForeignOrig")]
    public double? FUnitPriceExclForeignOrig { get; set; }

    [Column("iDeliveryMethodID")]
    public int? IDeliveryMethodId { get; set; }

    [Column("fQtyDeliver")]
    public double? FQtyDeliver { get; set; }

    [Column("dDeliveryDate", TypeName = "datetime")]
    public DateTime? DDeliveryDate { get; set; }

    [Column("iDeliveryStatus")]
    public int? IDeliveryStatus { get; set; }

    [Column("fQtyForDelivery")]
    public double? FQtyForDelivery { get; set; }

    [Column("bPromotionApplied")]
    public bool BPromotionApplied { get; set; }

    [Column("fPromotionPriceExcl")]
    public double? FPromotionPriceExcl { get; set; }

    [Column("fPromotionPriceIncl")]
    public double? FPromotionPriceIncl { get; set; }

    [Column("cPromotionCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPromotionCode { get; set; }

    [Column("iSOLinkedPOLineID")]
    public long ISolinkedPolineId { get; set; }

    [Column("fLength")]
    public double? FLength { get; set; }

    [Column("fWidth")]
    public double? FWidth { get; set; }

    [Column("fHeight")]
    public double? FHeight { get; set; }

    [Column("iPieces")]
    public int? IPieces { get; set; }

    [Column("iPiecesToProcess")]
    public int? IPiecesToProcess { get; set; }

    [Column("iPiecesLastProcess")]
    public int? IPiecesLastProcess { get; set; }

    [Column("iPiecesProcessed")]
    public int? IPiecesProcessed { get; set; }

    [Column("iPiecesReserved")]
    public int? IPiecesReserved { get; set; }

    [Column("iPiecesDeliver")]
    public int? IPiecesDeliver { get; set; }

    [Column("iPiecesForDelivery")]
    public int? IPiecesForDelivery { get; set; }

    [Column("fQuantityUR")]
    public double? FQuantityUr { get; set; }

    [Column("fQtyChangeUR")]
    public double? FQtyChangeUr { get; set; }

    [Column("fQtyToProcessUR")]
    public double? FQtyToProcessUr { get; set; }

    [Column("fQtyLastProcessUR")]
    public double? FQtyLastProcessUr { get; set; }

    [Column("fQtyProcessedUR")]
    public double? FQtyProcessedUr { get; set; }

    [Column("fQtyReservedUR")]
    public double? FQtyReservedUr { get; set; }

    [Column("fQtyReservedChangeUR")]
    public double? FQtyReservedChangeUr { get; set; }

    [Column("fQtyDeliverUR")]
    public double? FQtyDeliverUr { get; set; }

    [Column("fQtyForDeliveryUR")]
    public double? FQtyForDeliveryUr { get; set; }

    [Column("fQtyLinkedUsedUR")]
    public double? FQtyLinkedUsedUr { get; set; }

    [Column("iPiecesLinkedUsed")]
    public int? IPiecesLinkedUsed { get; set; }

    [Column("iSalesWhseID")]
    public int? ISalesWhseId { get; set; }

    [Column("_btblInvoiceLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvoiceLinesChecksum { get; set; }

    [Column("bReverseChargeApplied")]
    public bool BReverseChargeApplied { get; set; }

    [Column("fRecommendedRetailPrice")]
    public double? FRecommendedRetailPrice { get; set; }
}
