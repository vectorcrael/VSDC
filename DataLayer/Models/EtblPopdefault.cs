using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPOPDefaults")]
[Index("EtblPopdefaultsChecksum", Name = "idx__etblPOPDefaults__etblPOPDefaults_Checksum")]
[Index("EtblPopdefaultsIChangeSetId", Name = "idx__etblPOPDefaults_iChangeSetID")]
[Index("EtblPopdefaultsDModifiedDate", Name = "idx_etblPOPDefaults_dModifiedDate")]
[Index("EtblPopdefaultsIBranchId", Name = "idx_etblPOPDefaults_iBranchID")]
public partial class EtblPopdefault
{
    [Key]
    [Column("idPOPDefaults")]
    public int IdPopdefaults { get; set; }

    [Column("bAutoRequisition")]
    public bool BAutoRequisition { get; set; }

    [Column("cRequisitionPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CRequisitionPrefix { get; set; }

    [Column("iNextRequisitionNo")]
    public int? INextRequisitionNo { get; set; }

    [Column("iPadRequisitionLength")]
    public int? IPadRequisitionLength { get; set; }

    [Column("bReqBudgetCheck")]
    public bool BReqBudgetCheck { get; set; }

    [Column("bReqBudgetAnnual")]
    public bool BReqBudgetAnnual { get; set; }

    [Column("_etblPOPDefaults_iBranchID")]
    public int? EtblPopdefaultsIBranchId { get; set; }

    [Column("_etblPOPDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPopdefaultsDCreatedDate { get; set; }

    [Column("_etblPOPDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPopdefaultsDModifiedDate { get; set; }

    [Column("_etblPOPDefaults_iCreatedBranchID")]
    public int? EtblPopdefaultsICreatedBranchId { get; set; }

    [Column("_etblPOPDefaults_iModifiedBranchID")]
    public int? EtblPopdefaultsIModifiedBranchId { get; set; }

    [Column("_etblPOPDefaults_iCreatedAgentID")]
    public int? EtblPopdefaultsICreatedAgentId { get; set; }

    [Column("_etblPOPDefaults_iModifiedAgentID")]
    public int? EtblPopdefaultsIModifiedAgentId { get; set; }

    [Column("bReqToPOIgnoreExpDate")]
    public bool BReqToPoignoreExpDate { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("_etblPOPDefaults_iChangeSetID")]
    public int? EtblPopdefaultsIChangeSetId { get; set; }

    [Column("_etblPOPDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPopdefaultsChecksum { get; set; }
}
