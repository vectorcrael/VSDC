using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxBoxLayout")]
[Index("EtblTaxBoxLayoutChecksum", Name = "idx__etblTaxBoxLayout__etblTaxBoxLayout_Checksum")]
[Index("EtblTaxBoxLayoutDModifiedDate", Name = "idx__etblTaxBoxLayout__etblTaxBoxLayout_dModifiedDate")]
[Index("EtblTaxBoxLayoutIBranchId", Name = "idx__etblTaxBoxLayout__etblTaxBoxLayout_iBranchID")]
[Index("EtblTaxBoxLayoutIChangeSetId", Name = "idx__etblTaxBoxLayout__etblTaxBoxLayout_iChangeSetID")]
public partial class EtblTaxBoxLayout
{
    [Key]
    [Column("idTaxBoxLayout")]
    public int IdTaxBoxLayout { get; set; }

    [Column("iTaxGroupID")]
    public int? ITaxGroupId { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iTaxBoxSetupID")]
    public int? ITaxBoxSetupId { get; set; }

    [Column("_etblTaxBoxLayout_iBranchID")]
    public int? EtblTaxBoxLayoutIBranchId { get; set; }

    [Column("_etblTaxBoxLayout_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTaxBoxLayoutDCreatedDate { get; set; }

    [Column("_etblTaxBoxLayout_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTaxBoxLayoutDModifiedDate { get; set; }

    [Column("_etblTaxBoxLayout_iCreatedBranchID")]
    public int? EtblTaxBoxLayoutICreatedBranchId { get; set; }

    [Column("_etblTaxBoxLayout_iModifiedBranchID")]
    public int? EtblTaxBoxLayoutIModifiedBranchId { get; set; }

    [Column("_etblTaxBoxLayout_iCreatedAgentID")]
    public int? EtblTaxBoxLayoutICreatedAgentId { get; set; }

    [Column("_etblTaxBoxLayout_iModifiedAgentID")]
    public int? EtblTaxBoxLayoutIModifiedAgentId { get; set; }

    [Column("_etblTaxBoxLayout_iChangeSetID")]
    public int? EtblTaxBoxLayoutIChangeSetId { get; set; }

    [Column("_etblTaxBoxLayout_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTaxBoxLayoutChecksum { get; set; }
}
