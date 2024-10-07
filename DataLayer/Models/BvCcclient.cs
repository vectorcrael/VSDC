using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCcclient
{
    [Column("DCLink")]
    public int Dclink { get; set; }

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
    public bool Ct { get; set; }

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
    public bool OnHold { get; set; }

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

    public bool CashDebtor { get; set; }

    [Column("DCBalance")]
    public double? Dcbalance { get; set; }

    public bool CheckTerms { get; set; }

    public bool UseEmail { get; set; }

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
    public bool BStatPrint { get; set; }

    [Column("bStatEmail")]
    public bool BStatEmail { get; set; }

    [Column("cStatEmailPass")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CStatEmailPass { get; set; }

    [Column("bForCurAcc")]
    public bool BForCurAcc { get; set; }

    [Column("fForeignBalance")]
    public double? FForeignBalance { get; set; }

    [Column("bTaxPrompt")]
    public bool BTaxPrompt { get; set; }

    [Column("iARPriceListNameID")]
    public int? IArpriceListNameId { get; set; }

    [Column("iSettlementTermsID")]
    public int ISettlementTermsId { get; set; }

    [Column("bSourceDocPrint")]
    public bool BSourceDocPrint { get; set; }

    [Column("bSourceDocEmail")]
    public bool BSourceDocEmail { get; set; }

    [Column("iEUCountryID")]
    public int IEucountryId { get; set; }

    [Column("iDefTaxTypeID")]
    public int IDefTaxTypeId { get; set; }

    [Column("bCODAccount")]
    public bool BCodaccount { get; set; }

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
    public bool BElecDocAcceptance { get; set; }

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
    public bool BCustomerZoneEnabled { get; set; }

    [Column("iTaxState")]
    public int ITaxState { get; set; }
}
