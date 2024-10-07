using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("PostST")]
[Index("CAuditNumber", Name = "idxAuditNumber")]
[Index("PostStDModifiedDate", Name = "idxPostST_dModifiedDate")]
[Index("PostStIBranchId", Name = "idxPostST_iBranchID")]
[Index("ITxBranchId", Name = "idxPostST_iTxBranchID")]
[Index("PostStChecksum", Name = "idx_PostST_PostST_Checksum")]
[Index("PostStIChangeSetId", Name = "idx_PostST_iChangeSetID")]
public partial class PostSt
{
    [Key]
    public long AutoIdx { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TxDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    public int? AccountLink { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fForeignDebit")]
    public double? FForeignDebit { get; set; }

    [Column("fForeignCredit")]
    public double? FForeignCredit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("TaxTypeID")]
    public int? TaxTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [Column("Order_No")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExtOrderNum { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [Column("Tax_Amount")]
    public double? TaxAmount { get; set; }

    [Column("fForeignTax")]
    public double? FForeignTax { get; set; }

    public int? Project { get; set; }

    public double? Quantity { get; set; }

    public double? Cost { get; set; }

    [Column("WarehouseID")]
    public int? WarehouseId { get; set; }

    public int? JobCodeLink { get; set; }

    [Column("iJobLineID")]
    public long IJobLineId { get; set; }

    [Column("TillID")]
    public int? TillId { get; set; }

    public int? DrCrAccount { get; set; }

    [Column("CRCCheck")]
    public double? Crccheck { get; set; }

    [Column("DTStamp", TypeName = "datetime")]
    public DateTime? Dtstamp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("iTaxPeriodID")]
    public int? ITaxPeriodId { get; set; }

    public int? InvNumKey { get; set; }

    [Column("cReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference2 { get; set; }

    [Column("RepID")]
    public int? RepId { get; set; }

    [Column("bChargeCom")]
    public bool BChargeCom { get; set; }

    [Column("iMFPID")]
    public int? IMfpid { get; set; }

    [Column("iLotID")]
    public int? ILotId { get; set; }

    [Column("iMFPLineID")]
    public long IMfplineId { get; set; }

    [Column("fUnManufactured")]
    public double FUnManufactured { get; set; }

    [Column("fAdditionalCost")]
    public double FAdditionalCost { get; set; }

    [Column("iPostEUNoTCID")]
    public int IPostEunoTcid { get; set; }

    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Column("PostST_iBranchID")]
    public int? PostStIBranchId { get; set; }

    [Column("PostST_dCreatedDate", TypeName = "datetime")]
    public DateTime? PostStDCreatedDate { get; set; }

    [Column("PostST_dModifiedDate", TypeName = "datetime")]
    public DateTime? PostStDModifiedDate { get; set; }

    [Column("PostST_iCreatedBranchID")]
    public int? PostStICreatedBranchId { get; set; }

    [Column("PostST_iModifiedBranchID")]
    public int? PostStIModifiedBranchId { get; set; }

    [Column("PostST_iCreatedAgentID")]
    public int? PostStICreatedAgentId { get; set; }

    [Column("PostST_iModifiedAgentID")]
    public int? PostStIModifiedAgentId { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("PostST_iChangeSetID")]
    public int? PostStIChangeSetId { get; set; }

    [Column("fJCWIPQuantity")]
    public double FJcwipquantity { get; set; }

    [Column("fMFPWIPQuantity")]
    public double FMfpwipquantity { get; set; }

    public double? QuantityR { get; set; }

    [Column("fQuantityInvoiced")]
    public double FQuantityInvoiced { get; set; }

    [Column("PostST_Checksum")]
    [MaxLength(20)]
    public byte[]? PostStChecksum { get; set; }

    [Unicode(false)]
    public string? SagePayExtra1 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra2 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra3 { get; set; }

    [Column("iMajorIndustryCodeID")]
    public int? IMajorIndustryCodeId { get; set; }
}
