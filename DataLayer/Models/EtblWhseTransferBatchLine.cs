using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWhseTransferBatchLines")]
[Index("EtblWhseTransferBatchLinesChecksum", Name = "idx__etblWhseTransferBatchLines__etblWhseTransferBatchLines_Checksum")]
[Index("EtblWhseTransferBatchLinesIChangeSetId", Name = "idx__etblWhseTransferBatchLines_iChangeSetID")]
[Index("EtblWhseTransferBatchLinesDModifiedDate", Name = "idx_etblWhseTransferBatchLines_dModifiedDate")]
[Index("EtblWhseTransferBatchLinesIBranchId", Name = "idx_etblWhseTransferBatchLines_iBranchID")]
public partial class EtblWhseTransferBatchLine
{
    [Key]
    [Column("idWhseTransferBatchLines")]
    public int IdWhseTransferBatchLines { get; set; }

    [Column("iWhseTransferBatchID")]
    public int? IWhseTransferBatchId { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iFromWhseID")]
    public int? IFromWhseId { get; set; }

    [Column("iToWhseID")]
    public int? IToWhseId { get; set; }

    [Column("fQuantity")]
    public double? FQuantity { get; set; }

    [Column("fCost")]
    public double? FCost { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bIsSerialItem")]
    public bool BIsSerialItem { get; set; }

    [Column("iSerialNumberGroupID")]
    public int? ISerialNumberGroupId { get; set; }

    [Column("bIsLotItem")]
    public bool BIsLotItem { get; set; }

    [Column("iLotID")]
    public int ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("_etblWhseTransferBatchLines_iBranchID")]
    public int? EtblWhseTransferBatchLinesIBranchId { get; set; }

    [Column("_etblWhseTransferBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseTransferBatchLinesDCreatedDate { get; set; }

    [Column("_etblWhseTransferBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseTransferBatchLinesDModifiedDate { get; set; }

    [Column("_etblWhseTransferBatchLines_iCreatedBranchID")]
    public int? EtblWhseTransferBatchLinesICreatedBranchId { get; set; }

    [Column("_etblWhseTransferBatchLines_iModifiedBranchID")]
    public int? EtblWhseTransferBatchLinesIModifiedBranchId { get; set; }

    [Column("_etblWhseTransferBatchLines_iCreatedAgentID")]
    public int? EtblWhseTransferBatchLinesICreatedAgentId { get; set; }

    [Column("_etblWhseTransferBatchLines_iModifiedAgentID")]
    public int? EtblWhseTransferBatchLinesIModifiedAgentId { get; set; }

    [Column("_etblWhseTransferBatchLines_iChangeSetID")]
    public int? EtblWhseTransferBatchLinesIChangeSetId { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("_etblWhseTransferBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseTransferBatchLinesChecksum { get; set; }
}
