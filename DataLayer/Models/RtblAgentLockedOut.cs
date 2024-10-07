using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblAgentLockedOut")]
[Index("RtblAgentLockedOutChecksum", Name = "idx__rtblAgentLockedOut__rtblAgentLockedOut_Checksum")]
[Index("RtblAgentLockedOutDModifiedDate", Name = "idx__rtblAgentLockedOut__rtblAgentLockedOut_dModifiedDate")]
[Index("RtblAgentLockedOutIBranchId", Name = "idx__rtblAgentLockedOut__rtblAgentLockedOut_iBranchID")]
[Index("RtblAgentLockedOutIChangeSetId", Name = "idx__rtblAgentLockedOut__rtblAgentLockedOut_iChangeSetID")]
public partial class RtblAgentLockedOut
{
    [Key]
    [Column("IDAgentLockedOut")]
    public int IdagentLockedOut { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("dLockedOutDate", TypeName = "datetime")]
    public DateTime DLockedOutDate { get; set; }

    [Column("dUnlockedOutDate", TypeName = "datetime")]
    public DateTime? DUnlockedOutDate { get; set; }

    [Column("iUnlockOutAgentID")]
    public int? IUnlockOutAgentId { get; set; }

    [Column("_rtblAgentLockedOut_iBranchID")]
    public int? RtblAgentLockedOutIBranchId { get; set; }

    [Column("_rtblAgentLockedOut_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblAgentLockedOutDCreatedDate { get; set; }

    [Column("_rtblAgentLockedOut_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblAgentLockedOutDModifiedDate { get; set; }

    [Column("_rtblAgentLockedOut_iCreatedBranchID")]
    public int? RtblAgentLockedOutICreatedBranchId { get; set; }

    [Column("_rtblAgentLockedOut_iModifiedBranchID")]
    public int? RtblAgentLockedOutIModifiedBranchId { get; set; }

    [Column("_rtblAgentLockedOut_iCreatedAgentID")]
    public int? RtblAgentLockedOutICreatedAgentId { get; set; }

    [Column("_rtblAgentLockedOut_iModifiedAgentID")]
    public int? RtblAgentLockedOutIModifiedAgentId { get; set; }

    [Column("_rtblAgentLockedOut_iChangeSetID")]
    public int? RtblAgentLockedOutIChangeSetId { get; set; }

    [Column("_rtblAgentLockedOut_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblAgentLockedOutChecksum { get; set; }
}
