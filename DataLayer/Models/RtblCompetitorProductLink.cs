using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblCompetitorProductLink")]
[Index("RtblCompetitorProductLinkChecksum", Name = "idx__rtblCompetitorProductLink__rtblCompetitorProductLink_Checksum")]
[Index("RtblCompetitorProductLinkIChangeSetId", Name = "idx__rtblCompetitorProductLink_iChangeSetID")]
[Index("RtblCompetitorProductLinkDModifiedDate", Name = "idx_rtblCompetitorProductLink_dModifiedDate")]
[Index("RtblCompetitorProductLinkIBranchId", Name = "idx_rtblCompetitorProductLink_iBranchID")]
public partial class RtblCompetitorProductLink
{
    [Key]
    [Column("idCompetitorProductLink")]
    public int IdCompetitorProductLink { get; set; }

    [Column("iCompetitorID")]
    public int ICompetitorId { get; set; }

    [Column("iCompetitorProductID")]
    public int ICompetitorProductId { get; set; }

    [Column("fProductPrice")]
    public double? FProductPrice { get; set; }

    [Column("dDtPriceUpdated", TypeName = "datetime")]
    public DateTime? DDtPriceUpdated { get; set; }

    [Column("_rtblCompetitorProductLink_iBranchID")]
    public int? RtblCompetitorProductLinkIBranchId { get; set; }

    [Column("_rtblCompetitorProductLink_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblCompetitorProductLinkDCreatedDate { get; set; }

    [Column("_rtblCompetitorProductLink_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblCompetitorProductLinkDModifiedDate { get; set; }

    [Column("_rtblCompetitorProductLink_iCreatedBranchID")]
    public int? RtblCompetitorProductLinkICreatedBranchId { get; set; }

    [Column("_rtblCompetitorProductLink_iModifiedBranchID")]
    public int? RtblCompetitorProductLinkIModifiedBranchId { get; set; }

    [Column("_rtblCompetitorProductLink_iCreatedAgentID")]
    public int? RtblCompetitorProductLinkICreatedAgentId { get; set; }

    [Column("_rtblCompetitorProductLink_iModifiedAgentID")]
    public int? RtblCompetitorProductLinkIModifiedAgentId { get; set; }

    [Column("_rtblCompetitorProductLink_iChangeSetID")]
    public int? RtblCompetitorProductLinkIChangeSetId { get; set; }

    [Column("_rtblCompetitorProductLink_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblCompetitorProductLinkChecksum { get; set; }
}
