using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblRevaluationHistory")]
[Index("EtblRevaluationHistoryChecksum", Name = "idx__etblRevaluationHistory__etblRevaluationHistory_Checksum")]
[Index("EtblRevaluationHistoryDModifiedDate", Name = "idx__etblRevaluationHistory__etblRevaluationHistory_dModifiedDate")]
[Index("EtblRevaluationHistoryIBranchId", Name = "idx__etblRevaluationHistory__etblRevaluationHistory_iBranchID")]
[Index("EtblRevaluationHistoryIChangeSetId", Name = "idx__etblRevaluationHistory__etblRevaluationHistory_iChangeSetID")]
public partial class EtblRevaluationHistory
{
    [Key]
    [Column("idRevaluationHistory")]
    public int IdRevaluationHistory { get; set; }

    [Column("iModule")]
    public int? IModule { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("dTransactionDate", TypeName = "datetime")]
    public DateTime? DTransactionDate { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("fRevaluationRate")]
    public double? FRevaluationRate { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("bPosted")]
    public bool? BPosted { get; set; }

    [Column("fRevaluationAmount")]
    public double? FRevaluationAmount { get; set; }

    [Column("fOldHomeBalance")]
    public double? FOldHomeBalance { get; set; }

    [Column("fNewHomeBalance")]
    public double? FNewHomeBalance { get; set; }

    [Column("cBatchNumber")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CBatchNumber { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iGLAccountProfitLoss")]
    public int? IGlaccountProfitLoss { get; set; }

    [Column("iGLAccountProvision")]
    public int? IGlaccountProvision { get; set; }

    [Column("_etblRevaluationHistory_iBranchID")]
    public int? EtblRevaluationHistoryIBranchId { get; set; }

    [Column("_etblRevaluationHistory_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblRevaluationHistoryDCreatedDate { get; set; }

    [Column("_etblRevaluationHistory_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblRevaluationHistoryDModifiedDate { get; set; }

    [Column("_etblRevaluationHistory_iCreatedBranchID")]
    public int? EtblRevaluationHistoryICreatedBranchId { get; set; }

    [Column("_etblRevaluationHistory_iModifiedBranchID")]
    public int? EtblRevaluationHistoryIModifiedBranchId { get; set; }

    [Column("_etblRevaluationHistory_iCreatedAgentID")]
    public int? EtblRevaluationHistoryICreatedAgentId { get; set; }

    [Column("_etblRevaluationHistory_iModifiedAgentID")]
    public int? EtblRevaluationHistoryIModifiedAgentId { get; set; }

    [Column("_etblRevaluationHistory_iChangeSetID")]
    public int? EtblRevaluationHistoryIChangeSetId { get; set; }

    [Column("_etblRevaluationHistory_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblRevaluationHistoryChecksum { get; set; }

    [Column("cAccountName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAccountName { get; set; }

    [Column("iPeriodID")]
    public int IPeriodId { get; set; }

    [Column("fForeignBalance")]
    public double FForeignBalance { get; set; }

    [Column("dUpToTxDate", TypeName = "datetime")]
    public DateTime? DUpToTxDate { get; set; }

    [Column("dRevalRateDate", TypeName = "datetime")]
    public DateTime? DRevalRateDate { get; set; }
}
