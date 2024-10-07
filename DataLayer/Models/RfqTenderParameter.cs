using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_TenderParameters")]
[Index("RfqTenderParametersChecksum", Name = "idx_RFQ_TenderParameters_RFQ_TenderParameters_Checksum")]
[Index("RfqTenderParametersDModifiedDate", Name = "idx_RFQ_TenderParameters_RFQ_TenderParameters_dModifiedDate")]
[Index("RfqTenderParametersIBranchId", Name = "idx_RFQ_TenderParameters_RFQ_TenderParameters_iBranchID")]
[Index("RfqTenderParametersIChangeSetId", Name = "idx_RFQ_TenderParameters_RFQ_TenderParameters_iChangeSetID")]
public partial class RfqTenderParameter
{
    [Key]
    [Column("PK_TenderParamID")]
    public int PkTenderParamId { get; set; }

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

    [Column("RFQ_TenderParameters_iBranchID")]
    public int? RfqTenderParametersIBranchId { get; set; }

    [Column("RFQ_TenderParameters_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqTenderParametersDCreatedDate { get; set; }

    [Column("RFQ_TenderParameters_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqTenderParametersDModifiedDate { get; set; }

    [Column("RFQ_TenderParameters_iCreatedBranchID")]
    public int? RfqTenderParametersICreatedBranchId { get; set; }

    [Column("RFQ_TenderParameters_iModifiedBranchID")]
    public int? RfqTenderParametersIModifiedBranchId { get; set; }

    [Column("RFQ_TenderParameters_iCreatedAgentID")]
    public int? RfqTenderParametersICreatedAgentId { get; set; }

    [Column("RFQ_TenderParameters_iModifiedAgentID")]
    public int? RfqTenderParametersIModifiedAgentId { get; set; }

    [Column("RFQ_TenderParameters_iChangeSetID")]
    public int? RfqTenderParametersIChangeSetId { get; set; }

    [Column("RFQ_TenderParameters_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqTenderParametersChecksum { get; set; }

    [InverseProperty("FkTenderParam")]
    public virtual ICollection<RfqNewTenderParam> RfqNewTenderParams { get; set; } = new List<RfqNewTenderParam>();

    [InverseProperty("FkTenderParam")]
    public virtual ICollection<RfqRecordTenderParam> RfqRecordTenderParams { get; set; } = new List<RfqRecordTenderParam>();
}
