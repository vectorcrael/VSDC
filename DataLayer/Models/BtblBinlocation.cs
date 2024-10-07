using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblBINLocation")]
[Index("BtblBinlocationChecksum", Name = "idx__btblBINLocation__btblBINLocation_Checksum")]
[Index("BtblBinlocationIChangeSetId", Name = "idx__btblBINLocation_iChangeSetID")]
[Index("BtblBinlocationDModifiedDate", Name = "idx_btblBINLocation_dModifiedDate")]
[Index("BtblBinlocationIBranchId", Name = "idx_btblBINLocation_iBranchID")]
public partial class BtblBinlocation
{
    [Key]
    [Column("idBinLocation")]
    public int IdBinLocation { get; set; }

    [Column("cBinLocationName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CBinLocationName { get; set; } = null!;

    [Column("_btblBINLocation_iBranchID")]
    public int? BtblBinlocationIBranchId { get; set; }

    [Column("_btblBINLocation_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblBinlocationDCreatedDate { get; set; }

    [Column("_btblBINLocation_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblBinlocationDModifiedDate { get; set; }

    [Column("_btblBINLocation_iCreatedBranchID")]
    public int? BtblBinlocationICreatedBranchId { get; set; }

    [Column("_btblBINLocation_iModifiedBranchID")]
    public int? BtblBinlocationIModifiedBranchId { get; set; }

    [Column("_btblBINLocation_iCreatedAgentID")]
    public int? BtblBinlocationICreatedAgentId { get; set; }

    [Column("_btblBINLocation_iModifiedAgentID")]
    public int? BtblBinlocationIModifiedAgentId { get; set; }

    [Column("_btblBINLocation_iChangeSetID")]
    public int? BtblBinlocationIChangeSetId { get; set; }

    [Column("cBinLocationDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CBinLocationDescription { get; set; }

    [Column("_btblBINLocation_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblBinlocationChecksum { get; set; }
}
