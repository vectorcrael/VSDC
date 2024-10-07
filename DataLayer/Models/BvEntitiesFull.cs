using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvEntitiesFull
{
    [Column("idEntities")]
    public int IdEntities { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PhAddress1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PhAddress2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PhAddress3 { get; set; }

    [Column("POAddress1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Poaddress1 { get; set; }

    [Column("POAddress2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Poaddress2 { get; set; }

    [Column("POAddress3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Poaddress3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telephone1 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("Version_Dont_Change")]
    public double? VersionDontChange { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? StrSpare1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ShrStrSpare1 { get; set; }

    [Column("iNextAuditNumber")]
    public int? INextAuditNumber { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("EFTSCode")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Eftscode { get; set; }

    [Column("EFTSName")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Eftsname { get; set; }

    [Column("EFTSReference")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Eftsreference { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TranLogActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegisterName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TradingName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Town { get; set; }

    [Column(TypeName = "text")]
    public string? CompanyInfo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? IncorpForm { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TypeofBus { get; set; }

    [Column("ShowInactiveGL")]
    public bool ShowInactiveGl { get; set; }

    public bool ShowInactiveProjects { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PhPostalCode { get; set; }

    [Column("POPostalCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PopostalCode { get; set; }

    public int? PhState { get; set; }

    [Column("POState")]
    public int? Postate { get; set; }

    public int? PhCountry { get; set; }

    [Column("POCountry")]
    public int? Pocountry { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [Column("cWebSiteAddress")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CWebSiteAddress { get; set; }

    [Column("cGLSegmentSeparator")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CGlsegmentSeparator { get; set; }

    [Column("cBankRefNr")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankRefNr { get; set; }

    [Column("cAccountName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAccountName { get; set; }

    [Column("cBranchName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBranchName { get; set; }

    [Column("fAccountLimit")]
    public double? FAccountLimit { get; set; }

    [Column("iEUCountryID")]
    public int IEucountryId { get; set; }

    [Column("bAPDocBudgetCheck")]
    public bool BApdocBudgetCheck { get; set; }

    [Column("bAPDocBudgetAnnual")]
    public bool BApdocBudgetAnnual { get; set; }

    [Column("cHomeCurrency")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CHomeCurrency { get; set; }

    [Column("Entities_iBranchID")]
    public int? EntitiesIBranchId { get; set; }

    [Column("Entities_dCreatedDate", TypeName = "datetime")]
    public DateTime? EntitiesDCreatedDate { get; set; }

    [Column("Entities_dModifiedDate", TypeName = "datetime")]
    public DateTime? EntitiesDModifiedDate { get; set; }

    [Column("Entities_iCreatedBranchID")]
    public int? EntitiesICreatedBranchId { get; set; }

    [Column("Entities_iModifiedBranchID")]
    public int? EntitiesIModifiedBranchId { get; set; }

    [Column("Entities_iCreatedAgentID")]
    public int? EntitiesICreatedAgentId { get; set; }

    [Column("Entities_iModifiedAgentID")]
    public int? EntitiesIModifiedAgentId { get; set; }

    [Column("Entities_iChangeSetID")]
    public int? EntitiesIChangeSetId { get; set; }

    [Column("bSingleEntityReporting")]
    public bool BSingleEntityReporting { get; set; }

    [Column("iFilterStartLength")]
    public int IFilterStartLength { get; set; }

    [Column("bUseIntegreatedEFT")]
    public bool? BUseIntegreatedEft { get; set; }

    [Column("cMerchantType")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CMerchantType { get; set; }

    [Column("cMerchantID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CMerchantId { get; set; }

    [Column("cIPAddress")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIpaddress { get; set; }

    [Column("iPort")]
    public int? IPort { get; set; }

    [Column("dCommencementDate", TypeName = "datetime")]
    public DateTime? DCommencementDate { get; set; }

    [Column("GatewayID")]
    public int? GatewayId { get; set; }

    [Column("bUseBins")]
    public bool BUseBins { get; set; }

    [Column("cBinIPAddress")]
    [StringLength(20)]
    public string? CBinIpaddress { get; set; }

    [Column("iBinPort")]
    public int IBinPort { get; set; }

    [Column("cBankCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [Column("bAllowDCProcessing")]
    public bool BAllowDcprocessing { get; set; }

    [Column("iDCBranchLoanAccountID")]
    public int? IDcbranchLoanAccountId { get; set; }

    [Column("Entities_Checksum")]
    [MaxLength(20)]
    public byte[]? EntitiesChecksum { get; set; }

    [Column("bUsemSCOA")]
    public bool BUsemScoa { get; set; }

    [Column("iDefaultTaxState")]
    public int IDefaultTaxState { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PhysicalStateCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PhysicalStateDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PostalStateCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PostalStateDescription { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PhysicalCountry { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PostalCountry { get; set; }

    [Column("Tax_Number")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TaxNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Registration { get; set; }

    [Column("cCustomsCode")]
    [StringLength(8)]
    [Unicode(false)]
    public string? CCustomsCode { get; set; }

    public bool? PrincipalVendor { get; set; }

    [StringLength(90)]
    [Unicode(false)]
    public string? TaxContactName { get; set; }

    [StringLength(53)]
    [Unicode(false)]
    public string? TaxContactSurname { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TaxContactTelephone1 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TaxContactTelephone2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TaxContactCellular { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? TaxContactEmail { get; set; }
}
