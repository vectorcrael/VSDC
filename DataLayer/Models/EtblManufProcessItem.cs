using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblManufProcessItem")]
[Index("EtblManufProcessItemChecksum", Name = "idx__etblManufProcessItem__etblManufProcessItem_Checksum")]
[Index("EtblManufProcessItemIChangeSetId", Name = "idx__etblManufProcessItem_iChangeSetID")]
[Index("EtblManufProcessItemDModifiedDate", Name = "idx_etblManufProcessItem_dModifiedDate")]
[Index("EtblManufProcessItemIBranchId", Name = "idx_etblManufProcessItem_iBranchID")]
[Index("IInvItemId", Name = "idx_etblManufProcessItem_iInvItemID")]
[Index("IMfpitemId", Name = "idx_etblManufProcessItem_iMFPItemID")]
[Index("IManufProcessId", Name = "idx_etblManufProcessItem_iManufProcessID")]
public partial class EtblManufProcessItem
{
    [Key]
    [Column("idManufProcessItem")]
    public long IdManufProcessItem { get; set; }

    [Column("iMFPItemID")]
    public double? IMfpitemId { get; set; }

    [Column("iParentMFPItemID")]
    public int IParentMfpitemId { get; set; }

    [Column("iManufProcessID")]
    public int IManufProcessId { get; set; }

    [Column("iInvItemID")]
    public int? IInvItemId { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fProductionQty")]
    public double? FProductionQty { get; set; }

    [Column("cUnitOfMeasure")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CUnitOfMeasure { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("iDefaultWhseID")]
    public int? IDefaultWhseId { get; set; }

    [Column("_etblManufProcessItem_iBranchID")]
    public int? EtblManufProcessItemIBranchId { get; set; }

    [Column("_etblManufProcessItem_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessItemDCreatedDate { get; set; }

    [Column("_etblManufProcessItem_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessItemDModifiedDate { get; set; }

    [Column("_etblManufProcessItem_iCreatedBranchID")]
    public int? EtblManufProcessItemICreatedBranchId { get; set; }

    [Column("_etblManufProcessItem_iModifiedBranchID")]
    public int? EtblManufProcessItemIModifiedBranchId { get; set; }

    [Column("_etblManufProcessItem_iCreatedAgentID")]
    public int? EtblManufProcessItemICreatedAgentId { get; set; }

    [Column("_etblManufProcessItem_iModifiedAgentID")]
    public int? EtblManufProcessItemIModifiedAgentId { get; set; }

    [Column("_etblManufProcessItem_iChangeSetID")]
    public int? EtblManufProcessItemIChangeSetId { get; set; }

    [Column("_etblManufProcessItem_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblManufProcessItemChecksum { get; set; }
}
