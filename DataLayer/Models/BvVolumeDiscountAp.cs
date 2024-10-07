using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvVolumeDiscountAp
{
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

    [Column("cARAPAccount")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CArapaccount { get; set; }

    [Column("cARAPName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CArapname { get; set; }

    [Column("cARAPGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CArapgroup { get; set; }

    [Column("cGrpDesc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CGrpDesc { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencySymbol { get; set; }
}
