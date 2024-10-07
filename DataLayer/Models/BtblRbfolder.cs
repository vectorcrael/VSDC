using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("CFolderName", "IParentId")]
[Table("_btblRBFolder")]
[Index("BtblRbfolderChecksum", Name = "idx__btblRBFolder__btblRBFolder_Checksum")]
[Index("BtblRbfolderIChangeSetId", Name = "idx__btblRBFolder_iChangeSetID")]
[Index("BtblRbfolderDModifiedDate", Name = "idx_btblRBFolder_dModifiedDate")]
[Index("BtblRbfolderIBranchId", Name = "idx_btblRBFolder_iBranchID")]
public partial class BtblRbfolder
{
    public int IdFolder { get; set; }

    [Key]
    [Column("cFolderName")]
    [StringLength(60)]
    [Unicode(false)]
    public string CFolderName { get; set; } = null!;

    [Key]
    [Column("iParentId")]
    public int IParentId { get; set; }

    [Column("_btblRBFolder_iBranchID")]
    public int? BtblRbfolderIBranchId { get; set; }

    [Column("_btblRBFolder_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblRbfolderDCreatedDate { get; set; }

    [Column("_btblRBFolder_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblRbfolderDModifiedDate { get; set; }

    [Column("_btblRBFolder_iCreatedBranchID")]
    public int? BtblRbfolderICreatedBranchId { get; set; }

    [Column("_btblRBFolder_iModifiedBranchID")]
    public int? BtblRbfolderIModifiedBranchId { get; set; }

    [Column("_btblRBFolder_iCreatedAgentID")]
    public int? BtblRbfolderICreatedAgentId { get; set; }

    [Column("_btblRBFolder_iModifiedAgentID")]
    public int? BtblRbfolderIModifiedAgentId { get; set; }

    [Column("_btblRBFolder_iChangeSetID")]
    public int? BtblRbfolderIChangeSetId { get; set; }

    [Column("_btblRBFolder_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblRbfolderChecksum { get; set; }
}
