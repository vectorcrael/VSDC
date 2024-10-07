using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWhDefaults")]
[Index("EtblWhDefaultsChecksum", Name = "idx__etblWhDefaults__etblWhDefaults_Checksum")]
[Index("EtblWhDefaultsIChangeSetId", Name = "idx__etblWhDefaults_iChangeSetID")]
[Index("EtblWhDefaultsDModifiedDate", Name = "idx_etblWhDefaults_dModifiedDate")]
[Index("EtblWhDefaultsIBranchId", Name = "idx_etblWhDefaults_iBranchID")]
public partial class EtblWhDefault
{
    [Key]
    [Column("IDWhDefaults")]
    public int IdwhDefaults { get; set; }

    [Column("bWhTfBatchAutoNum")]
    public bool BWhTfBatchAutoNum { get; set; }

    [Column("cWhTfBatchPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CWhTfBatchPrefix { get; set; }

    [Column("iWhTfBatchPadLength")]
    public int? IWhTfBatchPadLength { get; set; }

    [Column("iWhTfTrCodeID")]
    public int? IWhTfTrCodeId { get; set; }

    [Column("bWhTfRefAutoNum")]
    public bool BWhTfRefAutoNum { get; set; }

    [Column("cWhTfRefPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CWhTfRefPrefix { get; set; }

    [Column("iWhTfRefPadLength")]
    public int? IWhTfRefPadLength { get; set; }

    [Column("bIBTNumAutoNum")]
    public bool BIbtnumAutoNum { get; set; }

    [Column("cIBTNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIbtnumPrefix { get; set; }

    [Column("iIBTNumPadLength")]
    public int? IIbtnumPadLength { get; set; }

    [Column("iIBTTrCodeID")]
    public int? IIbttrCodeId { get; set; }

    [Column("iIBTAddCostTrCodeID")]
    public int? IIbtaddCostTrCodeId { get; set; }

    [Column("bIBTDelNoteAutoNum")]
    public bool BIbtdelNoteAutoNum { get; set; }

    [Column("cIBTDelNotePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIbtdelNotePrefix { get; set; }

    [Column("iIBTDelNotePadLength")]
    public int IIbtdelNotePadLength { get; set; }

    [Column("iDefInTransitWHID")]
    public int? IDefInTransitWhid { get; set; }

    [Column("iDefVarianceWHID")]
    public int? IDefVarianceWhid { get; set; }

    [Column("iDefDamagedWHID")]
    public int? IDefDamagedWhid { get; set; }

    [Column("bWhseIBTActivated")]
    public bool BWhseIbtactivated { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("iBranchLoanAccountID")]
    public int? IBranchLoanAccountId { get; set; }

    [Column("bIBTDefaultCostToIssue")]
    public bool BIbtdefaultCostToIssue { get; set; }

    [Column("_etblWhDefaults_iBranchID")]
    public int? EtblWhDefaultsIBranchId { get; set; }

    [Column("_etblWhDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhDefaultsDCreatedDate { get; set; }

    [Column("_etblWhDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhDefaultsDModifiedDate { get; set; }

    [Column("_etblWhDefaults_iCreatedBranchID")]
    public int? EtblWhDefaultsICreatedBranchId { get; set; }

    [Column("_etblWhDefaults_iModifiedBranchID")]
    public int? EtblWhDefaultsIModifiedBranchId { get; set; }

    [Column("_etblWhDefaults_iCreatedAgentID")]
    public int? EtblWhDefaultsICreatedAgentId { get; set; }

    [Column("_etblWhDefaults_iModifiedAgentID")]
    public int? EtblWhDefaultsIModifiedAgentId { get; set; }

    [Column("_etblWhDefaults_iChangeSetID")]
    public int? EtblWhDefaultsIChangeSetId { get; set; }

    [Column("bIBTAllowOverDelivery")]
    public bool BIbtallowOverDelivery { get; set; }

    [Column("bIBTRequestNumAutoNum")]
    public bool BIbtrequestNumAutoNum { get; set; }

    [Column("cIBTRequestNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CIbtrequestNumPrefix { get; set; }

    [Column("iIBTRequestNumPadLength")]
    public int? IIbtrequestNumPadLength { get; set; }

    [Column("_etblWhDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhDefaultsChecksum { get; set; }
}
