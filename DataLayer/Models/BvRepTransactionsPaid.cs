using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvRepTransactionsPaid
{
    public long? TmpAutoIdx { get; set; }

    public int? TmpTxTerm { get; set; }

    [Column("TmpAllocID")]
    public long? TmpAllocId { get; set; }

    public double? TmpAllocAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TmpAllocDate { get; set; }

    public double? TmpTotCredits { get; set; }

    public double? TmpTotDebits { get; set; }

    [Column("TmpAllUACredits")]
    public double? TmpAllUacredits { get; set; }

    [Column("TmpAllUADebits")]
    public double? TmpAllUadebits { get; set; }

    [Column("TmpDCLink")]
    public int? TmpDclink { get; set; }

    [Column("TmpPas_Cursor")]
    public int? TmpPasCursor { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TmpTranModule { get; set; }

    [Column("TmpLinkedID")]
    public long? TmpLinkedId { get; set; }

    [Column("TmpLineID")]
    public int TmpLineId { get; set; }

    [Column("TmpRepID")]
    public int? TmpRepId { get; set; }

    public double? TmpStockAllocAmtExc { get; set; }

    public double? TmpStockCost { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("TmpAPRBatchID")]
    public int TmpAprbatchId { get; set; }

    [Column("SRidSalesRep")]
    public int? SridSalesRep { get; set; }

    [Column("SRCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Srcode { get; set; }

    [Column("SRName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Srname { get; set; }

    [Column("SRMethod")]
    public short? Srmethod { get; set; }

    [Column("SRTarget1")]
    public double? Srtarget1 { get; set; }

    [Column("SRTarget2")]
    public double? Srtarget2 { get; set; }

    [Column("SRTarget3")]
    public double? Srtarget3 { get; set; }

    [Column("SRTarget4")]
    public double? Srtarget4 { get; set; }

    [Column("SRTarget5")]
    public double? Srtarget5 { get; set; }

    [Column("SRCommission1")]
    public double? Srcommission1 { get; set; }

    [Column("SRCommission2")]
    public double? Srcommission2 { get; set; }

    [Column("SRCommission3")]
    public double? Srcommission3 { get; set; }

    [Column("SRCommission4")]
    public double? Srcommission4 { get; set; }

    [Column("SRCommission5")]
    public double? Srcommission5 { get; set; }

    [Column("SRAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Sraddress1 { get; set; }

    [Column("SRAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Sraddress2 { get; set; }

    [Column("SRAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Sraddress3 { get; set; }

    [Column("SREntity")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Srentity { get; set; }

    [Column("SRRep_On_Hold")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SrrepOnHold { get; set; }

    [Column("SRBank_Account")]
    [StringLength(40)]
    [Unicode(false)]
    public string? SrbankAccount { get; set; }

    [Column("SRComment1")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Srcomment1 { get; set; }

    [Column("SRComment2")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Srcomment2 { get; set; }

    [Column("ARTxDate", TypeName = "smalldatetime")]
    public DateTime? ArtxDate { get; set; }

    [Column("ARTxID")]
    [StringLength(5)]
    [Unicode(false)]
    public string? ArtxId { get; set; }

    [Column("ARTxCustomerID")]
    public int? ArtxCustomerId { get; set; }

    [Column("ARTxCodeID")]
    public int? ArtxCodeId { get; set; }

    [Column("ARTxDebit")]
    public double? ArtxDebit { get; set; }

    [Column("ARTxCredit")]
    public double? ArtxCredit { get; set; }

    [Column("ARTxTaxAmount")]
    public double? ArtxTaxAmount { get; set; }

    [Column("ARTxDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ArtxDescription { get; set; }

    [Column("ARTxReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxReference { get; set; }

    [Column("ARTxOrderNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxOrderNo { get; set; }

    [Column("ARTxAuditNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxAuditNo { get; set; }

    [Column("ARTxAllocRecID")]
    public long? ArtxAllocRecId { get; set; }

    [Column("ARTxJCCost")]
    public double? ArtxJccost { get; set; }

    [Column("ARTxTurnover")]
    public double? ArtxTurnover { get; set; }

    [Column("ARTxCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ArtxCode { get; set; }

    public int? ProjectLink { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [Column("IsJCItem")]
    public int IsJcitem { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerGroup { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerGroupDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CustomerArea { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerAreaDescr { get; set; }

    public int? LineTxCode { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? LineTxId { get; set; }

    public int LineTxQty { get; set; }

    public int? LineRepId { get; set; }

    public double? LineTxDebit { get; set; }

    public double? LineTxCredit { get; set; }

    public double? LineTxTax { get; set; }

    public double? LineTxCost { get; set; }

    public double? CommLineTxCost { get; set; }

    public double? LineTxTurnover { get; set; }

    public double? LineTxProfit { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? LineCodeOrAccount { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemGroup { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemGroupDescription { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemBinLocation { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ItemPackCode { get; set; }

    public int? ItemActive { get; set; }

    [Column("iInvSegValue1ID")]
    public int? IInvSegValue1Id { get; set; }

    [Column("iInvSegValue2ID")]
    public int? IInvSegValue2Id { get; set; }

    [Column("iInvSegValue3ID")]
    public int? IInvSegValue3Id { get; set; }

    [Column("iInvSegValue4ID")]
    public int? IInvSegValue4Id { get; set; }

    [Column("iInvSegValue5ID")]
    public int? IInvSegValue5Id { get; set; }

    [Column("iInvSegValue6ID")]
    public int? IInvSegValue6Id { get; set; }

    [Column("iInvSegValue7ID")]
    public int? IInvSegValue7Id { get; set; }

    [Column("ARTxPayReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxPayReference { get; set; }

    [Column("ARTxPayDate", TypeName = "smalldatetime")]
    public DateTime? ArtxPayDate { get; set; }

    [Column("ARTxPayDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ArtxPayDescription { get; set; }
}
