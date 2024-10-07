using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvGlaccountsFinancial
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

    [Column("Account_Type_New")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AccountTypeNew { get; set; }

    [Column("Account_Type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AccountType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountTypeDescriptionNew { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountTypeDescription { get; set; }

    [Column("IsBSAccountType")]
    public bool? IsBsaccountType { get; set; }

    public bool? IsDebitAccountType { get; set; }

    [Column("iTxBranchBlncID")]
    public int ITxBranchBlncId { get; set; }

    [Column("Actual_Deb00")]
    public int ActualDeb00 { get; set; }

    [Column("Actual_Deb01")]
    public double ActualDeb01 { get; set; }

    [Column("Actual_Deb02")]
    public double ActualDeb02 { get; set; }

    [Column("Actual_Deb03")]
    public double ActualDeb03 { get; set; }

    [Column("Actual_Deb04")]
    public double ActualDeb04 { get; set; }

    [Column("Actual_Deb05")]
    public double ActualDeb05 { get; set; }

    [Column("Actual_Deb06")]
    public double ActualDeb06 { get; set; }

    [Column("Actual_Deb07")]
    public double ActualDeb07 { get; set; }

    [Column("Actual_Deb08")]
    public double ActualDeb08 { get; set; }

    [Column("Actual_Deb09")]
    public double ActualDeb09 { get; set; }

    [Column("Actual_Deb10")]
    public double ActualDeb10 { get; set; }

    [Column("Actual_Deb11")]
    public double ActualDeb11 { get; set; }

    [Column("Actual_Deb12")]
    public double ActualDeb12 { get; set; }

    [Column("Actual_Deb13")]
    public double ActualDeb13 { get; set; }

    [Column("Actual_Deb14")]
    public double ActualDeb14 { get; set; }

    [Column("Actual_Deb15")]
    public double ActualDeb15 { get; set; }

    [Column("Actual_Deb16")]
    public double ActualDeb16 { get; set; }

    [Column("Actual_Deb17")]
    public double ActualDeb17 { get; set; }

    [Column("Actual_Deb18")]
    public double ActualDeb18 { get; set; }

    [Column("Actual_Deb19")]
    public double ActualDeb19 { get; set; }

    [Column("Actual_Deb20")]
    public double ActualDeb20 { get; set; }

    [Column("Actual_Deb21")]
    public double ActualDeb21 { get; set; }

    [Column("Actual_Deb22")]
    public double ActualDeb22 { get; set; }

    [Column("Actual_Deb23")]
    public double ActualDeb23 { get; set; }

    [Column("Actual_Deb24")]
    public double ActualDeb24 { get; set; }

    [Column("Actual_Deb25")]
    public double ActualDeb25 { get; set; }

    [Column("Actual_Deb26")]
    public double ActualDeb26 { get; set; }

    [Column("Actual_Deb27")]
    public double ActualDeb27 { get; set; }

    [Column("Actual_Deb28")]
    public double ActualDeb28 { get; set; }

    [Column("Actual_Deb29")]
    public double ActualDeb29 { get; set; }

    [Column("Actual_Deb30")]
    public double ActualDeb30 { get; set; }

    [Column("Actual_Deb31")]
    public double ActualDeb31 { get; set; }

    [Column("Actual_Deb32")]
    public double ActualDeb32 { get; set; }

    [Column("Actual_Deb33")]
    public double ActualDeb33 { get; set; }

    [Column("Actual_Deb34")]
    public double ActualDeb34 { get; set; }

    [Column("Actual_Deb35")]
    public double ActualDeb35 { get; set; }

    [Column("Actual_Deb36")]
    public double ActualDeb36 { get; set; }

    [Column("Actual_Deb37")]
    public double ActualDeb37 { get; set; }

    [Column("Actual_Deb38")]
    public double ActualDeb38 { get; set; }

    [Column("Actual_Deb39")]
    public double ActualDeb39 { get; set; }

    [Column("Actual_Deb40")]
    public double ActualDeb40 { get; set; }

    [Column("Actual_Deb41")]
    public double ActualDeb41 { get; set; }

    [Column("Actual_Deb42")]
    public double ActualDeb42 { get; set; }

    [Column("Actual_Deb43")]
    public double ActualDeb43 { get; set; }

    [Column("Actual_Deb44")]
    public double ActualDeb44 { get; set; }

    [Column("Actual_Deb45")]
    public double ActualDeb45 { get; set; }

    [Column("Actual_Deb46")]
    public double ActualDeb46 { get; set; }

    [Column("Actual_Deb47")]
    public double ActualDeb47 { get; set; }

    [Column("Actual_Deb48")]
    public double ActualDeb48 { get; set; }

    [Column("Actual_Deb49")]
    public double ActualDeb49 { get; set; }

    [Column("Actual_Deb50")]
    public double ActualDeb50 { get; set; }

    [Column("Actual_Deb51")]
    public double ActualDeb51 { get; set; }

    [Column("Actual_Deb52")]
    public double ActualDeb52 { get; set; }

    [Column("Actual_Deb53")]
    public double ActualDeb53 { get; set; }

    [Column("Actual_Deb54")]
    public double ActualDeb54 { get; set; }

    [Column("Actual_Deb55")]
    public double ActualDeb55 { get; set; }

    [Column("Actual_Deb56")]
    public double ActualDeb56 { get; set; }

    [Column("Actual_Deb57")]
    public double ActualDeb57 { get; set; }

    [Column("Actual_Deb58")]
    public double ActualDeb58 { get; set; }

    [Column("Actual_Deb59")]
    public double ActualDeb59 { get; set; }

    [Column("Actual_Deb60")]
    public double ActualDeb60 { get; set; }

    [Column("Actual_ForeignDeb00")]
    public int ActualForeignDeb00 { get; set; }

    [Column("Actual_ForeignDeb01")]
    public double ActualForeignDeb01 { get; set; }

    [Column("Actual_ForeignDeb02")]
    public double ActualForeignDeb02 { get; set; }

    [Column("Actual_ForeignDeb03")]
    public double ActualForeignDeb03 { get; set; }

    [Column("Actual_ForeignDeb04")]
    public double ActualForeignDeb04 { get; set; }

    [Column("Actual_ForeignDeb05")]
    public double ActualForeignDeb05 { get; set; }

    [Column("Actual_ForeignDeb06")]
    public double ActualForeignDeb06 { get; set; }

    [Column("Actual_ForeignDeb07")]
    public double ActualForeignDeb07 { get; set; }

    [Column("Actual_ForeignDeb08")]
    public double ActualForeignDeb08 { get; set; }

    [Column("Actual_ForeignDeb09")]
    public double ActualForeignDeb09 { get; set; }

    [Column("Actual_ForeignDeb10")]
    public double ActualForeignDeb10 { get; set; }

    [Column("Actual_ForeignDeb11")]
    public double ActualForeignDeb11 { get; set; }

    [Column("Actual_ForeignDeb12")]
    public double ActualForeignDeb12 { get; set; }

    [Column("Actual_ForeignDeb13")]
    public double ActualForeignDeb13 { get; set; }

    [Column("Actual_ForeignDeb14")]
    public double ActualForeignDeb14 { get; set; }

    [Column("Actual_ForeignDeb15")]
    public double ActualForeignDeb15 { get; set; }

    [Column("Actual_ForeignDeb16")]
    public double ActualForeignDeb16 { get; set; }

    [Column("Actual_ForeignDeb17")]
    public double ActualForeignDeb17 { get; set; }

    [Column("Actual_ForeignDeb18")]
    public double ActualForeignDeb18 { get; set; }

    [Column("Actual_ForeignDeb19")]
    public double ActualForeignDeb19 { get; set; }

    [Column("Actual_ForeignDeb20")]
    public double ActualForeignDeb20 { get; set; }

    [Column("Actual_ForeignDeb21")]
    public double ActualForeignDeb21 { get; set; }

    [Column("Actual_ForeignDeb22")]
    public double ActualForeignDeb22 { get; set; }

    [Column("Actual_ForeignDeb23")]
    public double ActualForeignDeb23 { get; set; }

    [Column("Actual_ForeignDeb24")]
    public double ActualForeignDeb24 { get; set; }

    [Column("Actual_ForeignDeb25")]
    public double ActualForeignDeb25 { get; set; }

    [Column("Actual_ForeignDeb26")]
    public double ActualForeignDeb26 { get; set; }

    [Column("Actual_ForeignDeb27")]
    public double ActualForeignDeb27 { get; set; }

    [Column("Actual_ForeignDeb28")]
    public double ActualForeignDeb28 { get; set; }

    [Column("Actual_ForeignDeb29")]
    public double ActualForeignDeb29 { get; set; }

    [Column("Actual_ForeignDeb30")]
    public double ActualForeignDeb30 { get; set; }

    [Column("Actual_ForeignDeb31")]
    public double ActualForeignDeb31 { get; set; }

    [Column("Actual_ForeignDeb32")]
    public double ActualForeignDeb32 { get; set; }

    [Column("Actual_ForeignDeb33")]
    public double ActualForeignDeb33 { get; set; }

    [Column("Actual_ForeignDeb34")]
    public double ActualForeignDeb34 { get; set; }

    [Column("Actual_ForeignDeb35")]
    public double ActualForeignDeb35 { get; set; }

    [Column("Actual_ForeignDeb36")]
    public double ActualForeignDeb36 { get; set; }

    [Column("Actual_ForeignDeb37")]
    public double ActualForeignDeb37 { get; set; }

    [Column("Actual_ForeignDeb38")]
    public double ActualForeignDeb38 { get; set; }

    [Column("Actual_ForeignDeb39")]
    public double ActualForeignDeb39 { get; set; }

    [Column("Actual_ForeignDeb40")]
    public double ActualForeignDeb40 { get; set; }

    [Column("Actual_ForeignDeb41")]
    public double ActualForeignDeb41 { get; set; }

    [Column("Actual_ForeignDeb42")]
    public double ActualForeignDeb42 { get; set; }

    [Column("Actual_ForeignDeb43")]
    public double ActualForeignDeb43 { get; set; }

    [Column("Actual_ForeignDeb44")]
    public double ActualForeignDeb44 { get; set; }

    [Column("Actual_ForeignDeb45")]
    public double ActualForeignDeb45 { get; set; }

    [Column("Actual_ForeignDeb46")]
    public double ActualForeignDeb46 { get; set; }

    [Column("Actual_ForeignDeb47")]
    public double ActualForeignDeb47 { get; set; }

    [Column("Actual_ForeignDeb48")]
    public double ActualForeignDeb48 { get; set; }

    [Column("Actual_ForeignDeb49")]
    public double ActualForeignDeb49 { get; set; }

    [Column("Actual_ForeignDeb50")]
    public double ActualForeignDeb50 { get; set; }

    [Column("Actual_ForeignDeb51")]
    public double ActualForeignDeb51 { get; set; }

    [Column("Actual_ForeignDeb52")]
    public double ActualForeignDeb52 { get; set; }

    [Column("Actual_ForeignDeb53")]
    public double ActualForeignDeb53 { get; set; }

    [Column("Actual_ForeignDeb54")]
    public double ActualForeignDeb54 { get; set; }

    [Column("Actual_ForeignDeb55")]
    public double ActualForeignDeb55 { get; set; }

    [Column("Actual_ForeignDeb56")]
    public double ActualForeignDeb56 { get; set; }

    [Column("Actual_ForeignDeb57")]
    public double ActualForeignDeb57 { get; set; }

    [Column("Actual_ForeignDeb58")]
    public double ActualForeignDeb58 { get; set; }

    [Column("Actual_ForeignDeb59")]
    public double ActualForeignDeb59 { get; set; }

    [Column("Actual_ForeignDeb60")]
    public double ActualForeignDeb60 { get; set; }

    [Column("Actual_Cred00")]
    public int ActualCred00 { get; set; }

    [Column("Actual_Cred01")]
    public double ActualCred01 { get; set; }

    [Column("Actual_Cred02")]
    public double ActualCred02 { get; set; }

    [Column("Actual_Cred03")]
    public double ActualCred03 { get; set; }

    [Column("Actual_Cred04")]
    public double ActualCred04 { get; set; }

    [Column("Actual_Cred05")]
    public double ActualCred05 { get; set; }

    [Column("Actual_Cred06")]
    public double ActualCred06 { get; set; }

    [Column("Actual_Cred07")]
    public double ActualCred07 { get; set; }

    [Column("Actual_Cred08")]
    public double ActualCred08 { get; set; }

    [Column("Actual_Cred09")]
    public double ActualCred09 { get; set; }

    [Column("Actual_Cred10")]
    public double ActualCred10 { get; set; }

    [Column("Actual_Cred11")]
    public double ActualCred11 { get; set; }

    [Column("Actual_Cred12")]
    public double ActualCred12 { get; set; }

    [Column("Actual_Cred13")]
    public double ActualCred13 { get; set; }

    [Column("Actual_Cred14")]
    public double ActualCred14 { get; set; }

    [Column("Actual_Cred15")]
    public double ActualCred15 { get; set; }

    [Column("Actual_Cred16")]
    public double ActualCred16 { get; set; }

    [Column("Actual_Cred17")]
    public double ActualCred17 { get; set; }

    [Column("Actual_Cred18")]
    public double ActualCred18 { get; set; }

    [Column("Actual_Cred19")]
    public double ActualCred19 { get; set; }

    [Column("Actual_Cred20")]
    public double ActualCred20 { get; set; }

    [Column("Actual_Cred21")]
    public double ActualCred21 { get; set; }

    [Column("Actual_Cred22")]
    public double ActualCred22 { get; set; }

    [Column("Actual_Cred23")]
    public double ActualCred23 { get; set; }

    [Column("Actual_Cred24")]
    public double ActualCred24 { get; set; }

    [Column("Actual_Cred25")]
    public double ActualCred25 { get; set; }

    [Column("Actual_Cred26")]
    public double ActualCred26 { get; set; }

    [Column("Actual_Cred27")]
    public double ActualCred27 { get; set; }

    [Column("Actual_Cred28")]
    public double ActualCred28 { get; set; }

    [Column("Actual_Cred29")]
    public double ActualCred29 { get; set; }

    [Column("Actual_Cred30")]
    public double ActualCred30 { get; set; }

    [Column("Actual_Cred31")]
    public double ActualCred31 { get; set; }

    [Column("Actual_Cred32")]
    public double ActualCred32 { get; set; }

    [Column("Actual_Cred33")]
    public double ActualCred33 { get; set; }

    [Column("Actual_Cred34")]
    public double ActualCred34 { get; set; }

    [Column("Actual_Cred35")]
    public double ActualCred35 { get; set; }

    [Column("Actual_Cred36")]
    public double ActualCred36 { get; set; }

    [Column("Actual_Cred37")]
    public double ActualCred37 { get; set; }

    [Column("Actual_Cred38")]
    public double ActualCred38 { get; set; }

    [Column("Actual_Cred39")]
    public double ActualCred39 { get; set; }

    [Column("Actual_Cred40")]
    public double ActualCred40 { get; set; }

    [Column("Actual_Cred41")]
    public double ActualCred41 { get; set; }

    [Column("Actual_Cred42")]
    public double ActualCred42 { get; set; }

    [Column("Actual_Cred43")]
    public double ActualCred43 { get; set; }

    [Column("Actual_Cred44")]
    public double ActualCred44 { get; set; }

    [Column("Actual_Cred45")]
    public double ActualCred45 { get; set; }

    [Column("Actual_Cred46")]
    public double ActualCred46 { get; set; }

    [Column("Actual_Cred47")]
    public double ActualCred47 { get; set; }

    [Column("Actual_Cred48")]
    public double ActualCred48 { get; set; }

    [Column("Actual_Cred49")]
    public double ActualCred49 { get; set; }

    [Column("Actual_Cred50")]
    public double ActualCred50 { get; set; }

    [Column("Actual_Cred51")]
    public double ActualCred51 { get; set; }

    [Column("Actual_Cred52")]
    public double ActualCred52 { get; set; }

    [Column("Actual_Cred53")]
    public double ActualCred53 { get; set; }

    [Column("Actual_Cred54")]
    public double ActualCred54 { get; set; }

    [Column("Actual_Cred55")]
    public double ActualCred55 { get; set; }

    [Column("Actual_Cred56")]
    public double ActualCred56 { get; set; }

    [Column("Actual_Cred57")]
    public double ActualCred57 { get; set; }

    [Column("Actual_Cred58")]
    public double ActualCred58 { get; set; }

    [Column("Actual_Cred59")]
    public double ActualCred59 { get; set; }

    [Column("Actual_Cred60")]
    public double ActualCred60 { get; set; }

    [Column("Actual_ForeignCred00")]
    public int ActualForeignCred00 { get; set; }

    [Column("Actual_ForeignCred01")]
    public double ActualForeignCred01 { get; set; }

    [Column("Actual_ForeignCred02")]
    public double ActualForeignCred02 { get; set; }

    [Column("Actual_ForeignCred03")]
    public double ActualForeignCred03 { get; set; }

    [Column("Actual_ForeignCred04")]
    public double ActualForeignCred04 { get; set; }

    [Column("Actual_ForeignCred05")]
    public double ActualForeignCred05 { get; set; }

    [Column("Actual_ForeignCred06")]
    public double ActualForeignCred06 { get; set; }

    [Column("Actual_ForeignCred07")]
    public double ActualForeignCred07 { get; set; }

    [Column("Actual_ForeignCred08")]
    public double ActualForeignCred08 { get; set; }

    [Column("Actual_ForeignCred09")]
    public double ActualForeignCred09 { get; set; }

    [Column("Actual_ForeignCred10")]
    public double ActualForeignCred10 { get; set; }

    [Column("Actual_ForeignCred11")]
    public double ActualForeignCred11 { get; set; }

    [Column("Actual_ForeignCred12")]
    public double ActualForeignCred12 { get; set; }

    [Column("Actual_ForeignCred13")]
    public double ActualForeignCred13 { get; set; }

    [Column("Actual_ForeignCred14")]
    public double ActualForeignCred14 { get; set; }

    [Column("Actual_ForeignCred15")]
    public double ActualForeignCred15 { get; set; }

    [Column("Actual_ForeignCred16")]
    public double ActualForeignCred16 { get; set; }

    [Column("Actual_ForeignCred17")]
    public double ActualForeignCred17 { get; set; }

    [Column("Actual_ForeignCred18")]
    public double ActualForeignCred18 { get; set; }

    [Column("Actual_ForeignCred19")]
    public double ActualForeignCred19 { get; set; }

    [Column("Actual_ForeignCred20")]
    public double ActualForeignCred20 { get; set; }

    [Column("Actual_ForeignCred21")]
    public double ActualForeignCred21 { get; set; }

    [Column("Actual_ForeignCred22")]
    public double ActualForeignCred22 { get; set; }

    [Column("Actual_ForeignCred23")]
    public double ActualForeignCred23 { get; set; }

    [Column("Actual_ForeignCred24")]
    public double ActualForeignCred24 { get; set; }

    [Column("Actual_ForeignCred25")]
    public double ActualForeignCred25 { get; set; }

    [Column("Actual_ForeignCred26")]
    public double ActualForeignCred26 { get; set; }

    [Column("Actual_ForeignCred27")]
    public double ActualForeignCred27 { get; set; }

    [Column("Actual_ForeignCred28")]
    public double ActualForeignCred28 { get; set; }

    [Column("Actual_ForeignCred29")]
    public double ActualForeignCred29 { get; set; }

    [Column("Actual_ForeignCred30")]
    public double ActualForeignCred30 { get; set; }

    [Column("Actual_ForeignCred31")]
    public double ActualForeignCred31 { get; set; }

    [Column("Actual_ForeignCred32")]
    public double ActualForeignCred32 { get; set; }

    [Column("Actual_ForeignCred33")]
    public double ActualForeignCred33 { get; set; }

    [Column("Actual_ForeignCred34")]
    public double ActualForeignCred34 { get; set; }

    [Column("Actual_ForeignCred35")]
    public double ActualForeignCred35 { get; set; }

    [Column("Actual_ForeignCred36")]
    public double ActualForeignCred36 { get; set; }

    [Column("Actual_ForeignCred37")]
    public double ActualForeignCred37 { get; set; }

    [Column("Actual_ForeignCred38")]
    public double ActualForeignCred38 { get; set; }

    [Column("Actual_ForeignCred39")]
    public double ActualForeignCred39 { get; set; }

    [Column("Actual_ForeignCred40")]
    public double ActualForeignCred40 { get; set; }

    [Column("Actual_ForeignCred41")]
    public double ActualForeignCred41 { get; set; }

    [Column("Actual_ForeignCred42")]
    public double ActualForeignCred42 { get; set; }

    [Column("Actual_ForeignCred43")]
    public double ActualForeignCred43 { get; set; }

    [Column("Actual_ForeignCred44")]
    public double ActualForeignCred44 { get; set; }

    [Column("Actual_ForeignCred45")]
    public double ActualForeignCred45 { get; set; }

    [Column("Actual_ForeignCred46")]
    public double ActualForeignCred46 { get; set; }

    [Column("Actual_ForeignCred47")]
    public double ActualForeignCred47 { get; set; }

    [Column("Actual_ForeignCred48")]
    public double ActualForeignCred48 { get; set; }

    [Column("Actual_ForeignCred49")]
    public double ActualForeignCred49 { get; set; }

    [Column("Actual_ForeignCred50")]
    public double ActualForeignCred50 { get; set; }

    [Column("Actual_ForeignCred51")]
    public double ActualForeignCred51 { get; set; }

    [Column("Actual_ForeignCred52")]
    public double ActualForeignCred52 { get; set; }

    [Column("Actual_ForeignCred53")]
    public double ActualForeignCred53 { get; set; }

    [Column("Actual_ForeignCred54")]
    public double ActualForeignCred54 { get; set; }

    [Column("Actual_ForeignCred55")]
    public double ActualForeignCred55 { get; set; }

    [Column("Actual_ForeignCred56")]
    public double ActualForeignCred56 { get; set; }

    [Column("Actual_ForeignCred57")]
    public double ActualForeignCred57 { get; set; }

    [Column("Actual_ForeignCred58")]
    public double ActualForeignCred58 { get; set; }

    [Column("Actual_ForeignCred59")]
    public double ActualForeignCred59 { get; set; }

    [Column("Actual_ForeignCred60")]
    public double ActualForeignCred60 { get; set; }

    [Column("iTxBranchPrevID")]
    public int? ITxBranchPrevId { get; set; }

    [Column("BFDebits00")]
    public double? Bfdebits00 { get; set; }

    [Column("BFDebits01")]
    public double? Bfdebits01 { get; set; }

    [Column("BFDebits02")]
    public double? Bfdebits02 { get; set; }

    [Column("BFDebits03")]
    public double? Bfdebits03 { get; set; }

    [Column("BFDebits04")]
    public double? Bfdebits04 { get; set; }

    [Column("BFDebits05")]
    public double? Bfdebits05 { get; set; }

    [Column("BFForeignDebits00")]
    public double? BfforeignDebits00 { get; set; }

    [Column("BFForeignDebits01")]
    public double? BfforeignDebits01 { get; set; }

    [Column("BFForeignDebits02")]
    public double? BfforeignDebits02 { get; set; }

    [Column("BFForeignDebits03")]
    public double? BfforeignDebits03 { get; set; }

    [Column("BFForeignDebits04")]
    public double? BfforeignDebits04 { get; set; }

    [Column("BFForeignDebits05")]
    public double? BfforeignDebits05 { get; set; }

    [Column("BFCredits00")]
    public double? Bfcredits00 { get; set; }

    [Column("BFCredits01")]
    public double? Bfcredits01 { get; set; }

    [Column("BFCredits02")]
    public double? Bfcredits02 { get; set; }

    [Column("BFCredits03")]
    public double? Bfcredits03 { get; set; }

    [Column("BFCredits04")]
    public double? Bfcredits04 { get; set; }

    [Column("BFCredits05")]
    public double? Bfcredits05 { get; set; }

    [Column("BFForeignCredits00")]
    public double? BfforeignCredits00 { get; set; }

    [Column("BFForeignCredits01")]
    public double? BfforeignCredits01 { get; set; }

    [Column("BFForeignCredits02")]
    public double? BfforeignCredits02 { get; set; }

    [Column("BFForeignCredits03")]
    public double? BfforeignCredits03 { get; set; }

    [Column("BFForeignCredits04")]
    public double? BfforeignCredits04 { get; set; }

    [Column("BFForeignCredits05")]
    public double? BfforeignCredits05 { get; set; }

    [Column("prevBal01")]
    public double? PrevBal01 { get; set; }

    [Column("prevBal02")]
    public double? PrevBal02 { get; set; }

    [Column("prevBal03")]
    public double? PrevBal03 { get; set; }

    [Column("prevBal04")]
    public double? PrevBal04 { get; set; }

    [Column("prevBal05")]
    public double? PrevBal05 { get; set; }

    [Column("iTXBranchBudgetID")]
    public int? ITxbranchBudgetId { get; set; }

    public double? Budget01 { get; set; }

    public double? Budget02 { get; set; }

    public double? Budget03 { get; set; }

    public double? Budget04 { get; set; }

    public double? Budget05 { get; set; }

    public double? Budget06 { get; set; }

    public double? Budget07 { get; set; }

    public double? Budget08 { get; set; }

    public double? Budget09 { get; set; }

    public double? Budget10 { get; set; }

    public double? Budget11 { get; set; }

    public double? Budget12 { get; set; }

    public double? Budget13 { get; set; }

    public double? Budget14 { get; set; }

    public double? Budget15 { get; set; }

    public double? Budget16 { get; set; }

    public double? Budget17 { get; set; }

    public double? Budget18 { get; set; }

    public double? Budget19 { get; set; }

    public double? Budget20 { get; set; }

    public double? Budget21 { get; set; }

    public double? Budget22 { get; set; }

    public double? Budget23 { get; set; }

    public double? Budget24 { get; set; }

    public double? Budget25 { get; set; }

    public double? Budget26 { get; set; }

    public double? Budget27 { get; set; }

    public double? Budget28 { get; set; }

    public double? Budget29 { get; set; }

    public double? Budget30 { get; set; }

    public double? Budget31 { get; set; }

    public double? Budget32 { get; set; }

    public double? Budget33 { get; set; }

    public double? Budget34 { get; set; }

    public double? Budget35 { get; set; }

    public double? Budget36 { get; set; }

    public double? Budget37 { get; set; }

    public double? Budget38 { get; set; }

    public double? Budget39 { get; set; }

    public double? Budget40 { get; set; }

    public double? Budget41 { get; set; }

    public double? Budget42 { get; set; }

    public double? Budget43 { get; set; }

    public double? Budget44 { get; set; }

    public double? Budget45 { get; set; }

    public double? Budget46 { get; set; }

    public double? Budget47 { get; set; }

    public double? Budget48 { get; set; }

    public double? Budget49 { get; set; }

    public double? Budget50 { get; set; }

    public double? Budget51 { get; set; }

    public double? Budget52 { get; set; }

    public double? Budget53 { get; set; }

    public double? Budget54 { get; set; }

    public double? Budget55 { get; set; }

    public double? Budget56 { get; set; }

    public double? Budget57 { get; set; }

    public double? Budget58 { get; set; }

    public double? Budget59 { get; set; }

    public double? Budget60 { get; set; }
}
