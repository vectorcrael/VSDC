using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblDocImportFieldMappings")]
public partial class AtblDocImportFieldMapping
{
    [Key]
    [Column("idDocImportFieldMapping")]
    public int IdDocImportFieldMapping { get; set; }

    [Column("iDocImportDocumentTypeID")]
    public int IDocImportDocumentTypeId { get; set; }

    [Column("cTableName")]
    [StringLength(100)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Column("cFieldName")]
    [StringLength(100)]
    [Unicode(false)]
    public string CFieldName { get; set; } = null!;

    [Column("iPosition")]
    public int IPosition { get; set; }

    [Column("bImportCodeInstead")]
    public bool BImportCodeInstead { get; set; }

    [Column("bRequiredField")]
    public bool BRequiredField { get; set; }

    [Column("cCaption")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CCaption { get; set; }

    [Column("bCreate")]
    public bool? BCreate { get; set; }
}
