using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblUnitCategory")]
[Index("EtblUnitCategoryChecksum", Name = "idx__etblUnitCategory__etblUnitCategory_Checksum")]
[Index("EtblUnitCategoryIChangeSetId", Name = "idx__etblUnitCategory_iChangeSetID")]
[Index("EtblUnitCategoryDModifiedDate", Name = "idx_etblUnitCategory_dModifiedDate")]
[Index("EtblUnitCategoryIBranchId", Name = "idx_etblUnitCategory_iBranchID")]
public partial class EtblUnitCategory
{
    [Key]
    [Column("idUnitCategory")]
    public int IdUnitCategory { get; set; }

    [Column("cUnitCatDescription")]
    [StringLength(20)]
    [Unicode(false)]
    public string CUnitCatDescription { get; set; } = null!;

    [Column("_etblUnitCategory_iBranchID")]
    public int? EtblUnitCategoryIBranchId { get; set; }

    [Column("_etblUnitCategory_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblUnitCategoryDCreatedDate { get; set; }

    [Column("_etblUnitCategory_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblUnitCategoryDModifiedDate { get; set; }

    [Column("_etblUnitCategory_iCreatedBranchID")]
    public int? EtblUnitCategoryICreatedBranchId { get; set; }

    [Column("_etblUnitCategory_iModifiedBranchID")]
    public int? EtblUnitCategoryIModifiedBranchId { get; set; }

    [Column("_etblUnitCategory_iCreatedAgentID")]
    public int? EtblUnitCategoryICreatedAgentId { get; set; }

    [Column("_etblUnitCategory_iModifiedAgentID")]
    public int? EtblUnitCategoryIModifiedAgentId { get; set; }

    [Column("_etblUnitCategory_iChangeSetID")]
    public int? EtblUnitCategoryIChangeSetId { get; set; }

    [Column("_etblUnitCategory_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblUnitCategoryChecksum { get; set; }
}
