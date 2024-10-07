using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvInvJrBatch
{
    [Column("IDInvJrBatches")]
    public int IdinvJrBatches { get; set; }

    [Column("cInvJrNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvJrNumber { get; set; }

    [Column("cInvJrDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CInvJrDescription { get; set; }

    [Column("cInvJrReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvJrReference { get; set; }

    [Column("iCreateAgentID")]
    public int ICreateAgentId { get; set; }

    [Column("bClearAfterPost")]
    public bool BClearAfterPost { get; set; }

    [Column("bAllowDupRef")]
    public bool BAllowDupRef { get; set; }

    [Column("bAllowEditGLContra")]
    public bool BAllowEditGlcontra { get; set; }

    [Column("iNewLineDateOpt")]
    public int? INewLineDateOpt { get; set; }

    [Column("dNewLineDateDef", TypeName = "datetime")]
    public DateTime? DNewLineDateDef { get; set; }

    [Column("iNewLineRefOpt")]
    public int? INewLineRefOpt { get; set; }

    [Column("cNewLineRefDef")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CNewLineRefDef { get; set; }

    [Column("bNewLineRefInc")]
    public bool BNewLineRefInc { get; set; }

    [Column("iNewLineDescOpt")]
    public int? INewLineDescOpt { get; set; }

    [Column("cNewLineDescDef")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CNewLineDescDef { get; set; }

    [Column("bNewLineDescInc")]
    public bool BNewLineDescInc { get; set; }

    [Column("iNewLineProjectOpt")]
    public int? INewLineProjectOpt { get; set; }

    [Column("iNewLineProjectDefID")]
    public int INewLineProjectDefId { get; set; }

    [Column("iNewLineWarehouseOpt")]
    public int? INewLineWarehouseOpt { get; set; }

    [Column("iNewLineWarehouseDefID")]
    public int INewLineWarehouseDefId { get; set; }

    [Column("bJustCleared")]
    public bool BJustCleared { get; set; }

    [Column("_etblInvJrBatches_iBranchID")]
    public int? EtblInvJrBatchesIBranchId { get; set; }

    [Column("_etblInvJrBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchesDCreatedDate { get; set; }

    [Column("_etblInvJrBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchesDModifiedDate { get; set; }

    [Column("_etblInvJrBatches_iCreatedBranchID")]
    public int? EtblInvJrBatchesICreatedBranchId { get; set; }

    [Column("_etblInvJrBatches_iModifiedBranchID")]
    public int? EtblInvJrBatchesIModifiedBranchId { get; set; }

    [Column("_etblInvJrBatches_iCreatedAgentID")]
    public int? EtblInvJrBatchesICreatedAgentId { get; set; }

    [Column("_etblInvJrBatches_iModifiedAgentID")]
    public int? EtblInvJrBatchesIModifiedAgentId { get; set; }

    [Column("_etblInvJrBatches_iChangeSetID")]
    public int? EtblInvJrBatchesIChangeSetId { get; set; }

    [Column("iTransactionCode")]
    public int? ITransactionCode { get; set; }

    [Column("_etblInvJrBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvJrBatchesChecksum { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }
}
