using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAGLBatchGLEntries")]
[Index("BtblFaglbatchGlentriesChecksum", Name = "idx__btblFAGLBatchGLEntries__btblFAGLBatchGLEntries_Checksum")]
[Index("BtblFaglbatchGlentriesIChangeSetId", Name = "idx__btblFAGLBatchGLEntries_iChangeSetID")]
[Index("BtblFaglbatchGlentriesDModifiedDate", Name = "idx_btblFAGLBatchGLEntries_dModifiedDate")]
[Index("BtblFaglbatchGlentriesIBranchId", Name = "idx_btblFAGLBatchGLEntries_iBranchID")]
public partial class BtblFaglbatchGlentry
{
    [Key]
    [Column("idBatchGLEntries")]
    public int IdBatchGlentries { get; set; }

    [Column("iBatchID")]
    public int? IBatchId { get; set; }

    [Column("iGLAccountID")]
    public int? IGlaccountId { get; set; }

    [Column("dDate", TypeName = "datetime")]
    public DateTime? DDate { get; set; }

    [Column("fDrAmount")]
    public double? FDrAmount { get; set; }

    [Column("fCrAmount")]
    public double? FCrAmount { get; set; }

    [Column("iAssetTypeID")]
    public int? IAssetTypeId { get; set; }

    [Column("iCostCentreID")]
    public int? ICostCentreId { get; set; }

    [Column("iAssetCount")]
    public int? IAssetCount { get; set; }

    [Column("cGLDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CGldescription { get; set; }

    [Column("_btblFAGLBatchGLEntries_iBranchID")]
    public int? BtblFaglbatchGlentriesIBranchId { get; set; }

    [Column("_btblFAGLBatchGLEntries_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaglbatchGlentriesDCreatedDate { get; set; }

    [Column("_btblFAGLBatchGLEntries_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaglbatchGlentriesDModifiedDate { get; set; }

    [Column("_btblFAGLBatchGLEntries_iCreatedBranchID")]
    public int? BtblFaglbatchGlentriesICreatedBranchId { get; set; }

    [Column("_btblFAGLBatchGLEntries_iModifiedBranchID")]
    public int? BtblFaglbatchGlentriesIModifiedBranchId { get; set; }

    [Column("_btblFAGLBatchGLEntries_iCreatedAgentID")]
    public int? BtblFaglbatchGlentriesICreatedAgentId { get; set; }

    [Column("_btblFAGLBatchGLEntries_iModifiedAgentID")]
    public int? BtblFaglbatchGlentriesIModifiedAgentId { get; set; }

    [Column("_btblFAGLBatchGLEntries_iChangeSetID")]
    public int? BtblFaglbatchGlentriesIChangeSetId { get; set; }

    [Column("_btblFAGLBatchGLEntries_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaglbatchGlentriesChecksum { get; set; }
}
