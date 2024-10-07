using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPosMenu")]
[Index("RetPosmenuChecksum", Name = "idx__retPOSMenu__retPOSMenu_Checksum")]
[Index("RetPosmenuDModifiedDate", Name = "idx__retPOSMenu__retPOSMenu_dModifiedDate")]
[Index("RetPosmenuIBranchId", Name = "idx__retPOSMenu__retPOSMenu_iBranchID")]
[Index("RetPosmenuIChangeSetId", Name = "idx__retPOSMenu__retPOSMenu_iChangeSetID")]
public partial class RetPosMenu
{
    [Key]
    [Column("idPOSMenu")]
    public long IdPosmenu { get; set; }

    [Column("iPOSKeyIndex")]
    public int? IPoskeyIndex { get; set; }

    [Column("cPOSKeyCaption")]
    [StringLength(50)]
    public string? CPoskeyCaption { get; set; }

    [Column("iPOSKeyColor")]
    public int? IPoskeyColor { get; set; }

    [Column("iPOSKeyFontColor")]
    public int? IPoskeyFontColor { get; set; }

    [Column("iCustomIndex")]
    public int? ICustomIndex { get; set; }

    [Column("idPOSMenuSetup")]
    public long? IdPosmenuSetup { get; set; }

    [Column("cSkinName")]
    [StringLength(50)]
    public string? CSkinName { get; set; }

    [Column("_retPOSMenu_iBranchID")]
    public int? RetPosmenuIBranchId { get; set; }

    [Column("_retPOSMenu_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPosmenuDCreatedDate { get; set; }

    [Column("_retPOSMenu_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPosmenuDModifiedDate { get; set; }

    [Column("_retPOSMenu_iCreatedBranchID")]
    public int? RetPosmenuICreatedBranchId { get; set; }

    [Column("_retPOSMenu_iModifiedBranchID")]
    public int? RetPosmenuIModifiedBranchId { get; set; }

    [Column("_retPOSMenu_iCreatedAgentID")]
    public int? RetPosmenuICreatedAgentId { get; set; }

    [Column("_retPOSMenu_iModifiedAgentID")]
    public int? RetPosmenuIModifiedAgentId { get; set; }

    [Column("_retPOSMenu_iChangeSetID")]
    public int? RetPosmenuIChangeSetId { get; set; }

    [Column("_retPOSMenu_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPosmenuChecksum { get; set; }

    [Column("bUseDesignColour")]
    public bool? BUseDesignColour { get; set; }

    [Column("iStockLink")]
    public int? IStockLink { get; set; }

    [Column("iMID")]
    public int? IMid { get; set; }
}
