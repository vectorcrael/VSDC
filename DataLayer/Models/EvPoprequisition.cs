using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvPoprequisition
{
    [Column("idPOPRequisitions")]
    public int IdPoprequisitions { get; set; }

    [Column("cRequisitionNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRequisitionNo { get; set; }

    [Column("dRequisitionDate", TypeName = "datetime")]
    public DateTime DRequisitionDate { get; set; }

    [Column("iProjectDefaultID")]
    public int IProjectDefaultId { get; set; }

    [Column("cRequestedBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRequestedBy { get; set; }

    [Column("iIncidentTypeDefaultID")]
    public int IIncidentTypeDefaultId { get; set; }

    [Column("iStatus")]
    public int IStatus { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("_etblPOPRequisitions_iBranchID")]
    public int? EtblPoprequisitionsIBranchId { get; set; }

    [Column("_etblPOPRequisitions_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionsDCreatedDate { get; set; }

    [Column("_etblPOPRequisitions_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionsDModifiedDate { get; set; }

    [Column("_etblPOPRequisitions_iCreatedBranchID")]
    public int? EtblPoprequisitionsICreatedBranchId { get; set; }

    [Column("_etblPOPRequisitions_iModifiedBranchID")]
    public int? EtblPoprequisitionsIModifiedBranchId { get; set; }

    [Column("_etblPOPRequisitions_iCreatedAgentID")]
    public int? EtblPoprequisitionsICreatedAgentId { get; set; }

    [Column("_etblPOPRequisitions_iModifiedAgentID")]
    public int? EtblPoprequisitionsIModifiedAgentId { get; set; }

    [Column("_etblPOPRequisitions_iChangeSetID")]
    public int? EtblPoprequisitionsIChangeSetId { get; set; }

    [Column("_etblPOPRequisitions_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPoprequisitionsChecksum { get; set; }

    [Column("cSector")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSector { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? DefaultProjectCode { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? DefaultProjectDescription { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }
}
