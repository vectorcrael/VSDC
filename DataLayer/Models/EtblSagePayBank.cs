using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSagePayBanks")]
[Index("EtblSagePayBanksChecksum", Name = "idx__etblSagePayBanks__etblSagePayBanks_Checksum")]
[Index("EtblSagePayBanksDModifiedDate", Name = "idx__etblSagePayBanks__etblSagePayBanks_dModifiedDate")]
[Index("EtblSagePayBanksIBranchId", Name = "idx__etblSagePayBanks__etblSagePayBanks_iBranchID")]
[Index("EtblSagePayBanksIChangeSetId", Name = "idx__etblSagePayBanks__etblSagePayBanks_iChangeSetID")]
public partial class EtblSagePayBank
{
    [Key]
    [Column("SagePayBankID")]
    public int SagePayBankId { get; set; }

    public short? CountryCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankNameDisplay { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankNameFile { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("_etblSagePayBanks_iBranchID")]
    public int? EtblSagePayBanksIBranchId { get; set; }

    [Column("_etblSagePayBanks_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayBanksDCreatedDate { get; set; }

    [Column("_etblSagePayBanks_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayBanksDModifiedDate { get; set; }

    [Column("_etblSagePayBanks_iCreatedBranchID")]
    public int? EtblSagePayBanksICreatedBranchId { get; set; }

    [Column("_etblSagePayBanks_iModifiedBranchID")]
    public int? EtblSagePayBanksIModifiedBranchId { get; set; }

    [Column("_etblSagePayBanks_iCreatedAgentID")]
    public int? EtblSagePayBanksICreatedAgentId { get; set; }

    [Column("_etblSagePayBanks_iModifiedAgentID")]
    public int? EtblSagePayBanksIModifiedAgentId { get; set; }

    [Column("_etblSagePayBanks_iChangeSetID")]
    public int? EtblSagePayBanksIChangeSetId { get; set; }

    [Column("_etblSagePayBanks_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSagePayBanksChecksum { get; set; }
}
