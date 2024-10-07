using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVASAirtimeMaster")]
[Index("EtblVasairtimeMasterChecksum", Name = "idx__etblVASAirtimeMaster__etblVASAirtimeMaster_Checksum")]
public partial class EtblVasairtimeMaster
{
    [Key]
    [Column("idVASAirtimeMaster")]
    public int IdVasairtimeMaster { get; set; }

    [Column("cContractCode")]
    [StringLength(20)]
    public string CContractCode { get; set; } = null!;

    [Column("cContractDescription")]
    [StringLength(100)]
    public string CContractDescription { get; set; } = null!;

    [Column("iSetupType")]
    public int ISetupType { get; set; }

    [Column("bActive")]
    public bool? BActive { get; set; }

    [Column("bDeleted")]
    public bool? BDeleted { get; set; }

    [Column("_etblVASAirtimeMaster_iBranchID")]
    public int? EtblVasairtimeMasterIBranchId { get; set; }

    [Column("_etblVASAirtimeMaster_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeMasterDCreatedDate { get; set; }

    [Column("_etblVASAirtimeMaster_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVasairtimeMasterDModifiedDate { get; set; }

    [Column("_etblVASAirtimeMaster_iCreatedBranchID")]
    public int? EtblVasairtimeMasterICreatedBranchId { get; set; }

    [Column("_etblVASAirtimeMaster_iModifiedBranchID")]
    public int? EtblVasairtimeMasterIModifiedBranchId { get; set; }

    [Column("_etblVASAirtimeMaster_iCreatedAgentID")]
    public int? EtblVasairtimeMasterICreatedAgentId { get; set; }

    [Column("_etblVASAirtimeMaster_iModifiedAgentID")]
    public int? EtblVasairtimeMasterIModifiedAgentId { get; set; }

    [Column("_etblVASAirtimeMaster_iChangeSetID")]
    public int? EtblVasairtimeMasterIChangeSetId { get; set; }

    [Column("_etblVASAirtimeMaster_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVasairtimeMasterChecksum { get; set; }
}
