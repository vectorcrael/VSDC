using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvKnowledgeBaseFull
{
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

    [StringLength(35)]
    [Unicode(false)]
    public string? ArtDescription1Label { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? ArtDescription1 { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? ArtDescription2Label { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? ArtDescription2 { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? ArtDescription3Label { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? ArtDescription3 { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? ArtDescription4Label { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? ArtDescription4 { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? ArtDescription5Label { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? ArtDescription5 { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? ArtStatusDescription { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ArtCreatedAgent { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ArtEditedAgent { get; set; }

    [Column("StockID")]
    public int? StockId { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? StockCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description3 { get; set; }

    public bool? ItemActive { get; set; }
}
