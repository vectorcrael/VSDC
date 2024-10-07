using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvInvJrBatchLine
{
    [Column("idInvJrBatchLines")]
    public int IdInvJrBatchLines { get; set; }

    [Column("iInvJrBatchID")]
    public int IInvJrBatchId { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("dTrDate", TypeName = "datetime")]
    public DateTime DTrDate { get; set; }

    [Column("iTrCodeID")]
    public int ITrCodeId { get; set; }

    [Column("iGLContraID")]
    public int IGlcontraId { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fQtyIn")]
    public double? FQtyIn { get; set; }

    [Column("fQtyOut")]
    public double? FQtyOut { get; set; }

    [Column("fNewCost")]
    public double? FNewCost { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("bIsSerialItem")]
    public bool BIsSerialItem { get; set; }

    [Column("bIsLotItem")]
    public bool BIsLotItem { get; set; }

    [Column("iSNGroupID")]
    public int ISngroupId { get; set; }

    [Column("iJobID")]
    public int IJobId { get; set; }

    [Column("iLotID")]
    public int ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("_etblInvJrBatchLines_iBranchID")]
    public int? EtblInvJrBatchLinesIBranchId { get; set; }

    [Column("_etblInvJrBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchLinesDCreatedDate { get; set; }

    [Column("_etblInvJrBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchLinesDModifiedDate { get; set; }

    [Column("_etblInvJrBatchLines_iCreatedBranchID")]
    public int? EtblInvJrBatchLinesICreatedBranchId { get; set; }

    [Column("_etblInvJrBatchLines_iModifiedBranchID")]
    public int? EtblInvJrBatchLinesIModifiedBranchId { get; set; }

    [Column("_etblInvJrBatchLines_iCreatedAgentID")]
    public int? EtblInvJrBatchLinesICreatedAgentId { get; set; }

    [Column("_etblInvJrBatchLines_iModifiedAgentID")]
    public int? EtblInvJrBatchLinesIModifiedAgentId { get; set; }

    [Column("_etblInvJrBatchLines_iChangeSetID")]
    public int? EtblInvJrBatchLinesIChangeSetId { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("_etblInvJrBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvJrBatchLinesChecksum { get; set; }

    public double? AdjQty { get; set; }

    public double? AdjValue { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription { get; set; }

    public double? ItemCost { get; set; }

    public double? QtyOnHand { get; set; }

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

    [Column("UOMUnitAdjQty")]
    public double? UomunitAdjQty { get; set; }

    [Column("UOMUnitQtyOnHand")]
    public double? UomunitQtyOnHand { get; set; }

    [Column("UOMUnitItemCost")]
    public double? UomunitItemCost { get; set; }

    [Column("UOMUnitNewCost")]
    public double? UomunitNewCost { get; set; }

    [Column("UOMUnitAdjValue")]
    public double? UomunitAdjValue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Warehouse { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TrCodeDescroption { get; set; }

    [Column("GLContraAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? GlcontraAccount { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? GlContraDescription { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JobCode { get; set; }
}
