using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("LedgerLink", "ITxBranchPrevId")]
[Table("AccPrev")]
[Index("AccPrevDModifiedDate", Name = "idxAccPrev_dModifiedDate")]
[Index("AccPrevIBranchId", Name = "idxAccPrev_iBranchID")]
[Index("AccPrevChecksum", Name = "idx_AccPrev_AccPrev_Checksum")]
[Index("AccPrevIChangeSetId", Name = "idx_AccPrev_iChangeSetID")]
public partial class AccPrev
{
    [Key]
    public int LedgerLink { get; set; }

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

    public double? PrevBal01 { get; set; }

    public double? PrevBal02 { get; set; }

    public double? PrevBal03 { get; set; }

    public double? PrevBal04 { get; set; }

    public double? PrevBal05 { get; set; }

    public double? PrevBal06 { get; set; }

    public double? PrevBal07 { get; set; }

    public double? PrevBal08 { get; set; }

    public double? PrevBal09 { get; set; }

    public double? PrevBal10 { get; set; }

    public double? PrevBal11 { get; set; }

    public double? PrevBal12 { get; set; }

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

    public double? PrevForeignBal01 { get; set; }

    public double? PrevForeignBal02 { get; set; }

    public double? PrevForeignBal03 { get; set; }

    public double? PrevForeignBal04 { get; set; }

    public double? PrevForeignBal05 { get; set; }

    public double? PrevForeignBal06 { get; set; }

    public double? PrevForeignBal07 { get; set; }

    public double? PrevForeignBal08 { get; set; }

    public double? PrevForeignBal09 { get; set; }

    public double? PrevForeignBal10 { get; set; }

    public double? PrevForeignBal11 { get; set; }

    public double? PrevForeignBal12 { get; set; }

    [Key]
    [Column("iTxBranchPrevID")]
    public int ITxBranchPrevId { get; set; }

    [Column("AccPrev_iBranchID")]
    public int? AccPrevIBranchId { get; set; }

    [Column("AccPrev_dCreatedDate", TypeName = "datetime")]
    public DateTime? AccPrevDCreatedDate { get; set; }

    [Column("AccPrev_dModifiedDate", TypeName = "datetime")]
    public DateTime? AccPrevDModifiedDate { get; set; }

    [Column("AccPrev_iCreatedBranchID")]
    public int? AccPrevICreatedBranchId { get; set; }

    [Column("AccPrev_iModifiedBranchID")]
    public int? AccPrevIModifiedBranchId { get; set; }

    [Column("AccPrev_iCreatedAgentID")]
    public int? AccPrevICreatedAgentId { get; set; }

    [Column("AccPrev_iModifiedAgentID")]
    public int? AccPrevIModifiedAgentId { get; set; }

    [Column("AccPrev_iChangeSetID")]
    public int? AccPrevIChangeSetId { get; set; }

    [Column("AccPrev_Checksum")]
    [MaxLength(20)]
    public byte[]? AccPrevChecksum { get; set; }
}
