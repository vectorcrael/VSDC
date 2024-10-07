using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAAssetTrackingLines")]
[Index("BtblFaassetTrackingLinesChecksum", Name = "idx__btblFAAssetTrackingLines__btblFAAssetTrackingLines_Checksum")]
[Index("BtblFaassetTrackingLinesIChangeSetId", Name = "idx__btblFAAssetTrackingLines_iChangeSetID")]
[Index("BtblFaassetTrackingLinesDModifiedDate", Name = "idx_btblFAAssetTrackingLines_dModifiedDate")]
[Index("BtblFaassetTrackingLinesIBranchId", Name = "idx_btblFAAssetTrackingLines_iBranchID")]
public partial class BtblFaassetTrackingLine
{
    [Key]
    [Column("idAssetTrackingLines")]
    public int IdAssetTrackingLines { get; set; }

    [Column("iAssetTrackingID")]
    public int IAssetTrackingId { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("cSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSerialNo { get; set; }

    [Column("cBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBarCode { get; set; }

    [Column("cLocationCode")]
    [StringLength(35)]
    [Unicode(false)]
    public string? CLocationCode { get; set; }

    [Column("iSystemUnitNoID")]
    public int? ISystemUnitNoId { get; set; }

    [Column("cSystemAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CSystemAssetCode { get; set; }

    [Column("cSystemSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSystemSerialNo { get; set; }

    [Column("cSystemBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSystemBarCode { get; set; }

    [Column("cSystemLocationCode")]
    [StringLength(35)]
    [Unicode(false)]
    public string? CSystemLocationCode { get; set; }

    [Column("fCountQty")]
    public double? FCountQty { get; set; }

    [Column("bModified")]
    public bool BModified { get; set; }

    [Column("iTrackingStatus")]
    public int? ITrackingStatus { get; set; }

    [Column("iTrackingDifference")]
    public int? ITrackingDifference { get; set; }

    [Column("iTrackingAdjustment")]
    public int? ITrackingAdjustment { get; set; }

    [Column("_btblFAAssetTrackingLines_iBranchID")]
    public int? BtblFaassetTrackingLinesIBranchId { get; set; }

    [Column("_btblFAAssetTrackingLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetTrackingLinesDCreatedDate { get; set; }

    [Column("_btblFAAssetTrackingLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetTrackingLinesDModifiedDate { get; set; }

    [Column("_btblFAAssetTrackingLines_iCreatedBranchID")]
    public int? BtblFaassetTrackingLinesICreatedBranchId { get; set; }

    [Column("_btblFAAssetTrackingLines_iModifiedBranchID")]
    public int? BtblFaassetTrackingLinesIModifiedBranchId { get; set; }

    [Column("_btblFAAssetTrackingLines_iCreatedAgentID")]
    public int? BtblFaassetTrackingLinesICreatedAgentId { get; set; }

    [Column("_btblFAAssetTrackingLines_iModifiedAgentID")]
    public int? BtblFaassetTrackingLinesIModifiedAgentId { get; set; }

    [Column("_btblFAAssetTrackingLines_iChangeSetID")]
    public int? BtblFaassetTrackingLinesIChangeSetId { get; set; }

    [Column("_btblFAAssetTrackingLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetTrackingLinesChecksum { get; set; }
}
