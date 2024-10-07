using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvCountLines")]
[Index("BtblInvCountLinesChecksum", Name = "idx__btblInvCountLines__btblInvCountLines_Checksum")]
[Index("BtblInvCountLinesIChangeSetId", Name = "idx__btblInvCountLines_iChangeSetID")]
[Index("BtblInvCountLinesDModifiedDate", Name = "idx_btblInvCountLines_dModifiedDate")]
[Index("BtblInvCountLinesIBranchId", Name = "idx_btblInvCountLines_iBranchID")]
public partial class BtblInvCountLine
{
    [Key]
    [Column("idInvCountLines")]
    public long IdInvCountLines { get; set; }

    [Column("iInvCountID")]
    public int IInvCountId { get; set; }

    [Column("cItemGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CItemGroup { get; set; }

    [Column("cPack")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CPack { get; set; }

    [Column("cBarcode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CBarcode { get; set; }

    [Column("fSystemQty")]
    public double? FSystemQty { get; set; }

    [Column("fCountQty")]
    public double? FCountQty { get; set; }

    [Column("bModified")]
    public bool BModified { get; set; }

    [Column("bWhseItem")]
    public bool BWhseItem { get; set; }

    [Column("bSerialItem")]
    public bool BSerialItem { get; set; }

    [Column("tSerialList", TypeName = "text")]
    public string? TSerialList { get; set; }

    [Column("bSNAllowDups")]
    public bool BSnallowDups { get; set; }

    [Column("iBinLocationId")]
    public int? IBinLocationId { get; set; }

    [Column("iLotTrackingID")]
    public int? ILotTrackingId { get; set; }

    [Column("bLotItem")]
    public bool BLotItem { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("bUOMCounted")]
    public bool BUomcounted { get; set; }

    [Column("_btblInvCountLines_iBranchID")]
    public int? BtblInvCountLinesIBranchId { get; set; }

    [Column("_btblInvCountLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountLinesDCreatedDate { get; set; }

    [Column("_btblInvCountLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountLinesDModifiedDate { get; set; }

    [Column("_btblInvCountLines_iCreatedBranchID")]
    public int? BtblInvCountLinesICreatedBranchId { get; set; }

    [Column("_btblInvCountLines_iModifiedBranchID")]
    public int? BtblInvCountLinesIModifiedBranchId { get; set; }

    [Column("_btblInvCountLines_iCreatedAgentID")]
    public int? BtblInvCountLinesICreatedAgentId { get; set; }

    [Column("_btblInvCountLines_iModifiedAgentID")]
    public int? BtblInvCountLinesIModifiedAgentId { get; set; }

    [Column("_btblInvCountLines_iChangeSetID")]
    public int? BtblInvCountLinesIChangeSetId { get; set; }

    [Column("bDimensionItem")]
    public bool BDimensionItem { get; set; }

    [Column("_btblInvCountLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvCountLinesChecksum { get; set; }
}
