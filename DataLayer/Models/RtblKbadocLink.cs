using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKBADocLinks")]
[Index("RtblKbadocLinksChecksum", Name = "idx__rtblKBADocLinks__rtblKBADocLinks_Checksum")]
[Index("RtblKbadocLinksIChangeSetId", Name = "idx__rtblKBADocLinks_iChangeSetID")]
[Index("RtblKbadocLinksDModifiedDate", Name = "idx_rtblKBADocLinks_dModifiedDate")]
[Index("RtblKbadocLinksIBranchId", Name = "idx_rtblKBADocLinks_iBranchID")]
public partial class RtblKbadocLink
{
    [Key]
    [Column("idDocLinks")]
    public int IdDocLinks { get; set; }

    [Column("iDocStoreID")]
    public int? IDocStoreId { get; set; }

    [Column("iLinkSource")]
    public int? ILinkSource { get; set; }

    [Column("iLinkID")]
    public int? ILinkId { get; set; }

    [Column("_rtblKBADocLinks_iBranchID")]
    public int? RtblKbadocLinksIBranchId { get; set; }

    [Column("_rtblKBADocLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKbadocLinksDCreatedDate { get; set; }

    [Column("_rtblKBADocLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKbadocLinksDModifiedDate { get; set; }

    [Column("_rtblKBADocLinks_iCreatedBranchID")]
    public int? RtblKbadocLinksICreatedBranchId { get; set; }

    [Column("_rtblKBADocLinks_iModifiedBranchID")]
    public int? RtblKbadocLinksIModifiedBranchId { get; set; }

    [Column("_rtblKBADocLinks_iCreatedAgentID")]
    public int? RtblKbadocLinksICreatedAgentId { get; set; }

    [Column("_rtblKBADocLinks_iModifiedAgentID")]
    public int? RtblKbadocLinksIModifiedAgentId { get; set; }

    [Column("_rtblKBADocLinks_iChangeSetID")]
    public int? RtblKbadocLinksIChangeSetId { get; set; }

    [Column("_rtblKBADocLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKbadocLinksChecksum { get; set; }
}
