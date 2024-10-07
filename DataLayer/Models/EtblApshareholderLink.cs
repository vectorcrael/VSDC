using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAPShareholderLinks")]
[Index("EtblApshareholderLinksChecksum", Name = "idx__etblAPShareholderLinks__etblAPShareholderLinks_Checksum")]
[Index("EtblApshareholderLinksDModifiedDate", Name = "idx__etblAPShareholderLinks__etblAPShareholderLinks_dModifiedDate")]
[Index("EtblApshareholderLinksIBranchId", Name = "idx__etblAPShareholderLinks__etblAPShareholderLinks_iBranchID")]
[Index("EtblApshareholderLinksIChangeSetId", Name = "idx__etblAPShareholderLinks__etblAPShareholderLinks_iChangeSetID")]
public partial class EtblApshareholderLink
{
    [Key]
    [Column("idAPShareholderLinks")]
    public int IdApshareholderLinks { get; set; }

    [Column("iAPShareholderID")]
    public int IApshareholderId { get; set; }

    [Column("iSupplierID")]
    public int ISupplierId { get; set; }

    [Column("fPercentage")]
    public double FPercentage { get; set; }

    [Column("cPositionHeld")]
    [StringLength(50)]
    [Unicode(false)]
    public string CPositionHeld { get; set; } = null!;

    [Column("bDirector")]
    public bool? BDirector { get; set; }

    [Column("_etblAPShareholderLinks_iBranchID")]
    public int? EtblApshareholderLinksIBranchId { get; set; }

    [Column("_etblAPShareholderLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblApshareholderLinksDCreatedDate { get; set; }

    [Column("_etblAPShareholderLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblApshareholderLinksDModifiedDate { get; set; }

    [Column("_etblAPShareholderLinks_iCreatedBranchID")]
    public int? EtblApshareholderLinksICreatedBranchId { get; set; }

    [Column("_etblAPShareholderLinks_iModifiedBranchID")]
    public int? EtblApshareholderLinksIModifiedBranchId { get; set; }

    [Column("_etblAPShareholderLinks_iCreatedAgentID")]
    public int? EtblApshareholderLinksICreatedAgentId { get; set; }

    [Column("_etblAPShareholderLinks_iModifiedAgentID")]
    public int? EtblApshareholderLinksIModifiedAgentId { get; set; }

    [Column("_etblAPShareholderLinks_iChangeSetID")]
    public int? EtblApshareholderLinksIChangeSetId { get; set; }

    [Column("_etblAPShareholderLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblApshareholderLinksChecksum { get; set; }
}
