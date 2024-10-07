using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvDmRowAp
{
    public int Position { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("CrDiscMx_iBranchID")]
    public int? CrDiscMxIBranchId { get; set; }
}
