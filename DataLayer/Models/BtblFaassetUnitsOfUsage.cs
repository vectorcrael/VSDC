using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAAssetUnitsOfUsage")]
[Index("BtblFaassetUnitsOfUsageChecksum", Name = "idx__btblFAAssetUnitsOfUsage__btblFAAssetUnitsOfUsage_Checksum")]
[Index("BtblFaassetUnitsOfUsageIChangeSetId", Name = "idx__btblFAAssetUnitsOfUsage_iChangeSetID")]
[Index("BtblFaassetUnitsOfUsageDModifiedDate", Name = "idx_btblFAAssetUnitsOfUsage_dModifiedDate")]
[Index("BtblFaassetUnitsOfUsageIBranchId", Name = "idx_btblFAAssetUnitsOfUsage_iBranchID")]
public partial class BtblFaassetUnitsOfUsage
{
    [Key]
    [Column("idAssetUnitNo")]
    public int IdAssetUnitNo { get; set; }

    [Column("fNoOfUnits")]
    public double FNoOfUnits { get; set; }

    [Column("iAssetNo")]
    public int IAssetNo { get; set; }

    [Column("iGLPeriodNo")]
    public int IGlperiodNo { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("cDeprTypeInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CDeprTypeInd { get; set; } = null!;

    [Column("_btblFAAssetUnitsOfUsage_iBranchID")]
    public int? BtblFaassetUnitsOfUsageIBranchId { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetUnitsOfUsageDCreatedDate { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetUnitsOfUsageDModifiedDate { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_iCreatedBranchID")]
    public int? BtblFaassetUnitsOfUsageICreatedBranchId { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_iModifiedBranchID")]
    public int? BtblFaassetUnitsOfUsageIModifiedBranchId { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_iCreatedAgentID")]
    public int? BtblFaassetUnitsOfUsageICreatedAgentId { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_iModifiedAgentID")]
    public int? BtblFaassetUnitsOfUsageIModifiedAgentId { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_iChangeSetID")]
    public int? BtblFaassetUnitsOfUsageIChangeSetId { get; set; }

    [Column("_btblFAAssetUnitsOfUsage_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetUnitsOfUsageChecksum { get; set; }
}
