using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvStockCostsVariance
{
    [Column("iStockCodeID")]
    public int? IStockCodeId { get; set; }

    [Column("cStockCode")]
    [StringLength(400)]
    [Unicode(false)]
    public string? CStockCode { get; set; }

    [Column("cDescription1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription1 { get; set; }

    [Column("bItemActive")]
    public bool? BItemActive { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("cWarehouseCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CWarehouseCode { get; set; }

    [Column("iBranchID")]
    public int? IBranchId { get; set; }

    [Column("fLowestCost")]
    public double FLowestCost { get; set; }

    [Column("fHighestCost")]
    public double FHighestCost { get; set; }

    [Column("fLastGRVCost")]
    public double FLastGrvcost { get; set; }

    [Column("fLatestCost")]
    public double FLatestCost { get; set; }

    [Column("fAverageCost")]
    public double FAverageCost { get; set; }

    [Column("fAverageToLatestCostVariance")]
    public double FAverageToLatestCostVariance { get; set; }

    [Column("fAverageToLastGRVCostVariance")]
    public double FAverageToLastGrvcostVariance { get; set; }

    [Column("fQtyOnHand")]
    public double FQtyOnHand { get; set; }
}
