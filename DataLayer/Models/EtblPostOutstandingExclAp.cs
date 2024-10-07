using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("_etblPostOutstandingExclAP")]
[Index("EtblPostOutstandingExclApChecksum", Name = "idx__etblPostOutstandingExclAP__etblPostOutstandingExclAP_Checksum")]
[Index("EtblPostOutstandingExclApIChangeSetId", Name = "idx__etblPostOutstandingExclAP_iChangeSetID")]
[Index("EtblPostOutstandingExclApDModifiedDate", Name = "idx_etblPostOutstandingExclAP_dModifiedDate")]
[Index("EtblPostOutstandingExclApIBranchId", Name = "idx_etblPostOutstandingExclAP_iBranchID")]
public partial class EtblPostOutstandingExclAp
{
    [Column("idPostOutstandingExcl")]
    public int IdPostOutstandingExcl { get; set; }

    [Column("iPostLnk")]
    public int IPostLnk { get; set; }

    [Column("fLnkAmount")]
    public double FLnkAmount { get; set; }

    [Column("fFCLnkAmount")]
    public double? FFclnkAmount { get; set; }

    [Column("_etblPostOutstandingExclAP_iBranchID")]
    public int? EtblPostOutstandingExclApIBranchId { get; set; }

    [Column("_etblPostOutstandingExclAP_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPostOutstandingExclApDCreatedDate { get; set; }

    [Column("_etblPostOutstandingExclAP_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPostOutstandingExclApDModifiedDate { get; set; }

    [Column("_etblPostOutstandingExclAP_iCreatedBranchID")]
    public int? EtblPostOutstandingExclApICreatedBranchId { get; set; }

    [Column("_etblPostOutstandingExclAP_iModifiedBranchID")]
    public int? EtblPostOutstandingExclApIModifiedBranchId { get; set; }

    [Column("_etblPostOutstandingExclAP_iCreatedAgentID")]
    public int? EtblPostOutstandingExclApICreatedAgentId { get; set; }

    [Column("_etblPostOutstandingExclAP_iModifiedAgentID")]
    public int? EtblPostOutstandingExclApIModifiedAgentId { get; set; }

    [Column("_etblPostOutstandingExclAP_iChangeSetID")]
    public int? EtblPostOutstandingExclApIChangeSetId { get; set; }

    [Column("_etblPostOutstandingExclAP_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPostOutstandingExclApChecksum { get; set; }
}
