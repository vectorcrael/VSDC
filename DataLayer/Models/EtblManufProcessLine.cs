using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblManufProcessLine")]
[Index("EtblManufProcessLineChecksum", Name = "idx__etblManufProcessLine__etblManufProcessLine_Checksum")]
[Index("EtblManufProcessLineIChangeSetId", Name = "idx__etblManufProcessLine_iChangeSetID")]
[Index("EtblManufProcessLineDModifiedDate", Name = "idx_etblManufProcessLine_dModifiedDate")]
[Index("EtblManufProcessLineIBranchId", Name = "idx_etblManufProcessLine_iBranchID")]
[Index("IManufProcessId", Name = "idx_etblManufProcessLine_iManufProcessID")]
public partial class EtblManufProcessLine
{
    [Key]
    [Column("idManufProcessLine")]
    public long IdManufProcessLine { get; set; }

    [Column("iManufProcessID")]
    public int IManufProcessId { get; set; }

    [Column("iAction")]
    public int IAction { get; set; }

    [Column("iLineNo")]
    public int ILineNo { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iMFPItemID")]
    public double? IMfpitemId { get; set; }

    [Column("iInvItemID")]
    public int IInvItemId { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("iNewInvItemID")]
    public int? INewInvItemId { get; set; }

    [Column("iNewWarehouseID")]
    public int? INewWarehouseId { get; set; }

    [Column("fQuantity")]
    public double? FQuantity { get; set; }

    [Column("fCost")]
    public double? FCost { get; set; }

    [Column("bProcessed")]
    public bool BProcessed { get; set; }

    [Column("dTransactionDate", TypeName = "datetime")]
    public DateTime? DTransactionDate { get; set; }

    [Column("dLastUpdateDate", TypeName = "datetime")]
    public DateTime? DLastUpdateDate { get; set; }

    [Column("fQtyAvailable")]
    public double? FQtyAvailable { get; set; }

    [Column("cDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iLotID")]
    public int? ILotId { get; set; }

    [Column("iPickingSlipPrinted")]
    public int IPickingSlipPrinted { get; set; }

    [Column("iUnmanufactureLineNo")]
    public int IUnmanufactureLineNo { get; set; }

    [Column("iDocVersion")]
    public int IDocVersion { get; set; }

    [Column("fLineCost")]
    public double FLineCost { get; set; }

    [Column("_etblManufProcessLine_iBranchID")]
    public int? EtblManufProcessLineIBranchId { get; set; }

    [Column("_etblManufProcessLine_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessLineDCreatedDate { get; set; }

    [Column("_etblManufProcessLine_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessLineDModifiedDate { get; set; }

    [Column("_etblManufProcessLine_iCreatedBranchID")]
    public int? EtblManufProcessLineICreatedBranchId { get; set; }

    [Column("_etblManufProcessLine_iModifiedBranchID")]
    public int? EtblManufProcessLineIModifiedBranchId { get; set; }

    [Column("_etblManufProcessLine_iCreatedAgentID")]
    public int? EtblManufProcessLineICreatedAgentId { get; set; }

    [Column("_etblManufProcessLine_iModifiedAgentID")]
    public int? EtblManufProcessLineIModifiedAgentId { get; set; }

    [Column("_etblManufProcessLine_iChangeSetID")]
    public int? EtblManufProcessLineIChangeSetId { get; set; }

    [Column("_etblManufProcessLine_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblManufProcessLineChecksum { get; set; }
}
