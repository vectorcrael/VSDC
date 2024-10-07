using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvStockAndWhseItemsExPl
{
    public int? StockLink { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("cSimpleCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSimpleCode { get; set; }

    [Column("cExtDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CExtDescription { get; set; }

    public int WhseLink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WhseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WhseName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WhseKnownAs { get; set; }

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

    [Column("iBinLocationID")]
    public int? IBinLocationId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemGroup { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BinLocationName { get; set; }

    public int? Bin { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Pack { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? BarCode { get; set; }

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

    [Column("Re_Ord_Lvl")]
    public double? ReOrdLvl { get; set; }

    [Column("Re_Ord_Qty")]
    public double? ReOrdQty { get; set; }

    [Column("Min_Lvl")]
    public double? MinLvl { get; set; }

    [Column("Max_Lvl")]
    public double? MaxLvl { get; set; }

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

    public double? PackSize { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PackDescription { get; set; }

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

    public double? ItemCost { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string CostingMethodDescription { get; set; } = null!;

    public int? CostingMethod { get; set; }

    [Column("Qty_On_Hand")]
    public double? QtyOnHand { get; set; }

    [Column("LastGRVCost")]
    public double? LastGrvcost { get; set; }

    [Column("LGRVCount")]
    public double? Lgrvcount { get; set; }

    public bool? ServiceItem { get; set; }

    public bool? ItemActive { get; set; }

    public double? ReservedQty { get; set; }

    [Column("QtyOnPO")]
    public double? QtyOnPo { get; set; }

    [Column("QtyOnSO")]
    public double? QtyOnSo { get; set; }

    public double? DeliveryQty { get; set; }

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

    [Column("MFPQty")]
    public double? Mfpqty { get; set; }

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

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemGroupDescription { get; set; }

    public double QtyInStock { get; set; }

    [Column("WHUsePriceDefs")]
    public bool? WhusePriceDefs { get; set; }

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

    [Column("cInvSegValue1Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue1Value { get; set; }

    [Column("cInvSegValue1Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue1Desc { get; set; }

    [Column("iInvSegValue1GroupID")]
    public int? IInvSegValue1GroupId { get; set; }

    [Column("cInvSegGroup1Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup1Desc { get; set; }

    [Column("cInvSegValue2Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue2Value { get; set; }

    [Column("cInvSegValue2Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue2Desc { get; set; }

    [Column("iInvSegValue2GroupID")]
    public int? IInvSegValue2GroupId { get; set; }

    [Column("cInvSegGroup2Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup2Desc { get; set; }

    [Column("cInvSegValue3Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue3Value { get; set; }

    [Column("cInvSegValue3Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue3Desc { get; set; }

    [Column("iInvSegValue3GroupID")]
    public int? IInvSegValue3GroupId { get; set; }

    [Column("cInvSegGroup3Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup3Desc { get; set; }

    [Column("cInvSegValue4Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue4Value { get; set; }

    [Column("cInvSegValue4Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue4Desc { get; set; }

    [Column("iInvSegValue4GroupID")]
    public int? IInvSegValue4GroupId { get; set; }

    [Column("cInvSegGroup4Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup4Desc { get; set; }

    [Column("cInvSegValue5Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue5Value { get; set; }

    [Column("cInvSegValue5Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue5Desc { get; set; }

    [Column("iInvSegValue5GroupID")]
    public int? IInvSegValue5GroupId { get; set; }

    [Column("cInvSegGroup5Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup5Desc { get; set; }

    [Column("cInvSegValue6Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue6Value { get; set; }

    [Column("cInvSegValue6Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue6Desc { get; set; }

    [Column("iInvSegValue6GroupID")]
    public int? IInvSegValue6GroupId { get; set; }

    [Column("cInvSegGroup6Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup6Desc { get; set; }

    [Column("cInvSegValue7Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue7Value { get; set; }

    [Column("cInvSegValue7Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue7Desc { get; set; }

    [Column("iInvSegValue7GroupID")]
    public int? IInvSegValue7GroupId { get; set; }

    [Column("cInvSegGroup7Desc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegGroup7Desc { get; set; }

    [Column("bLotItem")]
    public bool? BLotItem { get; set; }

    [Column("bLotMustExpire")]
    public bool? BLotMustExpire { get; set; }

    [Column("iLotStatus")]
    public int? ILotStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotStatusDescription { get; set; }

    [Column("iUOMStockingUnitID")]
    public int? IUomstockingUnitId { get; set; }

    [Column("iUOMDefSellUnitID")]
    public int? IUomdefSellUnitId { get; set; }

    [Column("iUOMDefPurchaseUnitID")]
    public int? IUomdefPurchaseUnitId { get; set; }

    [Column("UOMStockingUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomstockingUnitCode { get; set; }

    [Column("UOMDefPurchaseUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomdefPurchaseUnitCode { get; set; }

    [Column("UOMDefSellingUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomdefSellingUnitCode { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }

    [Column("WhseMst_iBranchID")]
    public int? WhseMstIBranchId { get; set; }

    [Column("bAllowNegStock")]
    public bool? BAllowNegStock { get; set; }

    [Column("bWHAllowNegStock")]
    public bool? BWhallowNegStock { get; set; }

    [Column("Stock_LeadDays")]
    public double? StockLeadDays { get; set; }

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

    [Column("bAirtimeItem")]
    public bool? BAirtimeItem { get; set; }

    [Column("WhseStock_LeadDays")]
    public double? WhseStockLeadDays { get; set; }

    [Column("bDimensionItem")]
    public bool? BDimensionItem { get; set; }

    [StringLength(4000)]
    public string? StockingUnit { get; set; }

    [Column("fIBTQtyToIssue")]
    public double? FIbtqtyToIssue { get; set; }

    [Column("fIBTQtyToReceive")]
    public double? FIbtqtyToReceive { get; set; }

    [Column("bVASItem")]
    public bool? BVasitem { get; set; }
}
