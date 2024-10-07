using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevAgentSessionCashUpDenomination
{
    [Column("idAgentSessionDenomination")]
    public int IdAgentSessionDenomination { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("iDenominationID")]
    public int? IDenominationId { get; set; }

    [Column("cDenominationCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CDenominationCode { get; set; }

    [Column("mMultiple", TypeName = "money")]
    public decimal? MMultiple { get; set; }

    [Column("iFloatCount")]
    public int? IFloatCount { get; set; }

    [Column(TypeName = "money")]
    public decimal? FloatValue { get; set; }

    [Column("iCashCount")]
    public int? ICashCount { get; set; }

    [Column(TypeName = "money")]
    public decimal? CashValue { get; set; }
}
