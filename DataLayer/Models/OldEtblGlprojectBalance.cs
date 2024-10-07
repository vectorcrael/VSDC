using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IGlaccountId", "IProjectId", "ITxBranchProjectId")]
[Table("_old_etblGLProjectBalances")]
[Index("OldEtblGlprojectBalancesChecksum", Name = "idx__etblGLProjectBalances__etblGLProjectBalances_Checksum")]
[Index("OldEtblGlprojectBalancesIChangeSetId", Name = "idx__etblGLProjectBalances_iChangeSetID")]
[Index("OldEtblGlprojectBalancesDModifiedDate", Name = "idx_etblGLProjectBalances_dModifiedDate")]
[Index("OldEtblGlprojectBalancesIBranchId", Name = "idx_etblGLProjectBalances_iBranchID")]
public partial class OldEtblGlprojectBalance
{
    [Key]
    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Key]
    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("cAccountType")]
    [StringLength(50)]
    [Unicode(false)]
    public string CAccountType { get; set; } = null!;

    [Column("fActualDebit00")]
    public double? FActualDebit00 { get; set; }

    [Column("fActualDebit01")]
    public double? FActualDebit01 { get; set; }

    [Column("fActualDebit02")]
    public double? FActualDebit02 { get; set; }

    [Column("fActualDebit03")]
    public double? FActualDebit03 { get; set; }

    [Column("fActualDebit04")]
    public double? FActualDebit04 { get; set; }

    [Column("fActualDebit05")]
    public double? FActualDebit05 { get; set; }

    [Column("fActualDebit06")]
    public double? FActualDebit06 { get; set; }

    [Column("fActualDebit07")]
    public double? FActualDebit07 { get; set; }

    [Column("fActualDebit08")]
    public double? FActualDebit08 { get; set; }

    [Column("fActualDebit09")]
    public double? FActualDebit09 { get; set; }

    [Column("fActualDebit10")]
    public double? FActualDebit10 { get; set; }

    [Column("fActualDebit11")]
    public double? FActualDebit11 { get; set; }

    [Column("fActualDebit12")]
    public double? FActualDebit12 { get; set; }

    [Column("fActualDebit13")]
    public double? FActualDebit13 { get; set; }

    [Column("fActualDebit14")]
    public double? FActualDebit14 { get; set; }

    [Column("fActualDebit15")]
    public double? FActualDebit15 { get; set; }

    [Column("fActualDebit16")]
    public double? FActualDebit16 { get; set; }

    [Column("fActualDebit17")]
    public double? FActualDebit17 { get; set; }

    [Column("fActualDebit18")]
    public double? FActualDebit18 { get; set; }

    [Column("fActualDebit19")]
    public double? FActualDebit19 { get; set; }

    [Column("fActualDebit20")]
    public double? FActualDebit20 { get; set; }

    [Column("fActualDebit21")]
    public double? FActualDebit21 { get; set; }

    [Column("fActualDebit22")]
    public double? FActualDebit22 { get; set; }

    [Column("fActualDebit23")]
    public double? FActualDebit23 { get; set; }

    [Column("fActualDebit24")]
    public double? FActualDebit24 { get; set; }

    [Column("fActualDebit25")]
    public double? FActualDebit25 { get; set; }

    [Column("fActualDebit26")]
    public double? FActualDebit26 { get; set; }

    [Column("fActualDebit27")]
    public double? FActualDebit27 { get; set; }

    [Column("fActualDebit28")]
    public double? FActualDebit28 { get; set; }

    [Column("fActualDebit29")]
    public double? FActualDebit29 { get; set; }

    [Column("fActualDebit30")]
    public double? FActualDebit30 { get; set; }

    [Column("fActualDebit31")]
    public double? FActualDebit31 { get; set; }

    [Column("fActualDebit32")]
    public double? FActualDebit32 { get; set; }

    [Column("fActualDebit33")]
    public double? FActualDebit33 { get; set; }

    [Column("fActualDebit34")]
    public double? FActualDebit34 { get; set; }

    [Column("fActualDebit35")]
    public double? FActualDebit35 { get; set; }

    [Column("fActualDebit36")]
    public double? FActualDebit36 { get; set; }

    [Column("fActualDebit37")]
    public double? FActualDebit37 { get; set; }

    [Column("fActualDebit38")]
    public double? FActualDebit38 { get; set; }

    [Column("fActualDebit39")]
    public double? FActualDebit39 { get; set; }

    [Column("fActualDebit40")]
    public double? FActualDebit40 { get; set; }

    [Column("fActualDebit41")]
    public double? FActualDebit41 { get; set; }

    [Column("fActualDebit42")]
    public double? FActualDebit42 { get; set; }

    [Column("fActualDebit43")]
    public double? FActualDebit43 { get; set; }

    [Column("fActualDebit44")]
    public double? FActualDebit44 { get; set; }

    [Column("fActualDebit45")]
    public double? FActualDebit45 { get; set; }

    [Column("fActualDebit46")]
    public double? FActualDebit46 { get; set; }

    [Column("fActualDebit47")]
    public double? FActualDebit47 { get; set; }

    [Column("fActualDebit48")]
    public double? FActualDebit48 { get; set; }

    [Column("fActualDebit49")]
    public double? FActualDebit49 { get; set; }

    [Column("fActualDebit50")]
    public double? FActualDebit50 { get; set; }

    [Column("fActualDebit51")]
    public double? FActualDebit51 { get; set; }

    [Column("fActualDebit52")]
    public double? FActualDebit52 { get; set; }

    [Column("fActualDebit53")]
    public double? FActualDebit53 { get; set; }

    [Column("fActualDebit54")]
    public double? FActualDebit54 { get; set; }

    [Column("fActualDebit55")]
    public double? FActualDebit55 { get; set; }

    [Column("fActualDebit56")]
    public double? FActualDebit56 { get; set; }

    [Column("fActualDebit57")]
    public double? FActualDebit57 { get; set; }

    [Column("fActualDebit58")]
    public double? FActualDebit58 { get; set; }

    [Column("fActualDebit59")]
    public double? FActualDebit59 { get; set; }

    [Column("fActualDebit60")]
    public double? FActualDebit60 { get; set; }

    [Column("fActualCredit00")]
    public double? FActualCredit00 { get; set; }

    [Column("fActualCredit01")]
    public double? FActualCredit01 { get; set; }

    [Column("fActualCredit02")]
    public double? FActualCredit02 { get; set; }

    [Column("fActualCredit03")]
    public double? FActualCredit03 { get; set; }

    [Column("fActualCredit04")]
    public double? FActualCredit04 { get; set; }

    [Column("fActualCredit05")]
    public double? FActualCredit05 { get; set; }

    [Column("fActualCredit06")]
    public double? FActualCredit06 { get; set; }

    [Column("fActualCredit07")]
    public double? FActualCredit07 { get; set; }

    [Column("fActualCredit08")]
    public double? FActualCredit08 { get; set; }

    [Column("fActualCredit09")]
    public double? FActualCredit09 { get; set; }

    [Column("fActualCredit10")]
    public double? FActualCredit10 { get; set; }

    [Column("fActualCredit11")]
    public double? FActualCredit11 { get; set; }

    [Column("fActualCredit12")]
    public double? FActualCredit12 { get; set; }

    [Column("fActualCredit13")]
    public double? FActualCredit13 { get; set; }

    [Column("fActualCredit14")]
    public double? FActualCredit14 { get; set; }

    [Column("fActualCredit15")]
    public double? FActualCredit15 { get; set; }

    [Column("fActualCredit16")]
    public double? FActualCredit16 { get; set; }

    [Column("fActualCredit17")]
    public double? FActualCredit17 { get; set; }

    [Column("fActualCredit18")]
    public double? FActualCredit18 { get; set; }

    [Column("fActualCredit19")]
    public double? FActualCredit19 { get; set; }

    [Column("fActualCredit20")]
    public double? FActualCredit20 { get; set; }

    [Column("fActualCredit21")]
    public double? FActualCredit21 { get; set; }

    [Column("fActualCredit22")]
    public double? FActualCredit22 { get; set; }

    [Column("fActualCredit23")]
    public double? FActualCredit23 { get; set; }

    [Column("fActualCredit24")]
    public double? FActualCredit24 { get; set; }

    [Column("fActualCredit25")]
    public double? FActualCredit25 { get; set; }

    [Column("fActualCredit26")]
    public double? FActualCredit26 { get; set; }

    [Column("fActualCredit27")]
    public double? FActualCredit27 { get; set; }

    [Column("fActualCredit28")]
    public double? FActualCredit28 { get; set; }

    [Column("fActualCredit29")]
    public double? FActualCredit29 { get; set; }

    [Column("fActualCredit30")]
    public double? FActualCredit30 { get; set; }

    [Column("fActualCredit31")]
    public double? FActualCredit31 { get; set; }

    [Column("fActualCredit32")]
    public double? FActualCredit32 { get; set; }

    [Column("fActualCredit33")]
    public double? FActualCredit33 { get; set; }

    [Column("fActualCredit34")]
    public double? FActualCredit34 { get; set; }

    [Column("fActualCredit35")]
    public double? FActualCredit35 { get; set; }

    [Column("fActualCredit36")]
    public double? FActualCredit36 { get; set; }

    [Column("fActualCredit37")]
    public double? FActualCredit37 { get; set; }

    [Column("fActualCredit38")]
    public double? FActualCredit38 { get; set; }

    [Column("fActualCredit39")]
    public double? FActualCredit39 { get; set; }

    [Column("fActualCredit40")]
    public double? FActualCredit40 { get; set; }

    [Column("fActualCredit41")]
    public double? FActualCredit41 { get; set; }

    [Column("fActualCredit42")]
    public double? FActualCredit42 { get; set; }

    [Column("fActualCredit43")]
    public double? FActualCredit43 { get; set; }

    [Column("fActualCredit44")]
    public double? FActualCredit44 { get; set; }

    [Column("fActualCredit45")]
    public double? FActualCredit45 { get; set; }

    [Column("fActualCredit46")]
    public double? FActualCredit46 { get; set; }

    [Column("fActualCredit47")]
    public double? FActualCredit47 { get; set; }

    [Column("fActualCredit48")]
    public double? FActualCredit48 { get; set; }

    [Column("fActualCredit49")]
    public double? FActualCredit49 { get; set; }

    [Column("fActualCredit50")]
    public double? FActualCredit50 { get; set; }

    [Column("fActualCredit51")]
    public double? FActualCredit51 { get; set; }

    [Column("fActualCredit52")]
    public double? FActualCredit52 { get; set; }

    [Column("fActualCredit53")]
    public double? FActualCredit53 { get; set; }

    [Column("fActualCredit54")]
    public double? FActualCredit54 { get; set; }

    [Column("fActualCredit55")]
    public double? FActualCredit55 { get; set; }

    [Column("fActualCredit56")]
    public double? FActualCredit56 { get; set; }

    [Column("fActualCredit57")]
    public double? FActualCredit57 { get; set; }

    [Column("fActualCredit58")]
    public double? FActualCredit58 { get; set; }

    [Column("fActualCredit59")]
    public double? FActualCredit59 { get; set; }

    [Column("fActualCredit60")]
    public double? FActualCredit60 { get; set; }

    [Column("fActualForeignDebit00")]
    public double? FActualForeignDebit00 { get; set; }

    [Column("fActualForeignDebit01")]
    public double? FActualForeignDebit01 { get; set; }

    [Column("fActualForeignDebit02")]
    public double? FActualForeignDebit02 { get; set; }

    [Column("fActualForeignDebit03")]
    public double? FActualForeignDebit03 { get; set; }

    [Column("fActualForeignDebit04")]
    public double? FActualForeignDebit04 { get; set; }

    [Column("fActualForeignDebit05")]
    public double? FActualForeignDebit05 { get; set; }

    [Column("fActualForeignDebit06")]
    public double? FActualForeignDebit06 { get; set; }

    [Column("fActualForeignDebit07")]
    public double? FActualForeignDebit07 { get; set; }

    [Column("fActualForeignDebit08")]
    public double? FActualForeignDebit08 { get; set; }

    [Column("fActualForeignDebit09")]
    public double? FActualForeignDebit09 { get; set; }

    [Column("fActualForeignDebit10")]
    public double? FActualForeignDebit10 { get; set; }

    [Column("fActualForeignDebit11")]
    public double? FActualForeignDebit11 { get; set; }

    [Column("fActualForeignDebit12")]
    public double? FActualForeignDebit12 { get; set; }

    [Column("fActualForeignDebit13")]
    public double? FActualForeignDebit13 { get; set; }

    [Column("fActualForeignDebit14")]
    public double? FActualForeignDebit14 { get; set; }

    [Column("fActualForeignDebit15")]
    public double? FActualForeignDebit15 { get; set; }

    [Column("fActualForeignDebit16")]
    public double? FActualForeignDebit16 { get; set; }

    [Column("fActualForeignDebit17")]
    public double? FActualForeignDebit17 { get; set; }

    [Column("fActualForeignDebit18")]
    public double? FActualForeignDebit18 { get; set; }

    [Column("fActualForeignDebit19")]
    public double? FActualForeignDebit19 { get; set; }

    [Column("fActualForeignDebit20")]
    public double? FActualForeignDebit20 { get; set; }

    [Column("fActualForeignDebit21")]
    public double? FActualForeignDebit21 { get; set; }

    [Column("fActualForeignDebit22")]
    public double? FActualForeignDebit22 { get; set; }

    [Column("fActualForeignDebit23")]
    public double? FActualForeignDebit23 { get; set; }

    [Column("fActualForeignDebit24")]
    public double? FActualForeignDebit24 { get; set; }

    [Column("fActualForeignDebit25")]
    public double? FActualForeignDebit25 { get; set; }

    [Column("fActualForeignDebit26")]
    public double? FActualForeignDebit26 { get; set; }

    [Column("fActualForeignDebit27")]
    public double? FActualForeignDebit27 { get; set; }

    [Column("fActualForeignDebit28")]
    public double? FActualForeignDebit28 { get; set; }

    [Column("fActualForeignDebit29")]
    public double? FActualForeignDebit29 { get; set; }

    [Column("fActualForeignDebit30")]
    public double? FActualForeignDebit30 { get; set; }

    [Column("fActualForeignDebit31")]
    public double? FActualForeignDebit31 { get; set; }

    [Column("fActualForeignDebit32")]
    public double? FActualForeignDebit32 { get; set; }

    [Column("fActualForeignDebit33")]
    public double? FActualForeignDebit33 { get; set; }

    [Column("fActualForeignDebit34")]
    public double? FActualForeignDebit34 { get; set; }

    [Column("fActualForeignDebit35")]
    public double? FActualForeignDebit35 { get; set; }

    [Column("fActualForeignDebit36")]
    public double? FActualForeignDebit36 { get; set; }

    [Column("fActualForeignDebit37")]
    public double? FActualForeignDebit37 { get; set; }

    [Column("fActualForeignDebit38")]
    public double? FActualForeignDebit38 { get; set; }

    [Column("fActualForeignDebit39")]
    public double? FActualForeignDebit39 { get; set; }

    [Column("fActualForeignDebit40")]
    public double? FActualForeignDebit40 { get; set; }

    [Column("fActualForeignDebit41")]
    public double? FActualForeignDebit41 { get; set; }

    [Column("fActualForeignDebit42")]
    public double? FActualForeignDebit42 { get; set; }

    [Column("fActualForeignDebit43")]
    public double? FActualForeignDebit43 { get; set; }

    [Column("fActualForeignDebit44")]
    public double? FActualForeignDebit44 { get; set; }

    [Column("fActualForeignDebit45")]
    public double? FActualForeignDebit45 { get; set; }

    [Column("fActualForeignDebit46")]
    public double? FActualForeignDebit46 { get; set; }

    [Column("fActualForeignDebit47")]
    public double? FActualForeignDebit47 { get; set; }

    [Column("fActualForeignDebit48")]
    public double? FActualForeignDebit48 { get; set; }

    [Column("fActualForeignDebit49")]
    public double? FActualForeignDebit49 { get; set; }

    [Column("fActualForeignDebit50")]
    public double? FActualForeignDebit50 { get; set; }

    [Column("fActualForeignDebit51")]
    public double? FActualForeignDebit51 { get; set; }

    [Column("fActualForeignDebit52")]
    public double? FActualForeignDebit52 { get; set; }

    [Column("fActualForeignDebit53")]
    public double? FActualForeignDebit53 { get; set; }

    [Column("fActualForeignDebit54")]
    public double? FActualForeignDebit54 { get; set; }

    [Column("fActualForeignDebit55")]
    public double? FActualForeignDebit55 { get; set; }

    [Column("fActualForeignDebit56")]
    public double? FActualForeignDebit56 { get; set; }

    [Column("fActualForeignDebit57")]
    public double? FActualForeignDebit57 { get; set; }

    [Column("fActualForeignDebit58")]
    public double? FActualForeignDebit58 { get; set; }

    [Column("fActualForeignDebit59")]
    public double? FActualForeignDebit59 { get; set; }

    [Column("fActualForeignDebit60")]
    public double? FActualForeignDebit60 { get; set; }

    [Column("fActualForeignCredit00")]
    public double? FActualForeignCredit00 { get; set; }

    [Column("fActualForeignCredit01")]
    public double? FActualForeignCredit01 { get; set; }

    [Column("fActualForeignCredit02")]
    public double? FActualForeignCredit02 { get; set; }

    [Column("fActualForeignCredit03")]
    public double? FActualForeignCredit03 { get; set; }

    [Column("fActualForeignCredit04")]
    public double? FActualForeignCredit04 { get; set; }

    [Column("fActualForeignCredit05")]
    public double? FActualForeignCredit05 { get; set; }

    [Column("fActualForeignCredit06")]
    public double? FActualForeignCredit06 { get; set; }

    [Column("fActualForeignCredit07")]
    public double? FActualForeignCredit07 { get; set; }

    [Column("fActualForeignCredit08")]
    public double? FActualForeignCredit08 { get; set; }

    [Column("fActualForeignCredit09")]
    public double? FActualForeignCredit09 { get; set; }

    [Column("fActualForeignCredit10")]
    public double? FActualForeignCredit10 { get; set; }

    [Column("fActualForeignCredit11")]
    public double? FActualForeignCredit11 { get; set; }

    [Column("fActualForeignCredit12")]
    public double? FActualForeignCredit12 { get; set; }

    [Column("fActualForeignCredit13")]
    public double? FActualForeignCredit13 { get; set; }

    [Column("fActualForeignCredit14")]
    public double? FActualForeignCredit14 { get; set; }

    [Column("fActualForeignCredit15")]
    public double? FActualForeignCredit15 { get; set; }

    [Column("fActualForeignCredit16")]
    public double? FActualForeignCredit16 { get; set; }

    [Column("fActualForeignCredit17")]
    public double? FActualForeignCredit17 { get; set; }

    [Column("fActualForeignCredit18")]
    public double? FActualForeignCredit18 { get; set; }

    [Column("fActualForeignCredit19")]
    public double? FActualForeignCredit19 { get; set; }

    [Column("fActualForeignCredit20")]
    public double? FActualForeignCredit20 { get; set; }

    [Column("fActualForeignCredit21")]
    public double? FActualForeignCredit21 { get; set; }

    [Column("fActualForeignCredit22")]
    public double? FActualForeignCredit22 { get; set; }

    [Column("fActualForeignCredit23")]
    public double? FActualForeignCredit23 { get; set; }

    [Column("fActualForeignCredit24")]
    public double? FActualForeignCredit24 { get; set; }

    [Column("fActualForeignCredit25")]
    public double? FActualForeignCredit25 { get; set; }

    [Column("fActualForeignCredit26")]
    public double? FActualForeignCredit26 { get; set; }

    [Column("fActualForeignCredit27")]
    public double? FActualForeignCredit27 { get; set; }

    [Column("fActualForeignCredit28")]
    public double? FActualForeignCredit28 { get; set; }

    [Column("fActualForeignCredit29")]
    public double? FActualForeignCredit29 { get; set; }

    [Column("fActualForeignCredit30")]
    public double? FActualForeignCredit30 { get; set; }

    [Column("fActualForeignCredit31")]
    public double? FActualForeignCredit31 { get; set; }

    [Column("fActualForeignCredit32")]
    public double? FActualForeignCredit32 { get; set; }

    [Column("fActualForeignCredit33")]
    public double? FActualForeignCredit33 { get; set; }

    [Column("fActualForeignCredit34")]
    public double? FActualForeignCredit34 { get; set; }

    [Column("fActualForeignCredit35")]
    public double? FActualForeignCredit35 { get; set; }

    [Column("fActualForeignCredit36")]
    public double? FActualForeignCredit36 { get; set; }

    [Column("fActualForeignCredit37")]
    public double? FActualForeignCredit37 { get; set; }

    [Column("fActualForeignCredit38")]
    public double? FActualForeignCredit38 { get; set; }

    [Column("fActualForeignCredit39")]
    public double? FActualForeignCredit39 { get; set; }

    [Column("fActualForeignCredit40")]
    public double? FActualForeignCredit40 { get; set; }

    [Column("fActualForeignCredit41")]
    public double? FActualForeignCredit41 { get; set; }

    [Column("fActualForeignCredit42")]
    public double? FActualForeignCredit42 { get; set; }

    [Column("fActualForeignCredit43")]
    public double? FActualForeignCredit43 { get; set; }

    [Column("fActualForeignCredit44")]
    public double? FActualForeignCredit44 { get; set; }

    [Column("fActualForeignCredit45")]
    public double? FActualForeignCredit45 { get; set; }

    [Column("fActualForeignCredit46")]
    public double? FActualForeignCredit46 { get; set; }

    [Column("fActualForeignCredit47")]
    public double? FActualForeignCredit47 { get; set; }

    [Column("fActualForeignCredit48")]
    public double? FActualForeignCredit48 { get; set; }

    [Column("fActualForeignCredit49")]
    public double? FActualForeignCredit49 { get; set; }

    [Column("fActualForeignCredit50")]
    public double? FActualForeignCredit50 { get; set; }

    [Column("fActualForeignCredit51")]
    public double? FActualForeignCredit51 { get; set; }

    [Column("fActualForeignCredit52")]
    public double? FActualForeignCredit52 { get; set; }

    [Column("fActualForeignCredit53")]
    public double? FActualForeignCredit53 { get; set; }

    [Column("fActualForeignCredit54")]
    public double? FActualForeignCredit54 { get; set; }

    [Column("fActualForeignCredit55")]
    public double? FActualForeignCredit55 { get; set; }

    [Column("fActualForeignCredit56")]
    public double? FActualForeignCredit56 { get; set; }

    [Column("fActualForeignCredit57")]
    public double? FActualForeignCredit57 { get; set; }

    [Column("fActualForeignCredit58")]
    public double? FActualForeignCredit58 { get; set; }

    [Column("fActualForeignCredit59")]
    public double? FActualForeignCredit59 { get; set; }

    [Column("fActualForeignCredit60")]
    public double? FActualForeignCredit60 { get; set; }

    [Column("_old_etblGLProjectBalances_iBranchID")]
    public int? OldEtblGlprojectBalancesIBranchId { get; set; }

    [Column("_old_etblGLProjectBalances_dCreatedDate", TypeName = "datetime")]
    public DateTime? OldEtblGlprojectBalancesDCreatedDate { get; set; }

    [Column("_old_etblGLProjectBalances_dModifiedDate", TypeName = "datetime")]
    public DateTime? OldEtblGlprojectBalancesDModifiedDate { get; set; }

    [Column("_old_etblGLProjectBalances_iCreatedBranchID")]
    public int? OldEtblGlprojectBalancesICreatedBranchId { get; set; }

    [Column("_old_etblGLProjectBalances_iModifiedBranchID")]
    public int? OldEtblGlprojectBalancesIModifiedBranchId { get; set; }

    [Column("_old_etblGLProjectBalances_iCreatedAgentID")]
    public int? OldEtblGlprojectBalancesICreatedAgentId { get; set; }

    [Column("_old_etblGLProjectBalances_iModifiedAgentID")]
    public int? OldEtblGlprojectBalancesIModifiedAgentId { get; set; }

    [Column("_old_etblGLProjectBalances_iChangeSetID")]
    public int? OldEtblGlprojectBalancesIChangeSetId { get; set; }

    [Key]
    [Column("iTxBranchProjectID")]
    public int ITxBranchProjectId { get; set; }

    [Column("_old_etblGLProjectBalances_Checksum")]
    [MaxLength(20)]
    public byte[]? OldEtblGlprojectBalancesChecksum { get; set; }
}
