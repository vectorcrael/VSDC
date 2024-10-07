using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblBusDesig")]
[Index("RtblBusDesigChecksum", Name = "idx__rtblBusDesig__rtblBusDesig_Checksum")]
[Index("RtblBusDesigIChangeSetId", Name = "idx__rtblBusDesig_iChangeSetID")]
[Index("RtblBusDesigDModifiedDate", Name = "idx_rtblBusDesig_dModifiedDate")]
[Index("RtblBusDesigIBranchId", Name = "idx_rtblBusDesig_iBranchID")]
public partial class RtblBusDesig
{
    [Key]
    [Column("idBusDesig")]
    public int IdBusDesig { get; set; }

    [Column("cBusDesig")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBusDesig { get; set; }

    [Column("_rtblBusDesig_iBranchID")]
    public int? RtblBusDesigIBranchId { get; set; }

    [Column("_rtblBusDesig_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblBusDesigDCreatedDate { get; set; }

    [Column("_rtblBusDesig_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblBusDesigDModifiedDate { get; set; }

    [Column("_rtblBusDesig_iCreatedBranchID")]
    public int? RtblBusDesigICreatedBranchId { get; set; }

    [Column("_rtblBusDesig_iModifiedBranchID")]
    public int? RtblBusDesigIModifiedBranchId { get; set; }

    [Column("_rtblBusDesig_iCreatedAgentID")]
    public int? RtblBusDesigICreatedAgentId { get; set; }

    [Column("_rtblBusDesig_iModifiedAgentID")]
    public int? RtblBusDesigIModifiedAgentId { get; set; }

    [Column("_rtblBusDesig_iChangeSetID")]
    public int? RtblBusDesigIChangeSetId { get; set; }

    [Column("_rtblBusDesig_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblBusDesigChecksum { get; set; }
}
