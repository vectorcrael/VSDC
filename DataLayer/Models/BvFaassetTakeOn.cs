using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaassetTakeOn
{
    [Column("idAssetNo")]
    public int IdAssetNo { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CAssetCode { get; set; } = null!;

    [Column("cTransferInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CTransferInd { get; set; }

    [Column("iFromAssetNo")]
    public int? IFromAssetNo { get; set; }

    [Column("dFromTransferDate", TypeName = "smalldatetime")]
    public DateTime? DFromTransferDate { get; set; }

    [Column("iFromTransferPeriodNo")]
    public int? IFromTransferPeriodNo { get; set; }

    [Column("iToAssetNo")]
    public int? IToAssetNo { get; set; }

    [Column("dToTransferDate", TypeName = "smalldatetime")]
    public DateTime? DToTransferDate { get; set; }

    [Column("iToTransferPeriodNo")]
    public int? IToTransferPeriodNo { get; set; }

    [Column("cAssetDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CAssetDesc { get; set; } = null!;

    [Column("iAssetTypeNo")]
    public int IAssetTypeNo { get; set; }

    [Column("iCostCenterNo")]
    public int? ICostCenterNo { get; set; }

    [Column("iLocationNo")]
    public int? ILocationNo { get; set; }

    [Column("iSupplierNo")]
    public int? ISupplierNo { get; set; }

    [Column("iCapexBudgetNo")]
    public int? ICapexBudgetNo { get; set; }

    [Column("iCapexOrderNo")]
    public int? ICapexOrderNo { get; set; }

    [Column("fNoOfUnits")]
    public double FNoOfUnits { get; set; }

    [Column("dPurchaseDate", TypeName = "smalldatetime")]
    public DateTime DPurchaseDate { get; set; }

    [Column("dDepreciationStartDate", TypeName = "smalldatetime")]
    public DateTime DDepreciationStartDate { get; set; }

    [Column("iDepreciationStartPeriodNo")]
    public int? IDepreciationStartPeriodNo { get; set; }

    [Column("dWTStartDate", TypeName = "smalldatetime")]
    public DateTime DWtstartDate { get; set; }

    [Column("iWTStartPeriodNo")]
    public int? IWtstartPeriodNo { get; set; }

    [Column("fPurchaseValue")]
    public double FPurchaseValue { get; set; }

    [Column("fRevalueValue")]
    public double FRevalueValue { get; set; }

    [Column("fInsuredValue")]
    public double FInsuredValue { get; set; }

    [Column("fResidualValue")]
    public double FResidualValue { get; set; }

    [Column("fScrapValue")]
    public double FScrapValue { get; set; }

    [Column("fDeprPriorYearsTakeOn")]
    public double? FDeprPriorYearsTakeOn { get; set; }

    [Column("fDeprCurrYearTakeOn")]
    public double? FDeprCurrYearTakeOn { get; set; }

    [Column("fWTPriorYearsTakeOn")]
    public double? FWtpriorYearsTakeOn { get; set; }

    [Column("fWTCurrYearTakeOn")]
    public double? FWtcurrYearTakeOn { get; set; }

    [Column("fSellingPrice")]
    public double? FSellingPrice { get; set; }

    [Column("dSellingDate", TypeName = "smalldatetime")]
    public DateTime? DSellingDate { get; set; }

    [Column("dReplacementDate", TypeName = "smalldatetime")]
    public DateTime? DReplacementDate { get; set; }

    [Column("fReplacementCost")]
    public double? FReplacementCost { get; set; }

    [Column("iBookOverrideMonths")]
    public int? IBookOverrideMonths { get; set; }

    [Column("iTaxOverrideMonths")]
    public int? ITaxOverrideMonths { get; set; }

    [Column("dLastImportDate", TypeName = "smalldatetime")]
    public DateTime? DLastImportDate { get; set; }

    [Column("iToAssetNo2")]
    public int? IToAssetNo2 { get; set; }

    [Column("cCurrentInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CCurrentInd { get; set; }

    [Column("cBarCode")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CBarCode { get; set; }

    [Column("dOverrideDate", TypeName = "smalldatetime")]
    public DateTime? DOverrideDate { get; set; }

    [Column("dOriginalWTStartDate", TypeName = "smalldatetime")]
    public DateTime DOriginalWtstartDate { get; set; }

    [Column("dOriginalDeprStartDate", TypeName = "smalldatetime")]
    public DateTime DOriginalDeprStartDate { get; set; }

    [Column("iMasterAssetID")]
    public int? IMasterAssetId { get; set; }

    [Column("cMasterAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CMasterAssetCode { get; set; }

    [Column("fBookInitialAllowance")]
    public double? FBookInitialAllowance { get; set; }

    [Column("fTaxInitialAllowance")]
    public double? FTaxInitialAllowance { get; set; }

    [Column("bInitialAllowancePosted")]
    public bool BInitialAllowancePosted { get; set; }

    [Column("fDivAssetBookPriorYearDepr")]
    public double? FDivAssetBookPriorYearDepr { get; set; }

    [Column("fDivAssetBookCurrYearDepr")]
    public double? FDivAssetBookCurrYearDepr { get; set; }

    [Column("fDivAssetTaxPriorYearDepr")]
    public double? FDivAssetTaxPriorYearDepr { get; set; }

    [Column("fDivAssetTaxCurrYearDepr")]
    public double? FDivAssetTaxCurrYearDepr { get; set; }

    [Column("iDivAssetBookBlockPeriods")]
    public int? IDivAssetBookBlockPeriods { get; set; }

    [Column("iDivAssetTaxBlockPeriods")]
    public int? IDivAssetTaxBlockPeriods { get; set; }

    [Column("cSellOrScrap")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CSellOrScrap { get; set; }

    [Column("cSellScrapReason")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CSellScrapReason { get; set; }

    [Column("dDivDate", TypeName = "datetime")]
    public DateTime? DDivDate { get; set; }

    [Column("fWTResidualValue")]
    public double? FWtresidualValue { get; set; }

    [Column("bWTWriteOffAsset")]
    public bool? BWtwriteOffAsset { get; set; }

    [Column("fCGTBaseCost")]
    public double? FCgtbaseCost { get; set; }

    [Column("bCGTRolloverRelief")]
    public bool? BCgtrolloverRelief { get; set; }

    [Column("idFinMethod")]
    public int? IdFinMethod { get; set; }

    [Column("fFinRate")]
    public double? FFinRate { get; set; }

    [Column("fFinResidual")]
    public double? FFinResidual { get; set; }

    [Column("cFinSecurities")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CFinSecurities { get; set; }

    [Column("fFinPeriod")]
    public int? FFinPeriod { get; set; }

    [Column("cFinAccountNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CFinAccountNumber { get; set; }

    [Column("cFinWhere")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CFinWhere { get; set; }

    [Column("fImpairmentCost")]
    public double? FImpairmentCost { get; set; }

    [Column("cRevaluationMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRevaluationMethod { get; set; }

    [Column("_btblFAAsset_iBranchID")]
    public int? BtblFaassetIBranchId { get; set; }

    [Column("_btblFAAsset_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetDCreatedDate { get; set; }

    [Column("_btblFAAsset_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetDModifiedDate { get; set; }

    [Column("_btblFAAsset_iCreatedBranchID")]
    public int? BtblFaassetICreatedBranchId { get; set; }

    [Column("_btblFAAsset_iModifiedBranchID")]
    public int? BtblFaassetIModifiedBranchId { get; set; }

    [Column("_btblFAAsset_iCreatedAgentID")]
    public int? BtblFaassetICreatedAgentId { get; set; }

    [Column("_btblFAAsset_iModifiedAgentID")]
    public int? BtblFaassetIModifiedAgentId { get; set; }

    [Column("_btblFAAsset_iChangeSetID")]
    public int? BtblFaassetIChangeSetId { get; set; }

    [Column("_btblFAAsset_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetChecksum { get; set; }

    [Column("cAssetTypeCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetTypeCode { get; set; }

    [Column("cAssetTypeDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CAssetTypeDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CostName { get; set; }

    public int? DeptNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DeptCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeptDesc { get; set; }

    [Column("cLocationCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CLocationCode { get; set; }

    [Column("cLocationDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CLocationDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("idCapexBudgetNo")]
    public int? IdCapexBudgetNo { get; set; }

    [Column("cCapexDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CCapexDesc { get; set; }

    [Column("cReplacementNewInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CReplacementNewInd { get; set; }

    [Column("fBudgetAmount")]
    public double? FBudgetAmount { get; set; }

    [Column("fAmountSpent")]
    public double? FAmountSpent { get; set; }

    [Column("fAmountCommited")]
    public double? FAmountCommited { get; set; }

    [Column("dCapitalisationDate", TypeName = "smalldatetime")]
    public DateTime? DCapitalisationDate { get; set; }

    [Column("idCapexOrderNo")]
    public int? IdCapexOrderNo { get; set; }

    [Column("dCapexOrderDate", TypeName = "smalldatetime")]
    public DateTime? DCapexOrderDate { get; set; }

    [Column("fCapexOrderAmount")]
    public double? FCapexOrderAmount { get; set; }

    [Column("cCapexOrderCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CCapexOrderCode { get; set; }

    [Column("cCapexOrderDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CCapexOrderDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BookBasis { get; set; }

    public double? BookPercentage { get; set; }

    public int? BookYears { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TaxBasis { get; set; }

    public double? TaxPercentage { get; set; }

    public int? TaxYears { get; set; }

    public int BookPriorYearsDepreciation { get; set; }

    public int BookCurrentYearDepreciation { get; set; }

    public int BookCurrentPeriodDepreciation { get; set; }
}
