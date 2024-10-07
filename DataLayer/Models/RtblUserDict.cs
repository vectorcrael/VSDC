using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblUserDict")]
[Index("RtblUserDictChecksum", Name = "idx__rtblUserDict__rtblUserDict_Checksum")]
[Index("RtblUserDictIChangeSetId", Name = "idx__rtblUserDict_iChangeSetID")]
[Index("RtblUserDictDModifiedDate", Name = "idx_rtblUserDict_dModifiedDate")]
[Index("RtblUserDictIBranchId", Name = "idx_rtblUserDict_iBranchID")]
public partial class RtblUserDict
{
    [Key]
    [Column("idUserDict")]
    public int IdUserDict { get; set; }

    [Column("cFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CFieldName { get; set; } = null!;

    [Column("cFieldDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CFieldDescription { get; set; } = null!;

    [Column("iFieldType")]
    public int IFieldType { get; set; }

    [Column("iFieldSize")]
    public int? IFieldSize { get; set; }

    [Column("iFieldIndex")]
    public int IFieldIndex { get; set; }

    [Column("cTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Column("cLookupOptions")]
    [Unicode(false)]
    public string? CLookupOptions { get; set; }

    [Column("bForceValue")]
    public bool BForceValue { get; set; }

    [Column("cDefaultValue")]
    [StringLength(250)]
    [Unicode(false)]
    public string? CDefaultValue { get; set; }

    [Column("iPageIndex")]
    public int? IPageIndex { get; set; }

    [Column("cPageName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CPageName { get; set; }

    [Column("iFieldDecimals")]
    public int? IFieldDecimals { get; set; }

    [Column("_rtblUserDict_iBranchID")]
    public int? RtblUserDictIBranchId { get; set; }

    [Column("_rtblUserDict_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblUserDictDCreatedDate { get; set; }

    [Column("_rtblUserDict_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblUserDictDModifiedDate { get; set; }

    [Column("_rtblUserDict_iCreatedBranchID")]
    public int? RtblUserDictICreatedBranchId { get; set; }

    [Column("_rtblUserDict_iModifiedBranchID")]
    public int? RtblUserDictIModifiedBranchId { get; set; }

    [Column("_rtblUserDict_iCreatedAgentID")]
    public int? RtblUserDictICreatedAgentId { get; set; }

    [Column("_rtblUserDict_iModifiedAgentID")]
    public int? RtblUserDictIModifiedAgentId { get; set; }

    [Column("iModuleOptions")]
    public int? IModuleOptions { get; set; }

    [Column("_rtblUserDict_iChangeSetID")]
    public int? RtblUserDictIChangeSetId { get; set; }

    [Column("_rtblUserDict_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblUserDictChecksum { get; set; }
}
