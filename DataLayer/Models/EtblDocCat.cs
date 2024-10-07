using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblDocCat")]
[Index("EtblDocCatChecksum", Name = "idx__etblDocCat__etblDocCat_Checksum")]
[Index("EtblDocCatDModifiedDate", Name = "idx__etblDocCat__etblDocCat_dModifiedDate")]
[Index("EtblDocCatIBranchId", Name = "idx__etblDocCat__etblDocCat_iBranchID")]
[Index("EtblDocCatIChangeSetId", Name = "idx__etblDocCat__etblDocCat_iChangeSetID")]
public partial class EtblDocCat
{
    [Key]
    [Column("idDocCat")]
    public int IdDocCat { get; set; }

    [Column("cDocCatCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CDocCatCode { get; set; } = null!;

    [Column("cDocCatDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDocCatDescription { get; set; }

    [Column("cDocCatLocation")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CDocCatLocation { get; set; }

    [Column("iDocCatGroupID")]
    public int? IDocCatGroupId { get; set; }

    [Column("_etblDocCat_iBranchID")]
    public int? EtblDocCatIBranchId { get; set; }

    [Column("_etblDocCat_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblDocCatDCreatedDate { get; set; }

    [Column("_etblDocCat_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblDocCatDModifiedDate { get; set; }

    [Column("_etblDocCat_iCreatedBranchID")]
    public int? EtblDocCatICreatedBranchId { get; set; }

    [Column("_etblDocCat_iModifiedBranchID")]
    public int? EtblDocCatIModifiedBranchId { get; set; }

    [Column("_etblDocCat_iCreatedAgentID")]
    public int? EtblDocCatICreatedAgentId { get; set; }

    [Column("_etblDocCat_iModifiedAgentID")]
    public int? EtblDocCatIModifiedAgentId { get; set; }

    [Column("_etblDocCat_iChangeSetID")]
    public int? EtblDocCatIChangeSetId { get; set; }

    [Column("_etblDocCat_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblDocCatChecksum { get; set; }
}
