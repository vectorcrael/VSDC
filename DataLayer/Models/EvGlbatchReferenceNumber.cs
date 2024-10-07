using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvGlbatchReferenceNumber
{
    [Column("cReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference2 { get; set; }
}
