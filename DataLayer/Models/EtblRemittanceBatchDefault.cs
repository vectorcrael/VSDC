using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblRemittanceBatchDefaults")]
[Index("EtblRemittanceBatchDefaultsChecksum", Name = "idx__etblRemittanceBatchDefaults__etblRemittanceBatchDefaults_Checksum")]
[Index("EtblRemittanceBatchDefaultsDModifiedDate", Name = "idx__etblRemittanceBatchDefaults__etblRemittanceBatchDefaults_dModifiedDate")]
[Index("EtblRemittanceBatchDefaultsIBranchId", Name = "idx__etblRemittanceBatchDefaults__etblRemittanceBatchDefaults_iBranchID")]
[Index("EtblRemittanceBatchDefaultsIChangeSetId", Name = "idx__etblRemittanceBatchDefaults__etblRemittanceBatchDefaults_iChangeSetID")]
public partial class EtblRemittanceBatchDefault
{
    [Key]
    [Column("idRemittanceBatchDefaults")]
    public int IdRemittanceBatchDefaults { get; set; }

    [Column("bAutoNumbers")]
    public bool? BAutoNumbers { get; set; }

    [Column("iAutoNumPadLength")]
    public int? IAutoNumPadLength { get; set; }

    [Column("cAutoNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumPrefix { get; set; }

    [Column("bAutoRefNumbers")]
    public bool? BAutoRefNumbers { get; set; }

    [Column("iAutoRefNumPadLength")]
    public int? IAutoRefNumPadLength { get; set; }

    [Column("cAutoRefNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoRefNumPrefix { get; set; }

    [Column("_etblRemittanceBatchDefaults_iBranchID")]
    public int? EtblRemittanceBatchDefaultsIBranchId { get; set; }

    [Column("_etblRemittanceBatchDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceBatchDefaultsDCreatedDate { get; set; }

    [Column("_etblRemittanceBatchDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblRemittanceBatchDefaultsDModifiedDate { get; set; }

    [Column("_etblRemittanceBatchDefaults_iCreatedBranchID")]
    public int? EtblRemittanceBatchDefaultsICreatedBranchId { get; set; }

    [Column("_etblRemittanceBatchDefaults_iModifiedBranchID")]
    public int? EtblRemittanceBatchDefaultsIModifiedBranchId { get; set; }

    [Column("_etblRemittanceBatchDefaults_iCreatedAgentID")]
    public int? EtblRemittanceBatchDefaultsICreatedAgentId { get; set; }

    [Column("_etblRemittanceBatchDefaults_iModifiedAgentID")]
    public int? EtblRemittanceBatchDefaultsIModifiedAgentId { get; set; }

    [Column("_etblRemittanceBatchDefaults_iChangeSetID")]
    public int? EtblRemittanceBatchDefaultsIChangeSetId { get; set; }

    [Column("_etblRemittanceBatchDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblRemittanceBatchDefaultsChecksum { get; set; }
}
