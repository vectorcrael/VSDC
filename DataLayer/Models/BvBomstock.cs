using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvBomstock
{
    [Column("BomID")]
    public int BomId { get; set; }

    public int? BomStockLink { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BomStockCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BomDescription { get; set; }

    public double? BomProductionQty { get; set; }

    public double? BomUnitCost { get; set; }

    public double? ThisLevelCost { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateLastCosted { get; set; }

    [Column("bBreakOnGrv")]
    public bool BBreakOnGrv { get; set; }

    [Column("bBreakAllocCostsbyPerc")]
    public bool BBreakAllocCostsbyPerc { get; set; }

    [Column("bShowComponentsOnGRV")]
    public bool BShowComponentsOnGrv { get; set; }

    [Column("bShowAvailAllLevels")]
    public bool BShowAvailAllLevels { get; set; }

    [Column("bShowCompOnInv")]
    public bool BShowCompOnInv { get; set; }

    [Column("bManufWithDefaultWH")]
    public bool BManufWithDefaultWh { get; set; }

    [Column("bBreakUpWithDefaultWH")]
    public bool BBreakUpWithDefaultWh { get; set; }

    [Column("bAllowOverUnderManufacture")]
    public bool BAllowOverUnderManufacture { get; set; }

    [Column("BomMast_iBranchID")]
    public int? BomMastIBranchId { get; set; }

    [Column("BomMast_dCreatedDate", TypeName = "datetime")]
    public DateTime? BomMastDCreatedDate { get; set; }

    [Column("BomMast_dModifiedDate", TypeName = "datetime")]
    public DateTime? BomMastDModifiedDate { get; set; }

    [Column("BomMast_iCreatedBranchID")]
    public int? BomMastICreatedBranchId { get; set; }

    [Column("BomMast_iModifiedBranchID")]
    public int? BomMastIModifiedBranchId { get; set; }

    [Column("BomMast_iCreatedAgentID")]
    public int? BomMastICreatedAgentId { get; set; }

    [Column("BomMast_iModifiedAgentID")]
    public int? BomMastIModifiedAgentId { get; set; }

    [Column("BomMast_iChangeSetID")]
    public int? BomMastIChangeSetId { get; set; }

    [Column("BomMast_fLeadDays")]
    public double? BomMastFLeadDays { get; set; }

    [Column("BomMast_Checksum")]
    [MaxLength(20)]
    public byte[]? BomMastChecksum { get; set; }

    [Column("bExplodeOnDocument")]
    public bool? BExplodeOnDocument { get; set; }

    public double? ItemCost { get; set; }

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

    public int? DefaultSupplierLink { get; set; }

    [Column("idBinLocation")]
    public int? IdBinLocation { get; set; }

    [Column("cBinLocationName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBinLocationName { get; set; }

    [Column("_btblBINLocation_iBranchID")]
    public int? BtblBinlocationIBranchId { get; set; }

    [Column("_btblBINLocation_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblBinlocationDCreatedDate { get; set; }

    [Column("_btblBINLocation_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblBinlocationDModifiedDate { get; set; }

    [Column("_btblBINLocation_iCreatedBranchID")]
    public int? BtblBinlocationICreatedBranchId { get; set; }

    [Column("_btblBINLocation_iModifiedBranchID")]
    public int? BtblBinlocationIModifiedBranchId { get; set; }

    [Column("_btblBINLocation_iCreatedAgentID")]
    public int? BtblBinlocationICreatedAgentId { get; set; }

    [Column("_btblBINLocation_iModifiedAgentID")]
    public int? BtblBinlocationIModifiedAgentId { get; set; }

    [Column("_btblBINLocation_iChangeSetID")]
    public int? BtblBinlocationIChangeSetId { get; set; }

    [Column("cBinLocationDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CBinLocationDescription { get; set; }

    [Column("_btblBINLocation_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblBinlocationChecksum { get; set; }

    public int? GroupStockAccount { get; set; }
}
