using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblMajorIndustryCodes")]
[Index("EtblMajorIndustryCodesChecksum", Name = "idx__etblMajorIndustryCodes__etblMajorIndustryCodes_Checksum")]
[Index("EtblMajorIndustryCodesDModifiedDate", Name = "idx__etblMajorIndustryCodes__etblMajorIndustryCodes_dModifiedDate")]
[Index("EtblMajorIndustryCodesIBranchId", Name = "idx__etblMajorIndustryCodes__etblMajorIndustryCodes_iBranchID")]
[Index("EtblMajorIndustryCodesIChangeSetId", Name = "idx__etblMajorIndustryCodes__etblMajorIndustryCodes_iChangeSetID")]
public partial class EtblMajorIndustryCode
{
    [Key]
    [Column("idMajorIndustryCode")]
    public int IdMajorIndustryCode { get; set; }

    [Column("cMajorIndustryCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CMajorIndustryCode { get; set; } = null!;

    [Column("cMajorIndustryDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CMajorIndustryDescription { get; set; }

    [Column("_etblMajorIndustryCodes_iBranchID")]
    public int? EtblMajorIndustryCodesIBranchId { get; set; }

    [Column("_etblMajorIndustryCodes_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblMajorIndustryCodesDCreatedDate { get; set; }

    [Column("_etblMajorIndustryCodes_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblMajorIndustryCodesDModifiedDate { get; set; }

    [Column("_etblMajorIndustryCodes_iCreatedBranchID")]
    public int? EtblMajorIndustryCodesICreatedBranchId { get; set; }

    [Column("_etblMajorIndustryCodes_iModifiedBranchID")]
    public int? EtblMajorIndustryCodesIModifiedBranchId { get; set; }

    [Column("_etblMajorIndustryCodes_iCreatedAgentID")]
    public int? EtblMajorIndustryCodesICreatedAgentId { get; set; }

    [Column("_etblMajorIndustryCodes_iModifiedAgentID")]
    public int? EtblMajorIndustryCodesIModifiedAgentId { get; set; }

    [Column("_etblMajorIndustryCodes_iChangeSetID")]
    public int? EtblMajorIndustryCodesIChangeSetId { get; set; }

    [Column("_etblMajorIndustryCodes_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblMajorIndustryCodesChecksum { get; set; }
}
