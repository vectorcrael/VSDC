using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchSettDiscLines")]
[Index("EtblArapbatchSettDiscLinesChecksum", Name = "idx__etblARAPBatchSettDiscLines__etblARAPBatchSettDiscLines_Checksum")]
[Index("EtblArapbatchSettDiscLinesIChangeSetId", Name = "idx__etblARAPBatchSettDiscLines_iChangeSetID")]
[Index("EtblArapbatchSettDiscLinesDModifiedDate", Name = "idx_etblARAPBatchSettDiscLines_dModifiedDate")]
[Index("EtblArapbatchSettDiscLinesIBranchId", Name = "idx_etblARAPBatchSettDiscLines_iBranchID")]
public partial class EtblArapbatchSettDiscLine
{
    [Key]
    [Column("idARAPBatchSettDiscLines")]
    public int IdArapbatchSettDiscLines { get; set; }

    [Column("iBatchId")]
    public int IBatchId { get; set; }

    [Column("iLinePermId")]
    public int ILinePermId { get; set; }

    [Column("iPostARAPId")]
    public long IPostArapid { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("fAmountForeign")]
    public double? FAmountForeign { get; set; }

    [Column("fDiscPerc")]
    public double? FDiscPerc { get; set; }

    [Column("fDiscAmount")]
    public double? FDiscAmount { get; set; }

    [Column("fDiscAmountForeign")]
    public double? FDiscAmountForeign { get; set; }

    [Column("fFCAccAmount")]
    public double? FFcaccAmount { get; set; }

    [Column("fFCAccDiscAmount")]
    public double? FFcaccDiscAmount { get; set; }

    [Column("_etblARAPBatchSettDiscLines_iBranchID")]
    public int? EtblArapbatchSettDiscLinesIBranchId { get; set; }

    [Column("_etblARAPBatchSettDiscLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchSettDiscLinesDCreatedDate { get; set; }

    [Column("_etblARAPBatchSettDiscLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchSettDiscLinesDModifiedDate { get; set; }

    [Column("_etblARAPBatchSettDiscLines_iCreatedBranchID")]
    public int? EtblArapbatchSettDiscLinesICreatedBranchId { get; set; }

    [Column("_etblARAPBatchSettDiscLines_iModifiedBranchID")]
    public int? EtblArapbatchSettDiscLinesIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchSettDiscLines_iCreatedAgentID")]
    public int? EtblArapbatchSettDiscLinesICreatedAgentId { get; set; }

    [Column("_etblARAPBatchSettDiscLines_iModifiedAgentID")]
    public int? EtblArapbatchSettDiscLinesIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchSettDiscLines_iChangeSetID")]
    public int? EtblArapbatchSettDiscLinesIChangeSetId { get; set; }

    [Column("_etblARAPBatchSettDiscLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchSettDiscLinesChecksum { get; set; }
}
