using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPriceListName")]
[Index("EtblPriceListNameChecksum", Name = "idx__etblPriceListName__etblPriceListName_Checksum")]
[Index("EtblPriceListNameIChangeSetId", Name = "idx__etblPriceListName_iChangeSetID")]
[Index("EtblPriceListNameDModifiedDate", Name = "idx_etblPriceListName_dModifiedDate")]
[Index("EtblPriceListNameIBranchId", Name = "idx_etblPriceListName_iBranchID")]
public partial class EtblPriceListName
{
    [Key]
    [Column("IDPriceListName")]
    public int IdpriceListName { get; set; }

    [Column("cName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bDefault")]
    public bool BDefault { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("dPLNameTimeStamp", TypeName = "datetime")]
    public DateTime? DPlnameTimeStamp { get; set; }

    [Column("_etblPriceListName_iBranchID")]
    public int? EtblPriceListNameIBranchId { get; set; }

    [Column("_etblPriceListName_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPriceListNameDCreatedDate { get; set; }

    [Column("_etblPriceListName_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPriceListNameDModifiedDate { get; set; }

    [Column("_etblPriceListName_iCreatedBranchID")]
    public int? EtblPriceListNameICreatedBranchId { get; set; }

    [Column("_etblPriceListName_iModifiedBranchID")]
    public int? EtblPriceListNameIModifiedBranchId { get; set; }

    [Column("_etblPriceListName_iCreatedAgentID")]
    public int? EtblPriceListNameICreatedAgentId { get; set; }

    [Column("_etblPriceListName_iModifiedAgentID")]
    public int? EtblPriceListNameIModifiedAgentId { get; set; }

    [Column("_etblPriceListName_iChangeSetID")]
    public int? EtblPriceListNameIChangeSetId { get; set; }

    [Column("_etblPriceListName_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPriceListNameChecksum { get; set; }
}
