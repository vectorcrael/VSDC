using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblLogDetails")]
[Index("BtblLogDetailsChecksum", Name = "idx__btblLogDetails__btblLogDetails_Checksum")]
[Index("BtblLogDetailsIChangeSetId", Name = "idx__btblLogDetails_iChangeSetID")]
[Index("BtblLogDetailsDModifiedDate", Name = "idx_btblLogDetails_dModifiedDate")]
[Index("BtblLogDetailsIBranchId", Name = "idx_btblLogDetails_iBranchID")]
public partial class BtblLogDetail
{
    [Key]
    [Column("idLogDetails")]
    public int IdLogDetails { get; set; }

    [Column("iLogMasterID")]
    public int ILogMasterId { get; set; }

    [Column("dGroupTime", TypeName = "smalldatetime")]
    public DateTime DGroupTime { get; set; }

    [Column("dTimeLogged", TypeName = "datetime")]
    public DateTime DTimeLogged { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("iSeverity")]
    public int ISeverity { get; set; }

    [Column("cDetails")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CDetails { get; set; }

    [Column("cAddInfo")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CAddInfo { get; set; }

    [Column("_btblLogDetails_iBranchID")]
    public int? BtblLogDetailsIBranchId { get; set; }

    [Column("_btblLogDetails_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblLogDetailsDCreatedDate { get; set; }

    [Column("_btblLogDetails_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblLogDetailsDModifiedDate { get; set; }

    [Column("_btblLogDetails_iCreatedBranchID")]
    public int? BtblLogDetailsICreatedBranchId { get; set; }

    [Column("_btblLogDetails_iModifiedBranchID")]
    public int? BtblLogDetailsIModifiedBranchId { get; set; }

    [Column("_btblLogDetails_iCreatedAgentID")]
    public int? BtblLogDetailsICreatedAgentId { get; set; }

    [Column("_btblLogDetails_iModifiedAgentID")]
    public int? BtblLogDetailsIModifiedAgentId { get; set; }

    [Column("_btblLogDetails_iChangeSetID")]
    public int? BtblLogDetailsIChangeSetId { get; set; }

    [Column("_btblLogDetails_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblLogDetailsChecksum { get; set; }
}
