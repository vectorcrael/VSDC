using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailTemplateData")]
public partial class AtblBulkEmailTemplateDatum
{
    [Key]
    [Column("idBulkEmailTemplateData")]
    public int IdBulkEmailTemplateData { get; set; }

    [Column("iBulkEmailTemplateID")]
    public int IBulkEmailTemplateId { get; set; }

    [Column("binData")]
    public byte[] BinData { get; set; } = null!;
}
