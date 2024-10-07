using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblMCDefaultCriteria")]
[Index("EtblMcdefaultCriteriaChecksum", Name = "idx__etblMCDefaultCriteria__etblMCDefaultCriteria_Checksum")]
[Index("EtblMcdefaultCriteriaIChangeSetId", Name = "idx__etblMCDefaultCriteria_iChangeSetID")]
[Index("EtblMcdefaultCriteriaDModifiedDate", Name = "idx_etblMCDefaultCriteria_dModifiedDate")]
[Index("EtblMcdefaultCriteriaIBranchId", Name = "idx_etblMCDefaultCriteria_iBranchID")]
public partial class EtblMcdefaultCriterion
{
    [Key]
    [Column("idDefaultCriteria")]
    public int IdDefaultCriteria { get; set; }

    [Column("cModule")]
    [StringLength(100)]
    [Unicode(false)]
    public string CModule { get; set; } = null!;

    [Column("cMonitorValue")]
    [StringLength(200)]
    [Unicode(false)]
    public string CMonitorValue { get; set; } = null!;

    [Column("cMonitorField")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CMonitorField { get; set; }

    [Column("cMonitorFieldType")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CMonitorFieldType { get; set; }

    [Column("cOperator")]
    [StringLength(30)]
    [Unicode(false)]
    public string? COperator { get; set; }

    [Column("cResultValue")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CResultValue { get; set; }

    [Column("cFieldsForResult")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CFieldsForResult { get; set; }

    [Column("cMessageValueDesc")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CMessageValueDesc { get; set; }

    [Column("cMessageValueField")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CMessageValueField { get; set; }

    [Column("cCriteriaSQLText")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CCriteriaSqltext { get; set; }

    [Column("_etblMCDefaultCriteria_iBranchID")]
    public int? EtblMcdefaultCriteriaIBranchId { get; set; }

    [Column("_etblMCDefaultCriteria_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblMcdefaultCriteriaDCreatedDate { get; set; }

    [Column("_etblMCDefaultCriteria_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblMcdefaultCriteriaDModifiedDate { get; set; }

    [Column("_etblMCDefaultCriteria_iCreatedBranchID")]
    public int? EtblMcdefaultCriteriaICreatedBranchId { get; set; }

    [Column("_etblMCDefaultCriteria_iModifiedBranchID")]
    public int? EtblMcdefaultCriteriaIModifiedBranchId { get; set; }

    [Column("_etblMCDefaultCriteria_iCreatedAgentID")]
    public int? EtblMcdefaultCriteriaICreatedAgentId { get; set; }

    [Column("_etblMCDefaultCriteria_iModifiedAgentID")]
    public int? EtblMcdefaultCriteriaIModifiedAgentId { get; set; }

    [Column("_etblMCDefaultCriteria_iChangeSetID")]
    public int? EtblMcdefaultCriteriaIChangeSetId { get; set; }

    [Column("_etblMCDefaultCriteria_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblMcdefaultCriteriaChecksum { get; set; }
}
