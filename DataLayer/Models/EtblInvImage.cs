using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvImages")]
[Index("EtblInvImagesChecksum", Name = "idx__etblInvImages__etblInvImages_Checksum")]
[Index("EtblInvImagesIChangeSetId", Name = "idx__etblInvImages_iChangeSetID")]
[Index("IStockLink", Name = "idx_etblInvImages_StockLink")]
[Index("EtblInvImagesDModifiedDate", Name = "idx_etblInvImages_dModifiedDate")]
[Index("EtblInvImagesIBranchId", Name = "idx_etblInvImages_iBranchID")]
public partial class EtblInvImage
{
    [Key]
    [Column("idInvImage")]
    public int IdInvImage { get; set; }

    [Column("iStockLink")]
    public int IStockLink { get; set; }

    [Column("nInvImage", TypeName = "image")]
    public byte[]? NInvImage { get; set; }

    [Column("cInvImageType")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CInvImageType { get; set; }

    [Column("cInvImageDesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvImageDesc { get; set; }

    [Column("bDisplayProportion")]
    public bool? BDisplayProportion { get; set; }

    [Column("bDisplayStretch")]
    public bool? BDisplayStretch { get; set; }

    [Column("_etblInvImages_iBranchID")]
    public int? EtblInvImagesIBranchId { get; set; }

    [Column("_etblInvImages_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvImagesDCreatedDate { get; set; }

    [Column("_etblInvImages_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvImagesDModifiedDate { get; set; }

    [Column("_etblInvImages_iCreatedBranchID")]
    public int? EtblInvImagesICreatedBranchId { get; set; }

    [Column("_etblInvImages_iModifiedBranchID")]
    public int? EtblInvImagesIModifiedBranchId { get; set; }

    [Column("_etblInvImages_iCreatedAgentID")]
    public int? EtblInvImagesICreatedAgentId { get; set; }

    [Column("_etblInvImages_iModifiedAgentID")]
    public int? EtblInvImagesIModifiedAgentId { get; set; }

    [Column("_etblInvImages_iChangeSetID")]
    public int? EtblInvImagesIChangeSetId { get; set; }

    [Column("iWidth")]
    public int? IWidth { get; set; }

    [Column("iHeight")]
    public int? IHeight { get; set; }

    [Column("cActualType")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CActualType { get; set; }

    [Column("fLongtitude")]
    public double? FLongtitude { get; set; }

    [Column("fLatitude")]
    public double? FLatitude { get; set; }

    [Column("fSize")]
    public double? FSize { get; set; }

    [Column("cTitle")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTitle { get; set; }

    [Column("_etblInvImages_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvImagesChecksum { get; set; }
}
