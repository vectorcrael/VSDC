using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFamovement
{
    [Column("idMovementTransactionNo")]
    public int IdMovementTransactionNo { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string? MovementTransaction { get; set; }

    [Column("iAssetID")]
    public int IAssetId { get; set; }

    [Column("iTransactionTypeID")]
    public int ITransactionTypeId { get; set; }

    public double TransactionUnits { get; set; }

    [Column("fAmount")]
    public double FAmount { get; set; }

    [Column("dMovementDate", TypeName = "smalldatetime")]
    public DateTime DMovementDate { get; set; }

    [Column("cReference")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iPeopleID")]
    public int? IPeopleId { get; set; }

    [Column("iAssetTypeID")]
    public int? IAssetTypeId { get; set; }

    [Column("_btblFAMovementTransaction_iBranchID")]
    public int? BtblFamovementTransactionIBranchId { get; set; }

    [Column("_btblFAMovementTransaction_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFamovementTransactionDCreatedDate { get; set; }

    [Column("_btblFAMovementTransaction_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFamovementTransactionDModifiedDate { get; set; }

    [Column("_btblFAMovementTransaction_iCreatedBranchID")]
    public int? BtblFamovementTransactionICreatedBranchId { get; set; }

    [Column("_btblFAMovementTransaction_iModifiedBranchID")]
    public int? BtblFamovementTransactionIModifiedBranchId { get; set; }

    [Column("_btblFAMovementTransaction_iCreatedAgentID")]
    public int? BtblFamovementTransactionICreatedAgentId { get; set; }

    [Column("_btblFAMovementTransaction_iModifiedAgentID")]
    public int? BtblFamovementTransactionIModifiedAgentId { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Depreciation { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AssetCode { get; set; }

    [Column("idAssetNo")]
    public int? IdAssetNo { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

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
    public string? CAssetDesc { get; set; }

    [Column("iAssetTypeNo")]
    public int? IAssetTypeNo { get; set; }

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
    public double? FNoOfUnits { get; set; }

    [Column("dPurchaseDate", TypeName = "smalldatetime")]
    public DateTime? DPurchaseDate { get; set; }

    [Column("dDepreciationStartDate", TypeName = "smalldatetime")]
    public DateTime? DDepreciationStartDate { get; set; }

    [Column("iDepreciationStartPeriodNo")]
    public int? IDepreciationStartPeriodNo { get; set; }

    [Column("dWTStartDate", TypeName = "smalldatetime")]
    public DateTime? DWtstartDate { get; set; }

    [Column("iWTStartPeriodNo")]
    public int? IWtstartPeriodNo { get; set; }

    [Column("fPurchaseValue")]
    public double? FPurchaseValue { get; set; }

    [Column("fRevalueValue")]
    public double? FRevalueValue { get; set; }

    [Column("fInsuredValue")]
    public double? FInsuredValue { get; set; }

    [Column("fResidualValue")]
    public double? FResidualValue { get; set; }

    [Column("fScrapValue")]
    public double? FScrapValue { get; set; }

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
    public DateTime? DOriginalWtstartDate { get; set; }

    [Column("dOriginalDeprStartDate", TypeName = "smalldatetime")]
    public DateTime? DOriginalDeprStartDate { get; set; }

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
    public bool? BInitialAllowancePosted { get; set; }

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

    [StringLength(30)]
    [Unicode(false)]
    public string? TxAssetTypeCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? TxAssetTypeDesc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TxLocationCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? TxLocationDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TxCostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? TxCostName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FromAssetTypeCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? FromAssetTypeDesc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FromLocationCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? FromLocationDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FromCostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? FromCostName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ToAssetTypeCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? ToAssetTypeDesc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ToLocationCode { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? ToLocationDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ToCostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ToCostName { get; set; }

    [Column("idPeople")]
    public int? IdPeople { get; set; }

    [Column("cFirstName")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CFirstName { get; set; }

    [Column("cInitials")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CInitials { get; set; }

    [Column("cLastName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CLastName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [Column("cTitle")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTitle { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cTelWork")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelWork { get; set; }

    [Column("cTelFax")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelFax { get; set; }

    [Column("cTelMobile")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelMobile { get; set; }

    [Column("cTelHome")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelHome { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [Column("cComments")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CComments { get; set; }

    [Column("cAddress")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CAddress { get; set; }

    [Column("cPostalAddress")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CPostalAddress { get; set; }

    [Column("iBusDeptID")]
    public int? IBusDeptId { get; set; }

    [Column("iBusDesigID")]
    public int? IBusDesigId { get; set; }

    [Column("dBirthDate", TypeName = "smalldatetime")]
    public DateTime? DBirthDate { get; set; }

    [Column("dPeopleTimeStamp", TypeName = "datetime")]
    public DateTime? DPeopleTimeStamp { get; set; }

    [Column("_rtblPeople_iBranchID")]
    public int? RtblPeopleIBranchId { get; set; }

    [Column("_rtblPeople_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblPeopleDCreatedDate { get; set; }

    [Column("_rtblPeople_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblPeopleDModifiedDate { get; set; }

    [Column("_rtblPeople_iCreatedBranchID")]
    public int? RtblPeopleICreatedBranchId { get; set; }

    [Column("_rtblPeople_iModifiedBranchID")]
    public int? RtblPeopleIModifiedBranchId { get; set; }

    [Column("_rtblPeople_iCreatedAgentID")]
    public int? RtblPeopleICreatedAgentId { get; set; }

    [Column("_rtblPeople_iModifiedAgentID")]
    public int? RtblPeopleIModifiedAgentId { get; set; }

    [Column("_rtblPeople_iChangeSetID")]
    public int? RtblPeopleIChangeSetId { get; set; }

    [Column("_rtblPeople_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblPeopleChecksum { get; set; }
}
