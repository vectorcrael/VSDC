﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Vendor")]
[Index("VendorDModifiedDate", Name = "idxVendor_dModifiedDate")]
[Index("VendorIBranchId", Name = "idxVendor_iBranchID")]
[Index("VendorChecksum", Name = "idx_Vendor_Vendor_Checksum")]
[Index("CIdnumber", Name = "idx_Vendor_cIDNumber")]
[Index("CPassportNumber", Name = "idx_Vendor_cPassportNumber")]
[Index("VendorIChangeSetId", Name = "idx_Vendor_iChangeSetID")]
public partial class Vendor
{
    [Key]
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

    [Column("DCBalance")]
    public double? Dcbalance { get; set; }

    public bool CheckTerms { get; set; }

    public bool UseEmail { get; set; }

    [Column("iBusTypeID")]
    public int? IBusTypeId { get; set; }

    [Column("iBusClassID")]
    public int? IBusClassId { get; set; }

    [Column("iCountryID")]
    public int? ICountryId { get; set; }

    [Column("cAccDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CAccDescription { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [Column("dTimeStamp", TypeName = "datetime")]
    public DateTime? DTimeStamp { get; set; }

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

    [Column("bRemittanceChequeEFTS")]
    public bool BRemittanceChequeEfts { get; set; }

    [Column("fForeignBalance")]
    public double? FForeignBalance { get; set; }

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

    [Column("Vendor_iBranchID")]
    public int? VendorIBranchId { get; set; }

    [Column("Vendor_dCreatedDate", TypeName = "datetime")]
    public DateTime? VendorDCreatedDate { get; set; }

    [Column("Vendor_dModifiedDate", TypeName = "datetime")]
    public DateTime? VendorDModifiedDate { get; set; }

    [Column("Vendor_iCreatedBranchID")]
    public int? VendorICreatedBranchId { get; set; }

    [Column("Vendor_iModifiedBranchID")]
    public int? VendorIModifiedBranchId { get; set; }

    [Column("Vendor_iCreatedAgentID")]
    public int? VendorICreatedAgentId { get; set; }

    [Column("Vendor_iModifiedAgentID")]
    public int? VendorIModifiedAgentId { get; set; }

    [Column("Vendor_iChangeSetID")]
    public int? VendorIChangeSetId { get; set; }

    [Column("iAgeingTermID")]
    public int? IAgeingTermId { get; set; }

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

    [Column("cBankCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [Column("cSwiftCode")]
    [StringLength(11)]
    [Unicode(false)]
    public string? CSwiftCode { get; set; }

    [Column("iBankDetailID")]
    public int? IBankDetailId { get; set; }

    [Column("Vendor_Checksum")]
    [MaxLength(20)]
    public byte[]? VendorChecksum { get; set; }

    [Column("iSPQueueID")]
    public int? ISpqueueId { get; set; }

    [Column("iTaxState")]
    public int ITaxState { get; set; }

    [Column("ulAPSector1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector1 { get; set; }

    [Column("ulAPSector2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector2 { get; set; }

    [Column("ulAPSector3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector3 { get; set; }

    [Column("ulAPSector4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector4 { get; set; }

    [Column("ulAPSector5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector5 { get; set; }

    [Column("ulAPSector6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector6 { get; set; }

    [Column("ulAPSector7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector7 { get; set; }

    [Column("ulAPSector8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector8 { get; set; }

    [Column("ulAPSector9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector9 { get; set; }

    [Column("ulAPSector10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsector10 { get; set; }

    [Column("ulAPSupplierLocation")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApsupplierLocation { get; set; }

    [Column("udAPRegistrationDate", TypeName = "datetime")]
    public DateTime? UdApregistrationDate { get; set; }

    [Column("ubAPBEECompliant")]
    public bool? UbApbeecompliant { get; set; }

    [Column("ulAPStatus")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApstatus { get; set; }

    [Column("ulAPDeliveryGoods")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlApdeliveryGoods { get; set; }

    [Column("ubAPFailToDeliver")]
    public bool? UbApfailToDeliver { get; set; }

    [Column("ubAPWorkforGovt")]
    public bool? UbApworkforGovt { get; set; }

    [Column("ubAPBlacklistedbyGovt")]
    public bool? UbApblacklistedbyGovt { get; set; }

    [Column("ubAPConfirmCompany")]
    public bool? UbApconfirmCompany { get; set; }

    [Column("ufAPHDI")]
    public double? UfAphdi { get; set; }

    [Column("ufAPFunctionality")]
    public double? UfApfunctionality { get; set; }

    [Column("ufAPExperience")]
    public double? UfApexperience { get; set; }

    [Column("ufAPWomen")]
    public double? UfApwomen { get; set; }

    [Column("ufAPWhite")]
    public double? UfApwhite { get; set; }

    [Column("ufAPMiscellaneous")]
    public double? UfApmiscellaneous { get; set; }

    [Column("ufAPPrice")]
    public double? UfApprice { get; set; }
}
