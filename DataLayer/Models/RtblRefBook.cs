using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblRefBook")]
[Index("RtblRefBookChecksum", Name = "idx__rtblRefBook__rtblRefBook_Checksum")]
[Index("RtblRefBookIChangeSetId", Name = "idx__rtblRefBook_iChangeSetID")]
[Index("RtblRefBookDModifiedDate", Name = "idx_rtblRefBook_dModifiedDate")]
[Index("RtblRefBookIBranchId", Name = "idx_rtblRefBook_iBranchID")]
public partial class RtblRefBook
{
    [Key]
    [Column("idRefBook")]
    public int IdRefBook { get; set; }

    [Column("iRefBaseID")]
    public int? IRefBaseId { get; set; }

    [Column("iBookedNo")]
    public int? IBookedNo { get; set; }

    [Column("bAvailable")]
    public bool BAvailable { get; set; }

    [Column("_rtblRefBook_iBranchID")]
    public int? RtblRefBookIBranchId { get; set; }

    [Column("_rtblRefBook_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblRefBookDCreatedDate { get; set; }

    [Column("_rtblRefBook_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblRefBookDModifiedDate { get; set; }

    [Column("_rtblRefBook_iCreatedBranchID")]
    public int? RtblRefBookICreatedBranchId { get; set; }

    [Column("_rtblRefBook_iModifiedBranchID")]
    public int? RtblRefBookIModifiedBranchId { get; set; }

    [Column("_rtblRefBook_iCreatedAgentID")]
    public int? RtblRefBookICreatedAgentId { get; set; }

    [Column("_rtblRefBook_iModifiedAgentID")]
    public int? RtblRefBookIModifiedAgentId { get; set; }

    [Column("_rtblRefBook_iChangeSetID")]
    public int? RtblRefBookIChangeSetId { get; set; }

    [Column("_rtblRefBook_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblRefBookChecksum { get; set; }
}
