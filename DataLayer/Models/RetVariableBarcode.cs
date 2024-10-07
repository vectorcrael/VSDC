using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retVariableBarcode")]
[Index("RetVariableBarcodeChecksum", Name = "idx__retVariableBarcode__retVariableBarcode_Checksum")]
[Index("RetVariableBarcodeDModifiedDate", Name = "idx__retVariableBarcode__retVariableBarcode_dModifiedDate")]
[Index("RetVariableBarcodeIBranchId", Name = "idx__retVariableBarcode__retVariableBarcode_iBranchID")]
[Index("RetVariableBarcodeIChangeSetId", Name = "idx__retVariableBarcode__retVariableBarcode_iChangeSetID")]
public partial class RetVariableBarcode
{
    [Key]
    [Column("idVariableBarcode")]
    public int IdVariableBarcode { get; set; }

    [Column("cCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CCode { get; set; }

    [Column("cDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CDesc { get; set; }

    [Column("cPrefix")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CPrefix { get; set; }

    [Column("iFullLength")]
    public int? IFullLength { get; set; }

    [Column("iItemStart")]
    public int? IItemStart { get; set; }

    [Column("iItemLength")]
    public int? IItemLength { get; set; }

    [Column("iValueStart")]
    public int? IValueStart { get; set; }

    [Column("iValueLength")]
    public int? IValueLength { get; set; }

    [Column("iValueDecimals")]
    public int? IValueDecimals { get; set; }

    [Column("bValueType")]
    public bool BValueType { get; set; }

    [Column("_retVariableBarcode_iBranchID")]
    public int? RetVariableBarcodeIBranchId { get; set; }

    [Column("_retVariableBarcode_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetVariableBarcodeDCreatedDate { get; set; }

    [Column("_retVariableBarcode_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetVariableBarcodeDModifiedDate { get; set; }

    [Column("_retVariableBarcode_iCreatedBranchID")]
    public int? RetVariableBarcodeICreatedBranchId { get; set; }

    [Column("_retVariableBarcode_iModifiedBranchID")]
    public int? RetVariableBarcodeIModifiedBranchId { get; set; }

    [Column("_retVariableBarcode_iCreatedAgentID")]
    public int? RetVariableBarcodeICreatedAgentId { get; set; }

    [Column("_retVariableBarcode_iModifiedAgentID")]
    public int? RetVariableBarcodeIModifiedAgentId { get; set; }

    [Column("_retVariableBarcode_iChangeSetID")]
    public int? RetVariableBarcodeIChangeSetId { get; set; }

    [Column("_retVariableBarcode_Checksum")]
    [MaxLength(20)]
    public byte[]? RetVariableBarcodeChecksum { get; set; }
}
