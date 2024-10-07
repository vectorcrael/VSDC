using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvVolumeDiscountAr
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

    [Column("_etblVDAR_iBranchID")]
    public int? EtblVdarIBranchId { get; set; }

    [Column("_etblVDAR_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVdarDCreatedDate { get; set; }

    [Column("_etblVDAR_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVdarDModifiedDate { get; set; }

    [Column("_etblVDAR_iCreatedBranchID")]
    public int? EtblVdarICreatedBranchId { get; set; }

    [Column("_etblVDAR_iModifiedBranchID")]
    public int? EtblVdarIModifiedBranchId { get; set; }

    [Column("_etblVDAR_iCreatedAgentID")]
    public int? EtblVdarICreatedAgentId { get; set; }

    [Column("_etblVDAR_iModifiedAgentID")]
    public int? EtblVdarIModifiedAgentId { get; set; }

    [Column("_etblVDAR_iChangeSetID")]
    public int? EtblVdarIChangeSetId { get; set; }

    [Column("_etblVDAR_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVdarChecksum { get; set; }

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
