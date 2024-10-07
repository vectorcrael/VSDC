using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_ParameterCriteria")]
[Index("RfqParameterCriteriaChecksum", Name = "idx_RFQ_ParameterCriteria_RFQ_ParameterCriteria_Checksum")]
[Index("RfqParameterCriteriaDModifiedDate", Name = "idx_RFQ_ParameterCriteria_RFQ_ParameterCriteria_dModifiedDate")]
[Index("RfqParameterCriteriaIBranchId", Name = "idx_RFQ_ParameterCriteria_RFQ_ParameterCriteria_iBranchID")]
[Index("RfqParameterCriteriaIChangeSetId", Name = "idx_RFQ_ParameterCriteria_RFQ_ParameterCriteria_iChangeSetID")]
public partial class RfqParameterCriterion
{
    [Key]
    [Column("idRfqParam")]
    public int IdRfqParam { get; set; }

    [Column("cCriteria")]
    [StringLength(100)]
    public string? CCriteria { get; set; }

    [Column("cDescription")]
    [StringLength(200)]
    public string? CDescription { get; set; }

    [Column("bRandomSelection")]
    public bool? BRandomSelection { get; set; }

    [Column("iRandomSupplier")]
    public int? IRandomSupplier { get; set; }

    [Column("iNoOfQuotes")]
    public int? INoOfQuotes { get; set; }

    [Column("RFQ_ParameterCriteria_iBranchID")]
    public int? RfqParameterCriteriaIBranchId { get; set; }

    [Column("RFQ_ParameterCriteria_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqParameterCriteriaDCreatedDate { get; set; }

    [Column("RFQ_ParameterCriteria_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqParameterCriteriaDModifiedDate { get; set; }

    [Column("RFQ_ParameterCriteria_iCreatedBranchID")]
    public int? RfqParameterCriteriaICreatedBranchId { get; set; }

    [Column("RFQ_ParameterCriteria_iModifiedBranchID")]
    public int? RfqParameterCriteriaIModifiedBranchId { get; set; }

    [Column("RFQ_ParameterCriteria_iCreatedAgentID")]
    public int? RfqParameterCriteriaICreatedAgentId { get; set; }

    [Column("RFQ_ParameterCriteria_iModifiedAgentID")]
    public int? RfqParameterCriteriaIModifiedAgentId { get; set; }

    [Column("RFQ_ParameterCriteria_iChangeSetID")]
    public int? RfqParameterCriteriaIChangeSetId { get; set; }

    [Column("RFQ_ParameterCriteria_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqParameterCriteriaChecksum { get; set; }
}
