using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Contact")]
[Index("ContactDModifiedDate", Name = "idxContact_dModifiedDate")]
[Index("ContactIBranchId", Name = "idxContact_iBranchID")]
[Index("ContactChecksum", Name = "idx_Contact_Contact_Checksum")]
[Index("ContactIChangeSetId", Name = "idx_Contact_iChangeSetID")]
public partial class Contact
{
    [Key]
    public int AutoIdx { get; set; }

    public int? DebtorLink { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Person { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Relationship { get; set; }

    [Column(TypeName = "text")]
    public string? TextField { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Dated { get; set; }

    public byte[]? Time { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? TypeOfCont { get; set; }

    [Column("Contact_iBranchID")]
    public int? ContactIBranchId { get; set; }

    [Column("Contact_dCreatedDate", TypeName = "datetime")]
    public DateTime? ContactDCreatedDate { get; set; }

    [Column("Contact_dModifiedDate", TypeName = "datetime")]
    public DateTime? ContactDModifiedDate { get; set; }

    [Column("Contact_iCreatedBranchID")]
    public int? ContactICreatedBranchId { get; set; }

    [Column("Contact_iModifiedBranchID")]
    public int? ContactIModifiedBranchId { get; set; }

    [Column("Contact_iCreatedAgentID")]
    public int? ContactICreatedAgentId { get; set; }

    [Column("Contact_iModifiedAgentID")]
    public int? ContactIModifiedAgentId { get; set; }

    [Column("Contact_iChangeSetID")]
    public int? ContactIChangeSetId { get; set; }

    [Column("Contact_Checksum")]
    [MaxLength(20)]
    public byte[]? ContactChecksum { get; set; }
}
