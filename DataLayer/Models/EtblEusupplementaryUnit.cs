using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEUSupplementaryUnit")]
[Index("EtblEusupplementaryUnitChecksum", Name = "idx__etblEUSupplementaryUnit__etblEUSupplementaryUnit_Checksum")]
[Index("EtblEusupplementaryUnitIChangeSetId", Name = "idx__etblEUSupplementaryUnit_iChangeSetID")]
[Index("EtblEusupplementaryUnitDModifiedDate", Name = "idx_etblEUSupplementaryUnit_dModifiedDate")]
[Index("EtblEusupplementaryUnitIBranchId", Name = "idx_etblEUSupplementaryUnit_iBranchID")]
public partial class EtblEusupplementaryUnit
{
    [Key]
    [Column("IDEUSupplementaryUnit")]
    public int IdeusupplementaryUnit { get; set; }

    [Column("cEUSupplementaryUnitCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEusupplementaryUnitCode { get; set; }

    [Column("cEUSupplementaryUnitDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEusupplementaryUnitDescription { get; set; }

    [Column("_etblEUSupplementaryUnit_iBranchID")]
    public int? EtblEusupplementaryUnitIBranchId { get; set; }

    [Column("_etblEUSupplementaryUnit_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEusupplementaryUnitDCreatedDate { get; set; }

    [Column("_etblEUSupplementaryUnit_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEusupplementaryUnitDModifiedDate { get; set; }

    [Column("_etblEUSupplementaryUnit_iCreatedBranchID")]
    public int? EtblEusupplementaryUnitICreatedBranchId { get; set; }

    [Column("_etblEUSupplementaryUnit_iModifiedBranchID")]
    public int? EtblEusupplementaryUnitIModifiedBranchId { get; set; }

    [Column("_etblEUSupplementaryUnit_iCreatedAgentID")]
    public int? EtblEusupplementaryUnitICreatedAgentId { get; set; }

    [Column("_etblEUSupplementaryUnit_iModifiedAgentID")]
    public int? EtblEusupplementaryUnitIModifiedAgentId { get; set; }

    [Column("_etblEUSupplementaryUnit_iChangeSetID")]
    public int? EtblEusupplementaryUnitIChangeSetId { get; set; }

    [Column("_etblEUSupplementaryUnit_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEusupplementaryUnitChecksum { get; set; }
}
