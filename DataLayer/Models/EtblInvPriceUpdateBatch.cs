using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvPriceUpdateBatches")]
[Index("EtblInvPriceUpdateBatchesChecksum", Name = "idx__etblInvPriceUpdateBatches__etblInvPriceUpdateBatches_Checksum")]
[Index("EtblInvPriceUpdateBatchesDModifiedDate", Name = "idx__etblInvPriceUpdateBatches__etblInvPriceUpdateBatches_dModifiedDate")]
[Index("EtblInvPriceUpdateBatchesIBranchId", Name = "idx__etblInvPriceUpdateBatches__etblInvPriceUpdateBatches_iBranchID")]
[Index("EtblInvPriceUpdateBatchesIChangeSetId", Name = "idx__etblInvPriceUpdateBatches__etblInvPriceUpdateBatches_iChangeSetID")]
public partial class EtblInvPriceUpdateBatch
{
    [Key]
    [Column("idInvPriceUpdateBatches")]
    public int IdInvPriceUpdateBatches { get; set; }

    [Column("cInvPriceUpdateNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvPriceUpdateNumber { get; set; }

    [Column("cInvPriceUpdateDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CInvPriceUpdateDescription { get; set; }

    [Column("cInvPriceUpdateReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvPriceUpdateReference { get; set; }

    [Column("cStartCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CStartCode { get; set; }

    [Column("cEndCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CEndCode { get; set; }

    [Column("cGroups")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CGroups { get; set; }

    [Column("cWarehouses")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CWarehouses { get; set; }

    [Column("bUpdateAllWarehouses")]
    public bool BUpdateAllWarehouses { get; set; }

    [Column("bSalesWarehouses")]
    public bool BSalesWarehouses { get; set; }

    [Column("bIgnoreInactive")]
    public bool BIgnoreInactive { get; set; }

    [Column("cPriceLists")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CPriceLists { get; set; }

    [Column("iUpdateType")]
    public int? IUpdateType { get; set; }

    [Column("iUpdateAction")]
    public int? IUpdateAction { get; set; }

    [Column("iRounding")]
    public int? IRounding { get; set; }

    [Column("iToNearest")]
    public int? IToNearest { get; set; }

    [Column("bPosted")]
    public bool BPosted { get; set; }

    [Column("_etblInvPriceUpdateBatches_iBranchID")]
    public int? EtblInvPriceUpdateBatchesIBranchId { get; set; }

    [Column("_etblInvPriceUpdateBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvPriceUpdateBatchesDCreatedDate { get; set; }

    [Column("_etblInvPriceUpdateBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvPriceUpdateBatchesDModifiedDate { get; set; }

    [Column("_etblInvPriceUpdateBatches_iCreatedBranchID")]
    public int? EtblInvPriceUpdateBatchesICreatedBranchId { get; set; }

    [Column("_etblInvPriceUpdateBatches_iModifiedBranchID")]
    public int? EtblInvPriceUpdateBatchesIModifiedBranchId { get; set; }

    [Column("_etblInvPriceUpdateBatches_iCreatedAgentID")]
    public int? EtblInvPriceUpdateBatchesICreatedAgentId { get; set; }

    [Column("_etblInvPriceUpdateBatches_iModifiedAgentID")]
    public int? EtblInvPriceUpdateBatchesIModifiedAgentId { get; set; }

    [Column("_etblInvPriceUpdateBatches_iChangeSetID")]
    public int? EtblInvPriceUpdateBatchesIChangeSetId { get; set; }

    [Column("_etblInvPriceUpdateBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvPriceUpdateBatchesChecksum { get; set; }
}
