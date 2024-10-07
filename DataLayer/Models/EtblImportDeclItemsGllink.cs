using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblImportDeclItemsGLLink")]
[Index("EtblImportDeclItemsGllinkChecksum", Name = "idx__etblImportDeclItemsGLLink__etblImportDeclItemsGLLink_Checksum")]
[Index("EtblImportDeclItemsGllinkDModifiedDate", Name = "idx__etblImportDeclItemsGLLink__etblImportDeclItemsGLLink_dModifiedDate")]
[Index("EtblImportDeclItemsGllinkIBranchId", Name = "idx__etblImportDeclItemsGLLink__etblImportDeclItemsGLLink_iBranchID")]
[Index("EtblImportDeclItemsGllinkIChangeSetId", Name = "idx__etblImportDeclItemsGLLink__etblImportDeclItemsGLLink_iChangeSetID")]
public partial class EtblImportDeclItemsGllink
{
    [Key]
    [Column("idImportDeclItemsGLLink")]
    public int IdImportDeclItemsGllink { get; set; }

    [Column("iImportDeclItemID")]
    public int IImportDeclItemId { get; set; }

    [Column("iAccountLinkID")]
    public int IAccountLinkId { get; set; }

    [Column("_etblImportDeclItemsGLLink_iBranchID")]
    public int? EtblImportDeclItemsGllinkIBranchId { get; set; }

    [Column("_etblImportDeclItemsGLLink_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclItemsGllinkDCreatedDate { get; set; }

    [Column("_etblImportDeclItemsGLLink_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclItemsGllinkDModifiedDate { get; set; }

    [Column("_etblImportDeclItemsGLLink_iCreatedBranchID")]
    public int? EtblImportDeclItemsGllinkICreatedBranchId { get; set; }

    [Column("_etblImportDeclItemsGLLink_iModifiedBranchID")]
    public int? EtblImportDeclItemsGllinkIModifiedBranchId { get; set; }

    [Column("_etblImportDeclItemsGLLink_iCreatedAgentID")]
    public int? EtblImportDeclItemsGllinkICreatedAgentId { get; set; }

    [Column("_etblImportDeclItemsGLLink_iModifiedAgentID")]
    public int? EtblImportDeclItemsGllinkIModifiedAgentId { get; set; }

    [Column("_etblImportDeclItemsGLLink_iChangeSetID")]
    public int? EtblImportDeclItemsGllinkIChangeSetId { get; set; }

    [Column("_etblImportDeclItemsGLLink_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblImportDeclItemsGllinkChecksum { get; set; }
}
