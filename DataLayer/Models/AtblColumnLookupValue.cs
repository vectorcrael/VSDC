using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblColumnLookupValues")]
public partial class AtblColumnLookupValue
{
    [Key]
    [Column("idColumnLookupValue")]
    public int IdColumnLookupValue { get; set; }

    [Column("iColumnLookupID")]
    public int IColumnLookupId { get; set; }

    [Column("cLookupCode")]
    [StringLength(100)]
    [Unicode(false)]
    public string CLookupCode { get; set; } = null!;

    [Column("cValue")]
    [StringLength(100)]
    [Unicode(false)]
    public string CValue { get; set; } = null!;
}
