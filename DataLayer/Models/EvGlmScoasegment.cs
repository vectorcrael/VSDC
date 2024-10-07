using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvGlmScoasegment
{
    [Column("idGLmSCOAAccount")]
    public int IdGlmScoaaccount { get; set; }

    [Column("SCOAId")]
    [StringLength(50)]
    [Unicode(false)]
    public string Scoaid { get; set; } = null!;

    [Column("ParentSCOAId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParentScoaid { get; set; }

    [Unicode(false)]
    public string? DefinitionDescription { get; set; }

    [Column("SCOAFile")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Scoafile { get; set; }

    [Column("SCOAAccount")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Scoaaccount { get; set; }

    [Column("SCOALevel")]
    public int? Scoalevel { get; set; }

    public int? ExcelRowNumber { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ShortDescription { get; set; }

    [Column("VATStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Vatstatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BreakDownAllowed { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Principle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApplicableTo { get; set; }

    [Column("bPostingLevel")]
    public bool? BPostingLevel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PostingLevelDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AccountNumberPrefix { get; set; }

    public int? AccountNumber1 { get; set; }

    public int? AccountNumber2 { get; set; }

    public int? AccountNumber3 { get; set; }

    public int? AccountNumber4 { get; set; }

    public int? AccountNumber5 { get; set; }

    public int? AccountNumber6 { get; set; }

    public int? AccountNumber7 { get; set; }

    public int? AccountNumber8 { get; set; }

    public int? AccountNumber9 { get; set; }

    public int? AccountNumber10 { get; set; }

    public int? AccountNumber11 { get; set; }

    public int? AccountNumber12 { get; set; }

    [Column("GFSCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Gfscode { get; set; }

    [Column("MSCOACheck")]
    [MaxLength(20)]
    public byte[]? Mscoacheck { get; set; }

    public int? NextSubAccountNumber { get; set; }

    [Column("_etblGLmSCOAAccounts_iBranchID")]
    public int? EtblGlmScoaaccountsIBranchId { get; set; }

    [Column("_etblGLmSCOAAccounts_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlmScoaaccountsDCreatedDate { get; set; }

    [Column("_etblGLmSCOAAccounts_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlmScoaaccountsDModifiedDate { get; set; }

    [Column("_etblGLmSCOAAccounts_iCreatedBranchID")]
    public int? EtblGlmScoaaccountsICreatedBranchId { get; set; }

    [Column("_etblGLmSCOAAccounts_iModifiedBranchID")]
    public int? EtblGlmScoaaccountsIModifiedBranchId { get; set; }

    [Column("_etblGLmSCOAAccounts_iCreatedAgentID")]
    public int? EtblGlmScoaaccountsICreatedAgentId { get; set; }

    [Column("_etblGLmSCOAAccounts_iModifiedAgentID")]
    public int? EtblGlmScoaaccountsIModifiedAgentId { get; set; }

    [Column("_etblGLmSCOAAccounts_iChangeSetID")]
    public int? EtblGlmScoaaccountsIChangeSetId { get; set; }

    [Column("_etblGLmSCOAAccounts_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlmScoaaccountsChecksum { get; set; }

    [Column("imSCOAVerID")]
    public int ImScoaverId { get; set; }

    [Column("idSegment")]
    public int? IdSegment { get; set; }

    [Column("iSegmentNo")]
    public int? ISegmentNo { get; set; }

    [Column("cCode")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CCode { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblGLSegment_iBranchID")]
    public int? EtblGlsegmentIBranchId { get; set; }

    [Column("_etblGLSegment_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlsegmentDCreatedDate { get; set; }

    [Column("_etblGLSegment_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlsegmentDModifiedDate { get; set; }

    [Column("_etblGLSegment_iCreatedBranchID")]
    public int? EtblGlsegmentICreatedBranchId { get; set; }

    [Column("_etblGLSegment_iModifiedBranchID")]
    public int? EtblGlsegmentIModifiedBranchId { get; set; }

    [Column("_etblGLSegment_iCreatedAgentID")]
    public int? EtblGlsegmentICreatedAgentId { get; set; }

    [Column("_etblGLSegment_iModifiedAgentID")]
    public int? EtblGlsegmentIModifiedAgentId { get; set; }

    [Column("_etblGLSegment_iChangeSetID")]
    public int? EtblGlsegmentIChangeSetId { get; set; }

    [Column("iSegmentBranchID")]
    public int? ISegmentBranchId { get; set; }

    [Column("_etblGLSegment_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlsegmentChecksum { get; set; }

    [Column("imSCOAAccountID")]
    public int? ImScoaaccountId { get; set; }

    [Column("mSCOAId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MScoaid { get; set; }

    [Column("idmSCOAVersion")]
    public int? IdmScoaversion { get; set; }

    [Column("cVersionDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CVersionDescription { get; set; }

    [Column("bTransactingVersion")]
    public bool? BTransactingVersion { get; set; }

    [Column("bActive")]
    public bool? BActive { get; set; }

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
