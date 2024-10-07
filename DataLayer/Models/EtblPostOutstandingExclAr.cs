using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("_etblPostOutstandingExclAR")]
[Index("EtblPostOutstandingExclArChecksum", Name = "idx__etblPostOutstandingExclAR__etblPostOutstandingExclAR_Checksum")]
[Index("EtblPostOutstandingExclArIChangeSetId", Name = "idx__etblPostOutstandingExclAR_iChangeSetID")]
[Index("EtblPostOutstandingExclArDModifiedDate", Name = "idx_etblPostOutstandingExclAR_dModifiedDate")]
[Index("EtblPostOutstandingExclArIBranchId", Name = "idx_etblPostOutstandingExclAR_iBranchID")]
public partial class EtblPostOutstandingExclAr
{
    [Column("idPostOutstandingExcl")]
    public int IdPostOutstandingExcl { get; set; }

    [Column("iPostLnk")]
    public int IPostLnk { get; set; }

    [Column("fLnkAmount")]
    public double FLnkAmount { get; set; }

    [Column("fFCLnkAmount")]
    public double? FFclnkAmount { get; set; }

    [Column("_etblPostOutstandingExclAR_iBranchID")]
    public int? EtblPostOutstandingExclArIBranchId { get; set; }

    [Column("_etblPostOutstandingExclAR_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPostOutstandingExclArDCreatedDate { get; set; }

    [Column("_etblPostOutstandingExclAR_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPostOutstandingExclArDModifiedDate { get; set; }

    [Column("_etblPostOutstandingExclAR_iCreatedBranchID")]
    public int? EtblPostOutstandingExclArICreatedBranchId { get; set; }

    [Column("_etblPostOutstandingExclAR_iModifiedBranchID")]
    public int? EtblPostOutstandingExclArIModifiedBranchId { get; set; }

    [Column("_etblPostOutstandingExclAR_iCreatedAgentID")]
    public int? EtblPostOutstandingExclArICreatedAgentId { get; set; }

    [Column("_etblPostOutstandingExclAR_iModifiedAgentID")]
    public int? EtblPostOutstandingExclArIModifiedAgentId { get; set; }

    [Column("_etblPostOutstandingExclAR_iChangeSetID")]
    public int? EtblPostOutstandingExclArIChangeSetId { get; set; }

    [Column("_etblPostOutstandingExclAR_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPostOutstandingExclArChecksum { get; set; }
}
