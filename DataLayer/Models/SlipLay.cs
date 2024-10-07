using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("SlipLay")]
[Index("SlipLayDModifiedDate", Name = "idxSlipLay_dModifiedDate")]
[Index("SlipLayIBranchId", Name = "idxSlipLay_iBranchID")]
[Index("SlipLayChecksum", Name = "idx_SlipLay_SlipLay_Checksum")]
[Index("SlipLayIChangeSetId", Name = "idx_SlipLay_iChangeSetID")]
public partial class SlipLay
{
    [Key]
    [Column("IDSlipLay")]
    public int IdslipLay { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string LayIdentifier { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? LayDefHeader { get; set; }

    [Column(TypeName = "text")]
    public string? LayDefBody { get; set; }

    [Column(TypeName = "text")]
    public string? LayDefFooter { get; set; }

    [Column(TypeName = "text")]
    public string? LayHeader { get; set; }

    [Column(TypeName = "text")]
    public string? LayBody { get; set; }

    [Column(TypeName = "text")]
    public string? LayFooter { get; set; }

    [Column("SlipLay_iBranchID")]
    public int? SlipLayIBranchId { get; set; }

    [Column("SlipLay_dCreatedDate", TypeName = "datetime")]
    public DateTime? SlipLayDCreatedDate { get; set; }

    [Column("SlipLay_dModifiedDate", TypeName = "datetime")]
    public DateTime? SlipLayDModifiedDate { get; set; }

    [Column("SlipLay_iCreatedBranchID")]
    public int? SlipLayICreatedBranchId { get; set; }

    [Column("SlipLay_iModifiedBranchID")]
    public int? SlipLayIModifiedBranchId { get; set; }

    [Column("SlipLay_iCreatedAgentID")]
    public int? SlipLayICreatedAgentId { get; set; }

    [Column("SlipLay_iModifiedAgentID")]
    public int? SlipLayIModifiedAgentId { get; set; }

    [Column("SlipLay_iChangeSetID")]
    public int? SlipLayIChangeSetId { get; set; }

    [Column("SlipLay_Checksum")]
    [MaxLength(20)]
    public byte[]? SlipLayChecksum { get; set; }
}
