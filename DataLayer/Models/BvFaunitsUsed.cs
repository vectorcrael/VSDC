using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaunitsUsed
{
    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CAssetCode { get; set; } = null!;

    public int? BookUnitsAvailable { get; set; }

    public int? TaxUnitsAvailable { get; set; }

    public double? BookTotalUnitsUsed { get; set; }

    public double? TaxTotalUnitsUsed { get; set; }
}
