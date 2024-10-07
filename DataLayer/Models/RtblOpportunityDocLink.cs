using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblOpportunityDocLinks")]
[Index("RtblOpportunityDocLinksChecksum", Name = "idx__rtblOpportunityDocLinks__rtblOpportunityDocLinks_Checksum")]
[Index("RtblOpportunityDocLinksIChangeSetId", Name = "idx__rtblOpportunityDocLinks_iChangeSetID")]
[Index("RtblOpportunityDocLinksDModifiedDate", Name = "idx_rtblOpportunityDocLinks_dModifiedDate")]
[Index("RtblOpportunityDocLinksIBranchId", Name = "idx_rtblOpportunityDocLinks_iBranchID")]
public partial class RtblOpportunityDocLink
{
    [Key]
    [Column("IDDocLinks")]
    public int IddocLinks { get; set; }

    [Column("iDocStoreID")]
    public int? IDocStoreId { get; set; }

    [Column("iLinkSource")]
    public int? ILinkSource { get; set; }

    [Column("iLinkID")]
    public int? ILinkId { get; set; }

    [Column("_rtblOpportunityDocLinks_iBranchID")]
    public int? RtblOpportunityDocLinksIBranchId { get; set; }

    [Column("_rtblOpportunityDocLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityDocLinksDCreatedDate { get; set; }

    [Column("_rtblOpportunityDocLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityDocLinksDModifiedDate { get; set; }

    [Column("_rtblOpportunityDocLinks_iCreatedBranchID")]
    public int? RtblOpportunityDocLinksICreatedBranchId { get; set; }

    [Column("_rtblOpportunityDocLinks_iModifiedBranchID")]
    public int? RtblOpportunityDocLinksIModifiedBranchId { get; set; }

    [Column("_rtblOpportunityDocLinks_iCreatedAgentID")]
    public int? RtblOpportunityDocLinksICreatedAgentId { get; set; }

    [Column("_rtblOpportunityDocLinks_iModifiedAgentID")]
    public int? RtblOpportunityDocLinksIModifiedAgentId { get; set; }

    [Column("_rtblOpportunityDocLinks_iChangeSetID")]
    public int? RtblOpportunityDocLinksIChangeSetId { get; set; }

    [Column("_rtblOpportunityDocLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblOpportunityDocLinksChecksum { get; set; }
}
