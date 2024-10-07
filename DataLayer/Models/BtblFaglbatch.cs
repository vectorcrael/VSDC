using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAGLBatch")]
[Index("BtblFaglbatchChecksum", Name = "idx__btblFAGLBatch__btblFAGLBatch_Checksum")]
[Index("BtblFaglbatchIChangeSetId", Name = "idx__btblFAGLBatch_iChangeSetID")]
[Index("BtblFaglbatchDModifiedDate", Name = "idx_btblFAGLBatch_dModifiedDate")]
[Index("BtblFaglbatchIBranchId", Name = "idx_btblFAGLBatch_iBranchID")]
public partial class BtblFaglbatch
{
    [Key]
    [Column("idBatch")]
    public int IdBatch { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("dDateRun", TypeName = "datetime")]
    public DateTime DDateRun { get; set; }

    [Column("bPosted")]
    public bool BPosted { get; set; }

    [Column("dBatchDate", TypeName = "smalldatetime")]
    public DateTime? DBatchDate { get; set; }

    [Column("iBatchType")]
    public int IBatchType { get; set; }

    [Column("_btblFAGLBatch_iBranchID")]
    public int? BtblFaglbatchIBranchId { get; set; }

    [Column("_btblFAGLBatch_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaglbatchDCreatedDate { get; set; }

    [Column("_btblFAGLBatch_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaglbatchDModifiedDate { get; set; }

    [Column("_btblFAGLBatch_iCreatedBranchID")]
    public int? BtblFaglbatchICreatedBranchId { get; set; }

    [Column("_btblFAGLBatch_iModifiedBranchID")]
    public int? BtblFaglbatchIModifiedBranchId { get; set; }

    [Column("_btblFAGLBatch_iCreatedAgentID")]
    public int? BtblFaglbatchICreatedAgentId { get; set; }

    [Column("_btblFAGLBatch_iModifiedAgentID")]
    public int? BtblFaglbatchIModifiedAgentId { get; set; }

    [Column("_btblFAGLBatch_iChangeSetID")]
    public int? BtblFaglbatchIChangeSetId { get; set; }

    [Column("_btblFAGLBatch_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaglbatchChecksum { get; set; }
}
