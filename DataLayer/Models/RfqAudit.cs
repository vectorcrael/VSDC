using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("RFQ_Audit")]
public partial class RfqAudit
{
    [StringLength(128)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [Column("TableID")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? TableId { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? OldValue { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? NewValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WorkStation { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? Application { get; set; }

    public int? Status { get; set; }
}
