using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAPShareholders")]
[Index("EtblApshareholdersChecksum", Name = "idx__etblAPShareholders__etblAPShareholders_Checksum")]
[Index("EtblApshareholdersDModifiedDate", Name = "idx__etblAPShareholders__etblAPShareholders_dModifiedDate")]
[Index("EtblApshareholdersIBranchId", Name = "idx__etblAPShareholders__etblAPShareholders_iBranchID")]
[Index("EtblApshareholdersIChangeSetId", Name = "idx__etblAPShareholders__etblAPShareholders_iChangeSetID")]
[Index("CName", Name = "idx__etblAPShareholders_cName")]
public partial class EtblApshareholder
{
    [Key]
    [Column("idAPShareholders")]
    public int IdApshareholders { get; set; }

    [Column("cName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cIDNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string CIdnumber { get; set; } = null!;

    [Column("cCitizenship")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCitizenship { get; set; }

    [Column("dCitizenshipAquired", TypeName = "datetime")]
    public DateTime? DCitizenshipAquired { get; set; }

    [Column("cRace")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CRace { get; set; }

    [Column("cGender")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CGender { get; set; }

    [Column("bDisabled")]
    public bool? BDisabled { get; set; }

    [Column("bYouth")]
    public bool? BYouth { get; set; }

    [Column("cGovernmentEmployeeNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CGovernmentEmployeeNumber { get; set; }

    [Column("cTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxNumber { get; set; }

    [Column("_etblAPShareholders_iBranchID")]
    public int? EtblApshareholdersIBranchId { get; set; }

    [Column("_etblAPShareholders_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblApshareholdersDCreatedDate { get; set; }

    [Column("_etblAPShareholders_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblApshareholdersDModifiedDate { get; set; }

    [Column("_etblAPShareholders_iCreatedBranchID")]
    public int? EtblApshareholdersICreatedBranchId { get; set; }

    [Column("_etblAPShareholders_iModifiedBranchID")]
    public int? EtblApshareholdersIModifiedBranchId { get; set; }

    [Column("_etblAPShareholders_iCreatedAgentID")]
    public int? EtblApshareholdersICreatedAgentId { get; set; }

    [Column("_etblAPShareholders_iModifiedAgentID")]
    public int? EtblApshareholdersIModifiedAgentId { get; set; }

    [Column("_etblAPShareholders_iChangeSetID")]
    public int? EtblApshareholdersIChangeSetId { get; set; }

    [Column("_etblAPShareholders_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblApshareholdersChecksum { get; set; }
}
