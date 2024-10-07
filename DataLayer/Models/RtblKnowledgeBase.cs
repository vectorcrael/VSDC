using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKnowledgeBase")]
[Index("RtblKnowledgeBaseChecksum", Name = "idx__rtblKnowledgeBase__rtblKnowledgeBase_Checksum")]
[Index("RtblKnowledgeBaseIChangeSetId", Name = "idx__rtblKnowledgeBase_iChangeSetID")]
[Index("RtblKnowledgeBaseDModifiedDate", Name = "idx_rtblKnowledgeBase_dModifiedDate")]
[Index("RtblKnowledgeBaseIBranchId", Name = "idx_rtblKnowledgeBase_iBranchID")]
public partial class RtblKnowledgeBase
{
    [Key]
    [Column("idKnowledgeBase")]
    public int IdKnowledgeBase { get; set; }

    [Column("cArticleNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CArticleNumber { get; set; }

    [Column("cSummary")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CSummary { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iStatus")]
    public int IStatus { get; set; }

    [Column("bPublic")]
    public bool BPublic { get; set; }

    [Column("dCreatedDate", TypeName = "smalldatetime")]
    public DateTime DCreatedDate { get; set; }

    [Column("iCreatedAgentID")]
    public int ICreatedAgentId { get; set; }

    [Column("dDateEdited", TypeName = "smalldatetime")]
    public DateTime? DDateEdited { get; set; }

    [Column("iEditedAgentID")]
    public int IEditedAgentId { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }

    [Column("_rtblKnowledgeBase_iBranchID")]
    public int? RtblKnowledgeBaseIBranchId { get; set; }

    [Column("_rtblKnowledgeBase_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseDCreatedDate { get; set; }

    [Column("_rtblKnowledgeBase_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseDModifiedDate { get; set; }

    [Column("_rtblKnowledgeBase_iCreatedBranchID")]
    public int? RtblKnowledgeBaseICreatedBranchId { get; set; }

    [Column("_rtblKnowledgeBase_iModifiedBranchID")]
    public int? RtblKnowledgeBaseIModifiedBranchId { get; set; }

    [Column("_rtblKnowledgeBase_iCreatedAgentID")]
    public int? RtblKnowledgeBaseICreatedAgentId { get; set; }

    [Column("_rtblKnowledgeBase_iModifiedAgentID")]
    public int? RtblKnowledgeBaseIModifiedAgentId { get; set; }

    [Column("_rtblKnowledgeBase_iChangeSetID")]
    public int? RtblKnowledgeBaseIChangeSetId { get; set; }

    [Column("_rtblKnowledgeBase_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKnowledgeBaseChecksum { get; set; }
}
