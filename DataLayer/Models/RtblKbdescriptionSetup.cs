using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblKBDescriptionSetup")]
[Index("RtblKbdescriptionSetupChecksum", Name = "idx__rtblKBDescriptionSetup__rtblKBDescriptionSetup_Checksum")]
[Index("RtblKbdescriptionSetupIChangeSetId", Name = "idx__rtblKBDescriptionSetup_iChangeSetID")]
[Index("RtblKbdescriptionSetupDModifiedDate", Name = "idx_rtblKBDescriptionSetup_dModifiedDate")]
[Index("RtblKbdescriptionSetupIBranchId", Name = "idx_rtblKBDescriptionSetup_iBranchID")]
public partial class RtblKbdescriptionSetup
{
    [Key]
    [Column("idKBDescriptionSetup")]
    public int IdKbdescriptionSetup { get; set; }

    [Column("idDescription")]
    public int IdDescription { get; set; }

    [Column("cDescriptionLabel")]
    [StringLength(35)]
    [Unicode(false)]
    public string CDescriptionLabel { get; set; } = null!;

    [Column("bInUse")]
    public bool BInUse { get; set; }

    [Column("_rtblKBDescriptionSetup_iBranchID")]
    public int? RtblKbdescriptionSetupIBranchId { get; set; }

    [Column("_rtblKBDescriptionSetup_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblKbdescriptionSetupDCreatedDate { get; set; }

    [Column("_rtblKBDescriptionSetup_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblKbdescriptionSetupDModifiedDate { get; set; }

    [Column("_rtblKBDescriptionSetup_iCreatedBranchID")]
    public int? RtblKbdescriptionSetupICreatedBranchId { get; set; }

    [Column("_rtblKBDescriptionSetup_iModifiedBranchID")]
    public int? RtblKbdescriptionSetupIModifiedBranchId { get; set; }

    [Column("_rtblKBDescriptionSetup_iCreatedAgentID")]
    public int? RtblKbdescriptionSetupICreatedAgentId { get; set; }

    [Column("_rtblKBDescriptionSetup_iModifiedAgentID")]
    public int? RtblKbdescriptionSetupIModifiedAgentId { get; set; }

    [Column("_rtblKBDescriptionSetup_iChangeSetID")]
    public int? RtblKbdescriptionSetupIChangeSetId { get; set; }

    [Column("_rtblKBDescriptionSetup_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblKbdescriptionSetupChecksum { get; set; }
}
