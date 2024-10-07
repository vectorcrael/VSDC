using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAccBlnc")]
[Index("EtblAccBlncChecksum", Name = "idx__etblAccBlnc__etblAccBlnc_Checksum")]
[Index("EtblAccBlncDModifiedDate", Name = "idx__etblAccBlnc__etblAccBlnc_dModifiedDate")]
[Index("EtblAccBlncIBranchId", Name = "idx__etblAccBlnc__etblAccBlnc_iBranchID")]
[Index("EtblAccBlncIChangeSetId", Name = "idx__etblAccBlnc__etblAccBlnc_iChangeSetID")]
[Index("IAccBlncAccountId", "IAccBlncPeriodId", "IAccBlncProjectId", "IAccBlncTxBranchId", Name = "idx__etblAccBlnc_iAccBlncAccountIDiAccBlncPeriodIDiAccBlncProjectIDiAccBlncTxBranchID")]
public partial class EtblAccBlnc
{
    [Key]
    [Column("idAccBlnc")]
    public int IdAccBlnc { get; set; }

    [Column("iAccBlncAccountID")]
    public int IAccBlncAccountId { get; set; }

    [Column("iAccBlncProjectID")]
    public int IAccBlncProjectId { get; set; }

    [Column("iAccBlncPeriodID")]
    public int IAccBlncPeriodId { get; set; }

    [Column("iAccBlncTxBranchID")]
    public int IAccBlncTxBranchId { get; set; }

    [Column("iAccBlncAccountType")]
    public int IAccBlncAccountType { get; set; }

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
}
