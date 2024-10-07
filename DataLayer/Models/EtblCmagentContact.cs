using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblCMAgentContact")]
[Index("EtblCmagentContactChecksum", Name = "idx__etblCMAgentContact__etblCMAgentContact_Checksum")]
[Index("EtblCmagentContactIChangeSetId", Name = "idx__etblCMAgentContact_iChangeSetID")]
[Index("EtblCmagentContactDModifiedDate", Name = "idx_etblCMAgentContact_dModifiedDate")]
[Index("EtblCmagentContactIBranchId", Name = "idx_etblCMAgentContact_iBranchID")]
public partial class EtblCmagentContact
{
    [Key]
    [Column("idContact")]
    public int IdContact { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cContactType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CContactType { get; set; }

    [Column("iSourceID")]
    public int? ISourceId { get; set; }

    [Column("cLastName")]
    [StringLength(255)]
    [Unicode(false)]
    public string CLastName { get; set; } = null!;

    [Column("cFirstName")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CFirstName { get; set; }

    [Column("cEmailAddress")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CEmailAddress { get; set; }

    [Column("cPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CPhone { get; set; }

    [Column("_etblCMAgentContact_iBranchID")]
    public int? EtblCmagentContactIBranchId { get; set; }

    [Column("_etblCMAgentContact_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblCmagentContactDCreatedDate { get; set; }

    [Column("_etblCMAgentContact_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblCmagentContactDModifiedDate { get; set; }

    [Column("_etblCMAgentContact_iCreatedBranchID")]
    public int? EtblCmagentContactICreatedBranchId { get; set; }

    [Column("_etblCMAgentContact_iModifiedBranchID")]
    public int? EtblCmagentContactIModifiedBranchId { get; set; }

    [Column("_etblCMAgentContact_iCreatedAgentID")]
    public int? EtblCmagentContactICreatedAgentId { get; set; }

    [Column("_etblCMAgentContact_iModifiedAgentID")]
    public int? EtblCmagentContactIModifiedAgentId { get; set; }

    [Column("_etblCMAgentContact_iChangeSetID")]
    public int? EtblCmagentContactIChangeSetId { get; set; }

    [Column("_etblCMAgentContact_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblCmagentContactChecksum { get; set; }
}
