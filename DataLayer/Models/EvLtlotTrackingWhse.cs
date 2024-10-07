using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvLtlotTrackingWhse
{
    [Column("idLotTracking")]
    public int IdLotTracking { get; set; }

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
    public bool BIsActive { get; set; }

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

    [Column("idLotStatus")]
    public int? IdLotStatus { get; set; }

    [Column("cLotStatusDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotStatusDescription { get; set; }

    [Column("bAllowPurchases")]
    public bool? BAllowPurchases { get; set; }

    [Column("bAllowSales")]
    public bool? BAllowSales { get; set; }

    [Column("_etblLotStatus_iBranchID")]
    public int? EtblLotStatusIBranchId { get; set; }

    [Column("_etblLotStatus_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblLotStatusDCreatedDate { get; set; }

    [Column("_etblLotStatus_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblLotStatusDModifiedDate { get; set; }

    [Column("_etblLotStatus_iCreatedBranchID")]
    public int? EtblLotStatusICreatedBranchId { get; set; }

    [Column("_etblLotStatus_iModifiedBranchID")]
    public int? EtblLotStatusIModifiedBranchId { get; set; }

    [Column("_etblLotStatus_iCreatedAgentID")]
    public int? EtblLotStatusICreatedAgentId { get; set; }

    [Column("_etblLotStatus_iModifiedAgentID")]
    public int? EtblLotStatusIModifiedAgentId { get; set; }

    [Column("_etblLotStatus_iChangeSetID")]
    public int? EtblLotStatusIChangeSetId { get; set; }

    [Column("_etblLotStatus_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblLotStatusChecksum { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("Description_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    public bool? ServiceItem { get; set; }

    public bool? WhseItem { get; set; }

    public bool? SerialItem { get; set; }

    [Column("bLotMustExpire")]
    public bool? BLotMustExpire { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BomCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WarehouseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    public double? QtyOnHand { get; set; }

    public double? QtyReserved { get; set; }

    public double? QtyAvailable { get; set; }
}
