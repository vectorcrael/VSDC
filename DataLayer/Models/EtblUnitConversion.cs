using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblUnitConversion")]
[Index("EtblUnitConversionChecksum", Name = "idx__etblUnitConversion__etblUnitConversion_Checksum")]
[Index("EtblUnitConversionIChangeSetId", Name = "idx__etblUnitConversion_iChangeSetID")]
[Index("EtblUnitConversionDModifiedDate", Name = "idx_etblUnitConversion_dModifiedDate")]
[Index("EtblUnitConversionIBranchId", Name = "idx_etblUnitConversion_iBranchID")]
public partial class EtblUnitConversion
{
    [Key]
    [Column("idUnitConversion")]
    public int IdUnitConversion { get; set; }

    [Column("iUnitAID")]
    public int IUnitAid { get; set; }

    [Column("fUnitAQty")]
    public double FUnitAqty { get; set; }

    [Column("iUnitBID")]
    public int IUnitBid { get; set; }

    [Column("fUnitBQty")]
    public double FUnitBqty { get; set; }

    [Column("fMarkup")]
    public double? FMarkup { get; set; }

    [Column("_etblUnitConversion_iBranchID")]
    public int? EtblUnitConversionIBranchId { get; set; }

    [Column("_etblUnitConversion_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblUnitConversionDCreatedDate { get; set; }

    [Column("_etblUnitConversion_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblUnitConversionDModifiedDate { get; set; }

    [Column("_etblUnitConversion_iCreatedBranchID")]
    public int? EtblUnitConversionICreatedBranchId { get; set; }

    [Column("_etblUnitConversion_iModifiedBranchID")]
    public int? EtblUnitConversionIModifiedBranchId { get; set; }

    [Column("_etblUnitConversion_iCreatedAgentID")]
    public int? EtblUnitConversionICreatedAgentId { get; set; }

    [Column("_etblUnitConversion_iModifiedAgentID")]
    public int? EtblUnitConversionIModifiedAgentId { get; set; }

    [Column("_etblUnitConversion_iChangeSetID")]
    public int? EtblUnitConversionIChangeSetId { get; set; }

    [Column("_etblUnitConversion_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblUnitConversionChecksum { get; set; }
}
