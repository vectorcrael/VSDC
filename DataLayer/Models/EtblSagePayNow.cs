using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSagePayNow")]
[Index("EtblSagePayNowChecksum", Name = "idx__etblSagePayNow__etblSagePayNow_Checksum")]
[Index("EtblSagePayNowDModifiedDate", Name = "idx__etblSagePayNow__etblSagePayNow_dModifiedDate")]
[Index("EtblSagePayNowIBranchId", Name = "idx__etblSagePayNow__etblSagePayNow_iBranchID")]
[Index("EtblSagePayNowIChangeSetId", Name = "idx__etblSagePayNow__etblSagePayNow_iChangeSetID")]
public partial class EtblSagePayNow
{
    [Key]
    [Column("idSagePayNow")]
    public int IdSagePayNow { get; set; }

    [Column("InvNumID")]
    public long InvNumId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UniqueReference { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankStatementRef { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardHoldersEmailAddress { get; set; }

    [Unicode(false)]
    public string? Extra1DebtorsRef { get; set; }

    [Unicode(false)]
    public string? Extra2 { get; set; }

    [Unicode(false)]
    public string? Extra3 { get; set; }

    [Column("AcceptDeclineURLParams")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AcceptDeclineUrlparams { get; set; }

    [Column("PCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Pcode { get; set; }

    [Column(TypeName = "xml")]
    public string? PayNowResponse { get; set; }

    public int DocType { get; set; }

    [Column("_etblSagePayNow_iBranchID")]
    public int? EtblSagePayNowIBranchId { get; set; }

    [Column("_etblSagePayNow_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayNowDCreatedDate { get; set; }

    [Column("_etblSagePayNow_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayNowDModifiedDate { get; set; }

    [Column("_etblSagePayNow_iCreatedBranchID")]
    public int? EtblSagePayNowICreatedBranchId { get; set; }

    [Column("_etblSagePayNow_iModifiedBranchID")]
    public int? EtblSagePayNowIModifiedBranchId { get; set; }

    [Column("_etblSagePayNow_iCreatedAgentID")]
    public int? EtblSagePayNowICreatedAgentId { get; set; }

    [Column("_etblSagePayNow_iModifiedAgentID")]
    public int? EtblSagePayNowIModifiedAgentId { get; set; }

    [Column("_etblSagePayNow_iChangeSetID")]
    public int? EtblSagePayNowIChangeSetId { get; set; }

    [Column("_etblSagePayNow_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSagePayNowChecksum { get; set; }
}
