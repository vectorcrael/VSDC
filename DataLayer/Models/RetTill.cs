using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retTill")]
[Index("RetTillIChangeSetId", Name = "idx__retBranchTill_iChangeSetID")]
[Index("RetTillChecksum", Name = "idx__retTill__retTill_Checksum")]
[Index("RetTillDModifiedDate", Name = "idx_retBranchTill_dModifiedDate")]
[Index("RetTillIBranchId", Name = "idx_retBranchTill_iBranchID")]
public partial class RetTill
{
    [Key]
    [Column("idTill")]
    public int IdTill { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("iCurrentAgentID")]
    public int? ICurrentAgentId { get; set; }

    [Column("bAutoNumPrependBranch")]
    public bool BAutoNumPrependBranch { get; set; }

    [Column("iAutoNumInvNext")]
    public int? IAutoNumInvNext { get; set; }

    [Column("iAutoNumInvPad")]
    public int? IAutoNumInvPad { get; set; }

    [Column("cAutoNumInvPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumInvPrefix { get; set; }

    [Column("iAutoNumOrdNext")]
    public int? IAutoNumOrdNext { get; set; }

    [Column("iAutoNumOrdPad")]
    public int? IAutoNumOrdPad { get; set; }

    [Column("cAutoNumOrdPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumOrdPrefix { get; set; }

    [Column("iAutoNumCrnNext")]
    public int? IAutoNumCrnNext { get; set; }

    [Column("iAutoNumCrnPad")]
    public int? IAutoNumCrnPad { get; set; }

    [Column("cAutoNumCrnPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumCrnPrefix { get; set; }

    [Column("iAutoNumQuoNext")]
    public int? IAutoNumQuoNext { get; set; }

    [Column("iAutoNumQuoPad")]
    public int? IAutoNumQuoPad { get; set; }

    [Column("cAutoNumQuoPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumQuoPrefix { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("iAutoNumCashUpNext")]
    public int? IAutoNumCashUpNext { get; set; }

    [Column("iAutoNumCashUpPad")]
    public int? IAutoNumCashUpPad { get; set; }

    [Column("cAutoNumCashUpPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumCashUpPrefix { get; set; }

    [Column("iAutoNumPettyCashNext")]
    public int? IAutoNumPettyCashNext { get; set; }

    [Column("iAutoNumPettyCashPad")]
    public int? IAutoNumPettyCashPad { get; set; }

    [Column("cAutoNumPettyCashPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumPettyCashPrefix { get; set; }

    [Column("iAutoNumCashPickupNext")]
    public int? IAutoNumCashPickupNext { get; set; }

    [Column("iAutoNumCashPickupPad")]
    public int? IAutoNumCashPickupPad { get; set; }

    [Column("cAutoNumCashPickupPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumCashPickupPrefix { get; set; }

    [Column("_retTill_iBranchID")]
    public int? RetTillIBranchId { get; set; }

    [Column("_retTill_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetTillDCreatedDate { get; set; }

    [Column("_retTill_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetTillDModifiedDate { get; set; }

    [Column("_retTill_iCreatedBranchID")]
    public int? RetTillICreatedBranchId { get; set; }

    [Column("_retTill_iModifiedBranchID")]
    public int? RetTillIModifiedBranchId { get; set; }

    [Column("_retTill_iCreatedAgentID")]
    public int? RetTillICreatedAgentId { get; set; }

    [Column("_retTill_iModifiedAgentID")]
    public int? RetTillIModifiedAgentId { get; set; }

    [Column("_retTill_iChangeSetID")]
    public int? RetTillIChangeSetId { get; set; }

    [Column("iAutoNumReceiptNext")]
    public int? IAutoNumReceiptNext { get; set; }

    [Column("iAutoNumReceiptPad")]
    public int? IAutoNumReceiptPad { get; set; }

    [Column("cAutoNumReceiptPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumReceiptPrefix { get; set; }

    [Column("iAutoNumRefundNext")]
    public int? IAutoNumRefundNext { get; set; }

    [Column("iAutoNumRefundPad")]
    public int? IAutoNumRefundPad { get; set; }

    [Column("cAutoNumRefundPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumRefundPrefix { get; set; }

    [Column("iAutoNumLayByReceiptNext")]
    public int? IAutoNumLayByReceiptNext { get; set; }

    [Column("iAutoNumLayByReceiptPad")]
    public int? IAutoNumLayByReceiptPad { get; set; }

    [Column("cAutoNumLayByReceiptPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumLayByReceiptPrefix { get; set; }

    [Column("iAutoNumLayByRefundNext")]
    public int? IAutoNumLayByRefundNext { get; set; }

    [Column("iAutoNumLayByRefundPad")]
    public int? IAutoNumLayByRefundPad { get; set; }

    [Column("cAutoNumLayByRefundPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumLayByRefundPrefix { get; set; }

    [Column("iAutoNumDelivNoteNext")]
    public int? IAutoNumDelivNoteNext { get; set; }

    [Column("iAutoNumDelivNotePad")]
    public int? IAutoNumDelivNotePad { get; set; }

    [Column("cAutoNumDelivNotePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumDelivNotePrefix { get; set; }

    [Column("iAutoNumLayByNext")]
    public int? IAutoNumLayByNext { get; set; }

    [Column("iAutoNumLayByPad")]
    public int? IAutoNumLayByPad { get; set; }

    [Column("cAutoNumLayByPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumLayByPrefix { get; set; }

    [Column("iAutoNumKeepAsideNext")]
    public int? IAutoNumKeepAsideNext { get; set; }

    [Column("iAutoNumKeepAsidePad")]
    public int? IAutoNumKeepAsidePad { get; set; }

    [Column("iAutoNumKeepAsidePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IAutoNumKeepAsidePrefix { get; set; }

    [Column("iDocketInputMode")]
    public int IDocketInputMode { get; set; }

    [Column("bUseOnScreenKeyboard")]
    public bool? BUseOnScreenKeyboard { get; set; }

    [Column("idPOSMenuSetup")]
    public long? IdPosmenuSetup { get; set; }

    [Column("iAutoNumCashDrawerHandoverNext")]
    public int? IAutoNumCashDrawerHandoverNext { get; set; }

    [Column("iAutoNumCashDrawerHandoverPad")]
    public int? IAutoNumCashDrawerHandoverPad { get; set; }

    [Column("cAutoNumCashDrawerHandoverPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumCashDrawerHandoverPrefix { get; set; }

    [Column("iAutoNumGIVNext")]
    public int? IAutoNumGivnext { get; set; }

    [Column("iAutoNumGIVPad")]
    public int? IAutoNumGivpad { get; set; }

    [Column("cAutoNumGIVPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumGivprefix { get; set; }

    [Column("iAutoNumCGRNext")]
    public int? IAutoNumCgrnext { get; set; }

    [Column("iAutoNumCGRPad")]
    public int? IAutoNumCgrpad { get; set; }

    [Column("cAutoNumCGRPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumCgrprefix { get; set; }

    [Column("_retTill_Checksum")]
    [MaxLength(20)]
    public byte[]? RetTillChecksum { get; set; }

    [Column("iTillLoginScreen")]
    public int ITillLoginScreen { get; set; }

    [Column("bAutoLogout")]
    public bool BAutoLogout { get; set; }
}
