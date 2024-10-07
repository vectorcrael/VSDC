using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("CTableName", "CFieldName")]
[Table("_btblRBUDefField")]
[Index("BtblRbudefFieldChecksum", Name = "idx__btblRBUDefField__btblRBUDefField_Checksum")]
[Index("BtblRbudefFieldIChangeSetId", Name = "idx__btblRBUDefField_iChangeSetID")]
[Index("BtblRbudefFieldDModifiedDate", Name = "idx_btblRBUDefField_dModifiedDate")]
[Index("BtblRbudefFieldIBranchId", Name = "idx_btblRBUDefField_iBranchID")]
public partial class BtblRbudefField
{
    [Key]
    [Column("cTableName")]
    [StringLength(60)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Key]
    [Column("cFieldName")]
    [StringLength(60)]
    [Unicode(false)]
    public string CFieldName { get; set; } = null!;

    [Column("cFieldAlias")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CFieldAlias { get; set; }

    [Column("cDataType")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDataType { get; set; }

    [Column("cSelectable")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CSelectable { get; set; }

    [Column("cSearchable")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CSearchable { get; set; }

    [Column("cSortable")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CSortable { get; set; }

    [Column("cAutoSearch")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAutoSearch { get; set; }

    [Column("cMandatory")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CMandatory { get; set; }

    [Column("_btblRBUDefField_iBranchID")]
    public int? BtblRbudefFieldIBranchId { get; set; }

    [Column("_btblRBUDefField_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblRbudefFieldDCreatedDate { get; set; }

    [Column("_btblRBUDefField_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblRbudefFieldDModifiedDate { get; set; }

    [Column("_btblRBUDefField_iCreatedBranchID")]
    public int? BtblRbudefFieldICreatedBranchId { get; set; }

    [Column("_btblRBUDefField_iModifiedBranchID")]
    public int? BtblRbudefFieldIModifiedBranchId { get; set; }

    [Column("_btblRBUDefField_iCreatedAgentID")]
    public int? BtblRbudefFieldICreatedAgentId { get; set; }

    [Column("_btblRBUDefField_iModifiedAgentID")]
    public int? BtblRbudefFieldIModifiedAgentId { get; set; }

    [Column("_btblRBUDefField_iChangeSetID")]
    public int? BtblRbudefFieldIChangeSetId { get; set; }

    [Column("_btblRBUDefField_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblRbudefFieldChecksum { get; set; }
}
