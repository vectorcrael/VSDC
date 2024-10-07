using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCBBankImportDefaults")]
[Index("BtblCbbankImportDefaultsChecksum", Name = "idx__btblCBBankImportDefaults__btblCBBankImportDefaults_Checksum")]
[Index("BtblCbbankImportDefaultsIChangeSetId", Name = "idx__btblCBBankImportDefaults_iChangeSetID")]
[Index("BtblCbbankImportDefaultsDModifiedDate", Name = "idx_btblCBBankImportDefaults_dModifiedDate")]
[Index("BtblCbbankImportDefaultsIBranchId", Name = "idx_btblCBBankImportDefaults_iBranchID")]
public partial class BtblCbbankImportDefault
{
    [Key]
    [Column("idCBBankImportDefaults")]
    public int IdCbbankImportDefaults { get; set; }

    [Column("bFixedLength")]
    public bool BFixedLength { get; set; }

    [Column("cDelimiter")]
    [StringLength(3)]
    [Unicode(false)]
    public string? CDelimiter { get; set; }

    [Column("bImpliedDecimals")]
    public bool BImpliedDecimals { get; set; }

    [Column("iTxDateStartPos")]
    public int? ITxDateStartPos { get; set; }

    [Column("iTxDateLength")]
    public int? ITxDateLength { get; set; }

    [Column("iTxDatePosition")]
    public int? ITxDatePosition { get; set; }

    [Column("iReferenceStartPos")]
    public int? IReferenceStartPos { get; set; }

    [Column("iReferenceLength")]
    public int? IReferenceLength { get; set; }

    [Column("iReferencePosition")]
    public int? IReferencePosition { get; set; }

    [Column("iAmountStartPos")]
    public int? IAmountStartPos { get; set; }

    [Column("iAmountLength")]
    public int? IAmountLength { get; set; }

    [Column("iAmountPosition")]
    public int? IAmountPosition { get; set; }

    [Column("bWindowsDateFormat")]
    public bool BWindowsDateFormat { get; set; }

    [Column("cCustomDateFormat")]
    [StringLength(8)]
    [Unicode(false)]
    public string? CCustomDateFormat { get; set; }

    [Column("cDateSeparator")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CDateSeparator { get; set; }

    [Column("iHeaderRecords")]
    public int? IHeaderRecords { get; set; }

    [Column("_btblCBBankImportDefaults_iBranchID")]
    public int? BtblCbbankImportDefaultsIBranchId { get; set; }

    [Column("_btblCBBankImportDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCbbankImportDefaultsDCreatedDate { get; set; }

    [Column("_btblCBBankImportDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCbbankImportDefaultsDModifiedDate { get; set; }

    [Column("_btblCBBankImportDefaults_iCreatedBranchID")]
    public int? BtblCbbankImportDefaultsICreatedBranchId { get; set; }

    [Column("_btblCBBankImportDefaults_iModifiedBranchID")]
    public int? BtblCbbankImportDefaultsIModifiedBranchId { get; set; }

    [Column("_btblCBBankImportDefaults_iCreatedAgentID")]
    public int? BtblCbbankImportDefaultsICreatedAgentId { get; set; }

    [Column("_btblCBBankImportDefaults_iModifiedAgentID")]
    public int? BtblCbbankImportDefaultsIModifiedAgentId { get; set; }

    [Column("_btblCBBankImportDefaults_iChangeSetID")]
    public int? BtblCbbankImportDefaultsIChangeSetId { get; set; }

    [Column("_btblCBBankImportDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCbbankImportDefaultsChecksum { get; set; }
}
