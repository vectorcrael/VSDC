using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSagePayQueue")]
[Index("EtblSagePayQueueChecksum", Name = "idx__etblSagePayQueue__etblSagePayQueue_Checksum")]
[Index("EtblSagePayQueueDModifiedDate", Name = "idx__etblSagePayQueue__etblSagePayQueue_dModifiedDate")]
[Index("EtblSagePayQueueIBranchId", Name = "idx__etblSagePayQueue__etblSagePayQueue_iBranchID")]
[Index("EtblSagePayQueueIChangeSetId", Name = "idx__etblSagePayQueue__etblSagePayQueue_iChangeSetID")]
public partial class EtblSagePayQueue
{
    [Key]
    [Column("idSPQueue")]
    public int IdSpqueue { get; set; }

    [Column("iService")]
    public int? IService { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cInstruction")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInstruction { get; set; }

    [Column("bTestOnly")]
    public bool? BTestOnly { get; set; }

    [Column("iSubmissionStatus")]
    public int? ISubmissionStatus { get; set; }

    [Column("iResponseStatus")]
    public int? IResponseStatus { get; set; }

    [Column("dCreated", TypeName = "datetime")]
    public DateTime? DCreated { get; set; }

    [Column("dLastPolled", TypeName = "datetime")]
    public DateTime? DLastPolled { get; set; }

    [Column("cToken")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CToken { get; set; }

    [Column("cBatchName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBatchName { get; set; }

    [Column("cBatchData")]
    [Unicode(false)]
    public string? CBatchData { get; set; }

    [Column("iRecordID")]
    public int? IRecordId { get; set; }

    [Column("cModule")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CModule { get; set; }

    [Column("cSubmissionData")]
    [Unicode(false)]
    public string? CSubmissionData { get; set; }

    [Column("cResponseData")]
    [Unicode(false)]
    public string? CResponseData { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("_etblSagePayQueue_iBranchID")]
    public int? EtblSagePayQueueIBranchId { get; set; }

    [Column("_etblSagePayQueue_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayQueueDCreatedDate { get; set; }

    [Column("_etblSagePayQueue_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayQueueDModifiedDate { get; set; }

    [Column("_etblSagePayQueue_iCreatedBranchID")]
    public int? EtblSagePayQueueICreatedBranchId { get; set; }

    [Column("_etblSagePayQueue_iModifiedBranchID")]
    public int? EtblSagePayQueueIModifiedBranchId { get; set; }

    [Column("_etblSagePayQueue_iCreatedAgentID")]
    public int? EtblSagePayQueueICreatedAgentId { get; set; }

    [Column("_etblSagePayQueue_iModifiedAgentID")]
    public int? EtblSagePayQueueIModifiedAgentId { get; set; }

    [Column("_etblSagePayQueue_iChangeSetID")]
    public int? EtblSagePayQueueIChangeSetId { get; set; }

    [Column("_etblSagePayQueue_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSagePayQueueChecksum { get; set; }
}
