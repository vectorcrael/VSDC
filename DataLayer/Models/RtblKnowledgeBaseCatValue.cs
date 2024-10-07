using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKnowledgeBaseCatValue")]
[Index("RtblKnowledgeBaseCatValueChecksum", Name = "idx__rtblKnowledgeBaseCatValue__rtblKnowledgeBaseCatValue_Checksum")]
[Index("RtblKnowledgeBaseCatValueIChangeSetId", Name = "idx__rtblKnowledgeBaseCatValue_iChangeSetID")]
[Index("RtblKnowledgeBaseCatValueDModifiedDate", Name = "idx_rtblKnowledgeBaseCatValue_dModifiedDate")]
[Index("RtblKnowledgeBaseCatValueIBranchId", Name = "idx_rtblKnowledgeBaseCatValue_iBranchID")]
public partial class RtblKnowledgeBaseCatValue
{
    [Key]
    [Column("idKnowledgeBaseCatValue")]
    public int IdKnowledgeBaseCatValue { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("iKnowledgeBaseCatID")]
    public int? IKnowledgeBaseCatId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_iBranchID")]
    public int? RtblKnowledgeBaseCatValueIBranchId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseCatValueDCreatedDate { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseCatValueDModifiedDate { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_iCreatedBranchID")]
    public int? RtblKnowledgeBaseCatValueICreatedBranchId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_iModifiedBranchID")]
    public int? RtblKnowledgeBaseCatValueIModifiedBranchId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_iCreatedAgentID")]
    public int? RtblKnowledgeBaseCatValueICreatedAgentId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_iModifiedAgentID")]
    public int? RtblKnowledgeBaseCatValueIModifiedAgentId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_iChangeSetID")]
    public int? RtblKnowledgeBaseCatValueIChangeSetId { get; set; }

    [Column("_rtblKnowledgeBaseCatValue_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKnowledgeBaseCatValueChecksum { get; set; }
}
