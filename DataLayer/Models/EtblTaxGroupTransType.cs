using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxGroupTransType")]
[Index("EtblTaxGroupTransTypeChecksum", Name = "idx__etblTaxGroupTransType__etblTaxGroupTransType_Checksum")]
[Index("EtblTaxGroupTransTypeDModifiedDate", Name = "idx__etblTaxGroupTransType__etblTaxGroupTransType_dModifiedDate")]
[Index("EtblTaxGroupTransTypeIBranchId", Name = "idx__etblTaxGroupTransType__etblTaxGroupTransType_iBranchID")]
[Index("EtblTaxGroupTransTypeIChangeSetId", Name = "idx__etblTaxGroupTransType__etblTaxGroupTransType_iChangeSetID")]
public partial class EtblTaxGroupTransType
{
    [Key]
    [Column("idTaxGroupTransType")]
    public int IdTaxGroupTransType { get; set; }

    [Column("iTaxGroupID")]
    public int ITaxGroupId { get; set; }

    [Column("iTransTypeID")]
    public int ITransTypeId { get; set; }

    [Column("_etblTaxGroupTransType_iBranchID")]
    public int? EtblTaxGroupTransTypeIBranchId { get; set; }

    [Column("_etblTaxGroupTransType_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTaxGroupTransTypeDCreatedDate { get; set; }

    [Column("_etblTaxGroupTransType_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTaxGroupTransTypeDModifiedDate { get; set; }

    [Column("_etblTaxGroupTransType_iCreatedBranchID")]
    public int? EtblTaxGroupTransTypeICreatedBranchId { get; set; }

    [Column("_etblTaxGroupTransType_iModifiedBranchID")]
    public int? EtblTaxGroupTransTypeIModifiedBranchId { get; set; }

    [Column("_etblTaxGroupTransType_iCreatedAgentID")]
    public int? EtblTaxGroupTransTypeICreatedAgentId { get; set; }

    [Column("_etblTaxGroupTransType_iModifiedAgentID")]
    public int? EtblTaxGroupTransTypeIModifiedAgentId { get; set; }

    [Column("_etblTaxGroupTransType_iChangeSetID")]
    public int? EtblTaxGroupTransTypeIChangeSetId { get; set; }

    [Column("cModule")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CModule { get; set; }

    [Column("_etblTaxGroupTransType_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTaxGroupTransTypeChecksum { get; set; }
}
