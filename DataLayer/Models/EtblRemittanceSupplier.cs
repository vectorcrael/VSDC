using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblRemittanceSuppliers")]
[Index("EtblRemittanceSuppliersChecksum", Name = "idx__etblRemittanceSuppliers__etblRemittanceSuppliers_Checksum")]
[Index("IBatchId", Name = "idx__etblRemittanceSuppliers_iBatchID")]
[Index("EtblRemittanceSuppliersIChangeSetId", Name = "idx__etblRemittanceSuppliers_iChangeSetID")]
[Index("IProjectId", Name = "idx__etblRemittanceSuppliers_iProjectID")]
[Index("ISupplierId", Name = "idx__etblRemittanceSuppliers_iSupplierID")]
[Index("ISupplierId", "IProjectId", "IBatchId", Name = "idx__etblRemittanceSuppliers_iSupplierIDiProjectIDiBatchID")]
[Index("EtblRemittanceSuppliersDModifiedDate", Name = "idx_etblRemittanceSuppliers_dModifiedDate")]
[Index("EtblRemittanceSuppliersIBranchId", Name = "idx_etblRemittanceSuppliers_iBranchID")]
public partial class EtblRemittanceSupplier
{
    [Key]
    [Column("IDRemittanceSuppliers")]
    public int IdremittanceSuppliers { get; set; }

    [Column("iSupplierID")]
    public int? ISupplierId { get; set; }

    [Column("cPayeeName")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CPayeeName { get; set; }

    [Column("bPrintCheque")]
    public bool BPrintCheque { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("fDiscReceived")]
    public double? FDiscReceived { get; set; }

    [Column("fTotalPaid")]
    public double? FTotalPaid { get; set; }

    [Column("fDocumentTotal")]
    public double? FDocumentTotal { get; set; }

    [Column("bIncludedInRun")]
    public bool BIncludedInRun { get; set; }

    [Column("bChequePrinted")]
    public bool BChequePrinted { get; set; }

    [Column("bRemittancePrinted")]
    public bool BRemittancePrinted { get; set; }

    [Column("bEFTSProcessed")]
    public bool BEftsprocessed { get; set; }

    [Column("fUnallocatedDebits")]
    public double? FUnallocatedDebits { get; set; }

    [Column("fAllocatedDebits")]
    public double? FAllocatedDebits { get; set; }

    [Column("fDiscReceivedExcl")]
    public double? FDiscReceivedExcl { get; set; }

    [Column("fTotalPaidExcl")]
    public double? FTotalPaidExcl { get; set; }

    [Column("fDiscTaxAmount")]
    public double? FDiscTaxAmount { get; set; }

    [Column("bPosted")]
    public bool BPosted { get; set; }

    [Column("bProduceEFTS")]
    public bool BProduceEfts { get; set; }

    [Column("iDiscTaxType")]
    public int? IDiscTaxType { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("dPaymentDate", TypeName = "datetime")]
    public DateTime? DPaymentDate { get; set; }

    [Column("cPayRecIDs")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CPayRecIds { get; set; }

    [Column("bDefaultPayAllInvoices")]
    public bool BDefaultPayAllInvoices { get; set; }

    [Column("cDCCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDccode { get; set; }

    [Column("cDCName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDcname { get; set; }

    [Column("fUnallocatedCredits")]
    public double? FUnallocatedCredits { get; set; }

    [Column("iInvoiceCount")]
    public int? IInvoiceCount { get; set; }

    [Column("iConfiguredCount")]
    public double? IConfiguredCount { get; set; }

    [Column("_etblRemittanceSuppliers_iBranchID")]
    public int? EtblRemittanceSuppliersIBranchId { get; set; }

    [Column("_etblRemittanceSuppliers_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceSuppliersDCreatedDate { get; set; }

    [Column("_etblRemittanceSuppliers_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceSuppliersDModifiedDate { get; set; }

    [Column("_etblRemittanceSuppliers_iCreatedBranchID")]
    public int? EtblRemittanceSuppliersICreatedBranchId { get; set; }

    [Column("_etblRemittanceSuppliers_iModifiedBranchID")]
    public int? EtblRemittanceSuppliersIModifiedBranchId { get; set; }

    [Column("_etblRemittanceSuppliers_iCreatedAgentID")]
    public int? EtblRemittanceSuppliersICreatedAgentId { get; set; }

    [Column("_etblRemittanceSuppliers_iModifiedAgentID")]
    public int? EtblRemittanceSuppliersIModifiedAgentId { get; set; }

    [Column("_etblRemittanceSuppliers_iChangeSetID")]
    public int? EtblRemittanceSuppliersIChangeSetId { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("fAmountToPay")]
    public double FAmountToPay { get; set; }

    [Column("_etblRemittanceSuppliers_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblRemittanceSuppliersChecksum { get; set; }

    [Column("iInstructionType")]
    public int? IInstructionType { get; set; }
}
