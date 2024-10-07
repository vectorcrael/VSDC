﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvArapbatch
{
    [Column("idARAPBatches")]
    public int IdArapbatches { get; set; }

    [Column("iDCModule")]
    public int IDcmodule { get; set; }

    [Column("cBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchNo { get; set; }

    [Column("cBatchDesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string CBatchDesc { get; set; } = null!;

    [Column("cBatchRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchRef { get; set; }

    [Column("bClearAfterPost")]
    public bool BClearAfterPost { get; set; }

    [Column("bAllowDupRef")]
    public bool BAllowDupRef { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("bCurrencySingle")]
    public bool BCurrencySingle { get; set; }

    [Column("iNewLineDateOpt")]
    public int? INewLineDateOpt { get; set; }

    [Column("dNewLineDateDef", TypeName = "datetime")]
    public DateTime? DNewLineDateDef { get; set; }

    [Column("iNewLineRefOpt")]
    public int? INewLineRefOpt { get; set; }

    [Column("cNewLineRefDef")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CNewLineRefDef { get; set; }

    [Column("bNewLineRefInc")]
    public bool BNewLineRefInc { get; set; }

    [Column("iNewLineDescOpt")]
    public int? INewLineDescOpt { get; set; }

    [Column("cNewLineDescDef")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CNewLineDescDef { get; set; }

    [Column("bNewLineDescInc")]
    public bool BNewLineDescInc { get; set; }

    [Column("iNewLineTrCodeOpt")]
    public int? INewLineTrCodeOpt { get; set; }

    [Column("iNewLineTrCodeDefID")]
    public int? INewLineTrCodeDefId { get; set; }

    [Column("bNewLineTrCodeForce")]
    public bool BNewLineTrCodeForce { get; set; }

    [Column("cOriginalBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COriginalBatchNo { get; set; }

    [Column("cOriginalbatchDesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COriginalbatchDesc { get; set; }

    [Column("iAgentCreatorID")]
    public int? IAgentCreatorId { get; set; }

    [Column("fValidateDebits")]
    public double? FValidateDebits { get; set; }

    [Column("fValidateCredits")]
    public double? FValidateCredits { get; set; }

    [Column("bShowGLContra")]
    public bool BShowGlcontra { get; set; }

    [Column("bEditGLContra")]
    public bool BEditGlcontra { get; set; }

    [Column("bAllowGLContraSplit")]
    public bool BAllowGlcontraSplit { get; set; }

    [Column("bEnterTaxOnGlContraSplit")]
    public bool BEnterTaxOnGlContraSplit { get; set; }

    [Column("_etblARAPBatches_iBranchID")]
    public int? EtblArapbatchesIBranchId { get; set; }

    [Column("_etblARAPBatches_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchesDCreatedDate { get; set; }

    [Column("_etblARAPBatches_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchesDModifiedDate { get; set; }

    [Column("_etblARAPBatches_iCreatedBranchID")]
    public int? EtblArapbatchesICreatedBranchId { get; set; }

    [Column("_etblARAPBatches_iModifiedBranchID")]
    public int? EtblArapbatchesIModifiedBranchId { get; set; }

    [Column("_etblARAPBatches_iCreatedAgentID")]
    public int? EtblArapbatchesICreatedAgentId { get; set; }

    [Column("_etblARAPBatches_iModifiedAgentID")]
    public int? EtblArapbatchesIModifiedAgentId { get; set; }

    [Column("_etblARAPBatches_iChangeSetID")]
    public int? EtblArapbatchesIChangeSetId { get; set; }

    [Column("bIncludeLinkedAccounts")]
    public bool BIncludeLinkedAccounts { get; set; }

    [Column("bEnterExclOnGlContraSplit")]
    public bool BEnterExclOnGlContraSplit { get; set; }

    [Column("bValidateOverTerms")]
    public bool BValidateOverTerms { get; set; }

    [Column("bValidateOverLimit")]
    public bool BValidateOverLimit { get; set; }

    [Column("bInterBranchBatch")]
    public bool BInterBranchBatch { get; set; }

    [Column("iBranchLoanAccountID")]
    public int? IBranchLoanAccountId { get; set; }

    [Column("bModuleAR")]
    public bool BModuleAr { get; set; }

    [Column("bModuleAP")]
    public bool BModuleAp { get; set; }

    [Column("bModuleGL")]
    public bool BModuleGl { get; set; }

    [Column("iInputTaxID")]
    public int? IInputTaxId { get; set; }

    [Column("iInputTaxAccID")]
    public int? IInputTaxAccId { get; set; }

    [Column("iOutputTaxID")]
    public int? IOutputTaxId { get; set; }

    [Column("iOutputTaxAccID")]
    public int? IOutputTaxAccId { get; set; }

    [Column("bCalcTax")]
    public bool BCalcTax { get; set; }

    [Column("iDefaultModule")]
    public int? IDefaultModule { get; set; }

    [Column("_etblARAPBatches_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchesChecksum { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    public int? CurrencyLink { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("cCurrencySymbol")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CCurrencySymbol { get; set; }

    [Column("iOptions")]
    public int? IOptions { get; set; }

    [Column("iPromptAgentID")]
    public int? IPromptAgentId { get; set; }

    [Column("Currency_iBranchID")]
    public int? CurrencyIBranchId { get; set; }

    [Column("Currency_dCreatedDate", TypeName = "datetime")]
    public DateTime? CurrencyDCreatedDate { get; set; }

    [Column("Currency_dModifiedDate", TypeName = "datetime")]
    public DateTime? CurrencyDModifiedDate { get; set; }

    [Column("Currency_iCreatedBranchID")]
    public int? CurrencyICreatedBranchId { get; set; }

    [Column("Currency_iModifiedBranchID")]
    public int? CurrencyIModifiedBranchId { get; set; }

    [Column("Currency_iCreatedAgentID")]
    public int? CurrencyICreatedAgentId { get; set; }

    [Column("Currency_iModifiedAgentID")]
    public int? CurrencyIModifiedAgentId { get; set; }

    [Column("Currency_iChangeSetID")]
    public int? CurrencyIChangeSetId { get; set; }

    [Column("Currency_Checksum")]
    [MaxLength(20)]
    public byte[]? CurrencyChecksum { get; set; }
}
