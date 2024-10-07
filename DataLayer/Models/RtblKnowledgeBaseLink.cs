using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKnowledgeBaseLinks")]
[Index("RtblKnowledgeBaseLinksChecksum", Name = "idx__rtblKnowledgeBaseLinks__rtblKnowledgeBaseLinks_Checksum")]
[Index("RtblKnowledgeBaseLinksIChangeSetId", Name = "idx__rtblKnowledgeBaseLinks_iChangeSetID")]
[Index("RtblKnowledgeBaseLinksDModifiedDate", Name = "idx_rtblKnowledgeBaseLinks_dModifiedDate")]
[Index("RtblKnowledgeBaseLinksIBranchId", Name = "idx_rtblKnowledgeBaseLinks_iBranchID")]
public partial class RtblKnowledgeBaseLink
{
    [Key]
    [Column("idKnowledgeBaseLinks")]
    public int IdKnowledgeBaseLinks { get; set; }

    [Column("iKnowledgeBaseID")]
    public int IKnowledgeBaseId { get; set; }

    [Column("iIncidentID")]
    public int IIncidentId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_iBranchID")]
    public int? RtblKnowledgeBaseLinksIBranchId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseLinksDCreatedDate { get; set; }

    [Column("_rtblKnowledgeBaseLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKnowledgeBaseLinksDModifiedDate { get; set; }

    [Column("_rtblKnowledgeBaseLinks_iCreatedBranchID")]
    public int? RtblKnowledgeBaseLinksICreatedBranchId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_iModifiedBranchID")]
    public int? RtblKnowledgeBaseLinksIModifiedBranchId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_iCreatedAgentID")]
    public int? RtblKnowledgeBaseLinksICreatedAgentId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_iModifiedAgentID")]
    public int? RtblKnowledgeBaseLinksIModifiedAgentId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_iChangeSetID")]
    public int? RtblKnowledgeBaseLinksIChangeSetId { get; set; }

    [Column("_rtblKnowledgeBaseLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKnowledgeBaseLinksChecksum { get; set; }
}
