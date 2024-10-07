using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_simtblStkIssueLines")]
public partial class SimtblStkIssueLine
{
    [Key]
    [Column("iAutoIdx")]
    public int IAutoIdx { get; set; }

    [Column("iStkIssueId")]
    public int? IStkIssueId { get; set; }

    [Column("iStkIssueTaxTpId")]
    public int? IStkIssueTaxTpId { get; set; }

    [Column("iStockId")]
    public int? IStockId { get; set; }

    [Column("cDescription")]
    public string? CDescription { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("iUnitOfMeasure")]
    public int? IUnitOfMeasure { get; set; }

    [Column("iWarehouseId")]
    public int? IWarehouseId { get; set; }

    [Column("fLineTotalCost")]
    public double? FLineTotalCost { get; set; }

    [Column("bIsprocessed")]
    public bool? BIsprocessed { get; set; }

    [Column("fConfirmQty")]
    public double? FConfirmQty { get; set; }

    [Column("bIswarehouse")]
    public bool? BIswarehouse { get; set; }

    [Column("cType")]
    [StringLength(50)]
    public string? CType { get; set; }

    [Column("cTypeDetails")]
    [StringLength(50)]
    public string? CTypeDetails { get; set; }

    [Column("cProject")]
    [StringLength(50)]
    public string? CProject { get; set; }

    [Column("iTrcodeId")]
    public int? ITrcodeId { get; set; }

    [Column("bIsLot")]
    public bool? BIsLot { get; set; }

    [Column("iLotNumber")]
    public int? ILotNumber { get; set; }

    [Column("iProjectId")]
    public int? IProjectId { get; set; }

    [Column("iStockingUnitID")]
    public int? IStockingUnitId { get; set; }

    [Column("iUnitCategoryID")]
    public int? IUnitCategoryId { get; set; }

    [Column("iStockingUnitCategoryID")]
    public int? IStockingUnitCategoryId { get; set; }

    [Column("bIsSerialItem")]
    public bool? BIsSerialItem { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }
}
