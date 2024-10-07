using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSyncInfo")]
public partial class EtblSyncInfo
{
    [Key]
    [Column("idSyncInfo")]
    public int IdSyncInfo { get; set; }

    [Column("iRecCount")]
    public long? IRecCount { get; set; }

    [Column("cTablename")]
    [StringLength(255)]
    public string? CTablename { get; set; }

    [Column("iBranchID")]
    public int? IBranchId { get; set; }
}
