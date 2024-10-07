using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_TenderDF")]
[Index("RfqTenderDfChecksum", Name = "idx_RFQ_TenderDF_RFQ_TenderDF_Checksum")]
[Index("RfqTenderDfDModifiedDate", Name = "idx_RFQ_TenderDF_RFQ_TenderDF_dModifiedDate")]
[Index("RfqTenderDfIBranchId", Name = "idx_RFQ_TenderDF_RFQ_TenderDF_iBranchID")]
[Index("RfqTenderDfIChangeSetId", Name = "idx_RFQ_TenderDF_RFQ_TenderDF_iChangeSetID")]
public partial class RfqTenderDf
{
    public bool? AutoNewTenderNo { get; set; }

    [StringLength(20)]
    public string? NewTenderPrefix { get; set; }

    public int? NextNewTenderNo { get; set; }

    public int? NewTenderPadLength { get; set; }

    public bool? AutoRecordTenderNo { get; set; }

    [StringLength(20)]
    public string? RecordTenderPrefix { get; set; }

    public int? NextRecordTenderNo { get; set; }

    public int? RecordTenderPadLength { get; set; }

    [Key]
    [Column("PK_Default")]
    public int PkDefault { get; set; }

    [Column("RFQ_TenderDF_iBranchID")]
    public int? RfqTenderDfIBranchId { get; set; }

    [Column("RFQ_TenderDF_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqTenderDfDCreatedDate { get; set; }

    [Column("RFQ_TenderDF_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqTenderDfDModifiedDate { get; set; }

    [Column("RFQ_TenderDF_iCreatedBranchID")]
    public int? RfqTenderDfICreatedBranchId { get; set; }

    [Column("RFQ_TenderDF_iModifiedBranchID")]
    public int? RfqTenderDfIModifiedBranchId { get; set; }

    [Column("RFQ_TenderDF_iCreatedAgentID")]
    public int? RfqTenderDfICreatedAgentId { get; set; }

    [Column("RFQ_TenderDF_iModifiedAgentID")]
    public int? RfqTenderDfIModifiedAgentId { get; set; }

    [Column("RFQ_TenderDF_iChangeSetID")]
    public int? RfqTenderDfIChangeSetId { get; set; }

    [Column("RFQ_TenderDF_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqTenderDfChecksum { get; set; }
}
