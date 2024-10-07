using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblLogMaster")]
[Index("BtblLogMasterChecksum", Name = "idx__btblLogMaster__btblLogMaster_Checksum")]
[Index("BtblLogMasterIChangeSetId", Name = "idx__btblLogMaster_iChangeSetID")]
[Index("BtblLogMasterDModifiedDate", Name = "idx_btblLogMaster_dModifiedDate")]
[Index("BtblLogMasterIBranchId", Name = "idx_btblLogMaster_iBranchID")]
public partial class BtblLogMaster
{
    [Column("idLogMaster")]
    public int IdLogMaster { get; set; }

    [Key]
    [Column("iLogOrdinal")]
    public int ILogOrdinal { get; set; }

    [Column("cLogName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CLogName { get; set; } = null!;

    [Column("_btblLogMaster_iBranchID")]
    public int? BtblLogMasterIBranchId { get; set; }

    [Column("_btblLogMaster_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblLogMasterDCreatedDate { get; set; }

    [Column("_btblLogMaster_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblLogMasterDModifiedDate { get; set; }

    [Column("_btblLogMaster_iCreatedBranchID")]
    public int? BtblLogMasterICreatedBranchId { get; set; }

    [Column("_btblLogMaster_iModifiedBranchID")]
    public int? BtblLogMasterIModifiedBranchId { get; set; }

    [Column("_btblLogMaster_iCreatedAgentID")]
    public int? BtblLogMasterICreatedAgentId { get; set; }

    [Column("_btblLogMaster_iModifiedAgentID")]
    public int? BtblLogMasterIModifiedAgentId { get; set; }

    [Column("_btblLogMaster_iChangeSetID")]
    public int? BtblLogMasterIChangeSetId { get; set; }

    [Column("_btblLogMaster_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblLogMasterChecksum { get; set; }
}
