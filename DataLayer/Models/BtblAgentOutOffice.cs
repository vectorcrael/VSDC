using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblAgentOutOffice")]
[Index("BtblAgentOutOfficeChecksum", Name = "idx__btblAgentOutOffice__btblAgentOutOffice_Checksum")]
[Index("BtblAgentOutOfficeIChangeSetId", Name = "idx__btblAgentOutOffice_iChangeSetID")]
[Index("BtblAgentOutOfficeDModifiedDate", Name = "idx_btblAgentOutOffice_dModifiedDate")]
[Index("BtblAgentOutOfficeIBranchId", Name = "idx_btblAgentOutOffice_iBranchID")]
public partial class BtblAgentOutOffice
{
    [Key]
    [Column("IDAgentOutOffice")]
    public int IdagentOutOffice { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("dDateFrom", TypeName = "datetime")]
    public DateTime? DDateFrom { get; set; }

    [Column("dDateTo", TypeName = "datetime")]
    public DateTime? DDateTo { get; set; }

    [Column("iReason")]
    public int? IReason { get; set; }

    [Column("_btblAgentOutOffice_iBranchID")]
    public int? BtblAgentOutOfficeIBranchId { get; set; }

    [Column("_btblAgentOutOffice_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblAgentOutOfficeDCreatedDate { get; set; }

    [Column("_btblAgentOutOffice_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblAgentOutOfficeDModifiedDate { get; set; }

    [Column("_btblAgentOutOffice_iCreatedBranchID")]
    public int? BtblAgentOutOfficeICreatedBranchId { get; set; }

    [Column("_btblAgentOutOffice_iModifiedBranchID")]
    public int? BtblAgentOutOfficeIModifiedBranchId { get; set; }

    [Column("_btblAgentOutOffice_iCreatedAgentID")]
    public int? BtblAgentOutOfficeICreatedAgentId { get; set; }

    [Column("_btblAgentOutOffice_iModifiedAgentID")]
    public int? BtblAgentOutOfficeIModifiedAgentId { get; set; }

    [Column("_btblAgentOutOffice_iChangeSetID")]
    public int? BtblAgentOutOfficeIChangeSetId { get; set; }

    [Column("_btblAgentOutOffice_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblAgentOutOfficeChecksum { get; set; }
}
