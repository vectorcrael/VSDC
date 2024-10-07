using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_NewTender")]
[Index("RfqNewTenderChecksum", Name = "idx_RFQ_NewTender_RFQ_NewTender_Checksum")]
[Index("RfqNewTenderDModifiedDate", Name = "idx_RFQ_NewTender_RFQ_NewTender_dModifiedDate")]
[Index("RfqNewTenderIBranchId", Name = "idx_RFQ_NewTender_RFQ_NewTender_iBranchID")]
[Index("RfqNewTenderIChangeSetId", Name = "idx_RFQ_NewTender_RFQ_NewTender_iChangeSetID")]
public partial class RfqNewTender
{
    [Key]
    [Column("PK_NewTenderID")]
    public int PkNewTenderId { get; set; }

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

    [Column("fEarnestMoney")]
    public double? FEarnestMoney { get; set; }

    [Column("bIsEMDMandatory")]
    public bool BIsEmdmandatory { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("fTenderTotal")]
    public double? FTenderTotal { get; set; }

    [Column("cTenderTerms")]
    public string? CTenderTerms { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime DLastModifiedDate { get; set; }

    [Column("iLastModifiedBy")]
    public int? ILastModifiedBy { get; set; }

    [Column("RFQ_NewTender_iBranchID")]
    public int? RfqNewTenderIBranchId { get; set; }

    [Column("RFQ_NewTender_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqNewTenderDCreatedDate { get; set; }

    [Column("RFQ_NewTender_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqNewTenderDModifiedDate { get; set; }

    [Column("RFQ_NewTender_iCreatedBranchID")]
    public int? RfqNewTenderICreatedBranchId { get; set; }

    [Column("RFQ_NewTender_iModifiedBranchID")]
    public int? RfqNewTenderIModifiedBranchId { get; set; }

    [Column("RFQ_NewTender_iCreatedAgentID")]
    public int? RfqNewTenderICreatedAgentId { get; set; }

    [Column("RFQ_NewTender_iModifiedAgentID")]
    public int? RfqNewTenderIModifiedAgentId { get; set; }

    [Column("RFQ_NewTender_iChangeSetID")]
    public int? RfqNewTenderIChangeSetId { get; set; }

    [Column("RFQ_NewTender_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqNewTenderChecksum { get; set; }

    [InverseProperty("FkNewTender")]
    public virtual ICollection<RfqNewTenderDetail> RfqNewTenderDetails { get; set; } = new List<RfqNewTenderDetail>();
}
