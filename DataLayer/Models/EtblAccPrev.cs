using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAccPrev")]
[Index("EtblAccPrevChecksum", Name = "idx__etblAccPrev__etblAccPrev_Checksum")]
[Index("EtblAccPrevDModifiedDate", Name = "idx__etblAccPrev__etblAccPrev_dModifiedDate")]
[Index("EtblAccPrevIBranchId", Name = "idx__etblAccPrev__etblAccPrev_iBranchID")]
[Index("EtblAccPrevIChangeSetId", Name = "idx__etblAccPrev__etblAccPrev_iChangeSetID")]
[Index("IAccPrevAccountId", "IAccPrevPeriodId", "IAccPrevProjectId", "IAccPrevTxBranchId", Name = "idx__etblAccPrev_iAccPrevAccountIDiAccPrevPeriodIDiAccPrevProjectIDiAccPrevTxBranchID")]
public partial class EtblAccPrev
{
    [Key]
    [Column("idAccPrev")]
    public int IdAccPrev { get; set; }

    [Column("iAccPrevAccountID")]
    public int IAccPrevAccountId { get; set; }

    [Column("iAccPrevProjectID")]
    public int IAccPrevProjectId { get; set; }

    [Column("iAccPrevPeriodID")]
    public int IAccPrevPeriodId { get; set; }

    [Column("iAccPrevTxBranchID")]
    public int IAccPrevTxBranchId { get; set; }

    [Column("fBFDebit")]
    public double? FBfdebit { get; set; }

    [Column("fBFCredit")]
    public double? FBfcredit { get; set; }

    [Column("fBFForeignDebit")]
    public double? FBfforeignDebit { get; set; }

    [Column("fBFForeignCredit")]
    public double? FBfforeignCredit { get; set; }

    [Column("_etblAccPrev_iBranchID")]
    public int? EtblAccPrevIBranchId { get; set; }

    [Column("_etblAccPrev_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAccPrevDCreatedDate { get; set; }

    [Column("_etblAccPrev_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAccPrevDModifiedDate { get; set; }

    [Column("_etblAccPrev_iCreatedBranchID")]
    public int? EtblAccPrevICreatedBranchId { get; set; }

    [Column("_etblAccPrev_iModifiedBranchID")]
    public int? EtblAccPrevIModifiedBranchId { get; set; }

    [Column("_etblAccPrev_iCreatedAgentID")]
    public int? EtblAccPrevICreatedAgentId { get; set; }

    [Column("_etblAccPrev_iModifiedAgentID")]
    public int? EtblAccPrevIModifiedAgentId { get; set; }

    [Column("_etblAccPrev_iChangeSetID")]
    public int? EtblAccPrevIChangeSetId { get; set; }

    [Column("_etblAccPrev_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAccPrevChecksum { get; set; }

    [Column("iAccPrevAccountType")]
    public int IAccPrevAccountType { get; set; }
}
