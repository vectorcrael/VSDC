using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFadepreciationMethodYear
{
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

    [StringLength(19)]
    [Unicode(false)]
    public string? BasisDesc { get; set; }

    [Column("fPercentage")]
    public double FPercentage { get; set; }

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

    [Column("iNoYears")]
    public int? INoYears { get; set; }

    [Column("iUnitsUsage")]
    public int? IUnitsUsage { get; set; }

    [Column("fInitialPercentage")]
    public double? FInitialPercentage { get; set; }

    [Column("cSystemInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CSystemInd { get; set; } = null!;

    [Column("PMYearNo")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PmyearNo { get; set; }

    [Column("PMYearPercentage")]
    public double? PmyearPercentage { get; set; }
}
