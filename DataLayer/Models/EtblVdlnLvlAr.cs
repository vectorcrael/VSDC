using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVDLnLvlAR")]
[Index("EtblVdlnLvlArChecksum", Name = "idx__etblVDLnLvlAR__etblVDLnLvlAR_Checksum")]
[Index("EtblVdlnLvlArIChangeSetId", Name = "idx__etblVDLnLvlAR_iChangeSetID")]
[Index("EtblVdlnLvlArDModifiedDate", Name = "idx_etblVDLnLvlAR_dModifiedDate")]
[Index("EtblVdlnLvlArIBranchId", Name = "idx_etblVDLnLvlAR_iBranchID")]
public partial class EtblVdlnLvlAr
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

    [Column("_etblVDLnLvlAR_iBranchID")]
    public int? EtblVdlnLvlArIBranchId { get; set; }

    [Column("_etblVDLnLvlAR_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnLvlArDCreatedDate { get; set; }

    [Column("_etblVDLnLvlAR_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnLvlArDModifiedDate { get; set; }

    [Column("_etblVDLnLvlAR_iCreatedBranchID")]
    public int? EtblVdlnLvlArICreatedBranchId { get; set; }

    [Column("_etblVDLnLvlAR_iModifiedBranchID")]
    public int? EtblVdlnLvlArIModifiedBranchId { get; set; }

    [Column("_etblVDLnLvlAR_iCreatedAgentID")]
    public int? EtblVdlnLvlArICreatedAgentId { get; set; }

    [Column("_etblVDLnLvlAR_iModifiedAgentID")]
    public int? EtblVdlnLvlArIModifiedAgentId { get; set; }

    [Column("_etblVDLnLvlAR_iChangeSetID")]
    public int? EtblVdlnLvlArIChangeSetId { get; set; }

    [Column("_etblVDLnLvlAR_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVdlnLvlArChecksum { get; set; }
}
