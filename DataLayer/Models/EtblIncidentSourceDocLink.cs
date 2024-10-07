using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblIncidentSourceDocLinks")]
[Index("EtblIncidentSourceDocLinksChecksum", Name = "idx__etblIncidentSourceDocLinks__etblIncidentSourceDocLinks_Checksum")]
[Index("EtblIncidentSourceDocLinksDModifiedDate", Name = "idx__etblIncidentSourceDocLinks__etblIncidentSourceDocLinks_dModifiedDate")]
[Index("EtblIncidentSourceDocLinksIBranchId", Name = "idx__etblIncidentSourceDocLinks__etblIncidentSourceDocLinks_iBranchID")]
[Index("EtblIncidentSourceDocLinksIChangeSetId", Name = "idx__etblIncidentSourceDocLinks__etblIncidentSourceDocLinks_iChangeSetID")]
[Index("IIncidentId", Name = "idx__etblIncidentSourceDocLinks_iIncidentID")]
[Index("ISourceDocId", Name = "idx__etblIncidentSourceDocLinks_iSourceDocID")]
public partial class EtblIncidentSourceDocLink
{
    [Key]
    [Column("idIncidentSourceDocLinks")]
    public int IdIncidentSourceDocLinks { get; set; }

    [Column("iIncidentID")]
    public int IIncidentId { get; set; }

    [Column("iSourceDocID")]
    public int ISourceDocId { get; set; }

    [Column("_etblIncidentSourceDocLinks_iBranchID")]
    public int? EtblIncidentSourceDocLinksIBranchId { get; set; }

    [Column("_etblIncidentSourceDocLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblIncidentSourceDocLinksDCreatedDate { get; set; }

    [Column("_etblIncidentSourceDocLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblIncidentSourceDocLinksDModifiedDate { get; set; }

    [Column("_etblIncidentSourceDocLinks_iCreatedBranchID")]
    public int? EtblIncidentSourceDocLinksICreatedBranchId { get; set; }

    [Column("_etblIncidentSourceDocLinks_iModifiedBranchID")]
    public int? EtblIncidentSourceDocLinksIModifiedBranchId { get; set; }

    [Column("_etblIncidentSourceDocLinks_iCreatedAgentID")]
    public int? EtblIncidentSourceDocLinksICreatedAgentId { get; set; }

    [Column("_etblIncidentSourceDocLinks_iModifiedAgentID")]
    public int? EtblIncidentSourceDocLinksIModifiedAgentId { get; set; }

    [Column("_etblIncidentSourceDocLinks_iChangeSetID")]
    public int? EtblIncidentSourceDocLinksIChangeSetId { get; set; }

    [Column("_etblIncidentSourceDocLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblIncidentSourceDocLinksChecksum { get; set; }
}
