using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchHistory")]
[Index("EtblArapbatchHistoryChecksum", Name = "idx__etblARAPBatchHistory__etblARAPBatchHistory_Checksum")]
[Index("EtblArapbatchHistoryIChangeSetId", Name = "idx__etblARAPBatchHistory_iChangeSetID")]
[Index("EtblArapbatchHistoryDModifiedDate", Name = "idx_etblARAPBatchHistory_dModifiedDate")]
[Index("EtblArapbatchHistoryIBranchId", Name = "idx_etblARAPBatchHistory_iBranchID")]
public partial class EtblArapbatchHistory
{
    [Key]
    [Column("idARAPBatchHistory")]
    public int IdArapbatchHistory { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("dActionDate", TypeName = "datetime")]
    public DateTime DActionDate { get; set; }

    [Column("iActionType")]
    public int IActionType { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchNo { get; set; }

    [Column("cBatchDesc")]
    [StringLength(40)]
    [Unicode(false)]
    public string CBatchDesc { get; set; } = null!;

    [Column("cBatchReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchReference { get; set; }

    [Column("iLineCount")]
    public int ILineCount { get; set; }

    [Column("_etblARAPBatchHistory_iBranchID")]
    public int? EtblArapbatchHistoryIBranchId { get; set; }

    [Column("_etblARAPBatchHistory_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchHistoryDCreatedDate { get; set; }

    [Column("_etblARAPBatchHistory_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchHistoryDModifiedDate { get; set; }

    [Column("_etblARAPBatchHistory_iCreatedBranchID")]
    public int? EtblArapbatchHistoryICreatedBranchId { get; set; }

    [Column("_etblARAPBatchHistory_iModifiedBranchID")]
    public int? EtblArapbatchHistoryIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchHistory_iCreatedAgentID")]
    public int? EtblArapbatchHistoryICreatedAgentId { get; set; }

    [Column("_etblARAPBatchHistory_iModifiedAgentID")]
    public int? EtblArapbatchHistoryIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchHistory_iChangeSetID")]
    public int? EtblArapbatchHistoryIChangeSetId { get; set; }

    [Column("_etblARAPBatchHistory_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchHistoryChecksum { get; set; }
}
