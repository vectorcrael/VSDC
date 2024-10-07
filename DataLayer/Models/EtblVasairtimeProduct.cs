using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVASAirtimeProduct")]
[Index("EtblVasairtimeProductChecksum", Name = "idx__etblVASAirtimeProduct__etblVASAirtimeProduct_Checksum")]
public partial class EtblVasairtimeProduct
{
    [Key]
    [Column("idVASAirtimeProduct")]
    public int IdVasairtimeProduct { get; set; }

    [Column("idVASAirtimeNetwork")]
    public int IdVasairtimeNetwork { get; set; }

    [Column("cProductCode")]
    [StringLength(20)]
    public string CProductCode { get; set; } = null!;

    [Column("cProductDescription")]
    [StringLength(100)]
    public string CProductDescription { get; set; } = null!;

    [Column("dProductPrice", TypeName = "decimal(18, 0)")]
    public decimal DProductPrice { get; set; }

    [Column("iStockLink")]
    public int IStockLink { get; set; }

    [Column("dDiscountPercentage", TypeName = "decimal(18, 0)")]
    public decimal? DDiscountPercentage { get; set; }

    [Column("_etblVASAirtimeProduct_iBranchID")]
    public int? EtblVasairtimeProductIBranchId { get; set; }

    [Column("_etblVASAirtimeProduct_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeProductDCreatedDate { get; set; }

    [Column("_etblVASAirtimeProduct_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeProductDModifiedDate { get; set; }

    [Column("_etblVASAirtimeProduct_iCreatedBranchID")]
    public int? EtblVasairtimeProductICreatedBranchId { get; set; }

    [Column("_etblVASAirtimeProduct_iModifiedBranchID")]
    public int? EtblVasairtimeProductIModifiedBranchId { get; set; }

    [Column("_etblVASAirtimeProduct_iCreatedAgentID")]
    public int? EtblVasairtimeProductICreatedAgentId { get; set; }

    [Column("_etblVASAirtimeProduct_iModifiedAgentID")]
    public int? EtblVasairtimeProductIModifiedAgentId { get; set; }

    [Column("_etblVASAirtimeProduct_iChangeSetID")]
    public int? EtblVasairtimeProductIChangeSetId { get; set; }

    [Column("_etblVASAirtimeProduct_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVasairtimeProductChecksum { get; set; }
}
