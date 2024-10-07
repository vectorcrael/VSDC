using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvCostTracking")]
[Index("IStockId", "DDateStamp", Name = "idx__etblInvCostTracking_iStockIDdDateStamp")]
public partial class EtblInvCostTracking
{
    [Key]
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
}
