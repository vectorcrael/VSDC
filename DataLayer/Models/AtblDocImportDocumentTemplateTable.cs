using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblDocImportDocumentTemplateTables")]
public partial class AtblDocImportDocumentTemplateTable
{
    [Key]
    [Column("idDocumentTemplateTable")]
    public int IdDocumentTemplateTable { get; set; }

    [Column("iDocumentTemplateID")]
    public int IDocumentTemplateId { get; set; }

    [Column("cTableName")]
    [StringLength(256)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;
}
