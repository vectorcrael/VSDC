using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_FileAttachment")]
public partial class RfqFileAttachment
{
    [Key]
    [Column("iFileID")]
    public int IFileId { get; set; }

    [Column("iRFQID")]
    public int IRfqid { get; set; }

    [Column("cFileName")]
    [StringLength(200)]
    public string? CFileName { get; set; }

    [Column("cFileContent")]
    public byte[]? CFileContent { get; set; }

    [Column("iSupplierID")]
    public int? ISupplierId { get; set; }
}
