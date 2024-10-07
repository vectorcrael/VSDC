using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblDocLinks")]
[Index("RtblDocLinksChecksum", Name = "idx__rtblDocLinks__rtblDocLinks_Checksum")]
[Index("RtblDocLinksIChangeSetId", Name = "idx__rtblDocLinks_iChangeSetID")]
[Index("RtblDocLinksDModifiedDate", Name = "idx_rtblDocLinks_dModifiedDate")]
[Index("RtblDocLinksIBranchId", Name = "idx_rtblDocLinks_iBranchID")]
public partial class RtblDocLink
{
    [Key]
    [Column("idDocLinks")]
    public int IdDocLinks { get; set; }

    [Column("iDocStoreID")]
    public int IDocStoreId { get; set; }

    [Column("iLinkSource")]
    public int ILinkSource { get; set; }

    [Column("iLinkID")]
    public int ILinkId { get; set; }

    [Column("_rtblDocLinks_iBranchID")]
    public int? RtblDocLinksIBranchId { get; set; }

    [Column("_rtblDocLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblDocLinksDCreatedDate { get; set; }

    [Column("_rtblDocLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblDocLinksDModifiedDate { get; set; }

    [Column("_rtblDocLinks_iCreatedBranchID")]
    public int? RtblDocLinksICreatedBranchId { get; set; }

    [Column("_rtblDocLinks_iModifiedBranchID")]
    public int? RtblDocLinksIModifiedBranchId { get; set; }

    [Column("_rtblDocLinks_iCreatedAgentID")]
    public int? RtblDocLinksICreatedAgentId { get; set; }

    [Column("_rtblDocLinks_iModifiedAgentID")]
    public int? RtblDocLinksIModifiedAgentId { get; set; }

    [Column("_rtblDocLinks_iChangeSetID")]
    public int? RtblDocLinksIChangeSetId { get; set; }

    [Column("_rtblDocLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblDocLinksChecksum { get; set; }
}
