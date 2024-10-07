using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARStatementRun")]
[Index("EtblArstatementRunChecksum", Name = "idx__etblARStatementRun__etblARStatementRun_Checksum")]
[Index("EtblArstatementRunDModifiedDate", Name = "idx__etblARStatementRun__etblARStatementRun_dModifiedDate")]
[Index("EtblArstatementRunIBranchId", Name = "idx__etblARStatementRun__etblARStatementRun_iBranchID")]
[Index("EtblArstatementRunIChangeSetId", Name = "idx__etblARStatementRun__etblARStatementRun_iChangeSetID")]
public partial class EtblArstatementRun
{
    [Key]
    [Column("idStatementRun")]
    public int IdStatementRun { get; set; }

    [Column("cReference")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("dRunGenerated", TypeName = "datetime")]
    public DateTime DRunGenerated { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("_etblARStatementRun_iBranchID")]
    public int? EtblArstatementRunIBranchId { get; set; }

    [Column("_etblARStatementRun_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArstatementRunDCreatedDate { get; set; }

    [Column("_etblARStatementRun_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArstatementRunDModifiedDate { get; set; }

    [Column("_etblARStatementRun_iCreatedBranchID")]
    public int? EtblArstatementRunICreatedBranchId { get; set; }

    [Column("_etblARStatementRun_iModifiedBranchID")]
    public int? EtblArstatementRunIModifiedBranchId { get; set; }

    [Column("_etblARStatementRun_iCreatedAgentID")]
    public int? EtblArstatementRunICreatedAgentId { get; set; }

    [Column("_etblARStatementRun_iModifiedAgentID")]
    public int? EtblArstatementRunIModifiedAgentId { get; set; }

    [Column("_etblARStatementRun_iChangeSetID")]
    public int? EtblArstatementRunIChangeSetId { get; set; }

    [Column("_etblARStatementRun_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArstatementRunChecksum { get; set; }
}
