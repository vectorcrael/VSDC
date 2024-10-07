using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCbBatchLines")]
[Index("BtblCbBatchLinesChecksum", Name = "idx__btblCbBatchLines__btblCbBatchLines_Checksum")]
[Index("BtblCbBatchLinesIChangeSetId", Name = "idx__btblCbBatchLines_iChangeSetID")]
[Index("BtblCbBatchLinesDModifiedDate", Name = "idx_btblCbBatchLines_dModifiedDate")]
[Index("BtblCbBatchLinesIBranchId", Name = "idx_btblCbBatchLines_iBranchID")]
public partial class BtblCbBatchLine
{
    [Key]
    [Column("idBatchLines")]
    public int IdBatchLines { get; set; }

    [Column("iBatchesID")]
    public int IBatchesId { get; set; }

    [Column("iSplitType")]
    public int? ISplitType { get; set; }

    [Column("iSplitGroup")]
    public int? ISplitGroup { get; set; }

    [Column("dTxDate", TypeName = "smalldatetime")]
    public DateTime DTxDate { get; set; }

    [Column("iModule")]
    public int IModule { get; set; }

    [Column("iAccountID")]
    public int IAccountId { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("fDebit")]
    public double? FDebit { get; set; }

    [Column("fCredit")]
    public double? FCredit { get; set; }

    [Column("bReconcile")]
    public bool BReconcile { get; set; }

    [Column("fTaxAmount")]
    public double? FTaxAmount { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("bPostDated")]
    public bool BPostDated { get; set; }

    [Column("fDiscPerc")]
    public double? FDiscPerc { get; set; }

    [Column("iDiscTrCodeID")]
    public int? IDiscTrCodeId { get; set; }

    [Column("cDiscDesc")]
    [StringLength(35)]
    [Unicode(false)]
    public string? CDiscDesc { get; set; }

    [Column("iDiscTaxTypeID")]
    public int? IDiscTaxTypeId { get; set; }

    [Column("iDiscTaxAccID")]
    public int? IDiscTaxAccId { get; set; }

    [Column("fDiscTaxAmount")]
    public double? FDiscTaxAmount { get; set; }

    [Column("cPayeeName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CPayeeName { get; set; }

    [Column("bPrintCheque")]
    public bool BPrintCheque { get; set; }

    [Column("bChequePrinted")]
    public bool BChequePrinted { get; set; }

    [Column("iRepID")]
    public int? IRepId { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fDebitForeign")]
    public double? FDebitForeign { get; set; }

    [Column("fCreditForeign")]
    public double? FCreditForeign { get; set; }

    [Column("fTaxAmountForeign")]
    public double? FTaxAmountForeign { get; set; }

    [Column("fDiscTaxAmountForeign")]
    public double? FDiscTaxAmountForeign { get; set; }

    [Column("iCBBatchLinesReconID")]
    public int? ICbbatchLinesReconId { get; set; }

    [Column("fFCAccountAmount")]
    public double FFcaccountAmount { get; set; }

    [Column("fFCAccountExchange")]
    public double FFcaccountExchange { get; set; }

    [Column("fFCAccountDiscAmount")]
    public double FFcaccountDiscAmount { get; set; }

    [Column("fFCAccountDiscTax")]
    public double FFcaccountDiscTax { get; set; }

    [Column("iSettDiscGroupID")]
    public int ISettDiscGroupId { get; set; }

    [Column("iSettDiscPostARAPID")]
    public long ISettDiscPostArapid { get; set; }

    [Column("_btblCbBatchLines_iBranchID")]
    public int? BtblCbBatchLinesIBranchId { get; set; }

    [Column("_btblCbBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCbBatchLinesDCreatedDate { get; set; }

    [Column("_btblCbBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCbBatchLinesDModifiedDate { get; set; }

    [Column("_btblCbBatchLines_iCreatedBranchID")]
    public int? BtblCbBatchLinesICreatedBranchId { get; set; }

    [Column("_btblCbBatchLines_iModifiedBranchID")]
    public int? BtblCbBatchLinesIModifiedBranchId { get; set; }

    [Column("_btblCbBatchLines_iCreatedAgentID")]
    public int? BtblCbBatchLinesICreatedAgentId { get; set; }

    [Column("_btblCbBatchLines_iModifiedAgentID")]
    public int? BtblCbBatchLinesIModifiedAgentId { get; set; }

    [Column("_btblCbBatchLines_iChangeSetID")]
    public int? BtblCbBatchLinesIChangeSetId { get; set; }

    [Column("cBankRef")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBankRef { get; set; }

    [Column("bIsPosted")]
    public bool BIsPosted { get; set; }

    [Column("iMBPropertyID")]
    public int? IMbpropertyId { get; set; }

    [Column("iMBPortionID")]
    public int? IMbportionId { get; set; }

    [Column("iMBServiceID")]
    public int? IMbserviceId { get; set; }

    [Column("iMBPropertyPortionServiceID")]
    public int? IMbpropertyPortionServiceId { get; set; }

    [Column("bMBOverride")]
    public bool BMboverride { get; set; }

    [Column("iMBMeterID")]
    public int? IMbmeterId { get; set; }

    [Column("_btblCbBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCbBatchLinesChecksum { get; set; }

    [Column("fFCAccountTaxAmount")]
    public double FFcaccountTaxAmount { get; set; }

    [Unicode(false)]
    public string? SagePayExtra1 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra2 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra3 { get; set; }

    [Column("cTaxCompanyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CTaxCompanyName { get; set; }

    [Column("cTaxCompanyRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxCompanyRegistration { get; set; }

    [Column("cTaxRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxRegistration { get; set; }
}
