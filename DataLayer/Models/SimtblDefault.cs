using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("_simtblDefaults")]
public partial class SimtblDefault
{
    [Column("bGeneralLedger")]
    public bool? BGeneralLedger { get; set; }

    [Column("bJobCards")]
    public bool? BJobCards { get; set; }

    [Column("bProject")]
    public bool? BProject { get; set; }

    [Column("cStockIssue_Trans")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CStockIssueTrans { get; set; }

    [Column("cStockCredit_Trans")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CStockCreditTrans { get; set; }

    [Column("cIncidentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CIncidentType { get; set; }

    [Column("bAllowStock_requistion")]
    public bool? BAllowStockRequistion { get; set; }

    [Column("bStockAuto_Numbering")]
    public bool? BStockAutoNumbering { get; set; }

    [Column("cStockPrefix")]
    [StringLength(20)]
    public string? CStockPrefix { get; set; }

    [Column("iStock_PadtoNumber")]
    public int? IStockPadtoNumber { get; set; }

    [Column("iStockNextNumber")]
    public int? IStockNextNumber { get; set; }

    [Column("bStockUniqueNumber")]
    public bool? BStockUniqueNumber { get; set; }

    [Column("bIssueAuto_Numbering")]
    public bool? BIssueAutoNumbering { get; set; }

    [Column("cIssuePrefix")]
    [StringLength(20)]
    public string? CIssuePrefix { get; set; }

    [Column("iIssue_PadtoNumber")]
    public int? IIssuePadtoNumber { get; set; }

    [Column("iIssueNextNumber")]
    public int? IIssueNextNumber { get; set; }

    [Column("bIssueUniqueNumber")]
    public bool? BIssueUniqueNumber { get; set; }

    [Column("bTemplateAutoNumbering")]
    public bool? BTemplateAutoNumbering { get; set; }

    [Column("cTemplatePrefix")]
    [StringLength(20)]
    public string? CTemplatePrefix { get; set; }

    [Column("iTemplate_PadtoNumber")]
    public int? ITemplatePadtoNumber { get; set; }

    [Column("iTemplateNextNumber")]
    public int? ITemplateNextNumber { get; set; }

    [Column("bTemplateUniqueNumber")]
    public bool? BTemplateUniqueNumber { get; set; }

    [Column("iTrcode")]
    public int? ITrcode { get; set; }

    [Column("bUseWorkFlow")]
    public bool? BUseWorkFlow { get; set; }
}
