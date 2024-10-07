using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAgentDocProfiles")]
[Index("EtblAgentDocProfilesChecksum", Name = "idx__etblAgentDocProfiles__etblAgentDocProfiles_Checksum")]
[Index("EtblAgentDocProfilesDModifiedDate", Name = "idx__etblAgentDocProfiles__etblAgentDocProfiles_dModifiedDate")]
[Index("EtblAgentDocProfilesIBranchId", Name = "idx__etblAgentDocProfiles__etblAgentDocProfiles_iBranchID")]
[Index("EtblAgentDocProfilesIChangeSetId", Name = "idx__etblAgentDocProfiles__etblAgentDocProfiles_iChangeSetID")]
[Index("IAgentId", "IDocProfileId", "BActiveDocProfile", Name = "idx__etblAgentDocProfiles_iAgentIDiDocProfileIDbActiveDocProfile")]
public partial class EtblAgentDocProfile
{
    [Key]
    [Column("idAgentDocProfiles")]
    public int IdAgentDocProfiles { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("iDocProfileID")]
    public int IDocProfileId { get; set; }

    [Column("bActiveDocProfile")]
    public bool BActiveDocProfile { get; set; }

    [Column("_etblAgentDocProfiles_iBranchID")]
    public int? EtblAgentDocProfilesIBranchId { get; set; }

    [Column("_etblAgentDocProfiles_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAgentDocProfilesDCreatedDate { get; set; }

    [Column("_etblAgentDocProfiles_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAgentDocProfilesDModifiedDate { get; set; }

    [Column("_etblAgentDocProfiles_iCreatedBranchID")]
    public int? EtblAgentDocProfilesICreatedBranchId { get; set; }

    [Column("_etblAgentDocProfiles_iModifiedBranchID")]
    public int? EtblAgentDocProfilesIModifiedBranchId { get; set; }

    [Column("_etblAgentDocProfiles_iCreatedAgentID")]
    public int? EtblAgentDocProfilesICreatedAgentId { get; set; }

    [Column("_etblAgentDocProfiles_iModifiedAgentID")]
    public int? EtblAgentDocProfilesIModifiedAgentId { get; set; }

    [Column("_etblAgentDocProfiles_iChangeSetID")]
    public int? EtblAgentDocProfilesIChangeSetId { get; set; }

    [Column("_etblAgentDocProfiles_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAgentDocProfilesChecksum { get; set; }
}
