using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_Sector")]
[Index("RfqSectorChecksum", Name = "idx_RFq_sector_RFq_sector_Checksum")]
[Index("RfqSectorDModifiedDate", Name = "idx_RFq_sector_RFq_sector_dModifiedDate")]
[Index("RfqSectorIBranchId", Name = "idx_RFq_sector_RFq_sector_iBranchID")]
[Index("RfqSectorIChangeSetId", Name = "idx_RFq_sector_RFq_sector_iChangeSetID")]
public partial class RfqSector
{
    [Key]
    [Column("idSector")]
    public int IdSector { get; set; }

    [Column("cSector")]
    [StringLength(100)]
    public string? CSector { get; set; }

    [Column("cDescription")]
    [StringLength(200)]
    public string? CDescription { get; set; }

    [Column("bAddedToUDF")]
    public bool? BAddedToUdf { get; set; }

    [Column("RFq_sector_iBranchID")]
    public int? RfqSectorIBranchId { get; set; }

    [Column("RFq_sector_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqSectorDCreatedDate { get; set; }

    [Column("RFq_sector_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqSectorDModifiedDate { get; set; }

    [Column("RFq_sector_iCreatedBranchID")]
    public int? RfqSectorICreatedBranchId { get; set; }

    [Column("RFq_sector_iModifiedBranchID")]
    public int? RfqSectorIModifiedBranchId { get; set; }

    [Column("RFq_sector_iCreatedAgentID")]
    public int? RfqSectorICreatedAgentId { get; set; }

    [Column("RFq_sector_iModifiedAgentID")]
    public int? RfqSectorIModifiedAgentId { get; set; }

    [Column("RFq_sector_iChangeSetID")]
    public int? RfqSectorIChangeSetId { get; set; }

    [Column("RFq_sector_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqSectorChecksum { get; set; }
}
