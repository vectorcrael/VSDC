using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblDeleted")]
[Index("KeyFieldsChecksum", Name = "idx__etblDeleted__KeyFields_Checksum")]
[Index("AuditDate", Name = "idx_etblDeleted_auditDate")]
[Index("CTableName", Name = "idx_etblDeleted_cTableName")]
public partial class EtblDeleted
{
    [Key]
    [Column("idDeleted")]
    public int IdDeleted { get; set; }

    [Column("cTableName")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CTableName { get; set; }

    [Column("cPKFields")]
    [StringLength(512)]
    [Unicode(false)]
    public string? CPkfields { get; set; }

    [Column("cPKValues")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CPkvalues { get; set; }

    [Column("iRowBranchID")]
    public int? IRowBranchId { get; set; }

    [Column("iDeletedAtBranchID")]
    public int? IDeletedAtBranchId { get; set; }

    [Column("_auditDate", TypeName = "datetime")]
    public DateTime? AuditDate { get; set; }

    [Column("_auditHostName")]
    [StringLength(64)]
    [Unicode(false)]
    public string? AuditHostName { get; set; }

    [Column("_auditSystemUser")]
    [StringLength(64)]
    [Unicode(false)]
    public string? AuditSystemUser { get; set; }

    [Column("_auditUserName")]
    [StringLength(64)]
    [Unicode(false)]
    public string? AuditUserName { get; set; }

    [Column("_auditAppName")]
    [StringLength(128)]
    [Unicode(false)]
    public string? AuditAppName { get; set; }

    [Column("iChangeSetID")]
    public int? IChangeSetId { get; set; }

    [Column("_KeyFields_Checksum")]
    [MaxLength(20)]
    public byte[]? KeyFieldsChecksum { get; set; }
}
