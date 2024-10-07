using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retLayBys")]
[Index("RetLayBysChecksum", Name = "idx__retLayBys__retLayBys_Checksum")]
[Index("RetLayBysDModifiedDate", Name = "idx__retLayBys__retLayBys_dModifiedDate")]
[Index("RetLayBysIBranchId", Name = "idx__retLayBys__retLayBys_iBranchID")]
[Index("RetLayBysIChangeSetId", Name = "idx__retLayBys__retLayBys_iChangeSetID")]
[Index("IInvoiceId", Name = "idx__retLayBys_iInvoiceID")]
public partial class RetLayBy
{
    [Key]
    [Column("idLayBys")]
    public int IdLayBys { get; set; }

    [Column("iInvoiceID")]
    public long? IInvoiceId { get; set; }

    [Column("iTermCount")]
    public int? ITermCount { get; set; }

    [Column("iTermOnDay")]
    public int? ITermOnDay { get; set; }

    [Column("iTermOfEvery")]
    public int? ITermOfEvery { get; set; }

    [Column("fLayByTotal")]
    public double? FLayByTotal { get; set; }

    [Column("dInceptionDate", TypeName = "datetime")]
    public DateTime? DInceptionDate { get; set; }

    [Column("iTermsElapsed")]
    public int? ITermsElapsed { get; set; }

    [Column("fPaidToDate")]
    public double? FPaidToDate { get; set; }

    [Column("dLastPaymentDate", TypeName = "datetime")]
    public DateTime? DLastPaymentDate { get; set; }

    [Column("dNextPaymentDate", TypeName = "datetime")]
    public DateTime? DNextPaymentDate { get; set; }

    [Column("dFinalPaymentDate", TypeName = "datetime")]
    public DateTime? DFinalPaymentDate { get; set; }

    [Column("_retLayBys_iBranchID")]
    public int? RetLayBysIBranchId { get; set; }

    [Column("_retLayBys_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetLayBysDCreatedDate { get; set; }

    [Column("_retLayBys_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetLayBysDModifiedDate { get; set; }

    [Column("_retLayBys_iCreatedBranchID")]
    public int? RetLayBysICreatedBranchId { get; set; }

    [Column("_retLayBys_iModifiedBranchID")]
    public int? RetLayBysIModifiedBranchId { get; set; }

    [Column("_retLayBys_iCreatedAgentID")]
    public int? RetLayBysICreatedAgentId { get; set; }

    [Column("_retLayBys_iModifiedAgentID")]
    public int? RetLayBysIModifiedAgentId { get; set; }

    [Column("_retLayBys_iChangeSetID")]
    public int? RetLayBysIChangeSetId { get; set; }

    [Column("fLayByDeposit")]
    public double? FLayByDeposit { get; set; }

    [Column("fInstallmentAmount")]
    public double? FInstallmentAmount { get; set; }

    [Column("dLastUpdated", TypeName = "datetime")]
    public DateTime? DLastUpdated { get; set; }

    [Column("fPaymentDue")]
    public double? FPaymentDue { get; set; }

    [Column("iInvoiceIDFinalised")]
    public long? IInvoiceIdfinalised { get; set; }

    [Column("fCancellationFee")]
    public double? FCancellationFee { get; set; }

    [Column("fCancellationFeeTax")]
    public double? FCancellationFeeTax { get; set; }

    [Column("_retLayBys_Checksum")]
    [MaxLength(20)]
    public byte[]? RetLayBysChecksum { get; set; }
}
