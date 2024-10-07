using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAuditingLog")]
public partial class EtblAuditingLog
{
    [Key]
    [Column("idAuditingLog")]
    public int IdAuditingLog { get; set; }

    [Column("dModificationDate", TypeName = "datetime")]
    public DateTime DModificationDate { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("cTableName")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CTableName { get; set; }

    [Column("iActionType")]
    public int? IActionType { get; set; }

    [Column("cComment")]
    [StringLength(4096)]
    [Unicode(false)]
    public string? CComment { get; set; }
}
