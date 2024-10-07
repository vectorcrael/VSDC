using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvSalesOrdersFull
{
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

    [Column("UOMStockingUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomstockingUnitCode { get; set; }

    [Column("UOMUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomunitCode { get; set; }

    [Column("UOMfStockingQuantity")]
    public double? UomfStockingQuantity { get; set; }

    [Column("UOMfStockingQtyChange")]
    public double? UomfStockingQtyChange { get; set; }

    [Column("UOMfStockingQtyToProcess")]
    public double? UomfStockingQtyToProcess { get; set; }

    [Column("UOMfStockingQtyLastProcess")]
    public double? UomfStockingQtyLastProcess { get; set; }

    [Column("UOMfStockingQtyProcessed")]
    public double? UomfStockingQtyProcessed { get; set; }

    [Column("UOMfStockingQtyReserved")]
    public double? UomfStockingQtyReserved { get; set; }

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

    public int? StockLink { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("Description_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [Column("Description_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description2 { get; set; }

    [Column("Description_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemGroup { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Pack { get; set; }

    [Column("TTI")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Tti { get; set; }

    [Column("TTC")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttc { get; set; }

    [Column("TTG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttg { get; set; }

    [Column("TTR")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttr { get; set; }

    [Column("Bar_Code")]
    [StringLength(400)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    [Column("Re_Ord_Lvl")]
    public double? ReOrdLvl { get; set; }

    [Column("Re_Ord_Qty")]
    public double? ReOrdQty { get; set; }

    [Column("Min_Lvl")]
    public double? MinLvl { get; set; }

    [Column("Max_Lvl")]
    public double? MaxLvl { get; set; }

    [Column("AveUCst")]
    public double? AveUcst { get; set; }

    [Column("LatUCst")]
    public double? LatUcst { get; set; }

    [Column("LowUCst")]
    public double? LowUcst { get; set; }

    [Column("HigUCst")]
    public double? HigUcst { get; set; }

    [Column("StdUCst")]
    public double? StdUcst { get; set; }

    [Column("Qty_On_Hand")]
    public double? QtyOnHand { get; set; }

    [Column("LGrvCount")]
    public double? LgrvCount { get; set; }

    public bool? ServiceItem { get; set; }

    public bool? ItemActive { get; set; }

    public double? ReservedQty { get; set; }

    [Column("QtyOnPO")]
    public double? QtyOnPo { get; set; }

    [Column("QtyOnSO")]
    public double? QtyOnSo { get; set; }

    public bool? WhseItem { get; set; }

    public bool? SerialItem { get; set; }

    [Column("DuplicateSN")]
    public bool? DuplicateSn { get; set; }

    [Column("StrictSN")]
    public bool? StrictSn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BomCode { get; set; }

    [Column("SMtrxCol")]
    public int? SmtrxCol { get; set; }

    [Column("PMtrxCol")]
    public int? PmtrxCol { get; set; }

    public double? JobQty { get; set; }

    [Column("cModel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CModel { get; set; }

    [Column("cRevision")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRevision { get; set; }

    [Column("cComponent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CComponent { get; set; }

    [Column("dDateReleased", TypeName = "smalldatetime")]
    public DateTime? DDateReleased { get; set; }

    [Column("iBinLocationID")]
    public int? IBinLocationId { get; set; }

    [Column("dStkitemTimeStamp", TypeName = "datetime")]
    public DateTime? DStkitemTimeStamp { get; set; }

    [Column("iInvSegValue1ID")]
    public int? IInvSegValue1Id { get; set; }

    [Column("iInvSegValue2ID")]
    public int? IInvSegValue2Id { get; set; }

    [Column("iInvSegValue3ID")]
    public int? IInvSegValue3Id { get; set; }

    [Column("iInvSegValue4ID")]
    public int? IInvSegValue4Id { get; set; }

    [Column("iInvSegValue5ID")]
    public int? IInvSegValue5Id { get; set; }

    [Column("iInvSegValue6ID")]
    public int? IInvSegValue6Id { get; set; }

    [Column("iInvSegValue7ID")]
    public int? IInvSegValue7Id { get; set; }

    [Column("cExtDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CExtDescription { get; set; }

    [Column("cSimpleCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSimpleCode { get; set; }

    [Column("bCommissionItem")]
    public bool? BCommissionItem { get; set; }

    [Column("MFPQty")]
    public double? Mfpqty { get; set; }

    [Column("bLotItem")]
    public bool? BLotItem { get; set; }

    [Column("iLotStatus")]
    public int? ILotStatus { get; set; }

    [Column("bLotMustExpire")]
    public bool? BLotMustExpire { get; set; }

    [Column("iItemCostingMethod")]
    public int? IItemCostingMethod { get; set; }

    [Column("fItemLastGRVCost")]
    public double? FItemLastGrvcost { get; set; }

    [Column("iEUCommodityID")]
    public int? IEucommodityId { get; set; }

    [Column("iEUSupplementaryUnitID")]
    public int? IEusupplementaryUnitId { get; set; }

    [Column("fNetMass")]
    public double? FNetMass { get; set; }

    [Column("iUOMStockingUnitID")]
    public int? IUomstockingUnitId { get; set; }

    [Column("iUOMDefPurchaseUnitID")]
    public int? IUomdefPurchaseUnitId { get; set; }

    [Column("iUOMDefSellUnitID")]
    public int? IUomdefSellUnitId { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }

    [Column("StkItem_dCreatedDate", TypeName = "datetime")]
    public DateTime? StkItemDCreatedDate { get; set; }

    [Column("StkItem_dModifiedDate", TypeName = "datetime")]
    public DateTime? StkItemDModifiedDate { get; set; }

    [Column("StkItem_iCreatedBranchID")]
    public int? StkItemICreatedBranchId { get; set; }

    [Column("StkItem_iModifiedBranchID")]
    public int? StkItemIModifiedBranchId { get; set; }

    [Column("StkItem_iCreatedAgentID")]
    public int? StkItemICreatedAgentId { get; set; }

    [Column("StkItem_iModifiedAgentID")]
    public int? StkItemIModifiedAgentId { get; set; }

    [Column("fStockGPPercent")]
    public float? FStockGppercent { get; set; }

    [Column("StkItem_iChangeSetID")]
    public int? StkItemIChangeSetId { get; set; }

    [Column("bAllowNegStock")]
    public bool? BAllowNegStock { get; set; }

    [Column("fQtyToDeliver")]
    public double? FQtyToDeliver { get; set; }

    [Column("StkItem_fLeadDays")]
    public double? StkItemFLeadDays { get; set; }

    [Column("cEachDescription")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CEachDescription { get; set; }

    [Column("cMeasurement")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CMeasurement { get; set; }

    [Column("fBuyLength")]
    public double? FBuyLength { get; set; }

    [Column("fBuyWidth")]
    public double? FBuyWidth { get; set; }

    [Column("fBuyHeight")]
    public double? FBuyHeight { get; set; }

    [Column("fBuyArea")]
    public double? FBuyArea { get; set; }

    [Column("fBuyVolume")]
    public double? FBuyVolume { get; set; }

    [Column("cBuyWeight")]
    public double? CBuyWeight { get; set; }

    [Column("cBuyUnit")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CBuyUnit { get; set; }

    [Column("fSellLength")]
    public double? FSellLength { get; set; }

    [Column("fSellWidth")]
    public double? FSellWidth { get; set; }

    [Column("fSellHeight")]
    public double? FSellHeight { get; set; }

    [Column("fSellArea")]
    public double? FSellArea { get; set; }

    [Column("fSellVolume")]
    public double? FSellVolume { get; set; }

    [Column("cSellWeight")]
    public double? CSellWeight { get; set; }

    [Column("cSellUnit")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CSellUnit { get; set; }

    [Column("bOverrideSell")]
    public bool? BOverrideSell { get; set; }

    [Column("bUOMItem")]
    public bool? BUomitem { get; set; }

    [Column("bDimensionItem")]
    public bool? BDimensionItem { get; set; }

    [Column("iBuyingAgentID")]
    public int? IBuyingAgentId { get; set; }

    [Column("bVASItem")]
    public bool? BVasitem { get; set; }

    [Column("bAirtimeItem")]
    public bool? BAirtimeItem { get; set; }

    [Column("fIBTQtyToIssue")]
    public double? FIbtqtyToIssue { get; set; }

    [Column("fIBTQtyToReceive")]
    public double? FIbtqtyToReceive { get; set; }

    [Column("StkItem_Checksum")]
    [MaxLength(20)]
    public byte[]? StkItemChecksum { get; set; }

    [Column("bSyncToSOT")]
    public bool? BSyncToSot { get; set; }

    [Column("bImportedServices")]
    public bool? BImportedServices { get; set; }

    [Column("DefaultDeliveryAddressID")]
    public int? DefaultDeliveryAddressId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DefaultDeliveryAddCode { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? DefaultDeliveryAddDescr { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DefaultDeliveryAdd1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DefaultDeliveryAdd2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DefaultDeliveryAdd3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DefaultDeliveryAdd4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DefaultDeliveryAdd5 { get; set; }

    [Column("DefaultDeliveryAddPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DefaultDeliveryAddPc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DafaultDeliveryAddContact1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DefaultDeliveryAddContact2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DefaultDeliveryAddTel1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DefaultDeliveryAddTel2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DefaultDeliveryAddCell { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DefaultDeliveryAddFax { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DefaultDeliveryAddEmail { get; set; }

    [Column("DeliveryAdd1ID")]
    public int? DeliveryAdd1Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeliveryAdd1Code { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? DeliveryAdd1Descr { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd1Line1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd1Line2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd1Line3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd1Line4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd1Line5 { get; set; }

    [Column("DeliveryAdd1PC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DeliveryAdd1Pc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveryAdd1Contact1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveryAdd1Contact2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd1Tel1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd1Tel2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd1Cell { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd1Fax { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryAdd1Email { get; set; }

    [Column("DeliveryAdd2ID")]
    public int? DeliveryAdd2Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeliveryAdd2Code { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? DeliveryAdd2Descr { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd2Line1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd2Line2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd2Line3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd2Line4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliveryAdd2Line5 { get; set; }

    [Column("DeliveryAdd2PC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DeliveryAdd2Pc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveryAdd2Contact1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveryAdd2Contact2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd2Tel1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd2Tel2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd2Cell { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? DeliveryAdd2Fax { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DeliveryAdd2Email { get; set; }

    public int? DefaultSupplierLink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DefaultSupplierCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DefaultSupplierName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DefaultSupplierItemCode { get; set; }

    [Column("fMinOrderQuantity")]
    public double? FMinOrderQuantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxType { get; set; }

    [Column("cJobCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CJobCode { get; set; }

    [Column("WarehouseID")]
    public int? WarehouseId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WarehouseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    [Column("WhseMst_iBranchID")]
    public int? WhseMstIBranchId { get; set; }

    public int? AutoIndex { get; set; }

    public int? DocType { get; set; }

    public int? DocVersion { get; set; }

    public int? DocState { get; set; }

    public int? DocFlag { get; set; }

    [Column("OrigDocID")]
    public int? OrigDocId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GrvNumber { get; set; }

    [Column("GrvID")]
    public int? GrvId { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InvDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DeliveryDate { get; set; }

    public bool? TaxInclusive { get; set; }

    [Column("Email_Sent")]
    public int? EmailSent { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address5 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address6 { get; set; }

    [Column("PAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress1 { get; set; }

    [Column("PAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress2 { get; set; }

    [Column("PAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress3 { get; set; }

    [Column("PAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress4 { get; set; }

    [Column("PAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress5 { get; set; }

    [Column("PAddress6")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress6 { get; set; }

    [Column("DelMethodID")]
    public int? DelMethodId { get; set; }

    [Column("DocRepID")]
    public int? DocRepId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DeliveryNote { get; set; }

    public double? InvDisc { get; set; }

    [Column("InvDiscReasonID")]
    public int? InvDiscReasonId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message3 { get; set; }

    [Column("ProjectID")]
    public int? ProjectId { get; set; }

    [Column("TillID")]
    public int? TillId { get; set; }

    [Column("POSAmntTendered")]
    public double? PosamntTendered { get; set; }

    [Column("POSChange")]
    public double? Poschange { get; set; }

    public bool? GrvSplitFixedCost { get; set; }

    public double? GrvSplitFixedAmnt { get; set; }

    [Column("OrderStatusID")]
    public int? OrderStatusId { get; set; }

    [Column("OrderPriorityID")]
    public int? OrderPriorityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExtOrderNum { get; set; }

    [Column("ForeignCurrencyID")]
    public int? ForeignCurrencyId { get; set; }

    public double? InvDiscAmnt { get; set; }

    public double? InvDiscAmntEx { get; set; }

    [Column("InvTotExclDEx")]
    public double? InvTotExclDex { get; set; }

    [Column("InvTotTaxDEx")]
    public double? InvTotTaxDex { get; set; }

    [Column("InvTotInclDEx")]
    public double? InvTotInclDex { get; set; }

    public double? InvTotExcl { get; set; }

    public double? InvTotTax { get; set; }

    public double? InvTotIncl { get; set; }

    public double? OrdDiscAmnt { get; set; }

    public double? OrdDiscAmntEx { get; set; }

    [Column("OrdTotExclDEx")]
    public double? OrdTotExclDex { get; set; }

    [Column("OrdTotTaxDEx")]
    public double? OrdTotTaxDex { get; set; }

    [Column("OrdTotInclDEx")]
    public double? OrdTotInclDex { get; set; }

    public double? OrdTotExcl { get; set; }

    public double? OrdTotTax { get; set; }

    public double? OrdTotIncl { get; set; }

    [Column("bUseFixedPrices")]
    public bool? BUseFixedPrices { get; set; }

    [Column("iDocPrinted")]
    public int? IDocPrinted { get; set; }

    [Column("iINVNUMAgentID")]
    public int? IInvnumagentId { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fGrvSplitFixedAmntForeign")]
    public double? FGrvSplitFixedAmntForeign { get; set; }

    [Column("fInvDiscAmntForeign")]
    public double? FInvDiscAmntForeign { get; set; }

    [Column("fInvDiscAmntExForeign")]
    public double? FInvDiscAmntExForeign { get; set; }

    [Column("fInvTotExclDExForeign")]
    public double? FInvTotExclDexForeign { get; set; }

    [Column("fInvTotTaxDExForeign")]
    public double? FInvTotTaxDexForeign { get; set; }

    [Column("fInvTotInclDExForeign")]
    public double? FInvTotInclDexForeign { get; set; }

    [Column("fInvTotExclForeign")]
    public double? FInvTotExclForeign { get; set; }

    [Column("fInvTotTaxForeign")]
    public double? FInvTotTaxForeign { get; set; }

    [Column("fInvTotInclForeign")]
    public double? FInvTotInclForeign { get; set; }

    [Column("fOrdDiscAmntForeign")]
    public double? FOrdDiscAmntForeign { get; set; }

    [Column("fOrdDiscAmntExForeign")]
    public double? FOrdDiscAmntExForeign { get; set; }

    [Column("fOrdTotExclDExForeign")]
    public double? FOrdTotExclDexForeign { get; set; }

    [Column("fOrdTotTaxDExForeign")]
    public double? FOrdTotTaxDexForeign { get; set; }

    [Column("fOrdTotInclDExForeign")]
    public double? FOrdTotInclDexForeign { get; set; }

    [Column("fOrdTotExclForeign")]
    public double? FOrdTotExclForeign { get; set; }

    [Column("fOrdTotTaxForeign")]
    public double? FOrdTotTaxForeign { get; set; }

    [Column("fOrdTotInclForeign")]
    public double? FOrdTotInclForeign { get; set; }

    [Column("cTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxNumber { get; set; }

    [Column("cAccountName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CAccountName { get; set; }

    [Column("iProspectID")]
    public int? IProspectId { get; set; }

    [Column("iOpportunityID")]
    public int? IOpportunityId { get; set; }

    public double? InvTotRounding { get; set; }

    public double? OrdTotRounding { get; set; }

    [Column("fInvTotForeignRounding")]
    public double? FInvTotForeignRounding { get; set; }

    [Column("fOrdTotForeignRounding")]
    public double? FOrdTotForeignRounding { get; set; }

    [Column("bInvRounding")]
    public bool? BInvRounding { get; set; }

    [Column("iInvSettlementTermsID")]
    public int? IInvSettlementTermsId { get; set; }

    [Column("cSettlementTermInvMsg")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSettlementTermInvMsg { get; set; }

    [Column("iOrderCancelReasonID")]
    public int? IOrderCancelReasonId { get; set; }

    [Column("iLinkedDocID")]
    public int? ILinkedDocId { get; set; }

    [Column("bLinkedTemplate")]
    public bool? BLinkedTemplate { get; set; }

    public double? InvTotInclExRounding { get; set; }

    public double? OrdTotInclExRounding { get; set; }

    [Column("fInvTotInclForeignExRounding")]
    public double? FInvTotInclForeignExRounding { get; set; }

    [Column("fOrdTotInclForeignExRounding")]
    public double? FOrdTotInclForeignExRounding { get; set; }

    [Column("iEUNoTCID")]
    public int? IEunoTcid { get; set; }

    [Column("iPOAuthStatus")]
    public int? IPoauthStatus { get; set; }

    [Column("iPOIncidentID")]
    public int? IPoincidentId { get; set; }

    [Column("iSupervisorID")]
    public int? ISupervisorId { get; set; }

    [Column("iMergedDocID")]
    public int? IMergedDocId { get; set; }

    [Column("InvNum_iBranchID")]
    public int? InvNumIBranchId { get; set; }

    [Column("InvNum_dCreatedDate", TypeName = "datetime")]
    public DateTime? InvNumDCreatedDate { get; set; }

    [Column("InvNum_dModifiedDate", TypeName = "datetime")]
    public DateTime? InvNumDModifiedDate { get; set; }

    [Column("InvNum_iCreatedBranchID")]
    public int? InvNumICreatedBranchId { get; set; }

    [Column("InvNum_iModifiedBranchID")]
    public int? InvNumIModifiedBranchId { get; set; }

    [Column("InvNum_iCreatedAgentID")]
    public int? InvNumICreatedAgentId { get; set; }

    [Column("InvNum_iModifiedAgentID")]
    public int? InvNumIModifiedAgentId { get; set; }

    [Column("InvNum_iChangeSetID")]
    public int? InvNumIChangeSetId { get; set; }

    [Column("iDocEmailed")]
    public int? IDocEmailed { get; set; }

    [Column("fDepositAmountForeign")]
    public double? FDepositAmountForeign { get; set; }

    [Column("fRefundAmount")]
    public double? FRefundAmount { get; set; }

    [Column("bTaxPerLine")]
    public bool? BTaxPerLine { get; set; }

    [Column("fDepositAmountTotal")]
    public double? FDepositAmountTotal { get; set; }

    [Column("fDepositAmountUnallocated")]
    public double? FDepositAmountUnallocated { get; set; }

    [Column("fDepositAmountNew")]
    public double? FDepositAmountNew { get; set; }

    [Column("fDepositAmountTotalForeign")]
    public double? FDepositAmountTotalForeign { get; set; }

    [Column("fDepositAmountUnallocatedForeign")]
    public double? FDepositAmountUnallocatedForeign { get; set; }

    [Column("fRefundAmountForeign")]
    public double? FRefundAmountForeign { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? KeepAsideCollectionDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? KeepAsideExpiryDate { get; set; }

    [Column("cContact")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CContact { get; set; }

    [Column("cTelephone")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CTelephone { get; set; }

    [Column("cFax")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CFax { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("cCellular")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CCellular { get; set; }

    [Column("imgOrderSignature")]
    public byte[]? ImgOrderSignature { get; set; }

    [Column("iInsuranceState")]
    public int? IInsuranceState { get; set; }

    [Column("cAuthorisedBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuthorisedBy { get; set; }

    [Column("cClaimNumber")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CClaimNumber { get; set; }

    [Column("cPolicyNumber")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPolicyNumber { get; set; }

    [Column("dIncidentDate", TypeName = "datetime")]
    public DateTime? DIncidentDate { get; set; }

    [Column("cExcessAccName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CExcessAccName { get; set; }

    [Column("cExcessAccCont1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CExcessAccCont1 { get; set; }

    [Column("cExcessAccCont2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CExcessAccCont2 { get; set; }

    [Column("fExcessAmt")]
    public double? FExcessAmt { get; set; }

    [Column("fExcessPct")]
    public double? FExcessPct { get; set; }

    [Column("fExcessExclusive")]
    public double? FExcessExclusive { get; set; }

    [Column("fExcessTax")]
    public double? FExcessTax { get; set; }

    [Column("fExcessInclusive")]
    public double? FExcessInclusive { get; set; }

    [Column("fAddChargeExclusive")]
    public double? FAddChargeExclusive { get; set; }

    [Column("fAddChargeTax")]
    public double? FAddChargeTax { get; set; }

    [Column("fAddChargeInclusive")]
    public double? FAddChargeInclusive { get; set; }

    [Column("fAddChargeExclusiveForeign")]
    public double? FAddChargeExclusiveForeign { get; set; }

    [Column("fAddChargeTaxForeign")]
    public double? FAddChargeTaxForeign { get; set; }

    [Column("fAddChargeInclusiveForeign")]
    public double? FAddChargeInclusiveForeign { get; set; }

    [Column("fOrdAddChargeExclusive")]
    public double? FOrdAddChargeExclusive { get; set; }

    [Column("fOrdAddChargeTax")]
    public double? FOrdAddChargeTax { get; set; }

    [Column("fOrdAddChargeInclusive")]
    public double? FOrdAddChargeInclusive { get; set; }

    [Column("fOrdAddChargeExclusiveForeign")]
    public double? FOrdAddChargeExclusiveForeign { get; set; }

    [Column("fOrdAddChargeTaxForeign")]
    public double? FOrdAddChargeTaxForeign { get; set; }

    [Column("fOrdAddChargeInclusiveForeign")]
    public double? FOrdAddChargeInclusiveForeign { get; set; }

    [Column("iInvoiceSplitDocID")]
    public long? IInvoiceSplitDocId { get; set; }

    [Column("cGIVNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CGivnumber { get; set; }

    [Column("bIsDCOrder")]
    public bool? BIsDcorder { get; set; }

    [Column("iDCBranchID")]
    public int? IDcbranchId { get; set; }

    [Column("iSalesBranchID")]
    public int? ISalesBranchId { get; set; }

    [Column("InvNum_Checksum")]
    [MaxLength(20)]
    public byte[]? InvNumChecksum { get; set; }

    [Column("bIDFProccessed")]
    public bool? BIdfproccessed { get; set; }

    [Column("iImportDeclarationID")]
    public int? IImportDeclarationId { get; set; }

    [Column("bSBSI")]
    public bool? BSbsi { get; set; }

    [Column("cPermitNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPermitNumber { get; set; }

    [Column("iStateID")]
    public int? IStateId { get; set; }

    [Column("ulIDInvEntityRep")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlIdinvEntityRep { get; set; }

    [Column("ulIDSOrdEntityRep")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlIdsordEntityRep { get; set; }

    [Column("DCLink")]
    public int? Dclink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Init { get; set; }

    [Column("Contact_Person")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical5 { get; set; }

    [Column("PhysicalPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PhysicalPc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Addressee { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post5 { get; set; }

    [Column("PostPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PostPc { get; set; }

    [Column("Delivered_To")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveredTo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax2 { get; set; }

    public int? AccountTerms { get; set; }

    [Column("CT")]
    public bool? Ct { get; set; }

    [Column("Tax_Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Registration { get; set; }

    [Column("Credit_Limit")]
    public double? CreditLimit { get; set; }

    [Column("RepID")]
    public int? RepId { get; set; }

    [Column("Interest_Rate")]
    public double? InterestRate { get; set; }

    public double? Discount { get; set; }

    [Column("On_Hold")]
    public bool? OnHold { get; set; }

    [Column("BFOpenType")]
    public int? BfopenType { get; set; }

    [Column("EMail")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    public int? BankLink { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccNum { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccType { get; set; }

    public double? AutoDisc { get; set; }

    public int? DiscMtrxRow { get; set; }

    public int? MainAccLink { get; set; }

    public bool? CashDebtor { get; set; }

    [Column("DCBalance")]
    public double? Dcbalance { get; set; }

    public bool? CheckTerms { get; set; }

    public bool? UseEmail { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("iBusTypeID")]
    public int? IBusTypeId { get; set; }

    [Column("iBusClassID")]
    public int? IBusClassId { get; set; }

    [Column("iCountryID")]
    public int? ICountryId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("dTimeStamp", TypeName = "datetime")]
    public DateTime? DTimeStamp { get; set; }

    [Column("cAccDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CAccDescription { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [Column("iClassID")]
    public int? IClassId { get; set; }

    [Column("iAreasID")]
    public int? IAreasId { get; set; }

    [Column("cBankRefNr")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankRefNr { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("bStatPrint")]
    public bool? BStatPrint { get; set; }

    [Column("bStatEmail")]
    public bool? BStatEmail { get; set; }

    [Column("cStatEmailPass")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CStatEmailPass { get; set; }

    [Column("bForCurAcc")]
    public bool? BForCurAcc { get; set; }

    [Column("fForeignBalance")]
    public double? FForeignBalance { get; set; }

    [Column("bTaxPrompt")]
    public bool? BTaxPrompt { get; set; }

    [Column("iARPriceListNameID")]
    public int? IArpriceListNameId { get; set; }

    [Column("iSettlementTermsID")]
    public int? ISettlementTermsId { get; set; }

    [Column("bSourceDocPrint")]
    public bool? BSourceDocPrint { get; set; }

    [Column("bSourceDocEmail")]
    public bool? BSourceDocEmail { get; set; }

    [Column("iEUCountryID")]
    public int? IEucountryId { get; set; }

    [Column("iDefTaxTypeID")]
    public int? IDefTaxTypeId { get; set; }

    [Column("bCODAccount")]
    public bool? BCodaccount { get; set; }

    [Column("Client_iBranchID")]
    public int? ClientIBranchId { get; set; }

    [Column("Client_dCreatedDate", TypeName = "datetime")]
    public DateTime? ClientDCreatedDate { get; set; }

    [Column("Client_dModifiedDate", TypeName = "datetime")]
    public DateTime? ClientDModifiedDate { get; set; }

    [Column("Client_iCreatedBranchID")]
    public int? ClientICreatedBranchId { get; set; }

    [Column("Client_iModifiedBranchID")]
    public int? ClientIModifiedBranchId { get; set; }

    [Column("Client_iCreatedAgentID")]
    public int? ClientICreatedAgentId { get; set; }

    [Column("Client_iModifiedAgentID")]
    public int? ClientIModifiedAgentId { get; set; }

    [Column("Client_iChangeSetID")]
    public int? ClientIChangeSetId { get; set; }

    [Column("iAgeingTermID")]
    public int? IAgeingTermId { get; set; }

    [Column("bElecDocAcceptance")]
    public bool? BElecDocAcceptance { get; set; }

    [Column("iBankDetailType")]
    public byte? IBankDetailType { get; set; }

    [Column("cBankAccHolder")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankAccHolder { get; set; }

    [Column("cIDNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIdnumber { get; set; }

    [Column("cPassportNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPassportNumber { get; set; }

    [Column("bInsuranceCustomer")]
    public bool? BInsuranceCustomer { get; set; }

    [Column("cBankCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [Column("cSwiftCode")]
    [StringLength(11)]
    [Unicode(false)]
    public string? CSwiftCode { get; set; }

    [Column("Client_Checksum")]
    [MaxLength(20)]
    public byte[]? ClientChecksum { get; set; }

    [Column("iSPQueueID")]
    public int? ISpqueueId { get; set; }

    [Column("bCustomerZoneEnabled")]
    public bool? BCustomerZoneEnabled { get; set; }

    [Column("iTaxState")]
    public int? ITaxState { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TillNo { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? Group { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GroupDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Area { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AreaDescription { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerRepName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerRepCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MasterAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? MasterAccountName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IncidentType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BusinessType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BusClassification { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CountryName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AgentName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AgentFirstName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AgentLastName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [Column("cCurrencySymbol")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CCurrencySymbol { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? OrdCurrencySym { get; set; }

    [Column("cBinLocationName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBinLocationName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? StatusDescription { get; set; }

    public double? QtyOutstanding { get; set; }

    [Column("UOMStockingQtyOutstanding")]
    public double? UomstockingQtyOutstanding { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string DocumentStateDesc { get; set; } = null!;

    [StringLength(400)]
    [Unicode(false)]
    public string? LineItem { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string DocFlagDesc { get; set; } = null!;

    public double? ExPr1 { get; set; }

    public double? InPr1 { get; set; }

    public double? ExPr2 { get; set; }

    public double? InPr2 { get; set; }

    public double? ExPr3 { get; set; }

    public double? InPr3 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CancelReasonCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CancelReason { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? PriorityDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OpportunityNumber { get; set; }

    [Column("UOMUnit_Qty_On_Hand")]
    public double? UomunitQtyOnHand { get; set; }

    [Column("cProductReference")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CProductReference { get; set; }

    [Column("Stock_LeadDays")]
    public double? StockLeadDays { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? StockingUnit { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DimensionDescription { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Comment { get; set; }
}
