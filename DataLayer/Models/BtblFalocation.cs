using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFALocation")]
[Index("BtblFalocationChecksum", Name = "idx__btblFALocation__btblFALocation_Checksum")]
[Index("BtblFalocationIChangeSetId", Name = "idx__btblFALocation_iChangeSetID")]
[Index("BtblFalocationDModifiedDate", Name = "idx_btblFALocation_dModifiedDate")]
[Index("BtblFalocationIBranchId", Name = "idx_btblFALocation_iBranchID")]
public partial class BtblFalocation
{
    [Key]
    [Column("idLocationNo")]
    public int IdLocationNo { get; set; }

    [Column("cLocationCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CLocationCode { get; set; } = null!;

    [Column("cLocationDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CLocationDesc { get; set; } = null!;

    [Column("_btblFALocation_iBranchID")]
    public int? BtblFalocationIBranchId { get; set; }

    [Column("_btblFALocation_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFalocationDCreatedDate { get; set; }

    [Column("_btblFALocation_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFalocationDModifiedDate { get; set; }

    [Column("_btblFALocation_iCreatedBranchID")]
    public int? BtblFalocationICreatedBranchId { get; set; }

    [Column("_btblFALocation_iModifiedBranchID")]
    public int? BtblFalocationIModifiedBranchId { get; set; }

    [Column("_btblFALocation_iCreatedAgentID")]
    public int? BtblFalocationICreatedAgentId { get; set; }

    [Column("_btblFALocation_iModifiedAgentID")]
    public int? BtblFalocationIModifiedAgentId { get; set; }

    [Column("_btblFALocation_iChangeSetID")]
    public int? BtblFalocationIChangeSetId { get; set; }

    [Column("_btblFALocation_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFalocationChecksum { get; set; }
}
