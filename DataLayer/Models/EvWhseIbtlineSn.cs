using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvWhseIbtlineSn
{
    [Column("IDWhseIBTLineSN")]
    public int IdwhseIbtlineSn { get; set; }

    [Column("iWhseIBTID")]
    public int? IWhseIbtid { get; set; }

    [Column("iSNGroupID")]
    public int? ISngroupId { get; set; }

    [Column("iSerialMFID")]
    public int? ISerialMfid { get; set; }

    [Column("_etblWhseIBTLineSN_iBranchID")]
    public int? EtblWhseIbtlineSnIBranchId { get; set; }

    [Column("_etblWhseIBTLineSN_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtlineSnDCreatedDate { get; set; }

    [Column("_etblWhseIBTLineSN_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtlineSnDModifiedDate { get; set; }

    [Column("_etblWhseIBTLineSN_iCreatedBranchID")]
    public int? EtblWhseIbtlineSnICreatedBranchId { get; set; }

    [Column("_etblWhseIBTLineSN_iModifiedBranchID")]
    public int? EtblWhseIbtlineSnIModifiedBranchId { get; set; }

    [Column("_etblWhseIBTLineSN_iCreatedAgentID")]
    public int? EtblWhseIbtlineSnICreatedAgentId { get; set; }

    [Column("_etblWhseIBTLineSN_iModifiedAgentID")]
    public int? EtblWhseIbtlineSnIModifiedAgentId { get; set; }

    [Column("_etblWhseIBTLineSN_iChangeSetID")]
    public int? EtblWhseIbtlineSnIChangeSetId { get; set; }

    [Column("_etblWhseIBTLineSN_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseIbtlineSnChecksum { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SerialNumber { get; set; }
}
