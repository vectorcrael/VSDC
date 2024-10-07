using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPOSLogFile")]
[Index("RetPoslogFileChecksum", Name = "idx__retPOSLogFile__retPOSLogFile_Checksum")]
[Index("RetPoslogFileIChangeSetId", Name = "idx__retPOSLogFile_iChangeSetID")]
[Index("RetPoslogFileDModifiedDate", Name = "idx_retPOSLogFile_dModifiedDate")]
[Index("RetPoslogFileIBranchId", Name = "idx_retPOSLogFile_iBranchID")]
public partial class RetPoslogFile
{
    [Key]
    [Column("idPOSLogFile")]
    public int IdPoslogFile { get; set; }

    [Column("iSystemFunctionID")]
    public int? ISystemFunctionId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("iTillID")]
    public int ITillId { get; set; }

    [Column("iSupervisorAgentID")]
    public int? ISupervisorAgentId { get; set; }

    [Column("dCurrentDate", TypeName = "datetime")]
    public DateTime? DCurrentDate { get; set; }

    [Column("cDescription")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_retPOSLogFile_iBranchID")]
    public int? RetPoslogFileIBranchId { get; set; }

    [Column("_retPOSLogFile_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPoslogFileDCreatedDate { get; set; }

    [Column("_retPOSLogFile_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPoslogFileDModifiedDate { get; set; }

    [Column("_retPOSLogFile_iCreatedBranchID")]
    public int? RetPoslogFileICreatedBranchId { get; set; }

    [Column("_retPOSLogFile_iModifiedBranchID")]
    public int? RetPoslogFileIModifiedBranchId { get; set; }

    [Column("_retPOSLogFile_iCreatedAgentID")]
    public int? RetPoslogFileICreatedAgentId { get; set; }

    [Column("_retPOSLogFile_iModifiedAgentID")]
    public int? RetPoslogFileIModifiedAgentId { get; set; }

    [Column("_retPOSLogFile_iChangeSetID")]
    public int? RetPoslogFileIChangeSetId { get; set; }

    [Column("iTradingSessionID")]
    public int? ITradingSessionId { get; set; }

    [Column("_retPOSLogFile_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPoslogFileChecksum { get; set; }
}
