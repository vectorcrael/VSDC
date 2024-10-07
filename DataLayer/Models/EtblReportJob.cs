using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblReportJobs")]
[Index("EtblReportJobsChecksum", Name = "idx__etblReportJobs__etblReportJobs_Checksum")]
[Index("EtblReportJobsIChangeSetId", Name = "idx__etblReportJobs_iChangeSetID")]
[Index("EtblReportJobsDModifiedDate", Name = "idx_etblReportJobs_dModifiedDate")]
[Index("EtblReportJobsIBranchId", Name = "idx_etblReportJobs_iBranchID")]
public partial class EtblReportJob
{
    [Key]
    [Column("idReportJobs")]
    public int IdReportJobs { get; set; }

    [Column("iReportJobParentID")]
    public int? IReportJobParentId { get; set; }

    [Column("cReportJobName")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CReportJobName { get; set; }

    [Column("iReportJobType")]
    public int? IReportJobType { get; set; }

    [Column("nReportJobProps", TypeName = "text")]
    public string? NReportJobProps { get; set; }

    [Column("iReportJobAgentID")]
    public int? IReportJobAgentId { get; set; }

    [Column("_etblReportJobs_iBranchID")]
    public int? EtblReportJobsIBranchId { get; set; }

    [Column("_etblReportJobs_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblReportJobsDCreatedDate { get; set; }

    [Column("_etblReportJobs_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblReportJobsDModifiedDate { get; set; }

    [Column("_etblReportJobs_iCreatedBranchID")]
    public int? EtblReportJobsICreatedBranchId { get; set; }

    [Column("_etblReportJobs_iModifiedBranchID")]
    public int? EtblReportJobsIModifiedBranchId { get; set; }

    [Column("_etblReportJobs_iCreatedAgentID")]
    public int? EtblReportJobsICreatedAgentId { get; set; }

    [Column("_etblReportJobs_iModifiedAgentID")]
    public int? EtblReportJobsIModifiedAgentId { get; set; }

    [Column("_etblReportJobs_iChangeSetID")]
    public int? EtblReportJobsIChangeSetId { get; set; }

    [Column("_etblReportJobs_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblReportJobsChecksum { get; set; }
}
