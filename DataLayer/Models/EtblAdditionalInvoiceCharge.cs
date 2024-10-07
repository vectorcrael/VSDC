using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAdditionalInvoiceCharges")]
[Index("EtblAdditionalInvoiceChargesChecksum", Name = "idx__etblAdditionalInvoiceCharges__etblAdditionalInvoiceCharges_Checksum")]
[Index("EtblAdditionalInvoiceChargesDModifiedDate", Name = "idx__etblAdditionalInvoiceCharges__etblAdditionalInvoiceCharges_dModifiedDate")]
[Index("EtblAdditionalInvoiceChargesIBranchId", Name = "idx__etblAdditionalInvoiceCharges__etblAdditionalInvoiceCharges_iBranchID")]
[Index("EtblAdditionalInvoiceChargesIChangeSetId", Name = "idx__etblAdditionalInvoiceCharges__etblAdditionalInvoiceCharges_iChangeSetID")]
public partial class EtblAdditionalInvoiceCharge
{
    [Key]
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
}
