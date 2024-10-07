using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvRecurRevApfixed
{
    public int AutoIdx { get; set; }

    public int? Module { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Descrip { get; set; }

    public double? Amount { get; set; }

    public bool Incl { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    [Column("TaxTypeID")]
    public int? TaxTypeId { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    public bool? BaseHome { get; set; }

    [Column("iTmplSettlementTermsID")]
    public int ITmplSettlementTermsId { get; set; }

    [Column("RecurRF_iBranchID")]
    public int? RecurRfIBranchId { get; set; }

    [Column("RecurRF_dCreatedDate", TypeName = "datetime")]
    public DateTime? RecurRfDCreatedDate { get; set; }

    [Column("RecurRF_dModifiedDate", TypeName = "datetime")]
    public DateTime? RecurRfDModifiedDate { get; set; }

    [Column("RecurRF_iCreatedBranchID")]
    public int? RecurRfICreatedBranchId { get; set; }

    [Column("RecurRF_iModifiedBranchID")]
    public int? RecurRfIModifiedBranchId { get; set; }

    [Column("RecurRF_iCreatedAgentID")]
    public int? RecurRfICreatedAgentId { get; set; }

    [Column("RecurRF_iModifiedAgentID")]
    public int? RecurRfIModifiedAgentId { get; set; }

    [Column("RecurRF_iChangeSetID")]
    public int? RecurRfIChangeSetId { get; set; }

    [Column("RecurRF_Checksum")]
    [MaxLength(20)]
    public byte[]? RecurRfChecksum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TrCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? TrCodeDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxTypeDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SettlementTermsCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SettlementTermDescription { get; set; }

    public int? SettlementDays { get; set; }

    public double? SettlementDiscPerc { get; set; }
}
