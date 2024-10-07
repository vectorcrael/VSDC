using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retDefaults")]
[Index("RetDefaultsChecksum", Name = "idx__retDefaults__retDefaults_Checksum")]
[Index("RetDefaultsDModifiedDate", Name = "idx__retDefaults__retDefaults_dModifiedDate")]
[Index("RetDefaultsIBranchId", Name = "idx__retDefaults__retDefaults_iBranchID")]
[Index("RetDefaultsIChangeSetId", Name = "idx__retDefaults__retDefaults_iChangeSetID")]
public partial class RetDefault
{
    [Key]
    [Column("idRetailDefaults")]
    public int IdRetailDefaults { get; set; }

    [Column("fDefaultFloatAmount")]
    public double? FDefaultFloatAmount { get; set; }

    [Column("fDefaultCashPickupAmount")]
    public double? FDefaultCashPickupAmount { get; set; }

    [Column("iDefaultCustomerID")]
    public int? IDefaultCustomerId { get; set; }

    [Column("iModelCustomerID")]
    public int? IModelCustomerId { get; set; }

    [Column("cAutoNumBranchPrefix")]
    [StringLength(3)]
    [Unicode(false)]
    public string? CAutoNumBranchPrefix { get; set; }

    [Column("iDocketTrCodeID")]
    public int? IDocketTrCodeId { get; set; }

    [Column("iDocketAdjTrCodeID")]
    public int? IDocketAdjTrCodeId { get; set; }

    [Column("iCashUpBankTrCodeID")]
    public int? ICashUpBankTrCodeId { get; set; }

    [Column("iCashUpExcessTrCodeID")]
    public int? ICashUpExcessTrCodeId { get; set; }

    [Column("iCashUpShortageTrCodeID")]
    public int? ICashUpShortageTrCodeId { get; set; }

    [Column("iPettyCashAdvancedTrCodeID")]
    public int? IPettyCashAdvancedTrCodeId { get; set; }

    [Column("iPettyCashProcessedTrCodeID")]
    public int? IPettyCashProcessedTrCodeId { get; set; }

    [Column("_retDefaults_iBranchID")]
    public int? RetDefaultsIBranchId { get; set; }

