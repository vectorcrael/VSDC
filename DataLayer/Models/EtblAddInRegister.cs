using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAddInRegister")]
[Index("EtblAddinRegisterChecksum", Name = "idx__etblAddinRegister__etblAddinRegister_Checksum")]
[Index("EtblAddinRegisterDModifiedDate", Name = "idx__etblAddinRegister__etblAddinRegister_dModifiedDate")]
[Index("EtblAddinRegisterIBranchId", Name = "idx__etblAddinRegister__etblAddinRegister_iBranchID")]
[Index("EtblAddinRegisterIChangeSetId", Name = "idx__etblAddinRegister__etblAddinRegister_iChangeSetID")]
public partial class EtblAddInRegister
{
    [Key]
    [Column("idAddIn")]
    public int IdAddIn { get; set; }

    [Column("cAddInGuid")]
    public Guid CAddInGuid { get; set; }

    [Column("cName")]
    [StringLength(200)]
    public string CName { get; set; } = null!;

    [Column("cPublisher")]
    [StringLength(200)]
    public string CPublisher { get; set; } = null!;

    [Column("cPublisherContact")]
    [StringLength(15)]
    public string CPublisherContact { get; set; } = null!;

    [Column("cPublisherTel")]
    [StringLength(15)]
    public string CPublisherTel { get; set; } = null!;

    [Column("cPublisherHomePage")]
    [StringLength(200)]
    public string CPublisherHomePage { get; set; } = null!;

    [Column("cPublisherEmail")]
    [StringLength(200)]
    public string CPublisherEmail { get; set; } = null!;

    [Column("bAddInEnabled")]
    public bool BAddInEnabled { get; set; }

    [Column("fAddInVersion")]
    public double FAddInVersion { get; set; }

    [Column("_etblAddinRegister_iBranchID")]
    public int? EtblAddinRegisterIBranchId { get; set; }

    [Column("_etblAddinRegister_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAddinRegisterDCreatedDate { get; set; }

    [Column("_etblAddinRegister_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAddinRegisterDModifiedDate { get; set; }

    [Column("_etblAddinRegister_iCreatedBranchID")]
    public int? EtblAddinRegisterICreatedBranchId { get; set; }

    [Column("_etblAddinRegister_iModifiedBranchID")]
    public int? EtblAddinRegisterIModifiedBranchId { get; set; }

    [Column("_etblAddinRegister_iCreatedAgentID")]
    public int? EtblAddinRegisterICreatedAgentId { get; set; }

    [Column("_etblAddinRegister_iModifiedAgentID")]
    public int? EtblAddinRegisterIModifiedAgentId { get; set; }

    [Column("_etblAddinRegister_iChangeSetID")]
    public int? EtblAddinRegisterIChangeSetId { get; set; }

    [Column("_etblAddinRegister_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAddinRegisterChecksum { get; set; }
}
