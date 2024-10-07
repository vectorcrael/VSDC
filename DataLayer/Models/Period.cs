using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class Period
{
    public short? Per { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PerDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Blocked { get; set; } = null!;

    [Column("Period_iBranchID")]
    public int? PeriodIBranchId { get; set; }

    [Column("Period_dCreatedDate", TypeName = "datetime")]
    public DateTime? PeriodDCreatedDate { get; set; }

    [Column("Period_dModifiedDate", TypeName = "datetime")]
    public DateTime? PeriodDModifiedDate { get; set; }

    [Column("Period_iCreatedBranchID")]
    public int? PeriodICreatedBranchId { get; set; }

    [Column("Period_iModifiedBranchID")]
    public int? PeriodIModifiedBranchId { get; set; }

    [Column("Period_iCreatedAgentID")]
    public int? PeriodICreatedAgentId { get; set; }

    [Column("Period_iModifiedAgentID")]
    public int? PeriodIModifiedAgentId { get; set; }

    [Column("Period_iChangeSetID")]
    public int? PeriodIChangeSetId { get; set; }

    [Column("bPBT")]
    public int? BPbt { get; set; }
}
