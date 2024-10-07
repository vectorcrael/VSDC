using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("BomDef")]
[Index("BomDefDModifiedDate", Name = "idxBomDef_dModifiedDate")]
[Index("BomDefIBranchId", Name = "idxBomDef_iBranchID")]
[Index("BomDefChecksum", Name = "idx_BomDef_BomDef_Checksum")]
[Index("BomDefIChangeSetId", Name = "idx_BomDef_iChangeSetID")]
public partial class BomDef
{
    [StringLength(20)]
    [Unicode(false)]
    public string? TxCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BrkUpTxCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UpdCostTxCode { get; set; }

    public int? PromptToManuf { get; set; }

    public int? TempNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NextBillManufRef { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NextBillBrkRef { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NextBillUpdateRef { get; set; }

    [Column("iBreakupOnGrvPrompt")]
    public int? IBreakupOnGrvPrompt { get; set; }

    [Column("bShowComponentsOnGRV")]
    public bool? BShowComponentsOnGrv { get; set; }

    [Column("iAccountsIDDefSurplus")]
    public int? IAccountsIddefSurplus { get; set; }

    [Column("iMFTxCodeID")]
    public int? IMftxCodeId { get; set; }

    [Column("iDRTxCodeID")]
    public int? IDrtxCodeId { get; set; }

    [Column("iBPTxCodeID")]
    public int? IBptxCodeId { get; set; }

    [Column("iWATxCodeID")]
    public int? IWatxCodeId { get; set; }

    [Column("iUMTxCodeID")]
    public int? IUmtxCodeId { get; set; }

    [Column("iVATxCodeID")]
    public int? IVatxCodeId { get; set; }

    [Column("bShowAvailAllLevels")]
    public bool BShowAvailAllLevels { get; set; }

    [Column("bShowCompOnInv")]
    public bool BShowCompOnInv { get; set; }

    [Column("bAutoNumManuf")]
    public bool BAutoNumManuf { get; set; }

    [Column("bAutoNumBreakUp")]
    public bool BAutoNumBreakUp { get; set; }

    [Column("bAutoNumUpdateCosts")]
    public bool BAutoNumUpdateCosts { get; set; }

    [Column("bPromptPickSlip")]
    public bool BPromptPickSlip { get; set; }

    [Column("bAlwaysPrintPickSlip")]
    public bool BAlwaysPrintPickSlip { get; set; }

    [Column("bManufAutoNumLine")]
    public bool BManufAutoNumLine { get; set; }

    [Column("cNextManufRefLine")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CNextManufRefLine { get; set; }

    [Column("bOverwriteAutoManufRef")]
    public bool BOverwriteAutoManufRef { get; set; }

    [Column("iMFPFilterStLength")]
    public int IMfpfilterStLength { get; set; }

    [Column("bPickSlipPrintAllLines")]
    public bool BPickSlipPrintAllLines { get; set; }

    [Column("bPickSlipPrintUnprintedLines")]
    public bool BPickSlipPrintUnprintedLines { get; set; }

    [Column("bPickSlipPrintLastSessionLines")]
    public bool BPickSlipPrintLastSessionLines { get; set; }

    [Column("bPickSlipPrintSubManuf")]
    public bool BPickSlipPrintSubManuf { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("bUniqueManufRef")]
    public bool? BUniqueManufRef { get; set; }

    [Column("BomDef_iBranchID")]
    public int? BomDefIBranchId { get; set; }

    [Column("BomDef_dCreatedDate", TypeName = "datetime")]
    public DateTime? BomDefDCreatedDate { get; set; }

    [Column("BomDef_dModifiedDate", TypeName = "datetime")]
    public DateTime? BomDefDModifiedDate { get; set; }

    [Column("BomDef_iCreatedBranchID")]
    public int? BomDefICreatedBranchId { get; set; }

    [Column("BomDef_iModifiedBranchID")]
    public int? BomDefIModifiedBranchId { get; set; }

    [Column("BomDef_iCreatedAgentID")]
    public int? BomDefICreatedAgentId { get; set; }

    [Column("BomDef_iModifiedAgentID")]
    public int? BomDefIModifiedAgentId { get; set; }

    [Key]
    [Column("idBomDef")]
    public int IdBomDef { get; set; }

    [Column("BomDef_iChangeSetID")]
    public int? BomDefIChangeSetId { get; set; }

    [Column("iDefaultComponentWhseID")]
    public int? IDefaultComponentWhseId { get; set; }

    [Column("bOverDrawWarning")]
    public bool BOverDrawWarning { get; set; }

    [Column("BomDef_Checksum")]
    [MaxLength(20)]
    public byte[]? BomDefChecksum { get; set; }
}
