using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmdocumentFull
{
    [Column("idDocStore")]
    public int IdDocStore { get; set; }

    [Column("cDocStoreName")]
    [StringLength(20)]
    [Unicode(false)]
    public string CDocStoreName { get; set; } = null!;

    [Column("cDocName")]
    [StringLength(255)]
    [Unicode(false)]
    public string CDocName { get; set; } = null!;

    [Column("iDocCatID")]
    public int? IDocCatId { get; set; }

    [Column("cDocDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string CDocDescription { get; set; } = null!;

    [Column("dModified", TypeName = "smalldatetime")]
    public DateTime DModified { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("nIcon", TypeName = "image")]
    public byte[]? NIcon { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }

    [Column("_rtblDocStore_iBranchID")]
    public int? RtblDocStoreIBranchId { get; set; }

    [Column("_rtblDocStore_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblDocStoreDCreatedDate { get; set; }

    [Column("_rtblDocStore_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblDocStoreDModifiedDate { get; set; }

    [Column("_rtblDocStore_iCreatedBranchID")]
    public int? RtblDocStoreICreatedBranchId { get; set; }

    [Column("_rtblDocStore_iModifiedBranchID")]
    public int? RtblDocStoreIModifiedBranchId { get; set; }

    [Column("_rtblDocStore_iCreatedAgentID")]
    public int? RtblDocStoreICreatedAgentId { get; set; }

    [Column("_rtblDocStore_iModifiedAgentID")]
    public int? RtblDocStoreIModifiedAgentId { get; set; }

    [Column("_rtblDocStore_iChangeSetID")]
    public int? RtblDocStoreIChangeSetId { get; set; }

    [Column("_rtblDocStore_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblDocStoreChecksum { get; set; }

    [Column("cDocCat")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CDocCat { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }
}
