using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblColumns")]
public partial class AtblColumn
{
    [Key]
    [Column("idColumn")]
    public int IdColumn { get; set; }

    [Column("cTableName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Column("cColumnName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CColumnName { get; set; } = null!;

    [Column("iColumnSelectType")]
    public int IColumnSelectType { get; set; }

    [Column("cDefaultValue")]
    [StringLength(1000)]
    [Unicode(false)]
    public string CDefaultValue { get; set; } = null!;

    [Column("bSystemColumn")]
    public bool BSystemColumn { get; set; }
}
