using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchDefaults")]
[Index("EtblArapbatchDefaultsChecksum", Name = "idx__etblARAPBatchDefaults__etblARAPBatchDefaults_Checksum")]
[Index("EtblArapbatchDefaultsIChangeSetId", Name = "idx__etblARAPBatchDefaults_iChangeSetID")]
[Index("EtblArapbatchDefaultsDModifiedDate", Name = "idx_etblARAPBatchDefaults_dModifiedDate")]
[Index("EtblArapbatchDefaultsIBranchId", Name = "idx_etblARAPBatchDefaults_iBranchID")]
public partial class EtblArapbatchDefault
{
    [Key]
    [Column("idARAPBatchDefaults")]
    public int IdArapbatchDefaults { get; set; }

    [Column("iDCModule")]
    public int IDcmodule { get; set; }

    [Column("bAutoNumbers")]
    public bool BAutoNumbers { get; set; }

    [Column("iAutoNumPadLength")]
    public int? IAutoNumPadLength { get; set; }

    [Column("cAutoNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoNumPrefix { get; set; }

    [Column("bAutoRefNumbers")]
    public bool BAutoRefNumbers { get; set; }

    [Column("iAutoRefNumPadLength")]
    public int? IAutoRefNumPadLength { get; set; }

    [Column("cAutoRefNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CAutoRefNumPrefix { get; set; }

    [Column("_etblARAPBatchDefaults_iBranchID")]
    public int? EtblArapbatchDefaultsIBranchId { get; set; }

    [Column("_etblARAPBatchDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchDefaultsDCreatedDate { get; set; }

    [Column("_etblARAPBatchDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchDefaultsDModifiedDate { get; set; }

    [Column("_etblARAPBatchDefaults_iCreatedBranchID")]
    public int? EtblArapbatchDefaultsICreatedBranchId { get; set; }

    [Column("_etblARAPBatchDefaults_iModifiedBranchID")]
    public int? EtblArapbatchDefaultsIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchDefaults_iCreatedAgentID")]
    public int? EtblArapbatchDefaultsICreatedAgentId { get; set; }

    [Column("_etblARAPBatchDefaults_iModifiedAgentID")]
    public int? EtblArapbatchDefaultsIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchDefaults_iChangeSetID")]
    public int? EtblArapbatchDefaultsIChangeSetId { get; set; }

    [Column("_etblARAPBatchDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchDefaultsChecksum { get; set; }
}
