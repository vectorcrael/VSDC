﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvUnitsOfMeasureConversion
{
    [Column("fUnitAQty")]
    public double FUnitAqty { get; set; }

    [Column("iUnitAId")]
    public int IUnitAid { get; set; }

    [Column("fUnitBQty")]
    public double FUnitBqty { get; set; }

    [Column("iUnitBId")]
    public int IUnitBid { get; set; }

    [Column("idUnits")]
    public int? IdUnits { get; set; }

    [Column("cUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CUnitCode { get; set; }

    [Column("cUnitDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CUnitDescription { get; set; }

    [Column("iUnitCategoryID")]
    public int? IUnitCategoryId { get; set; }

    [Column("_etblUnits_iBranchID")]
    public int? EtblUnitsIBranchId { get; set; }

    [Column("_etblUnits_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblUnitsDCreatedDate { get; set; }

    [Column("_etblUnits_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblUnitsDModifiedDate { get; set; }

    [Column("_etblUnits_iCreatedBranchID")]
    public int? EtblUnitsICreatedBranchId { get; set; }

    [Column("_etblUnits_iModifiedBranchID")]
    public int? EtblUnitsIModifiedBranchId { get; set; }

    [Column("_etblUnits_iCreatedAgentID")]
    public int? EtblUnitsICreatedAgentId { get; set; }

    [Column("_etblUnits_iModifiedAgentID")]
    public int? EtblUnitsIModifiedAgentId { get; set; }

    [Column("bUnitRoundUp")]
    public bool? BUnitRoundUp { get; set; }

    [Column("_etblUnits_iChangeSetID")]
    public int? EtblUnitsIChangeSetId { get; set; }

    [Column("_etblUnits_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblUnitsChecksum { get; set; }
}
