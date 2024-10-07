using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblAgentOutOfficeReasons")]
[Index("BtblAgentOutOfficeReasonsChecksum", Name = "idx__btblAgentOutOfficeReasons__btblAgentOutOfficeReasons_Checksum")]
[Index("BtblAgentOutOfficeReasonsIChangeSetId", Name = "idx__btblAgentOutOfficeReasons_iChangeSetID")]
[Index("BtblAgentOutOfficeReasonsDModifiedDate", Name = "idx_btblAgentOutOfficeReasons_dModifiedDate")]
[Index("BtblAgentOutOfficeReasonsIBranchId", Name = "idx_btblAgentOutOfficeReasons_iBranchID")]
public partial class BtblAgentOutOfficeReason
{
    [Key]
    [Column("iAgentOutOfficeID")]
    public int IAgentOutOfficeId { get; set; }

    [Column("cReason")]
    [StringLength(50)]
    [Unicode(false)]
    public string CReason { get; set; } = null!;

    [Column("_btblAgentOutOfficeReasons_iBranchID")]
    public int? BtblAgentOutOfficeReasonsIBranchId { get; set; }

    [Column("_btblAgentOutOfficeReasons_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblAgentOutOfficeReasonsDCreatedDate { get; set; }

    [Column("_btblAgentOutOfficeReasons_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblAgentOutOfficeReasonsDModifiedDate { get; set; }

    [Column("_btblAgentOutOfficeReasons_iCreatedBranchID")]
    public int? BtblAgentOutOfficeReasonsICreatedBranchId { get; set; }

    [Column("_btblAgentOutOfficeReasons_iModifiedBranchID")]
    public int? BtblAgentOutOfficeReasonsIModifiedBranchId { get; set; }

    [Column("_btblAgentOutOfficeReasons_iCreatedAgentID")]
    public int? BtblAgentOutOfficeReasonsICreatedAgentId { get; set; }

    [Column("_btblAgentOutOfficeReasons_iModifiedAgentID")]
    public int? BtblAgentOutOfficeReasonsIModifiedAgentId { get; set; }

    [Column("_btblAgentOutOfficeReasons_iChangeSetID")]
    public int? BtblAgentOutOfficeReasonsIChangeSetId { get; set; }

    [Column("_btblAgentOutOfficeReasons_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblAgentOutOfficeReasonsChecksum { get; set; }
}
