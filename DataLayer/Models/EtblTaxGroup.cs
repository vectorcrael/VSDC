using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxGroup")]
[Index("EtblTaxGroupChecksum", Name = "idx__etblTaxGroup__etblTaxGroup_Checksum")]
[Index("EtblTaxGroupDModifiedDate", Name = "idx__etblTaxGroup__etblTaxGroup_dModifiedDate")]
[Index("EtblTaxGroupIBranchId", Name = "idx__etblTaxGroup__etblTaxGroup_iBranchID")]
[Index("EtblTaxGroupIChangeSetId", Name = "idx__etblTaxGroup__etblTaxGroup_iChangeSetID")]
public partial class EtblTaxGroup
{
    [Key]
    [Column("idTaxGroup")]
    public int IdTaxGroup { get; set; }

    [Column("cCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCode { get; set; }

    [Column("cDescription")]
    [StringLength(120)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblTaxGroup_iBranchID")]
    public int? EtblTaxGroupIBranchId { get; set; }

    [Column("_etblTaxGroup_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTaxGroupDCreatedDate { get; set; }

    [Column("_etblTaxGroup_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTaxGroupDModifiedDate { get; set; }

    [Column("_etblTaxGroup_iCreatedBranchID")]
    public int? EtblTaxGroupICreatedBranchId { get; set; }

    [Column("_etblTaxGroup_iModifiedBranchID")]
    public int? EtblTaxGroupIModifiedBranchId { get; set; }

    [Column("_etblTaxGroup_iCreatedAgentID")]
    public int? EtblTaxGroupICreatedAgentId { get; set; }

    [Column("_etblTaxGroup_iModifiedAgentID")]
    public int? EtblTaxGroupIModifiedAgentId { get; set; }

    [Column("_etblTaxGroup_iChangeSetID")]
    public int? EtblTaxGroupIChangeSetId { get; set; }

    [Column("_etblTaxGroup_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTaxGroupChecksum { get; set; }
}
