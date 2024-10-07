using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvRecurRevApfull
{
    [Column("AccountID")]
    public int AccountId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AccountName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AccountGroup { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AccountArea { get; set; }

    public bool AccountChargeTax { get; set; }

    [Column("RecurrTransID")]
    public int RecurrTransId { get; set; }

    [Column("RecurrTransAccountID")]
    public int? RecurrTransAccountId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RecurrTransTerminateDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RecurrTransActiveDate { get; set; }

    [Column("RecurrTransConfigID")]
    public int? RecurrTransConfigId { get; set; }

    public int? RecurrTransChargeType { get; set; }

    public int? RecurrTransModule { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string RecurrTransTemplateType { get; set; } = null!;

    [Column("RecurrTransTemplateID")]
    public int? RecurrTransTemplateId { get; set; }

    public bool RecurrTransSuspended { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RecurrTransLastUpd { get; set; }

    public int? RecurrTransState { get; set; }

    public int? RecurrTransOccurredToDate { get; set; }

    public bool RecurrTransCreateAsOrder { get; set; }

    public bool RecurrTransCreatePayment { get; set; }

    public bool RecurrTransDebitOrder { get; set; }

    public bool RecurrTransAllowSettlementTerms { get; set; }

    [Column("RecurRL_iBranchID")]
    public int? RecurRlIBranchId { get; set; }

    [Column("TemplateID")]
    public int? TemplateId { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? TemplateDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TemplateReference { get; set; }

    [Column("TemplateTxCodeID")]
    public int? TemplateTxCodeId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TemplateTxCode { get; set; }

    [Column("TemplateTaxTypeID")]
    public int? TemplateTaxTypeId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TemplateTaxType { get; set; }

    public double? TemplateInclAmount { get; set; }

    public double? TemplateTaxAmount { get; set; }

    public bool? TemplateInHome { get; set; }

    [Column("TemplateCurrencyID")]
    public int TemplateCurrencyId { get; set; }

    public double? TemplateInclAmountForeign { get; set; }

    [Column("TemplateSettlementTermsID")]
    public int? TemplateSettlementTermsId { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ConfigDescription { get; set; }

    public int? ConfigOccurs { get; set; }

    public bool? ConfigActive { get; set; }

    public int? ConfigIntType { get; set; }

    public bool? ConfigChargeNow { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ConfigTerminateDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ConfigActiveDate { get; set; }

    public int? ConfigIntData1 { get; set; }

    public int? ConfigIntData2 { get; set; }

    [Column("ContractID")]
    public int? ContractId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ContractStartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ContractEndDate { get; set; }

    [Column("cSettlementCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSettlementCode { get; set; }

    [Column("cSettlementDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSettlementDescription { get; set; }

    [Column("iSettlementDays")]
    public int? ISettlementDays { get; set; }

    [Column("fSettlementDisc")]
    public double? FSettlementDisc { get; set; }
}
