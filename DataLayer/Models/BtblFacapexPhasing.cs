using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFACapexPhasing")]
[Index("BtblFacapexPhasingChecksum", Name = "idx__btblFACapexPhasing__btblFACapexPhasing_Checksum")]
[Index("BtblFacapexPhasingIChangeSetId", Name = "idx__btblFACapexPhasing_iChangeSetID")]
[Index("BtblFacapexPhasingDModifiedDate", Name = "idx_btblFACapexPhasing_dModifiedDate")]
[Index("BtblFacapexPhasingIBranchId", Name = "idx_btblFACapexPhasing_iBranchID")]
public partial class BtblFacapexPhasing
{
    [Key]
    [Column("idCapexPhasingNo")]
    public int IdCapexPhasingNo { get; set; }

    [Column("dPhaseDate", TypeName = "smalldatetime")]
    public DateTime DPhaseDate { get; set; }

    [Column("fPhaseAmount")]
    public double FPhaseAmount { get; set; }

    [Column("iCapexBudgetNo")]
    public int ICapexBudgetNo { get; set; }

    [Column("_btblFACapexPhasing_iBranchID")]
    public int? BtblFacapexPhasingIBranchId { get; set; }

    [Column("_btblFACapexPhasing_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFacapexPhasingDCreatedDate { get; set; }

    [Column("_btblFACapexPhasing_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFacapexPhasingDModifiedDate { get; set; }

    [Column("_btblFACapexPhasing_iCreatedBranchID")]
    public int? BtblFacapexPhasingICreatedBranchId { get; set; }

    [Column("_btblFACapexPhasing_iModifiedBranchID")]
    public int? BtblFacapexPhasingIModifiedBranchId { get; set; }

    [Column("_btblFACapexPhasing_iCreatedAgentID")]
    public int? BtblFacapexPhasingICreatedAgentId { get; set; }

    [Column("_btblFACapexPhasing_iModifiedAgentID")]
    public int? BtblFacapexPhasingIModifiedAgentId { get; set; }

    [Column("_btblFACapexPhasing_iChangeSetID")]
    public int? BtblFacapexPhasingIChangeSetId { get; set; }

    [Column("_btblFACapexPhasing_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFacapexPhasingChecksum { get; set; }
}
