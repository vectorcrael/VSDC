using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSystem")]
public partial class EtblSystem
{
    [Key]
    [Column("idSystem")]
    public int IdSystem { get; set; }

    [Column("cIdentity")]
    [StringLength(35)]
    [Unicode(false)]
    public string CIdentity { get; set; } = null!;

    [Column("cValue")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CValue { get; set; }
}
