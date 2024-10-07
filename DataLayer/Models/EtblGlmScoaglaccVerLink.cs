using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLmSCOAGLAccVerLinks")]
[Index("EtblGlmScoaglaccVerLinksChecksum", Name = "idx__etblGLmSCOAGLAccVerLinks__etblGLmSCOAGLAccVerLinks_Checksum")]
[Index("EtblGlmScoaglaccVerLinksDModifiedDate", Name = "idx__etblGLmSCOAGLAccVerLinks__etblGLmSCOAGLAccVerLinks_dModifiedDate")]
[Index("EtblGlmScoaglaccVerLinksIBranchId", Name = "idx__etblGLmSCOAGLAccVerLinks__etblGLmSCOAGLAccVerLinks_iBranchID")]
[Index("EtblGlmScoaglaccVerLinksIChangeSetId", Name = "idx__etblGLmSCOAGLAccVerLinks__etblGLmSCOAGLAccVerLinks_iChangeSetID")]
public partial class EtblGlmScoaglaccVerLink
{
    [Key]
    [Column("idGLAccVerLink")]
    public int IdGlaccVerLink { get; set; }

    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Column("imSCOAVersionID")]
    public int ImScoaversionId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_iBranchID")]
    public int? EtblGlmScoaglaccVerLinksIBranchId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlmScoaglaccVerLinksDCreatedDate { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlmScoaglaccVerLinksDModifiedDate { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_iCreatedBranchID")]
    public int? EtblGlmScoaglaccVerLinksICreatedBranchId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_iModifiedBranchID")]
    public int? EtblGlmScoaglaccVerLinksIModifiedBranchId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_iCreatedAgentID")]
    public int? EtblGlmScoaglaccVerLinksICreatedAgentId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_iModifiedAgentID")]
    public int? EtblGlmScoaglaccVerLinksIModifiedAgentId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_iChangeSetID")]
    public int? EtblGlmScoaglaccVerLinksIChangeSetId { get; set; }

    [Column("_etblGLmSCOAGLAccVerLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlmScoaglaccVerLinksChecksum { get; set; }
}
