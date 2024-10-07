using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvDocCat
{
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

    [Column("idDocCatGroup")]
    public int? IdDocCatGroup { get; set; }

    [Column("cDocCatGroupCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CDocCatGroupCode { get; set; }

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

    [StringLength(256)]
    [Unicode(false)]
    public string? DefaultLocation { get; set; }
}
