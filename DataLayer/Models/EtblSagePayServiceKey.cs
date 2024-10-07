using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSagePayServiceKeys")]
[Index("EtblSagePayServiceKeysChecksum", Name = "idx__etblSagePayServiceKeys__etblSagePayServiceKeys_Checksum")]
[Index("EtblSagePayServiceKeysDModifiedDate", Name = "idx__etblSagePayServiceKeys__etblSagePayServiceKeys_dModifiedDate")]
[Index("EtblSagePayServiceKeysIBranchId", Name = "idx__etblSagePayServiceKeys__etblSagePayServiceKeys_iBranchID")]
[Index("EtblSagePayServiceKeysIChangeSetId", Name = "idx__etblSagePayServiceKeys__etblSagePayServiceKeys_iChangeSetID")]
public partial class EtblSagePayServiceKey
{
    [Key]
    [Column("idSagePayServiceKey")]
    public int IdSagePayServiceKey { get; set; }

    [Column("iServiceType")]
    public int IServiceType { get; set; }

    [Column("cServiceKeyName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CServiceKeyName { get; set; } = null!;

    [Column("cServiceDescription")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CServiceDescription { get; set; }

    [Column("cServiceKeyValue")]
    [StringLength(37)]
    [Unicode(false)]
    public string? CServiceKeyValue { get; set; }

    [Column("iConnectionTimeout")]
    public int? IConnectionTimeout { get; set; }

    [Column("iReceiveTimeout")]
    public int? IReceiveTimeout { get; set; }

    [Column("iSendTimeout")]
    public int? ISendTimeout { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }

    [Column("_etblSagePayServiceKeys_iBranchID")]
    public int? EtblSagePayServiceKeysIBranchId { get; set; }

    [Column("_etblSagePayServiceKeys_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayServiceKeysDCreatedDate { get; set; }

    [Column("_etblSagePayServiceKeys_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayServiceKeysDModifiedDate { get; set; }

    [Column("_etblSagePayServiceKeys_iCreatedBranchID")]
    public int? EtblSagePayServiceKeysICreatedBranchId { get; set; }

    [Column("_etblSagePayServiceKeys_iModifiedBranchID")]
    public int? EtblSagePayServiceKeysIModifiedBranchId { get; set; }

    [Column("_etblSagePayServiceKeys_iCreatedAgentID")]
    public int? EtblSagePayServiceKeysICreatedAgentId { get; set; }

    [Column("_etblSagePayServiceKeys_iModifiedAgentID")]
    public int? EtblSagePayServiceKeysIModifiedAgentId { get; set; }

    [Column("_etblSagePayServiceKeys_iChangeSetID")]
    public int? EtblSagePayServiceKeysIChangeSetId { get; set; }

    [Column("_etblSagePayServiceKeys_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSagePayServiceKeysChecksum { get; set; }
}
