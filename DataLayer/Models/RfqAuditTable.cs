using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_AuditTables")]
public partial class RfqAuditTable
{
    [Key]
    [Column("iAuditTableID")]
    public int IAuditTableId { get; set; }

    [Column("cTableName")]
    [StringLength(200)]
    public string? CTableName { get; set; }

    [Column("bIsAuditing")]
    public bool? BIsAuditing { get; set; }

    [Column("bIsAudit")]
    public bool? BIsAudit { get; set; }
}
