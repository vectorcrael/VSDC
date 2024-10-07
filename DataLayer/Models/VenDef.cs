using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("VenDef")]
[Index("VenDefDModifiedDate", Name = "idxVenDef_dModifiedDate")]
[Index("VenDefIBranchId", Name = "idxVenDef_iBranchID")]
[Index("VenDefChecksum", Name = "idx_VenDef_VenDef_Checksum")]
[Index("VenDefIChangeSetId", Name = "idx_VenDef_iChangeSetID")]
public partial class VenDef
{
    [Key]
    [Column("idVenDef")]
    public int IdVenDef { get; set; }

    [Column("AutoYN")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AutoYn { get; set; }

    public int? AutoLength { get; set; }

    public int? AutoAlphaLength { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? UpperAccNo { get; set; }

    public bool ForceProject { get; set; }

    public bool DefaultTxDesc { get; set; }

    [Column("LatestVDPrice")]
    public bool LatestVdprice { get; set; }

    public int? FilterStartLength { get; set; }

    [Column("iTaxRateIdNoCharge")]
    public int? ITaxRateIdNoCharge { get; set; }

    [Column("iPEXTrCodeID")]
    public int? IPextrCodeId { get; set; }

    [Column("iLEXTrCodeID")]
    public int? ILextrCodeId { get; set; }

    [Column("fTaxPromptAmount")]
    public double? FTaxPromptAmount { get; set; }

    [Column("iDelAddressCodeID1")]
    public int? IDelAddressCodeId1 { get; set; }

    [Column("iDelAddressCodeID2")]
    public int? IDelAddressCodeId2 { get; set; }

    [Column("bUseAllocStoredProc")]
    public bool BUseAllocStoredProc { get; set; }

    [Column("bInvTxCheckAccAfterChange")]
    public bool BInvTxCheckAccAfterChange { get; set; }

    [Column("iEFTSLayoutID")]
    public int IEftslayoutId { get; set; }

    [Column("cEFTSPathOutFile")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftspathOutFile { get; set; }

    [Column("VenDef_iBranchID")]
    public int? VenDefIBranchId { get; set; }

    [Column("VenDef_dCreatedDate", TypeName = "datetime")]
    public DateTime? VenDefDCreatedDate { get; set; }

    [Column("VenDef_dModifiedDate", TypeName = "datetime")]
    public DateTime? VenDefDModifiedDate { get; set; }

    [Column("VenDef_iCreatedBranchID")]
    public int? VenDefICreatedBranchId { get; set; }

    [Column("VenDef_iModifiedBranchID")]
    public int? VenDefIModifiedBranchId { get; set; }

    [Column("VenDef_iCreatedAgentID")]
    public int? VenDefICreatedAgentId { get; set; }

    [Column("VenDef_iModifiedAgentID")]
    public int? VenDefIModifiedAgentId { get; set; }

    [Column("VenDef_iChangeSetID")]
    public int? VenDefIChangeSetId { get; set; }

    [Column("iDefaultTermID")]
    public int? IDefaultTermId { get; set; }

    [Column("iRevProfitAcc")]
    public int? IRevProfitAcc { get; set; }

    [Column("iRevLossAcc")]
    public int? IRevLossAcc { get; set; }

    [Column("iProvForRevAcc")]
    public int? IProvForRevAcc { get; set; }

    [Column("iRemitBatchManageOpt")]
    public int IRemitBatchManageOpt { get; set; }

    [Column("iPDAgentID")]
    public int IPdagentId { get; set; }

    [Column("iPDPromptOpt")]
    public int IPdpromptOpt { get; set; }

    [Column("dPDLastPrompt", TypeName = "datetime")]
    public DateTime? DPdlastPrompt { get; set; }

    [Column("VenDef_Checksum")]
    [MaxLength(20)]
    public byte[]? VenDefChecksum { get; set; }

    [Column("cEFTSFileName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftsfileName { get; set; }

    [Column("bEFTSAutoNumbers")]
    public bool BEftsautoNumbers { get; set; }

    [Column("iEFTSPadLength")]
    public int? IEftspadLength { get; set; }

    [Column("cEFTSPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftsprefix { get; set; }
}
