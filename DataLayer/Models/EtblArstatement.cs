using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARStatements")]
[Index("EtblArstatementsChecksum", Name = "idx__etblARStatements__etblARStatements_Checksum")]
[Index("EtblArstatementsDModifiedDate", Name = "idx__etblARStatements__etblARStatements_dModifiedDate")]
[Index("EtblArstatementsIBranchId", Name = "idx__etblARStatements__etblARStatements_iBranchID")]
[Index("EtblArstatementsIChangeSetId", Name = "idx__etblARStatements__etblARStatements_iChangeSetID")]
public partial class EtblArstatement
{
    [Key]
    [Column("idStatements")]
    public int IdStatements { get; set; }

    [Column("iStatementRunID")]
    public int IStatementRunId { get; set; }

    [Column("iClientID")]
    public int IClientId { get; set; }

    [Column("nPDFDocument", TypeName = "image")]
    public byte[]? NPdfdocument { get; set; }

    [Column("_etblARStatements_iBranchID")]
    public int? EtblArstatementsIBranchId { get; set; }

    [Column("_etblARStatements_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArstatementsDCreatedDate { get; set; }

    [Column("_etblARStatements_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArstatementsDModifiedDate { get; set; }

    [Column("_etblARStatements_iCreatedBranchID")]
    public int? EtblArstatementsICreatedBranchId { get; set; }

    [Column("_etblARStatements_iModifiedBranchID")]
    public int? EtblArstatementsIModifiedBranchId { get; set; }

    [Column("_etblARStatements_iCreatedAgentID")]
    public int? EtblArstatementsICreatedAgentId { get; set; }

    [Column("_etblARStatements_iModifiedAgentID")]
    public int? EtblArstatementsIModifiedAgentId { get; set; }

    [Column("_etblARStatements_iChangeSetID")]
    public int? EtblArstatementsIChangeSetId { get; set; }

    [Column("_etblARStatements_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArstatementsChecksum { get; set; }
}
