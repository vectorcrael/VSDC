using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvIistockIssueNoteList
{
    [Column("iStkIssueId")]
    public int IStkIssueId { get; set; }

    [Column("iStkIssueLineID")]
    public int IStkIssueLineId { get; set; }

    [Column("cStkIssueNumber")]
    [StringLength(50)]
    public string? CStkIssueNumber { get; set; }

    public int StockLink { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("cTrCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTrCode { get; set; }

    [Column("fConfirmQty")]
    public double? FConfirmQty { get; set; }

    [Column("fLineTotalCost")]
    public double? FLineTotalCost { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription { get; set; }

    public string? IssueNoteRefNumber { get; set; }

    [Column("iStockId")]
    public int? IStockId { get; set; }

    [Column("dIssueDate", TypeName = "datetime")]
    public DateTime? DIssueDate { get; set; }

    [Column("iProjectId")]
    public int? IProjectId { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string ProjectCode { get; set; } = null!;

    [Column("cAccOrJobCode")]
    [StringLength(91)]
    [Unicode(false)]
    public string? CAccOrJobCode { get; set; }

    [Column("cUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string CUnitCode { get; set; } = null!;

    [Column("cUnitDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CUnitDescription { get; set; } = null!;

    [Column("cRequestedBy")]
    [StringLength(50)]
    public string CRequestedBy { get; set; } = null!;

    [Column("iRequisitionId")]
    public int IRequisitionId { get; set; }

    [Column("iStatus")]
    public bool IStatus { get; set; }

    [Column("cStatus")]
    [StringLength(11)]
    [Unicode(false)]
    public string CStatus { get; set; } = null!;

    [Column("cType")]
    [StringLength(10)]
    public string CType { get; set; } = null!;

    [Column("iAccOrJobId")]
    [StringLength(50)]
    public string IAccOrJobId { get; set; } = null!;

    [Column("cLotDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CLotDescription { get; set; } = null!;

    [Column("dExpiryDate")]
    public DateOnly? DExpiryDate { get; set; }

    [Column("cSerialNumbers")]
    public string? CSerialNumbers { get; set; }
}
