using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_RecordTender")]
[Index("RfqRecordTenderChecksum", Name = "idx_RFQ_RecordTender_RFQ_RecordTender_Checksum")]
[Index("RfqRecordTenderDModifiedDate", Name = "idx_RFQ_RecordTender_RFQ_RecordTender_dModifiedDate")]
[Index("RfqRecordTenderIBranchId", Name = "idx_RFQ_RecordTender_RFQ_RecordTender_iBranchID")]
[Index("RfqRecordTenderIChangeSetId", Name = "idx_RFQ_RecordTender_RFQ_RecordTender_iChangeSetID")]
public partial class RfqRecordTender
{
    [Key]
    [Column("PK_RecordTender")]
    public int PkRecordTender { get; set; }

    [Column("FK_NewTenderID")]
    public int FkNewTenderId { get; set; }

    [Column("cTenderNo")]
    [StringLength(50)]
    public string CTenderNo { get; set; } = null!;

    [Column("cTenderTitle")]
    [StringLength(200)]
    public string CTenderTitle { get; set; } = null!;

    [Column("cTenderRefNo")]
    [StringLength(50)]
    public string CTenderRefNo { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(500)]
    public string CDescription { get; set; } = null!;

    [Column("dAnnouncementDate", TypeName = "datetime")]
    public DateTime DAnnouncementDate { get; set; }

    [Column("dOpeningDate", TypeName = "datetime")]
    public DateTime DOpeningDate { get; set; }

    [Column("dLastSubmissionDate", TypeName = "datetime")]
    public DateTime DLastSubmissionDate { get; set; }

    [Column("dCompletiondate", TypeName = "datetime")]
    public DateTime DCompletiondate { get; set; }

    [Column("dSubmissiondate", TypeName = "datetime")]
    public DateTime DSubmissiondate { get; set; }

    [Column("fEarnestMoney")]
    public double? FEarnestMoney { get; set; }

    [Column("bIsEMDMandatory")]
    public bool BIsEmdmandatory { get; set; }

    [Column("iSupplierID")]
    public int ISupplierId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("fTenderTotal")]
    public double? FTenderTotal { get; set; }

    [Column("cTenderTerms")]
    public string? CTenderTerms { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [Column("iRecordSavedBy")]
    public int? IRecordSavedBy { get; set; }

    [Column("iScoreEnteredBy")]
    public int? IScoreEnteredBy { get; set; }

    [Column("iRecordEvaluatedBy")]
    public int? IRecordEvaluatedBy { get; set; }

    [Column("dEvaluationdate", TypeName = "datetime")]
    public DateTime? DEvaluationdate { get; set; }

    [Column("cEvaluationComments")]
    public string? CEvaluationComments { get; set; }

    [Column("RFQ_RecordTender_iBranchID")]
    public int? RfqRecordTenderIBranchId { get; set; }

    [Column("RFQ_RecordTender_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqRecordTenderDCreatedDate { get; set; }

    [Column("RFQ_RecordTender_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqRecordTenderDModifiedDate { get; set; }

    [Column("RFQ_RecordTender_iCreatedBranchID")]
    public int? RfqRecordTenderICreatedBranchId { get; set; }

    [Column("RFQ_RecordTender_iModifiedBranchID")]
    public int? RfqRecordTenderIModifiedBranchId { get; set; }

    [Column("RFQ_RecordTender_iCreatedAgentID")]
    public int? RfqRecordTenderICreatedAgentId { get; set; }

    [Column("RFQ_RecordTender_iModifiedAgentID")]
    public int? RfqRecordTenderIModifiedAgentId { get; set; }

    [Column("RFQ_RecordTender_iChangeSetID")]
    public int? RfqRecordTenderIChangeSetId { get; set; }

    [Column("RFQ_RecordTender_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqRecordTenderChecksum { get; set; }

    [InverseProperty("FkRecordTender")]
    public virtual ICollection<RfqRecordTenderDetail> RfqRecordTenderDetails { get; set; } = new List<RfqRecordTenderDetail>();
}
