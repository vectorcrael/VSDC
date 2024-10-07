using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvInvPriceUpdateBatchLine
{
    [Column("idInvPriceUpdateBatchLines")]
    public int IdInvPriceUpdateBatchLines { get; set; }

    [Column("iInvPriceUpdateBatchID")]
    public int IInvPriceUpdateBatchId { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("iPriceListID")]
    public int IPriceListId { get; set; }

    [Column("fExclPrice")]
    public double? FExclPrice { get; set; }

    [Column("fInclPrice")]
    public double? FInclPrice { get; set; }

    [Column("iCostMethod")]
    public int? ICostMethod { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("fGrossMargin")]
    public double? FGrossMargin { get; set; }

    [Column("fGMPercentage")]
    public double? FGmpercentage { get; set; }

    [Column("iUpdateType")]
    public int? IUpdateType { get; set; }

    [Column("iUpdateAction")]
    public int? IUpdateAction { get; set; }

    [Column("fPercentageChange")]
    public double? FPercentageChange { get; set; }

    [Column("iRounding")]
    public int? IRounding { get; set; }

    [Column("iToNearest")]
    public int? IToNearest { get; set; }

    [Column("fUpdatePrice")]
    public double? FUpdatePrice { get; set; }

    [Column("fNewExclPrice")]
    public double? FNewExclPrice { get; set; }

    [Column("fNewInclPrice")]
    public double? FNewInclPrice { get; set; }

    [Column("fNewGrossMargin")]
    public double? FNewGrossMargin { get; set; }

    [Column("fNewGMPercentage")]
    public double? FNewGmpercentage { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_iBranchID")]
    public int? EtblInvPriceUpdateBatchLinesIBranchId { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvPriceUpdateBatchLinesDCreatedDate { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvPriceUpdateBatchLinesDModifiedDate { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_iCreatedBranchID")]
    public int? EtblInvPriceUpdateBatchLinesICreatedBranchId { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_iModifiedBranchID")]
    public int? EtblInvPriceUpdateBatchLinesIModifiedBranchId { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_iCreatedAgentID")]
    public int? EtblInvPriceUpdateBatchLinesICreatedAgentId { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_iModifiedAgentID")]
    public int? EtblInvPriceUpdateBatchLinesIModifiedAgentId { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_iChangeSetID")]
    public int? EtblInvPriceUpdateBatchLinesIChangeSetId { get; set; }

    [Column("_etblInvPriceUpdateBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvPriceUpdateBatchLinesChecksum { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? UpdateType { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? UpdateAction { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? Rounding { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ToNearest { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PriceListName { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription { get; set; }

    public double? ItemCost { get; set; }

    public double? QtyOnHand { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Warehouse { get; set; }
}
