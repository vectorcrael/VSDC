using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblTables")]
public partial class AtblTable
{
    [Key]
    [Column("idTable")]
    public int IdTable { get; set; }

    [Column("cName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cUserFreindlyTableName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CUserFreindlyTableName { get; set; } = null!;

    [Column("cCodeColumn")]
    [StringLength(256)]
    [Unicode(false)]
    public string CCodeColumn { get; set; } = null!;
}
