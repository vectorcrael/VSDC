using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAAssetImages")]
[Index("BtblFaassetImagesChecksum", Name = "idx__btblFAAssetImages__btblFAAssetImages_Checksum")]
[Index("BtblFaassetImagesIChangeSetId", Name = "idx__btblFAAssetImages_iChangeSetID")]
[Index("BtblFaassetImagesDModifiedDate", Name = "idx_btblFAAssetImages_dModifiedDate")]
[Index("BtblFaassetImagesIBranchId", Name = "idx_btblFAAssetImages_iBranchID")]
public partial class BtblFaassetImage
{
    [Key]
    [Column("idImageNo")]
    public int IdImageNo { get; set; }

    [Column("iAssetNo")]
    public int IAssetNo { get; set; }

    [Column("cImageDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CImageDesc { get; set; } = null!;

    [Column("nImage", TypeName = "image")]
    public byte[] NImage { get; set; } = null!;

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("cImageType")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CImageType { get; set; }

    [Column("_btblFAAssetImages_iBranchID")]
    public int? BtblFaassetImagesIBranchId { get; set; }

    [Column("_btblFAAssetImages_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetImagesDCreatedDate { get; set; }

    [Column("_btblFAAssetImages_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetImagesDModifiedDate { get; set; }

    [Column("_btblFAAssetImages_iCreatedBranchID")]
    public int? BtblFaassetImagesICreatedBranchId { get; set; }

    [Column("_btblFAAssetImages_iModifiedBranchID")]
    public int? BtblFaassetImagesIModifiedBranchId { get; set; }

    [Column("_btblFAAssetImages_iCreatedAgentID")]
    public int? BtblFaassetImagesICreatedAgentId { get; set; }

    [Column("_btblFAAssetImages_iModifiedAgentID")]
    public int? BtblFaassetImagesIModifiedAgentId { get; set; }

    [Column("_btblFAAssetImages_iChangeSetID")]
    public int? BtblFaassetImagesIChangeSetId { get; set; }

    [Column("_btblFAAssetImages_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetImagesChecksum { get; set; }
}
