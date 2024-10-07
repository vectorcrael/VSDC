using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaglperiod
{
    [Column("idGLPeriodNo")]
    public int IdGlperiodNo { get; set; }

    [Column("dStartDate", TypeName = "smalldatetime")]
    public DateTime DStartDate { get; set; }

    [Column("dEndDate", TypeName = "smalldatetime")]
    public DateTime DEndDate { get; set; }

    [Column("cDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("iYear")]
    public int IYear { get; set; }

    [Column("iPeriodNo")]
    public int IPeriodNo { get; set; }

    [Column("bBlockInd")]
    [StringLength(5)]
    [Unicode(false)]
    public string BBlockInd { get; set; } = null!;
}
