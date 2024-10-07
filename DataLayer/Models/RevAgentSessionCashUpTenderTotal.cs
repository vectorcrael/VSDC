using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevAgentSessionCashUpTenderTotal
{
    [Column("idAgentSessionTenderTotals")]
    public int IdAgentSessionTenderTotals { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("iTenderTypeID")]
    public int? ITenderTypeId { get; set; }

    [Column("bCashTenderType")]
    public bool BCashTenderType { get; set; }

    [Column("iTypeOfTender")]
    public int? ITypeOfTender { get; set; }

    [Column("cTenderTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CTenderTypeCode { get; set; }

    [Column("cTenderTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CTenderTypeDesc { get; set; }

    [Column("iDisplayOrder")]
    public int? IDisplayOrder { get; set; }

    [Column("bActive")]
    public bool? BActive { get; set; }

    [Column("iTenderCount")]
    public int? ITenderCount { get; set; }

    [Column("fTenderAmountSystem")]
    public double? FTenderAmountSystem { get; set; }

    [Column("fTenderAmountAdjusted")]
    public double? FTenderAmountAdjusted { get; set; }

    [Column("fTenderAmountCounted")]
    public double? FTenderAmountCounted { get; set; }

    [Column("fTenderAmountFinalised")]
    public double? FTenderAmountFinalised { get; set; }
}
