using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFacapexOderBudgetLookup
{
    [Column("idCapexOrderNo")]
    public int IdCapexOrderNo { get; set; }

    [Column("cCapexOrderCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CCapexOrderCode { get; set; } = null!;

    [Column("iCapexBudgetNo")]
    public int ICapexBudgetNo { get; set; }

    [Column("dCapexOrderDate", TypeName = "smalldatetime")]
    public DateTime DCapexOrderDate { get; set; }

    [Column("fCapexOrderAmount")]
    public double FCapexOrderAmount { get; set; }

    [Column("cCapexOrderDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CCapexOrderDesc { get; set; } = null!;

    [Column("_btblFACapexOrder_iBranchID")]
    public int? BtblFacapexOrderIBranchId { get; set; }

    [Column("_btblFACapexOrder_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFacapexOrderDCreatedDate { get; set; }

    [Column("_btblFACapexOrder_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFacapexOrderDModifiedDate { get; set; }

    [Column("_btblFACapexOrder_iCreatedBranchID")]
    public int? BtblFacapexOrderICreatedBranchId { get; set; }

    [Column("_btblFACapexOrder_iModifiedBranchID")]
    public int? BtblFacapexOrderIModifiedBranchId { get; set; }

    [Column("_btblFACapexOrder_iCreatedAgentID")]
    public int? BtblFacapexOrderICreatedAgentId { get; set; }

    [Column("_btblFACapexOrder_iModifiedAgentID")]
    public int? BtblFacapexOrderIModifiedAgentId { get; set; }

    [Column("_btblFACapexOrder_iChangeSetID")]
    public int? BtblFacapexOrderIChangeSetId { get; set; }

    [Column("_btblFACapexOrder_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFacapexOrderChecksum { get; set; }

    [Column("AssetTypeID")]
    public int AssetTypeId { get; set; }

    [Column("CostCenterID")]
    public int? CostCenterId { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string CapexDesc { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string AssetTypeDesc { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string AssetTypeCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CostCenterCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CostCenterName { get; set; }
}
