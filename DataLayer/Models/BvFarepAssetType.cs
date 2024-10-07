using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFarepAssetType
{
    [Column("idAssetTypeNo")]
    public int IdAssetTypeNo { get; set; }

    [Column("cAssetTypeCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CAssetTypeCode { get; set; } = null!;

    [Column("cAssetTypeDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CAssetTypeDesc { get; set; } = null!;

    [Column("fRevaluationIndex")]
    public double FRevaluationIndex { get; set; }

    [Column("fInsuranceIndex")]
    public double FInsuranceIndex { get; set; }

    [Column("fInsuranceCostFactor")]
    public double FInsuranceCostFactor { get; set; }

    [Column("fResidualFactor")]
    public double FResidualFactor { get; set; }

    [Column("iDepreciationNo")]
    public int IDepreciationNo { get; set; }

    [Column("iTaxDepreciationNo")]
    public int ITaxDepreciationNo { get; set; }

    [Column("_btblFAAssetType_iBranchID")]
    public int? BtblFaassetTypeIBranchId { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? BookDepreciationDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BookBasisInd { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? BookBasisDesc { get; set; }

    public double? BookPercentage { get; set; }

    public int? BookNoYears { get; set; }

    public int? BookUnitsUsage { get; set; }

    public double? BookInitialPercentage { get; set; }

    public double? BookResidualValue { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? TaxDepreciationDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TaxBasisInd { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? TaxBasisDesc { get; set; }

    public double? TaxPercentage { get; set; }

    public int? TaxNoYears { get; set; }

    public int? TaxUnitsUsage { get; set; }

    public double? TaxInitialPercentage { get; set; }

    public double? TaxResidualValue { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? DepreciationExpenseAccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? AccumulatedDepreciationAccount { get; set; }
}
