using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAGLBatchAssetValues")]
[Index("BtblFaglbatchAssetValuesChecksum", Name = "idx__btblFAGLBatchAssetValues__btblFAGLBatchAssetValues_Checksum")]
[Index("BtblFaglbatchAssetValuesIChangeSetId", Name = "idx__btblFAGLBatchAssetValues_iChangeSetID")]
[Index("BtblFaglbatchAssetValuesDModifiedDate", Name = "idx_btblFAGLBatchAssetValues_dModifiedDate")]
[Index("BtblFaglbatchAssetValuesIBranchId", Name = "idx_btblFAGLBatchAssetValues_iBranchID")]
public partial class BtblFaglbatchAssetValue
{
    [Key]
    [Column("idBatchAssetValues")]
    public int IdBatchAssetValues { get; set; }

    [Column("iBatchID")]
    public int? IBatchId { get; set; }

    [Column("iAssetID")]
    public int? IAssetId { get; set; }

    [Column("dDate", TypeName = "datetime")]
    public DateTime? DDate { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("bInitialAllowance")]
    public bool BInitialAllowance { get; set; }

    [Column("_btblFAGLBatchAssetValues_iBranchID")]
    public int? BtblFaglbatchAssetValuesIBranchId { get; set; }

    [Column("_btblFAGLBatchAssetValues_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaglbatchAssetValuesDCreatedDate { get; set; }

    [Column("_btblFAGLBatchAssetValues_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaglbatchAssetValuesDModifiedDate { get; set; }

    [Column("_btblFAGLBatchAssetValues_iCreatedBranchID")]
    public int? BtblFaglbatchAssetValuesICreatedBranchId { get; set; }

    [Column("_btblFAGLBatchAssetValues_iModifiedBranchID")]
    public int? BtblFaglbatchAssetValuesIModifiedBranchId { get; set; }

    [Column("_btblFAGLBatchAssetValues_iCreatedAgentID")]
    public int? BtblFaglbatchAssetValuesICreatedAgentId { get; set; }

    [Column("_btblFAGLBatchAssetValues_iModifiedAgentID")]
    public int? BtblFaglbatchAssetValuesIModifiedAgentId { get; set; }

    [Column("_btblFAGLBatchAssetValues_iChangeSetID")]
    public int? BtblFaglbatchAssetValuesIChangeSetId { get; set; }

    [Column("_btblFAGLBatchAssetValues_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaglbatchAssetValuesChecksum { get; set; }
}
