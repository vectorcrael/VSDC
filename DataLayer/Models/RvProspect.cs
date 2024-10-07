using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvProspect
{
    [Column("IDProspect")]
    public int Idprospect { get; set; }

    [Column("cCompanyName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCompanyName { get; set; }

    [Column("cTelephone")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CTelephone { get; set; }

    [Column("cFax")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CFax { get; set; }

    [Column("cPhysicalAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPhysicalAddress1 { get; set; }

    [Column("cPhysicalAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPhysicalAddress2 { get; set; }

    [Column("cPhysicalAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPhysicalAddress3 { get; set; }

    [Column("cPhysicalAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPhysicalAddress4 { get; set; }

    [Column("cPhysicalAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPhysicalAddress5 { get; set; }

    [Column("cPhysicalAddressPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CPhysicalAddressPc { get; set; }

    [Column("cPostalAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPostalAddress1 { get; set; }

    [Column("cPostalAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPostalAddress2 { get; set; }

    [Column("cPostalAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPostalAddress3 { get; set; }

    [Column("cPostalAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPostalAddress4 { get; set; }

    [Column("cPostalAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CPostalAddress5 { get; set; }

    [Column("cPostalAddressPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CPostalAddressPc { get; set; }

    [Column("cWebsite")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CWebsite { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("bChargeTax")]
    public bool BChargeTax { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("bPublic")]
    public bool BPublic { get; set; }

    [Column("iRepID")]
    public int IRepId { get; set; }

    [Column("_rtblProspect_iBranchID")]
    public int? RtblProspectIBranchId { get; set; }

    [Column("_rtblProspect_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblProspectDCreatedDate { get; set; }

    [Column("_rtblProspect_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblProspectDModifiedDate { get; set; }

    [Column("_rtblProspect_iCreatedBranchID")]
    public int? RtblProspectICreatedBranchId { get; set; }

    [Column("_rtblProspect_iModifiedBranchID")]
    public int? RtblProspectIModifiedBranchId { get; set; }

    [Column("_rtblProspect_iCreatedAgentID")]
    public int? RtblProspectICreatedAgentId { get; set; }

    [Column("_rtblProspect_iModifiedAgentID")]
    public int? RtblProspectIModifiedAgentId { get; set; }

    [Column("_rtblProspect_iChangeSetID")]
    public int? RtblProspectIChangeSetId { get; set; }

    [Column("_rtblProspect_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblProspectChecksum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AgentName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AgentFirstName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AgentLastName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }
}
