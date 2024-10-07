using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWhseTransferBatches")]
[Index("EtblWhseTransferBatchesChecksum", Name = "idx__etblWhseTransferBatches__etblWhseTransferBatches_Checksum")]
[Index("EtblWhseTransferBatchesIChangeSetId", Name = "idx__etblWhseTransferBatches_iChangeSetID")]
[Index("EtblWhseTransferBatchesDModifiedDate", Name = "idx_etblWhseTransferBatches_dModifiedDate")]
[Index("EtblWhseTransferBatchesIBranchId", Name = "idx_etblWhseTransferBatches_iBranchID")]
public partial class EtblWhseTransferBatch
{
    [Key]
    [Column("idWhseTransferBatch")]
    public int IdWhseTransferBatch { get; set; }

    [Column("cBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchNo { get; set; }

    [Column("cBatchDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CBatchDescription { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("iCreateAgentID")]
    public int? ICreateAgentId { get; set; }

    [Column("bClearBatchAfterPost")]
    public bool BClearBatchAfterPost { get; set; }

    [Column("bAllowDuplicateRef")]
    public bool BAllowDuplicateRef { get; set; }

    [Column("bPrintJournal")]
    public bool BPrintJournal { get; set; }

    [Column("iNewLineRefOpt")]
    public int? INewLineRefOpt { get; set; }

    [Column("cNewLineRefDef")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CNewLineRefDef { get; set; }

    [Column("bNewLineRefIncr")]
    public bool BNewLineRefIncr { get; set; }

    [Column("iNewLineDescOpt")]
    public int? INewLineDescOpt { get; set; }

    [Column("cNewLineDescDef")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CNewLineDescDef { get; set; }

    [Column("bNewLineDescIncr")]
    public bool BNewLineDescIncr { get; set; }

    [Column("iNewLineWHFromOpt")]
    public int? INewLineWhfromOpt { get; set; }

    [Column("iNewLineWHFromDefID")]
    public int? INewLineWhfromDefId { get; set; }

    [Column("iNewLineWHToOpt")]
    public int? INewLineWhtoOpt { get; set; }

    [Column("iNewLineWHToDefID")]
    public int? INewLineWhtoDefId { get; set; }

    [Column("iNewLineProjectOpt")]
    public int? INewLineProjectOpt { get; set; }

    [Column("iNewLineProjectDefID")]
    public int? INewLineProjectDefId { get; set; }

    [Column("cBatchRefNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchRefNo { get; set; }

    [Column("_etblWhseTransferBatches_iBranchID")]
    public int? EtblWhseTransferBatchesIBranchId { get; set; }

    [Column("_etblWhseTransferBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseTransferBatchesDCreatedDate { get; set; }

    [Column("_etblWhseTransferBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseTransferBatchesDModifiedDate { get; set; }

    [Column("_etblWhseTransferBatches_iCreatedBranchID")]
    public int? EtblWhseTransferBatchesICreatedBranchId { get; set; }

    [Column("_etblWhseTransferBatches_iModifiedBranchID")]
    public int? EtblWhseTransferBatchesIModifiedBranchId { get; set; }

    [Column("_etblWhseTransferBatches_iCreatedAgentID")]
    public int? EtblWhseTransferBatchesICreatedAgentId { get; set; }

    [Column("_etblWhseTransferBatches_iModifiedAgentID")]
    public int? EtblWhseTransferBatchesIModifiedAgentId { get; set; }

    [Column("_etblWhseTransferBatches_iChangeSetID")]
    public int? EtblWhseTransferBatchesIChangeSetId { get; set; }

    [Column("_etblWhseTransferBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseTransferBatchesChecksum { get; set; }
}
