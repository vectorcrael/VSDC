using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPostDatedCheques")]
[Index("EtblPostDatedChequesChecksum", Name = "idx__etblPostDatedCheques__etblPostDatedCheques_Checksum")]
[Index("EtblPostDatedChequesIChangeSetId", Name = "idx__etblPostDatedCheques_iChangeSetID")]
[Index("EtblPostDatedChequesDModifiedDate", Name = "idx_etblPostDatedCheques_dModifiedDate")]
[Index("EtblPostDatedChequesIBranchId", Name = "idx_etblPostDatedCheques_iBranchID")]
public partial class EtblPostDatedCheque
{
    [Key]
    [Column("idPostDatedCheques")]
    public int IdPostDatedCheques { get; set; }

    [Column("dpdcDate", TypeName = "smalldatetime")]
    public DateTime? DpdcDate { get; set; }

    [Column("ipdcAccountID")]
    public int IpdcAccountId { get; set; }

    [Column("ipdcTrCodeID")]
    public int IpdcTrCodeId { get; set; }

    [Column("ipdcTaxTypeID")]
    public int IpdcTaxTypeId { get; set; }

    [Column("ipdcProjectID")]
    public int IpdcProjectId { get; set; }

    [Column("ipdcRepID")]
    public int IpdcRepId { get; set; }

    [Column("ipdcContraLedgerID")]
    public int IpdcContraLedgerId { get; set; }

    [Column("cpdcReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CpdcReference { get; set; }

    [Column("cpdcReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CpdcReference2 { get; set; }

    [Column("cpdcDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CpdcDescription { get; set; }

    [Column("cpdcOrderNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CpdcOrderNo { get; set; }

    [Column("fpdcInclusive")]
    public double FpdcInclusive { get; set; }

    [Column("fpdcExclusive")]
    public double FpdcExclusive { get; set; }

    [Column("fpdcTax")]
    public double FpdcTax { get; set; }

    [Column("fpdcFCInclusive")]
    public double FpdcFcinclusive { get; set; }

    [Column("fpdcFCExclusive")]
    public double FpdcFcexclusive { get; set; }

    [Column("fpdcFCTax")]
    public double FpdcFctax { get; set; }

    [Column("ipdcDiscTrCodeID")]
    public int IpdcDiscTrCodeId { get; set; }

    [Column("ipdcDiscTaxTypeID")]
    public int IpdcDiscTaxTypeId { get; set; }

    [Column("ipdcDiscTaxLedgerID")]
    public int IpdcDiscTaxLedgerId { get; set; }

    [Column("ipdcDiscContraLedgerID")]
    public int IpdcDiscContraLedgerId { get; set; }

    [Column("cpdcDiscDescription")]
    [StringLength(35)]
    [Unicode(false)]
    public string CpdcDiscDescription { get; set; } = null!;

    [Column("fpdcDiscInclusive")]
    public double FpdcDiscInclusive { get; set; }

    [Column("fpdcDiscExclusive")]
    public double FpdcDiscExclusive { get; set; }

    [Column("fpdcDiscTax")]
    public double FpdcDiscTax { get; set; }

    [Column("fpdcDiscFCInclusive")]
    public double FpdcDiscFcinclusive { get; set; }

    [Column("fpdcDiscFCExclusive")]
    public double FpdcDiscFcexclusive { get; set; }

    [Column("fpdcDiscFCTax")]
    public double FpdcDiscFctax { get; set; }

    [Column("fpdcExchangeRate")]
    public double FpdcExchangeRate { get; set; }

    [Column("ipdcGLControlID")]
    public int IpdcGlcontrolId { get; set; }

    [Column("bpdcCancelled")]
    public bool BpdcCancelled { get; set; }

    [Column("cpdcCancellationReason")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CpdcCancellationReason { get; set; }

    [Column("_etblPostDatedCheques_iBranchID")]
    public int? EtblPostDatedChequesIBranchId { get; set; }

    [Column("_etblPostDatedCheques_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPostDatedChequesDCreatedDate { get; set; }

    [Column("_etblPostDatedCheques_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPostDatedChequesDModifiedDate { get; set; }

    [Column("_etblPostDatedCheques_iCreatedBranchID")]
    public int? EtblPostDatedChequesICreatedBranchId { get; set; }

    [Column("_etblPostDatedCheques_iModifiedBranchID")]
    public int? EtblPostDatedChequesIModifiedBranchId { get; set; }

    [Column("_etblPostDatedCheques_iCreatedAgentID")]
    public int? EtblPostDatedChequesICreatedAgentId { get; set; }

    [Column("_etblPostDatedCheques_iModifiedAgentID")]
    public int? EtblPostDatedChequesIModifiedAgentId { get; set; }

    [Column("_etblPostDatedCheques_iChangeSetID")]
    public int? EtblPostDatedChequesIChangeSetId { get; set; }

    [Column("iVMVoucherID")]
    public int IVmvoucherId { get; set; }

    [Column("ipdcDCModule")]
    public int IpdcDcmodule { get; set; }

    [Column("_etblPostDatedCheques_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPostDatedChequesChecksum { get; set; }
}
