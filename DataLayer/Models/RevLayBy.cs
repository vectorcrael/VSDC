using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevLayBy
{
    [Column("idLayBys")]
    public int IdLayBys { get; set; }

    [Column("iInvoiceID")]
    public long? IInvoiceId { get; set; }

    [Column("iTermCount")]
    public int? ITermCount { get; set; }

    [Column("iTermOnDay")]
    public int? ITermOnDay { get; set; }

    [Column("iTermOfEvery")]
    public int? ITermOfEvery { get; set; }

    [Column("fLayByTotal")]
    public double? FLayByTotal { get; set; }

    [Column("dInceptionDate", TypeName = "datetime")]
    public DateTime? DInceptionDate { get; set; }

    [Column("iTermsElapsed")]
    public int? ITermsElapsed { get; set; }

    [Column("fPaidToDate")]
    public double? FPaidToDate { get; set; }

    [Column("dLastPaymentDate", TypeName = "datetime")]
    public DateTime? DLastPaymentDate { get; set; }

    [Column("dNextPaymentDate", TypeName = "datetime")]
    public DateTime? DNextPaymentDate { get; set; }

    [Column("dFinalPaymentDate", TypeName = "datetime")]
    public DateTime? DFinalPaymentDate { get; set; }

    [Column("_retLayBys_iBranchID")]
    public int? RetLayBysIBranchId { get; set; }

    [Column("_retLayBys_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetLayBysDCreatedDate { get; set; }

    [Column("_retLayBys_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetLayBysDModifiedDate { get; set; }

    [Column("_retLayBys_iCreatedBranchID")]
    public int? RetLayBysICreatedBranchId { get; set; }

    [Column("_retLayBys_iModifiedBranchID")]
    public int? RetLayBysIModifiedBranchId { get; set; }

    [Column("_retLayBys_iCreatedAgentID")]
    public int? RetLayBysICreatedAgentId { get; set; }

    [Column("_retLayBys_iModifiedAgentID")]
    public int? RetLayBysIModifiedAgentId { get; set; }

    [Column("_retLayBys_iChangeSetID")]
    public int? RetLayBysIChangeSetId { get; set; }

    [Column("fLayByDeposit")]
    public double? FLayByDeposit { get; set; }

    [Column("fInstallmentAmount")]
    public double? FInstallmentAmount { get; set; }

    [Column("dLastUpdated", TypeName = "datetime")]
    public DateTime? DLastUpdated { get; set; }

    [Column("fPaymentDue")]
    public double? FPaymentDue { get; set; }

    [Column("iInvoiceIDFinalised")]
    public long? IInvoiceIdfinalised { get; set; }

    [Column("fCancellationFee")]
    public double? FCancellationFee { get; set; }

    [Column("fCancellationFeeTax")]
    public double? FCancellationFeeTax { get; set; }

    [Column("_retLayBys_Checksum")]
    [MaxLength(20)]
    public byte[]? RetLayBysChecksum { get; set; }

    [Column("iTermOfEveryDesc")]
    [StringLength(5)]
    [Unicode(false)]
    public string? ITermOfEveryDesc { get; set; }

    [Column("cTermsDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CTermsDescription { get; set; }

    [Column("fOutstandingAmount")]
    public double? FOutstandingAmount { get; set; }

    public int? AutoIndex { get; set; }

    public int? DocType { get; set; }

    public int? DocVersion { get; set; }

    public int? DocState { get; set; }

    public int? DocFlag { get; set; }

    [Column("OrigDocID")]
    public int? OrigDocId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GrvNumber { get; set; }

    [Column("GrvID")]
    public int? GrvId { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InvDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DeliveryDate { get; set; }

    public bool? TaxInclusive { get; set; }

    [Column("Email_Sent")]
    public int? EmailSent { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address5 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address6 { get; set; }

    [Column("PAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress1 { get; set; }

    [Column("PAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress2 { get; set; }

    [Column("PAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress3 { get; set; }

    [Column("PAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress4 { get; set; }

    [Column("PAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress5 { get; set; }

    [Column("PAddress6")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress6 { get; set; }

    [Column("DelMethodID")]
    public int? DelMethodId { get; set; }

    [Column("DocRepID")]
    public int? DocRepId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DeliveryNote { get; set; }

    public double? InvDisc { get; set; }

    [Column("InvDiscReasonID")]
    public int? InvDiscReasonId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message3 { get; set; }

    [Column("ProjectID")]
    public int? ProjectId { get; set; }

    [Column("TillID")]
    public int? TillId { get; set; }

    [Column("POSAmntTendered")]
    public double? PosamntTendered { get; set; }

    [Column("POSChange")]
    public double? Poschange { get; set; }

    public bool? GrvSplitFixedCost { get; set; }

    public double? GrvSplitFixedAmnt { get; set; }

    [Column("OrderStatusID")]
    public int? OrderStatusId { get; set; }

    [Column("OrderPriorityID")]
    public int? OrderPriorityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExtOrderNum { get; set; }

    [Column("ForeignCurrencyID")]
    public int? ForeignCurrencyId { get; set; }

    public double? InvDiscAmnt { get; set; }

    public double? InvDiscAmntEx { get; set; }

    [Column("InvTotExclDEx")]
    public double? InvTotExclDex { get; set; }

    [Column("InvTotTaxDEx")]
    public double? InvTotTaxDex { get; set; }

    [Column("InvTotInclDEx")]
    public double? InvTotInclDex { get; set; }

    public double? InvTotExcl { get; set; }

    public double? InvTotTax { get; set; }

    public double? InvTotIncl { get; set; }

    public double? OrdDiscAmnt { get; set; }

    public double? OrdDiscAmntEx { get; set; }

    [Column("OrdTotExclDEx")]
    public double? OrdTotExclDex { get; set; }

    [Column("OrdTotTaxDEx")]
    public double? OrdTotTaxDex { get; set; }

    [Column("OrdTotInclDEx")]
    public double? OrdTotInclDex { get; set; }

    public double? OrdTotExcl { get; set; }

    public double? OrdTotTax { get; set; }

    public double? OrdTotIncl { get; set; }

    [Column("bUseFixedPrices")]
    public bool? BUseFixedPrices { get; set; }

    [Column("iDocPrinted")]
    public int? IDocPrinted { get; set; }

    [Column("iINVNUMAgentID")]
    public int? IInvnumagentId { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fGrvSplitFixedAmntForeign")]
    public double? FGrvSplitFixedAmntForeign { get; set; }

    [Column("fInvDiscAmntForeign")]
    public double? FInvDiscAmntForeign { get; set; }

    [Column("fInvDiscAmntExForeign")]
    public double? FInvDiscAmntExForeign { get; set; }

    [Column("fInvTotExclDExForeign")]
    public double? FInvTotExclDexForeign { get; set; }

    [Column("fInvTotTaxDExForeign")]
    public double? FInvTotTaxDexForeign { get; set; }

    [Column("fInvTotInclDExForeign")]
    public double? FInvTotInclDexForeign { get; set; }

    [Column("fInvTotExclForeign")]
    public double? FInvTotExclForeign { get; set; }

    [Column("fInvTotTaxForeign")]
    public double? FInvTotTaxForeign { get; set; }

    [Column("fInvTotInclForeign")]
    public double? FInvTotInclForeign { get; set; }

    [Column("fOrdDiscAmntForeign")]
    public double? FOrdDiscAmntForeign { get; set; }

    [Column("fOrdDiscAmntExForeign")]
    public double? FOrdDiscAmntExForeign { get; set; }

    [Column("fOrdTotExclDExForeign")]
    public double? FOrdTotExclDexForeign { get; set; }

    [Column("fOrdTotTaxDExForeign")]
    public double? FOrdTotTaxDexForeign { get; set; }

    [Column("fOrdTotInclDExForeign")]
    public double? FOrdTotInclDexForeign { get; set; }

    [Column("fOrdTotExclForeign")]
    public double? FOrdTotExclForeign { get; set; }

    [Column("fOrdTotTaxForeign")]
    public double? FOrdTotTaxForeign { get; set; }

    [Column("fOrdTotInclForeign")]
    public double? FOrdTotInclForeign { get; set; }

    [Column("cTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxNumber { get; set; }

    [Column("cAccountName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CAccountName { get; set; }

    [Column("iProspectID")]
    public int? IProspectId { get; set; }

    [Column("iOpportunityID")]
    public int? IOpportunityId { get; set; }

    public double? InvTotRounding { get; set; }

    public double? OrdTotRounding { get; set; }

    [Column("fInvTotForeignRounding")]
    public double? FInvTotForeignRounding { get; set; }

    [Column("fOrdTotForeignRounding")]
    public double? FOrdTotForeignRounding { get; set; }

    [Column("bInvRounding")]
    public bool? BInvRounding { get; set; }

    [Column("iInvSettlementTermsID")]
    public int? IInvSettlementTermsId { get; set; }

    [Column("cSettlementTermInvMsg")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSettlementTermInvMsg { get; set; }

    [Column("iOrderCancelReasonID")]
    public int? IOrderCancelReasonId { get; set; }

    [Column("iLinkedDocID")]
    public int? ILinkedDocId { get; set; }

    [Column("bLinkedTemplate")]
    public bool? BLinkedTemplate { get; set; }

    public double? InvTotInclExRounding { get; set; }

    public double? OrdTotInclExRounding { get; set; }

    [Column("fInvTotInclForeignExRounding")]
    public double? FInvTotInclForeignExRounding { get; set; }

    [Column("fOrdTotInclForeignExRounding")]
    public double? FOrdTotInclForeignExRounding { get; set; }

    [Column("iEUNoTCID")]
    public int? IEunoTcid { get; set; }

    [Column("iPOAuthStatus")]
    public int? IPoauthStatus { get; set; }

    [Column("iPOIncidentID")]
    public int? IPoincidentId { get; set; }

    [Column("iSupervisorID")]
    public int? ISupervisorId { get; set; }

    [Column("iMergedDocID")]
    public int? IMergedDocId { get; set; }

    [Column("InvNum_iBranchID")]
    public int? InvNumIBranchId { get; set; }

    [Column("InvNum_dCreatedDate", TypeName = "datetime")]
    public DateTime? InvNumDCreatedDate { get; set; }

    [Column("InvNum_dModifiedDate", TypeName = "datetime")]
    public DateTime? InvNumDModifiedDate { get; set; }

    [Column("InvNum_iCreatedBranchID")]
    public int? InvNumICreatedBranchId { get; set; }

    [Column("InvNum_iModifiedBranchID")]
    public int? InvNumIModifiedBranchId { get; set; }

    [Column("InvNum_iCreatedAgentID")]
    public int? InvNumICreatedAgentId { get; set; }

    [Column("InvNum_iModifiedAgentID")]
    public int? InvNumIModifiedAgentId { get; set; }

    [Column("InvNum_iChangeSetID")]
    public int? InvNumIChangeSetId { get; set; }

    [Column("iDocEmailed")]
    public int? IDocEmailed { get; set; }

    [Column("fDepositAmountForeign")]
    public double? FDepositAmountForeign { get; set; }

    [Column("fRefundAmount")]
    public double? FRefundAmount { get; set; }

    [Column("bTaxPerLine")]
    public bool? BTaxPerLine { get; set; }

    [Column("fDepositAmountTotal")]
    public double? FDepositAmountTotal { get; set; }

    [Column("fDepositAmountUnallocated")]
    public double? FDepositAmountUnallocated { get; set; }

    [Column("fDepositAmountNew")]
    public double? FDepositAmountNew { get; set; }

    [Column("fDepositAmountTotalForeign")]
    public double? FDepositAmountTotalForeign { get; set; }

    [Column("fDepositAmountUnallocatedForeign")]
    public double? FDepositAmountUnallocatedForeign { get; set; }

    [Column("fRefundAmountForeign")]
    public double? FRefundAmountForeign { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? KeepAsideCollectionDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? KeepAsideExpiryDate { get; set; }

    [Column("cContact")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CContact { get; set; }

    [Column("cTelephone")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CTelephone { get; set; }

    [Column("cFax")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CFax { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("cCellular")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CCellular { get; set; }

    [Column("imgOrderSignature")]
    public byte[]? ImgOrderSignature { get; set; }

    [Column("iInsuranceState")]
    public int? IInsuranceState { get; set; }

    [Column("cAuthorisedBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuthorisedBy { get; set; }

    [Column("cClaimNumber")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CClaimNumber { get; set; }

    [Column("cPolicyNumber")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPolicyNumber { get; set; }

    [Column("dIncidentDate", TypeName = "datetime")]
    public DateTime? DIncidentDate { get; set; }

    [Column("cExcessAccName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CExcessAccName { get; set; }

    [Column("cExcessAccCont1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CExcessAccCont1 { get; set; }

    [Column("cExcessAccCont2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CExcessAccCont2 { get; set; }

    [Column("fExcessAmt")]
    public double? FExcessAmt { get; set; }

    [Column("fExcessPct")]
    public double? FExcessPct { get; set; }

    [Column("fExcessExclusive")]
    public double? FExcessExclusive { get; set; }

    [Column("fExcessTax")]
    public double? FExcessTax { get; set; }

    [Column("fExcessInclusive")]
    public double? FExcessInclusive { get; set; }

    [Column("fAddChargeExclusive")]
    public double? FAddChargeExclusive { get; set; }

    [Column("fAddChargeTax")]
    public double? FAddChargeTax { get; set; }

    [Column("fAddChargeInclusive")]
    public double? FAddChargeInclusive { get; set; }

    [Column("fAddChargeExclusiveForeign")]
    public double? FAddChargeExclusiveForeign { get; set; }

    [Column("fAddChargeTaxForeign")]
    public double? FAddChargeTaxForeign { get; set; }

    [Column("fAddChargeInclusiveForeign")]
    public double? FAddChargeInclusiveForeign { get; set; }

    [Column("fOrdAddChargeExclusive")]
    public double? FOrdAddChargeExclusive { get; set; }

    [Column("fOrdAddChargeTax")]
    public double? FOrdAddChargeTax { get; set; }

    [Column("fOrdAddChargeInclusive")]
    public double? FOrdAddChargeInclusive { get; set; }

    [Column("fOrdAddChargeExclusiveForeign")]
    public double? FOrdAddChargeExclusiveForeign { get; set; }

    [Column("fOrdAddChargeTaxForeign")]
    public double? FOrdAddChargeTaxForeign { get; set; }

    [Column("fOrdAddChargeInclusiveForeign")]
    public double? FOrdAddChargeInclusiveForeign { get; set; }

    [Column("iInvoiceSplitDocID")]
    public long? IInvoiceSplitDocId { get; set; }

    [Column("cGIVNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CGivnumber { get; set; }

    [Column("bIsDCOrder")]
    public bool? BIsDcorder { get; set; }

    [Column("iDCBranchID")]
    public int? IDcbranchId { get; set; }

    [Column("iSalesBranchID")]
    public int? ISalesBranchId { get; set; }

    [Column("InvNum_Checksum")]
    [MaxLength(20)]
    public byte[]? InvNumChecksum { get; set; }

    [Column("bIDFProccessed")]
    public bool? BIdfproccessed { get; set; }

    [Column("iImportDeclarationID")]
    public int? IImportDeclarationId { get; set; }

    [Column("bSBSI")]
    public bool? BSbsi { get; set; }

    [Column("cPermitNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPermitNumber { get; set; }

    [Column("iStateID")]
    public int? IStateId { get; set; }

    [Column("ulIDInvEntityRep")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlIdinvEntityRep { get; set; }

    [Column("ulIDSOrdEntityRep")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlIdsordEntityRep { get; set; }
}
