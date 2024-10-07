using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWhseIBTAddCosts")]
[Index("EtblWhseIbtaddCostsChecksum", Name = "idx__etblWhseIBTAddCosts__etblWhseIBTAddCosts_Checksum")]
[Index("EtblWhseIbtaddCostsIChangeSetId", Name = "idx__etblWhseIBTAddCosts_iChangeSetID")]
[Index("EtblWhseIbtaddCostsDModifiedDate", Name = "idx_etblWhseIBTAddCosts_dModifiedDate")]
[Index("EtblWhseIbtaddCostsIBranchId", Name = "idx_etblWhseIBTAddCosts_iBranchID")]
public partial class EtblWhseIbtaddCost
{
    [Key]
    [Column("IDWhseIBTAddCosts")]
    public int IdwhseIbtaddCosts { get; set; }

    [Column("iWhseIBTID")]
    public int IWhseIbtid { get; set; }

    [Column("iSupplierID")]
    public int ISupplierId { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fLineTotalExcl")]
    public double FLineTotalExcl { get; set; }

    [Column("iTaxTypeID")]
    public int ITaxTypeId { get; set; }

    [Column("fLineTaxAmount")]
    public double FLineTaxAmount { get; set; }

    [Column("iCurrencyID")]
    public int ICurrencyId { get; set; }

    [Column("fExchangeRate")]
    public double FExchangeRate { get; set; }

    [Column("fLineTotalExclForeign")]
    public double FLineTotalExclForeign { get; set; }

    [Column("_etblWhseIBTAddCosts_iBranchID")]
    public int? EtblWhseIbtaddCostsIBranchId { get; set; }

    [Column("_etblWhseIBTAddCosts_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtaddCostsDCreatedDate { get; set; }

    [Column("_etblWhseIBTAddCosts_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtaddCostsDModifiedDate { get; set; }

    [Column("_etblWhseIBTAddCosts_iCreatedBranchID")]
    public int? EtblWhseIbtaddCostsICreatedBranchId { get; set; }

    [Column("_etblWhseIBTAddCosts_iModifiedBranchID")]
    public int? EtblWhseIbtaddCostsIModifiedBranchId { get; set; }

    [Column("_etblWhseIBTAddCosts_iCreatedAgentID")]
    public int? EtblWhseIbtaddCostsICreatedAgentId { get; set; }

    [Column("_etblWhseIBTAddCosts_iModifiedAgentID")]
    public int? EtblWhseIbtaddCostsIModifiedAgentId { get; set; }

    [Column("_etblWhseIBTAddCosts_iChangeSetID")]
    public int? EtblWhseIbtaddCostsIChangeSetId { get; set; }

    [Column("_etblWhseIBTAddCosts_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseIbtaddCostsChecksum { get; set; }
}
