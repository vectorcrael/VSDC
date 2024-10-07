using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("WHT_TaxMaster")]
[Index("WhtTaxMasterChecksum", Name = "idx_WHT_TaxMaster_WHT_TaxMaster_Checksum")]
[Index("WhtTaxMasterDModifiedDate", Name = "idx_WHT_TaxMaster_WHT_TaxMaster_dModifiedDate")]
[Index("WhtTaxMasterIBranchId", Name = "idx_WHT_TaxMaster_WHT_TaxMaster_iBranchID")]
[Index("WhtTaxMasterIChangeSetId", Name = "idx_WHT_TaxMaster_WHT_TaxMaster_iChangeSetID")]
public partial class WhtTaxMaster
{
    [Key]
    [Column("idTaxMaster")]
    public int IdTaxMaster { get; set; }

    [Column("idVendor")]
    public int? IdVendor { get; set; }

    [StringLength(30)]
    public string? VendorAccount { get; set; }

    [StringLength(50)]
    public string? VendorName { get; set; }

    [Column("bIsVendorWHT")]
    public bool? BIsVendorWht { get; set; }

    [Column("fWHTPercentage")]
    public double? FWhtpercentage { get; set; }

    [Column("bIsSelect")]
    public bool? BIsSelect { get; set; }

    [Column("WHT_TaxMaster_iBranchID")]
    public int? WhtTaxMasterIBranchId { get; set; }

    [Column("WHT_TaxMaster_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhtTaxMasterDCreatedDate { get; set; }

    [Column("WHT_TaxMaster_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhtTaxMasterDModifiedDate { get; set; }

    [Column("WHT_TaxMaster_iCreatedBranchID")]
    public int? WhtTaxMasterICreatedBranchId { get; set; }

    [Column("WHT_TaxMaster_iModifiedBranchID")]
    public int? WhtTaxMasterIModifiedBranchId { get; set; }

    [Column("WHT_TaxMaster_iCreatedAgentID")]
    public int? WhtTaxMasterICreatedAgentId { get; set; }

    [Column("WHT_TaxMaster_iModifiedAgentID")]
    public int? WhtTaxMasterIModifiedAgentId { get; set; }

    [Column("WHT_TaxMaster_iChangeSetID")]
    public int? WhtTaxMasterIChangeSetId { get; set; }

    [Column("WHT_TaxMaster_Checksum")]
    [MaxLength(20)]
    public byte[]? WhtTaxMasterChecksum { get; set; }
}
