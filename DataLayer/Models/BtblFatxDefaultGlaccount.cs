using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFATxDefaultGLAccounts")]
[Index("BtblFatxDefaultGlaccountsChecksum", Name = "idx__btblFATxDefaultGLAccounts__btblFATxDefaultGLAccounts_Checksum")]
[Index("BtblFatxDefaultGlaccountsIChangeSetId", Name = "idx__btblFATxDefaultGLAccounts_iChangeSetID")]
[Index("BtblFatxDefaultGlaccountsDModifiedDate", Name = "idx_btblFATxDefaultGLAccounts_dModifiedDate")]
[Index("BtblFatxDefaultGlaccountsIBranchId", Name = "idx_btblFATxDefaultGLAccounts_iBranchID")]
public partial class BtblFatxDefaultGlaccount
{
    [Key]
    [Column("idTXDefaultGLAccount")]
    public int IdTxdefaultGlaccount { get; set; }

    [Column("cTransactionType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CTransactionType { get; set; }

    [Column("iDebitGLAccountID")]
    public int? IDebitGlaccountId { get; set; }

    [Column("iProfitGLAccountID")]
    public int? IProfitGlaccountId { get; set; }

    [Column("iLossGLAccountID")]
    public int? ILossGlaccountId { get; set; }

    [Column("iRevaluationGLAccountID")]
    public int? IRevaluationGlaccountId { get; set; }

    [Column("iCreditGLAccountID")]
    public int? ICreditGlaccountId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_iBranchID")]
    public int? BtblFatxDefaultGlaccountsIBranchId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFatxDefaultGlaccountsDCreatedDate { get; set; }

    [Column("_btblFATxDefaultGLAccounts_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFatxDefaultGlaccountsDModifiedDate { get; set; }

    [Column("_btblFATxDefaultGLAccounts_iCreatedBranchID")]
    public int? BtblFatxDefaultGlaccountsICreatedBranchId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_iModifiedBranchID")]
    public int? BtblFatxDefaultGlaccountsIModifiedBranchId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_iCreatedAgentID")]
    public int? BtblFatxDefaultGlaccountsICreatedAgentId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_iModifiedAgentID")]
    public int? BtblFatxDefaultGlaccountsIModifiedAgentId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_iChangeSetID")]
    public int? BtblFatxDefaultGlaccountsIChangeSetId { get; set; }

    [Column("_btblFATxDefaultGLAccounts_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFatxDefaultGlaccountsChecksum { get; set; }
}
