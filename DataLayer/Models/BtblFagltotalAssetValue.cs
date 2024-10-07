using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAGLTotalAssetValues")]
[Index("BtblFagltotalAssetValuesChecksum", Name = "idx__btblFAGLTotalAssetValues__btblFAGLTotalAssetValues_Checksum")]
[Index("BtblFagltotalAssetValuesIChangeSetId", Name = "idx__btblFAGLTotalAssetValues_iChangeSetID")]
[Index("BtblFagltotalAssetValuesDModifiedDate", Name = "idx_btblFAGLTotalAssetValues_dModifiedDate")]
[Index("BtblFagltotalAssetValuesIBranchId", Name = "idx_btblFAGLTotalAssetValues_iBranchID")]
public partial class BtblFagltotalAssetValue
{
    [Key]
    [Column("idTotalAssetValues")]
    public int IdTotalAssetValues { get; set; }

    [Column("iAssetID")]
    public int? IAssetId { get; set; }

    [Column("dDate", TypeName = "datetime")]
    public DateTime? DDate { get; set; }

    [Column("iPeriodID")]
    public int? IPeriodId { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("_btblFAGLTotalAssetValues_iBranchID")]
    public int? BtblFagltotalAssetValuesIBranchId { get; set; }

    [Column("_btblFAGLTotalAssetValues_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFagltotalAssetValuesDCreatedDate { get; set; }

    [Column("_btblFAGLTotalAssetValues_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFagltotalAssetValuesDModifiedDate { get; set; }

    [Column("_btblFAGLTotalAssetValues_iCreatedBranchID")]
    public int? BtblFagltotalAssetValuesICreatedBranchId { get; set; }

    [Column("_btblFAGLTotalAssetValues_iModifiedBranchID")]
    public int? BtblFagltotalAssetValuesIModifiedBranchId { get; set; }

    [Column("_btblFAGLTotalAssetValues_iCreatedAgentID")]
    public int? BtblFagltotalAssetValuesICreatedAgentId { get; set; }

    [Column("_btblFAGLTotalAssetValues_iModifiedAgentID")]
    public int? BtblFagltotalAssetValuesIModifiedAgentId { get; set; }

    [Column("_btblFAGLTotalAssetValues_iChangeSetID")]
    public int? BtblFagltotalAssetValuesIChangeSetId { get; set; }

    [Column("_btblFAGLTotalAssetValues_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFagltotalAssetValuesChecksum { get; set; }
}
