using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEFTReference")]
[Index("EtblEftreferenceChecksum", Name = "idx__etblEFTReference__etblEFTReference_Checksum")]
[Index("EtblEftreferenceDModifiedDate", Name = "idx__etblEFTReference__etblEFTReference_dModifiedDate")]
[Index("EtblEftreferenceIBranchId", Name = "idx__etblEFTReference__etblEFTReference_iBranchID")]
[Index("EtblEftreferenceIChangeSetId", Name = "idx__etblEFTReference__etblEFTReference_iChangeSetID")]
public partial class EtblEftreference
{
    [Key]
    [Column("idNumber")]
    public int IdNumber { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("_etblEFTReference_iBranchID")]
    public int? EtblEftreferenceIBranchId { get; set; }

    [Column("_etblEFTReference_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEftreferenceDCreatedDate { get; set; }

    [Column("_etblEFTReference_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEftreferenceDModifiedDate { get; set; }

    [Column("_etblEFTReference_iCreatedBranchID")]
    public int? EtblEftreferenceICreatedBranchId { get; set; }

    [Column("_etblEFTReference_iModifiedBranchID")]
    public int? EtblEftreferenceIModifiedBranchId { get; set; }

    [Column("_etblEFTReference_iCreatedAgentID")]
    public int? EtblEftreferenceICreatedAgentId { get; set; }

    [Column("_etblEFTReference_iModifiedAgentID")]
    public int? EtblEftreferenceIModifiedAgentId { get; set; }

    [Column("_etblEFTReference_iChangeSetID")]
    public int? EtblEftreferenceIChangeSetId { get; set; }

    [Column("_etblEFTReference_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEftreferenceChecksum { get; set; }
}
