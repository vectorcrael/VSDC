using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvIiinventoryIssueNote
{
    [Column("iStkIssueId")]
    public int IStkIssueId { get; set; }

    [Column("iAutoIdx")]
    public int IAutoIdx { get; set; }

    [Column("cStkIssueNumber")]
    [StringLength(50)]
    public string? CStkIssueNumber { get; set; }

    [Column("dIssueDate", TypeName = "datetime")]
    public DateTime? DIssueDate { get; set; }

    public string? Reference { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? Account { get; set; }

    [Column("cType")]
    [StringLength(50)]
    public string? CType { get; set; }

    [Column("cStatus")]
    [StringLength(11)]
    [Unicode(false)]
    public string CStatus { get; set; } = null!;

    [Column("iStatus")]
    public bool IStatus { get; set; }

    [Column("fQty")]
    public double? FQty { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("iStockId")]
    public int? IStockId { get; set; }

    [Column("iWarehouseId")]
    public int? IWarehouseId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WhseCode { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }
}
