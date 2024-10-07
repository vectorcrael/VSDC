using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IdInvJrBatchLines", "IInvJrBatchId")]
[Table("_etblInvJrBatchLines")]
[Index("EtblInvJrBatchLinesChecksum", Name = "idx__etblInvJrBatchLines__etblInvJrBatchLines_Checksum")]
[Index("EtblInvJrBatchLinesIChangeSetId", Name = "idx__etblInvJrBatchLines_iChangeSetID")]
[Index("EtblInvJrBatchLinesDModifiedDate", Name = "idx_etblInvJrBatchLines_dModifiedDate")]
[Index("EtblInvJrBatchLinesIBranchId", Name = "idx_etblInvJrBatchLines_iBranchID")]
public partial class EtblInvJrBatchLine
{
    [Key]
    [Column("idInvJrBatchLines")]
    public int IdInvJrBatchLines { get; set; }

    [Key]
    [Column("iInvJrBatchID")]
    public int IInvJrBatchId { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("dTrDate", TypeName = "datetime")]
    public DateTime DTrDate { get; set; }

    [Column("iTrCodeID")]
    public int ITrCodeId { get; set; }

    [Column("iGLContraID")]
    public int IGlcontraId { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fQtyIn")]
    public double? FQtyIn { get; set; }

    [Column("fQtyOut")]
    public double? FQtyOut { get; set; }

    [Column("fNewCost")]
    public double? FNewCost { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("bIsSerialItem")]
    public bool BIsSerialItem { get; set; }

    [Column("bIsLotItem")]
    public bool BIsLotItem { get; set; }

    [Column("iSNGroupID")]
    public int ISngroupId { get; set; }

    [Column("iJobID")]
    public int IJobId { get; set; }

    [Column("iLotID")]
    public int ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("_etblInvJrBatchLines_iBranchID")]
    public int? EtblInvJrBatchLinesIBranchId { get; set; }

    [Column("_etblInvJrBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchLinesDCreatedDate { get; set; }

    [Column("_etblInvJrBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchLinesDModifiedDate { get; set; }

    [Column("_etblInvJrBatchLines_iCreatedBranchID")]
    public int? EtblInvJrBatchLinesICreatedBranchId { get; set; }

    [Column("_etblInvJrBatchLines_iModifiedBranchID")]
    public int? EtblInvJrBatchLinesIModifiedBranchId { get; set; }

    [Column("_etblInvJrBatchLines_iCreatedAgentID")]
    public int? EtblInvJrBatchLinesICreatedAgentId { get; set; }

    [Column("_etblInvJrBatchLines_iModifiedAgentID")]
    public int? EtblInvJrBatchLinesIModifiedAgentId { get; set; }

    [Column("_etblInvJrBatchLines_iChangeSetID")]
    public int? EtblInvJrBatchLinesIChangeSetId { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("_etblInvJrBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvJrBatchLinesChecksum { get; set; }
}
