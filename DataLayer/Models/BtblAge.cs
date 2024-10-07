using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblAges")]
[Index("BtblAgesChecksum", Name = "idx__btblAges__btblAges_Checksum")]
[Index("BtblAgesIChangeSetId", Name = "idx__btblAges_iChangeSetID")]
[Index("BtblAgesDModifiedDate", Name = "idx_btblAges_dModifiedDate")]
[Index("BtblAgesIBranchId", Name = "idx_btblAges_iBranchID")]
public partial class BtblAge
{
    [Key]
    [Column("idAges")]
    public int IdAges { get; set; }

    [Column("nARAges", TypeName = "image")]
    public byte[]? NArages { get; set; }

    [Column("nAPAges", TypeName = "image")]
    public byte[]? NApages { get; set; }

    [Column("_btblAges_iBranchID")]
    public int? BtblAgesIBranchId { get; set; }

    [Column("_btblAges_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblAgesDCreatedDate { get; set; }

    [Column("_btblAges_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblAgesDModifiedDate { get; set; }

    [Column("_btblAges_iCreatedBranchID")]
    public int? BtblAgesICreatedBranchId { get; set; }

    [Column("_btblAges_iModifiedBranchID")]
    public int? BtblAgesIModifiedBranchId { get; set; }

    [Column("_btblAges_iCreatedAgentID")]
    public int? BtblAgesICreatedAgentId { get; set; }

    [Column("_btblAges_iModifiedAgentID")]
    public int? BtblAgesIModifiedAgentId { get; set; }

    [Column("_btblAges_iChangeSetID")]
    public int? BtblAgesIChangeSetId { get; set; }

    [Column("_btblAges_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblAgesChecksum { get; set; }
}
