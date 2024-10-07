using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvGlaccountBalancesFull
{
    public int AccountLink { get; set; }

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

    public bool Jr { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CaseAcc { get; set; }

    public bool ActiveAccount { get; set; }

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
    public bool IAllowIcsales { get; set; }

    [Column("iAllowICPurchases")]
    public bool IAllowIcpurchases { get; set; }

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
    public bool BMbisAsset { get; set; }

    [Column("bMBIsGrant")]
    public bool BMbisGrant { get; set; }

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
    public bool BIsBranchLoanAccount { get; set; }

    [Column("bForeignBankAcc")]
    public bool BForeignBankAcc { get; set; }

    [Column("iForeignBankCurrencyID")]
    public int? IForeignBankCurrencyId { get; set; }

    [Column("iForeignBankPEXAccID")]
    public int? IForeignBankPexaccId { get; set; }

    [Column("iForeignBankLEXAccID")]
    public int? IForeignBankLexaccId { get; set; }

    [Column("bRevalueWithSellingRate")]
    public bool BRevalueWithSellingRate { get; set; }

    [Column("bPaymentsBasedTax")]
    public bool BPaymentsBasedTax { get; set; }

    [Column("iAccountType")]
    public int IAccountType { get; set; }

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

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment0Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment0Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment1Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment1Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment2Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment2Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment3Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment3Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment4Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment4Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment5Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment5Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment6Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment6Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment7Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment7Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment8Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment8Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment9Code { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Segment9Desc { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ReportCategoryCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReportCategoryDesc { get; set; }

    [Column("Account_Type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AccountType { get; set; }

    [Column("Account_Type_Old")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AccountTypeOld { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountTypeDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountTypeDescriptionOld { get; set; }

    [Column("IsBSAccountType")]
    public bool? IsBsaccountType { get; set; }

    public bool? IsDebitAccountType { get; set; }

    [Column("idPeriod")]
    public int IdPeriod { get; set; }

    [Column("dPeriodDate", TypeName = "datetime")]
    public DateTime DPeriodDate { get; set; }

    [Column("bBlocked")]
    public bool BBlocked { get; set; }

    [Column("bPBTProcessed")]
    public bool BPbtprocessed { get; set; }

    [Column("bPeriodProcessed")]
    public bool BPeriodProcessed { get; set; }

    [Column("_etblPeriod_iBranchID")]
    public int? EtblPeriodIBranchId { get; set; }

    [Column("_etblPeriod_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodDCreatedDate { get; set; }

    [Column("_etblPeriod_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodDModifiedDate { get; set; }

    [Column("_etblPeriod_iCreatedBranchID")]
    public int? EtblPeriodICreatedBranchId { get; set; }

    [Column("_etblPeriod_iModifiedBranchID")]
    public int? EtblPeriodIModifiedBranchId { get; set; }

    [Column("_etblPeriod_iCreatedAgentID")]
    public int? EtblPeriodICreatedAgentId { get; set; }

    [Column("_etblPeriod_iModifiedAgentID")]
    public int? EtblPeriodIModifiedAgentId { get; set; }

    [Column("_etblPeriod_iChangeSetID")]
    public int? EtblPeriodIChangeSetId { get; set; }

    [Column("_etblPeriod_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPeriodChecksum { get; set; }

    [Column("iYearID")]
    public int IYearId { get; set; }

    [Column("idAccBlnc")]
    public int? IdAccBlnc { get; set; }

    [Column("iAccBlncAccountID")]
    public int? IAccBlncAccountId { get; set; }

    [Column("iAccBlncProjectID")]
    public int? IAccBlncProjectId { get; set; }

    [Column("iAccBlncPeriodID")]
    public int? IAccBlncPeriodId { get; set; }

    [Column("iAccBlncTxBranchID")]
    public int? IAccBlncTxBranchId { get; set; }

    [Column("iAccBlncAccountType")]
    public int? IAccBlncAccountType { get; set; }

    [Column("fActualDebit")]
    public double? FActualDebit { get; set; }

    [Column("fActualCredit")]
    public double? FActualCredit { get; set; }

    [Column("fActualForeignDebit")]
    public double? FActualForeignDebit { get; set; }

    [Column("fActualForeignCredit")]
    public double? FActualForeignCredit { get; set; }

    [Column("_etblAccBlnc_iBranchID")]
    public int? EtblAccBlncIBranchId { get; set; }

    [Column("_etblAccBlnc_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAccBlncDCreatedDate { get; set; }

    [Column("_etblAccBlnc_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAccBlncDModifiedDate { get; set; }

    [Column("_etblAccBlnc_iCreatedBranchID")]
    public int? EtblAccBlncICreatedBranchId { get; set; }

    [Column("_etblAccBlnc_iModifiedBranchID")]
    public int? EtblAccBlncIModifiedBranchId { get; set; }

    [Column("_etblAccBlnc_iCreatedAgentID")]
    public int? EtblAccBlncICreatedAgentId { get; set; }

    [Column("_etblAccBlnc_iModifiedAgentID")]
    public int? EtblAccBlncIModifiedAgentId { get; set; }

    [Column("_etblAccBlnc_iChangeSetID")]
    public int? EtblAccBlncIChangeSetId { get; set; }

    [Column("_etblAccBlnc_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAccBlncChecksum { get; set; }

    [Column("idBudgets")]
    public int? IdBudgets { get; set; }

    [Column("iBudgetAccountID")]
    public int? IBudgetAccountId { get; set; }

    [Column("iBudgetProjectID")]
    public int? IBudgetProjectId { get; set; }

    [Column("iBudgetPeriodID")]
    public int? IBudgetPeriodId { get; set; }

    [Column("iBudgetTxBranchID")]
    public int? IBudgetTxBranchId { get; set; }

    [Column("iBudgetAccountType")]
    public int? IBudgetAccountType { get; set; }

    [Column("fBudget")]
    public double? FBudget { get; set; }

    [Column("fUnprocessedPOValue")]
    public double? FUnprocessedPovalue { get; set; }

    [Column("dBudgetDTStamp", TypeName = "datetime")]
    public DateTime? DBudgetDtstamp { get; set; }

    [Column("_etblBudgets_iBranchID")]
    public int? EtblBudgetsIBranchId { get; set; }

    [Column("_etblBudgets_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblBudgetsDCreatedDate { get; set; }

    [Column("_etblBudgets_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblBudgetsDModifiedDate { get; set; }

    [Column("_etblBudgets_iCreatedBranchID")]
    public int? EtblBudgetsICreatedBranchId { get; set; }

    [Column("_etblBudgets_iModifiedBranchID")]
    public int? EtblBudgetsIModifiedBranchId { get; set; }

    [Column("_etblBudgets_iCreatedAgentID")]
    public int? EtblBudgetsICreatedAgentId { get; set; }

    [Column("_etblBudgets_iModifiedAgentID")]
    public int? EtblBudgetsIModifiedAgentId { get; set; }

    [Column("_etblBudgets_iChangeSetID")]
    public int? EtblBudgetsIChangeSetId { get; set; }

    [Column("_etblBudgets_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblBudgetsChecksum { get; set; }

    [Column("fForecast")]
    public double? FForecast { get; set; }

    [Column("fBudgetForeign")]
    public double? FBudgetForeign { get; set; }

    [Column("fUnprocessedPOValueForeign")]
    public double? FUnprocessedPovalueForeign { get; set; }

    [Column("fForecastForeign")]
    public double? FForecastForeign { get; set; }

    [Column("idYear")]
    public int? IdYear { get; set; }

    [Column("cYearDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CYearDescription { get; set; }

    [Column("dYearStartDate", TypeName = "datetime")]
    public DateTime? DYearStartDate { get; set; }

    [Column("_etblPeriodYear_iBranchID")]
    public int? EtblPeriodYearIBranchId { get; set; }

    [Column("_etblPeriodYear_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodYearDCreatedDate { get; set; }

    [Column("_etblPeriodYear_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodYearDModifiedDate { get; set; }

    [Column("_etblPeriodYear_iCreatedBranchID")]
    public int? EtblPeriodYearICreatedBranchId { get; set; }

    [Column("_etblPeriodYear_iModifiedBranchID")]
    public int? EtblPeriodYearIModifiedBranchId { get; set; }

    [Column("_etblPeriodYear_iCreatedAgentID")]
    public int? EtblPeriodYearICreatedAgentId { get; set; }

    [Column("_etblPeriodYear_iModifiedAgentID")]
    public int? EtblPeriodYearIModifiedAgentId { get; set; }

    [Column("_etblPeriodYear_iChangeSetID")]
    public int? EtblPeriodYearIChangeSetId { get; set; }

    [Column("_etblPeriodYear_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPeriodYearChecksum { get; set; }

    [Column("bArchived")]
    public bool? BArchived { get; set; }

    [Column("bPurged")]
    public bool? BPurged { get; set; }

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
}
