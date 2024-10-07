using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPaymentsBasedTax")]
[Index("EtblPaymentsBasedTaxChecksum", Name = "idx__etblPaymentsBasedTax__etblPaymentsBasedTax_Checksum")]
[Index("EtblPaymentsBasedTaxDModifiedDate", Name = "idx__etblPaymentsBasedTax__etblPaymentsBasedTax_dModifiedDate")]
[Index("EtblPaymentsBasedTaxIBranchId", Name = "idx__etblPaymentsBasedTax__etblPaymentsBasedTax_iBranchID")]
[Index("EtblPaymentsBasedTaxIChangeSetId", Name = "idx__etblPaymentsBasedTax__etblPaymentsBasedTax_iChangeSetID")]
public partial class EtblPaymentsBasedTax
{
    [Key]
    [Column("idPaymentsBasedTax")]
    public int IdPaymentsBasedTax { get; set; }

    [Column("iFromPeriod")]
    public int? IFromPeriod { get; set; }

    [Column("iToPeriod")]
    public int? IToPeriod { get; set; }

    [Column("dProcessDate", TypeName = "datetime")]
    public DateTime? DProcessDate { get; set; }

    [Column("cNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CNumber { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("fExcludeLessThan")]
    public double? FExcludeLessThan { get; set; }

    [Column("bProcessed")]
    public bool BProcessed { get; set; }

    [Column("cProcessedAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CProcessedAuditNumber { get; set; }

    [Column("_etblPaymentsBasedTax_iBranchID")]
    public int? EtblPaymentsBasedTaxIBranchId { get; set; }

    [Column("_etblPaymentsBasedTax_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPaymentsBasedTaxDCreatedDate { get; set; }

    [Column("_etblPaymentsBasedTax_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPaymentsBasedTaxDModifiedDate { get; set; }

    [Column("_etblPaymentsBasedTax_iCreatedBranchID")]
    public int? EtblPaymentsBasedTaxICreatedBranchId { get; set; }

    [Column("_etblPaymentsBasedTax_iModifiedBranchID")]
    public int? EtblPaymentsBasedTaxIModifiedBranchId { get; set; }

    [Column("_etblPaymentsBasedTax_iCreatedAgentID")]
    public int? EtblPaymentsBasedTaxICreatedAgentId { get; set; }

    [Column("_etblPaymentsBasedTax_iModifiedAgentID")]
    public int? EtblPaymentsBasedTaxIModifiedAgentId { get; set; }

    [Column("_etblPaymentsBasedTax_iChangeSetID")]
    public int? EtblPaymentsBasedTaxIChangeSetId { get; set; }

    [Column("_etblPaymentsBasedTax_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPaymentsBasedTaxChecksum { get; set; }
}
