using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_mtblMBRCategories")]
[Index("MtblMbrcategoriesChecksum", Name = "idx__mtblMBRCategories__mtblMBRCategories_Checksum")]
[Index("MtblMbrcategoriesDModifiedDate", Name = "idx__mtblMBRCategories__mtblMBRCategories_dModifiedDate")]
[Index("MtblMbrcategoriesIBranchId", Name = "idx__mtblMBRCategories__mtblMBRCategories_iBranchID")]
[Index("MtblMbrcategoriesIChangeSetId", Name = "idx__mtblMBRCategories__mtblMBRCategories_iChangeSetID")]
public partial class MtblMbrcategory
{
    [Key]
    [Column("idMBRCategories")]
    public int IdMbrcategories { get; set; }

    [Column("cMBRCategory")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CMbrcategory { get; set; }

    [Column("cMBRDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CMbrdescription { get; set; }

    [Column("iMBRType")]
    public int? IMbrtype { get; set; }

    [Column("iMBRCategoryLinkID")]
    public int? IMbrcategoryLinkId { get; set; }

    [Column("_mtblMBRCategories_iBranchID")]
    public int? MtblMbrcategoriesIBranchId { get; set; }

    [Column("_mtblMBRCategories_dCreatedDate", TypeName = "datetime")]
    public DateTime? MtblMbrcategoriesDCreatedDate { get; set; }

    [Column("_mtblMBRCategories_dModifiedDate", TypeName = "datetime")]
    public DateTime? MtblMbrcategoriesDModifiedDate { get; set; }

    [Column("_mtblMBRCategories_iCreatedBranchID")]
    public int? MtblMbrcategoriesICreatedBranchId { get; set; }

    [Column("_mtblMBRCategories_iModifiedBranchID")]
    public int? MtblMbrcategoriesIModifiedBranchId { get; set; }

    [Column("_mtblMBRCategories_iCreatedAgentID")]
    public int? MtblMbrcategoriesICreatedAgentId { get; set; }

    [Column("_mtblMBRCategories_iModifiedAgentID")]
    public int? MtblMbrcategoriesIModifiedAgentId { get; set; }

    [Column("_mtblMBRCategories_iChangeSetID")]
    public int? MtblMbrcategoriesIChangeSetId { get; set; }

    [Column("_mtblMBRCategories_Checksum")]
    [MaxLength(20)]
    public byte[]? MtblMbrcategoriesChecksum { get; set; }
}
