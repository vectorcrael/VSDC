using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCcreminderType
{
    public int Autoidx { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("CredMnt_iBranchID")]
    public int? CredMntIBranchId { get; set; }

    [Column("CredMnt_dCreatedDate", TypeName = "datetime")]
    public DateTime? CredMntDCreatedDate { get; set; }

    [Column("CredMnt_dModifiedDate", TypeName = "datetime")]
    public DateTime? CredMntDModifiedDate { get; set; }

    [Column("CredMnt_iCreatedBranchID")]
    public int? CredMntICreatedBranchId { get; set; }

    [Column("CredMnt_iModifiedBranchID")]
    public int? CredMntIModifiedBranchId { get; set; }

    [Column("CredMnt_iCreatedAgentID")]
    public int? CredMntICreatedAgentId { get; set; }

    [Column("CredMnt_iModifiedAgentID")]
    public int? CredMntIModifiedAgentId { get; set; }

    [Column("CredMnt_iChangeSetID")]
    public int? CredMntIChangeSetId { get; set; }

    [Column("CredMnt_Checksum")]
    [MaxLength(20)]
    public byte[]? CredMntChecksum { get; set; }
}
