using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RecurRF")]
[Index("RecurRfDModifiedDate", Name = "idxRecurRF_dModifiedDate")]
[Index("RecurRfIBranchId", Name = "idxRecurRF_iBranchID")]
[Index("RecurRfChecksum", Name = "idx_RecurRF_RecurRF_Checksum")]
[Index("RecurRfIChangeSetId", Name = "idx_RecurRF_iChangeSetID")]
public partial class RecurRf
{
    [Key]
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
}
