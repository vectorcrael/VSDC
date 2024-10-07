using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Index("PosDefsDModifiedDate", Name = "idxPosDefs_dModifiedDate")]
[Index("PosDefsIBranchId", Name = "idxPosDefs_iBranchID")]
[Index("PosDefsChecksum", Name = "idx_PosDefs_PosDefs_Checksum")]
[Index("PosDefsIChangeSetId", Name = "idx_PosDefs_iChangeSetID")]
public partial class PosDef
{
    [Key]
    [Column("IDPOSDefs")]
    public int Idposdefs { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AllowLineDisc { get; set; }

    [Column("Max_LDisc")]
    public double? MaxLdisc { get; set; }

    [Column("Max_Disc")]
    public double? MaxDisc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RecPref { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RecNum { get; set; }

    [Column("iRecPad")]
    public int? IRecPad { get; set; }

    [Column("bAutoRecNum")]
    public bool? BAutoRecNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PoleLine1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PoleLine2 { get; set; }

    [Column("AllocatePM")]
    public bool AllocatePm { get; set; }

    [Column("iTrCodesIDSTSale")]
    public int? ITrCodesIdstsale { get; set; }

    [Column("iTrCodesIDSTReturn")]
    public int? ITrCodesIdstreturn { get; set; }

    [Column("iTrCodesIDPOSFloat")]
    public int? ITrCodesIdposfloat { get; set; }

    [Column("iTrCodesIDPOSBanking")]
    public int? ITrCodesIdposbanking { get; set; }

    [Column("iTrCodesIDPOSPettyCash")]
    public int? ITrCodesIdpospettyCash { get; set; }

    [Column("iTrCodesIDPOSShortage")]
    public int? ITrCodesIdposshortage { get; set; }

    [Column("iTrCodesIDPOSExcess")]
    public int? ITrCodesIdposexcess { get; set; }

    [Column("iTrCodesIDARReceipt")]
    public int? ITrCodesIdarreceipt { get; set; }

    [Column("iTrCodesIDAPPayment")]
    public int? ITrCodesIdappayment { get; set; }

    [Column("iTenderIDDefFloat")]
    public int? ITenderIddefFloat { get; set; }

    [Column("iTenderIDDefBanking")]
    public int? ITenderIddefBanking { get; set; }

    [Column("iTenderIDDefPettyCash")]
    public int? ITenderIddefPettyCash { get; set; }

    [Column("iTenderIDDefShortage")]
    public int? ITenderIddefShortage { get; set; }

    [Column("iTenderIDDefExcess")]
    public int? ITenderIddefExcess { get; set; }

    [Column("iTenderIDDefReceipt")]
    public int? ITenderIddefReceipt { get; set; }

    [Column("iTenderIDDefPayment")]
    public int? ITenderIddefPayment { get; set; }

    [Column("iTenderIDDefCash")]
    public int? ITenderIddefCash { get; set; }

    [Column("bAutoAllocCashPM")]
    public bool BAutoAllocCashPm { get; set; }

    [Column("PosDefs_iBranchID")]
    public int? PosDefsIBranchId { get; set; }

    [Column("PosDefs_dCreatedDate", TypeName = "datetime")]
    public DateTime? PosDefsDCreatedDate { get; set; }

    [Column("PosDefs_dModifiedDate", TypeName = "datetime")]
    public DateTime? PosDefsDModifiedDate { get; set; }

    [Column("PosDefs_iCreatedBranchID")]
    public int? PosDefsICreatedBranchId { get; set; }

    [Column("PosDefs_iModifiedBranchID")]
    public int? PosDefsIModifiedBranchId { get; set; }

    [Column("PosDefs_iCreatedAgentID")]
    public int? PosDefsICreatedAgentId { get; set; }

    [Column("PosDefs_iModifiedAgentID")]
    public int? PosDefsIModifiedAgentId { get; set; }

    [Column("PosDefs_iChangeSetID")]
    public int? PosDefsIChangeSetId { get; set; }

    [Column("iTrCodesIDARDepositRefund")]
    public int? ITrCodesIdardepositRefund { get; set; }

    [Column("iTenderIDDefDepositRefund")]
    public int? ITenderIddefDepositRefund { get; set; }

    [Column("iTrCodesIDARRefund")]
    public int? ITrCodesIdarrefund { get; set; }

    [Column("iTenderIDDefRefund")]
    public int? ITenderIddefRefund { get; set; }

    [Column("bUseDocumentRoundingOnTender")]
    public bool? BUseDocumentRoundingOnTender { get; set; }

    [Column("PosDefs_Checksum")]
    [MaxLength(20)]
    public byte[]? PosDefsChecksum { get; set; }
}
