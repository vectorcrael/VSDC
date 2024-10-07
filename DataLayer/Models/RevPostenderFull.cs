using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPostenderFull
{
    [Column("iTenderTypeID")]
    public int? ITenderTypeId { get; set; }

    [Column("cTenderTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CTenderTypeCode { get; set; }

    [Column("cTenderTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CTenderTypeDesc { get; set; }

    [Column("iTypeOfTender")]
    public int? ITypeOfTender { get; set; }

    [Column("bActive")]
    public bool? BActive { get; set; }

    [Column("iDisplayOrder")]
    public int? IDisplayOrder { get; set; }

    public double? TenderAmount { get; set; }

    [Column("iTillID")]
    public int? ITillId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("dTransactionDate", TypeName = "datetime")]
    public DateTime? DTransactionDate { get; set; }
}
