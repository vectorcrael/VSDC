using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblColumnLookups")]
public partial class AtblColumnLookup
{
    [Key]
    [Column("idColumnLookup")]
    public int IdColumnLookup { get; set; }

    [Column("cTableName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Column("cColumnName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CColumnName { get; set; } = null!;

    [Column("cLookupTable")]
    [StringLength(256)]
    [Unicode(false)]
    public string CLookupTable { get; set; } = null!;

    [Column("cLookupColumn")]
    [StringLength(256)]
    [Unicode(false)]
    public string CLookupColumn { get; set; } = null!;

    [Column("bIsValueLookup")]
    public bool BIsValueLookup { get; set; }
}
