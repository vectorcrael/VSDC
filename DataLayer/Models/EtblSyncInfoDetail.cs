using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSyncInfoDetails")]
public partial class EtblSyncInfoDetail
{
    [Key]
    [Column("idSyncInfoDetails")]
    public long IdSyncInfoDetails { get; set; }

    [Column("iSyncInfoID")]
    public int? ISyncInfoId { get; set; }

    [Column("rowChecksum")]
    [MaxLength(20)]
    public byte[]? RowChecksum { get; set; }
}
