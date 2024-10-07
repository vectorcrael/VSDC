using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblImportDeclItems")]
[Index("EtblImportDeclItemsChecksum", Name = "idx__etblImportDeclItems__etblImportDeclItems_Checksum")]
[Index("EtblImportDeclItemsDModifiedDate", Name = "idx__etblImportDeclItems__etblImportDeclItems_dModifiedDate")]
[Index("EtblImportDeclItemsIBranchId", Name = "idx__etblImportDeclItems__etblImportDeclItems_iBranchID")]
[Index("EtblImportDeclItemsIChangeSetId", Name = "idx__etblImportDeclItems__etblImportDeclItems_iChangeSetID")]
public partial class EtblImportDeclItem
{
    [Key]
    [Column("idImportDeclItems")]
    public int IdImportDeclItems { get; set; }

    [Column("cImportDeclName")]
    [StringLength(50)]
    public string CImportDeclName { get; set; } = null!;

    [Column("_etblImportDeclItems_iBranchID")]
    public int? EtblImportDeclItemsIBranchId { get; set; }

    [Column("_etblImportDeclItems_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclItemsDCreatedDate { get; set; }

    [Column("_etblImportDeclItems_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclItemsDModifiedDate { get; set; }

    [Column("_etblImportDeclItems_iCreatedBranchID")]
    public int? EtblImportDeclItemsICreatedBranchId { get; set; }

    [Column("_etblImportDeclItems_iModifiedBranchID")]
    public int? EtblImportDeclItemsIModifiedBranchId { get; set; }

    [Column("_etblImportDeclItems_iCreatedAgentID")]
    public int? EtblImportDeclItemsICreatedAgentId { get; set; }

    [Column("_etblImportDeclItems_iModifiedAgentID")]
    public int? EtblImportDeclItemsIModifiedAgentId { get; set; }

    [Column("_etblImportDeclItems_iChangeSetID")]
    public int? EtblImportDeclItemsIChangeSetId { get; set; }

    [Column("_etblImportDeclItems_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblImportDeclItemsChecksum { get; set; }
}
