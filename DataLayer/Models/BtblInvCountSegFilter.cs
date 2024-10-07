using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvCountSegFilters")]
[Index("BtblInvCountSegFiltersChecksum", Name = "idx__btblInvCountSegFilters__btblInvCountSegFilters_Checksum")]
[Index("BtblInvCountSegFiltersDModifiedDate", Name = "idx__btblInvCountSegFilters__btblInvCountSegFilters_dModifiedDate")]
[Index("BtblInvCountSegFiltersIBranchId", Name = "idx__btblInvCountSegFilters__btblInvCountSegFilters_iBranchID")]
[Index("BtblInvCountSegFiltersIChangeSetId", Name = "idx__btblInvCountSegFilters__btblInvCountSegFilters_iChangeSetID")]
public partial class BtblInvCountSegFilter
{
    [Key]
    [Column("idInvCountSegFilter")]
    public long IdInvCountSegFilter { get; set; }

    [Column("iInvCountID")]
    public int IInvCountId { get; set; }

    [Column("iSegmentLevel")]
    public int ISegmentLevel { get; set; }

    [Column("cSegGroups")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CSegGroups { get; set; }

    [Column("cSegGroupsChkListInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CSegGroupsChkListInd { get; set; }

    [Column("cSegValues")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CSegValues { get; set; }

    [Column("cSegValuesChkListInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CSegValuesChkListInd { get; set; }

    [Column("_btblInvCountSegFilters_iBranchID")]
    public int? BtblInvCountSegFiltersIBranchId { get; set; }

    [Column("_btblInvCountSegFilters_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountSegFiltersDCreatedDate { get; set; }

    [Column("_btblInvCountSegFilters_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountSegFiltersDModifiedDate { get; set; }

    [Column("_btblInvCountSegFilters_iCreatedBranchID")]
    public int? BtblInvCountSegFiltersICreatedBranchId { get; set; }

    [Column("_btblInvCountSegFilters_iModifiedBranchID")]
    public int? BtblInvCountSegFiltersIModifiedBranchId { get; set; }

    [Column("_btblInvCountSegFilters_iCreatedAgentID")]
    public int? BtblInvCountSegFiltersICreatedAgentId { get; set; }

    [Column("_btblInvCountSegFilters_iModifiedAgentID")]
    public int? BtblInvCountSegFiltersIModifiedAgentId { get; set; }

    [Column("_btblInvCountSegFilters_iChangeSetID")]
    public int? BtblInvCountSegFiltersIChangeSetId { get; set; }

    [Column("_btblInvCountSegFilters_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvCountSegFiltersChecksum { get; set; }
}
