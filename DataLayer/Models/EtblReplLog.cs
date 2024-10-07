using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblReplLog")]
[Index("IChangeSetId", Name = "idx_etblReplLog_iChangeSetID")]
public partial class EtblReplLog
{
    [Key]
    [Column("idReplLog")]
    public int IdReplLog { get; set; }

    [Column("iChangeSetID")]
    public int IChangeSetId { get; set; }

    [Column("iBranchID")]
    public int IBranchId { get; set; }

    [Column("cAction")]
    [StringLength(1)]
    [Unicode(false)]
    public string CAction { get; set; } = null!;

    [Column("dInitDateUtc", TypeName = "datetime")]
    public DateTime? DInitDateUtc { get; set; }

    [Column("cFileName")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CFileName { get; set; }
}
