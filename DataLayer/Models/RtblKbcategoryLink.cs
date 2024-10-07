using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKBCategoryLinks")]
[Index("RtblKbcategoryLinksChecksum", Name = "idx__rtblKBCategoryLinks__rtblKBCategoryLinks_Checksum")]
[Index("RtblKbcategoryLinksIChangeSetId", Name = "idx__rtblKBCategoryLinks_iChangeSetID")]
[Index("RtblKbcategoryLinksDModifiedDate", Name = "idx_rtblKBCategoryLinks_dModifiedDate")]
[Index("RtblKbcategoryLinksIBranchId", Name = "idx_rtblKBCategoryLinks_iBranchID")]
public partial class RtblKbcategoryLink
{
    [Key]
    [Column("idCategoryLinks")]
    public int IdCategoryLinks { get; set; }

    [Column("iKnowledgeBaseID")]
    public int IKnowledgeBaseId { get; set; }

    [Column("iKnowledgeBaseCatValueID")]
    public int IKnowledgeBaseCatValueId { get; set; }

    [Column("bSelected")]
    public bool BSelected { get; set; }

    [Column("_rtblKBCategoryLinks_iBranchID")]
    public int? RtblKbcategoryLinksIBranchId { get; set; }

    [Column("_rtblKBCategoryLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKbcategoryLinksDCreatedDate { get; set; }

    [Column("_rtblKBCategoryLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKbcategoryLinksDModifiedDate { get; set; }

    [Column("_rtblKBCategoryLinks_iCreatedBranchID")]
    public int? RtblKbcategoryLinksICreatedBranchId { get; set; }

    [Column("_rtblKBCategoryLinks_iModifiedBranchID")]
    public int? RtblKbcategoryLinksIModifiedBranchId { get; set; }

    [Column("_rtblKBCategoryLinks_iCreatedAgentID")]
    public int? RtblKbcategoryLinksICreatedAgentId { get; set; }

    [Column("_rtblKBCategoryLinks_iModifiedAgentID")]
    public int? RtblKbcategoryLinksIModifiedAgentId { get; set; }

    [Column("_rtblKBCategoryLinks_iChangeSetID")]
    public int? RtblKbcategoryLinksIChangeSetId { get; set; }

    [Column("_rtblKBCategoryLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKbcategoryLinksChecksum { get; set; }
}
