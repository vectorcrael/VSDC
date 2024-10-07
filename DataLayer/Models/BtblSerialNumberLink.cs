using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblSerialNumberLink")]
[Index("ISerialMfId", Name = "idxSerialNumberGroupID")]
[Index("BtblSerialNumberLinkChecksum", Name = "idx__btblSerialNumberLink__btblSerialNumberLink_Checksum")]
[Index("BtblSerialNumberLinkIChangeSetId", Name = "idx__btblSerialNumberLink_iChangeSetID")]
[Index("BtblSerialNumberLinkDModifiedDate", Name = "idx_btblSerialNumberLink_dModifiedDate")]
[Index("BtblSerialNumberLinkIBranchId", Name = "idx_btblSerialNumberLink_iBranchID")]
public partial class BtblSerialNumberLink
{
    [Key]
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
