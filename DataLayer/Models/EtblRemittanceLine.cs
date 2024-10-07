using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblRemittanceLines")]
[Index("EtblRemittanceLinesChecksum", Name = "idx__etblRemittanceLines__etblRemittanceLines_Checksum")]
[Index("BAllocated", Name = "idx__etblRemittanceLines_bAllocated")]
[Index("BPayTransaction", Name = "idx__etblRemittanceLines_bPayTransaction")]
[Index("IBatchId", Name = "idx__etblRemittanceLines_iBatchID")]
[Index("EtblRemittanceLinesIChangeSetId", Name = "idx__etblRemittanceLines_iChangeSetID")]
[Index("IInvRecId", Name = "idx__etblRemittanceLines_iInvRecID")]
[Index("ISupplierId", Name = "idx__etblRemittanceLines_iSupplierID")]
[Index("ISupplierId", "IBatchId", "BPayTransaction", "IInvRecId", "BAllocated", Name = "idx__etblRemittanceLines_iSupplierIDiBatchIDbPayTransactioniInvRecIDbAllocated")]
[Index("EtblRemittanceLinesDModifiedDate", Name = "idx_etblRemittanceLines_dModifiedDate")]
[Index("EtblRemittanceLinesIBranchId", Name = "idx_etblRemittanceLines_iBranchID")]
public partial class EtblRemittanceLine
{
    [Key]
    [Column("IDRemittanceLines")]
    public int IdremittanceLines { get; set; }

    [Column("iSupplierID")]
    public int? ISupplierId { get; set; }

    [Column("cDocumentNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDocumentNumber { get; set; }

    [Column("fAmountOutstanding")]
    public double? FAmountOutstanding { get; set; }

    [Column("fDiscAmount")]
    public double? FDiscAmount { get; set; }

    [Column("fAmountToPay")]
    public double? FAmountToPay { get; set; }

    [Column("bPayTransaction")]
    public bool BPayTransaction { get; set; }

    [Column("fDiscAmountExcl")]
    public double? FDiscAmountExcl { get; set; }

    [Column("fDiscTaxAmount")]
    public double? FDiscTaxAmount { get; set; }

    [Column("dDocumentDate", TypeName = "datetime")]
    public DateTime? DDocumentDate { get; set; }

    [Column("fDocumentAmount")]
    public double? FDocumentAmount { get; set; }

    [Column("bAllocated")]
    public bool BAllocated { get; set; }

    [Column("iInvRecID")]
    public long? IInvRecId { get; set; }

    [Column("cInvDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CInvDescription { get; set; }

    [Column("cInvReference1")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CInvReference1 { get; set; }

    [Column("cInvReference2")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CInvReference2 { get; set; }

    [Column("iInvSettlementTermsID")]
    public int IInvSettlementTermsId { get; set; }

    [Column("fSettDiscAmount")]
    public double FSettDiscAmount { get; set; }

    [Column("cSettTermCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSettTermCode { get; set; }

    [Column("fSettTermDiscPerc")]
    public double FSettTermDiscPerc { get; set; }

    [Column("iSettTermDays")]
    public int ISettTermDays { get; set; }

    [Column("iSettTermPayMethod")]
    public int ISettTermPayMethod { get; set; }

    [Column("bApplyDisc")]
    public bool BApplyDisc { get; set; }

    [Column("fDiscPerc")]
    public double FDiscPerc { get; set; }

    [Column("cInvOrderNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CInvOrderNumber { get; set; }

    [Column("_etblRemittanceLines_iBranchID")]
    public int? EtblRemittanceLinesIBranchId { get; set; }

    [Column("_etblRemittanceLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceLinesDCreatedDate { get; set; }

    [Column("_etblRemittanceLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceLinesDModifiedDate { get; set; }

    [Column("_etblRemittanceLines_iCreatedBranchID")]
    public int? EtblRemittanceLinesICreatedBranchId { get; set; }

    [Column("_etblRemittanceLines_iModifiedBranchID")]
    public int? EtblRemittanceLinesIModifiedBranchId { get; set; }

    [Column("_etblRemittanceLines_iCreatedAgentID")]
    public int? EtblRemittanceLinesICreatedAgentId { get; set; }

    [Column("_etblRemittanceLines_iModifiedAgentID")]
    public int? EtblRemittanceLinesIModifiedAgentId { get; set; }

    [Column("_etblRemittanceLines_iChangeSetID")]
    public int? EtblRemittanceLinesIChangeSetId { get; set; }

    [Column("bTxOnHold")]
    public bool BTxOnHold { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("fAmountPaid")]
    public double FAmountPaid { get; set; }

    [Column("_etblRemittanceLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblRemittanceLinesChecksum { get; set; }
}
