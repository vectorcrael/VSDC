using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_wtblSystem")]
public partial class WtblSystem
{
    [Key]
    [Column("idSystem")]
    public int IdSystem { get; set; }

    [Column("cIdentity")]
    [StringLength(35)]
    [Unicode(false)]
    public string? CIdentity { get; set; }

    [Column("cValue")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CValue { get; set; }
}
