using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCMIncidentTypeGroup")]
[Index("BtblCmincidentTypeGroupChecksum", Name = "idx__btblCMIncidentTypeGroup__btblCMIncidentTypeGroup_Checksum")]
[Index("BtblCmincidentTypeGroupIChangeSetId", Name = "idx__btblCMIncidentTypeGroup_iChangeSetID")]
[Index("BtblCmincidentTypeGroupDModifiedDate", Name = "idx_btblCMIncidentTypeGroup_dModifiedDate")]
[Index("BtblCmincidentTypeGroupIBranchId", Name = "idx_btblCMIncidentTypeGroup_iBranchID")]
public partial class BtblCmincidentTypeGroup
{
    [Key]
    [Column("idIncidentTypeGroup")]
    public int IdIncidentTypeGroup { get; set; }

    [Column("cName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_btblCMIncidentTypeGroup_iBranchID")]
    public int? BtblCmincidentTypeGroupIBranchId { get; set; }

    [Column("_btblCMIncidentTypeGroup_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCmincidentTypeGroupDCreatedDate { get; set; }

    [Column("_btblCMIncidentTypeGroup_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCmincidentTypeGroupDModifiedDate { get; set; }

    [Column("_btblCMIncidentTypeGroup_iCreatedBranchID")]
    public int? BtblCmincidentTypeGroupICreatedBranchId { get; set; }

    [Column("_btblCMIncidentTypeGroup_iModifiedBranchID")]
    public int? BtblCmincidentTypeGroupIModifiedBranchId { get; set; }

    [Column("_btblCMIncidentTypeGroup_iCreatedAgentID")]
    public int? BtblCmincidentTypeGroupICreatedAgentId { get; set; }

    [Column("_btblCMIncidentTypeGroup_iModifiedAgentID")]
    public int? BtblCmincidentTypeGroupIModifiedAgentId { get; set; }

    [Column("_btblCMIncidentTypeGroup_iChangeSetID")]
    public int? BtblCmincidentTypeGroupIChangeSetId { get; set; }

    [Column("_btblCMIncidentTypeGroup_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmincidentTypeGroupChecksum { get; set; }
}
