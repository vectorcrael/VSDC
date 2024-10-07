using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retTillSecurity")]
[Index("RetTillSecurityChecksum", Name = "idx__retTillSecurity__retTillSecurity_Checksum")]
[Index("RetTillSecurityIChangeSetId", Name = "idx__retTillSecurity_iChangeSetID")]
[Index("RetTillSecurityDModifiedDate", Name = "idx_retTillSecurity_dModifiedDate")]
[Index("RetTillSecurityIBranchId", Name = "idx_retTillSecurity_iBranchID")]
public partial class RetTillSecurity
{
    [Key]
    [Column("idTillSecurity")]
    public int IdTillSecurity { get; set; }

    [Column("iSystemFunction")]
    public int ISystemFunction { get; set; }

    [Column("iPermission")]
    public int? IPermission { get; set; }

    [Column("_retTillSecurity_iBranchID")]
    public int? RetTillSecurityIBranchId { get; set; }

    [Column("_retTillSecurity_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetTillSecurityDCreatedDate { get; set; }

    [Column("_retTillSecurity_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetTillSecurityDModifiedDate { get; set; }

    [Column("_retTillSecurity_iCreatedBranchID")]
    public int? RetTillSecurityICreatedBranchId { get; set; }

    [Column("_retTillSecurity_iModifiedBranchID")]
    public int? RetTillSecurityIModifiedBranchId { get; set; }

    [Column("_retTillSecurity_iCreatedAgentID")]
    public int? RetTillSecurityICreatedAgentId { get; set; }

    [Column("_retTillSecurity_iModifiedAgentID")]
    public int? RetTillSecurityIModifiedAgentId { get; set; }

    [Column("_retTillSecurity_iChangeSetID")]
    public int? RetTillSecurityIChangeSetId { get; set; }

    [Column("_retTillSecurity_Checksum")]
    [MaxLength(20)]
    public byte[]? RetTillSecurityChecksum { get; set; }
}
