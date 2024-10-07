using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFauu
{
    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("cDeprTypeInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CDeprTypeInd { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }
}
