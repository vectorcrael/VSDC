using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEUNoTC")]
[Index("EtblEunoTcChecksum", Name = "idx__etblEUNoTC__etblEUNoTC_Checksum")]
[Index("EtblEunoTcIChangeSetId", Name = "idx__etblEUNoTC_iChangeSetID")]
[Index("EtblEunoTcDModifiedDate", Name = "idx_etblEUNoTC_dModifiedDate")]
[Index("EtblEunoTcIBranchId", Name = "idx_etblEUNoTC_iBranchID")]
public partial class EtblEunoTc
{
    [Key]
    [Column("IDEUNoTC")]
    public int IdeunoTc { get; set; }

    [Column("cEUNoTCCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CEunoTccode { get; set; }

    [Column("cEUNoTCDescription")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CEunoTcdescription { get; set; }

    [Column("_etblEUNoTC_iBranchID")]
    public int? EtblEunoTcIBranchId { get; set; }

    [Column("_etblEUNoTC_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEunoTcDCreatedDate { get; set; }

    [Column("_etblEUNoTC_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEunoTcDModifiedDate { get; set; }

    [Column("_etblEUNoTC_iCreatedBranchID")]
    public int? EtblEunoTcICreatedBranchId { get; set; }

    [Column("_etblEUNoTC_iModifiedBranchID")]
    public int? EtblEunoTcIModifiedBranchId { get; set; }

    [Column("_etblEUNoTC_iCreatedAgentID")]
    public int? EtblEunoTcICreatedAgentId { get; set; }

    [Column("_etblEUNoTC_iModifiedAgentID")]
    public int? EtblEunoTcIModifiedAgentId { get; set; }

    [Column("_etblEUNoTC_iChangeSetID")]
    public int? EtblEunoTcIChangeSetId { get; set; }

    [Column("_etblEUNoTC_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEunoTcChecksum { get; set; }
}
