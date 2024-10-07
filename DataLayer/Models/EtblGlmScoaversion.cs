using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLmSCOAVersions")]
[Index("EtblGlmScoaversionsChecksum", Name = "idx__etblGLmSCOAVersions__etblGLmSCOAVersions_Checksum")]
[Index("EtblGlmScoaversionsDModifiedDate", Name = "idx__etblGLmSCOAVersions__etblGLmSCOAVersions_dModifiedDate")]
[Index("EtblGlmScoaversionsIBranchId", Name = "idx__etblGLmSCOAVersions__etblGLmSCOAVersions_iBranchID")]
[Index("EtblGlmScoaversionsIChangeSetId", Name = "idx__etblGLmSCOAVersions__etblGLmSCOAVersions_iChangeSetID")]
public partial class EtblGlmScoaversion
{
    [Key]
    [Column("idmSCOAVersion")]
    public int IdmScoaversion { get; set; }

    [Column("cVersionDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CVersionDescription { get; set; } = null!;

    [Column("bTransactingVersion")]
    public bool BTransactingVersion { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_etblGLmSCOAVersions_iBranchID")]
    public int? EtblGlmScoaversionsIBranchId { get; set; }

    [Column("_etblGLmSCOAVersions_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlmScoaversionsDCreatedDate { get; set; }

    [Column("_etblGLmSCOAVersions_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlmScoaversionsDModifiedDate { get; set; }

    [Column("_etblGLmSCOAVersions_iCreatedBranchID")]
    public int? EtblGlmScoaversionsICreatedBranchId { get; set; }

    [Column("_etblGLmSCOAVersions_iModifiedBranchID")]
    public int? EtblGlmScoaversionsIModifiedBranchId { get; set; }

    [Column("_etblGLmSCOAVersions_iCreatedAgentID")]
    public int? EtblGlmScoaversionsICreatedAgentId { get; set; }

    [Column("_etblGLmSCOAVersions_iModifiedAgentID")]
    public int? EtblGlmScoaversionsIModifiedAgentId { get; set; }

    [Column("_etblGLmSCOAVersions_iChangeSetID")]
    public int? EtblGlmScoaversionsIChangeSetId { get; set; }

    [Column("_etblGLmSCOAVersions_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlmScoaversionsChecksum { get; set; }
}
