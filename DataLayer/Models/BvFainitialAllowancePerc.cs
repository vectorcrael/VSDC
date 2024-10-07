using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFainitialAllowancePerc
{
    [Column("idAssetTypeNo")]
    public int IdAssetTypeNo { get; set; }

    public double? BookInitialPercentage { get; set; }

    public double? TaxInitialPercentage { get; set; }
}
