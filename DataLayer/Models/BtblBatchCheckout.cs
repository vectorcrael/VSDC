using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblBatchCheckout")]
[Index("BtblBatchCheckoutChecksum", Name = "idx__btblBatchCheckout__btblBatchCheckout_Checksum")]
[Index("BtblBatchCheckoutIChangeSetId", Name = "idx__btblBatchCheckout_iChangeSetID")]
[Index("BtblBatchCheckoutDModifiedDate", Name = "idx_btblBatchCheckout_dModifiedDate")]
[Index("BtblBatchCheckoutIBranchId", Name = "idx_btblBatchCheckout_iBranchID")]
public partial class BtblBatchCheckout
{
    [Key]
    [Column("idBatchCheckout")]
    public int IdBatchCheckout { get; set; }

    [Column("cBatchClass")]
    [StringLength(32)]
    [Unicode(false)]
    public string CBatchClass { get; set; } = null!;

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("cNetworkUser")]
    [StringLength(32)]
    [Unicode(false)]
    public string CNetworkUser { get; set; } = null!;

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cCheckoutGUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string CCheckoutGuid { get; set; } = null!;

    [Column("bIncludeOpenBatches")]
    public bool BIncludeOpenBatches { get; set; }

    [Column("_btblBatchCheckout_iBranchID")]
    public int? BtblBatchCheckoutIBranchId { get; set; }

    [Column("_btblBatchCheckout_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblBatchCheckoutDCreatedDate { get; set; }

    [Column("_btblBatchCheckout_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblBatchCheckoutDModifiedDate { get; set; }

    [Column("_btblBatchCheckout_iCreatedBranchID")]
    public int? BtblBatchCheckoutICreatedBranchId { get; set; }

    [Column("_btblBatchCheckout_iModifiedBranchID")]
    public int? BtblBatchCheckoutIModifiedBranchId { get; set; }

    [Column("_btblBatchCheckout_iCreatedAgentID")]
    public int? BtblBatchCheckoutICreatedAgentId { get; set; }

    [Column("_btblBatchCheckout_iModifiedAgentID")]
    public int? BtblBatchCheckoutIModifiedAgentId { get; set; }

    [Column("_btblBatchCheckout_iChangeSetID")]
    public int? BtblBatchCheckoutIChangeSetId { get; set; }

    [Column("_btblBatchCheckout_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblBatchCheckoutChecksum { get; set; }
}
