using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_simtblStockIssueLineSN")]
public partial class SimtblStockIssueLineSn
{
    [Key]
    [Column("idStockIssueLineSN")]
    public int IdStockIssueLineSn { get; set; }

    [Column("iSerialStockIssueID")]
    public int ISerialStockIssueId { get; set; }

    [Column("iSerialStockIssueLineID")]
    public long ISerialStockIssueLineId { get; set; }

    [Column("cSerialNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSerialNumber { get; set; }

    [Column("iSerialMFID")]
    public int ISerialMfid { get; set; }
}
