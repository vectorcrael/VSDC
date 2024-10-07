using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvCountLinesUOM")]
[Index("BtblInvCountLinesUomChecksum", Name = "idx__btblInvCountLinesUOM__btblInvCountLinesUOM_Checksum")]
[Index("BtblInvCountLinesUomIChangeSetId", Name = "idx__btblInvCountLinesUOM_iChangeSetID")]
[Index("BtblInvCountLinesUomDModifiedDate", Name = "idx_btblInvCountLinesUOM_dModifiedDate")]
[Index("BtblInvCountLinesUomIBranchId", Name = "idx_btblInvCountLinesUOM_iBranchID")]
public partial class BtblInvCountLinesUom
{
    [Key]
    [Column("IDInvCountLinesUOM")]
    public long IdinvCountLinesUom { get; set; }

    [Column("iInvCountID")]
    public int IInvCountId { get; set; }

    [Column("iInvCountLinesID")]
    public long IInvCountLinesId { get; set; }

    [Column("iUnitsID")]
    public int IUnitsId { get; set; }

    [Column("fUnitCountQty")]
    public double? FUnitCountQty { get; set; }

    [Column("_btblInvCountLinesUOM_iBranchID")]
    public int? BtblInvCountLinesUomIBranchId { get; set; }

    [Column("_btblInvCountLinesUOM_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountLinesUomDCreatedDate { get; set; }

    [Column("_btblInvCountLinesUOM_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountLinesUomDModifiedDate { get; set; }

    [Column("_btblInvCountLinesUOM_iCreatedBranchID")]
    public int? BtblInvCountLinesUomICreatedBranchId { get; set; }

    [Column("_btblInvCountLinesUOM_iModifiedBranchID")]
    public int? BtblInvCountLinesUomIModifiedBranchId { get; set; }

    [Column("_btblInvCountLinesUOM_iCreatedAgentID")]
    public int? BtblInvCountLinesUomICreatedAgentId { get; set; }

    [Column("_btblInvCountLinesUOM_iModifiedAgentID")]
    public int? BtblInvCountLinesUomIModifiedAgentId { get; set; }

    [Column("_btblInvCountLinesUOM_iChangeSetID")]
    public int? BtblInvCountLinesUomIChangeSetId { get; set; }

    [Column("iCountedPieces")]
    public int ICountedPieces { get; set; }

    [Column("fLength")]
    public double FLength { get; set; }

    [Column("fHeight")]
    public double FHeight { get; set; }

    [Column("fWidth")]
    public double FWidth { get; set; }

    [Column("_btblInvCountLinesUOM_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvCountLinesUomChecksum { get; set; }
}
