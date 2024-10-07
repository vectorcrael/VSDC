using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKnowledgeBaseCat")]
[Index("RtblKnowledgeBaseCatChecksum", Name = "idx__rtblKnowledgeBaseCat__rtblKnowledgeBaseCat_Checksum")]
[Index("RtblKnowledgeBaseCatIChangeSetId", Name = "idx__rtblKnowledgeBaseCat_iChangeSetID")]
[Index("RtblKnowledgeBaseCatDModifiedDate", Name = "idx_rtblKnowledgeBaseCat_dModifiedDate")]
[Index("RtblKnowledgeBaseCatIBranchId", Name = "idx_rtblKnowledgeBaseCat_iBranchID")]
public partial class RtblKnowledgeBaseCat
{
    [Key]
    [Column("idKnowledgeBaseCat")]
    public int IdKnowledgeBaseCat { get; set; }

    [Column("cName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bInUse")]
    public bool BInUse { get; set; }

    [Column("_rtblKnowledgeBaseCat_iBranchID")]
    public int? RtblKnowledgeBaseCatIBranchId { get; set; }

    [Column("_rtblKnowledgeBaseCat_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseCatDCreatedDate { get; set; }

    [Column("_rtblKnowledgeBaseCat_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseCatDModifiedDate { get; set; }

    [Column("_rtblKnowledgeBaseCat_iCreatedBranchID")]
    public int? RtblKnowledgeBaseCatICreatedBranchId { get; set; }

    [Column("_rtblKnowledgeBaseCat_iModifiedBranchID")]
    public int? RtblKnowledgeBaseCatIModifiedBranchId { get; set; }

    [Column("_rtblKnowledgeBaseCat_iCreatedAgentID")]
    public int? RtblKnowledgeBaseCatICreatedAgentId { get; set; }

    [Column("_rtblKnowledgeBaseCat_iModifiedAgentID")]
    public int? RtblKnowledgeBaseCatIModifiedAgentId { get; set; }

    [Column("_rtblKnowledgeBaseCat_iChangeSetID")]
    public int? RtblKnowledgeBaseCatIChangeSetId { get; set; }

    [Column("_rtblKnowledgeBaseCat_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKnowledgeBaseCatChecksum { get; set; }
}
