using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("_simtblReportLayout")]
public partial class SimtblReportLayout
{
    [Column("idReportLayout")]
    public int IdReportLayout { get; set; }

    [Column("cRptDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string CRptDescription { get; set; } = null!;

    [Column("iModuleId")]
    public int? IModuleId { get; set; }

    [Column("iVersion")]
    public int? IVersion { get; set; }

    [Column("nLayout")]
    public byte[] NLayout { get; set; } = null!;

    [Column("bReadOnly")]
    public bool BReadOnly { get; set; }

    [Column("bIsDefaultLayout")]
    public bool? BIsDefaultLayout { get; set; }
}
