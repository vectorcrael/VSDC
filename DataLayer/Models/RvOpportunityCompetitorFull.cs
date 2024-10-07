using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvOpportunityCompetitorFull
{
    [Column("cCompanyName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCompanyName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CompanyDescription { get; set; }

    [Column("cProductName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CProductName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ProductDescription { get; set; }

    [Column("idOpportunityCompetitor")]
    public int IdOpportunityCompetitor { get; set; }

    [Column("iOpportunityID")]
    public int IOpportunityId { get; set; }

    [Column("iCompetitorID")]
    public int ICompetitorId { get; set; }

    [Column("iCompetitorProductID")]
    public int ICompetitorProductId { get; set; }

    [Column("fPrice")]
    public double? FPrice { get; set; }

    [Column("bWonDeal")]
    public bool BWonDeal { get; set; }

    [Column("_rtblOpportunityCompetitor_iBranchID")]
    public int? RtblOpportunityCompetitorIBranchId { get; set; }

    [Column("_rtblOpportunityCompetitor_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityCompetitorDCreatedDate { get; set; }

    [Column("_rtblOpportunityCompetitor_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityCompetitorDModifiedDate { get; set; }

    [Column("_rtblOpportunityCompetitor_iCreatedBranchID")]
    public int? RtblOpportunityCompetitorICreatedBranchId { get; set; }

    [Column("_rtblOpportunityCompetitor_iModifiedBranchID")]
    public int? RtblOpportunityCompetitorIModifiedBranchId { get; set; }

    [Column("_rtblOpportunityCompetitor_iCreatedAgentID")]
    public int? RtblOpportunityCompetitorICreatedAgentId { get; set; }

    [Column("_rtblOpportunityCompetitor_iModifiedAgentID")]
    public int? RtblOpportunityCompetitorIModifiedAgentId { get; set; }

    [Column("_rtblOpportunityCompetitor_iChangeSetID")]
    public int? RtblOpportunityCompetitorIChangeSetId { get; set; }

    [Column("_rtblOpportunityCompetitor_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblOpportunityCompetitorChecksum { get; set; }
}
