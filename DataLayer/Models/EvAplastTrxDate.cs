using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvAplastTrxDate
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? InvoiceDate { get; set; }

    public int? AccountLink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone { get; set; }
}
