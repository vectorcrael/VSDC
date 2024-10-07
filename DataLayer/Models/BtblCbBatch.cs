using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCbBatches")]
[Index("BtblCbBatchesChecksum", Name = "idx__btblCbBatches__btblCbBatches_Checksum")]
[Index("BtblCbBatchesIChangeSetId", Name = "idx__btblCbBatches_iChangeSetID")]
[Index("BtblCbBatchesDModifiedDate", Name = "idx_btblCbBatches_dModifiedDate")]
[Index("BtblCbBatchesIBranchId", Name = "idx_btblCbBatches_iBranchID")]
public partial class BtblCbBatch
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

    [Column("bModuleGL")]
    public bool BModuleGl { get; set; }

    [Column("bModuleAR")]
    public bool BModuleAr { get; set; }

    [Column("bModuleAP")]
    public bool BModuleAp { get; set; }

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

    [Column("iGLBankAccID")]
    public int? IGlbankAccId { get; set; }

    [Column("iGLARAccID")]
    public int? IGlaraccId { get; set; }

    [Column("iGLAPAccID")]
    public int? IGlapaccId { get; set; }

    [Column("iDefModule")]
    public int? IDefModule { get; set; }

    [Column("bAllowDisc")]
    public bool BAllowDisc { get; set; }

    [Column("iARDiscTrCodeID")]
    public int? IArdiscTrCodeId { get; set; }

    [Column("iAPDiscTrCodeID")]
    public int? IApdiscTrCodeId { get; set; }

    [Column("cDiscDesc")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDiscDesc { get; set; }

    [Column("bCheckedOut")]
    public bool? BCheckedOut { get; set; }

    [Column("bDupRefs")]
    public bool? BDupRefs { get; set; }

    [Column("bPrintCheque")]
    public bool BPrintCheque { get; set; }

    [Column("bIncludeBankStatement")]
    public bool BIncludeBankStatement { get; set; }

    [Column("iMaxRecur")]
    public int? IMaxRecur { get; set; }

    [Column("iBatchPosted")]
    public int? IBatchPosted { get; set; }

    [Column("cBatchRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchRef { get; set; }

    [Column("fValidationTotDeposits")]
    public double? FValidationTotDeposits { get; set; }

    [Column("fValidationTotPayments")]
    public double? FValidationTotPayments { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("bPromptGlobalChanges")]
    public bool? BPromptGlobalChanges { get; set; }

    [Column("bTransDateOnCheque")]
    public bool BTransDateOnCheque { get; set; }

    [Column("dDateBatchCreated", TypeName = "datetime")]
    public DateTime? DDateBatchCreated { get; set; }

    [Column("iAgentBatchCreated")]
    public int IAgentBatchCreated { get; set; }

    [Column("iAgentCheckedOut")]
    public int IAgentCheckedOut { get; set; }

    [Column("bApplySettDisc")]
    public bool BApplySettDisc { get; set; }

    [Column("bAllowZeroValues")]
    public bool BAllowZeroValues { get; set; }

    [Column("bARAllowLinkedAccounts")]
    public bool BArallowLinkedAccounts { get; set; }

    [Column("_btblCbBatches_iBranchID")]
    public int? BtblCbBatchesIBranchId { get; set; }

    [Column("_btblCbBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCbBatchesDCreatedDate { get; set; }

    [Column("_btblCbBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCbBatchesDModifiedDate { get; set; }

    [Column("_btblCbBatches_iCreatedBranchID")]
    public int? BtblCbBatchesICreatedBranchId { get; set; }

    [Column("_btblCbBatches_iModifiedBranchID")]
    public int? BtblCbBatchesIModifiedBranchId { get; set; }

    [Column("_btblCbBatches_iCreatedAgentID")]
    public int? BtblCbBatchesICreatedAgentId { get; set; }

    [Column("_btblCbBatches_iModifiedAgentID")]
    public int? BtblCbBatchesIModifiedAgentId { get; set; }

    [Column("_btblCbBatches_iChangeSetID")]
    public int? BtblCbBatchesIChangeSetId { get; set; }

    [Column("bInterBranchBatch")]
    public bool BInterBranchBatch { get; set; }

    [Column("iBranchLoanAccountID")]
    public int? IBranchLoanAccountId { get; set; }

    [Column("bOnlyAllowForCurrency")]
    public bool BOnlyAllowForCurrency { get; set; }

    [Column("dProcessedDate", TypeName = "datetime")]
    public DateTime? DProcessedDate { get; set; }

    [Column("bAutoAllocBBForward")]
    public bool BAutoAllocBbforward { get; set; }

    [Column("bAutoAllocOpenItem")]
    public bool BAutoAllocOpenItem { get; set; }

    [Column("bEFTSExport")]
    public bool BEftsexport { get; set; }

    [Column("_btblCbBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCbBatchesChecksum { get; set; }

    [Column("bAutoAllocByReference")]
    public bool? BAutoAllocByReference { get; set; }
}
