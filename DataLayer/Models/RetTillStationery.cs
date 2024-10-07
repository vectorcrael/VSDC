using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retTillStationery")]
[Index("RetTillStationeryChecksum", Name = "idx__retTillStationery__retTillStationery_Checksum")]
[Index("RetTillStationeryDModifiedDate", Name = "idx__retTillStationery__retTillStationery_dModifiedDate")]
[Index("RetTillStationeryIBranchId", Name = "idx__retTillStationery__retTillStationery_iBranchID")]
[Index("RetTillStationeryIChangeSetId", Name = "idx__retTillStationery__retTillStationery_iChangeSetID")]
public partial class RetTillStationery
{
    [Key]
    [Column("idTillStationery")]
    public int IdTillStationery { get; set; }

    [Column("iSloTypeID")]
    public int? ISloTypeId { get; set; }

    [Column("iSloSource")]
    public int? ISloSource { get; set; }

    [Column("iSloLayoutID")]
    public int? ISloLayoutId { get; set; }

    [Column("iPrinterPaperSize")]
    public int? IPrinterPaperSize { get; set; }

    [Column("iPrinterCopies")]
    public int? IPrinterCopies { get; set; }

    [Column("iPrinterCollate")]
    public int? IPrinterCollate { get; set; }

    [Column("iPrinterDuplex")]
    public int? IPrinterDuplex { get; set; }

    [Column("_retTillStationery_iBranchID")]
    public int? RetTillStationeryIBranchId { get; set; }

    [Column("_retTillStationery_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetTillStationeryDCreatedDate { get; set; }

    [Column("_retTillStationery_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetTillStationeryDModifiedDate { get; set; }

    [Column("_retTillStationery_iCreatedBranchID")]
    public int? RetTillStationeryICreatedBranchId { get; set; }

    [Column("_retTillStationery_iModifiedBranchID")]
    public int? RetTillStationeryIModifiedBranchId { get; set; }

    [Column("_retTillStationery_iCreatedAgentID")]
    public int? RetTillStationeryICreatedAgentId { get; set; }

    [Column("_retTillStationery_iModifiedAgentID")]
    public int? RetTillStationeryIModifiedAgentId { get; set; }

    [Column("_retTillStationery_iChangeSetID")]
    public int? RetTillStationeryIChangeSetId { get; set; }

    [Column("iEmailFormatIndex")]
    public int? IEmailFormatIndex { get; set; }

    [Column("bZip")]
    public bool? BZip { get; set; }

    [Column("cEmailDefaultSubject")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CEmailDefaultSubject { get; set; }

    [Column("cEmailDefaultBody")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CEmailDefaultBody { get; set; }

    [Column("bEmailDifferentLayout")]
    public bool? BEmailDifferentLayout { get; set; }

    [Column("iEmailLayoutIndex")]
    public int? IEmailLayoutIndex { get; set; }

    [Column("_retTillStationery_Checksum")]
    [MaxLength(20)]
    public byte[]? RetTillStationeryChecksum { get; set; }
}
