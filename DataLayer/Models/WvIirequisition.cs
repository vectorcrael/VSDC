using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvIirequisition
{
    [Column("cRequisitionNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRequisitionNo { get; set; }

    [Column("dRequisitionDate", TypeName = "datetime")]
    public DateTime? DRequisitionDate { get; set; }

    [Column("cRequestedBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRequestedBy { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("Description_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [Column("fConfirmQty")]
    public double? FConfirmQty { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("fLineTotalCost")]
    public double? FLineTotalCost { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [Column("cIncident")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CIncident { get; set; }

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

    [Column("cStatus")]
    [StringLength(8)]
    [Unicode(false)]
    public string? CStatus { get; set; }

    [Column("idReqHeader")]
    public int IdReqHeader { get; set; }
}
