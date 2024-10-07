using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLSegment")]
[Index("EtblGlsegmentChecksum", Name = "idx__etblGLSegment__etblGLSegment_Checksum")]
[Index("EtblGlsegmentIChangeSetId", Name = "idx__etblGLSegment_iChangeSetID")]
[Index("EtblGlsegmentDModifiedDate", Name = "idx_etblGLSegment_dModifiedDate")]
[Index("EtblGlsegmentIBranchId", Name = "idx_etblGLSegment_iBranchID")]
public partial class EtblGlsegment
{
    [Key]
    [Column("idSegment")]
    public int IdSegment { get; set; }

    [Column("iSegmentNo")]
    public int ISegmentNo { get; set; }

    [Column("cCode")]
    [StringLength(40)]
    [Unicode(false)]
    public string CCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblGLSegment_iBranchID")]
    public int? EtblGlsegmentIBranchId { get; set; }

    [Column("_etblGLSegment_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlsegmentDCreatedDate { get; set; }

    [Column("_etblGLSegment_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlsegmentDModifiedDate { get; set; }

    [Column("_etblGLSegment_iCreatedBranchID")]
    public int? EtblGlsegmentICreatedBranchId { get; set; }

    [Column("_etblGLSegment_iModifiedBranchID")]
    public int? EtblGlsegmentIModifiedBranchId { get; set; }

    [Column("_etblGLSegment_iCreatedAgentID")]
    public int? EtblGlsegmentICreatedAgentId { get; set; }

    [Column("_etblGLSegment_iModifiedAgentID")]
    public int? EtblGlsegmentIModifiedAgentId { get; set; }

    [Column("_etblGLSegment_iChangeSetID")]
    public int? EtblGlsegmentIChangeSetId { get; set; }

    [Column("iSegmentBranchID")]
    public int? ISegmentBranchId { get; set; }

    [Column("_etblGLSegment_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlsegmentChecksum { get; set; }

    [Column("imSCOAAccountID")]
    public int? ImScoaaccountId { get; set; }

    [Column("mSCOAId")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MScoaid { get; set; }
}
