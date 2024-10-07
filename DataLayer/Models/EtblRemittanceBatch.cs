using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblRemittanceBatches")]
[Index("EtblRemittanceBatchesChecksum", Name = "idx__etblRemittanceBatches__etblRemittanceBatches_Checksum")]
[Index("EtblRemittanceBatchesDModifiedDate", Name = "idx__etblRemittanceBatches__etblRemittanceBatches_dModifiedDate")]
[Index("EtblRemittanceBatchesIBranchId", Name = "idx__etblRemittanceBatches__etblRemittanceBatches_iBranchID")]
[Index("EtblRemittanceBatchesIChangeSetId", Name = "idx__etblRemittanceBatches__etblRemittanceBatches_iChangeSetID")]
public partial class EtblRemittanceBatch
{
    [Key]
    [Column("idRemittanceBatches")]
    public int IdRemittanceBatches { get; set; }

    [Column("cBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchNo { get; set; }

    [Column("cBatchDesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string CBatchDesc { get; set; } = null!;

    [Column("cBatchRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchRef { get; set; }

    [Column("bClearAfterPost")]
    public bool BClearAfterPost { get; set; }

    [Column("bCheckedOut")]
    public bool? BCheckedOut { get; set; }

    [Column("iAgentCheckedOut")]
    public int? IAgentCheckedOut { get; set; }

    [Column("dProcessedDate", TypeName = "datetime")]
    public DateTime? DProcessedDate { get; set; }

    [Column("bChequeEFTSRun")]
    public bool? BChequeEftsrun { get; set; }

    [Column("iDefaultTranType")]
    public int? IDefaultTranType { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bIncDescription")]
    public bool? BIncDescription { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("bIncReference")]
    public bool? BIncReference { get; set; }

    [Column("bDefaultPrintCheque")]
    public bool? BDefaultPrintCheque { get; set; }

    [Column("bAllInvoicesPaid")]
    public bool? BAllInvoicesPaid { get; set; }

    [Column("bPrintChequeOrEFTSOnly")]
    public bool? BPrintChequeOrEftsonly { get; set; }

    [Column("bPrintRemittance")]
    public bool? BPrintRemittance { get; set; }

    [Column("bPrintAlsoChequeOrEFTS")]
    public bool? BPrintAlsoChequeOrEfts { get; set; }

    [Column("bPrintSamePageRemCheq")]
    public bool? BPrintSamePageRemCheq { get; set; }

    [Column("cEFTSFileName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftsfileName { get; set; }

    [Column("iDiscTranType")]
    public int? IDiscTranType { get; set; }

    [Column("bPromptValidationOnClose")]
    public bool? BPromptValidationOnClose { get; set; }

    [Column("bWarnNotIncludedInRun")]
    public bool? BWarnNotIncludedInRun { get; set; }

    [Column("bPreviewBeforePrint")]
    public bool? BPreviewBeforePrint { get; set; }

    [Column("iDiscTaxType")]
    public int? IDiscTaxType { get; set; }

    [Column("bDefaultEFTSProc")]
    public bool? BDefaultEftsproc { get; set; }

    [Column("dEFTSActionDate", TypeName = "datetime")]
    public DateTime? DEftsactionDate { get; set; }

    [Column("bApplyTerms")]
    public bool? BApplyTerms { get; set; }

    [Column("cEFTSBatchDescription")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CEftsbatchDescription { get; set; }

    [Column("iEFTSBatchNumber")]
    public int? IEftsbatchNumber { get; set; }

    [Column("dDefaultPaymentDate", TypeName = "datetime")]
    public DateTime? DDefaultPaymentDate { get; set; }

    [Column("cEFTSACBServiceType")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftsacbserviceType { get; set; }

    [Column("iEFTSType")]
    public int? IEftstype { get; set; }

    [Column("bIncludeSupOnHold")]
    public bool? BIncludeSupOnHold { get; set; }

    [Column("fMaxAmt")]
    public double? FMaxAmt { get; set; }

    [Column("fMinAmt")]
    public double? FMinAmt { get; set; }

    [Column("dPayDueDate", TypeName = "datetime")]
    public DateTime? DPayDueDate { get; set; }

    [Column("cSupArea")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSupArea { get; set; }

    [Column("cSupFrom")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSupFrom { get; set; }

    [Column("cSupGrp")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSupGrp { get; set; }

    [Column("cSupTo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSupTo { get; set; }

    [Column("cEFTSTransactionDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CEftstransactionDesc { get; set; }

    [Column("cTrCodes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CTrCodes { get; set; }

    [Column("cEFTSLayoutDesc")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CEftslayoutDesc { get; set; }

    [Column("bAllocateToOldest")]
    public bool? BAllocateToOldest { get; set; }

    [Column("bAllowSettDisc")]
    public bool? BAllowSettDisc { get; set; }

    [Column("cEFTSBatchTypeString")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CEftsbatchTypeString { get; set; }

    [Column("bEFTSAutoDateForward")]
    public bool? BEftsautoDateForward { get; set; }

    [Column("bEFTSTxProofOfPayment")]
    public bool? BEftstxProofOfPayment { get; set; }

    [Column("bEFTSDuplicateFile")]
    public bool? BEftsduplicateFile { get; set; }

    [Column("bEFTSExportOrderLetter")]
    public bool? BEftsexportOrderLetter { get; set; }

    [Column("cEFTSOrderLetter")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CEftsorderLetter { get; set; }

    [Column("bInclOutstandingDebits")]
    public bool? BInclOutstandingDebits { get; set; }

    [Column("bAutoAllocOutstanding")]
    public bool? BAutoAllocOutstanding { get; set; }

    [Column("bTxOnHold")]
    public bool? BTxOnHold { get; set; }

    [Column("bTxOnHoldRemove")]
    public bool? BTxOnHoldRemove { get; set; }

    [Column("_etblRemittanceBatches_iBranchID")]
    public int? EtblRemittanceBatchesIBranchId { get; set; }

    [Column("_etblRemittanceBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceBatchesDCreatedDate { get; set; }

    [Column("_etblRemittanceBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceBatchesDModifiedDate { get; set; }

    [Column("_etblRemittanceBatches_iCreatedBranchID")]
    public int? EtblRemittanceBatchesICreatedBranchId { get; set; }

    [Column("_etblRemittanceBatches_iModifiedBranchID")]
    public int? EtblRemittanceBatchesIModifiedBranchId { get; set; }

    [Column("_etblRemittanceBatches_iCreatedAgentID")]
    public int? EtblRemittanceBatchesICreatedAgentId { get; set; }

    [Column("_etblRemittanceBatches_iModifiedAgentID")]
    public int? EtblRemittanceBatchesIModifiedAgentId { get; set; }

    [Column("_etblRemittanceBatches_iChangeSetID")]
    public int? EtblRemittanceBatchesIChangeSetId { get; set; }

    [Column("_etblRemittanceBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblRemittanceBatchesChecksum { get; set; }

    [Column("iStatus")]
    public int IStatus { get; set; }

    [Column("iBankDetailID")]
    public int? IBankDetailId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }
}
