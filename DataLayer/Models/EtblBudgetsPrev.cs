using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblBudgetsPrev")]
[Index("EtblBudgetsPrevChecksum", Name = "idx__etblBudgetsPrev__etblBudgetsPrev_Checksum")]
[Index("EtblBudgetsPrevDModifiedDate", Name = "idx__etblBudgetsPrev__etblBudgetsPrev_dModifiedDate")]
[Index("EtblBudgetsPrevIBranchId", Name = "idx__etblBudgetsPrev__etblBudgetsPrev_iBranchID")]
[Index("EtblBudgetsPrevIChangeSetId", Name = "idx__etblBudgetsPrev__etblBudgetsPrev_iChangeSetID")]
[Index("IBudgetPrevAccountId", "IBudgetPrevPeriodId", "IBudgetPrevProjectId", "IBudgetPrevTxBranchId", Name = "idx__etblBudgetsPrev_iBudgetPrevAccountIDiBudgetPrevPeriodIDiBudgetPrevProjectIDiBudgetPrevTxBranchID")]
public partial class EtblBudgetsPrev
{
    [Key]
    [Column("idBudgetsPrev")]
    public int IdBudgetsPrev { get; set; }

    [Column("iBudgetPrevAccountID")]
    public int IBudgetPrevAccountId { get; set; }

    [Column("iBudgetPrevProjectID")]
    public int IBudgetPrevProjectId { get; set; }

    [Column("iBudgetPrevPeriodID")]
    public int IBudgetPrevPeriodId { get; set; }

    [Column("iBudgetPrevTxBranchID")]
    public int IBudgetPrevTxBranchId { get; set; }

    [Column("iBudgetPrevAccountType")]
    public int IBudgetPrevAccountType { get; set; }

    [Column("fBudgetPrev")]
    public double? FBudgetPrev { get; set; }

    [Column("fUnprocessedPOValuePrev")]
    public double? FUnprocessedPovaluePrev { get; set; }

    [Column("dBudgetPrevDTStamp", TypeName = "datetime")]
    public DateTime? DBudgetPrevDtstamp { get; set; }

    [Column("_etblBudgetsPrev_iBranchID")]
    public int? EtblBudgetsPrevIBranchId { get; set; }

    [Column("_etblBudgetsPrev_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblBudgetsPrevDCreatedDate { get; set; }

    [Column("_etblBudgetsPrev_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblBudgetsPrevDModifiedDate { get; set; }

    [Column("_etblBudgetsPrev_iCreatedBranchID")]
    public int? EtblBudgetsPrevICreatedBranchId { get; set; }

    [Column("_etblBudgetsPrev_iModifiedBranchID")]
    public int? EtblBudgetsPrevIModifiedBranchId { get; set; }

    [Column("_etblBudgetsPrev_iCreatedAgentID")]
    public int? EtblBudgetsPrevICreatedAgentId { get; set; }

    [Column("_etblBudgetsPrev_iModifiedAgentID")]
    public int? EtblBudgetsPrevIModifiedAgentId { get; set; }

    [Column("_etblBudgetsPrev_iChangeSetID")]
    public int? EtblBudgetsPrevIChangeSetId { get; set; }

    [Column("_etblBudgetsPrev_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblBudgetsPrevChecksum { get; set; }

    [Column("fBudgetPrevForeign")]
    public double FBudgetPrevForeign { get; set; }

    [Column("fUnprocessedPOValuePrevForeign")]
    public double FUnprocessedPovaluePrevForeign { get; set; }
}
