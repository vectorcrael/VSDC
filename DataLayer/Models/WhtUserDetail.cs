using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("WHT_UserDetails")]
[Index("WhtUserDetailsChecksum", Name = "idx_WHT_UserDetails_WHT_UserDetails_Checksum")]
[Index("WhtUserDetailsDModifiedDate", Name = "idx_WHT_UserDetails_WHT_UserDetails_dModifiedDate")]
[Index("WhtUserDetailsIBranchId", Name = "idx_WHT_UserDetails_WHT_UserDetails_iBranchID")]
[Index("WhtUserDetailsIChangeSetId", Name = "idx_WHT_UserDetails_WHT_UserDetails_iChangeSetID")]
public partial class WhtUserDetail
{
    [Key]
    [Column("idUser")]
    public int IdUser { get; set; }

    [Column("cUserName")]
    [StringLength(24)]
    public string? CUserName { get; set; }

    [Column("cPassword")]
    [StringLength(100)]
    public string? CPassword { get; set; }

    [Column("bIsAdmin")]
    public bool? BIsAdmin { get; set; }

    [Column("cRole")]
    [StringLength(30)]
    public string? CRole { get; set; }

    [Column("WHT_UserDetails_iBranchID")]
    public int? WhtUserDetailsIBranchId { get; set; }

    [Column("WHT_UserDetails_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhtUserDetailsDCreatedDate { get; set; }

    [Column("WHT_UserDetails_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhtUserDetailsDModifiedDate { get; set; }

    [Column("WHT_UserDetails_iCreatedBranchID")]
    public int? WhtUserDetailsICreatedBranchId { get; set; }

    [Column("WHT_UserDetails_iModifiedBranchID")]
    public int? WhtUserDetailsIModifiedBranchId { get; set; }

    [Column("WHT_UserDetails_iCreatedAgentID")]
    public int? WhtUserDetailsICreatedAgentId { get; set; }

    [Column("WHT_UserDetails_iModifiedAgentID")]
    public int? WhtUserDetailsIModifiedAgentId { get; set; }

    [Column("WHT_UserDetails_iChangeSetID")]
    public int? WhtUserDetailsIChangeSetId { get; set; }

    [Column("WHT_UserDetails_Checksum")]
    [MaxLength(20)]
    public byte[]? WhtUserDetailsChecksum { get; set; }
}
