using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKBDescriptionLinks")]
[Index("RtblKbdescriptionLinksChecksum", Name = "idx__rtblKBDescriptionLinks__rtblKBDescriptionLinks_Checksum")]
[Index("RtblKbdescriptionLinksIChangeSetId", Name = "idx__rtblKBDescriptionLinks_iChangeSetID")]
[Index("RtblKbdescriptionLinksDModifiedDate", Name = "idx_rtblKBDescriptionLinks_dModifiedDate")]
[Index("RtblKbdescriptionLinksIBranchId", Name = "idx_rtblKBDescriptionLinks_iBranchID")]
public partial class RtblKbdescriptionLink
{
    [Key]
    [Column("idDescriptionLinks")]
    public int IdDescriptionLinks { get; set; }

    [Column("iKnowledgeBaseID")]
    public int IKnowledgeBaseId { get; set; }

    [Column("iDescriptionID")]
    public int IDescriptionId { get; set; }

    [Column("cDescription", TypeName = "text")]
    public string? CDescription { get; set; }

    [Column("_rtblKBDescriptionLinks_iBranchID")]
    public int? RtblKbdescriptionLinksIBranchId { get; set; }

    [Column("_rtblKBDescriptionLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKbdescriptionLinksDCreatedDate { get; set; }

    [Column("_rtblKBDescriptionLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKbdescriptionLinksDModifiedDate { get; set; }

    [Column("_rtblKBDescriptionLinks_iCreatedBranchID")]
    public int? RtblKbdescriptionLinksICreatedBranchId { get; set; }

    [Column("_rtblKBDescriptionLinks_iModifiedBranchID")]
    public int? RtblKbdescriptionLinksIModifiedBranchId { get; set; }

    [Column("_rtblKBDescriptionLinks_iCreatedAgentID")]
    public int? RtblKbdescriptionLinksICreatedAgentId { get; set; }

    [Column("_rtblKBDescriptionLinks_iModifiedAgentID")]
    public int? RtblKbdescriptionLinksIModifiedAgentId { get; set; }

    [Column("_rtblKBDescriptionLinks_iChangeSetID")]
    public int? RtblKbdescriptionLinksIChangeSetId { get; set; }

    [Column("_rtblKBDescriptionLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKbdescriptionLinksChecksum { get; set; }
}
