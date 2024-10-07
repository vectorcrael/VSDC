using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Refer")]
[Index("ReferDModifiedDate", Name = "idxRefer_dModifiedDate")]
[Index("ReferIBranchId", Name = "idxRefer_iBranchID")]
[Index("ReferChecksum", Name = "idx_Refer_Refer_Checksum")]
[Index("ReferIChangeSetId", Name = "idx_Refer_iChangeSetID")]
public partial class Refer
{
    [Key]
    public int AutoIdx { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DebtorAccNo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NameOfRef { get; set; }

    [Column("IDNumber")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Idnumber { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    public double? PerShare { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    public double? CreditLimit { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Rating { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CreditGranted { get; set; }

    public int? PunctPayment { get; set; }

    [Column("Refer_iBranchID")]
    public int? ReferIBranchId { get; set; }

    [Column("Refer_dCreatedDate", TypeName = "datetime")]
    public DateTime? ReferDCreatedDate { get; set; }

    [Column("Refer_dModifiedDate", TypeName = "datetime")]
    public DateTime? ReferDModifiedDate { get; set; }

    [Column("Refer_iCreatedBranchID")]
    public int? ReferICreatedBranchId { get; set; }

    [Column("Refer_iModifiedBranchID")]
    public int? ReferIModifiedBranchId { get; set; }

    [Column("Refer_iCreatedAgentID")]
    public int? ReferICreatedAgentId { get; set; }

    [Column("Refer_iModifiedAgentID")]
    public int? ReferIModifiedAgentId { get; set; }

    [Column("Refer_iChangeSetID")]
    public int? ReferIChangeSetId { get; set; }

    [Column("Refer_Checksum")]
    [MaxLength(20)]
    public byte[]? ReferChecksum { get; set; }
}
