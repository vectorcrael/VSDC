using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvArbatchLine
{
    [StringLength(91)]
    [Unicode(false)]
    public string? ModuleAccount { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ModuleAccountName { get; set; }

    [Column("idARAPBatchLines")]
    public int IdArapbatchLines { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("idLinePermanent")]
    public int? IdLinePermanent { get; set; }

    [Column("dTxDate", TypeName = "datetime")]
    public DateTime? DTxDate { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("iAccountCurrencyID")]
    public int? IAccountCurrencyId { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("iGLContraID")]
    public int? IGlcontraId { get; set; }

    [Column("bPostDated")]
    public bool BPostDated { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cOrderNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? COrderNumber { get; set; }

    [Column("fAmountExcl")]
    public double? FAmountExcl { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("fAmountIncl")]
    public double? FAmountIncl { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fAmountExclForeign")]
    public double? FAmountExclForeign { get; set; }

    [Column("fAmountInclForeign")]
    public double? FAmountInclForeign { get; set; }

    [Column("fAccountExchangeRate")]
    public double? FAccountExchangeRate { get; set; }

    [Column("fAccountForeignAmountExcl")]
    public double? FAccountForeignAmountExcl { get; set; }

    [Column("fAccountForeignAmountIncl")]
    public double? FAccountForeignAmountIncl { get; set; }

    [Column("iDiscGLContraID")]
    public int? IDiscGlcontraId { get; set; }

    [Column("fDiscPercent")]
    public double? FDiscPercent { get; set; }

    [Column("fDiscAmountExcl")]
    public double? FDiscAmountExcl { get; set; }

    [Column("iDiscTaxTypeID")]
    public int? IDiscTaxTypeId { get; set; }

    [Column("fDiscAmountIncl")]
    public double? FDiscAmountIncl { get; set; }

    [Column("fDiscAmountExclForeign")]
    public double? FDiscAmountExclForeign { get; set; }

    [Column("fDiscAmountInclForeign")]
    public double? FDiscAmountInclForeign { get; set; }

    [Column("fAccountForeignDiscAmountExcl")]
    public double? FAccountForeignDiscAmountExcl { get; set; }

    [Column("fAccountForeignDiscAmountIncl")]
    public double? FAccountForeignDiscAmountIncl { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iSalesRepID")]
    public int? ISalesRepId { get; set; }

    [Column("iBatchSettlementTermsID")]
    public int IBatchSettlementTermsId { get; set; }

    [Column("_etblARAPBatchLines_iBranchID")]
    public int? EtblArapbatchLinesIBranchId { get; set; }

    [Column("_etblARAPBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchLinesDCreatedDate { get; set; }

    [Column("_etblARAPBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchLinesDModifiedDate { get; set; }

    [Column("_etblARAPBatchLines_iCreatedBranchID")]
    public int? EtblArapbatchLinesICreatedBranchId { get; set; }

    [Column("_etblARAPBatchLines_iModifiedBranchID")]
    public int? EtblArapbatchLinesIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchLines_iCreatedAgentID")]
    public int? EtblArapbatchLinesICreatedAgentId { get; set; }

    [Column("_etblARAPBatchLines_iModifiedAgentID")]
    public int? EtblArapbatchLinesIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchLines_iChangeSetID")]
    public int? EtblArapbatchLinesIChangeSetId { get; set; }

    [Column("iModule")]
    public int? IModule { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("bIsDebit")]
    public bool BIsDebit { get; set; }

    [Column("iMBPropertyID")]
    public int? IMbpropertyId { get; set; }

    [Column("iMBPortionID")]
    public int? IMbportionId { get; set; }

    [Column("iMBServiceID")]
    public int? IMbserviceId { get; set; }

    [Column("iMBPropertyPortionServiceID")]
    public int? IMbpropertyPortionServiceId { get; set; }

    [Column("_etblARAPBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchLinesChecksum { get; set; }

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

    [StringLength(2)]
    [Unicode(false)]
    public string? Module { get; set; }

    [Column("fDebitExcl")]
    public double? FDebitExcl { get; set; }

    [Column("fCreditExcl")]
    public double? FCreditExcl { get; set; }

    [Column("fTaxAmount")]
    public double? FTaxAmount { get; set; }

    [Column("fDebitIncl")]
    public double? FDebitIncl { get; set; }

    [Column("fCreditIncl")]
    public double? FCreditIncl { get; set; }

    [Column("fDebitExclForeign")]
    public double? FDebitExclForeign { get; set; }

    [Column("fCreditExclForeign")]
    public double? FCreditExclForeign { get; set; }

    [Column("fTaxAmountForeign")]
    public double? FTaxAmountForeign { get; set; }

    [Column("fDebitInclForeign")]
    public double? FDebitInclForeign { get; set; }

    [Column("fCreditInclForeign")]
    public double? FCreditInclForeign { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TrCodeDescription { get; set; }

    public bool? TrCodeIsDebit { get; set; }

    [Column("ContraGLMasterSubAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? ContraGlmasterSubAccount { get; set; }

    [Column("ContraGLAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? ContraGlaccount { get; set; }

    [Column("ContraGLDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? ContraGldescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxTypeDescription { get; set; }

    [Column("DiscContraGLMasterSubAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? DiscContraGlmasterSubAccount { get; set; }

    [Column("DiscContraGLAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? DiscContraGlaccount { get; set; }

    [Column("DiscContraGLDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DiscContraGldescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DiscTaxTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DiscTaxTypeDescription { get; set; }

    public int? ProjectLink { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(41)]
    [Unicode(false)]
    public string? MasterSubProject { get; set; }

    public int? ProjectLevel { get; set; }

    public int? SubProjectOfLink { get; set; }

    [Column("Project_iBranchID")]
    public int? ProjectIBranchId { get; set; }

    [Column("Project_dCreatedDate", TypeName = "datetime")]
    public DateTime? ProjectDCreatedDate { get; set; }

    [Column("Project_dModifiedDate", TypeName = "datetime")]
    public DateTime? ProjectDModifiedDate { get; set; }

    [Column("Project_iCreatedBranchID")]
    public int? ProjectICreatedBranchId { get; set; }

    [Column("Project_iModifiedBranchID")]
    public int? ProjectIModifiedBranchId { get; set; }

    [Column("Project_iCreatedAgentID")]
    public int? ProjectICreatedAgentId { get; set; }

    [Column("Project_iModifiedAgentID")]
    public int? ProjectIModifiedAgentId { get; set; }

    [Column("Project_iChangeSetID")]
    public int? ProjectIChangeSetId { get; set; }

    [Column("Project_Checksum")]
    [MaxLength(20)]
    public byte[]? ProjectChecksum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [Column("GLTaxAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? GltaxAccount { get; set; }

    [Column("DCLink")]
    public int? Dclink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Init { get; set; }

    [Column("Contact_Person")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Physical5 { get; set; }

    [Column("PhysicalPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PhysicalPc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Addressee { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Post5 { get; set; }

    [Column("PostPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PostPc { get; set; }

    [Column("Delivered_To")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveredTo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax2 { get; set; }

    public int? AccountTerms { get; set; }

    [Column("CT")]
    public bool? Ct { get; set; }

    [Column("Tax_Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Registration { get; set; }

    [Column("Credit_Limit")]
    public double? CreditLimit { get; set; }

    [Column("RepID")]
    public int? RepId { get; set; }

    [Column("Interest_Rate")]
    public double? InterestRate { get; set; }

    public double? Discount { get; set; }

    [Column("On_Hold")]
    public bool? OnHold { get; set; }

    [Column("BFOpenType")]
    public int? BfopenType { get; set; }

    [Column("EMail")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    public int? BankLink { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccNum { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccType { get; set; }

    public double? AutoDisc { get; set; }

    public int? DiscMtrxRow { get; set; }

    public int? MainAccLink { get; set; }

    public bool? CashDebtor { get; set; }

    [Column("DCBalance")]
    public double? Dcbalance { get; set; }

    public bool? CheckTerms { get; set; }

    public bool? UseEmail { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("iBusTypeID")]
    public int? IBusTypeId { get; set; }

    [Column("iBusClassID")]
    public int? IBusClassId { get; set; }

    [Column("iCountryID")]
    public int? ICountryId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("dTimeStamp", TypeName = "datetime")]
    public DateTime? DTimeStamp { get; set; }

    [Column("cAccDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CAccDescription { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [Column("iClassID")]
    public int? IClassId { get; set; }

    [Column("iAreasID")]
    public int? IAreasId { get; set; }

    [Column("cBankRefNr")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankRefNr { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("bStatPrint")]
    public bool? BStatPrint { get; set; }

    [Column("bStatEmail")]
    public bool? BStatEmail { get; set; }

    [Column("cStatEmailPass")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CStatEmailPass { get; set; }

    [Column("bForCurAcc")]
    public bool? BForCurAcc { get; set; }

    [Column("fForeignBalance")]
    public double? FForeignBalance { get; set; }

    [Column("bTaxPrompt")]
    public bool? BTaxPrompt { get; set; }

    [Column("iARPriceListNameID")]
    public int? IArpriceListNameId { get; set; }

    [Column("iSettlementTermsID")]
    public int? ISettlementTermsId { get; set; }

    [Column("bSourceDocPrint")]
    public bool? BSourceDocPrint { get; set; }

    [Column("bSourceDocEmail")]
    public bool? BSourceDocEmail { get; set; }

    [Column("iEUCountryID")]
    public int? IEucountryId { get; set; }

    [Column("iDefTaxTypeID")]
    public int? IDefTaxTypeId { get; set; }

    [Column("bCODAccount")]
    public bool? BCodaccount { get; set; }

    [Column("Client_iBranchID")]
    public int? ClientIBranchId { get; set; }

    [Column("Client_dCreatedDate", TypeName = "datetime")]
    public DateTime? ClientDCreatedDate { get; set; }

    [Column("Client_dModifiedDate", TypeName = "datetime")]
    public DateTime? ClientDModifiedDate { get; set; }

    [Column("Client_iCreatedBranchID")]
    public int? ClientICreatedBranchId { get; set; }

    [Column("Client_iModifiedBranchID")]
    public int? ClientIModifiedBranchId { get; set; }

    [Column("Client_iCreatedAgentID")]
    public int? ClientICreatedAgentId { get; set; }

    [Column("Client_iModifiedAgentID")]
    public int? ClientIModifiedAgentId { get; set; }

    [Column("Client_iChangeSetID")]
    public int? ClientIChangeSetId { get; set; }

    [Column("iAgeingTermID")]
    public int? IAgeingTermId { get; set; }

    [Column("bElecDocAcceptance")]
    public bool? BElecDocAcceptance { get; set; }

    [Column("iBankDetailType")]
    public byte? IBankDetailType { get; set; }

    [Column("cBankAccHolder")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankAccHolder { get; set; }

    [Column("cIDNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIdnumber { get; set; }

    [Column("cPassportNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPassportNumber { get; set; }

    [Column("bInsuranceCustomer")]
    public bool? BInsuranceCustomer { get; set; }

    [Column("cBankCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [Column("cSwiftCode")]
    [StringLength(11)]
    [Unicode(false)]
    public string? CSwiftCode { get; set; }

    [Column("Client_Checksum")]
    [MaxLength(20)]
    public byte[]? ClientChecksum { get; set; }

    [Column("iSPQueueID")]
    public int? ISpqueueId { get; set; }

    [Column("bCustomerZoneEnabled")]
    public bool? BCustomerZoneEnabled { get; set; }

    [Column("iTaxState")]
    public int? ITaxState { get; set; }
}
