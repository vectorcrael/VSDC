using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevCashPickupDenominationFull
{
    [Column("idCashPickupDenomination")]
    public int IdCashPickupDenomination { get; set; }

    [Column("iCashPickupID")]
    public int? ICashPickupId { get; set; }

    [Column("cDenominationCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CDenominationCode { get; set; }

    [Column("mMultiple", TypeName = "money")]
    public decimal? MMultiple { get; set; }

    [Column("iCashCount")]
    public int? ICashCount { get; set; }

    [Column("fCashValue", TypeName = "money")]
    public decimal? FCashValue { get; set; }
}
