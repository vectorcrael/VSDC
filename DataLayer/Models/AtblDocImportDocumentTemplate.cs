using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblDocImportDocumentTemplates")]
public partial class AtblDocImportDocumentTemplate
{
    [Key]
    [Column("idDocImportDocumentTemplate")]
    public int IdDocImportDocumentTemplate { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("cPrimaryTable")]
    [StringLength(100)]
    [Unicode(false)]
    public string CPrimaryTable { get; set; } = null!;
}
