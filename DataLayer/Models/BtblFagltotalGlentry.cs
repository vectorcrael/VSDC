using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAGLTotalGLEntries")]
[Index("BtblFagltotalGlentriesChecksum", Name = "idx__btblFAGLTotalGLEntries__btblFAGLTotalGLEntries_Checksum")]
[Index("BtblFagltotalGlentriesIChangeSetId", Name = "idx__btblFAGLTotalGLEntries_iChangeSetID")]
[Index("BtblFagltotalGlentriesDModifiedDate", Name = "idx_btblFAGLTotalGLEntries_dModifiedDate")]
[Index("BtblFagltotalGlentriesIBranchId", Name = "idx_btblFAGLTotalGLEntries_iBranchID")]
public partial class BtblFagltotalGlentry
{
    [Key]
    [Column("idTotalGLEntries")]
    public int IdTotalGlentries { get; set; }

    [Column("iGLAccountID")]
    public int? IGlaccountId { get; set; }

    [Column("dDate", TypeName = "datetime")]
    public DateTime? DDate { get; set; }

    [Column("iPeriodID")]
    public int? IPeriodId { get; set; }

    [Column("fDrAmount")]
    public double? FDrAmount { get; set; }

    [Column("fCrAmount")]
    public double? FCrAmount { get; set; }

    [Column("_btblFAGLTotalGLEntries_iBranchID")]
    public int? BtblFagltotalGlentriesIBranchId { get; set; }

    [Column("_btblFAGLTotalGLEntries_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFagltotalGlentriesDCreatedDate { get; set; }

    [Column("_btblFAGLTotalGLEntries_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFagltotalGlentriesDModifiedDate { get; set; }

    [Column("_btblFAGLTotalGLEntries_iCreatedBranchID")]
    public int? BtblFagltotalGlentriesICreatedBranchId { get; set; }

    [Column("_btblFAGLTotalGLEntries_iModifiedBranchID")]
    public int? BtblFagltotalGlentriesIModifiedBranchId { get; set; }

    [Column("_btblFAGLTotalGLEntries_iCreatedAgentID")]
    public int? BtblFagltotalGlentriesICreatedAgentId { get; set; }

    [Column("_btblFAGLTotalGLEntries_iModifiedAgentID")]
    public int? BtblFagltotalGlentriesIModifiedAgentId { get; set; }

    [Column("_btblFAGLTotalGLEntries_iChangeSetID")]
    public int? BtblFagltotalGlentriesIChangeSetId { get; set; }

    [Column("_btblFAGLTotalGLEntries_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFagltotalGlentriesChecksum { get; set; }
}
