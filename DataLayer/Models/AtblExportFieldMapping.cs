using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblExportFieldMappings")]
public partial class AtblExportFieldMapping
{
    [Key]
    [Column("idExportFieldMapping")]
    public int IdExportFieldMapping { get; set; }

    [Column("iExportTemplateID")]
    public int IExportTemplateId { get; set; }

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

    [Column("cCaption")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CCaption { get; set; }
}
