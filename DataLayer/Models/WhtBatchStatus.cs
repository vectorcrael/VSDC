using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("WHT_BatchStatus")]
[Index("WhtBatchStatusChecksum", Name = "idx_WHT_BatchStatus_WHT_BatchStatus_Checksum")]
[Index("WhtBatchStatusDModifiedDate", Name = "idx_WHT_BatchStatus_WHT_BatchStatus_dModifiedDate")]
[Index("WhtBatchStatusIBranchId", Name = "idx_WHT_BatchStatus_WHT_BatchStatus_iBranchID")]
[Index("WhtBatchStatusIChangeSetId", Name = "idx_WHT_BatchStatus_WHT_BatchStatus_iChangeSetID")]
public partial class WhtBatchStatus
{
    [Key]
    [Column("idBatchNumber")]
    public int IdBatchNumber { get; set; }

    [Column("batchNumber")]
    [StringLength(30)]
    public string? BatchNumber { get; set; }

    [Column("batchStatus")]
    public bool? BatchStatus { get; set; }

    [Column("creationDate", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("processingDate", TypeName = "datetime")]
    public DateTime? ProcessingDate { get; set; }

    [Column("WHT_BatchStatus_iBranchID")]
    public int? WhtBatchStatusIBranchId { get; set; }

    [Column("WHT_BatchStatus_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhtBatchStatusDCreatedDate { get; set; }

    [Column("WHT_BatchStatus_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhtBatchStatusDModifiedDate { get; set; }

    [Column("WHT_BatchStatus_iCreatedBranchID")]
    public int? WhtBatchStatusICreatedBranchId { get; set; }

    [Column("WHT_BatchStatus_iModifiedBranchID")]
    public int? WhtBatchStatusIModifiedBranchId { get; set; }

    [Column("WHT_BatchStatus_iCreatedAgentID")]
    public int? WhtBatchStatusICreatedAgentId { get; set; }

    [Column("WHT_BatchStatus_iModifiedAgentID")]
    public int? WhtBatchStatusIModifiedAgentId { get; set; }

    [Column("WHT_BatchStatus_iChangeSetID")]
    public int? WhtBatchStatusIChangeSetId { get; set; }

    [Column("WHT_BatchStatus_Checksum")]
    [MaxLength(20)]
    public byte[]? WhtBatchStatusChecksum { get; set; }
}
