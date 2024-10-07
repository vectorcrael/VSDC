using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARStatementRunOptions")]
[Index("EtblArstatementRunOptionsChecksum", Name = "idx__etblARStatementRunOptions__etblARStatementRunOptions_Checksum")]
[Index("EtblArstatementRunOptionsDModifiedDate", Name = "idx__etblARStatementRunOptions__etblARStatementRunOptions_dModifiedDate")]
[Index("EtblArstatementRunOptionsIBranchId", Name = "idx__etblARStatementRunOptions__etblARStatementRunOptions_iBranchID")]
[Index("EtblArstatementRunOptionsIChangeSetId", Name = "idx__etblARStatementRunOptions__etblARStatementRunOptions_iChangeSetID")]
public partial class EtblArstatementRunOption
{
    [Key]
    [Column("idStatementRunOptions")]
    public int IdStatementRunOptions { get; set; }

    [Column("iStatementRunID")]
    public int IStatementRunId { get; set; }

    [Column("dFromDate", TypeName = "datetime")]
    public DateTime? DFromDate { get; set; }

    [Column("dToDate", TypeName = "datetime")]
    public DateTime? DToDate { get; set; }

    [Column("bAgePerService")]
    public bool BAgePerService { get; set; }

    [Column("bDebits")]
    public bool BDebits { get; set; }

    [Column("bFullyAllocDebits")]
    public bool BFullyAllocDebits { get; set; }

    [Column("bCreditAllocs")]
    public bool BCreditAllocs { get; set; }

    [Column("bCredits")]
    public bool BCredits { get; set; }

    [Column("bFullyAllocCredits")]
    public bool BFullyAllocCredits { get; set; }

    [Column("bDebitAllocs")]
    public bool BDebitAllocs { get; set; }

    [Column("bExclZeroBal")]
    public bool BExclZeroBal { get; set; }

    [Column("bPrintZeroCurrMonth")]
    public bool BPrintZeroCurrMonth { get; set; }

    [Column("bExclBalLessAmt")]
    public bool BExclBalLessAmt { get; set; }

    [Column("fExclBalLessAmt")]
    public double? FExclBalLessAmt { get; set; }

    [Column("bExclNegBal")]
    public bool BExclNegBal { get; set; }

    [Column("bShowGrandTotals")]
    public bool BShowGrandTotals { get; set; }

    [Column("bShowZeroTx")]
    public bool BShowZeroTx { get; set; }

    [Column("bPrintOpenItemBBF")]
    public bool BPrintOpenItemBbf { get; set; }

    [Column("bGroupLinkedAccTx")]
    public bool BGroupLinkedAccTx { get; set; }

    [Column("bPrintForCurrFor")]
    public bool BPrintForCurrFor { get; set; }

    [Column("bPrintUnallocLast")]
    public bool BPrintUnallocLast { get; set; }

    [Column("bPrintFullAmount")]
    public bool BPrintFullAmount { get; set; }

    [Column("bPrintPDCheques")]
    public bool BPrintPdcheques { get; set; }

    [Column("bPrintDocDetail")]
    public bool BPrintDocDetail { get; set; }

    [Column("cFromCustomer")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CFromCustomer { get; set; }

    [Column("cToCustomer")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CToCustomer { get; set; }

    [Column("cGroups")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CGroups { get; set; }

    [Column("cAreas")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CAreas { get; set; }

    [Column("cSalesReps")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSalesReps { get; set; }

    [Column("cAgeingPeriods")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CAgeingPeriods { get; set; }

    [Column("cForCurrency")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CForCurrency { get; set; }

    [Column("cSort")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSort { get; set; }

    [Column("cSecondarySort")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CSecondarySort { get; set; }

    [Column("cPrintTotals")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CPrintTotals { get; set; }

    [Column("cAgeAllBy")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CAgeAllBy { get; set; }

    [Column("bInclEmailCustPreview")]
    public bool BInclEmailCustPreview { get; set; }

    [Column("bInclEmailCustPrint")]
    public bool BInclEmailCustPrint { get; set; }

    [Column("bEmailIndiv")]
    public bool BEmailIndiv { get; set; }

    [Column("bPrintOnHold")]
    public bool BPrintOnHold { get; set; }

    [Column("bPrintCash")]
    public bool BPrintCash { get; set; }

    [Column("_etblARStatementRunOptions_iBranchID")]
    public int? EtblArstatementRunOptionsIBranchId { get; set; }

    [Column("_etblARStatementRunOptions_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArstatementRunOptionsDCreatedDate { get; set; }

    [Column("_etblARStatementRunOptions_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArstatementRunOptionsDModifiedDate { get; set; }

    [Column("_etblARStatementRunOptions_iCreatedBranchID")]
    public int? EtblArstatementRunOptionsICreatedBranchId { get; set; }

    [Column("_etblARStatementRunOptions_iModifiedBranchID")]
    public int? EtblArstatementRunOptionsIModifiedBranchId { get; set; }

    [Column("_etblARStatementRunOptions_iCreatedAgentID")]
    public int? EtblArstatementRunOptionsICreatedAgentId { get; set; }

    [Column("_etblARStatementRunOptions_iModifiedAgentID")]
    public int? EtblArstatementRunOptionsIModifiedAgentId { get; set; }

    [Column("_etblARStatementRunOptions_iChangeSetID")]
    public int? EtblArstatementRunOptionsIChangeSetId { get; set; }

    [Column("_etblARStatementRunOptions_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArstatementRunOptionsChecksum { get; set; }

    [Column("cAge1Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge1Message1 { get; set; }

    [Column("cAge1Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge1Message2 { get; set; }

    [Column("cAge2Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge2Message1 { get; set; }

    [Column("cAge2Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge2Message2 { get; set; }

    [Column("cAge3Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge3Message1 { get; set; }

    [Column("cAge3Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge3Message2 { get; set; }

    [Column("cAge4Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge4Message1 { get; set; }

    [Column("cAge4Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge4Message2 { get; set; }

    [Column("cAge5Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge5Message1 { get; set; }

    [Column("cAge5Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge5Message2 { get; set; }

    [Column("cAge6Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge6Message1 { get; set; }

    [Column("cAge6Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge6Message2 { get; set; }

    [Column("cAge7Message1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge7Message1 { get; set; }

    [Column("cAge7Message2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAge7Message2 { get; set; }

    [Column("cCustSortPrimary")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CCustSortPrimary { get; set; }

    [Column("cCustSortSecondary")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CCustSortSecondary { get; set; }

    [Column("cDefaultMessage")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CDefaultMessage { get; set; }

    [Column("cDefaultSubject")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CDefaultSubject { get; set; }
}
