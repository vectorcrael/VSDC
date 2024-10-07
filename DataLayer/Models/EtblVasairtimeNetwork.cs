using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVASAirtimeNetwork")]
[Index("EtblVasairtimeNetworkChecksum", Name = "idx__etblVASAirtimeNetwork__etblVASAirtimeNetwork_Checksum")]
public partial class EtblVasairtimeNetwork
{
    [Key]
    [Column("idVASAirtimeNetwork")]
    public int IdVasairtimeNetwork { get; set; }

    [Column("idVASAirtimeMaster")]
    public int IdVasairtimeMaster { get; set; }

    [Column("cNetworkCode")]
    [StringLength(20)]
    public string CNetworkCode { get; set; } = null!;

    [Column("cNetworkName")]
    [StringLength(50)]
    public string CNetworkName { get; set; } = null!;

    [Column("cNetworkDescription")]
    [StringLength(100)]
    public string CNetworkDescription { get; set; } = null!;

    [Column("iStockLink")]
    public int IStockLink { get; set; }

    [Column("dDiscountPercentage", TypeName = "decimal(18, 0)")]
    public decimal? DDiscountPercentage { get; set; }

    [Column("_etblVASAirtimeNetwork_iBranchID")]
    public int? EtblVasairtimeNetworkIBranchId { get; set; }

    [Column("_etblVASAirtimeNetwork_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeNetworkDCreatedDate { get; set; }

    [Column("_etblVASAirtimeNetwork_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeNetworkDModifiedDate { get; set; }

    [Column("_etblVASAirtimeNetwork_iCreatedBranchID")]
    public int? EtblVasairtimeNetworkICreatedBranchId { get; set; }

    [Column("_etblVASAirtimeNetwork_iModifiedBranchID")]
    public int? EtblVasairtimeNetworkIModifiedBranchId { get; set; }

    [Column("_etblVASAirtimeNetwork_iCreatedAgentID")]
    public int? EtblVasairtimeNetworkICreatedAgentId { get; set; }

    [Column("_etblVASAirtimeNetwork_iModifiedAgentID")]
    public int? EtblVasairtimeNetworkIModifiedAgentId { get; set; }

    [Column("_etblVASAirtimeNetwork_iChangeSetID")]
    public int? EtblVasairtimeNetworkIChangeSetId { get; set; }

    [Column("_etblVASAirtimeNetwork_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVasairtimeNetworkChecksum { get; set; }
}
