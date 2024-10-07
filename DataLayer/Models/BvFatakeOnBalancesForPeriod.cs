using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFatakeOnBalancesForPeriod
{
    [Column("iYear")]
    public int IYear { get; set; }

    [Column("fDeprPriorYearsTakeOn")]
    public double? FDeprPriorYearsTakeOn { get; set; }

    [Column("fDeprCurrYearTakeOn")]
    public double? FDeprCurrYearTakeOn { get; set; }

    [Column("fWTPriorYearsTakeOn")]
    public double? FWtpriorYearsTakeOn { get; set; }

    [Column("fWTCurrYearTakeOn")]
    public double? FWtcurrYearTakeOn { get; set; }
}
