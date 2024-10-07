using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEUCommodity")]
[Index("EtblEucommodityChecksum", Name = "idx__etblEUCommodity__etblEUCommodity_Checksum")]
[Index("EtblEucommodityIChangeSetId", Name = "idx__etblEUCommodity_iChangeSetID")]
[Index("EtblEucommodityDModifiedDate", Name = "idx_etblEUCommodity_dModifiedDate")]
[Index("EtblEucommodityIBranchId", Name = "idx_etblEUCommodity_iBranchID")]
public partial class EtblEucommodity
{
    [Key]
    [Column("IDEUCommodity")]
    public int Ideucommodity { get; set; }

    [Column("cEUCommodityCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEucommodityCode { get; set; }

    [Column("cEUCommodityDescription")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CEucommodityDescription { get; set; }

    [Column("_etblEUCommodity_iBranchID")]
    public int? EtblEucommodityIBranchId { get; set; }

    [Column("_etblEUCommodity_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEucommodityDCreatedDate { get; set; }

    [Column("_etblEUCommodity_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEucommodityDModifiedDate { get; set; }

    [Column("_etblEUCommodity_iCreatedBranchID")]
    public int? EtblEucommodityICreatedBranchId { get; set; }

    [Column("_etblEUCommodity_iModifiedBranchID")]
    public int? EtblEucommodityIModifiedBranchId { get; set; }

    [Column("_etblEUCommodity_iCreatedAgentID")]
    public int? EtblEucommodityICreatedAgentId { get; set; }

    [Column("_etblEUCommodity_iModifiedAgentID")]
    public int? EtblEucommodityIModifiedAgentId { get; set; }

    [Column("_etblEUCommodity_iChangeSetID")]
    public int? EtblEucommodityIChangeSetId { get; set; }

    [Column("_etblEUCommodity_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEucommodityChecksum { get; set; }
}
