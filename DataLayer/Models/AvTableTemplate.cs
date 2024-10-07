using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class AvTableTemplate
{
    [Column("cTableName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Column("cUserFreindlyTableName")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CUserFreindlyTableName { get; set; }

    [Column("cCodeColumn")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CCodeColumn { get; set; }
}
