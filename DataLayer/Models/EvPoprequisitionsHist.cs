using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvPoprequisitionsHist
{
    [Column("idPOPRequisitionsHist")]
    public int IdPoprequisitionsHist { get; set; }

    [Column("iRequisitionID")]
    public int IRequisitionId { get; set; }

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
    public int IAgentId { get; set; }

    [Column("iVersion")]
    public int IVersion { get; set; }

    [Column("_etblPOPRequisitionsHist_iBranchID")]
    public int? EtblPoprequisitionsHistIBranchId { get; set; }

    [Column("_etblPOPRequisitionsHist_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionsHistDCreatedDate { get; set; }

    [Column("_etblPOPRequisitionsHist_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPoprequisitionsHistDModifiedDate { get; set; }

    [Column("_etblPOPRequisitionsHist_iCreatedBranchID")]
    public int? EtblPoprequisitionsHistICreatedBranchId { get; set; }

    [Column("_etblPOPRequisitionsHist_iModifiedBranchID")]
    public int? EtblPoprequisitionsHistIModifiedBranchId { get; set; }

    [Column("_etblPOPRequisitionsHist_iCreatedAgentID")]
    public int? EtblPoprequisitionsHistICreatedAgentId { get; set; }

    [Column("_etblPOPRequisitionsHist_iModifiedAgentID")]
    public int? EtblPoprequisitionsHistIModifiedAgentId { get; set; }

    [Column("_etblPOPRequisitionsHist_iChangeSetID")]
    public int? EtblPoprequisitionsHistIChangeSetId { get; set; }

    [Column("_etblPOPRequisitionsHist_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPoprequisitionsHistChecksum { get; set; }

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
