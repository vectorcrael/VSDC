using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblPeopleLinks")]
[Index("RtblPeopleLinksChecksum", Name = "idx__rtblPeopleLinks__rtblPeopleLinks_Checksum")]
[Index("RtblPeopleLinksIChangeSetId", Name = "idx__rtblPeopleLinks_iChangeSetID")]
[Index("RtblPeopleLinksDModifiedDate", Name = "idx_rtblPeopleLinks_dModifiedDate")]
[Index("RtblPeopleLinksIBranchId", Name = "idx_rtblPeopleLinks_iBranchID")]
public partial class RtblPeopleLink
{
    [Key]
    [Column("idPeopleLinks")]
    public int IdPeopleLinks { get; set; }

    [Column("iPeopleID")]
    public int? IPeopleId { get; set; }

    [Column("iDebtorID")]
    public int? IDebtorId { get; set; }

    [Column("cModule")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CModule { get; set; }

    [Column("_rtblPeopleLinks_iBranchID")]
    public int? RtblPeopleLinksIBranchId { get; set; }

    [Column("_rtblPeopleLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblPeopleLinksDCreatedDate { get; set; }

    [Column("_rtblPeopleLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblPeopleLinksDModifiedDate { get; set; }

    [Column("_rtblPeopleLinks_iCreatedBranchID")]
    public int? RtblPeopleLinksICreatedBranchId { get; set; }

    [Column("_rtblPeopleLinks_iModifiedBranchID")]
    public int? RtblPeopleLinksIModifiedBranchId { get; set; }

    [Column("_rtblPeopleLinks_iCreatedAgentID")]
    public int? RtblPeopleLinksICreatedAgentId { get; set; }

    [Column("_rtblPeopleLinks_iModifiedAgentID")]
    public int? RtblPeopleLinksIModifiedAgentId { get; set; }

    [Column("_rtblPeopleLinks_iChangeSetID")]
    public int? RtblPeopleLinksIChangeSetId { get; set; }

    [Column("_rtblPeopleLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblPeopleLinksChecksum { get; set; }
}
