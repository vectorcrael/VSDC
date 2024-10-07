using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Tender")]
[Index("TenderDModifiedDate", Name = "idxTender_dModifiedDate")]
[Index("TenderIBranchId", Name = "idxTender_iBranchID")]
[Index("TenderChecksum", Name = "idx_Tender_Tender_Checksum")]
[Index("TenderIChangeSetId", Name = "idx_Tender_iChangeSetID")]
public partial class Tender
{
    [Key]
    public int IdTender { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TenderNo { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Force_Narrative")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ForceNarrative { get; set; }

    [Column("House_Limit")]
    public double? HouseLimit { get; set; }

    [Column("iTrCodesIDInvPM")]
    public int? ITrCodesIdinvPm { get; set; }

    [Column("iTrCodesIDCRNRF")]
    public int? ITrCodesIdcrnrf { get; set; }

    [Column("Tender_iBranchID")]
    public int? TenderIBranchId { get; set; }

    [Column("Tender_dCreatedDate", TypeName = "datetime")]
    public DateTime? TenderDCreatedDate { get; set; }

    [Column("Tender_dModifiedDate", TypeName = "datetime")]
    public DateTime? TenderDModifiedDate { get; set; }

    [Column("Tender_iCreatedBranchID")]
    public int? TenderICreatedBranchId { get; set; }

    [Column("Tender_iModifiedBranchID")]
    public int? TenderIModifiedBranchId { get; set; }

    [Column("Tender_iCreatedAgentID")]
    public int? TenderICreatedAgentId { get; set; }

    [Column("Tender_iModifiedAgentID")]
    public int? TenderIModifiedAgentId { get; set; }

    [Column("Tender_iChangeSetID")]
    public int? TenderIChangeSetId { get; set; }

    [Column("bUsePinPad")]
    public bool? BUsePinPad { get; set; }

    [Column("iCardDisplayFirst")]
    public int? ICardDisplayFirst { get; set; }

    [Column("iCardDisplayLast")]
    public int? ICardDisplayLast { get; set; }

    [Column("bForceCardNumber")]
    public bool? BForceCardNumber { get; set; }

    [Column("bForceCardHolder")]
    public bool? BForceCardHolder { get; set; }

    [Column("cExpiryFormat")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CExpiryFormat { get; set; }

    [Column("bForceExpiry")]
    public bool? BForceExpiry { get; set; }

    [Column("bApplyDocumentRounding")]
    public bool? BApplyDocumentRounding { get; set; }

    [Column("Tender_Checksum")]
    [MaxLength(20)]
    public byte[]? TenderChecksum { get; set; }
}
