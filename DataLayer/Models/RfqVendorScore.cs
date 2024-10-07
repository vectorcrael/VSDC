using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_VendorScore")]
[Index("RfqVendorScoreChecksum", Name = "idx_RFQ_VendorScore_RFQ_VendorScore_Checksum")]
[Index("RfqVendorScoreDModifiedDate", Name = "idx_RFQ_VendorScore_RFQ_VendorScore_dModifiedDate")]
[Index("RfqVendorScoreIBranchId", Name = "idx_RFQ_VendorScore_RFQ_VendorScore_iBranchID")]
[Index("RfqVendorScoreIChangeSetId", Name = "idx_RFQ_VendorScore_RFQ_VendorScore_iChangeSetID")]
public partial class RfqVendorScore
{
    [Key]
    [Column("idVendorScore")]
    public int IdVendorScore { get; set; }

    [Column("iVendorID")]
    public int IVendorId { get; set; }

    [Column("iParameterID")]
    public int IParameterId { get; set; }

    [Column("cScore")]
    [StringLength(50)]
    public string CScore { get; set; } = null!;

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [Column("RFQ_VendorScore_iBranchID")]
    public int? RfqVendorScoreIBranchId { get; set; }

    [Column("RFQ_VendorScore_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqVendorScoreDCreatedDate { get; set; }

    [Column("RFQ_VendorScore_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqVendorScoreDModifiedDate { get; set; }

    [Column("RFQ_VendorScore_iCreatedBranchID")]
    public int? RfqVendorScoreICreatedBranchId { get; set; }

    [Column("RFQ_VendorScore_iModifiedBranchID")]
    public int? RfqVendorScoreIModifiedBranchId { get; set; }

    [Column("RFQ_VendorScore_iCreatedAgentID")]
    public int? RfqVendorScoreICreatedAgentId { get; set; }

    [Column("RFQ_VendorScore_iModifiedAgentID")]
    public int? RfqVendorScoreIModifiedAgentId { get; set; }

    [Column("RFQ_VendorScore_iChangeSetID")]
    public int? RfqVendorScoreIChangeSetId { get; set; }

    [Column("RFQ_VendorScore_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqVendorScoreChecksum { get; set; }

    [ForeignKey("IParameterId")]
    [InverseProperty("RfqVendorScores")]
    public virtual RfqVendorParameter IParameter { get; set; } = null!;

    [ForeignKey("IVendorId")]
    [InverseProperty("RfqVendorScores")]
    public virtual RfqVendor IVendor { get; set; } = null!;
}
