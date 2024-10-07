using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvArapbatchContraSplit
{
    [Column("idARAPBatchContraSplit")]
    public int IdArapbatchContraSplit { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("iLinePermID")]
    public int ILinePermId { get; set; }

    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("fAmountForeign")]
    public double? FAmountForeign { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iTaxTypeID")]
    public int ITaxTypeId { get; set; }

    [Column("fAmountIncl")]
    public double? FAmountIncl { get; set; }

    [Column("fAmountInclForeign")]
    public double? FAmountInclForeign { get; set; }

    [Column("_etblARAPBatchContraSplit_iBranchID")]
    public int? EtblArapbatchContraSplitIBranchId { get; set; }

    [Column("_etblARAPBatchContraSplit_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchContraSplitDCreatedDate { get; set; }

    [Column("_etblARAPBatchContraSplit_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchContraSplitDModifiedDate { get; set; }

    [Column("_etblARAPBatchContraSplit_iCreatedBranchID")]
    public int? EtblArapbatchContraSplitICreatedBranchId { get; set; }

    [Column("_etblARAPBatchContraSplit_iModifiedBranchID")]
    public int? EtblArapbatchContraSplitIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchContraSplit_iCreatedAgentID")]
    public int? EtblArapbatchContraSplitICreatedAgentId { get; set; }

    [Column("_etblARAPBatchContraSplit_iModifiedAgentID")]
    public int? EtblArapbatchContraSplitIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchContraSplit_iChangeSetID")]
    public int? EtblArapbatchContraSplitIChangeSetId { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("_etblARAPBatchContraSplit_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchContraSplitChecksum { get; set; }

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

    public int? AccountLink { get; set; }

    [Column("Master_Sub_Account")]
    [StringLength(91)]
    [Unicode(false)]
    public string? MasterSubAccount { get; set; }

    public int? AccountLevel { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? Account { get; set; }

    public int? SubAccOfLink { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Dept { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Brch { get; set; }

    public bool? Jr { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CaseAcc { get; set; }

    public bool? ActiveAccount { get; set; }

    [Column("dAccountsTimeStamp", TypeName = "datetime")]
    public DateTime? DAccountsTimeStamp { get; set; }

    [Column("cNextChequeNum")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CNextChequeNum { get; set; }

    [Column("iGLSegment0ID")]
    public int? IGlsegment0Id { get; set; }

    [Column("iGLSegment1ID")]
    public int? IGlsegment1Id { get; set; }

    [Column("iGLSegment2ID")]
    public int? IGlsegment2Id { get; set; }

    [Column("iGLSegment3ID")]
    public int? IGlsegment3Id { get; set; }

    [Column("iGLSegment4ID")]
    public int? IGlsegment4Id { get; set; }

    [Column("iGLSegment5ID")]
    public int? IGlsegment5Id { get; set; }

    [Column("iGLSegment6ID")]
    public int? IGlsegment6Id { get; set; }

    [Column("iGLSegment7ID")]
    public int? IGlsegment7Id { get; set; }

    [Column("iGLSegment8ID")]
    public int? IGlsegment8Id { get; set; }

    [Column("iGLSegment9ID")]
    public int? IGlsegment9Id { get; set; }

    [Column("iReportCategoryID")]
    public int? IReportCategoryId { get; set; }

    [Column("fBankStatementBalance")]
    public double? FBankStatementBalance { get; set; }

    [Column("cExtDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CExtDescription { get; set; }

    [Column("iTaxTypeINVID")]
    public int? ITaxTypeInvid { get; set; }

    [Column("iTaxTypeCRNID")]
    public int? ITaxTypeCrnid { get; set; }

    [Column("iTaxTypeGRVID")]
    public int? ITaxTypeGrvid { get; set; }

    [Column("iTaxTypeRTSID")]
    public int? ITaxTypeRtsid { get; set; }

    [Column("iAllowICSales")]
    public bool? IAllowIcsales { get; set; }

    [Column("iAllowICPurchases")]
    public bool? IAllowIcpurchases { get; set; }

    [Column("Accounts_iBranchID")]
    public int? AccountsIBranchId { get; set; }

    [Column("Accounts_dCreatedDate", TypeName = "datetime")]
    public DateTime? AccountsDCreatedDate { get; set; }

    [Column("Accounts_dModifiedDate", TypeName = "datetime")]
    public DateTime? AccountsDModifiedDate { get; set; }

    [Column("Accounts_iCreatedBranchID")]
    public int? AccountsICreatedBranchId { get; set; }

    [Column("Accounts_iModifiedBranchID")]
    public int? AccountsIModifiedBranchId { get; set; }

    [Column("Accounts_iCreatedAgentID")]
    public int? AccountsICreatedAgentId { get; set; }

    [Column("Accounts_iModifiedAgentID")]
    public int? AccountsIModifiedAgentId { get; set; }

    [Column("Accounts_iChangeSetID")]
    public int? AccountsIChangeSetId { get; set; }

    [Column("iMBReportingCategoryID")]
    public int? IMbreportingCategoryId { get; set; }

    [Column("iMBCashFlowCategoryID")]
    public int? IMbcashFlowCategoryId { get; set; }

    [Column("bMBIsAsset")]
    public bool? BMbisAsset { get; set; }

    [Column("bMBIsGrant")]
    public bool? BMbisGrant { get; set; }

    [Column("iMBAssetClassificationID")]
    public int? IMbassetClassificationId { get; set; }

    [Column("iMBAssetCategoryID")]
    public int? IMbassetCategoryId { get; set; }

    [Column("iMBAssetTypeID")]
    public int? IMbassetTypeId { get; set; }

    [Column("iMBGrantLevel1TypeID")]
    public int? IMbgrantLevel1TypeId { get; set; }

    [Column("iMBGrantLevel2TypeID")]
    public int? IMbgrantLevel2TypeId { get; set; }

    [Column("iMBGrantLevel3TypeID")]
    public int? IMbgrantLevel3TypeId { get; set; }

    [Column("bIsBranchLoanAccount")]
    public bool? BIsBranchLoanAccount { get; set; }

    [Column("bForeignBankAcc")]
    public bool? BForeignBankAcc { get; set; }

    [Column("iForeignBankCurrencyID")]
    public int? IForeignBankCurrencyId { get; set; }

    [Column("iForeignBankPEXAccID")]
    public int? IForeignBankPexaccId { get; set; }

    [Column("iForeignBankLEXAccID")]
    public int? IForeignBankLexaccId { get; set; }

    [Column("bRevalueWithSellingRate")]
    public bool? BRevalueWithSellingRate { get; set; }

    [Column("bPaymentsBasedTax")]
    public bool? BPaymentsBasedTax { get; set; }

    [Column("iAccountType")]
    public int? IAccountType { get; set; }

    [Column("cBankName")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CBankName { get; set; }

    [Column("cBankAccountName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBankAccountName { get; set; }

    [Column("cBankCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [Column("cBankAccountNumber")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CBankAccountNumber { get; set; }

    [Column("cBranchName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBranchName { get; set; }

    [Column("cSEPABranchCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CSepabranchCode { get; set; }

    [Column("cBankRefNr")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBankRefNr { get; set; }

    [Column("Accounts_Checksum")]
    [MaxLength(20)]
    public byte[]? AccountsChecksum { get; set; }

    [Column("ulGLSector1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector1 { get; set; }

    [Column("ulGLSector2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector2 { get; set; }

    [Column("ulGLSector3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector3 { get; set; }

    [Column("ulGLSector4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector4 { get; set; }

    [Column("ulGLSector5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector5 { get; set; }

    [Column("ulGLSector6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector6 { get; set; }

    [Column("ulGLSector7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector7 { get; set; }

    [Column("ulGLSector8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector8 { get; set; }

    [Column("ulGLSector9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector9 { get; set; }

    [Column("ulGLSector10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlsector10 { get; set; }

    [Column("ulGLCostCentre")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UlGlcostCentre { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxTypeDescription { get; set; }

    public double? TaxTypeRate { get; set; }
}
