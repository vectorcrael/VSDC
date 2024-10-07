using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVDLnLvlAP")]
[Index("EtblVdlnLvlApChecksum", Name = "idx__etblVDLnLvlAP__etblVDLnLvlAP_Checksum")]
[Index("EtblVdlnLvlApIChangeSetId", Name = "idx__etblVDLnLvlAP_iChangeSetID")]
[Index("EtblVdlnLvlApDModifiedDate", Name = "idx_etblVDLnLvlAP_dModifiedDate")]
[Index("EtblVdlnLvlApIBranchId", Name = "idx_etblVDLnLvlAP_iBranchID")]
public partial class EtblVdlnLvlAp
{
    [Key]
    [Column("IDVDLnLvl")]
    public int IdvdlnLvl { get; set; }

    [Column("iVDLnID")]
    public int? IVdlnId { get; set; }

    [Column("iLevel")]
    public int? ILevel { get; set; }

    [Column("fQuantity")]
    public double? FQuantity { get; set; }

    [Column("fPriceDisc")]
    public double? FPriceDisc { get; set; }

    [Column("_etblVDLnLvlAP_iBranchID")]
    public int? EtblVdlnLvlApIBranchId { get; set; }

    [Column("_etblVDLnLvlAP_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnLvlApDCreatedDate { get; set; }

    [Column("_etblVDLnLvlAP_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnLvlApDModifiedDate { get; set; }

    [Column("_etblVDLnLvlAP_iCreatedBranchID")]
    public int? EtblVdlnLvlApICreatedBranchId { get; set; }

    [Column("_etblVDLnLvlAP_iModifiedBranchID")]
    public int? EtblVdlnLvlApIModifiedBranchId { get; set; }

    [Column("_etblVDLnLvlAP_iCreatedAgentID")]
    public int? EtblVdlnLvlApICreatedAgentId { get; set; }

    [Column("_etblVDLnLvlAP_iModifiedAgentID")]
    public int? EtblVdlnLvlApIModifiedAgentId { get; set; }

    [Column("_etblVDLnLvlAP_iChangeSetID")]
    public int? EtblVdlnLvlApIChangeSetId { get; set; }

    [Column("_etblVDLnLvlAP_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVdlnLvlApChecksum { get; set; }
}
