using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblLotTrackingQty")]
[Index("EtblLotTrackingQtyChecksum", Name = "idx__etblLotTrackingQty__etblLotTrackingQty_Checksum")]
[Index("EtblLotTrackingQtyIChangeSetId", Name = "idx__etblLotTrackingQty_iChangeSetID")]
[Index("EtblLotTrackingQtyDModifiedDate", Name = "idx_etblLotTrackingQty_dModifiedDate")]
[Index("EtblLotTrackingQtyIBranchId", Name = "idx_etblLotTrackingQty_iBranchID")]
public partial class EtblLotTrackingQty
{
    [Key]
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
}
