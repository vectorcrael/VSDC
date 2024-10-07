using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("StDfTbl")]
[Index("StDfTblDModifiedDate", Name = "idxStDfTbl_dModifiedDate")]
[Index("StDfTblIBranchId", Name = "idxStDfTbl_iBranchID")]
[Index("StDfTblChecksum", Name = "idx_StDfTbl_StDfTbl_Checksum")]
[Index("StDfTblIChangeSetId", Name = "idx_StDfTbl_iChangeSetID")]
public partial class StDfTbl
{
    [Key]
    [Column("idStDfTbl")]
    public int IdStDfTbl { get; set; }

    public bool? AutoInvNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InvPref { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InvNum { get; set; }

    [Column("InvTrCodeID")]
    public int? InvTrCodeId { get; set; }

    public bool? AutoRtsNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RtsPref { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RtsNum { get; set; }

    [Column("RtsTrCodeID")]
    public int? RtsTrCodeId { get; set; }

    public bool? AutoCrnNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CrnPref { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CrnNum { get; set; }

    [Column("CrnTrCodeID")]
    public int? CrnTrCodeId { get; set; }

    public bool? AutoGrvNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GrvPref { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? GrvNum { get; set; }

    [Column("bInvGrvSplit")]
    public bool? BInvGrvSplit { get; set; }

    [Column("SInvTrCodeID")]
    public int? SinvTrCodeId { get; set; }

    [Column("GrvTrCodeID")]
    public int? GrvTrCodeId { get; set; }

    [Column("SInvGLVarAccID")]
    public int? SinvGlvarAccId { get; set; }

    [Column("AdjTrCodeID")]
    public int? AdjTrCodeId { get; set; }

    [Column("Neg_Qty")]
    [StringLength(1)]
    [Unicode(false)]
    public string? NegQty { get; set; }

    public short? Decimals { get; set; }

    public short? QuantDec { get; set; }

    [Column("GRVNumOpt")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GrvnumOpt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ShowInactive { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? InvAutoDisc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CrnAutoDisc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GrvAutoDisc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RtsAutoDisc { get; set; }

    public short? SerialPerLine { get; set; }

    [Column("GrvSplitTaxTypeID")]
    public int? GrvSplitTaxTypeId { get; set; }

    [Column("RTSNumOpt")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RtsnumOpt { get; set; }

    public bool AutoCode { get; set; }

    public int? AutoCodeLength { get; set; }

    public int? AutoCodeAlphaLength { get; set; }

    public int? FilterStartLength { get; set; }

    public bool? DefaultAdjDesc { get; set; }

    public bool? InvCountAuto { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InvCountPrefix { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InvCountNum { get; set; }

    public int? InvPad { get; set; }

    [Column("RTSPad")]
    public int? Rtspad { get; set; }

    [Column("CRNPad")]
    public int? Crnpad { get; set; }

    [Column("GRVPad")]
    public int? Grvpad { get; set; }

    public int? AutoCodeNum { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AutoCodePref { get; set; }

    public int? InvCountPad { get; set; }

    public bool? AutoQuoteNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? QuotePref { get; set; }

    public int? QuoteNum { get; set; }

    public int? QuotePad { get; set; }

    public bool? AutoTemplateNum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TemplatePref { get; set; }

    public int? TemplateNum { get; set; }

    public int? TemplatePad { get; set; }

    [Column("iINVTaxTypeID")]
    public int? IInvtaxTypeId { get; set; }

    [Column("iCRNTaxTypeID")]
    public int? ICrntaxTypeId { get; set; }

    [Column("iGRVTaxTypeID")]
    public int? IGrvtaxTypeId { get; set; }

    [Column("iRTSTaxTypeID")]
    public int IRtstaxTypeId { get; set; }

    [Column("iPaymentTrCodesID")]
    public int? IPaymentTrCodesId { get; set; }

    [Column("iSerialFilterStLength")]
    public int? ISerialFilterStLength { get; set; }

    [Column("bSerialFilterStart")]
    public bool? BSerialFilterStart { get; set; }

    [Column("bSerialFilterProcessing")]
    public bool? BSerialFilterProcessing { get; set; }

    [Column("bGrvSplitUseExemptTax")]
    public bool BGrvSplitUseExemptTax { get; set; }

    [Column("iInvSeg1TypeID")]
    public int? IInvSeg1TypeId { get; set; }

    [Column("iInvSeg2TypeID")]
    public int? IInvSeg2TypeId { get; set; }

    [Column("iInvSeg3TypeID")]
    public int? IInvSeg3TypeId { get; set; }

    [Column("iInvSeg4TypeID")]
    public int? IInvSeg4TypeId { get; set; }

    [Column("iInvSeg5TypeID")]
    public int? IInvSeg5TypeId { get; set; }

    [Column("iInvSeg6TypeID")]
    public int? IInvSeg6TypeId { get; set; }

    [Column("iInvSeg7TypeID")]
    public int? IInvSeg7TypeId { get; set; }

    [Column("bUseInvSeg")]
    public bool BUseInvSeg { get; set; }

    [Column("bPostRepPerLine")]
    public bool BPostRepPerLine { get; set; }

    [Column("iCostDecimals")]
    public short? ICostDecimals { get; set; }

    [Column("bPostProjectPerLine")]
    public bool BPostProjectPerLine { get; set; }

    [Column("iDefaultLotStatus")]
    public int? IDefaultLotStatus { get; set; }

    [Column("bUseUpperItemCode")]
    public bool BUseUpperItemCode { get; set; }

    [Column("iPriceListNameID1")]
    public int? IPriceListNameId1 { get; set; }

    [Column("iPriceListNameID2")]
    public int? IPriceListNameId2 { get; set; }

    [Column("iPriceListNameID3")]
    public int? IPriceListNameId3 { get; set; }

    [Column("bNegQtyWarn")]
    public bool BNegQtyWarn { get; set; }

    [Column("bIsPerpetual")]
    public bool BIsPerpetual { get; set; }

    [Column("bIsInclusive")]
    public bool BIsInclusive { get; set; }

    [Column("iCostingMethod")]
    public int ICostingMethod { get; set; }

    [Column("iDefStockCostVarianceAccID")]
    public int IDefStockCostVarianceAccId { get; set; }

    [Column("bCostPerWarehouse")]
    public bool BCostPerWarehouse { get; set; }

    [Column("bInvJrBatchAutoNum")]
    public bool BInvJrBatchAutoNum { get; set; }

    [Column("cInvJrBatchPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CInvJrBatchPrefix { get; set; }

    [Column("iInvJrBatchPadLength")]
    public int? IInvJrBatchPadLength { get; set; }

    [Column("bInvJrRefAutoNum")]
    public bool BInvJrRefAutoNum { get; set; }

    [Column("cInvJrRefPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CInvJrRefPrefix { get; set; }

    [Column("iInvJrRefPadLength")]
    public int? IInvJrRefPadLength { get; set; }

    [Column("iInvJrTrCodeID")]
    public int? IInvJrTrCodeId { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("bForceRep")]
    public bool BForceRep { get; set; }

    [Column("bArchiveQuotes")]
    public bool BArchiveQuotes { get; set; }

    [Column("bSerialProcessActLookup")]
    public bool BSerialProcessActLookup { get; set; }

    [Column("bInvLinePostDocDesc")]
    public bool BInvLinePostDocDesc { get; set; }

    [Column("bFinLinePostDocDesc")]
    public bool BFinLinePostDocDesc { get; set; }

    [Column("bForceExtOrderNum")]
    public bool BForceExtOrderNum { get; set; }

    [Column("bForceSupplierInvNumber")]
    public bool BForceSupplierInvNumber { get; set; }

    [Column("bUniqueInvNum")]
    public bool? BUniqueInvNum { get; set; }

    [Column("bUniqueRtsNum")]
    public bool? BUniqueRtsNum { get; set; }

    [Column("bUniqueCrnNum")]
    public bool? BUniqueCrnNum { get; set; }

    [Column("bUniqueGrvNum")]
    public bool? BUniqueGrvNum { get; set; }

    [Column("bUniqueQuoteNum")]
    public bool? BUniqueQuoteNum { get; set; }

    [Column("bUniqueTemplateNum")]
    public bool? BUniqueTemplateNum { get; set; }

    [Column("bUniqueInvCountNum")]
    public bool? BUniqueInvCountNum { get; set; }

    [Column("bUniqueExtOrderNum")]
    public bool? BUniqueExtOrderNum { get; set; }

    [Column("bUniqueSupplierInvNum")]
    public bool? BUniqueSupplierInvNum { get; set; }

    [Column("cCostPriceEncodingKey")]
    [StringLength(11)]
    [Unicode(false)]
    public string CCostPriceEncodingKey { get; set; } = null!;

    [Column("StDfTbl_iBranchID")]
    public int? StDfTblIBranchId { get; set; }

    [Column("StDfTbl_dCreatedDate", TypeName = "datetime")]
    public DateTime? StDfTblDCreatedDate { get; set; }

    [Column("StDfTbl_dModifiedDate", TypeName = "datetime")]
    public DateTime? StDfTblDModifiedDate { get; set; }

    [Column("StDfTbl_iCreatedBranchID")]
    public int? StDfTblICreatedBranchId { get; set; }

    [Column("StDfTbl_iModifiedBranchID")]
    public int? StDfTblIModifiedBranchId { get; set; }

    [Column("StDfTbl_iCreatedAgentID")]
    public int? StDfTblICreatedAgentId { get; set; }

    [Column("StDfTbl_iModifiedAgentID")]
    public int? StDfTblIModifiedAgentId { get; set; }

    [Column("fDefaultGPPercent")]
    public float? FDefaultGppercent { get; set; }

    [Column("StDfTbl_iChangeSetID")]
    public int? StDfTblIChangeSetId { get; set; }

    [Column("bAllowPOSTender")]
    public bool BAllowPostender { get; set; }

    [Column("bAllowNegStockDef")]
    public bool BAllowNegStockDef { get; set; }

    [Column("bCalculateTaxPerLine")]
    public bool BCalculateTaxPerLine { get; set; }

    [Column("iInvCountAgentID")]
    public int? IInvCountAgentId { get; set; }

    [Column("iInvCountPromptOpt")]
    public int? IInvCountPromptOpt { get; set; }

    [Column("dInvCountLastPrompt", TypeName = "datetime")]
    public DateTime? DInvCountLastPrompt { get; set; }

    [Column("bInvPrcUpdBatchAutoNum")]
    public bool BInvPrcUpdBatchAutoNum { get; set; }

    [Column("cInvPrcUpdBatchPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CInvPrcUpdBatchPrefix { get; set; }

    [Column("iInvPrcUpdBatchPadLength")]
    public int? IInvPrcUpdBatchPadLength { get; set; }

    [Column("bAutoLotAlloc")]
    public bool BAutoLotAlloc { get; set; }

    [Column("iAutoLotAllocType")]
    public int? IAutoLotAllocType { get; set; }

    [Column("bInvPrcUpdRefAutoNum")]
    public bool BInvPrcUpdRefAutoNum { get; set; }

    [Column("cInvPrcUpdRefPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CInvPrcUpdRefPrefix { get; set; }

    [Column("iInvPrcUpdRefPadLength")]
    public int? IInvPrcUpdRefPadLength { get; set; }

    [Column("bPostDeliveryPerLine")]
    public bool BPostDeliveryPerLine { get; set; }

    [Column("bAddToDeliveryDate")]
    public bool BAddToDeliveryDate { get; set; }

    [Column("iAddToDeliveryType")]
    public int? IAddToDeliveryType { get; set; }

    [Column("iAddDeliveryDays")]
    public int? IAddDeliveryDays { get; set; }

    [Column("bForceDeliveryINV")]
    public bool BForceDeliveryInv { get; set; }

    [Column("bForceDeliveryCRN")]
    public bool BForceDeliveryCrn { get; set; }

    [Column("bForceDeliveryGRV")]
    public bool BForceDeliveryGrv { get; set; }

    [Column("bForceDeliveryRTS")]
    public bool BForceDeliveryRts { get; set; }

    [Column("bPostCostVarianceGLLine")]
    public bool BPostCostVarianceGlline { get; set; }

    [Column("bUseDimensions")]
    public bool? BUseDimensions { get; set; }

    [Column("bSellUsingDimensions")]
    public bool? BSellUsingDimensions { get; set; }

    [Column("bBuyUsingDimensions")]
    public bool? BBuyUsingDimensions { get; set; }

    [Column("cDefMeasurement")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CDefMeasurement { get; set; }

    [Column("cMeasurementRounding")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CMeasurementRounding { get; set; }

    [Column("cRoundingOption")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CRoundingOption { get; set; }

    [Column("bUseSalesOrders")]
    public bool BUseSalesOrders { get; set; }

    [Column("bUseUOM")]
    public bool BUseUom { get; set; }

    [Column("bInvIssueSplit")]
    public bool BInvIssueSplit { get; set; }

    [Column("iInvIssueSplitAccrualAccID")]
    public int? IInvIssueSplitAccrualAccId { get; set; }

    [Column("bAutoGIVNumber")]
    public bool BAutoGivnumber { get; set; }

    [Column("bUniqueGIVNum")]
    public bool BUniqueGivnum { get; set; }

    [Column("cGIVPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CGivprefix { get; set; }

    [Column("cGIVNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CGivnumber { get; set; }

    [Column("iGIVPad")]
    public int? IGivpad { get; set; }

    [Column("bAutoCGRNumber")]
    public bool BAutoCgrnumber { get; set; }

    [Column("bUniqueCGRNum")]
    public bool BUniqueCgrnum { get; set; }

    [Column("cCGRPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CCgrprefix { get; set; }

    [Column("cCGRNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CCgrnumber { get; set; }

    [Column("iCGRPad")]
    public int? ICgrpad { get; set; }

    [Column("bRTSAverageCostVariance")]
    public bool BRtsaverageCostVariance { get; set; }

    [Column("StDfTbl_Checksum")]
    [MaxLength(20)]
    public byte[]? StDfTblChecksum { get; set; }

    [Column("bAutoSBSINumber")]
    public bool BAutoSbsinumber { get; set; }

    [Column("bUniqueSBSINumber")]
    public bool BUniqueSbsinumber { get; set; }

    [Column("cSBSIPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSbsiprefix { get; set; }

    [Column("cSBSINumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CSbsinumber { get; set; }

    [Column("iSBSIPad")]
    public int? ISbsipad { get; set; }
}
