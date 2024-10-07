using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchContraSplitHistory")]
[Index("EtblArapbatchContraSplitHistoryChecksum", Name = "idx__etblARAPBatchContraSplitHistory__etblARAPBatchContraSplitHistory_Checksum")]
[Index("EtblArapbatchContraSplitHistoryIChangeSetId", Name = "idx__etblARAPBatchContraSplitHistory_iChangeSetID")]
[Index("EtblArapbatchContraSplitHistoryDModifiedDate", Name = "idx_etblARAPBatchContraSplitHistory_dModifiedDate")]
[Index("EtblArapbatchContraSplitHistoryIBranchId", Name = "idx_etblARAPBatchContraSplitHistory_iBranchID")]
public partial class EtblArapbatchContraSplitHistory
{
    [Key]
    [Column("idARAPBatchContraSplitHistory")]
    public int IdArapbatchContraSplitHistory { get; set; }

    [Column("iBatchHistoryID")]
    public int IBatchHistoryId { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("iLinePermID")]
    public int ILinePermId { get; set; }

    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("fAmountForeign")]
    public double? FAmountForeign { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iTaxTypeID")]
    public int ITaxTypeId { get; set; }

    [Column("fAmountIncl")]
    public double FAmountIncl { get; set; }

    [Column("fAmountInclForeign")]
    public double? FAmountInclForeign { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_iBranchID")]
    public int? EtblArapbatchContraSplitHistoryIBranchId { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchContraSplitHistoryDCreatedDate { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchContraSplitHistoryDModifiedDate { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_iCreatedBranchID")]
    public int? EtblArapbatchContraSplitHistoryICreatedBranchId { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_iModifiedBranchID")]
    public int? EtblArapbatchContraSplitHistoryIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_iCreatedAgentID")]
    public int? EtblArapbatchContraSplitHistoryICreatedAgentId { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_iModifiedAgentID")]
    public int? EtblArapbatchContraSplitHistoryIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_iChangeSetID")]
    public int? EtblArapbatchContraSplitHistoryIChangeSetId { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("_etblARAPBatchContraSplitHistory_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchContraSplitHistoryChecksum { get; set; }
}
