using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPOSTransaction")]
[Index("IAgentSessionId", Name = "idx__rebtPOSTransaction_iAgentSessionID")]
[Index("RetPostransactionChecksum", Name = "idx__retPOSTransaction__retPOSTransaction_Checksum")]
[Index("RetPostransactionDModifiedDate", Name = "idx__retPOSTransaction__retPOSTransaction_dModifiedDate")]
[Index("RetPostransactionIBranchId", Name = "idx__retPOSTransaction__retPOSTransaction_iBranchID")]
[Index("RetPostransactionIChangeSetId", Name = "idx__retPOSTransaction__retPOSTransaction_iChangeSetID")]
[Index("IInvNumId", Name = "idx__retPOSTransaction_iInvNumID")]
public partial class RetPostransaction
{
    [Key]
    [Column("idPOSTransaction")]
    public long IdPostransaction { get; set; }

    [Column("iTillID")]
    public int? ITillId { get; set; }

    [Column("dTransactionDate", TypeName = "datetime")]
    public DateTime? DTransactionDate { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("iTrCodesID")]
    public int? ITrCodesId { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("iTillTxType")]
    public int? ITillTxType { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("fAmountTendered")]
    public double? FAmountTendered { get; set; }

    [Column("fAmountChange")]
    public double? FAmountChange { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("iInvNumID")]
    public long? IInvNumId { get; set; }

    [Column("_retPOSTransaction_iBranchID")]
    public int? RetPostransactionIBranchId { get; set; }

    [Column("_retPOSTransaction_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPostransactionDCreatedDate { get; set; }

    [Column("_retPOSTransaction_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPostransactionDModifiedDate { get; set; }

    [Column("_retPOSTransaction_iCreatedBranchID")]
    public int? RetPostransactionICreatedBranchId { get; set; }

    [Column("_retPOSTransaction_iModifiedBranchID")]
    public int? RetPostransactionIModifiedBranchId { get; set; }

    [Column("_retPOSTransaction_iCreatedAgentID")]
    public int? RetPostransactionICreatedAgentId { get; set; }

    [Column("_retPOSTransaction_iModifiedAgentID")]
    public int? RetPostransactionIModifiedAgentId { get; set; }

    [Column("_retPOSTransaction_iChangeSetID")]
    public int? RetPostransactionIChangeSetId { get; set; }

    [Column("_retPOSTransaction_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPostransactionChecksum { get; set; }
}
