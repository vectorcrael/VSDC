using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvSerialNumberLink
{
    [StringLength(30)]
    [Unicode(false)]
    public string? SerialNumber { get; set; }

    public int? CurrentLoc { get; set; }

    [Column("IDSerialNumberLink")]
    public int IdserialNumberLink { get; set; }

    [Column("iSerialNumberGroupID")]
    public int ISerialNumberGroupId { get; set; }

    [Column("iSerialMfID")]
    public int ISerialMfId { get; set; }

    [Column("_btblSerialNumberLink_iBranchID")]
    public int? BtblSerialNumberLinkIBranchId { get; set; }

    [Column("_btblSerialNumberLink_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblSerialNumberLinkDCreatedDate { get; set; }

    [Column("_btblSerialNumberLink_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblSerialNumberLinkDModifiedDate { get; set; }

    [Column("_btblSerialNumberLink_iCreatedBranchID")]
    public int? BtblSerialNumberLinkICreatedBranchId { get; set; }

    [Column("_btblSerialNumberLink_iModifiedBranchID")]
    public int? BtblSerialNumberLinkIModifiedBranchId { get; set; }

    [Column("_btblSerialNumberLink_iCreatedAgentID")]
    public int? BtblSerialNumberLinkICreatedAgentId { get; set; }

    [Column("_btblSerialNumberLink_iModifiedAgentID")]
    public int? BtblSerialNumberLinkIModifiedAgentId { get; set; }

    [Column("_btblSerialNumberLink_iChangeSetID")]
    public int? BtblSerialNumberLinkIChangeSetId { get; set; }

    [Column("_btblSerialNumberLink_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblSerialNumberLinkChecksum { get; set; }
}
