using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RecurRTX")]
[Index("RecurRtxDModifiedDate", Name = "idxRecurRTX_dModifiedDate")]
[Index("RecurRtxIBranchId", Name = "idxRecurRTX_iBranchID")]
[Index("RecurRtxChecksum", Name = "idx_RecurRTX_RecurRTX_Checksum")]
[Index("RecurRtxIChangeSetId", Name = "idx_RecurRTX_iChangeSetID")]
public partial class RecurRtx
{
    [Key]
    public int AutoIdx { get; set; }

    public int? ListIdx { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TxDate { get; set; }

    public double? TxAmount { get; set; }

    [Column("cTxAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTxAuditNumber { get; set; }

    [Column("iInvNumID")]
    public int? IInvNumId { get; set; }

    [Column("bDebitOrderPosted")]
    public bool BDebitOrderPosted { get; set; }

    [Column("bPaymentCreated")]
    public bool BPaymentCreated { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    public double? ExchangeRate { get; set; }

    public double? TxAmountForeign { get; set; }

    [Column("RecurRTX_iBranchID")]
    public int? RecurRtxIBranchId { get; set; }

    [Column("RecurRTX_dCreatedDate", TypeName = "datetime")]
    public DateTime? RecurRtxDCreatedDate { get; set; }

    [Column("RecurRTX_dModifiedDate", TypeName = "datetime")]
    public DateTime? RecurRtxDModifiedDate { get; set; }

    [Column("RecurRTX_iCreatedBranchID")]
    public int? RecurRtxICreatedBranchId { get; set; }

    [Column("RecurRTX_iModifiedBranchID")]
    public int? RecurRtxIModifiedBranchId { get; set; }

    [Column("RecurRTX_iCreatedAgentID")]
    public int? RecurRtxICreatedAgentId { get; set; }

    [Column("RecurRTX_iModifiedAgentID")]
    public int? RecurRtxIModifiedAgentId { get; set; }

    [Column("RecurRTX_iChangeSetID")]
    public int? RecurRtxIChangeSetId { get; set; }

    [Column("RecurRTX_Checksum")]
    [MaxLength(20)]
    public byte[]? RecurRtxChecksum { get; set; }
}
