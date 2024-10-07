using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_VendorParameter")]
[Index("RfqVendorParameterChecksum", Name = "idx_RFQ_VendorParameter_RFQ_VendorParameter_Checksum")]
[Index("RfqVendorParameterDModifiedDate", Name = "idx_RFQ_VendorParameter_RFQ_VendorParameter_dModifiedDate")]
[Index("RfqVendorParameterIBranchId", Name = "idx_RFQ_VendorParameter_RFQ_VendorParameter_iBranchID")]
[Index("RfqVendorParameterIChangeSetId", Name = "idx_RFQ_VendorParameter_RFQ_VendorParameter_iChangeSetID")]
public partial class RfqVendorParameter
{
    [Key]
    [Column("VendorParameterID")]
    public int VendorParameterId { get; set; }

    [Column("cParameterName")]
    [StringLength(100)]
    public string CParameterName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(200)]
    public string? CDescription { get; set; }

    [Column("bIsMandatory")]
    public bool? BIsMandatory { get; set; }

    [Column("bIsActive")]
    public bool? BIsActive { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [Column("RFQ_VendorParameter_iBranchID")]
    public int? RfqVendorParameterIBranchId { get; set; }

    [Column("RFQ_VendorParameter_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqVendorParameterDCreatedDate { get; set; }

    [Column("RFQ_VendorParameter_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqVendorParameterDModifiedDate { get; set; }

    [Column("RFQ_VendorParameter_iCreatedBranchID")]
    public int? RfqVendorParameterICreatedBranchId { get; set; }

    [Column("RFQ_VendorParameter_iModifiedBranchID")]
    public int? RfqVendorParameterIModifiedBranchId { get; set; }

    [Column("RFQ_VendorParameter_iCreatedAgentID")]
    public int? RfqVendorParameterICreatedAgentId { get; set; }

    [Column("RFQ_VendorParameter_iModifiedAgentID")]
    public int? RfqVendorParameterIModifiedAgentId { get; set; }

    [Column("RFQ_VendorParameter_iChangeSetID")]
    public int? RfqVendorParameterIChangeSetId { get; set; }

    [Column("RFQ_VendorParameter_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqVendorParameterChecksum { get; set; }

    [InverseProperty("IParameter")]
    public virtual ICollection<RfqVendorScore> RfqVendorScores { get; set; } = new List<RfqVendorScore>();
}
