using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CliDef")]
[Index("CliDefDModifiedDate", Name = "idxCliDef_dModifiedDate")]
[Index("CliDefIBranchId", Name = "idxCliDef_iBranchID")]
[Index("CliDefChecksum", Name = "idx_CliDef_CliDef_Checksum")]
[Index("CliDefIChangeSetId", Name = "idx_CliDef_iChangeSetID")]
public partial class CliDef
{
    [Key]
    [Column("idCliDef")]
    public int IdCliDef { get; set; }

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

    [Column("iPDAgentID")]
    public int? IPdagentId { get; set; }

    [Column("iPDPromptOpt")]
    public int? IPdpromptOpt { get; set; }

    [Column("dPDLastPrompt", TypeName = "datetime")]
    public DateTime? DPdlastPrompt { get; set; }

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

    [Column("bUseRounding")]
    public bool BUseRounding { get; set; }

    [Column("bRoundPOSOnly")]
    public bool BRoundPosonly { get; set; }

    [Column("fMinRoundDenom")]
    public double FMinRoundDenom { get; set; }

    [Column("iRoundToOpt")]
    public int? IRoundToOpt { get; set; }

    [Column("iRoundingGLAccountID")]
    public int? IRoundingGlaccountId { get; set; }

    [Column("bForceRep")]
    public bool BForceRep { get; set; }

    [Column("iEFTSLayoutID")]
    public int IEftslayoutId { get; set; }

    [Column("cEFTSPathOutFile")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftspathOutFile { get; set; }

    [Column("CliDef_iBranchID")]
    public int? CliDefIBranchId { get; set; }

    [Column("CliDef_dCreatedDate", TypeName = "datetime")]
    public DateTime? CliDefDCreatedDate { get; set; }

    [Column("CliDef_dModifiedDate", TypeName = "datetime")]
    public DateTime? CliDefDModifiedDate { get; set; }

    [Column("CliDef_iCreatedBranchID")]
    public int? CliDefICreatedBranchId { get; set; }

    [Column("CliDef_iModifiedBranchID")]
    public int? CliDefIModifiedBranchId { get; set; }

    [Column("CliDef_iCreatedAgentID")]
    public int? CliDefICreatedAgentId { get; set; }

    [Column("CliDef_iModifiedAgentID")]
    public int? CliDefIModifiedAgentId { get; set; }

    [Column("CliDef_iChangeSetID")]
    public int? CliDefIChangeSetId { get; set; }

    [Column("iDefaultTermID")]
    public int? IDefaultTermId { get; set; }

    [Column("bUseInsurance")]
    public bool? BUseInsurance { get; set; }

    [Column("bForceAuthorisedBy")]
    public bool? BForceAuthorisedBy { get; set; }

    [Column("bForceClaimNumber")]
    public bool? BForceClaimNumber { get; set; }

    [Column("bForcePolicyNumber")]
    public bool? BForcePolicyNumber { get; set; }

    [Column("bForceIncidentDate")]
    public bool? BForceIncidentDate { get; set; }

    [Column("bForceExcessAccName")]
    public bool? BForceExcessAccName { get; set; }

    [Column("bForceExcessAccCont1")]
    public bool? BForceExcessAccCont1 { get; set; }

    [Column("bForceExcessAccCont2")]
    public bool? BForceExcessAccCont2 { get; set; }

    [Column("iExcessCustomerId")]
    public int? IExcessCustomerId { get; set; }

    [Column("iExcessInvoiceTaxTypeId")]
    public int? IExcessInvoiceTaxTypeId { get; set; }

    [Column("iRevProfitAcc")]
    public int? IRevProfitAcc { get; set; }

    [Column("iRevLossAcc")]
    public int? IRevLossAcc { get; set; }

    [Column("iProvForRevAcc")]
    public int? IProvForRevAcc { get; set; }

    [Column("bApplyDiscountToACs")]
    public bool BApplyDiscountToAcs { get; set; }

    [Column("bStatementRun")]
    public bool BStatementRun { get; set; }

    [Column("bStatementsAutoNumbers")]
    public bool BStatementsAutoNumbers { get; set; }

    [Column("iStatementPadLength")]
    public int? IStatementPadLength { get; set; }

    [Column("bStatementUniqueNumber")]
    public bool BStatementUniqueNumber { get; set; }

    [Column("bForceStatementReference")]
    public bool BForceStatementReference { get; set; }

    [Column("cStatementPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CStatementPrefix { get; set; }

    [Column("bMBIgnoreServiceonAllocs")]
    public bool BMbignoreServiceonAllocs { get; set; }

    [Column("CliDef_Checksum")]
    [MaxLength(20)]
    public byte[]? CliDefChecksum { get; set; }
}
