using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("BankMain")]
[Index("BankMainDModifiedDate", Name = "idxBankMain_dModifiedDate")]
[Index("BankMainIBranchId", Name = "idxBankMain_iBranchID")]
[Index("BankMainChecksum", Name = "idx_BankMain_BankMain_Checksum")]
[Index("BankMainIChangeSetId", Name = "idx_BankMain_iChangeSetID")]
public partial class BankMain
{
    [Key]
    public int Counter { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? Branch { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ActiveBank { get; set; }

    [Column("BankMain_iBranchID")]
    public int? BankMainIBranchId { get; set; }

    [Column("BankMain_dCreatedDate", TypeName = "datetime")]
    public DateTime? BankMainDCreatedDate { get; set; }

    [Column("BankMain_dModifiedDate", TypeName = "datetime")]
    public DateTime? BankMainDModifiedDate { get; set; }

    [Column("BankMain_iCreatedBranchID")]
    public int? BankMainICreatedBranchId { get; set; }

    [Column("BankMain_iModifiedBranchID")]
    public int? BankMainIModifiedBranchId { get; set; }

    [Column("BankMain_iCreatedAgentID")]
    public int? BankMainICreatedAgentId { get; set; }

    [Column("BankMain_iModifiedAgentID")]
    public int? BankMainIModifiedAgentId { get; set; }

    [Column("BankMain_iChangeSetID")]
    public int? BankMainIChangeSetId { get; set; }

    [Column("BankMain_Checksum")]
    [MaxLength(20)]
    public byte[]? BankMainChecksum { get; set; }

    [Column("iSagePayBank")]
    public int? ISagePayBank { get; set; }
}
