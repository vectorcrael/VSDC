using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGSTPrepayments")]
[Index("EtblGstprepaymentsChecksum", Name = "idx__etblGSTPrepayments__etblGSTPrepayments_Checksum")]
[Index("EtblGstprepaymentsDModifiedDate", Name = "idx__etblGSTPrepayments__etblGSTPrepayments_dModifiedDate")]
[Index("EtblGstprepaymentsIBranchId", Name = "idx__etblGSTPrepayments__etblGSTPrepayments_iBranchID")]
[Index("EtblGstprepaymentsIChangeSetId", Name = "idx__etblGSTPrepayments__etblGSTPrepayments_iChangeSetID")]
public partial class EtblGstprepayment
{
    [Key]
    [Column("idGSTPrepayments")]
    public int IdGstprepayments { get; set; }

    [Column("iPostARPrepayID")]
    public int? IPostArprepayId { get; set; }

    [Column("iPostARInvID")]
    public int? IPostArinvId { get; set; }

    [Column("iTaxPeriodID")]
    public int? ITaxPeriodId { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("fTaxAmount")]
    public double? FTaxAmount { get; set; }

    [Column("_etblGSTPrepayments_iBranchID")]
    public int? EtblGstprepaymentsIBranchId { get; set; }

    [Column("_etblGSTPrepayments_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGstprepaymentsDCreatedDate { get; set; }

    [Column("_etblGSTPrepayments_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGstprepaymentsDModifiedDate { get; set; }

    [Column("_etblGSTPrepayments_iCreatedBranchID")]
    public int? EtblGstprepaymentsICreatedBranchId { get; set; }

    [Column("_etblGSTPrepayments_iModifiedBranchID")]
    public int? EtblGstprepaymentsIModifiedBranchId { get; set; }

    [Column("_etblGSTPrepayments_iCreatedAgentID")]
    public int? EtblGstprepaymentsICreatedAgentId { get; set; }

    [Column("_etblGSTPrepayments_iModifiedAgentID")]
    public int? EtblGstprepaymentsIModifiedAgentId { get; set; }

    [Column("_etblGSTPrepayments_iChangeSetID")]
    public int? EtblGstprepaymentsIChangeSetId { get; set; }

    [Column("_etblGSTPrepayments_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGstprepaymentsChecksum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TxDate { get; set; }

    [Column("iUnallocTaxPeriodID")]
    public int IUnallocTaxPeriodId { get; set; }

    [Column("fAmountForeign")]
    public double FAmountForeign { get; set; }

    [Column("fTaxAmountForeign")]
    public double FTaxAmountForeign { get; set; }

    [Column("fUnAllocAmountForeign")]
    public double FUnAllocAmountForeign { get; set; }

    [Column("fUnAllocTaxAmountForeign")]
    public double FUnAllocTaxAmountForeign { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AllocTxDate { get; set; }

    [Column("fUnAllocAmount")]
    public double FUnAllocAmount { get; set; }

    [Column("fUnAllocTaxAmount")]
    public double FUnAllocTaxAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UnallocTxDate { get; set; }
}
