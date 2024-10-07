using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblDocImportDocumentTypes")]
public partial class AtblDocImportDocumentType
{
    [Key]
    [Column("idDocImportDocumentTypes")]
    public int IdDocImportDocumentTypes { get; set; }

    [Column("cDocumentType")]
    [StringLength(100)]
    [Unicode(false)]
    public string CDocumentType { get; set; } = null!;

    [Column("cFilePrefix")]
    [StringLength(50)]
    [Unicode(false)]
    public string CFilePrefix { get; set; } = null!;

    [Column("iDocImportDocumentTemplateID")]
    public int IDocImportDocumentTemplateId { get; set; }
}
