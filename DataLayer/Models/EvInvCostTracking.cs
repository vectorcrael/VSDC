using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvInvCostTracking
{
    [Column("idCostTracking")]
    public long IdCostTracking { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("iLotID")]
    public int ILotId { get; set; }

    [Column("iAutoIdx")]
    public long IAutoIdx { get; set; }

    [Column("dTxDate", TypeName = "datetime")]
    public DateTime DTxDate { get; set; }

    [Column("dDateStamp", TypeName = "datetime")]
    public DateTime DDateStamp { get; set; }

    [Column("fAverageCost")]
    public double FAverageCost { get; set; }

    [Column("fLatestCost")]
    public double FLatestCost { get; set; }

    [Column("fLowestCost")]
    public double FLowestCost { get; set; }

    [Column("fHighestCost")]
    public double FHighestCost { get; set; }

    [Column("fManualCost")]
    public double FManualCost { get; set; }

    [Column("fQtyOnHand")]
    public double FQtyOnHand { get; set; }

    [Column("fJobQty")]
    public double FJobQty { get; set; }

    [Column("fMFPQty")]
    public double FMfpqty { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }

    [Column("WhseMst_iBranchID")]
    public int? WhseMstIBranchId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WhseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WhseName { get; set; }

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

    public int? StockLink { get; set; }

    public bool? ItemActive { get; set; }

    public bool? ServiceItem { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Pack { get; set; }

    [Column("iLotTrackingId")]
    public int? ILotTrackingId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNumber { get; set; }

    [Column("iLotStatusID")]
    public int? ILotStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotStatusDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LotExpiryDate { get; set; }

    public double? LotQtyOnHand { get; set; }

    [Column("iUomStockingUnitID")]
    public int? IUomStockingUnitId { get; set; }

    public bool? Whseitem { get; set; }

    [Column("bLotItem")]
    public bool? BLotItem { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? StockingUnitCode { get; set; }

    public double? QtyInStock { get; set; }

    public double? QtyInStockExclLots { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemGroupDescription { get; set; }

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

    public double ItemCost { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string CostingMethodDescription { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? BinLocationName { get; set; }

    public int? Bin { get; set; }

    public int? CostingMethod { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PackDescription { get; set; }

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
}
