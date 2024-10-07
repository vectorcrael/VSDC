using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblJrBatches")]
[Index("BtblJrBatchesChecksum", Name = "idx__btblJrBatches__btblJrBatches_Checksum")]
[Index("BtblJrBatchesIChangeSetId", Name = "idx__btblJrBatches_iChangeSetID")]
[Index("BtblJrBatchesDModifiedDate", Name = "idx_btblJrBatches_dModifiedDate")]
[Index("BtblJrBatchesIBranchId", Name = "idx_btblJrBatches_iBranchID")]
public partial class BtblJrBatch
{
    [Key]
    [Column("idBatches")]
    public int IdBatches { get; set; }

    [Column("cBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchNo { get; set; }

    [Column("cBatchDesc")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CBatchDesc { get; set; }

    [Column("iInputTaxID")]
    public int? IInputTaxId { get; set; }

    [Column("iInputTaxAccID")]
    public int? IInputTaxAccId { get; set; }

    [Column("iOutputTaxID")]
    public int? IOutputTaxId { get; set; }

    [Column("iOutputTaxAccID")]
    public int? IOutputTaxAccId { get; set; }

    [Column("bCalcTax")]
    public bool BCalcTax { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("bClearBatch")]
    public bool BClearBatch { get; set; }

    [Column("iDateLineOpt")]
    public int? IDateLineOpt { get; set; }

    [Column("dDefDate", TypeName = "smalldatetime")]
    public DateTime? DDefDate { get; set; }

    [Column("iRefLineOpt")]
    public int? IRefLineOpt { get; set; }

    [Column("cDefRef")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDefRef { get; set; }

    [Column("iDescLineOpt")]
    public int? IDescLineOpt { get; set; }

    [Column("cDefDesc")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDefDesc { get; set; }

    [Column("bCheckedOut")]
    public bool? BCheckedOut { get; set; }

    [Column("iMaxRecur")]
    public int? IMaxRecur { get; set; }

    [Column("iBatchPosted")]
    public int? IBatchPosted { get; set; }

    [Column("cBatchRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchRef { get; set; }

    [Column("bPromptGlobalChanges")]
    public bool? BPromptGlobalChanges { get; set; }

    [Column("dDateBatchCreated", TypeName = "datetime")]
    public DateTime? DDateBatchCreated { get; set; }

    [Column("iAgentBatchCreated")]
    public int IAgentBatchCreated { get; set; }

    [Column("iAgentCheckedOut")]
    public int IAgentCheckedOut { get; set; }

    [Column("bAccrualBatch")]
    public bool? BAccrualBatch { get; set; }

    [Column("iAccrualDateOpt")]
    public int? IAccrualDateOpt { get; set; }

    [Column("dDefAccrualDay")]
    public int? DDefAccrualDay { get; set; }

    [Column("iAccrualRefOpt")]
    public int? IAccrualRefOpt { get; set; }

    [Column("cDefAccrualRefPrefixOrSuffix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDefAccrualRefPrefixOrSuffix { get; set; }

    [Column("dProcessedDate", TypeName = "datetime")]
    public DateTime? DProcessedDate { get; set; }

    [Column("_btblJrBatches_iBranchID")]
    public int? BtblJrBatchesIBranchId { get; set; }

    [Column("_btblJrBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJrBatchesDCreatedDate { get; set; }

    [Column("_btblJrBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJrBatchesDModifiedDate { get; set; }

    [Column("_btblJrBatches_iCreatedBranchID")]
    public int? BtblJrBatchesICreatedBranchId { get; set; }

    [Column("_btblJrBatches_iModifiedBranchID")]
    public int? BtblJrBatchesIModifiedBranchId { get; set; }

    [Column("_btblJrBatches_iCreatedAgentID")]
    public int? BtblJrBatchesICreatedAgentId { get; set; }

    [Column("_btblJrBatches_iModifiedAgentID")]
    public int? BtblJrBatchesIModifiedAgentId { get; set; }

    [Column("_btblJrBatches_iChangeSetID")]
    public int? BtblJrBatchesIChangeSetId { get; set; }

    [Column("bInterBranchBatch")]
    public bool BInterBranchBatch { get; set; }

    [Column("iBranchLoanAccountID")]
    public int? IBranchLoanAccountId { get; set; }

    [Column("bRevaluationBatch")]
    public bool BRevaluationBatch { get; set; }

    [Column("_btblJrBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJrBatchesChecksum { get; set; }

    [Column("imSCOAVerID")]
    public int ImScoaverId { get; set; }
}
