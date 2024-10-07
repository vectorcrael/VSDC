using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaendDate
{
    [Column("iYear")]
    public int IYear { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }
}
