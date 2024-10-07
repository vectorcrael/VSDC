using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvTotalSalesTodayForSalesRep
{
    [Column("idSalesRep")]
    public int IdSalesRep { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Name { get; set; }

    public double TotalSalesForDay { get; set; }
}
