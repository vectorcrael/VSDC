using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblAgentGroups")]
[Index("RtblAgentGroupsChecksum", Name = "idx__rtblAgentGroups__rtblAgentGroups_Checksum")]
[Index("RtblAgentGroupsIChangeSetId", Name = "idx__rtblAgentGroups_iChangeSetID")]
[Index("RtblAgentGroupsDModifiedDate", Name = "idx_rtblAgentGroups_dModifiedDate")]
[Index("RtblAgentGroupsIBranchId", Name = "idx_rtblAgentGroups_iBranchID")]
public partial class RtblAgentGroup
{
    [Key]
    [Column("idAgentGroups")]
    public int IdAgentGroups { get; set; }

    [Column("bSysGroup")]
    public bool BSysGroup { get; set; }

    [Column("cGroupName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CGroupName { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cComments")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CComments { get; set; }

    [Column("bCanAssign")]
    public bool BCanAssign { get; set; }

    [Column("iAssignRule")]
    public int IAssignRule { get; set; }

    [Column("iAssignAgent")]
    public int? IAssignAgent { get; set; }

    [Column("bUseDefaultTree")]
    public bool BUseDefaultTree { get; set; }

    [Column("bCBGrpAllVisible")]
    public bool BCbgrpAllVisible { get; set; }

    [Column("bCBGrpNoneVisible")]
    public bool BCbgrpNoneVisible { get; set; }

    [Column("bJRGrpAllVisible")]
    public bool BJrgrpAllVisible { get; set; }

    [Column("bJRGrpNoneVisible")]
    public bool BJrgrpNoneVisible { get; set; }

    [Column("bCBGrpAgentVisible")]
    public bool BCbgrpAgentVisible { get; set; }

    [Column("bJRGrpAgentVisible")]
    public bool BJrgrpAgentVisible { get; set; }

    [Column("iPOAuthType")]
    public int IPoauthType { get; set; }

    [Column("iPOIncidentTypeID")]
    public int? IPoincidentTypeId { get; set; }

    [Column("bPOExclusive")]
    public bool BPoexclusive { get; set; }

    [Column("fPOLimit")]
    public double? FPolimit { get; set; }

    [Column("bPOUseDefaults")]
    public bool BPouseDefaults { get; set; }

    [Column("_rtblAgentGroups_iBranchID")]
    public int? RtblAgentGroupsIBranchId { get; set; }

    [Column("_rtblAgentGroups_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblAgentGroupsDCreatedDate { get; set; }

    [Column("_rtblAgentGroups_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblAgentGroupsDModifiedDate { get; set; }

    [Column("_rtblAgentGroups_iCreatedBranchID")]
    public int? RtblAgentGroupsICreatedBranchId { get; set; }

    [Column("_rtblAgentGroups_iModifiedBranchID")]
    public int? RtblAgentGroupsIModifiedBranchId { get; set; }

    [Column("_rtblAgentGroups_iCreatedAgentID")]
    public int? RtblAgentGroupsICreatedAgentId { get; set; }

    [Column("_rtblAgentGroups_iModifiedAgentID")]
    public int? RtblAgentGroupsIModifiedAgentId { get; set; }

    [Column("_rtblAgentGroups_iChangeSetID")]
    public int? RtblAgentGroupsIChangeSetId { get; set; }

    [Column("idPOSMenuSetup")]
    public int? IdPosmenuSetup { get; set; }

    [Column("_rtblAgentGroups_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblAgentGroupsChecksum { get; set; }
}
