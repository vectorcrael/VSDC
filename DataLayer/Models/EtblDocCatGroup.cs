using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblDocCatGroup")]
[Index("EtblDocCatGroupChecksum", Name = "idx__etblDocCatGroup__etblDocCatGroup_Checksum")]
[Index("EtblDocCatGroupDModifiedDate", Name = "idx__etblDocCatGroup__etblDocCatGroup_dModifiedDate")]
[Index("EtblDocCatGroupIBranchId", Name = "idx__etblDocCatGroup__etblDocCatGroup_iBranchID")]
[Index("EtblDocCatGroupIChangeSetId", Name = "idx__etblDocCatGroup__etblDocCatGroup_iChangeSetID")]
public partial class EtblDocCatGroup
{
    [Key]
    [Column("idDocCatGroup")]
    public int IdDocCatGroup { get; set; }

    [Column("cDocCatGroupCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CDocCatGroupCode { get; set; } = null!;

    [Column("cDocCatGroupDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDocCatGroupDescription { get; set; }

    [Column("cDocCatGroupLocation")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CDocCatGroupLocation { get; set; }

    [Column("_etblDocCatGroup_iBranchID")]
    public int? EtblDocCatGroupIBranchId { get; set; }

    [Column("_etblDocCatGroup_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblDocCatGroupDCreatedDate { get; set; }

    [Column("_etblDocCatGroup_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblDocCatGroupDModifiedDate { get; set; }

    [Column("_etblDocCatGroup_iCreatedBranchID")]
    public int? EtblDocCatGroupICreatedBranchId { get; set; }

    [Column("_etblDocCatGroup_iModifiedBranchID")]
    public int? EtblDocCatGroupIModifiedBranchId { get; set; }

    [Column("_etblDocCatGroup_iCreatedAgentID")]
    public int? EtblDocCatGroupICreatedAgentId { get; set; }

    [Column("_etblDocCatGroup_iModifiedAgentID")]
    public int? EtblDocCatGroupIModifiedAgentId { get; set; }

    [Column("_etblDocCatGroup_iChangeSetID")]
    public int? EtblDocCatGroupIChangeSetId { get; set; }

    [Column("_etblDocCatGroup_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblDocCatGroupChecksum { get; set; }
}
