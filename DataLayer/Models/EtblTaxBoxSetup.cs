using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxBoxSetup")]
[Index("EtblTaxBoxSetupChecksum", Name = "idx__etblTaxBoxSetup__etblTaxBoxSetup_Checksum")]
[Index("EtblTaxBoxSetupDModifiedDate", Name = "idx__etblTaxBoxSetup__etblTaxBoxSetup_dModifiedDate")]
[Index("EtblTaxBoxSetupIBranchId", Name = "idx__etblTaxBoxSetup__etblTaxBoxSetup_iBranchID")]
[Index("EtblTaxBoxSetupIChangeSetId", Name = "idx__etblTaxBoxSetup__etblTaxBoxSetup_iChangeSetID")]
public partial class EtblTaxBoxSetup
{
    [Key]
    [Column("idTaxBoxSetup")]
    public int IdTaxBoxSetup { get; set; }

    [Column("iBoxNumber")]
    public int IBoxNumber { get; set; }

    [Column("cBoxLabel")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CBoxLabel { get; set; }

    [Column("cBoxHeading")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CBoxHeading { get; set; }

    [Column("cExamples")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CExamples { get; set; }

    [Column("iValueTypeID")]
    public int? IValueTypeId { get; set; }

    [Column("iValueID")]
    public int? IValueId { get; set; }

    [Column("iRoundingID")]
    public int? IRoundingId { get; set; }

    [Column("_etblTaxBoxSetup_iBranchID")]
    public int? EtblTaxBoxSetupIBranchId { get; set; }

    [Column("_etblTaxBoxSetup_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTaxBoxSetupDCreatedDate { get; set; }

    [Column("_etblTaxBoxSetup_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTaxBoxSetupDModifiedDate { get; set; }

    [Column("_etblTaxBoxSetup_iCreatedBranchID")]
    public int? EtblTaxBoxSetupICreatedBranchId { get; set; }

    [Column("_etblTaxBoxSetup_iModifiedBranchID")]
    public int? EtblTaxBoxSetupIModifiedBranchId { get; set; }

    [Column("_etblTaxBoxSetup_iCreatedAgentID")]
    public int? EtblTaxBoxSetupICreatedAgentId { get; set; }

    [Column("_etblTaxBoxSetup_iModifiedAgentID")]
    public int? EtblTaxBoxSetupIModifiedAgentId { get; set; }

    [Column("_etblTaxBoxSetup_iChangeSetID")]
    public int? EtblTaxBoxSetupIChangeSetId { get; set; }

    [Column("_etblTaxBoxSetup_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTaxBoxSetupChecksum { get; set; }
}
