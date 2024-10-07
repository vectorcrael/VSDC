using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvJcmasterFull
{
    [Column("IdJCMaster")]
    public int IdJcmaster { get; set; }

    [Column("cJobCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CJobCode { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }

    [Column("iPostingMethod")]
    public int? IPostingMethod { get; set; }

    [Column("iAccountsIdWIP")]
    public int? IAccountsIdWip { get; set; }

    [Column("iAccountsIdSales")]
    public int IAccountsIdSales { get; set; }

    [Column("iAccountsIdCOS")]
    public int? IAccountsIdCos { get; set; }

    [Column("iAccountsIdRecovery")]
    public int? IAccountsIdRecovery { get; set; }

    [Column("iClientId")]
    public int? IClientId { get; set; }

    [Column("cOrderNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COrderNo { get; set; }

    [Column("cFinalInvoiceNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CFinalInvoiceNo { get; set; }

    [Column("cDeliveryNoteNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDeliveryNoteNo { get; set; }

    [Column("cFinalCheck")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CFinalCheck { get; set; }

    [Column("cAuthorised")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAuthorised { get; set; }

    [Column("dStartDate", TypeName = "datetime")]
    public DateTime? DStartDate { get; set; }

    [Column("dCompletionDate", TypeName = "datetime")]
    public DateTime? DCompletionDate { get; set; }

    [Column("dDeliveryDate", TypeName = "datetime")]
    public DateTime? DDeliveryDate { get; set; }

    [Column("dClosingDate", TypeName = "datetime")]
    public DateTime? DClosingDate { get; set; }

    [Column("fQuoteAmount")]
    public double? FQuoteAmount { get; set; }

    [Column("bIsTemplate")]
    public bool BIsTemplate { get; set; }

    [Column("bFinal")]
    public bool BFinal { get; set; }

    [Column("iDeliveryMethodID")]
    public int? IDeliveryMethodId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("bInclusiveEntry")]
    public bool BInclusiveEntry { get; set; }

    [Column("bTaxPerLineEntry")]
    public bool BTaxPerLineEntry { get; set; }

    [Column("fDiscountPercent")]
    public double? FDiscountPercent { get; set; }

    [Column("iSalesRepId")]
    public int? ISalesRepId { get; set; }

    [Column("dInvDate", TypeName = "datetime")]
    public DateTime? DInvDate { get; set; }

    [Column("cAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CAddress1 { get; set; }

    [Column("cAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CAddress2 { get; set; }

    [Column("cAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CAddress3 { get; set; }

    [Column("cAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CAddress4 { get; set; }

    [Column("cAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CAddress5 { get; set; }

    [Column("cAddress6")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CAddress6 { get; set; }

    [Column("cPAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPaddress1 { get; set; }

    [Column("cPAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPaddress2 { get; set; }

    [Column("cPAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPaddress3 { get; set; }

    [Column("cPAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPaddress4 { get; set; }

    [Column("cPAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPaddress5 { get; set; }

    [Column("cPAddress6")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPaddress6 { get; set; }

    [Column("cMessage1")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CMessage1 { get; set; }

    [Column("cMessage2")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CMessage2 { get; set; }

    [Column("cMessage3")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CMessage3 { get; set; }

    [Column("tNarration", TypeName = "text")]
    public string? TNarration { get; set; }

    [Column("cExtOrderNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CExtOrderNo { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("iJobSettlementTermsID")]
    public int IJobSettlementTermsId { get; set; }

    [Column("iTxAddEUNoTCID")]
    public int ITxAddEunoTcid { get; set; }

    [Column("iTxRemEUNoTCID")]
    public int ITxRemEunoTcid { get; set; }

    [Column("_btblJCMaster_iBranchID")]
    public int? BtblJcmasterIBranchId { get; set; }

    [Column("_btblJCMaster_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJcmasterDCreatedDate { get; set; }

    [Column("_btblJCMaster_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJcmasterDModifiedDate { get; set; }

    [Column("_btblJCMaster_iCreatedBranchID")]
    public int? BtblJcmasterICreatedBranchId { get; set; }

    [Column("_btblJCMaster_iModifiedBranchID")]
    public int? BtblJcmasterIModifiedBranchId { get; set; }

    [Column("_btblJCMaster_iCreatedAgentID")]
    public int? BtblJcmasterICreatedAgentId { get; set; }

    [Column("_btblJCMaster_iModifiedAgentID")]
    public int? BtblJcmasterIModifiedAgentId { get; set; }

    [Column("_btblJCMaster_iChangeSetID")]
    public int? BtblJcmasterIChangeSetId { get; set; }

    [Column("iSortDocID")]
    public int? ISortDocId { get; set; }

    [Column("bInventoryMade")]
    public bool BInventoryMade { get; set; }

    [Column("cJMAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CJmauditNumber { get; set; }

    [Column("_btblJCMaster_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJcmasterChecksum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Group { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GroupDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Area { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AreaDescription { get; set; }

    [Column("WIPAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? Wipaccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? SalesAccount { get; set; }

    [Column("COSAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? Cosaccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? RecoveryAccount { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? DeliveryMethodDesc { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? JobStatusDesc { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string? JobPostMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [Column("iJCMasterID")]
    public int? IJcmasterId { get; set; }

    public double? ActSales { get; set; }

    public double? ActCost { get; set; }

    public double? ActTax { get; set; }

    public double? ActInvCost { get; set; }

    public double? ActBudgetSales { get; set; }

    public double? ActBudgetCost { get; set; }

    public double? ActBudgetTax { get; set; }

    public double? ActSalesForeign { get; set; }

    public double? ActBudgetSalesForeign { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDesc { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencySymbol { get; set; }
}
