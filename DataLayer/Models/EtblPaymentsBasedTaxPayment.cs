using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPaymentsBasedTaxPayments")]
[Index("EtblPaymentsBasedTaxPaymentsChecksum", Name = "idx__etblPaymentsBasedTaxPayments__etblPaymentsBasedTaxPayments_Checksum")]
[Index("EtblPaymentsBasedTaxPaymentsDModifiedDate", Name = "idx__etblPaymentsBasedTaxPayments__etblPaymentsBasedTaxPayments_dModifiedDate")]
[Index("EtblPaymentsBasedTaxPaymentsIBranchId", Name = "idx__etblPaymentsBasedTaxPayments__etblPaymentsBasedTaxPayments_iBranchID")]
[Index("EtblPaymentsBasedTaxPaymentsIChangeSetId", Name = "idx__etblPaymentsBasedTaxPayments__etblPaymentsBasedTaxPayments_iChangeSetID")]
public partial class EtblPaymentsBasedTaxPayment
{
    [Key]
    [Column("idPaymentsBasedTaxPayments")]
    public int IdPaymentsBasedTaxPayments { get; set; }

    [Column("iPBTBatchID")]
    public int? IPbtbatchId { get; set; }

    [Column("iModule")]
    public int? IModule { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("iPostingID")]
    public long? IPostingId { get; set; }

    [Column("fExclusive")]
    public double? FExclusive { get; set; }

    [Column("fTax")]
    public double? FTax { get; set; }

    [Column("fInclusive")]
    public double? FInclusive { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iGLTaxAccountID")]
    public int? IGltaxAccountId { get; set; }

    [Column("cAllocatedToReference")]
    [StringLength(50)]
    public string? CAllocatedToReference { get; set; }

    [Column("iAllocatedPostingID")]
    public long? IAllocatedPostingId { get; set; }

    [Column("iAllocatedStatus")]
    public int IAllocatedStatus { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_iBranchID")]
    public int? EtblPaymentsBasedTaxPaymentsIBranchId { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPaymentsBasedTaxPaymentsDCreatedDate { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPaymentsBasedTaxPaymentsDModifiedDate { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_iCreatedBranchID")]
    public int? EtblPaymentsBasedTaxPaymentsICreatedBranchId { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_iModifiedBranchID")]
    public int? EtblPaymentsBasedTaxPaymentsIModifiedBranchId { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_iCreatedAgentID")]
    public int? EtblPaymentsBasedTaxPaymentsICreatedAgentId { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_iModifiedAgentID")]
    public int? EtblPaymentsBasedTaxPaymentsIModifiedAgentId { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_iChangeSetID")]
    public int? EtblPaymentsBasedTaxPaymentsIChangeSetId { get; set; }

    [Column("_etblPaymentsBasedTaxPayments_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPaymentsBasedTaxPaymentsChecksum { get; set; }
}
