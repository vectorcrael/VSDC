using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblManufProcess")]
[Index("EtblManufProcessChecksum", Name = "idx__etblManufProcess__etblManufProcess_Checksum")]
[Index("EtblManufProcessIChangeSetId", Name = "idx__etblManufProcess_iChangeSetID")]
[Index("EtblManufProcessDModifiedDate", Name = "idx_etblManufProcess_dModifiedDate")]
[Index("EtblManufProcessIBranchId", Name = "idx_etblManufProcess_iBranchID")]
[Index("IInvNumId", Name = "idx_etblManufProcess_iInvNumID")]
public partial class EtblManufProcess
{
    [Key]
    [Column("idManufProcess")]
    public int IdManufProcess { get; set; }

    [Column("iStatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string IStatus { get; set; } = null!;

    [Column("cProcessRefNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string CProcessRefNumber { get; set; } = null!;

    [Column("cOtherRefNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COtherRefNumber { get; set; }

    [Column("iBOMMasterID")]
    public int IBommasterId { get; set; }

    [Column("cManufDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CManufDescription { get; set; }

    [Column("dCreated", TypeName = "datetime")]
    public DateTime DCreated { get; set; }

    [Column("dLastUpdated", TypeName = "datetime")]
    public DateTime DLastUpdated { get; set; }

    [Column("fManufQuantity")]
    public double? FManufQuantity { get; set; }

    [Column("fQtyManufactured")]
    public double? FQtyManufactured { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iManufWarehouseID")]
    public int? IManufWarehouseId { get; set; }

    [Column("bOverrideCompWhse")]
    public bool BOverrideCompWhse { get; set; }

    [Column("iInvoiceLineID")]
    public long IInvoiceLineId { get; set; }

    [Column("bIsLinkedToOrder")]
    public bool BIsLinkedToOrder { get; set; }

    [Column("iInvNumID")]
    public int? IInvNumId { get; set; }

    [Column("iJCMasterID")]
    public int? IJcmasterId { get; set; }

    [Column("_etblManufProcess_iBranchID")]
    public int? EtblManufProcessIBranchId { get; set; }

    [Column("_etblManufProcess_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessDCreatedDate { get; set; }

    [Column("_etblManufProcess_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessDModifiedDate { get; set; }

    [Column("_etblManufProcess_iCreatedBranchID")]
    public int? EtblManufProcessICreatedBranchId { get; set; }

    [Column("_etblManufProcess_iModifiedBranchID")]
    public int? EtblManufProcessIModifiedBranchId { get; set; }

    [Column("_etblManufProcess_iCreatedAgentID")]
    public int? EtblManufProcessICreatedAgentId { get; set; }

    [Column("_etblManufProcess_iModifiedAgentID")]
    public int? EtblManufProcessIModifiedAgentId { get; set; }

    [Column("_etblManufProcess_iChangeSetID")]
    public int? EtblManufProcessIChangeSetId { get; set; }

    [Column("dProjectedCompletionDate", TypeName = "datetime")]
    public DateTime? DProjectedCompletionDate { get; set; }

    [Column("dActualCompletionDate", TypeName = "datetime")]
    public DateTime? DActualCompletionDate { get; set; }

    [Column("_etblManufProcess_fLeadDays")]
    public double? EtblManufProcessFLeadDays { get; set; }

    [Column("_etblManufProcess_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblManufProcessChecksum { get; set; }
}
