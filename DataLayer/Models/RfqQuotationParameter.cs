using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_QuotationParameters")]
[Index("RfqQuotationParametersChecksum", Name = "idx_RFQ_QuotationParameters_RFQ_QuotationParameters_Checksum")]
[Index("RfqQuotationParametersDModifiedDate", Name = "idx_RFQ_QuotationParameters_RFQ_QuotationParameters_dModifiedDate")]
[Index("RfqQuotationParametersIBranchId", Name = "idx_RFQ_QuotationParameters_RFQ_QuotationParameters_iBranchID")]
[Index("RfqQuotationParametersIChangeSetId", Name = "idx_RFQ_QuotationParameters_RFQ_QuotationParameters_iChangeSetID")]
public partial class RfqQuotationParameter
{
    [Key]
    [Column("PK_QuotationParamID")]
    public int PkQuotationParamId { get; set; }

    [Column("cParamName")]
    [StringLength(100)]
    public string CParamName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(500)]
    public string? CDescription { get; set; }

    [Column("bIsMandatory")]
    public bool BIsMandatory { get; set; }

    [Column("bIsActive")]
    public bool? BIsActive { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime DLastModifiedDate { get; set; }

    [Column("RFQ_QuotationParameters_iBranchID")]
    public int? RfqQuotationParametersIBranchId { get; set; }

    [Column("RFQ_QuotationParameters_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqQuotationParametersDCreatedDate { get; set; }

    [Column("RFQ_QuotationParameters_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqQuotationParametersDModifiedDate { get; set; }

    [Column("RFQ_QuotationParameters_iCreatedBranchID")]
    public int? RfqQuotationParametersICreatedBranchId { get; set; }

    [Column("RFQ_QuotationParameters_iModifiedBranchID")]
    public int? RfqQuotationParametersIModifiedBranchId { get; set; }

    [Column("RFQ_QuotationParameters_iCreatedAgentID")]
    public int? RfqQuotationParametersICreatedAgentId { get; set; }

    [Column("RFQ_QuotationParameters_iModifiedAgentID")]
    public int? RfqQuotationParametersIModifiedAgentId { get; set; }

    [Column("RFQ_QuotationParameters_iChangeSetID")]
    public int? RfqQuotationParametersIChangeSetId { get; set; }

    [Column("RFQ_QuotationParameters_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqQuotationParametersChecksum { get; set; }
}
