using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblNotes")]
[Index("CNotetbltableId", Name = "idxTableID")]
[Index("BtblNotesChecksum", Name = "idx__btblNotes__btblNotes_Checksum")]
[Index("BtblNotesIChangeSetId", Name = "idx__btblNotes_iChangeSetID")]
[Index("BtblNotesDModifiedDate", Name = "idx_btblNotes_dModifiedDate")]
[Index("BtblNotesIBranchId", Name = "idx_btblNotes_iBranchID")]
public partial class BtblNote
{
    [Key]
    [Column("idNotes")]
    public int IdNotes { get; set; }

    [Column("cNOTETBLTableName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CNotetbltableName { get; set; }

    [Column("cNOTETBLTableID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CNotetbltableId { get; set; }

    [Column("dNOTETBLCreated", TypeName = "datetime")]
    public DateTime? DNotetblcreated { get; set; }

    [Column("dNOTETBLModified", TypeName = "datetime")]
    public DateTime? DNotetblmodified { get; set; }

    [Column("iNOTETBLAgentID")]
    public int? INotetblagentId { get; set; }

    [Column("nNOTETBLText", TypeName = "text")]
    public string? NNotetbltext { get; set; }

    [Column("cNOTETBLTableKeyField")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CNotetbltableKeyField { get; set; }

    [Column("_btblNotes_iBranchID")]
    public int? BtblNotesIBranchId { get; set; }

    [Column("_btblNotes_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblNotesDCreatedDate { get; set; }

    [Column("_btblNotes_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblNotesDModifiedDate { get; set; }

    [Column("_btblNotes_iCreatedBranchID")]
    public int? BtblNotesICreatedBranchId { get; set; }

    [Column("_btblNotes_iModifiedBranchID")]
    public int? BtblNotesIModifiedBranchId { get; set; }

    [Column("_btblNotes_iCreatedAgentID")]
    public int? BtblNotesICreatedAgentId { get; set; }

    [Column("_btblNotes_iModifiedAgentID")]
    public int? BtblNotesIModifiedAgentId { get; set; }

    [Column("_btblNotes_iChangeSetID")]
    public int? BtblNotesIChangeSetId { get; set; }

    [Column("_btblNotes_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblNotesChecksum { get; set; }
}
