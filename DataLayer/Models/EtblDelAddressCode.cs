using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblDelAddressCode")]
[Index("EtblDelAddressCodeChecksum", Name = "idx__etblDelAddressCode__etblDelAddressCode_Checksum")]
[Index("EtblDelAddressCodeIChangeSetId", Name = "idx__etblDelAddressCode_iChangeSetID")]
[Index("EtblDelAddressCodeDModifiedDate", Name = "idx_etblDelAddressCode_dModifiedDate")]
[Index("EtblDelAddressCodeIBranchId", Name = "idx_etblDelAddressCode_iBranchID")]
public partial class EtblDelAddressCode
{
    [Key]
    [Column("IDDelAddressCode")]
    public int IddelAddressCode { get; set; }

    [Column("cDelAddressCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDelAddressCode { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblDelAddressCode_iBranchID")]
    public int? EtblDelAddressCodeIBranchId { get; set; }

    [Column("_etblDelAddressCode_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblDelAddressCodeDCreatedDate { get; set; }

    [Column("_etblDelAddressCode_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblDelAddressCodeDModifiedDate { get; set; }

    [Column("_etblDelAddressCode_iCreatedBranchID")]
    public int? EtblDelAddressCodeICreatedBranchId { get; set; }

    [Column("_etblDelAddressCode_iModifiedBranchID")]
    public int? EtblDelAddressCodeIModifiedBranchId { get; set; }

    [Column("_etblDelAddressCode_iCreatedAgentID")]
    public int? EtblDelAddressCodeICreatedAgentId { get; set; }

    [Column("_etblDelAddressCode_iModifiedAgentID")]
    public int? EtblDelAddressCodeIModifiedAgentId { get; set; }

    [Column("_etblDelAddressCode_iChangeSetID")]
    public int? EtblDelAddressCodeIChangeSetId { get; set; }

    [Column("_etblDelAddressCode_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblDelAddressCodeChecksum { get; set; }
}
