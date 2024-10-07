using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvDmRowAr
{
    public int Position { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("DrDiscMx_iBranchID")]
    public int? DrDiscMxIBranchId { get; set; }
}
