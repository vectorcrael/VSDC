using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblPOSTenderTx")]
[Index("BtblPostenderTxChecksum", Name = "idx__btblPOSTenderTx__btblPOSTenderTx_Checksum")]
[Index("BtblPostenderTxIChangeSetId", Name = "idx__btblPOSTenderTx_iChangeSetID")]
[Index("BtblPostenderTxDModifiedDate", Name = "idx_btblPOSTenderTx_dModifiedDate")]
[Index("BtblPostenderTxIBranchId", Name = "idx_btblPOSTenderTx_iBranchID")]
public partial class BtblPostenderTx
{
    [Key]
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
}
