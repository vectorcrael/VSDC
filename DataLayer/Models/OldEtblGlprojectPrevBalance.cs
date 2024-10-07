using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IGlaccountId", "IProjectId", "ITxBranchProjectPrevId")]
[Table("_old_etblGLProjectPrevBalances")]
[Index("OldEtblGlprojectPrevBalancesChecksum", Name = "idx__etblGLProjectPrevBalances__etblGLProjectPrevBalances_Checksum")]
[Index("OldEtblGlprojectPrevBalancesIChangeSetId", Name = "idx__etblGLProjectPrevBalances_iChangeSetID")]
[Index("OldEtblGlprojectPrevBalancesDModifiedDate", Name = "idx_etblGLProjectPrevBalances_dModifiedDate")]
[Index("OldEtblGlprojectPrevBalancesIBranchId", Name = "idx_etblGLProjectPrevBalances_iBranchID")]
public partial class OldEtblGlprojectPrevBalance
{
    [Key]
    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Key]
    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("fBFDebits00")]
    public double? FBfdebits00 { get; set; }

    [Column("fBFDebits01")]
    public double? FBfdebits01 { get; set; }

    [Column("fBFDebits02")]
    public double? FBfdebits02 { get; set; }

    [Column("fBFDebits03")]
    public double? FBfdebits03 { get; set; }

    [Column("fBFDebits04")]
    public double? FBfdebits04 { get; set; }

    [Column("fBFDebits05")]
    public double? FBfdebits05 { get; set; }

    [Column("fBFCredits00")]
    public double? FBfcredits00 { get; set; }

    [Column("fBFCredits01")]
    public double? FBfcredits01 { get; set; }

    [Column("fBFCredits02")]
    public double? FBfcredits02 { get; set; }

    [Column("fBFCredits03")]
    public double? FBfcredits03 { get; set; }

    [Column("fBFCredits04")]
    public double? FBfcredits04 { get; set; }

    [Column("fBFCredits05")]
    public double? FBfcredits05 { get; set; }

    [Column("fPrevBalance01")]
    public double? FPrevBalance01 { get; set; }

    [Column("fPrevBalance02")]
    public double? FPrevBalance02 { get; set; }

    [Column("fPrevBalance03")]
    public double? FPrevBalance03 { get; set; }

    [Column("fPrevBalance04")]
    public double? FPrevBalance04 { get; set; }

    [Column("fPrevBalance05")]
    public double? FPrevBalance05 { get; set; }

    [Column("fPrevBalance06")]
    public double? FPrevBalance06 { get; set; }

    [Column("fPrevBalance07")]
    public double? FPrevBalance07 { get; set; }

    [Column("fPrevBalance08")]
    public double? FPrevBalance08 { get; set; }

    [Column("fPrevBalance09")]
    public double? FPrevBalance09 { get; set; }

    [Column("fPrevBalance10")]
    public double? FPrevBalance10 { get; set; }

    [Column("fPrevBalance11")]
    public double? FPrevBalance11 { get; set; }

    [Column("fPrevBalance12")]
    public double? FPrevBalance12 { get; set; }

    [Column("fBFForeignDebits00")]
    public double? FBfforeignDebits00 { get; set; }

    [Column("fBFForeignDebits01")]
    public double? FBfforeignDebits01 { get; set; }

    [Column("fBFForeignDebits02")]
    public double? FBfforeignDebits02 { get; set; }

    [Column("fBFForeignDebits03")]
    public double? FBfforeignDebits03 { get; set; }

    [Column("fBFForeignDebits04")]
    public double? FBfforeignDebits04 { get; set; }

    [Column("fBFForeignDebits05")]
    public double? FBfforeignDebits05 { get; set; }

    [Column("fBFForeignCredits00")]
    public double? FBfforeignCredits00 { get; set; }

    [Column("fBFForeignCredits01")]
    public double? FBfforeignCredits01 { get; set; }

    [Column("fBFForeignCredits02")]
    public double? FBfforeignCredits02 { get; set; }

    [Column("fBFForeignCredits03")]
    public double? FBfforeignCredits03 { get; set; }

    [Column("fBFForeignCredits04")]
    public double? FBfforeignCredits04 { get; set; }

    [Column("fBFForeignCredits05")]
    public double? FBfforeignCredits05 { get; set; }

    [Column("fPrevForeignBalance01")]
    public double? FPrevForeignBalance01 { get; set; }

    [Column("fPrevForeignBalance02")]
    public double? FPrevForeignBalance02 { get; set; }

    [Column("fPrevForeignBalance03")]
    public double? FPrevForeignBalance03 { get; set; }

    [Column("fPrevForeignBalance04")]
    public double? FPrevForeignBalance04 { get; set; }

    [Column("fPrevForeignBalance05")]
    public double? FPrevForeignBalance05 { get; set; }

    [Column("fPrevForeignBalance06")]
    public double? FPrevForeignBalance06 { get; set; }

    [Column("fPrevForeignBalance07")]
    public double? FPrevForeignBalance07 { get; set; }

    [Column("fPrevForeignBalance08")]
    public double? FPrevForeignBalance08 { get; set; }

    [Column("fPrevForeignBalance09")]
    public double? FPrevForeignBalance09 { get; set; }

    [Column("fPrevForeignBalance10")]
    public double? FPrevForeignBalance10 { get; set; }

    [Column("fPrevForeignBalance11")]
    public double? FPrevForeignBalance11 { get; set; }

    [Column("fPrevForeignBalance12")]
    public double? FPrevForeignBalance12 { get; set; }

    [Column("_old_etblGLProjectPrevBalances_iBranchID")]
    public int? OldEtblGlprojectPrevBalancesIBranchId { get; set; }

    [Column("_old_etblGLProjectPrevBalances_dCreatedDate", TypeName = "datetime")]
    public DateTime? OldEtblGlprojectPrevBalancesDCreatedDate { get; set; }

    [Column("_old_etblGLProjectPrevBalances_dModifiedDate", TypeName = "datetime")]
    public DateTime? OldEtblGlprojectPrevBalancesDModifiedDate { get; set; }

    [Column("_old_etblGLProjectPrevBalances_iCreatedBranchID")]
    public int? OldEtblGlprojectPrevBalancesICreatedBranchId { get; set; }

    [Column("_old_etblGLProjectPrevBalances_iModifiedBranchID")]
    public int? OldEtblGlprojectPrevBalancesIModifiedBranchId { get; set; }

    [Column("_old_etblGLProjectPrevBalances_iCreatedAgentID")]
    public int? OldEtblGlprojectPrevBalancesICreatedAgentId { get; set; }

    [Column("_old_etblGLProjectPrevBalances_iModifiedAgentID")]
    public int? OldEtblGlprojectPrevBalancesIModifiedAgentId { get; set; }

    [Column("_old_etblGLProjectPrevBalances_iChangeSetID")]
    public int? OldEtblGlprojectPrevBalancesIChangeSetId { get; set; }

    [Key]
    [Column("iTxBranchProjectPrevID")]
    public int ITxBranchProjectPrevId { get; set; }

    [Column("_old_etblGLProjectPrevBalances_Checksum")]
    [MaxLength(20)]
    public byte[]? OldEtblGlprojectPrevBalancesChecksum { get; set; }
}
