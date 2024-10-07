using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IAgentId", "CPassword")]
[Table("_etblAgentPwdHistory")]
[Index("EtblAgentPwdHistoryChecksum", Name = "idx__etblAgentPwdHistory__etblAgentPwdHistory_Checksum")]
[Index("EtblAgentPwdHistoryIChangeSetId", Name = "idx__etblAgentPwdHistory_iChangeSetID")]
[Index("EtblAgentPwdHistoryDModifiedDate", Name = "idx_etblAgentPwdHistory_dModifiedDate")]
[Index("EtblAgentPwdHistoryIBranchId", Name = "idx_etblAgentPwdHistory_iBranchID")]
public partial class EtblAgentPwdHistory
{
    [Key]
    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Key]
    [Column("cPassword")]
    [StringLength(24)]
    [Unicode(false)]
    public string CPassword { get; set; } = null!;

    [Column("dPwdLastUsed", TypeName = "smalldatetime")]
    public DateTime? DPwdLastUsed { get; set; }

    [Column("_etblAgentPwdHistory_iBranchID")]
    public int? EtblAgentPwdHistoryIBranchId { get; set; }

    [Column("_etblAgentPwdHistory_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAgentPwdHistoryDCreatedDate { get; set; }

    [Column("_etblAgentPwdHistory_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAgentPwdHistoryDModifiedDate { get; set; }

    [Column("_etblAgentPwdHistory_iCreatedBranchID")]
    public int? EtblAgentPwdHistoryICreatedBranchId { get; set; }

    [Column("_etblAgentPwdHistory_iModifiedBranchID")]
    public int? EtblAgentPwdHistoryIModifiedBranchId { get; set; }

    [Column("_etblAgentPwdHistory_iCreatedAgentID")]
    public int? EtblAgentPwdHistoryICreatedAgentId { get; set; }

    [Column("_etblAgentPwdHistory_iModifiedAgentID")]
    public int? EtblAgentPwdHistoryIModifiedAgentId { get; set; }

    [Column("_etblAgentPwdHistory_iChangeSetID")]
    public int? EtblAgentPwdHistoryIChangeSetId { get; set; }

    [Column("_etblAgentPwdHistory_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAgentPwdHistoryChecksum { get; set; }
}
