using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblReportJobLog")]
[Index("EtblReportJobLogChecksum", Name = "idx__etblReportJobLog__etblReportJobLog_Checksum")]
[Index("EtblReportJobLogIChangeSetId", Name = "idx__etblReportJobLog_iChangeSetID")]
[Index("EtblReportJobLogDModifiedDate", Name = "idx_etblReportJobLog_dModifiedDate")]
[Index("EtblReportJobLogIBranchId", Name = "idx_etblReportJobLog_iBranchID")]
public partial class EtblReportJobLog
{
    [Key]
    [Column("idReportJobLog")]
    public int IdReportJobLog { get; set; }

    [Column("iJobType")]
    public int? IJobType { get; set; }

    [Column("iReportJobID")]
    public int? IReportJobId { get; set; }

    [Column("dLogTime", TypeName = "datetime")]
    public DateTime? DLogTime { get; set; }

    [Column("iLogType")]
    public int? ILogType { get; set; }

    [Column("cLogDescription")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLogDescription { get; set; }

    [Column("nLogData", TypeName = "image")]
    public byte[]? NLogData { get; set; }

    [Column("_etblReportJobLog_iBranchID")]
    public int? EtblReportJobLogIBranchId { get; set; }

    [Column("_etblReportJobLog_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblReportJobLogDCreatedDate { get; set; }

    [Column("_etblReportJobLog_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblReportJobLogDModifiedDate { get; set; }

    [Column("_etblReportJobLog_iCreatedBranchID")]
    public int? EtblReportJobLogICreatedBranchId { get; set; }

    [Column("_etblReportJobLog_iModifiedBranchID")]
    public int? EtblReportJobLogIModifiedBranchId { get; set; }

    [Column("_etblReportJobLog_iCreatedAgentID")]
    public int? EtblReportJobLogICreatedAgentId { get; set; }

    [Column("_etblReportJobLog_iModifiedAgentID")]
    public int? EtblReportJobLogIModifiedAgentId { get; set; }

    [Column("_etblReportJobLog_iChangeSetID")]
    public int? EtblReportJobLogIChangeSetId { get; set; }

    [Column("_etblReportJobLog_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblReportJobLogChecksum { get; set; }
}
