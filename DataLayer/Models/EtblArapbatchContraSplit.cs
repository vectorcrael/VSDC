using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchContraSplit")]
[Index("EtblArapbatchContraSplitChecksum", Name = "idx__etblARAPBatchContraSplit__etblARAPBatchContraSplit_Checksum")]
[Index("EtblArapbatchContraSplitIChangeSetId", Name = "idx__etblARAPBatchContraSplit_iChangeSetID")]
[Index("EtblArapbatchContraSplitDModifiedDate", Name = "idx_etblARAPBatchContraSplit_dModifiedDate")]
[Index("EtblArapbatchContraSplitIBranchId", Name = "idx_etblARAPBatchContraSplit_iBranchID")]
public partial class EtblArapbatchContraSplit
{
    [Key]
    [Column("idARAPBatchContraSplit")]
    public int IdArapbatchContraSplit { get; set; }

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
    public double? FAmountIncl { get; set; }

    [Column("fAmountInclForeign")]
    public double? FAmountInclForeign { get; set; }

    [Column("_etblARAPBatchContraSplit_iBranchID")]
    public int? EtblArapbatchContraSplitIBranchId { get; set; }

    [Column("_etblARAPBatchContraSplit_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchContraSplitDCreatedDate { get; set; }

    [Column("_etblARAPBatchContraSplit_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchContraSplitDModifiedDate { get; set; }

    [Column("_etblARAPBatchContraSplit_iCreatedBranchID")]
    public int? EtblArapbatchContraSplitICreatedBranchId { get; set; }

    [Column("_etblARAPBatchContraSplit_iModifiedBranchID")]
    public int? EtblArapbatchContraSplitIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchContraSplit_iCreatedAgentID")]
    public int? EtblArapbatchContraSplitICreatedAgentId { get; set; }

    [Column("_etblARAPBatchContraSplit_iModifiedAgentID")]
    public int? EtblArapbatchContraSplitIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchContraSplit_iChangeSetID")]
    public int? EtblArapbatchContraSplitIChangeSetId { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("_etblARAPBatchContraSplit_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchContraSplitChecksum { get; set; }

    [Column("cTaxCompanyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CTaxCompanyName { get; set; }

    [Column("cTaxCompanyRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxCompanyRegistration { get; set; }

    [Column("cTaxRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxRegistration { get; set; }
}
