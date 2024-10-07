using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvPosxztenderTxFull
{
    [Column("IDPOSXZTable")]
    public int? Idposxztable { get; set; }

    [Column("dTranDate", TypeName = "datetime")]
    public DateTime? DTranDate { get; set; }

    [Column("iTillTxType")]
    public int? ITillTxType { get; set; }

    [Column("iTillsID")]
    public int? ITillsId { get; set; }

    [Column("iAgentsID")]
    public int? IAgentsId { get; set; }

    [Column("iTrCodesID")]
    public int? ITrCodesId { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("cXZAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CXzauditNumber { get; set; }

    [Column("fAmtTendered")]
    public double? FAmtTendered { get; set; }

    [Column("fTranAmount")]
    public double? FTranAmount { get; set; }

    [Column("fChange")]
    public double? FChange { get; set; }

    [Column("_btblPOSXZTable_iBranchID")]
    public int? BtblPosxztableIBranchId { get; set; }

    [Column("_btblPOSXZTable_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblPosxztableDCreatedDate { get; set; }

    [Column("_btblPOSXZTable_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblPosxztableDModifiedDate { get; set; }

    [Column("_btblPOSXZTable_iCreatedBranchID")]
    public int? BtblPosxztableICreatedBranchId { get; set; }

    [Column("_btblPOSXZTable_iModifiedBranchID")]
    public int? BtblPosxztableIModifiedBranchId { get; set; }

    [Column("_btblPOSXZTable_iCreatedAgentID")]
    public int? BtblPosxztableICreatedAgentId { get; set; }

    [Column("_btblPOSXZTable_iModifiedAgentID")]
    public int? BtblPosxztableIModifiedAgentId { get; set; }

    [Column("_btblPOSXZTable_iChangeSetID")]
    public int? BtblPosxztableIChangeSetId { get; set; }

    [Column("_btblPOSXZTable_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblPosxztableChecksum { get; set; }

    [Column("IDPOSTenderTx")]
    public int IdpostenderTx { get; set; }

    [Column("iTenderID")]
    public int ITenderId { get; set; }

    [Column("cNarrative")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CNarrative { get; set; }

    [Column("fTxAmount")]
    public double? FTxAmount { get; set; }

    [Column("iPOSXZTableID")]
    public int? IPosxztableId { get; set; }

    [Column("_btblPOSTenderTx_iBranchID")]
    public int? BtblPostenderTxIBranchId { get; set; }

    [Column("_btblPOSTenderTx_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblPostenderTxDCreatedDate { get; set; }

    [Column("_btblPOSTenderTx_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblPostenderTxDModifiedDate { get; set; }

    [Column("_btblPOSTenderTx_iCreatedBranchID")]
    public int? BtblPostenderTxICreatedBranchId { get; set; }

    [Column("_btblPOSTenderTx_iModifiedBranchID")]
    public int? BtblPostenderTxIModifiedBranchId { get; set; }

    [Column("_btblPOSTenderTx_iCreatedAgentID")]
    public int? BtblPostenderTxICreatedAgentId { get; set; }

    [Column("_btblPOSTenderTx_iModifiedAgentID")]
    public int? BtblPostenderTxIModifiedAgentId { get; set; }

    [Column("_btblPOSTenderTx_iChangeSetID")]
    public int? BtblPostenderTxIChangeSetId { get; set; }

    [Column("cCardNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CCardNumber { get; set; }

    [Column("cCardHolder")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CCardHolder { get; set; }

    [Column("dExpiryDate", TypeName = "datetime")]
    public DateTime? DExpiryDate { get; set; }

    [Column("cEMVApplicationID")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CEmvapplicationId { get; set; }

    [Column("cEMVVerification")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CEmvverification { get; set; }

    [Column("cEMVTrCertificate")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEmvtrCertificate { get; set; }

    [Column("cEMVApplLabel")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEmvapplLabel { get; set; }

    [Column("cCardType")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CCardType { get; set; }

    [Column("cAuthCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CAuthCode { get; set; }

    [Column("dEFTDateTime", TypeName = "datetime")]
    public DateTime? DEftdateTime { get; set; }

    [Column("cEMVTSI")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CEmvtsi { get; set; }

    [Column("cEFTBudgetPeriod")]
    [StringLength(2)]
    [Unicode(false)]
    public string CEftbudgetPeriod { get; set; } = null!;

    [Column("cAuthorisationID")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CAuthorisationId { get; set; }

    [Column("cInstitutionID")]
    [StringLength(11)]
    [Unicode(false)]
    public string? CInstitutionId { get; set; }

    [Column("cTransactionType")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CTransactionType { get; set; }

    [Column("cAccountType")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CAccountType { get; set; }

    [Column("cE0210RespCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CE0210respCode { get; set; }

    [Column("cE0202RespCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CE0202respCode { get; set; }

    [Column("bChipCard")]
    public bool BChipCard { get; set; }

    [Column("cEFTReferenceNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftreferenceNumber { get; set; }

    [Column("bManualEFT")]
    public bool BManualEft { get; set; }

    [Column("_btblPOSTenderTx_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblPostenderTxChecksum { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TillNo { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TenderNo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TenderDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AccountName { get; set; }
}
