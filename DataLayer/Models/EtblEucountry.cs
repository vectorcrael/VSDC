using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEUCountry")]
[Index("EtblEucountryChecksum", Name = "idx__etblEUCountry__etblEUCountry_Checksum")]
[Index("EtblEucountryIChangeSetId", Name = "idx__etblEUCountry_iChangeSetID")]
[Index("EtblEucountryDModifiedDate", Name = "idx_etblEUCountry_dModifiedDate")]
[Index("EtblEucountryIBranchId", Name = "idx_etblEUCountry_iBranchID")]
public partial class EtblEucountry
{
    [Key]
    [Column("IDEUCountry")]
    public int Ideucountry { get; set; }

    [Column("cEUCountryCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string CEucountryCode { get; set; } = null!;

    [Column("cEUCountryName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CEucountryName { get; set; }

    [Column("_etblEUCountry_iBranchID")]
    public int? EtblEucountryIBranchId { get; set; }

    [Column("_etblEUCountry_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEucountryDCreatedDate { get; set; }

    [Column("_etblEUCountry_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEucountryDModifiedDate { get; set; }

    [Column("_etblEUCountry_iCreatedBranchID")]
    public int? EtblEucountryICreatedBranchId { get; set; }

    [Column("_etblEUCountry_iModifiedBranchID")]
    public int? EtblEucountryIModifiedBranchId { get; set; }

    [Column("_etblEUCountry_iCreatedAgentID")]
    public int? EtblEucountryICreatedAgentId { get; set; }

    [Column("_etblEUCountry_iModifiedAgentID")]
    public int? EtblEucountryIModifiedAgentId { get; set; }

    [Column("_etblEUCountry_iChangeSetID")]
    public int? EtblEucountryIChangeSetId { get; set; }

    [Column("_etblEUCountry_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEucountryChecksum { get; set; }
}
