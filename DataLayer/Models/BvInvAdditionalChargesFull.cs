using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvInvAdditionalChargesFull
{
    [StringLength(91)]
    [Unicode(false)]
    public string? LedgerAccount { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? LedgerDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxDescription { get; set; }

    public double? TaxRate { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SalesRepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SalesRepName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [Column("cCurrencySymbol")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CCurrencySymbol { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AdditionalChargeCode { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? AdditionalChargeDescription { get; set; }

    [Column("idAdditionalInvoiceCharges")]
    public int IdAdditionalInvoiceCharges { get; set; }

    [Column("bInclusive")]
    public bool BInclusive { get; set; }

    [Column("fAdditionalAmt")]
    public double? FAdditionalAmt { get; set; }

    [Column("fPercentage")]
    public double? FPercentage { get; set; }

    [Column("fAmountExcl")]
    public double? FAmountExcl { get; set; }

    [Column("fAmountIncl")]
    public double? FAmountIncl { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iRepID")]
    public int? IRepId { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iInvNumID")]
    public long? IInvNumId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_iBranchID")]
    public int? EtblAdditionalInvoiceChargesIBranchId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAdditionalInvoiceChargesDCreatedDate { get; set; }

    [Column("_etblAdditionalInvoiceCharges_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAdditionalInvoiceChargesDModifiedDate { get; set; }

    [Column("_etblAdditionalInvoiceCharges_iCreatedBranchID")]
    public int? EtblAdditionalInvoiceChargesICreatedBranchId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_iModifiedBranchID")]
    public int? EtblAdditionalInvoiceChargesIModifiedBranchId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_iCreatedAgentID")]
    public int? EtblAdditionalInvoiceChargesICreatedAgentId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_iModifiedAgentID")]
    public int? EtblAdditionalInvoiceChargesIModifiedAgentId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_iChangeSetID")]
    public int? EtblAdditionalInvoiceChargesIChangeSetId { get; set; }

    [Column("_etblAdditionalInvoiceCharges_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAdditionalInvoiceChargesChecksum { get; set; }

    [Column("iAdditionalChargeID")]
    public int IAdditionalChargeId { get; set; }

    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Column("fAdditionalForeignAmt")]
    public double FAdditionalForeignAmt { get; set; }

    [Column("fForeignAmountExcl")]
    public double FForeignAmountExcl { get; set; }

    [Column("fForeignAmountIncl")]
    public double FForeignAmountIncl { get; set; }

    [Column("iCurrencyID")]
    public int ICurrencyId { get; set; }

    [Column("fCurrencyRate")]
    public double FCurrencyRate { get; set; }

    [Column("idAdditionalChgSettings")]
    public int IdAdditionalChgSettings { get; set; }

    [Column("bIsInvoiceCharge")]
    public bool BIsInvoiceCharge { get; set; }

    [Column("bIsReturnCharge")]
    public bool BIsReturnCharge { get; set; }

    public double? Tax { get; set; }

    public double TaxForeign { get; set; }
}
