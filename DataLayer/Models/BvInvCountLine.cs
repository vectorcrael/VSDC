using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvInvCountLine
{
    [Column("idInvCountLines")]
    public long IdInvCountLines { get; set; }

    [Column("iInvCountID")]
    public int IInvCountId { get; set; }

    [Column("cItemGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CItemGroup { get; set; }

    [Column("cPack")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CPack { get; set; }

    [Column("cBarcode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CBarcode { get; set; }

    [Column("fSystemQty")]
    public double? FSystemQty { get; set; }

    [Column("fCountQty")]
    public double? FCountQty { get; set; }

    [Column("bModified")]
    public bool BModified { get; set; }

    [Column("bWhseItem")]
    public bool BWhseItem { get; set; }

    [Column("bSerialItem")]
    public bool BSerialItem { get; set; }

    [Column("tSerialList", TypeName = "text")]
    public string? TSerialList { get; set; }

    [Column("bSNAllowDups")]
    public bool BSnallowDups { get; set; }

    [Column("iBinLocationId")]
    public int? IBinLocationId { get; set; }

    [Column("iLotTrackingID")]
    public int? ILotTrackingId { get; set; }

    [Column("bLotItem")]
    public bool BLotItem { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("bUOMCounted")]
    public bool BUomcounted { get; set; }

    [Column("_btblInvCountLines_iBranchID")]
    public int? BtblInvCountLinesIBranchId { get; set; }

    [Column("_btblInvCountLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountLinesDCreatedDate { get; set; }

    [Column("_btblInvCountLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountLinesDModifiedDate { get; set; }

    [Column("_btblInvCountLines_iCreatedBranchID")]
    public int? BtblInvCountLinesICreatedBranchId { get; set; }

    [Column("_btblInvCountLines_iModifiedBranchID")]
    public int? BtblInvCountLinesIModifiedBranchId { get; set; }

    [Column("_btblInvCountLines_iCreatedAgentID")]
    public int? BtblInvCountLinesICreatedAgentId { get; set; }

    [Column("_btblInvCountLines_iModifiedAgentID")]
    public int? BtblInvCountLinesIModifiedAgentId { get; set; }

    [Column("_btblInvCountLines_iChangeSetID")]
    public int? BtblInvCountLinesIChangeSetId { get; set; }

    [Column("bDimensionItem")]
    public bool BDimensionItem { get; set; }

    [Column("_btblInvCountLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvCountLinesChecksum { get; set; }

    [Column("StrictSN")]
    public bool? StrictSn { get; set; }

    [Column("cItemCode")]
    [StringLength(400)]
    [Unicode(false)]
    public string? CItemCode { get; set; }

    [Column("cWarehouse")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CWarehouse { get; set; }

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

    [Column("Qty_On_Hand")]
    public double? QtyOnHand { get; set; }

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

    [Column("iItemCostingMethod")]
    public int? IItemCostingMethod { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PackDescription { get; set; }

    public double? PackSize { get; set; }

    [Column("cBinLocationName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBinLocationName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LotExpiryDate { get; set; }

    [Column("iUomStockingUnitID")]
    public int? IUomStockingUnitId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? StockingUnitCode { get; set; }

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

    [Column("cInvSegValue2Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue2Value { get; set; }

    [Column("cInvSegValue3Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue3Value { get; set; }

    [Column("cInvSegValue4Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue4Value { get; set; }

    [Column("cInvSegValue5Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue5Value { get; set; }

    [Column("cInvSegValue6Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue6Value { get; set; }

    [Column("cInvSegValue7Value")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvSegValue7Value { get; set; }
}
