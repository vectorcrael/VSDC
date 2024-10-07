using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFADepreciationMethod")]
[Index("BtblFadepreciationMethodChecksum", Name = "idx__btblFADepreciationMethod__btblFADepreciationMethod_Checksum")]
[Index("BtblFadepreciationMethodIChangeSetId", Name = "idx__btblFADepreciationMethod_iChangeSetID")]
[Index("BtblFadepreciationMethodDModifiedDate", Name = "idx_btblFADepreciationMethod_dModifiedDate")]
[Index("BtblFadepreciationMethodIBranchId", Name = "idx_btblFADepreciationMethod_iBranchID")]
public partial class BtblFadepreciationMethod
{
    [Key]
    [Column("idDepreciationNo")]
    public int IdDepreciationNo { get; set; }

    [Column("cDepreciationDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CDepreciationDesc { get; set; } = null!;

    [Column("cBasisInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CBasisInd { get; set; } = null!;

    [Column("fPercentage")]
    public double FPercentage { get; set; }

    [Column("iNoYears")]
    public int? INoYears { get; set; }

    [Column("iUnitsUsage")]
    public int? IUnitsUsage { get; set; }

    [Column("fInitialPercentage")]
    public double? FInitialPercentage { get; set; }

    [Column("fResidualValue")]
    public double? FResidualValue { get; set; }

    [Column("cSystemInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CSystemInd { get; set; } = null!;

    [Column("_btblFADepreciationMethod_iBranchID")]
    public int? BtblFadepreciationMethodIBranchId { get; set; }

    [Column("_btblFADepreciationMethod_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFadepreciationMethodDCreatedDate { get; set; }

    [Column("_btblFADepreciationMethod_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFadepreciationMethodDModifiedDate { get; set; }

    [Column("_btblFADepreciationMethod_iCreatedBranchID")]
    public int? BtblFadepreciationMethodICreatedBranchId { get; set; }

    [Column("_btblFADepreciationMethod_iModifiedBranchID")]
    public int? BtblFadepreciationMethodIModifiedBranchId { get; set; }

    [Column("_btblFADepreciationMethod_iCreatedAgentID")]
    public int? BtblFadepreciationMethodICreatedAgentId { get; set; }

    [Column("_btblFADepreciationMethod_iModifiedAgentID")]
    public int? BtblFadepreciationMethodIModifiedAgentId { get; set; }

    [Column("_btblFADepreciationMethod_iChangeSetID")]
    public int? BtblFadepreciationMethodIChangeSetId { get; set; }

    [Column("_btblFADepreciationMethod_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFadepreciationMethodChecksum { get; set; }
}
