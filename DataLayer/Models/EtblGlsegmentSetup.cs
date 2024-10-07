using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLSegmentSetup")]
[Index("EtblGlsegmentSetupChecksum", Name = "idx__etblGLSegmentSetup__etblGLSegmentSetup_Checksum")]
[Index("EtblGlsegmentSetupIChangeSetId", Name = "idx__etblGLSegmentSetup_iChangeSetID")]
[Index("EtblGlsegmentSetupDModifiedDate", Name = "idx_etblGLSegmentSetup_dModifiedDate")]
[Index("EtblGlsegmentSetupIBranchId", Name = "idx_etblGLSegmentSetup_iBranchID")]
public partial class EtblGlsegmentSetup
{
    [Key]
    [Column("idSegmentNo")]
    public int IdSegmentNo { get; set; }

    [Column("bForceValue")]
    public bool BForceValue { get; set; }

    [Column("bSegmentUsed")]
    public bool BSegmentUsed { get; set; }

    [Column("cSegmentLabel")]
    [StringLength(35)]
    [Unicode(false)]
    public string CSegmentLabel { get; set; } = null!;

    [Column("cSegmentMask")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CSegmentMask { get; set; }

    [Column("bInUse")]
    public bool BInUse { get; set; }

    [Column("_etblGLSegmentSetup_iBranchID")]
    public int? EtblGlsegmentSetupIBranchId { get; set; }

    [Column("_etblGLSegmentSetup_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlsegmentSetupDCreatedDate { get; set; }

    [Column("_etblGLSegmentSetup_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlsegmentSetupDModifiedDate { get; set; }

    [Column("_etblGLSegmentSetup_iCreatedBranchID")]
    public int? EtblGlsegmentSetupICreatedBranchId { get; set; }

    [Column("_etblGLSegmentSetup_iModifiedBranchID")]
    public int? EtblGlsegmentSetupIModifiedBranchId { get; set; }

    [Column("_etblGLSegmentSetup_iCreatedAgentID")]
    public int? EtblGlsegmentSetupICreatedAgentId { get; set; }

    [Column("_etblGLSegmentSetup_iModifiedAgentID")]
    public int? EtblGlsegmentSetupIModifiedAgentId { get; set; }

    [Column("_etblGLSegmentSetup_iChangeSetID")]
    public int? EtblGlsegmentSetupIChangeSetId { get; set; }

    [Column("bIsBranchSegment")]
    public bool BIsBranchSegment { get; set; }

    [Column("_etblGLSegmentSetup_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlsegmentSetupChecksum { get; set; }
}
