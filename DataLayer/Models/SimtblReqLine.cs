using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_simtblReqLines")]
public partial class SimtblReqLine
{
    [Key]
    [Column("idReqLines")]
    public int IdReqLines { get; set; }

    [Column("fk_idReqHeader")]
    public int? FkIdReqHeader { get; set; }

    [Column("iStockId")]
    public int? IStockId { get; set; }

    [Column("cDescription")]
    public string? CDescription { get; set; }

    [Column("iReqStatus")]
    public int? IReqStatus { get; set; }

    [Column("dSartDate", TypeName = "datetime")]
    public DateTime? DSartDate { get; set; }

    [Column("dEndDate", TypeName = "datetime")]
    public DateTime? DEndDate { get; set; }

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
    public int? CTypeDetails { get; set; }

    [Column("iTrcodeId")]
    public int? ITrcodeId { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("iLineNo")]
    public int? ILineNo { get; set; }

    [Column("iTaxType")]
    public int? ITaxType { get; set; }

    [Column("fk_iIncidentId")]
    public int? FkIIncidentId { get; set; }

    [Column("iStockingUnitID")]
    public int? IStockingUnitId { get; set; }

    [Column("iUnitCategoryID")]
    public int? IUnitCategoryId { get; set; }

    [Column("iStockingUnitCategoryID")]
    public int? IStockingUnitCategoryId { get; set; }

    [Column("bIsLot")]
    public bool? BIsLot { get; set; }

    [Column("bIsSerialItem")]
    public bool? BIsSerialItem { get; set; }
}
