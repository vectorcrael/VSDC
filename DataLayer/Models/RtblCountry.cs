using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblCountry")]
[Index("RtblCountryChecksum", Name = "idx__rtblCountry__rtblCountry_Checksum")]
[Index("RtblCountryIChangeSetId", Name = "idx__rtblCountry_iChangeSetID")]
[Index("RtblCountryDModifiedDate", Name = "idx_rtblCountry_dModifiedDate")]
[Index("RtblCountryIBranchId", Name = "idx_rtblCountry_iBranchID")]
public partial class RtblCountry
{
    [Key]
    [Column("idCountry")]
    public int IdCountry { get; set; }

    [Column("cCountryName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CCountryName { get; set; } = null!;

    [Column("_rtblCountry_iBranchID")]
    public int? RtblCountryIBranchId { get; set; }

    [Column("_rtblCountry_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblCountryDCreatedDate { get; set; }

    [Column("_rtblCountry_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblCountryDModifiedDate { get; set; }

    [Column("_rtblCountry_iCreatedBranchID")]
    public int? RtblCountryICreatedBranchId { get; set; }

    [Column("_rtblCountry_iModifiedBranchID")]
    public int? RtblCountryIModifiedBranchId { get; set; }

    [Column("_rtblCountry_iCreatedAgentID")]
    public int? RtblCountryICreatedAgentId { get; set; }

    [Column("_rtblCountry_iModifiedAgentID")]
    public int? RtblCountryIModifiedAgentId { get; set; }

    [Column("_rtblCountry_iChangeSetID")]
    public int? RtblCountryIChangeSetId { get; set; }

    [Column("_rtblCountry_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblCountryChecksum { get; set; }
}
