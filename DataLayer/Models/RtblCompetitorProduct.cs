using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblCompetitorProduct")]
[Index("RtblCompetitorProductChecksum", Name = "idx__rtblCompetitorProduct__rtblCompetitorProduct_Checksum")]
[Index("RtblCompetitorProductIChangeSetId", Name = "idx__rtblCompetitorProduct_iChangeSetID")]
[Index("RtblCompetitorProductDModifiedDate", Name = "idx_rtblCompetitorProduct_dModifiedDate")]
[Index("RtblCompetitorProductIBranchId", Name = "idx_rtblCompetitorProduct_iBranchID")]
public partial class RtblCompetitorProduct
{
    [Key]
    [Column("IDCompetitorProduct")]
    public int IdcompetitorProduct { get; set; }

    [Column("cProductName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CProductName { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cDetailedDescription")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CDetailedDescription { get; set; }

    [Column("_rtblCompetitorProduct_iBranchID")]
    public int? RtblCompetitorProductIBranchId { get; set; }

    [Column("_rtblCompetitorProduct_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblCompetitorProductDCreatedDate { get; set; }

    [Column("_rtblCompetitorProduct_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblCompetitorProductDModifiedDate { get; set; }

    [Column("_rtblCompetitorProduct_iCreatedBranchID")]
    public int? RtblCompetitorProductICreatedBranchId { get; set; }

    [Column("_rtblCompetitorProduct_iModifiedBranchID")]
    public int? RtblCompetitorProductIModifiedBranchId { get; set; }

    [Column("_rtblCompetitorProduct_iCreatedAgentID")]
    public int? RtblCompetitorProductICreatedAgentId { get; set; }

    [Column("_rtblCompetitorProduct_iModifiedAgentID")]
    public int? RtblCompetitorProductIModifiedAgentId { get; set; }

    [Column("_rtblCompetitorProduct_iChangeSetID")]
    public int? RtblCompetitorProductIChangeSetId { get; set; }

    [Column("_rtblCompetitorProduct_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblCompetitorProductChecksum { get; set; }
}
