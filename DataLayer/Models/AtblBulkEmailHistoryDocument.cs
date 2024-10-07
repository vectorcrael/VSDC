using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailHistoryDocuments")]
public partial class AtblBulkEmailHistoryDocument
{
    [Key]
    [Column("idBulkEmailHistoryDocument")]
    public int IdBulkEmailHistoryDocument { get; set; }

    [Column("iBulkEmailHistoryID")]
    public int IBulkEmailHistoryId { get; set; }

    [Column("binDocument")]
    public byte[] BinDocument { get; set; } = null!;
}
