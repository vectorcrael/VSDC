using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvStockEuinfo
{
    public int StockLink { get; set; }

    [Column("iEUCommodityID")]
    public int IEucommodityId { get; set; }

    [Column("cEUCommodityCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEucommodityCode { get; set; }

    [Column("iEUSupplementaryUnitID")]
    public int IEusupplementaryUnitId { get; set; }

    [Column("cEUSupplementaryUnitCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEusupplementaryUnitCode { get; set; }

    [Column("fNetMass")]
    public double FNetMass { get; set; }
}
