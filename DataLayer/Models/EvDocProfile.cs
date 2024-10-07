using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvDocProfile
{
    [Column("idDocProfiles")]
    public int IdDocProfiles { get; set; }

    [Column("cCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(120)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("iDocType")]
    public int IDocType { get; set; }

    [Column("iDocSubType")]
    public int IDocSubType { get; set; }

    [Column("bUseDefaults")]
    public bool BUseDefaults { get; set; }

    [Column("bAutoNum")]
    public bool BAutoNum { get; set; }

    [Column("iNextAutoNum")]
    public int? INextAutoNum { get; set; }

    [Column("iAutoNumPadLength")]
    public int? IAutoNumPadLength { get; set; }

    [Column("cAutoNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumPrefix { get; set; }

    [Column("bUniqueNum")]
    public bool? BUniqueNum { get; set; }

    [Column("iDocTrCodeID")]
    public int? IDocTrCodeId { get; set; }

    [Column("iDocHomeLayoutID")]
    public int? IDocHomeLayoutId { get; set; }

    [Column("bDocHomeLayoutPrompt")]
    public bool BDocHomeLayoutPrompt { get; set; }

    [Column("iDocForeignLayoutID")]
    public int? IDocForeignLayoutId { get; set; }

    [Column("bDocForeignLayoutPrompt")]
    public bool BDocForeignLayoutPrompt { get; set; }

    [Column("iExclusiveDoc")]
    public int? IExclusiveDoc { get; set; }

    [Column("iTaxPerDoc")]
    public int? ITaxPerDoc { get; set; }

    [Column("bHasBeenUsed")]
    public bool BHasBeenUsed { get; set; }

    [Column("_etblDocProfiles_iBranchID")]
    public int? EtblDocProfilesIBranchId { get; set; }

    [Column("_etblDocProfiles_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblDocProfilesDCreatedDate { get; set; }

    [Column("_etblDocProfiles_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblDocProfilesDModifiedDate { get; set; }

    [Column("_etblDocProfiles_iCreatedBranchID")]
    public int? EtblDocProfilesICreatedBranchId { get; set; }

    [Column("_etblDocProfiles_iModifiedBranchID")]
    public int? EtblDocProfilesIModifiedBranchId { get; set; }

    [Column("_etblDocProfiles_iCreatedAgentID")]
    public int? EtblDocProfilesICreatedAgentId { get; set; }

    [Column("_etblDocProfiles_iModifiedAgentID")]
    public int? EtblDocProfilesIModifiedAgentId { get; set; }

    [Column("_etblDocProfiles_iChangeSetID")]
    public int? EtblDocProfilesIChangeSetId { get; set; }

    [Column("_etblDocProfiles_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblDocProfilesChecksum { get; set; }

    [Column("bIsUserLayout")]
    public bool BIsUserLayout { get; set; }

    [Column("bIsUserForeignLayout")]
    public bool BIsUserForeignLayout { get; set; }

    [Column("iDocHomeEmailLayoutID")]
    public int? IDocHomeEmailLayoutId { get; set; }

    [Column("bDocHomeEmailLayoutPrompt")]
    public bool BDocHomeEmailLayoutPrompt { get; set; }

    [Column("bIsUserEmailLayout")]
    public bool BIsUserEmailLayout { get; set; }

    [Column("iDocForeignEmailLayoutID")]
    public int? IDocForeignEmailLayoutId { get; set; }

    [Column("bDocForeignEmailLayoutPrompt")]
    public bool BDocForeignEmailLayoutPrompt { get; set; }

    [Column("bIsUserForeignEmailLayout")]
    public bool BIsUserForeignEmailLayout { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string? DocTypeDescription { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string? DocSubTypeDescription { get; set; }
}
