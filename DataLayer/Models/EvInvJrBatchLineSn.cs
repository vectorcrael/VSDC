using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvInvJrBatchLineSn
{
    [Column("IDInvJrBatchLineSN")]
    public int IdinvJrBatchLineSn { get; set; }

    [Column("iInvJrBatchID")]
    public int? IInvJrBatchId { get; set; }

    [Column("iSNGroupID")]
    public int? ISngroupId { get; set; }

    [Column("iSerialMFID")]
    public int? ISerialMfid { get; set; }

    [Column("cSerialNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSerialNumber { get; set; }

    [Column("_etblInvJrBatchLineSN_iBranchID")]
    public int? EtblInvJrBatchLineSnIBranchId { get; set; }

    [Column("_etblInvJrBatchLineSN_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchLineSnDCreatedDate { get; set; }

    [Column("_etblInvJrBatchLineSN_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvJrBatchLineSnDModifiedDate { get; set; }

    [Column("_etblInvJrBatchLineSN_iCreatedBranchID")]
    public int? EtblInvJrBatchLineSnICreatedBranchId { get; set; }

    [Column("_etblInvJrBatchLineSN_iModifiedBranchID")]
    public int? EtblInvJrBatchLineSnIModifiedBranchId { get; set; }

    [Column("_etblInvJrBatchLineSN_iCreatedAgentID")]
    public int? EtblInvJrBatchLineSnICreatedAgentId { get; set; }

    [Column("_etblInvJrBatchLineSN_iModifiedAgentID")]
    public int? EtblInvJrBatchLineSnIModifiedAgentId { get; set; }

    [Column("_etblInvJrBatchLineSN_iChangeSetID")]
    public int? EtblInvJrBatchLineSnIChangeSetId { get; set; }

    [Column("_etblInvJrBatchLineSN_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvJrBatchLineSnChecksum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerialNumber { get; set; }
}
