using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvWhseTrfBatchLine
{
    [Column("idWhseTransferBatchLines")]
    public int IdWhseTransferBatchLines { get; set; }

    [Column("iWhseTransferBatchID")]
    public int? IWhseTransferBatchId { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iFromWhseID")]
    public int? IFromWhseId { get; set; }

    [Column("iToWhseID")]
    public int? IToWhseId { get; set; }

    [Column("fQuantity")]
    public double? FQuantity { get; set; }

    [Column("fCost")]
    public double? FCost { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bIsSerialItem")]
    public bool BIsSerialItem { get; set; }

    [Column("iSerialNumberGroupID")]
    public int? ISerialNumberGroupId { get; set; }

    [Column("bIsLotItem")]
    public bool BIsLotItem { get; set; }

    [Column("iLotID")]
    public int ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("_etblWhseTransferBatchLines_iBranchID")]
    public int? EtblWhseTransferBatchLinesIBranchId { get; set; }

    [Column("_etblWhseTransferBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseTransferBatchLinesDCreatedDate { get; set; }

    [Column("_etblWhseTransferBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseTransferBatchLinesDModifiedDate { get; set; }

    [Column("_etblWhseTransferBatchLines_iCreatedBranchID")]
    public int? EtblWhseTransferBatchLinesICreatedBranchId { get; set; }

    [Column("_etblWhseTransferBatchLines_iModifiedBranchID")]
    public int? EtblWhseTransferBatchLinesIModifiedBranchId { get; set; }

    [Column("_etblWhseTransferBatchLines_iCreatedAgentID")]
    public int? EtblWhseTransferBatchLinesICreatedAgentId { get; set; }

    [Column("_etblWhseTransferBatchLines_iModifiedAgentID")]
    public int? EtblWhseTransferBatchLinesIModifiedAgentId { get; set; }

    [Column("_etblWhseTransferBatchLines_iChangeSetID")]
    public int? EtblWhseTransferBatchLinesIChangeSetId { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("_etblWhseTransferBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseTransferBatchLinesChecksum { get; set; }

    [Column("UOMStockingUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomstockingUnitCode { get; set; }

    [Column("UOMUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomunitCode { get; set; }

    [Column("UOMUnitDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UomunitDescription { get; set; }

    [Column("UOMUnitQuantity")]
    public double? UomunitQuantity { get; set; }

    [Column("UOMUnitNewCost")]
    public double? UomunitNewCost { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? FromWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromWhName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ToWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ToWhName { get; set; }

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
}
