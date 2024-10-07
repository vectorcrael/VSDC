using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCapexBudgetAndAssetForCostCentre
{
    public int Counter { get; set; }

    [Column("idCapexBudgetNo")]
    public int IdCapexBudgetNo { get; set; }

    [Column("idAssetNo")]
    public int IdAssetNo { get; set; }
}
