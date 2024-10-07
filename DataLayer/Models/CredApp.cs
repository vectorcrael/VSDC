using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CredApp")]
[Index("CredAppDModifiedDate", Name = "idxCredApp_dModifiedDate")]
[Index("CredAppIBranchId", Name = "idxCredApp_iBranchID")]
[Index("CredAppChecksum", Name = "idx_CredApp_CredApp_Checksum")]
[Index("CredAppIChangeSetId", Name = "idx_CredApp_iChangeSetID")]
public partial class CredApp
{
    [Key]
    public int Autoidx { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TypeofBus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AccountNo { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? TradeName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegAdd1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegAdd2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegAdd3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegAdd4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegAdd5 { get; set; }

    [Column("RegAddPC")]
    [StringLength(30)]
    [Unicode(false)]
    public string? RegAddPc { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateBusStart { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Physical1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Physical2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Physical3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Physical4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Physical5 { get; set; }

    [Column("PhysicalPC")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PhysicalPc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Postal1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Postal2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Postal3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Postal4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Postal5 { get; set; }

    [Column("PostalPC")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PostalPc { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TaxNumber { get; set; }

    public int? BankLink { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccNum { get; set; }

    public short? Terms { get; set; }

    public double? CreditLimit { get; set; }

    public double? MonthlyPur { get; set; }

    public double? Score { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ScoreDesc { get; set; }

    public double? ScoreOutOf { get; set; }

    public short? Granted { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateGranted { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ApplicationDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AuditorName { get; set; }

    public bool? LatestFinan { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankContact { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? BankDate { get; set; }

    public double? BankAmount { get; set; }

    [Column("BankRD")]
    public bool? BankRd { get; set; }

    public short? BankCode { get; set; }

    [Column(TypeName = "text")]
    public string? OwnerList { get; set; }

    [Column(TypeName = "text")]
    public string? TradeList { get; set; }

    [Column(TypeName = "text")]
    public string? ScoreCard { get; set; }

    [Column(TypeName = "text")]
    public string? ScoreSummary { get; set; }

    public bool? Judgement { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JudgementDet1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JudgementDet2 { get; set; }

    public bool? International { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TypeofBus2 { get; set; }

    [Column("JSEListDate", TypeName = "smalldatetime")]
    public DateTime? JselistDate { get; set; }

    public bool? SameOwner { get; set; }

    [Column("CredApp_iBranchID")]
    public int? CredAppIBranchId { get; set; }

    [Column("CredApp_dCreatedDate", TypeName = "datetime")]
    public DateTime? CredAppDCreatedDate { get; set; }

    [Column("CredApp_dModifiedDate", TypeName = "datetime")]
    public DateTime? CredAppDModifiedDate { get; set; }

    [Column("CredApp_iCreatedBranchID")]
    public int? CredAppICreatedBranchId { get; set; }

    [Column("CredApp_iModifiedBranchID")]
    public int? CredAppIModifiedBranchId { get; set; }

    [Column("CredApp_iCreatedAgentID")]
    public int? CredAppICreatedAgentId { get; set; }

    [Column("CredApp_iModifiedAgentID")]
    public int? CredAppIModifiedAgentId { get; set; }

    [Column("CredApp_iChangeSetID")]
    public int? CredAppIChangeSetId { get; set; }

    [Column("CredApp_Checksum")]
    [MaxLength(20)]
    public byte[]? CredAppChecksum { get; set; }
}
