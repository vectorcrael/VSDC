using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("OrdersDf")]
[Index("OrdersDfDModifiedDate", Name = "idxOrdersDf_dModifiedDate")]
[Index("OrdersDfIBranchId", Name = "idxOrdersDf_iBranchID")]
[Index("OrdersDfChecksum", Name = "idx_OrdersDf_OrdersDf_Checksum")]
[Index("OrdersDfIChangeSetId", Name = "idx_OrdersDf_iChangeSetID")]
public partial class OrdersDf
{
    [Key]
    public int DefaultCounter { get; set; }

    [Column("iModule")]
    public int IModule { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OrderPrefix { get; set; }

    [Column("DN_POPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DnPoprefix { get; set; }

    [Column("AutoDNNo")]
    public bool AutoDnno { get; set; }

    [Column("NextDNNo")]
    public int? NextDnno { get; set; }

    [Column("DNoPadLgth")]
    public int? DnoPadLgth { get; set; }

    public bool AutoCustNo { get; set; }

    public int? NextCustNo { get; set; }

    [Column("CNoPadLgth")]
    public int? CnoPadLgth { get; set; }

    public bool ReserveStock { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    public bool PrintAllLines { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TemplatePrefix { get; set; }

    public int? NextTemplateNo { get; set; }

    public int? PadTemplateLngth { get; set; }

    public bool? AutoTemplate { get; set; }

    public bool? AutoQuote { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? QuotePrefix { get; set; }

    public int? NextQuoteNo { get; set; }

    public int? PadQuoteLngth { get; set; }

    [Column("bInvGrvSplit")]
    public bool? BInvGrvSplit { get; set; }

    [Column("iGrvTrCodeID")]
    public int? IGrvTrCodeId { get; set; }

    [Column("iSInvGLVarAccID")]
    public int? ISinvGlvarAccId { get; set; }

    [Column("bUseNewCurrencyRate")]
    public bool BUseNewCurrencyRate { get; set; }

    [Column("iPOAuthType")]
    public int IPoauthType { get; set; }

    [Column("iPOIncidentTypeID")]
    public int? IPoincidentTypeId { get; set; }

    [Column("bPOExclusive")]
    public bool BPoexclusive { get; set; }

    [Column("fPOLimit")]
    public double? FPolimit { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("bForceRep")]
    public bool BForceRep { get; set; }

    [Column("bArchiveQuotes")]
    public bool BArchiveQuotes { get; set; }

    [Column("bForceExtOrderNum")]
    public bool BForceExtOrderNum { get; set; }

    [Column("bForceSupplierInvNumber")]
    public bool BForceSupplierInvNumber { get; set; }

    [Column("bUniqueOrderNum")]
    public bool? BUniqueOrderNum { get; set; }

    [Column("bUniqueQuoteNum")]
    public bool? BUniqueQuoteNum { get; set; }

    [Column("bUniqueTemplateNum")]
    public bool? BUniqueTemplateNum { get; set; }

    [Column("bUniqueDeliveryNoteNum")]
    public bool? BUniqueDeliveryNoteNum { get; set; }

    [Column("OrdersDf_iBranchID")]
    public int? OrdersDfIBranchId { get; set; }

    [Column("OrdersDf_dCreatedDate", TypeName = "datetime")]
    public DateTime? OrdersDfDCreatedDate { get; set; }

    [Column("OrdersDf_dModifiedDate", TypeName = "datetime")]
    public DateTime? OrdersDfDModifiedDate { get; set; }

    [Column("OrdersDf_iCreatedBranchID")]
    public int? OrdersDfICreatedBranchId { get; set; }

    [Column("OrdersDf_iModifiedBranchID")]
    public int? OrdersDfIModifiedBranchId { get; set; }

    [Column("OrdersDf_iCreatedAgentID")]
    public int? OrdersDfICreatedAgentId { get; set; }

    [Column("OrdersDf_iModifiedAgentID")]
    public int? OrdersDfIModifiedAgentId { get; set; }

    [Column("OrdersDf_iChangeSetID")]
    public int? OrdersDfIChangeSetId { get; set; }

    [Column("bAllowPOSTender")]
    public bool BAllowPostender { get; set; }

    [Column("bUseDeposits")]
    public bool BUseDeposits { get; set; }

    [Column("bForceDeposits")]
    public bool BForceDeposits { get; set; }

    [Column("iDepTrCodeID")]
    public int? IDepTrCodeId { get; set; }

    [Column("fMinDepositPerc")]
    public double? FMinDepositPerc { get; set; }

    [Column("bPrintUnprocessedSOPS")]
    public bool BPrintUnprocessedSops { get; set; }

    [Column("bPrintProcessedSOPS")]
    public bool BPrintProcessedSops { get; set; }

    [Column("bForceDelivery")]
    public bool BForceDelivery { get; set; }

    [Column("bReserveSOLinkedPO")]
    public bool BReserveSolinkedPo { get; set; }

    [Column("bSOInvIssueSplit")]
    public bool BSoinvIssueSplit { get; set; }

    [Column("iSOInvIssueSplitAccrualAccID")]
    public int ISoinvIssueSplitAccrualAccId { get; set; }

    [Column("OrdersDf_Checksum")]
    [MaxLength(20)]
    public byte[]? OrdersDfChecksum { get; set; }

    [Column("bUseDeliveryManagement")]
    public bool? BUseDeliveryManagement { get; set; }
}
