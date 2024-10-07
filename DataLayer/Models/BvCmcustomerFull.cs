using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmcustomerFull
{
    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PhysicalAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PhysicalAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PhysicalAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PhysicalAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PhysicalAddress5 { get; set; }

    [Column("PhysicalPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PhysicalPc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Addressee { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PostalAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PostalAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PostalAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PostalAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PostalAddress5 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PostalCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliverAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliverAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliverAddress3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliverAddress4 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeliverAddress5 { get; set; }

    [Column("DeliverPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DeliverPc { get; set; }

    [Column("IncidentTypeID")]
    public int? IncidentTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IncidentType { get; set; }

    [Column("BusinessTypeID")]
    public int? BusinessTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BusinessType { get; set; }

    [Column("BusinessClassID")]
    public int? BusinessClassId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BusinessClass { get; set; }

    [Column("CountryID")]
    public int? CountryId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CountryName { get; set; }

    [Column("AgentID")]
    public int? AgentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AgentName { get; set; }

    [Column("Client_iBranchID")]
    public int? ClientIBranchId { get; set; }
}
