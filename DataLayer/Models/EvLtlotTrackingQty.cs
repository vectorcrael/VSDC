using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvLtlotTrackingQty
{
    [Column("idLotTracking")]
    public int? IdLotTracking { get; set; }

    [Column("cLotDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotDescription { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iLotStatusID")]
    public int? ILotStatusId { get; set; }

    [Column("dExpiryDate", TypeName = "datetime")]
    public DateTime? DExpiryDate { get; set; }

    [Column("bIsActive")]
    public bool? BIsActive { get; set; }

    [Column("_etblLotTracking_iBranchID")]
    public int? EtblLotTrackingIBranchId { get; set; }

    [Column("_etblLotTracking_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingDCreatedDate { get; set; }

    [Column("_etblLotTracking_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingDModifiedDate { get; set; }

    [Column("_etblLotTracking_iCreatedBranchID")]
    public int? EtblLotTrackingICreatedBranchId { get; set; }

    [Column("_etblLotTracking_iModifiedBranchID")]
    public int? EtblLotTrackingIModifiedBranchId { get; set; }

    [Column("_etblLotTracking_iCreatedAgentID")]
    public int? EtblLotTrackingICreatedAgentId { get; set; }

    [Column("_etblLotTracking_iModifiedAgentID")]
    public int? EtblLotTrackingIModifiedAgentId { get; set; }

    [Column("_etblLotTracking_iChangeSetID")]
    public int? EtblLotTrackingIChangeSetId { get; set; }

    [Column("dLastGRVDate", TypeName = "datetime")]
    public DateTime? DLastGrvdate { get; set; }

    [Column("_etblLotTracking_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblLotTrackingChecksum { get; set; }

    [Column("idLotTrackingQty")]
    public int IdLotTrackingQty { get; set; }

    [Column("iLotTrackingID")]
    public int? ILotTrackingId { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("fQtyOnHand")]
    public double? FQtyOnHand { get; set; }

    [Column("fQtyPurchased")]
    public double? FQtyPurchased { get; set; }

    [Column("fQtySold")]
    public double? FQtySold { get; set; }

    [Column("fQtyAdjustOut")]
    public double? FQtyAdjustOut { get; set; }

    [Column("fQtyAdjustIn")]
    public double? FQtyAdjustIn { get; set; }

    [Column("fQtyToSupplier")]
    public double? FQtyToSupplier { get; set; }

    [Column("fQtyFromClient")]
    public double? FQtyFromClient { get; set; }

    [Column("fQtyFromWarehouse")]
    public double? FQtyFromWarehouse { get; set; }

    [Column("fQtyToWarehouse")]
    public double? FQtyToWarehouse { get; set; }

    [Column("fQtyReserved")]
    public double? FQtyReserved { get; set; }

    [Column("fQtyJCWIP")]
    public double? FQtyJcwip { get; set; }

    [Column("fQtyMFWIP")]
    public double? FQtyMfwip { get; set; }

    [Column("_etblLotTrackingQty_iBranchID")]
    public int? EtblLotTrackingQtyIBranchId { get; set; }

    [Column("_etblLotTrackingQty_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingQtyDCreatedDate { get; set; }

    [Column("_etblLotTrackingQty_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingQtyDModifiedDate { get; set; }

    [Column("_etblLotTrackingQty_iCreatedBranchID")]
    public int? EtblLotTrackingQtyICreatedBranchId { get; set; }

    [Column("_etblLotTrackingQty_iModifiedBranchID")]
    public int? EtblLotTrackingQtyIModifiedBranchId { get; set; }

    [Column("_etblLotTrackingQty_iCreatedAgentID")]
    public int? EtblLotTrackingQtyICreatedAgentId { get; set; }

    [Column("_etblLotTrackingQty_iModifiedAgentID")]
    public int? EtblLotTrackingQtyIModifiedAgentId { get; set; }

    [Column("_etblLotTrackingQty_iChangeSetID")]
    public int? EtblLotTrackingQtyIChangeSetId { get; set; }

    [Column("_etblLotTrackingQty_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblLotTrackingQtyChecksum { get; set; }

    [Column("cLotStatusDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotStatusDescription { get; set; }
}
