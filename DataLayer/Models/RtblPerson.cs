using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblPeople")]
[Index("RtblPeopleChecksum", Name = "idx__rtblPeople__rtblPeople_Checksum")]
[Index("RtblPeopleIChangeSetId", Name = "idx__rtblPeople_iChangeSetID")]
[Index("RtblPeopleDModifiedDate", Name = "idx_rtblPeople_dModifiedDate")]
[Index("RtblPeopleIBranchId", Name = "idx_rtblPeople_iBranchID")]
public partial class RtblPerson
{
    [Key]
    [Column("idPeople")]
    public int IdPeople { get; set; }

    [Column("cFirstName")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CFirstName { get; set; }

    [Column("cInitials")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CInitials { get; set; }

    [Column("cLastName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CLastName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [Column("cTitle")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTitle { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cTelWork")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelWork { get; set; }

    [Column("cTelFax")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelFax { get; set; }

    [Column("cTelMobile")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelMobile { get; set; }

    [Column("cTelHome")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTelHome { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("cWebPage")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWebPage { get; set; }

    [Column("cComments")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CComments { get; set; }

    [Column("cAddress")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CAddress { get; set; }

    [Column("cPostalAddress")]
    [StringLength(240)]
    [Unicode(false)]
    public string? CPostalAddress { get; set; }

    [Column("iBusDeptID")]
    public int? IBusDeptId { get; set; }

    [Column("iBusDesigID")]
    public int? IBusDesigId { get; set; }

    [Column("dBirthDate", TypeName = "smalldatetime")]
    public DateTime? DBirthDate { get; set; }

    [Column("dPeopleTimeStamp", TypeName = "datetime")]
    public DateTime? DPeopleTimeStamp { get; set; }

    [Column("_rtblPeople_iBranchID")]
    public int? RtblPeopleIBranchId { get; set; }

    [Column("_rtblPeople_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblPeopleDCreatedDate { get; set; }

    [Column("_rtblPeople_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblPeopleDModifiedDate { get; set; }

    [Column("_rtblPeople_iCreatedBranchID")]
    public int? RtblPeopleICreatedBranchId { get; set; }

    [Column("_rtblPeople_iModifiedBranchID")]
    public int? RtblPeopleIModifiedBranchId { get; set; }

    [Column("_rtblPeople_iCreatedAgentID")]
    public int? RtblPeopleICreatedAgentId { get; set; }

    [Column("_rtblPeople_iModifiedAgentID")]
    public int? RtblPeopleIModifiedAgentId { get; set; }

    [Column("_rtblPeople_iChangeSetID")]
    public int? RtblPeopleIChangeSetId { get; set; }

    [Column("_rtblPeople_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblPeopleChecksum { get; set; }
}
