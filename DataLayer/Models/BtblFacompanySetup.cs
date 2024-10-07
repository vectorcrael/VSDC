using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFACompanySetup")]
[Index("BtblFacompanySetupChecksum", Name = "idx__btblFACompanySetup__btblFACompanySetup_Checksum")]
[Index("BtblFacompanySetupIChangeSetId", Name = "idx__btblFACompanySetup_iChangeSetID")]
[Index("BtblFacompanySetupDModifiedDate", Name = "idx_btblFACompanySetup_dModifiedDate")]
[Index("BtblFacompanySetupIBranchId", Name = "idx_btblFACompanySetup_iBranchID")]
public partial class BtblFacompanySetup
{
    [Key]
    [Column("iFACompanyNo")]
    public int IFacompanyNo { get; set; }

    [Column("cDebitMethod")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CDebitMethod { get; set; }

    [Column("cCapexInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CCapexInd { get; set; } = null!;

    [Column("cDecimalInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CDecimalInd { get; set; } = null!;

    [Column("dLastYearEndRun", TypeName = "smalldatetime")]
    public DateTime? DLastYearEndRun { get; set; }

    [Column("dLastImportDate", TypeName = "smalldatetime")]
    public DateTime? DLastImportDate { get; set; }

    [Column("cGLIntegrationInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CGlintegrationInd { get; set; } = null!;

    [Column("cCalcStartDateInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CCalcStartDateInd { get; set; } = null!;

    [Column("iCalcDateDayNo")]
    public int? ICalcDateDayNo { get; set; }

    [Column("iNoPeriodsInYear")]
    public int? INoPeriodsInYear { get; set; }

    [Column("bCCRequired")]
    public bool? BCcrequired { get; set; }

    [Column("bLocationRequired")]
    public bool? BLocationRequired { get; set; }

    [Column("cIntegrationMethod")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CIntegrationMethod { get; set; }

    [Column("iGLPeriodID")]
    public int? IGlperiodId { get; set; }

    [Column("iGLIntegrationOption")]
    public int? IGlintegrationOption { get; set; }

    [Column("iPastelJrTypeNo")]
    public int? IPastelJrTypeNo { get; set; }

    [Column("cPastelDataPath")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CPastelDataPath { get; set; }

    [Column("cPastelAppPath")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CPastelAppPath { get; set; }

    [Column("iJrBatchID")]
    public int? IJrBatchId { get; set; }

    [Column("cAutoYN")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAutoYn { get; set; }

    [Column("iAutoLength")]
    public int? IAutoLength { get; set; }

    [Column("iAutoAlphaLength")]
    public int? IAutoAlphaLength { get; set; }

    [Column("cUpperAccNo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CUpperAccNo { get; set; }

    [Column("iPastelTxJrTypeNo")]
    public int? IPastelTxJrTypeNo { get; set; }

    [Column("iTxJrBatchID")]
    public int? ITxJrBatchId { get; set; }

    [Column("bCreateTxJrEntries")]
    public bool BCreateTxJrEntries { get; set; }

    [Column("iPastelSDKVersionID")]
    public int? IPastelSdkversionId { get; set; }

    [Column("bTrackingAuto")]
    public bool? BTrackingAuto { get; set; }

    [Column("cTrackingNum")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTrackingNum { get; set; }

    [Column("cTrackingPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTrackingPrefix { get; set; }

    [Column("iTrackingPad")]
    public int? ITrackingPad { get; set; }

    [Column("bDepreciateByAccPeriod")]
    public bool BDepreciateByAccPeriod { get; set; }

    [Column("_btblFACompanySetup_iBranchID")]
    public int? BtblFacompanySetupIBranchId { get; set; }

    [Column("_btblFACompanySetup_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFacompanySetupDCreatedDate { get; set; }

    [Column("_btblFACompanySetup_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFacompanySetupDModifiedDate { get; set; }

    [Column("_btblFACompanySetup_iCreatedBranchID")]
    public int? BtblFacompanySetupICreatedBranchId { get; set; }

    [Column("_btblFACompanySetup_iModifiedBranchID")]
    public int? BtblFacompanySetupIModifiedBranchId { get; set; }

    [Column("_btblFACompanySetup_iCreatedAgentID")]
    public int? BtblFacompanySetupICreatedAgentId { get; set; }

    [Column("_btblFACompanySetup_iModifiedAgentID")]
    public int? BtblFacompanySetupIModifiedAgentId { get; set; }

    [Column("_btblFACompanySetup_iChangeSetID")]
    public int? BtblFacompanySetupIChangeSetId { get; set; }

    [Column("_btblFACompanySetup_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFacompanySetupChecksum { get; set; }
}
