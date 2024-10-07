using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVASAirtimeItem")]
[Index("EtblVasairtimeItemChecksum", Name = "idx__etblVASAirtimeItem__etblVASAirtimeItem_Checksum")]
public partial class EtblVasairtimeItem
{
    [Key]
    [Column("idVASAirtimeItem")]
    public int IdVasairtimeItem { get; set; }

    [Column("idVASAirtimeMaster")]
    public int IdVasairtimeMaster { get; set; }

    [Column("iStockLink")]
    public int IStockLink { get; set; }

    [Column("dDiscountPercentage", TypeName = "decimal(18, 0)")]
    public decimal? DDiscountPercentage { get; set; }

    [Column("_etblVASAirtimeItem_iBranchID")]
    public int? EtblVasairtimeItemIBranchId { get; set; }

    [Column("_etblVASAirtimeItem_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeItemDCreatedDate { get; set; }

    [Column("_etblVASAirtimeItem_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeItemDModifiedDate { get; set; }

    [Column("_etblVASAirtimeItem_iCreatedBranchID")]
    public int? EtblVasairtimeItemICreatedBranchId { get; set; }

    [Column("_etblVASAirtimeItem_iModifiedBranchID")]
    public int? EtblVasairtimeItemIModifiedBranchId { get; set; }

    [Column("_etblVASAirtimeItem_iCreatedAgentID")]
    public int? EtblVasairtimeItemICreatedAgentId { get; set; }

    [Column("_etblVASAirtimeItem_iModifiedAgentID")]
    public int? EtblVasairtimeItemIModifiedAgentId { get; set; }

    [Column("_etblVASAirtimeItem_iChangeSetID")]
    public int? EtblVasairtimeItemIChangeSetId { get; set; }

    [Column("_etblVASAirtimeItem_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVasairtimeItemChecksum { get; set; }
}
