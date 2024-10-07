using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("TaxRate")]
[Index("TaxRateDModifiedDate", Name = "idxTaxRate_dModifiedDate")]
[Index("TaxRateIBranchId", Name = "idxTaxRate_iBranchID")]
[Index("TaxRateChecksum", Name = "idx_TaxRate_TaxRate_Checksum")]
[Index("TaxRateIChangeSetId", Name = "idx_TaxRate_iChangeSetID")]
public partial class TaxRate
{
    [Key]
    [Column("idTaxRate")]
    public int IdTaxRate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("TaxRate")]
    public double? TaxRate1 { get; set; }

    [Column("TaxRate_iBranchID")]
    public int? TaxRateIBranchId { get; set; }

    [Column("TaxRate_dCreatedDate", TypeName = "datetime")]
    public DateTime? TaxRateDCreatedDate { get; set; }

    [Column("TaxRate_dModifiedDate", TypeName = "datetime")]
    public DateTime? TaxRateDModifiedDate { get; set; }

    [Column("TaxRate_iCreatedBranchID")]
    public int? TaxRateICreatedBranchId { get; set; }

    [Column("TaxRate_iModifiedBranchID")]
    public int? TaxRateIModifiedBranchId { get; set; }

    [Column("TaxRate_iCreatedAgentID")]
    public int? TaxRateICreatedAgentId { get; set; }

    [Column("TaxRate_iModifiedAgentID")]
    public int? TaxRateIModifiedAgentId { get; set; }

    [Column("TaxRate_iChangeSetID")]
    public int? TaxRateIChangeSetId { get; set; }

    [Column("TaxRate_Checksum")]
    [MaxLength(20)]
    public byte[]? TaxRateChecksum { get; set; }

    [Column("iTransSource")]
    public int ITransSource { get; set; }

    [Column("bActiveTaxType")]
    public bool BActiveTaxType { get; set; }

    [Column("bAllowImportDeclaration")]
    public bool BAllowImportDeclaration { get; set; }

    [Column("cFiscalTaxLabel")]
    [StringLength(2)]
    public string? CFiscalTaxLabel { get; set; }

    [Column("bRequireRRP")]
    public bool? BRequireRrp { get; set; }
}
