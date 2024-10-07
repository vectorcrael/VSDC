using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("_btblFAPeriodClose")]
[Index("BtblFaperiodCloseChecksum", Name = "idx__btblFAPeriodClose__btblFAPeriodClose_Checksum")]
[Index("BtblFaperiodCloseIChangeSetId", Name = "idx__btblFAPeriodClose_iChangeSetID")]
[Index("BtblFaperiodCloseDModifiedDate", Name = "idx_btblFAPeriodClose_dModifiedDate")]
[Index("BtblFaperiodCloseIBranchId", Name = "idx_btblFAPeriodClose_iBranchID")]
public partial class BtblFaperiodClose
{
    [Column("idPeriodClose")]
    public int IdPeriodClose { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    public string? CAssetCode { get; set; }

    [Column("dPeriodCloseDate", TypeName = "datetime")]
    public DateTime? DPeriodCloseDate { get; set; }

    [Column("iGLPeriodNoID")]
    public int IGlperiodNoId { get; set; }

    [Column("fBookCurrentYearDepreciation")]
    public double? FBookCurrentYearDepreciation { get; set; }

    [Column("fBookPriorYearDepreciation")]
    public double? FBookPriorYearDepreciation { get; set; }

    [Column("fWTCurrentYearDepreciation")]
    public double? FWtcurrentYearDepreciation { get; set; }

    [Column("fWTPriorYearDepreciation")]
    public double? FWtpriorYearDepreciation { get; set; }

    [Column("fTotalBookBlockPeriod")]
    public double? FTotalBookBlockPeriod { get; set; }

    [Column("fTotalWTBlockPeriod")]
    public double? FTotalWtblockPeriod { get; set; }

    [Column("bReopened")]
    public bool? BReopened { get; set; }

    [Column("_btblFAPeriodClose_iBranchID")]
    public int? BtblFaperiodCloseIBranchId { get; set; }

    [Column("_btblFAPeriodClose_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaperiodCloseDCreatedDate { get; set; }

    [Column("_btblFAPeriodClose_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaperiodCloseDModifiedDate { get; set; }

    [Column("_btblFAPeriodClose_iCreatedBranchID")]
    public int? BtblFaperiodCloseICreatedBranchId { get; set; }

    [Column("_btblFAPeriodClose_iModifiedBranchID")]
    public int? BtblFaperiodCloseIModifiedBranchId { get; set; }

    [Column("_btblFAPeriodClose_iCreatedAgentID")]
    public int? BtblFaperiodCloseICreatedAgentId { get; set; }

    [Column("_btblFAPeriodClose_iModifiedAgentID")]
    public int? BtblFaperiodCloseIModifiedAgentId { get; set; }

    [Column("_btblFAPeriodClose_iChangeSetID")]
    public int? BtblFaperiodCloseIChangeSetId { get; set; }

    [Column("_btblFAPeriodClose_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaperiodCloseChecksum { get; set; }
}
