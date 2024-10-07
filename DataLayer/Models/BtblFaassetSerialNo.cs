using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAAssetSerialNo")]
[Index("BtblFaassetSerialNoChecksum", Name = "idx__btblFAAssetSerialNo__btblFAAssetSerialNo_Checksum")]
[Index("BtblFaassetSerialNoIChangeSetId", Name = "idx__btblFAAssetSerialNo_iChangeSetID")]
[Index("BtblFaassetSerialNoDModifiedDate", Name = "idx_btblFAAssetSerialNo_dModifiedDate")]
[Index("BtblFaassetSerialNoIBranchId", Name = "idx_btblFAAssetSerialNo_iBranchID")]
public partial class BtblFaassetSerialNo
{
    [Key]
    [Column("idSerialNo")]
    public int IdSerialNo { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CAssetCode { get; set; } = null!;

    [Column("iUnitNo")]
    public int IUnitNo { get; set; }

    [Column("cSerialNo")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CSerialNo { get; set; }

    [Column("cBarcode")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CBarcode { get; set; }

    [Column("iLocationNo")]
    public int? ILocationNo { get; set; }

    [Column("_btblFAAssetSerialNo_iBranchID")]
    public int? BtblFaassetSerialNoIBranchId { get; set; }

    [Column("_btblFAAssetSerialNo_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetSerialNoDCreatedDate { get; set; }

    [Column("_btblFAAssetSerialNo_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetSerialNoDModifiedDate { get; set; }

    [Column("_btblFAAssetSerialNo_iCreatedBranchID")]
    public int? BtblFaassetSerialNoICreatedBranchId { get; set; }

    [Column("_btblFAAssetSerialNo_iModifiedBranchID")]
    public int? BtblFaassetSerialNoIModifiedBranchId { get; set; }

    [Column("_btblFAAssetSerialNo_iCreatedAgentID")]
    public int? BtblFaassetSerialNoICreatedAgentId { get; set; }

    [Column("_btblFAAssetSerialNo_iModifiedAgentID")]
    public int? BtblFaassetSerialNoIModifiedAgentId { get; set; }

    [Column("_btblFAAssetSerialNo_iChangeSetID")]
    public int? BtblFaassetSerialNoIChangeSetId { get; set; }

    [Column("_btblFAAssetSerialNo_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetSerialNoChecksum { get; set; }
}
