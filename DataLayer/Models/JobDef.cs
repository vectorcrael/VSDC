using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("JobDef")]
[Index("JobDefDModifiedDate", Name = "idxJobDef_dModifiedDate")]
[Index("JobDefIBranchId", Name = "idxJobDef_iBranchID")]
[Index("JobDefChecksum", Name = "idx_JobDef_JobDef_Checksum")]
[Index("JobDefIChangeSetId", Name = "idx_JobDef_iChangeSetID")]
public partial class JobDef
{
    public bool AutoNumber { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CurrentNumber { get; set; }

    [Column("WIPM1Link")]
    public int? Wipm1link { get; set; }

    [Column("RecoveryM1Link")]
    public int? RecoveryM1link { get; set; }

    [Column("TaxM1Link")]
    public int? TaxM1link { get; set; }

    [Column("StockM1Link")]
    public int? StockM1link { get; set; }

    [Column("CreditorM1Link")]
    public int? CreditorM1link { get; set; }

    [Column("SalesM1Link")]
    public int? SalesM1link { get; set; }

    [Column("COSM1Link")]
    public int? Cosm1link { get; set; }

    [Column("DebtorM1Link")]
    public int? DebtorM1link { get; set; }

    [Column("WIPM2Link")]
    public int? Wipm2link { get; set; }

    [Column("RecoveryM2Link")]
    public int? RecoveryM2link { get; set; }

    [Column("TaxM2Link")]
    public int? TaxM2link { get; set; }

    [Column("StockM2Link")]
    public int? StockM2link { get; set; }

    [Column("CreditorM2Link")]
    public int? CreditorM2link { get; set; }

    [Column("SalesM2Link")]
    public int? SalesM2link { get; set; }

    [Column("COSM2Link")]
    public int? Cosm2link { get; set; }

    [Column("DebtorM2Link")]
    public int? DebtorM2link { get; set; }

    [Column("POSTINGM")]
    public int? Postingm { get; set; }

    public bool AutoTemplate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NextTemplate { get; set; }

    [Column("iCCDebitAccount")]
    public int? ICcdebitAccount { get; set; }

    [Column("iCCCreditAccount")]
    public int? ICccreditAccount { get; set; }

    [Column("iJobPadTo")]
    public int? IJobPadTo { get; set; }

    [Column("cJobPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CJobPrefix { get; set; }

    [Column("iTemplatePadTo")]
    public int? ITemplatePadTo { get; set; }

    [Column("cTemplatePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTemplatePrefix { get; set; }

    [Column("iJobTxTpIDGRV")]
    public int? IJobTxTpIdgrv { get; set; }

    [Column("iJobTxTpIDGLOC")]
    public int? IJobTxTpIdgloc { get; set; }

    [Column("bAutoJCQuote")]
    public bool? BAutoJcquote { get; set; }

    [Column("cNextJCQuote")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CNextJcquote { get; set; }

    [Column("iJCQuotePadTo")]
    public int? IJcquotePadTo { get; set; }

    [Column("cJCQuotePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CJcquotePrefix { get; set; }

    [Column("bAutoJCDelNote")]
    public bool? BAutoJcdelNote { get; set; }

    [Column("cNextJCDelNote")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CNextJcdelNote { get; set; }

    [Column("iJCDelNotePadTo")]
    public int? IJcdelNotePadTo { get; set; }

    [Column("cJCDelNotePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CJcdelNotePrefix { get; set; }

    [Column("bPrintAllLines")]
    public bool BPrintAllLines { get; set; }

    [Column("iJobTxTpIDGrvGL")]
    public int? IJobTxTpIdgrvGl { get; set; }

    [Column("bPostGRVCost")]
    public bool BPostGrvcost { get; set; }

    [Column("bAPAllowSettlementTerms")]
    public bool BApallowSettlementTerms { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("bForceRep")]
    public bool BForceRep { get; set; }

    [Column("bForceExtOrderNum")]
    public bool BForceExtOrderNum { get; set; }

    [Column("bUniqueJobNum")]
    public bool? BUniqueJobNum { get; set; }

    [Column("bUniqueQuoteNum")]
    public bool? BUniqueQuoteNum { get; set; }

    [Column("bUniqueTemplateNum")]
    public bool? BUniqueTemplateNum { get; set; }

    [Column("bUniqueDeliveryNoteNum")]
    public bool? BUniqueDeliveryNoteNum { get; set; }

    [Column("JobDef_iBranchID")]
    public int? JobDefIBranchId { get; set; }

    [Column("JobDef_dCreatedDate", TypeName = "datetime")]
    public DateTime? JobDefDCreatedDate { get; set; }

    [Column("JobDef_dModifiedDate", TypeName = "datetime")]
    public DateTime? JobDefDModifiedDate { get; set; }

    [Column("JobDef_iCreatedBranchID")]
    public int? JobDefICreatedBranchId { get; set; }

    [Column("JobDef_iModifiedBranchID")]
    public int? JobDefIModifiedBranchId { get; set; }

    [Column("JobDef_iCreatedAgentID")]
    public int? JobDefICreatedAgentId { get; set; }

    [Column("JobDef_iModifiedAgentID")]
    public int? JobDefIModifiedAgentId { get; set; }

    [Key]
    [Column("idJobDef")]
    public int IdJobDef { get; set; }

    [Column("bStrictWIP")]
    public bool BStrictWip { get; set; }

    [Column("JobDef_iChangeSetID")]
    public int? JobDefIChangeSetId { get; set; }

    [Column("iFilterStartLength")]
    public int? IFilterStartLength { get; set; }

    [Column("JobDef_Checksum")]
    [MaxLength(20)]
    public byte[]? JobDefChecksum { get; set; }
}
