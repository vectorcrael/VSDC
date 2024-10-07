using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblContractDocLinks")]
[Index("RtblContractDocLinksChecksum", Name = "idx__rtblContractDocLinks__rtblContractDocLinks_Checksum")]
[Index("RtblContractDocLinksIChangeSetId", Name = "idx__rtblContractDocLinks_iChangeSetID")]
[Index("RtblContractDocLinksDModifiedDate", Name = "idx_rtblContractDocLinks_dModifiedDate")]
[Index("RtblContractDocLinksIBranchId", Name = "idx_rtblContractDocLinks_iBranchID")]
public partial class RtblContractDocLink
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

    [Column("_rtblContractDocLinks_iBranchID")]
    public int? RtblContractDocLinksIBranchId { get; set; }

    [Column("_rtblContractDocLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblContractDocLinksDCreatedDate { get; set; }

    [Column("_rtblContractDocLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblContractDocLinksDModifiedDate { get; set; }

    [Column("_rtblContractDocLinks_iCreatedBranchID")]
    public int? RtblContractDocLinksICreatedBranchId { get; set; }

    [Column("_rtblContractDocLinks_iModifiedBranchID")]
    public int? RtblContractDocLinksIModifiedBranchId { get; set; }

    [Column("_rtblContractDocLinks_iCreatedAgentID")]
    public int? RtblContractDocLinksICreatedAgentId { get; set; }

    [Column("_rtblContractDocLinks_iModifiedAgentID")]
    public int? RtblContractDocLinksIModifiedAgentId { get; set; }

    [Column("_rtblContractDocLinks_iChangeSetID")]
    public int? RtblContractDocLinksIChangeSetId { get; set; }

    [Column("_rtblContractDocLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblContractDocLinksChecksum { get; set; }
}
