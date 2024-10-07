using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFatakeOnDate
{
    [Column("idGLPeriodNo")]
    public int IdGlperiodNo { get; set; }

    [Column("dStartDate", TypeName = "smalldatetime")]
    public DateTime DStartDate { get; set; }

    [Column("dEndDate", TypeName = "smalldatetime")]
    public DateTime DEndDate { get; set; }

    [Column("cDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("iYear")]
    public int IYear { get; set; }

    [Column("iPeriodNo")]
    public int IPeriodNo { get; set; }

    [Column("bBlockInd")]
    public bool? BBlockInd { get; set; }

    [Column("bClosedInd")]
    public bool? BClosedInd { get; set; }

    [Column("bReopened")]
    public bool? BReopened { get; set; }

    [Column("_btblFAGLPeriod_iBranchID")]
    public int? BtblFaglperiodIBranchId { get; set; }

    [Column("_btblFAGLPeriod_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaglperiodDCreatedDate { get; set; }

    [Column("_btblFAGLPeriod_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaglperiodDModifiedDate { get; set; }

    [Column("_btblFAGLPeriod_iCreatedBranchID")]
    public int? BtblFaglperiodICreatedBranchId { get; set; }

    [Column("_btblFAGLPeriod_iModifiedBranchID")]
    public int? BtblFaglperiodIModifiedBranchId { get; set; }

    [Column("_btblFAGLPeriod_iCreatedAgentID")]
    public int? BtblFaglperiodICreatedAgentId { get; set; }

    [Column("_btblFAGLPeriod_iModifiedAgentID")]
    public int? BtblFaglperiodIModifiedAgentId { get; set; }

    [Column("_btblFAGLPeriod_iChangeSetID")]
    public int? BtblFaglperiodIChangeSetId { get; set; }

    [Column("_btblFAGLPeriod_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaglperiodChecksum { get; set; }
}
