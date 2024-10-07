using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTerms")]
[Index("EtblTermsChecksum", Name = "idx__etblTerms__etblTerms_Checksum")]
[Index("EtblTermsIChangeSetId", Name = "idx__etblTerms_iChangeSetID")]
[Index("EtblTermsDModifiedDate", Name = "idx_etblTerms_dModifiedDate")]
[Index("EtblTermsIBranchId", Name = "idx_etblTerms_iBranchID")]
public partial class EtblTerm
{
    [Key]
    [Column("iTermID")]
    public int ITermId { get; set; }

    [Column("iModule")]
    public int IModule { get; set; }

    [Column("cCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iTermDescOption")]
    public int? ITermDescOption { get; set; }

    [Column("cTermDesc1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc1 { get; set; }

    [Column("cTermDesc2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc2 { get; set; }

    [Column("cTermDesc3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc3 { get; set; }

    [Column("cTermDesc4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc4 { get; set; }

    [Column("cTermDesc5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc5 { get; set; }

    [Column("cTermDesc6")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc6 { get; set; }

    [Column("cTermDesc7")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTermDesc7 { get; set; }

    [Column("iAgeTypeOption")]
    public int? IAgeTypeOption { get; set; }

    [Column("iIntervalOption")]
    public int? IIntervalOption { get; set; }

    [Column("iInterval1Days")]
    public int? IInterval1Days { get; set; }

    [Column("iInterval2Days")]
    public int? IInterval2Days { get; set; }

    [Column("iInterval3Days")]
    public int? IInterval3Days { get; set; }

    [Column("iInterval4Days")]
    public int? IInterval4Days { get; set; }

    [Column("iInterval5Days")]
    public int? IInterval5Days { get; set; }

    [Column("iInterval6Days")]
    public int? IInterval6Days { get; set; }

    [Column("iInterval7Days")]
    public int? IInterval7Days { get; set; }

    [Column("dStateCloseDate1", TypeName = "datetime")]
    public DateTime? DStateCloseDate1 { get; set; }

    [Column("dStateCloseDate2", TypeName = "datetime")]
    public DateTime? DStateCloseDate2 { get; set; }

    [Column("dStateCloseDate3", TypeName = "datetime")]
    public DateTime? DStateCloseDate3 { get; set; }

    [Column("dStateCloseDate4", TypeName = "datetime")]
    public DateTime? DStateCloseDate4 { get; set; }

    [Column("dStateCloseDate5", TypeName = "datetime")]
    public DateTime? DStateCloseDate5 { get; set; }

    [Column("dStateCloseDate6", TypeName = "datetime")]
    public DateTime? DStateCloseDate6 { get; set; }

    [Column("dStateCloseDate7", TypeName = "datetime")]
    public DateTime? DStateCloseDate7 { get; set; }

    [Column("bAutoSetToPeriod")]
    public bool BAutoSetToPeriod { get; set; }

    [Column("cAge1Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge1Message1 { get; set; }

    [Column("cAge1Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge1Message2 { get; set; }

    [Column("cAge2Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge2Message1 { get; set; }

    [Column("cAge2Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge2Message2 { get; set; }

    [Column("cAge3Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge3Message1 { get; set; }

    [Column("cAge3Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge3Message2 { get; set; }

    [Column("cAge4Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge4Message1 { get; set; }

    [Column("cAge4Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge4Message2 { get; set; }

    [Column("cAge5Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge5Message1 { get; set; }

    [Column("cAge5Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge5Message2 { get; set; }

    [Column("cAge6Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge6Message1 { get; set; }

    [Column("cAge6Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge6Message2 { get; set; }

    [Column("cAge7Message1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge7Message1 { get; set; }

    [Column("cAge7Message2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAge7Message2 { get; set; }

    [Column("_etblTerms_iBranchID")]
    public int? EtblTermsIBranchId { get; set; }

    [Column("_etblTerms_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTermsDCreatedDate { get; set; }

    [Column("_etblTerms_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTermsDModifiedDate { get; set; }

    [Column("_etblTerms_iCreatedBranchID")]
    public int? EtblTermsICreatedBranchId { get; set; }

    [Column("_etblTerms_iModifiedBranchID")]
    public int? EtblTermsIModifiedBranchId { get; set; }

    [Column("_etblTerms_iCreatedAgentID")]
    public int? EtblTermsICreatedAgentId { get; set; }

    [Column("_etblTerms_iModifiedAgentID")]
    public int? EtblTermsIModifiedAgentId { get; set; }

    [Column("_etblTerms_iChangeSetID")]
    public int? EtblTermsIChangeSetId { get; set; }

    [Column("_etblTerms_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTermsChecksum { get; set; }
}
