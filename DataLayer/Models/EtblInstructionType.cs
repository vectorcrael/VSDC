using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInstructionTypes")]
[Index("EtblInstructionTypesChecksum", Name = "idx__etblInstructionTypes__etblInstructionTypes_Checksum")]
[Index("EtblInstructionTypesDModifiedDate", Name = "idx__etblInstructionTypes__etblInstructionTypes_dModifiedDate")]
[Index("EtblInstructionTypesIBranchId", Name = "idx__etblInstructionTypes__etblInstructionTypes_iBranchID")]
[Index("EtblInstructionTypesIChangeSetId", Name = "idx__etblInstructionTypes__etblInstructionTypes_iChangeSetID")]
public partial class EtblInstructionType
{
    [Key]
    [Column("iInstructionTypeID")]
    public int IInstructionTypeId { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cEFTSOutValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CEftsoutValue { get; set; }

    [Column("_etblInstructionTypes_iBranchID")]
    public int? EtblInstructionTypesIBranchId { get; set; }

    [Column("_etblInstructionTypes_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInstructionTypesDCreatedDate { get; set; }

    [Column("_etblInstructionTypes_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInstructionTypesDModifiedDate { get; set; }

    [Column("_etblInstructionTypes_iCreatedBranchID")]
    public int? EtblInstructionTypesICreatedBranchId { get; set; }

    [Column("_etblInstructionTypes_iModifiedBranchID")]
    public int? EtblInstructionTypesIModifiedBranchId { get; set; }

    [Column("_etblInstructionTypes_iCreatedAgentID")]
    public int? EtblInstructionTypesICreatedAgentId { get; set; }

    [Column("_etblInstructionTypes_iModifiedAgentID")]
    public int? EtblInstructionTypesIModifiedAgentId { get; set; }

    [Column("_etblInstructionTypes_iChangeSetID")]
    public int? EtblInstructionTypesIChangeSetId { get; set; }

    [Column("_etblInstructionTypes_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInstructionTypesChecksum { get; set; }
}
