using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("WHT_DefaultSettings")]
[Index("WhtDefaultSettingsChecksum", Name = "idx_WHT_DefaultSettings_WHT_DefaultSettings_Checksum")]
[Index("WhtDefaultSettingsDModifiedDate", Name = "idx_WHT_DefaultSettings_WHT_DefaultSettings_dModifiedDate")]
[Index("WhtDefaultSettingsIBranchId", Name = "idx_WHT_DefaultSettings_WHT_DefaultSettings_iBranchID")]
[Index("WhtDefaultSettingsIChangeSetId", Name = "idx_WHT_DefaultSettings_WHT_DefaultSettings_iChangeSetID")]
public partial class WhtDefaultSetting
{
    [Column("idAccountLink")]
    public int? IdAccountLink { get; set; }

    [Column("idVendorGLAccount")]
    public int? IdVendorGlaccount { get; set; }

    [Column("idTrCodes")]
    public int? IdTrCodes { get; set; }

    [StringLength(41)]
    public string? SubAccount { get; set; }

    [StringLength(21)]
    public string? Account { get; set; }

    [StringLength(50)]
    public string? AccountType { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    [StringLength(4)]
    public string? TrCode { get; set; }

    [StringLength(100)]
    public string? TrCodeDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CutOffDate { get; set; }

    [Column("isGlItemToShow")]
    public bool? IsGlItemToShow { get; set; }

    [Column("isStItemToShow")]
    public bool? IsStItemToShow { get; set; }

    [Column("isServiceItemToShow")]
    public bool? IsServiceItemToShow { get; set; }

    [Column("WHT_DefaultSettings_iBranchID")]
    public int? WhtDefaultSettingsIBranchId { get; set; }

    [Column("WHT_DefaultSettings_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhtDefaultSettingsDCreatedDate { get; set; }

    [Column("WHT_DefaultSettings_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhtDefaultSettingsDModifiedDate { get; set; }

    [Column("WHT_DefaultSettings_iCreatedBranchID")]
    public int? WhtDefaultSettingsICreatedBranchId { get; set; }

    [Column("WHT_DefaultSettings_iModifiedBranchID")]
    public int? WhtDefaultSettingsIModifiedBranchId { get; set; }

    [Column("WHT_DefaultSettings_iCreatedAgentID")]
    public int? WhtDefaultSettingsICreatedAgentId { get; set; }

    [Column("WHT_DefaultSettings_iModifiedAgentID")]
    public int? WhtDefaultSettingsIModifiedAgentId { get; set; }

    [Column("WHT_DefaultSettings_iChangeSetID")]
    public int? WhtDefaultSettingsIChangeSetId { get; set; }

    [Column("WHT_DefaultSettings_Checksum")]
    [MaxLength(20)]
    public byte[]? WhtDefaultSettingsChecksum { get; set; }
}
