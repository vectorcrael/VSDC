using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_Vendor")]
[Index("RfqVendorChecksum", Name = "idx_RFQ_Vendor_RFQ_Vendor_Checksum")]
[Index("RfqVendorDModifiedDate", Name = "idx_RFQ_Vendor_RFQ_Vendor_dModifiedDate")]
[Index("RfqVendorIBranchId", Name = "idx_RFQ_Vendor_RFQ_Vendor_iBranchID")]
[Index("RfqVendorIChangeSetId", Name = "idx_RFQ_Vendor_RFQ_Vendor_iChangeSetID")]
public partial class RfqVendor
{
    [Key]
    [Column("idVendor")]
    public int IdVendor { get; set; }

    [Column("cVendorAccount")]
    [StringLength(20)]
    [Unicode(false)]
    public string CVendorAccount { get; set; } = null!;

    [Column("cVendorName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CVendorName { get; set; }

    [Column("cDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cVendorTitle")]
    [StringLength(5)]
    public string? CVendorTitle { get; set; }

    [Column("cInit")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CInit { get; set; }

    [Column("bApproved")]
    public bool? BApproved { get; set; }

    [Column("bRejected")]
    public bool? BRejected { get; set; }

    [Column("bExportToEvo")]
    public bool? BExportToEvo { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [Column("iClassID")]
    public int? IClassId { get; set; }

    [Column("iAreasID")]
    public int? IAreasId { get; set; }

    [Column("BFOpen")]
    public int? Bfopen { get; set; }

    public bool CheckTerms { get; set; }

    [Column("CT")]
    public bool Ct { get; set; }

    [Column("Tax_Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Registration { get; set; }

    [Column("iAgeingTermID")]
    public int? IAgeingTermId { get; set; }

    public int? AccountTerms { get; set; }

    [Column("Credit_Limit")]
    public double? CreditLimit { get; set; }

    [Column("Interest_Rate")]
    public double? InterestRate { get; set; }

    [Column("iSettlementTermsID")]
    public int? ISettlementTermsId { get; set; }

    public double? Discount { get; set; }

    public double? AutoDisc { get; set; }

    public int? DiscMtrxRow { get; set; }

    [Column("bForCurAcc")]
    public bool BForCurAcc { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("Contact_Person")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [Column("Delivered_To")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DeliveredTo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax2 { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Addressee { get; set; }

    [Column("EMail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Email { get; set; }

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

    [Column("RFQ_Vendor_iBranchID")]
    public int? RfqVendorIBranchId { get; set; }

    [Column("RFQ_Vendor_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqVendorDCreatedDate { get; set; }

    [Column("RFQ_Vendor_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqVendorDModifiedDate { get; set; }

    [Column("RFQ_Vendor_iCreatedBranchID")]
    public int? RfqVendorICreatedBranchId { get; set; }

    [Column("RFQ_Vendor_iModifiedBranchID")]
    public int? RfqVendorIModifiedBranchId { get; set; }

    [Column("RFQ_Vendor_iCreatedAgentID")]
    public int? RfqVendorICreatedAgentId { get; set; }

    [Column("RFQ_Vendor_iModifiedAgentID")]
    public int? RfqVendorIModifiedAgentId { get; set; }

    [Column("RFQ_Vendor_iChangeSetID")]
    public int? RfqVendorIChangeSetId { get; set; }

    [Column("RFQ_Vendor_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqVendorChecksum { get; set; }

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

    [Column("cBankRefNr")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankRefNr { get; set; }

    [Column("bStatPrint")]
    public bool? BStatPrint { get; set; }

    [Column("bStatEmail")]
    public bool? BStatEmail { get; set; }

    [Column("bSourceDocPrint")]
    public bool? BSourceDocPrint { get; set; }

    [Column("bSourceDocEmail")]
    public bool? BSourceDocEmail { get; set; }

    [Column("cStatEmailPass")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CStatEmailPass { get; set; }

    [Column("bRemittanceChequeEFTS")]
    public bool? BRemittanceChequeEfts { get; set; }

    [Column("iDefTaxTypeID")]
    public int IDefTaxTypeId { get; set; }

    [Column("cIDNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIdnumber { get; set; }

    [Column("cPassportNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPassportNumber { get; set; }

    [Column("cBankAccHolder")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankAccHolder { get; set; }

    [Column("cBankCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [InverseProperty("IVendor")]
    public virtual ICollection<RfqVendorScore> RfqVendorScores { get; set; } = new List<RfqVendorScore>();
}