    [Column("_retDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetDefaultsDCreatedDate { get; set; }

    [Column("_retDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetDefaultsDModifiedDate { get; set; }

    [Column("_retDefaults_iCreatedBranchID")]
    public int? RetDefaultsICreatedBranchId { get; set; }

    [Column("_retDefaults_iModifiedBranchID")]
    public int? RetDefaultsIModifiedBranchId { get; set; }

    [Column("_retDefaults_iCreatedAgentID")]
    public int? RetDefaultsICreatedAgentId { get; set; }

    [Column("_retDefaults_iModifiedAgentID")]
    public int? RetDefaultsIModifiedAgentId { get; set; }

    [Column("_retDefaults_iChangeSetID")]
    public int? RetDefaultsIChangeSetId { get; set; }

    [Column("cPoleDisplayDef1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPoleDisplayDef1 { get; set; }

    [Column("cPoleDisplayDef2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPoleDisplayDef2 { get; set; }

    [Column("iReceiptDiscountTrCodeID")]
    public int? IReceiptDiscountTrCodeId { get; set; }

    [Column("bAllocationPrompt")]
    public bool BAllocationPrompt { get; set; }

    [Column("bVariableBarcodesEnabled")]
    public bool BVariableBarcodesEnabled { get; set; }

    [Column("iVariableBarcodePriceListID")]
    public int? IVariableBarcodePriceListId { get; set; }

    [Column("iDeliveryMethodDefaultID")]
    public int? IDeliveryMethodDefaultId { get; set; }

    [Column("bDocketForceReps")]
    public bool BDocketForceReps { get; set; }

    [Column("bDocketPromptForCustomerAccount")]
    public bool BDocketPromptForCustomerAccount { get; set; }

    [Column("bPettyCashAdvanceAuthorisation")]
    public bool BPettyCashAdvanceAuthorisation { get; set; }

    [Column("fPettyCashAdvanceLimit")]
    public double? FPettyCashAdvanceLimit { get; set; }

    [Column("bRestrictPettyCashAdvance")]
    public bool BRestrictPettyCashAdvance { get; set; }

    [Column("bCashPickupWarning")]
    public bool BCashPickupWarning { get; set; }

    [Column("cCashPickupWarningMessage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCashPickupWarningMessage { get; set; }

    [Column("fCashPickupMaxCashInTillLimit")]
    public double? FCashPickupMaxCashInTillLimit { get; set; }

    [Column("bDepositUse")]
    public bool BDepositUse { get; set; }

    [Column("bDepositForce")]
    public bool BDepositForce { get; set; }

    [Column("iDepositTrCodeID")]
    public int? IDepositTrCodeId { get; set; }

    [Column("fDepositMinPerc")]
    public double? FDepositMinPerc { get; set; }

    [Column("fDepositMinAmnt")]
    public double? FDepositMinAmnt { get; set; }

    [Column("bDepositAllow")]
    public bool BDepositAllow { get; set; }

    [Column("fDepositGreaterThan")]
    public double? FDepositGreaterThan { get; set; }

    [Column("iInactivityTimeout")]
    public int? IInactivityTimeout { get; set; }

    [Column("iReversalInvJrBatchID")]
    public int? IReversalInvJrBatchId { get; set; }

    [Column("iReversalAdjTrCodeID")]
    public int? IReversalAdjTrCodeId { get; set; }

    [Column("iLayByModelCustomerID")]
    public int? ILayByModelCustomerId { get; set; }

    [Column("iReversalAgentID")]
    public int? IReversalAgentId { get; set; }

    [Column("iLayByPaymentTermCount")]
    public int? ILayByPaymentTermCount { get; set; }

    [Column("iLayByPaymentTermOnDay")]
    public int? ILayByPaymentTermOnDay { get; set; }

    [Column("iLayByPaymentTermOfEvery")]
    public int? ILayByPaymentTermOfEvery { get; set; }

    [Column("fLayByDepositMinPerc")]
    public double? FLayByDepositMinPerc { get; set; }

    [Column("fLayByDepositMinAmnt")]
    public double? FLayByDepositMinAmnt { get; set; }

    [Column("fLayByCancellationPerc")]
    public double? FLayByCancellationPerc { get; set; }

    [Column("fLayByCancellationAmnt")]
    public double? FLayByCancellationAmnt { get; set; }

    [Column("iLayByCancellationTrCodeID")]
    public int? ILayByCancellationTrCodeId { get; set; }

    [Column("bReserveStockOrders")]
    public bool BReserveStockOrders { get; set; }

    [Column("bReserveStockLayBys")]
    public bool BReserveStockLayBys { get; set; }

    [Column("bPromoAutoYN")]
    public bool BPromoAutoYn { get; set; }

    [Column("iPromoAutoLength")]
    public int IPromoAutoLength { get; set; }

    [Column("iPromoAutoAlphaLength")]
    public int IPromoAutoAlphaLength { get; set; }

    [Column("bUpperPromoNo")]
    public bool BUpperPromoNo { get; set; }

    [Column("iKeepAsideDaysToExpiry")]
    public int IKeepAsideDaysToExpiry { get; set; }

    [Column("iDisplayDocketPromptFields")]
    public int IDisplayDocketPromptFields { get; set; }

    [Column("iForceDocketPromptFields")]
    public int IForceDocketPromptFields { get; set; }

    [Column("bLayByFirstPaymentInCurrentPeriod")]
    public bool BLayByFirstPaymentInCurrentPeriod { get; set; }

    [Column("bAutoAdjust")]
    public bool BAutoAdjust { get; set; }

    [Column("cDocketModeDocketPromptFields")]
    [StringLength(400)]
    [Unicode(false)]
    public string? CDocketModeDocketPromptFields { get; set; }

    [Column("cTillConfigPassword")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CTillConfigPassword { get; set; }

    [Column("bDisplayDocketPromotionCode")]
    public bool BDisplayDocketPromotionCode { get; set; }

    [Column("bDisplayDocketPromotionDescription")]
    public bool BDisplayDocketPromotionDescription { get; set; }

    [Column("fReturnLimit")]
    public double? FReturnLimit { get; set; }

    [Column("bReturnAuthorisation")]
    public bool BReturnAuthorisation { get; set; }

    [Column("bRestrictReturn")]
    public bool BRestrictReturn { get; set; }

    [Column("bPromoItemListAutoYN")]
    public bool BPromoItemListAutoYn { get; set; }

    [Column("bUpperPromoItemListNo")]
    public bool BUpperPromoItemListNo { get; set; }

    [Column("iPromoItemListAutoLength")]
    public int IPromoItemListAutoLength { get; set; }

    [Column("iPromoItemListAutoAlphaLength")]
    public int IPromoItemListAutoAlphaLength { get; set; }

    [Column("bLayByEdit")]
    public bool BLayByEdit { get; set; }

    [Column("bLineForceReps")]
    public bool BLineForceReps { get; set; }

    [Column("bFloatPerAgentOrTill")]
    public bool BFloatPerAgentOrTill { get; set; }

    [Column("iTradingSessionDuration")]
    public int? ITradingSessionDuration { get; set; }

    [Column("bDisableTradeOnExpiry")]
    public bool BDisableTradeOnExpiry { get; set; }

    [Column("bForceSerialNumbers")]
    public bool BForceSerialNumbers { get; set; }

    [Column("bUseDocketRoundingOnTender")]
    public bool? BUseDocketRoundingOnTender { get; set; }

    [Column("bRoundingOnCashTenderOnly")]
    public bool? BRoundingOnCashTenderOnly { get; set; }

    [Column("iRoundingGLAccount")]
    public int? IRoundingGlaccount { get; set; }

    [Column("bAllowCashDrawerHandover")]
    public bool? BAllowCashDrawerHandover { get; set; }

    [Column("iInvSplitProcessOption")]
    public int IInvSplitProcessOption { get; set; }

    [Column("bUseVASAirtime")]
    public bool? BUseVasairtime { get; set; }

    [Column("cVASAirtimeMerchantID")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CVasairtimeMerchantId { get; set; }

    [Column("cVASAirtimeHostURI")]
    [StringLength(100)]
    public string? CVasairtimeHostUri { get; set; }

    [Column("_retDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? RetDefaultsChecksum { get; set; }
}
