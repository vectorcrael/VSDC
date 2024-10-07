using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQDf")]
[Index("RfqdfChecksum", Name = "idx_RFQDF_RFQDF_Checksum")]
[Index("RfqdfDModifiedDate", Name = "idx_RFQDF_RFQDF_dModifiedDate")]
[Index("RfqdfIBranchId", Name = "idx_RFQDF_RFQDF_iBranchID")]
[Index("RfqdfIChangeSetId", Name = "idx_RFQDF_RFQDF_iChangeSetID")]
public partial class Rfqdf
{
    [Key]
    public int DefaultCounter { get; set; }

    [Column("iWIPLink")]
    public int IWiplink { get; set; }

    [Column("iMasterLink")]
    public int IMasterLink { get; set; }

    [Column("DCLink")]
    public int Dclink { get; set; }

    [Column("bSalesOrder")]
    public bool BSalesOrder { get; set; }

    [Column("bWareHouse")]
    public bool BWareHouse { get; set; }

    [Column("cSageAppPath")]
    public string? CSageAppPath { get; set; }

    [Column("bIsPrefSupplier")]
    public bool? BIsPrefSupplier { get; set; }

    [Column("IsGL")]
    public bool? IsGl { get; set; }

    public bool? IsOther { get; set; }

    [Column("iIncidentType")]
    public int? IIncidentType { get; set; }

    [Column("bVolumeContract")]
    public bool? BVolumeContract { get; set; }

    [Column("cDBVersion")]
    [StringLength(50)]
    public string? CDbversion { get; set; }

    [Column("bResZeroStock")]
    public bool? BResZeroStock { get; set; }

    [Column("bShowReportLogo")]
    public bool? BShowReportLogo { get; set; }

    [Column("iRFQAutorization")]
    public int? IRfqautorization { get; set; }

    public bool? IsQuotedPriceEditable { get; set; }

    public bool? IsCostCentreEditable { get; set; }

    public bool? IsQuantityEditable { get; set; }

    public bool? SetRejectionProcess { get; set; }

    [Column("bIsLinkedSupplier")]
    public bool BIsLinkedSupplier { get; set; }

    [Column("bIsCriteriaAside")]
    public bool BIsCriteriaAside { get; set; }

    [Column("iSupplierIncident")]
    public int? ISupplierIncident { get; set; }

    [Column("bProspectiveSupplier")]
    public bool? BProspectiveSupplier { get; set; }

    [Column("bRFQWorkflow")]
    public bool? BRfqworkflow { get; set; }

    [Column("AutoNewRFQNo")]
    public bool? AutoNewRfqno { get; set; }

    [Column("NewRFQPrefix")]
    [StringLength(20)]
    public string? NewRfqprefix { get; set; }

    [Column("NextNewRFQNo")]
    public int? NextNewRfqno { get; set; }

    [Column("NewRFQPadLength")]
    public int? NewRfqpadLength { get; set; }

    [Column("fReportingAmount")]
    public double? FReportingAmount { get; set; }

    [Column("fRestrictedSupOrdAmt")]
    public double? FRestrictedSupOrdAmt { get; set; }

    [Column("bUseInclPrices")]
    public bool? BUseInclPrices { get; set; }

    [Column("bReportToNatTreasury")]
    public bool? BReportToNatTreasury { get; set; }

    [Column("cReportingEmailID")]
    [StringLength(500)]
    public string? CReportingEmailId { get; set; }

    [Column("bForceEmailToNationalTreasury")]
    public bool? BForceEmailToNationalTreasury { get; set; }

    [Column("bBlockRestrictedSup")]
    public bool? BBlockRestrictedSup { get; set; }

    [Column("cMunicipalityName")]
    [StringLength(100)]
    public string? CMunicipalityName { get; set; }

    [Column("bBBBEE_Script")]
    public bool BBbbeeScript { get; set; }

    [Column("bRotateOnRFQ")]
    public bool BRotateOnRfq { get; set; }

    [Column("iRandomSupplier")]
    public int IRandomSupplier { get; set; }

    [Column("bForceCostCentre")]
    public bool? BForceCostCentre { get; set; }

    [Column("iSTTrCode")]
    public int ISttrCode { get; set; }

    [Column("bSupplierRotation")]
    public bool BSupplierRotation { get; set; }

    [Column("bSupplierPreference")]
    public bool BSupplierPreference { get; set; }

    [Column("cSupplierUDFs")]
    public string? CSupplierUdfs { get; set; }

    [Column("bAutomatedCriteria")]
    public bool BAutomatedCriteria { get; set; }

    [Column("IsST")]
    public bool? IsSt { get; set; }

    [Column("bForceSector")]
    public bool? BForceSector { get; set; }

    [Column("RFQDF_iBranchID")]
    public int? RfqdfIBranchId { get; set; }

    [Column("RFQDF_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqdfDCreatedDate { get; set; }

    [Column("RFQDF_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqdfDModifiedDate { get; set; }

    [Column("RFQDF_iCreatedBranchID")]
    public int? RfqdfICreatedBranchId { get; set; }

    [Column("RFQDF_iModifiedBranchID")]
    public int? RfqdfIModifiedBranchId { get; set; }

    [Column("RFQDF_iCreatedAgentID")]
    public int? RfqdfICreatedAgentId { get; set; }

    [Column("RFQDF_iModifiedAgentID")]
    public int? RfqdfIModifiedAgentId { get; set; }

    [Column("RFQDF_iChangeSetID")]
    public int? RfqdfIChangeSetId { get; set; }

    [Column("RFQDF_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqdfChecksum { get; set; }
}
