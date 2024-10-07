using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPOSMenuSetup")]
[Index("RetPosmenuSetupChecksum", Name = "idx__retPOSMenuSetup__retPOSMenuSetup_Checksum")]
[Index("RetPosmenuSetupDModifiedDate", Name = "idx__retPOSMenuSetup__retPOSMenuSetup_dModifiedDate")]
[Index("RetPosmenuSetupIBranchId", Name = "idx__retPOSMenuSetup__retPOSMenuSetup_iBranchID")]
[Index("RetPosmenuSetupIChangeSetId", Name = "idx__retPOSMenuSetup__retPOSMenuSetup_iChangeSetID")]
public partial class RetPosmenuSetup
{
    [Key]
    [Column("idPOSMenuSetup")]
    public long IdPosmenuSetup { get; set; }

    [Column("cPOSMenuCode")]
    [StringLength(50)]
    public string? CPosmenuCode { get; set; }

    [Column("cPOSMenuDescription")]
    [StringLength(50)]
    public string? CPosmenuDescription { get; set; }

    [Column("_retPOSMenuSetup_iBranchID")]
    public int? RetPosmenuSetupIBranchId { get; set; }

    [Column("_retPOSMenuSetup_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPosmenuSetupDCreatedDate { get; set; }

    [Column("_retPOSMenuSetup_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPosmenuSetupDModifiedDate { get; set; }

    [Column("_retPOSMenuSetup_iCreatedBranchID")]
    public int? RetPosmenuSetupICreatedBranchId { get; set; }

    [Column("_retPOSMenuSetup_iModifiedBranchID")]
    public int? RetPosmenuSetupIModifiedBranchId { get; set; }

    [Column("_retPOSMenuSetup_iCreatedAgentID")]
    public int? RetPosmenuSetupICreatedAgentId { get; set; }

    [Column("_retPOSMenuSetup_iModifiedAgentID")]
    public int? RetPosmenuSetupIModifiedAgentId { get; set; }

    [Column("_retPOSMenuSetup_iChangeSetID")]
    public int? RetPosmenuSetupIChangeSetId { get; set; }

    [Column("_retPOSMenuSetup_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPosmenuSetupChecksum { get; set; }

    [Column("iBackgroundColour")]
    public int? IBackgroundColour { get; set; }

    [Column("bTransparentDisabledButtons")]
    public bool? BTransparentDisabledButtons { get; set; }
}
