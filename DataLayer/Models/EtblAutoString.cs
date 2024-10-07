using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAutoStrings")]
[Index("EtblAutoStringsChecksum", Name = "idx__etblAutoStrings__etblAutoStrings_Checksum")]
[Index("EtblAutoStringsDModifiedDate", Name = "idx__etblAutoStrings__etblAutoStrings_dModifiedDate")]
[Index("EtblAutoStringsIBranchId", Name = "idx__etblAutoStrings__etblAutoStrings_iBranchID")]
[Index("EtblAutoStringsIChangeSetId", Name = "idx__etblAutoStrings__etblAutoStrings_iChangeSetID")]
[Index("CAutoString", Name = "idx__etblAutoStrings_cAutoString")]
public partial class EtblAutoString
{
    [Key]
    [Column("idAutoStrings")]
    public int IdAutoStrings { get; set; }

    [Column("cAutoString")]
    [StringLength(5)]
    [Unicode(false)]
    public string CAutoString { get; set; } = null!;

    [Column("bPublic")]
    public bool BPublic { get; set; }

    [Column("cAutoText")]
    [StringLength(120)]
    [Unicode(false)]
    public string CAutoText { get; set; } = null!;

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("_etblAutoStrings_iBranchID")]
    public int? EtblAutoStringsIBranchId { get; set; }

    [Column("_etblAutoStrings_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAutoStringsDCreatedDate { get; set; }

    [Column("_etblAutoStrings_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAutoStringsDModifiedDate { get; set; }

    [Column("_etblAutoStrings_iCreatedBranchID")]
    public int? EtblAutoStringsICreatedBranchId { get; set; }

    [Column("_etblAutoStrings_iModifiedBranchID")]
    public int? EtblAutoStringsIModifiedBranchId { get; set; }

    [Column("_etblAutoStrings_iCreatedAgentID")]
    public int? EtblAutoStringsICreatedAgentId { get; set; }

    [Column("_etblAutoStrings_iModifiedAgentID")]
    public int? EtblAutoStringsIModifiedAgentId { get; set; }

    [Column("_etblAutoStrings_iChangeSetID")]
    public int? EtblAutoStringsIChangeSetId { get; set; }

    [Column("_etblAutoStrings_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAutoStringsChecksum { get; set; }
}
