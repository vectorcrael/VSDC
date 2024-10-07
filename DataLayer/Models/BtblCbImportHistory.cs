using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCbImportHistory")]
public partial class BtblCbImportHistory
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTime { get; set; }

    [StringLength(100)]
    public string? FileName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FileDateTime { get; set; }

    [Column("BatchID")]
    public int? BatchId { get; set; }
}
