using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvJobTotal
{
    [Column("iJCMasterID")]
    public int? IJcmasterId { get; set; }

    public double? ActSales { get; set; }

    public double? ActCost { get; set; }

    public double? ActTax { get; set; }

    public double? ActInvCost { get; set; }

    public double? ActBudgetSales { get; set; }

    public double? ActBudgetCost { get; set; }

    public double? ActBudgetTax { get; set; }

    public double? ActSalesForeign { get; set; }

    public double? ActBudgetSalesForeign { get; set; }
}
