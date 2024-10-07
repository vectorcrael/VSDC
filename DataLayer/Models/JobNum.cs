using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("JobNum")]
[Index("JobNumDModifiedDate", Name = "idxJobNum_dModifiedDate")]
[Index("JobNumIBranchId", Name = "idxJobNum_iBranchID")]
[Index("JobNumChecksum", Name = "idx_JobNum_JobNum_Checksum")]
[Index("JobNumIChangeSetId", Name = "idx_JobNum_iChangeSetID")]
public partial class JobNum
{
    [Key]
    public int AutoIndex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InvDate { get; set; }

    [Column("Email_Sent")]
    public int? EmailSent { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [Column("iJCMasterID")]
    public int? IJcmasterId { get; set; }

    public bool? TaxInclusive { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address5 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address6 { get; set; }

    [Column("PAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress1 { get; set; }

    [Column("PAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress2 { get; set; }

    [Column("PAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress3 { get; set; }

    [Column("PAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress4 { get; set; }

    [Column("PAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress5 { get; set; }

    [Column("PAddress6")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Paddress6 { get; set; }

    [Column("iDelMethodID")]
    public int? IDelMethodId { get; set; }

    [Column("iRepID")]
    public int? IRepId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DeliveryNote { get; set; }

    public double? InvDisc { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Message3 { get; set; }

    [Column(TypeName = "text")]
    public string? Narration { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    public double? InvDiscAmnt { get; set; }

    [Column("InvTotExclDEx")]
    public double? InvTotExclDex { get; set; }

    [Column("InvTotTaxDEx")]
    public double? InvTotTaxDex { get; set; }

    [Column("InvTotInclDEx")]
    public double? InvTotInclDex { get; set; }

    public double? InvTotExcl { get; set; }

    public double? InvTotTax { get; set; }

    public double? InvTotIncl { get; set; }

    public int? DocType { get; set; }

    [Column("bSummaryInv")]
    public bool BSummaryInv { get; set; }

    [Column("cExtOrderNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CExtOrderNumber { get; set; }

    [Column("iDocPrinted")]
    public int? IDocPrinted { get; set; }

    public double? InvDiscAmntForeign { get; set; }

    [Column("InvTotExclDExForeign")]
    public double? InvTotExclDexForeign { get; set; }

    [Column("InvTotTaxDExForeign")]
    public double? InvTotTaxDexForeign { get; set; }

    [Column("InvTotInclDExForeign")]
    public double? InvTotInclDexForeign { get; set; }

    public double? InvTotExclForeign { get; set; }

    public double? InvTotTaxForeign { get; set; }

    public double? InvTotInclForeign { get; set; }

    [Column("cTaxNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTaxNumber { get; set; }

    [Column("cAccountName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CAccountName { get; set; }

    [Column("iInvSettlementTermsID")]
    public int IInvSettlementTermsId { get; set; }

    [Column("JobNum_iBranchID")]
    public int? JobNumIBranchId { get; set; }

    [Column("JobNum_dCreatedDate", TypeName = "datetime")]
    public DateTime? JobNumDCreatedDate { get; set; }

    [Column("JobNum_dModifiedDate", TypeName = "datetime")]
    public DateTime? JobNumDModifiedDate { get; set; }

    [Column("JobNum_iCreatedBranchID")]
    public int? JobNumICreatedBranchId { get; set; }

    [Column("JobNum_iModifiedBranchID")]
    public int? JobNumIModifiedBranchId { get; set; }

    [Column("JobNum_iCreatedAgentID")]
    public int? JobNumICreatedAgentId { get; set; }

    [Column("JobNum_iModifiedAgentID")]
    public int? JobNumIModifiedAgentId { get; set; }

    [Column("JobNum_iChangeSetID")]
    public int? JobNumIChangeSetId { get; set; }

    [Column("bTaxPerLine")]
    public bool BTaxPerLine { get; set; }

    [Column("JobNum_Checksum")]
    [MaxLength(20)]
    public byte[]? JobNumChecksum { get; set; }
}
