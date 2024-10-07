using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("BomComp")]
[Index("BomCompDModifiedDate", Name = "idxBomComp_dModifiedDate")]
[Index("BomCompIBranchId", Name = "idxBomComp_iBranchID")]
[Index("BomCompChecksum", Name = "idx_BomComp_BomComp_Checksum")]
[Index("BomCompIChangeSetId", Name = "idx_BomComp_iChangeSetID")]
public partial class BomComp
{
    [Key]
    public int BomComponentKey { get; set; }

    public int? BomMasterKey { get; set; }

    public int? ComponentStockLink { get; set; }

    public int? ComponentIndex { get; set; }

    public double? ProductionQty { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? UnitOfMeasure { get; set; }

    public double? UnitCost { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("DefaultWhseID")]
    public int? DefaultWhseId { get; set; }

    [Column("fBreakAllocCostPerc")]
    public double? FBreakAllocCostPerc { get; set; }

    [Column("BomComp_iBranchID")]
    public int? BomCompIBranchId { get; set; }

    [Column("BomComp_dCreatedDate", TypeName = "datetime")]
    public DateTime? BomCompDCreatedDate { get; set; }

    [Column("BomComp_dModifiedDate", TypeName = "datetime")]
    public DateTime? BomCompDModifiedDate { get; set; }

    [Column("BomComp_iCreatedBranchID")]
    public int? BomCompICreatedBranchId { get; set; }

    [Column("BomComp_iModifiedBranchID")]
    public int? BomCompIModifiedBranchId { get; set; }

    [Column("BomComp_iCreatedAgentID")]
    public int? BomCompICreatedAgentId { get; set; }

    [Column("BomComp_iModifiedAgentID")]
    public int? BomCompIModifiedAgentId { get; set; }

    [Column("BomComp_iChangeSetID")]
    public int? BomCompIChangeSetId { get; set; }

    [Column("fOffsetLeadTime")]
    public double? FOffsetLeadTime { get; set; }

    [Column("BomComp_Checksum")]
    [MaxLength(20)]
    public byte[]? BomCompChecksum { get; set; }
}
