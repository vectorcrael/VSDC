using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RecurRL")]
[Index("RecurRlDModifiedDate", Name = "idxRecurRL_dModifiedDate")]
[Index("RecurRlIBranchId", Name = "idxRecurRL_iBranchID")]
[Index("RecurRlChecksum", Name = "idx_RecurRL_RecurRL_Checksum")]
[Index("RecurRlIChangeSetId", Name = "idx_RecurRL_iChangeSetID")]
public partial class RecurRl
{
    [Key]
    public int AutoIdx { get; set; }

    public bool Suspend { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastUpd { get; set; }

    public int? State { get; set; }

    public int? Module { get; set; }

    public int? Account { get; set; }

    public int? ChgType { get; set; }

    public int? Template { get; set; }

    public int? Config { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ActDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TermDate { get; set; }

    public int? OccurCnt { get; set; }

    [Column("iContractID")]
    public int? IContractId { get; set; }

    [Column("bCreateAsOrder")]
    public bool BCreateAsOrder { get; set; }

    [Column("bDebitOrder")]
    public bool BDebitOrder { get; set; }

    [Column("bCreatePayment")]
    public bool BCreatePayment { get; set; }

    [Column("bAllowSettlementTerms")]
    public bool BAllowSettlementTerms { get; set; }

    [Column("RecurRL_iBranchID")]
    public int? RecurRlIBranchId { get; set; }

    [Column("RecurRL_dCreatedDate", TypeName = "datetime")]
    public DateTime? RecurRlDCreatedDate { get; set; }

    [Column("RecurRL_dModifiedDate", TypeName = "datetime")]
    public DateTime? RecurRlDModifiedDate { get; set; }

    [Column("RecurRL_iCreatedBranchID")]
    public int? RecurRlICreatedBranchId { get; set; }

    [Column("RecurRL_iModifiedBranchID")]
    public int? RecurRlIModifiedBranchId { get; set; }

    [Column("RecurRL_iCreatedAgentID")]
    public int? RecurRlICreatedAgentId { get; set; }

    [Column("RecurRL_iModifiedAgentID")]
    public int? RecurRlIModifiedAgentId { get; set; }

    [Column("RecurRL_iChangeSetID")]
    public int? RecurRlIChangeSetId { get; set; }

    [Column("RecurRL_Checksum")]
    [MaxLength(20)]
    public byte[]? RecurRlChecksum { get; set; }
}
