using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVDAP")]
[Index("EtblVdapChecksum", Name = "idx__etblVDAP__etblVDAP_Checksum")]
[Index("EtblVdapIChangeSetId", Name = "idx__etblVDAP_iChangeSetID")]
[Index("EtblVdapDModifiedDate", Name = "idx_etblVDAP_dModifiedDate")]
[Index("EtblVdapIBranchId", Name = "idx_etblVDAP_iBranchID")]
public partial class EtblVdap
{
    [Key]
    [Column("IDVD")]
    public int Idvd { get; set; }

    [Column("iARAPID")]
    public int? IArapid { get; set; }

    [Column("iGroupID")]
    public int? IGroupId { get; set; }

    [Column("iCurrencyID")]
    public int ICurrencyId { get; set; }

    [Column("cContractName")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CContractName { get; set; }

    [Column("bOnHold")]
    public bool BOnHold { get; set; }

    [Column("tDescription", TypeName = "text")]
    public string? TDescription { get; set; }

    [Column("bARAPAll")]
    public bool? BArapall { get; set; }

    [Column("bIsTemplate")]
    public bool BIsTemplate { get; set; }

    [Column("_etblVDAP_iBranchID")]
    public int? EtblVdapIBranchId { get; set; }

    [Column("_etblVDAP_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVdapDCreatedDate { get; set; }

    [Column("_etblVDAP_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVdapDModifiedDate { get; set; }

    [Column("_etblVDAP_iCreatedBranchID")]
    public int? EtblVdapICreatedBranchId { get; set; }

    [Column("_etblVDAP_iModifiedBranchID")]
    public int? EtblVdapIModifiedBranchId { get; set; }

    [Column("_etblVDAP_iCreatedAgentID")]
    public int? EtblVdapICreatedAgentId { get; set; }

    [Column("_etblVDAP_iModifiedAgentID")]
    public int? EtblVdapIModifiedAgentId { get; set; }

    [Column("_etblVDAP_iChangeSetID")]
    public int? EtblVdapIChangeSetId { get; set; }

    [Column("_etblVDAP_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVdapChecksum { get; set; }
}
