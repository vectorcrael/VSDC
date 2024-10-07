using System;
using System.Collections.Generic;
using DataLayer.Models2;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class AppDBContext : DbContext
{
    public AppDBContext(Func<object, object> value, DbContextOptions<AppDBContext> options)
    {
    }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FiscalInfo> FiscalInfos { get; set; }
    public virtual DbSet<ZraInvoice> ZraInvoices { get; set; }
    public virtual DbSet<ZraInvoiceItem> ZraInvoiceItems { get; set; }
    public virtual DbSet<PurchaseInfo> PurchaseInfos { get; set; }

    public virtual DbSet<AccPrev> AccPrevs { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AtblBulkEmailAccount> AtblBulkEmailAccounts { get; set; }

    public virtual DbSet<AtblBulkEmailFilter> AtblBulkEmailFilters { get; set; }

    public virtual DbSet<AtblBulkEmailHistory> AtblBulkEmailHistories { get; set; }

    public virtual DbSet<AtblBulkEmailHistoryDocument> AtblBulkEmailHistoryDocuments { get; set; }

    public virtual DbSet<AtblBulkEmailTemplate> AtblBulkEmailTemplates { get; set; }

    public virtual DbSet<AtblBulkEmailTemplateDatum> AtblBulkEmailTemplateData { get; set; }

    public virtual DbSet<AtblBulkEmailUdffilter> AtblBulkEmailUdffilters { get; set; }

    public virtual DbSet<AtblColumn> AtblColumns { get; set; }

    public virtual DbSet<AtblColumnLookup> AtblColumnLookups { get; set; }

    public virtual DbSet<AtblColumnLookupValue> AtblColumnLookupValues { get; set; }

    public virtual DbSet<AtblDocDefault> AtblDocDefaults { get; set; }

    public virtual DbSet<AtblDocImportDocumentTemplate> AtblDocImportDocumentTemplates { get; set; }

    public virtual DbSet<AtblDocImportDocumentTemplateTable> AtblDocImportDocumentTemplateTables { get; set; }

    public virtual DbSet<AtblDocImportDocumentType> AtblDocImportDocumentTypes { get; set; }

    public virtual DbSet<AtblDocImportFieldMapping> AtblDocImportFieldMappings { get; set; }

    public virtual DbSet<AtblEmailAccount> AtblEmailAccounts { get; set; }

    public virtual DbSet<AtblExportDefault> AtblExportDefaults { get; set; }

    public virtual DbSet<AtblExportFieldMapping> AtblExportFieldMappings { get; set; }

    public virtual DbSet<AtblExportTemplate> AtblExportTemplates { get; set; }

    public virtual DbSet<AtblTable> AtblTables { get; set; }

    public virtual DbSet<AtblTableRelationship> AtblTableRelationships { get; set; }

    public virtual DbSet<AvCustomerAging> AvCustomerAgings { get; set; }

    public virtual DbSet<AvTableTemplate> AvTableTemplates { get; set; }

    public virtual DbSet<BankMain> BankMains { get; set; }

    public virtual DbSet<BomComp> BomComps { get; set; }

    public virtual DbSet<BomDef> BomDefs { get; set; }

    public virtual DbSet<BomMast> BomMasts { get; set; }

    public virtual DbSet<BtblAge> BtblAges { get; set; }

    public virtual DbSet<BtblAgentOption> BtblAgentOptions { get; set; }

    public virtual DbSet<BtblAgentOutOffice> BtblAgentOutOffices { get; set; }

    public virtual DbSet<BtblAgentOutOfficeReason> BtblAgentOutOfficeReasons { get; set; }

    public virtual DbSet<BtblAgentSystemFunction> BtblAgentSystemFunctions { get; set; }

    public virtual DbSet<BtblAgentSystemTree> BtblAgentSystemTrees { get; set; }

    public virtual DbSet<BtblBatchCheckout> BtblBatchCheckouts { get; set; }

    public virtual DbSet<BtblBinlocation> BtblBinlocations { get; set; }

    public virtual DbSet<BtblCbBatch> BtblCbBatches { get; set; }

    public virtual DbSet<BtblCbBatchDef> BtblCbBatchDefs { get; set; }

    public virtual DbSet<BtblCbBatchLine> BtblCbBatchLines { get; set; }

    public virtual DbSet<BtblCbImportHistory> BtblCbImportHistories { get; set; }

    public virtual DbSet<BtblCbMatchRule> BtblCbMatchRules { get; set; }

    public virtual DbSet<BtblCbStatement> BtblCbStatements { get; set; }

    public virtual DbSet<BtblCbbankImportDefault> BtblCbbankImportDefaults { get; set; }

    public virtual DbSet<BtblCmevent> BtblCmevents { get; set; }

    public virtual DbSet<BtblCmeventAttendee> BtblCmeventAttendees { get; set; }

    public virtual DbSet<BtblCmincidentTypeGroup> BtblCmincidentTypeGroups { get; set; }

    public virtual DbSet<BtblCmworkflow> BtblCmworkflows { get; set; }

    public virtual DbSet<BtblCmworkflowMember> BtblCmworkflowMembers { get; set; }

    public virtual DbSet<BtblCmworkflowStatus> BtblCmworkflowStatuses { get; set; }

    public virtual DbSet<BtblFaasset> BtblFaassets { get; set; }

    public virtual DbSet<BtblFaassetBlock> BtblFaassetBlocks { get; set; }

    public virtual DbSet<BtblFaassetImage> BtblFaassetImages { get; set; }

    public virtual DbSet<BtblFaassetSerialNo> BtblFaassetSerialNos { get; set; }

    public virtual DbSet<BtblFaassetTracking> BtblFaassetTrackings { get; set; }

    public virtual DbSet<BtblFaassetTrackingLine> BtblFaassetTrackingLines { get; set; }

    public virtual DbSet<BtblFaassetType> BtblFaassetTypes { get; set; }

    public virtual DbSet<BtblFaassetUnitsOfUsage> BtblFaassetUnitsOfUsages { get; set; }

    public virtual DbSet<BtblFacapexBudget> BtblFacapexBudgets { get; set; }

    public virtual DbSet<BtblFacapexOrder> BtblFacapexOrders { get; set; }

    public virtual DbSet<BtblFacapexPhasing> BtblFacapexPhasings { get; set; }

    public virtual DbSet<BtblFacompanySetup> BtblFacompanySetups { get; set; }

    public virtual DbSet<BtblFadepreciationMethod> BtblFadepreciationMethods { get; set; }

    public virtual DbSet<BtblFadepreciationYear> BtblFadepreciationYears { get; set; }

    public virtual DbSet<BtblFafinanceMethod> BtblFafinanceMethods { get; set; }

    public virtual DbSet<BtblFaglbatch> BtblFaglbatches { get; set; }

    public virtual DbSet<BtblFaglbatchAssetValue> BtblFaglbatchAssetValues { get; set; }

    public virtual DbSet<BtblFaglbatchGlentry> BtblFaglbatchGlentries { get; set; }

    public virtual DbSet<BtblFaglperiod> BtblFaglperiods { get; set; }

    public virtual DbSet<BtblFagltotalAssetValue> BtblFagltotalAssetValues { get; set; }

    public virtual DbSet<BtblFagltotalGlentry> BtblFagltotalGlentries { get; set; }

    public virtual DbSet<BtblFalocation> BtblFalocations { get; set; }

    public virtual DbSet<BtblFamovementTransaction> BtblFamovementTransactions { get; set; }

    public virtual DbSet<BtblFaperiodClose> BtblFaperiodCloses { get; set; }

    public virtual DbSet<BtblFatxDefaultGlaccount> BtblFatxDefaultGlaccounts { get; set; }

    public virtual DbSet<BtblInvCount> BtblInvCounts { get; set; }

    public virtual DbSet<BtblInvCountLine> BtblInvCountLines { get; set; }

    public virtual DbSet<BtblInvCountLinesUom> BtblInvCountLinesUoms { get; set; }

    public virtual DbSet<BtblInvCountSegFilter> BtblInvCountSegFilters { get; set; }

    public virtual DbSet<BtblInvoiceFiscalTaxis> BtblInvoiceFiscalTaxes { get; set; }

    public virtual DbSet<BtblInvoiceGrvSplit> BtblInvoiceGrvSplits { get; set; }

    public virtual DbSet<BtblInvoiceLine> BtblInvoiceLines { get; set; }

    public virtual DbSet<BtblInvoiceLineSn> BtblInvoiceLineSns { get; set; }

    public virtual DbSet<BtblInvoiceMessage> BtblInvoiceMessages { get; set; }

    public virtual DbSet<BtblJcinvoiceLine> BtblJcinvoiceLines { get; set; }

    public virtual DbSet<BtblJcmaster> BtblJcmasters { get; set; }

    public virtual DbSet<BtblJctxLine> BtblJctxLines { get; set; }

    public virtual DbSet<BtblJobFiscalTaxis> BtblJobFiscalTaxes { get; set; }

    public virtual DbSet<BtblJrBatch> BtblJrBatches { get; set; }

    public virtual DbSet<BtblJrBatchDef> BtblJrBatchDefs { get; set; }

    public virtual DbSet<BtblJrBatchLine> BtblJrBatchLines { get; set; }

    public virtual DbSet<BtblLogDetail> BtblLogDetails { get; set; }

    public virtual DbSet<BtblLogMaster> BtblLogMasters { get; set; }

    public virtual DbSet<BtblNote> BtblNotes { get; set; }

    public virtual DbSet<BtblPostenderTx> BtblPostenderTxes { get; set; }

    public virtual DbSet<BtblPosxztable> BtblPosxztables { get; set; }

    public virtual DbSet<BtblRbfolder> BtblRbfolders { get; set; }

    public virtual DbSet<BtblRbitem> BtblRbitems { get; set; }

    public virtual DbSet<BtblRbudefField> BtblRbudefFields { get; set; }

    public virtual DbSet<BtblSerialNumberLink> BtblSerialNumberLinks { get; set; }

    public virtual DbSet<BtblState> BtblStates { get; set; }

    public virtual DbSet<BtblSystemFunction> BtblSystemFunctions { get; set; }

    public virtual DbSet<BtblSystemTree> BtblSystemTrees { get; set; }

    public virtual DbSet<BtblTmcalcSheet> BtblTmcalcSheets { get; set; }

    public virtual DbSet<BtblTmtaxBox> BtblTmtaxBoxes { get; set; }

    public virtual DbSet<BtblTmtaxPeriod> BtblTmtaxPeriods { get; set; }

    public virtual DbSet<BtblTmtaxPeriodYear> BtblTmtaxPeriodYears { get; set; }

    public virtual DbSet<BtblTmtaxTotal> BtblTmtaxTotals { get; set; }

    public virtual DbSet<BvApaccountsFull> BvApaccountsFulls { get; set; }

    public virtual DbSet<BvAptransactionsFull> BvAptransactionsFulls { get; set; }

    public virtual DbSet<BvAraccountsFull> BvAraccountsFulls { get; set; }

    public virtual DbSet<BvArauditLinkedAccRep> BvArauditLinkedAccReps { get; set; }

    public virtual DbSet<BvArtransactionsFull> BvArtransactionsFulls { get; set; }

    public virtual DbSet<BvBomcompStock> BvBomcompStocks { get; set; }

    public virtual DbSet<BvBomstock> BvBomstocks { get; set; }

    public virtual DbSet<BvCapexBudgetAndAssetForCostCentre> BvCapexBudgetAndAssetForCostCentres { get; set; }

    public virtual DbSet<BvCashbookLine> BvCashbookLines { get; set; }

    public virtual DbSet<BvCcclient> BvCcclients { get; set; }

    public virtual DbSet<BvCccustomer> BvCccustomers { get; set; }

    public virtual DbSet<BvCcmanagement> BvCcmanagements { get; set; }

    public virtual DbSet<BvCcreminder> BvCcreminders { get; set; }

    public virtual DbSet<BvCcreminderType> BvCcreminderTypes { get; set; }

    public virtual DbSet<BvCmcontractTxFull> BvCmcontractTxFulls { get; set; }

    public virtual DbSet<BvCmcontractsFull> BvCmcontractsFulls { get; set; }

    public virtual DbSet<BvCmcustomerFull> BvCmcustomerFulls { get; set; }

    public virtual DbSet<BvCmcustomerInventory> BvCmcustomerInventories { get; set; }

    public virtual DbSet<BvCmdocumentFull> BvCmdocumentFulls { get; set; }

    public virtual DbSet<BvCmeventAttendee> BvCmeventAttendees { get; set; }

    public virtual DbSet<BvCmgroupAgent> BvCmgroupAgents { get; set; }

    public virtual DbSet<BvCmitgrpMember> BvCmitgrpMembers { get; set; }

    public virtual DbSet<BvCmstockFull> BvCmstockFulls { get; set; }

    public virtual DbSet<BvCmworkflowMember> BvCmworkflowMembers { get; set; }

    public virtual DbSet<BvCurrencyRevaluation> BvCurrencyRevaluations { get; set; }

    public virtual DbSet<BvDmRowAp> BvDmRowAps { get; set; }

    public virtual DbSet<BvDmRowAr> BvDmRowArs { get; set; }

    public virtual DbSet<BvDmcolAp> BvDmcolAps { get; set; }

    public virtual DbSet<BvDmcolAr> BvDmcolArs { get; set; }

    public virtual DbSet<BvEntitiesFull> BvEntitiesFulls { get; set; }

    public virtual DbSet<BvFaactiveCostCenter> BvFaactiveCostCenters { get; set; }

    public virtual DbSet<BvFaasset> BvFaassets { get; set; }

    public virtual DbSet<BvFaassetBlock> BvFaassetBlocks { get; set; }

    public virtual DbSet<BvFaassetLookupForBlock> BvFaassetLookupForBlocks { get; set; }

    public virtual DbSet<BvFaassetRevaluation> BvFaassetRevaluations { get; set; }

    public virtual DbSet<BvFaassetTakeOn> BvFaassetTakeOns { get; set; }

    public virtual DbSet<BvFaassetTracking> BvFaassetTrackings { get; set; }

    public virtual DbSet<BvFaassetTrackingFull> BvFaassetTrackingFulls { get; set; }

    public virtual DbSet<BvFaassetTypeLookupDepr> BvFaassetTypeLookupDeprs { get; set; }

    public virtual DbSet<BvFaassetUnit> BvFaassetUnits { get; set; }

    public virtual DbSet<BvFacapexBudget> BvFacapexBudgets { get; set; }

    public virtual DbSet<BvFacapexCashFlow> BvFacapexCashFlows { get; set; }

    public virtual DbSet<BvFacapexOderBudgetLookup> BvFacapexOderBudgetLookups { get; set; }

    public virtual DbSet<BvFacapexOrder> BvFacapexOrders { get; set; }

    public virtual DbSet<BvFacapexPhasing> BvFacapexPhasings { get; set; }

    public virtual DbSet<BvFacapexSummary> BvFacapexSummaries { get; set; }

    public virtual DbSet<BvFacostCenterDepartmentLookup> BvFacostCenterDepartmentLookups { get; set; }

    public virtual DbSet<BvFacurrentAsset> BvFacurrentAssets { get; set; }

    public virtual DbSet<BvFacurrentAssetUnit> BvFacurrentAssetUnits { get; set; }

    public virtual DbSet<BvFacurrentUnsoldAsset> BvFacurrentUnsoldAssets { get; set; }

    public virtual DbSet<BvFadepreciationMethod> BvFadepreciationMethods { get; set; }

    public virtual DbSet<BvFadepreciationMethodYear> BvFadepreciationMethodYears { get; set; }

    public virtual DbSet<BvFaendDate> BvFaendDates { get; set; }

    public virtual DbSet<BvFaglbatch> BvFaglbatches { get; set; }

    public virtual DbSet<BvFaglperiod> BvFaglperiods { get; set; }

    public virtual DbSet<BvFainitialAllowancePerc> BvFainitialAllowancePercs { get; set; }

    public virtual DbSet<BvFamasterAsset> BvFamasterAssets { get; set; }

    public virtual DbSet<BvFamovement> BvFamovements { get; set; }

    public virtual DbSet<BvFamovementDate> BvFamovementDates { get; set; }

    public virtual DbSet<BvFaoverrideAsset> BvFaoverrideAssets { get; set; }

    public virtual DbSet<BvFarepAssetType> BvFarepAssetTypes { get; set; }

    public virtual DbSet<BvFarevaluedAsset> BvFarevaluedAssets { get; set; }

    public virtual DbSet<BvFatakeOnBalancesForPeriod> BvFatakeOnBalancesForPeriods { get; set; }

    public virtual DbSet<BvFatakeOnDate> BvFatakeOnDates { get; set; }

    public virtual DbSet<BvFatransferredAsset> BvFatransferredAssets { get; set; }

    public virtual DbSet<BvFaunitsUsed> BvFaunitsUseds { get; set; }

    public virtual DbSet<BvFauu> BvFauus { get; set; }

    public virtual DbSet<BvFauudate> BvFauudates { get; set; }

    public virtual DbSet<BvFiscalCopySale> BvFiscalCopySales { get; set; }

    public virtual DbSet<BvFiscalInspurDatum> BvFiscalInspurData { get; set; }

    public virtual DbSet<BvFiscalNormalSale> BvFiscalNormalSales { get; set; }

    public virtual DbSet<BvGlaccountsFinancial> BvGlaccountsFinancials { get; set; }

    public virtual DbSet<BvGlperiodsFull> BvGlperiodsFulls { get; set; }

    public virtual DbSet<BvGltransactionsFull> BvGltransactionsFulls { get; set; }

    public virtual DbSet<BvGltransactionsHistFull> BvGltransactionsHistFulls { get; set; }

    public virtual DbSet<BvInvAdditionalChargesFull> BvInvAdditionalChargesFulls { get; set; }

    public virtual DbSet<BvInvCountLine> BvInvCountLines { get; set; }

    public virtual DbSet<BvInvCountVarianceListing> BvInvCountVarianceListings { get; set; }

    public virtual DbSet<BvInvLinesFull> BvInvLinesFulls { get; set; }

    public virtual DbSet<BvInvNumApfull> BvInvNumApfulls { get; set; }

    public virtual DbSet<BvInvNumAplookupDatum> BvInvNumAplookupData { get; set; }

    public virtual DbSet<BvInvNumArap> BvInvNumAraps { get; set; }

    public virtual DbSet<BvInvNumArfull> BvInvNumArfulls { get; set; }

    public virtual DbSet<BvInvNumArlookupDatum> BvInvNumArlookupData { get; set; }

    public virtual DbSet<BvJcdocPrint> BvJcdocPrints { get; set; }

    public virtual DbSet<BvJcdocPrintPslip> BvJcdocPrintPslips { get; set; }

    public virtual DbSet<BvJcinvoiceLinesFull> BvJcinvoiceLinesFulls { get; set; }

    public virtual DbSet<BvJcmasterFull> BvJcmasterFulls { get; set; }

    public virtual DbSet<BvJctxLinesFull> BvJctxLinesFulls { get; set; }

    public virtual DbSet<BvJobNumFull> BvJobNumFulls { get; set; }

    public virtual DbSet<BvJobStockFull> BvJobStockFulls { get; set; }

    public virtual DbSet<BvJobTotal> BvJobTotals { get; set; }

    public virtual DbSet<BvKeepAsidesFull> BvKeepAsidesFulls { get; set; }

    public virtual DbSet<BvNote> BvNotes { get; set; }

    public virtual DbSet<BvPosTillsFull> BvPosTillsFulls { get; set; }

    public virtual DbSet<BvPosxztenderTxFull> BvPosxztenderTxFulls { get; set; }

    public virtual DbSet<BvPurchaseOrdersFull> BvPurchaseOrdersFulls { get; set; }

    public virtual DbSet<BvQuotesFull> BvQuotesFulls { get; set; }

    public virtual DbSet<BvQuotesLine> BvQuotesLines { get; set; }

    public virtual DbSet<BvRecurRevApfixed> BvRecurRevApfixeds { get; set; }

    public virtual DbSet<BvRecurRevApfull> BvRecurRevApfulls { get; set; }

    public virtual DbSet<BvRecurRevArfixed> BvRecurRevArfixeds { get; set; }

    public virtual DbSet<BvRecurRevArfull> BvRecurRevArfulls { get; set; }

    public virtual DbSet<BvRecurrTransFull> BvRecurrTransFulls { get; set; }

    public virtual DbSet<BvRecurrTransFullWithTx> BvRecurrTransFullWithTxes { get; set; }

    public virtual DbSet<BvRepArtransaction> BvRepArtransactions { get; set; }

    public virtual DbSet<BvRepTransactionsFull> BvRepTransactionsFulls { get; set; }

    public virtual DbSet<BvRepTransactionsPaid> BvRepTransactionsPaids { get; set; }

    public virtual DbSet<BvSalesOrdersFull> BvSalesOrdersFulls { get; set; }

    public virtual DbSet<BvSalesOrdersManufFull> BvSalesOrdersManufFulls { get; set; }

    public virtual DbSet<BvSerialMasterFull> BvSerialMasterFulls { get; set; }

    public virtual DbSet<BvSerialNumberLink> BvSerialNumberLinks { get; set; }

    public virtual DbSet<BvSerialNumbersFull> BvSerialNumbersFulls { get; set; }

    public virtual DbSet<BvStockAndWhseItem> BvStockAndWhseItems { get; set; }

    public virtual DbSet<BvStockAndWhseItemsExPl> BvStockAndWhseItemsExPls { get; set; }

    public virtual DbSet<BvStockFull> BvStockFulls { get; set; }

    public virtual DbSet<BvStockFullExPl> BvStockFullExPls { get; set; }

    public virtual DbSet<BvStockGroup> BvStockGroups { get; set; }

    public virtual DbSet<BvStockItemsAndPromotionId> BvStockItemsAndPromotionIds { get; set; }

    public virtual DbSet<BvStockWhseLotItem> BvStockWhseLotItems { get; set; }

    public virtual DbSet<BvStockWhseLotItemsExPl> BvStockWhseLotItemsExPls { get; set; }

    public virtual DbSet<BvSttransactionsFull> BvSttransactionsFulls { get; set; }

    public virtual DbSet<BvSttransactionsPivot> BvSttransactionsPivots { get; set; }

    public virtual DbSet<BvSttransactionsPivotFull> BvSttransactionsPivotFulls { get; set; }

    public virtual DbSet<BvSttransactionsPivotLinked> BvSttransactionsPivotLinkeds { get; set; }

    public virtual DbSet<BvTrCodesAp> BvTrCodesAps { get; set; }

    public virtual DbSet<BvTrCodesAr> BvTrCodesArs { get; set; }

    public virtual DbSet<BvTrCodesGl> BvTrCodesGls { get; set; }

    public virtual DbSet<BvTrCodesI> BvTrCodesIs { get; set; }

    public virtual DbSet<BvTrCodesJc> BvTrCodesJcs { get; set; }

    public virtual DbSet<BvTrCodesPo> BvTrCodesPos { get; set; }

    public virtual DbSet<BvVolumeDiscountAp> BvVolumeDiscountAps { get; set; }

    public virtual DbSet<BvVolumeDiscountAr> BvVolumeDiscountArs { get; set; }

    public virtual DbSet<BvVolumeDiscountLinesAp> BvVolumeDiscountLinesAps { get; set; }

    public virtual DbSet<BvVolumeDiscountLinesAr> BvVolumeDiscountLinesArs { get; set; }

    public virtual DbSet<BvWarehouseFull> BvWarehouseFulls { get; set; }

    public virtual DbSet<BvWarehouseStockFull> BvWarehouseStockFulls { get; set; }

    public virtual DbSet<BvWhseMst> BvWhseMsts { get; set; }

    public virtual DbSet<Ccdef> Ccdefs { get; set; }

    public virtual DbSet<Ccdetail> Ccdetails { get; set; }

    public virtual DbSet<CliClass> CliClasses { get; set; }

    public virtual DbSet<CliDef> CliDefs { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Cost> Costs { get; set; }

    public virtual DbSet<CostCntr> CostCntrs { get; set; }

    public virtual DbSet<CrDiscHd> CrDiscHds { get; set; }

    public virtual DbSet<CrDiscMx> CrDiscMxes { get; set; }

    public virtual DbSet<CredApp> CredApps { get; set; }

    public virtual DbSet<CredMnt> CredMnts { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyHist> CurrencyHists { get; set; }

    public virtual DbSet<Cwratio> Cwratios { get; set; }

    public virtual DbSet<DelTbl> DelTbls { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<DrDiscHd> DrDiscHds { get; set; }

    public virtual DbSet<DrDiscMx> DrDiscMxes { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<EtblAccBlnc> EtblAccBlncs { get; set; }

    public virtual DbSet<EtblAccPrev> EtblAccPrevs { get; set; }

    public virtual DbSet<EtblAddInRegister> EtblAddInRegisters { get; set; }

    public virtual DbSet<EtblAdditionalCharge> EtblAdditionalCharges { get; set; }

    public virtual DbSet<EtblAdditionalChargeSetting> EtblAdditionalChargeSettings { get; set; }

    public virtual DbSet<EtblAdditionalInvoiceCharge> EtblAdditionalInvoiceCharges { get; set; }

    public virtual DbSet<EtblAgentDocProfile> EtblAgentDocProfiles { get; set; }

    public virtual DbSet<EtblAgentPwdHistory> EtblAgentPwdHistories { get; set; }

    public virtual DbSet<EtblAllocTemp> EtblAllocTemps { get; set; }

    public virtual DbSet<EtblAllocsDclinkRangeTemp> EtblAllocsDclinkRangeTemps { get; set; }

    public virtual DbSet<EtblAllocsTemp> EtblAllocsTemps { get; set; }

    public virtual DbSet<EtblApshareholder> EtblApshareholders { get; set; }

    public virtual DbSet<EtblApshareholderLink> EtblApshareholderLinks { get; set; }

    public virtual DbSet<EtblArapbatch> EtblArapbatches { get; set; }

    public virtual DbSet<EtblArapbatchContraSplit> EtblArapbatchContraSplits { get; set; }

    public virtual DbSet<EtblArapbatchContraSplitHistory> EtblArapbatchContraSplitHistories { get; set; }

    public virtual DbSet<EtblArapbatchDefault> EtblArapbatchDefaults { get; set; }

    public virtual DbSet<EtblArapbatchHistory> EtblArapbatchHistories { get; set; }

    public virtual DbSet<EtblArapbatchHistoryLine> EtblArapbatchHistoryLines { get; set; }

    public virtual DbSet<EtblArapbatchLine> EtblArapbatchLines { get; set; }

    public virtual DbSet<EtblArapbatchSettDiscLine> EtblArapbatchSettDiscLines { get; set; }

    public virtual DbSet<EtblArstatement> EtblArstatements { get; set; }

    public virtual DbSet<EtblArstatementRun> EtblArstatementRuns { get; set; }

    public virtual DbSet<EtblArstatementRunOption> EtblArstatementRunOptions { get; set; }

    public virtual DbSet<EtblAuditingLog> EtblAuditingLogs { get; set; }

    public virtual DbSet<EtblAutoLevelUpdateItem> EtblAutoLevelUpdateItems { get; set; }

    public virtual DbSet<EtblAutoString> EtblAutoStrings { get; set; }

    public virtual DbSet<EtblBankDetail> EtblBankDetails { get; set; }

    public virtual DbSet<EtblBatchPermission> EtblBatchPermissions { get; set; }

    public virtual DbSet<EtblBranch> EtblBranches { get; set; }

    public virtual DbSet<EtblBudget> EtblBudgets { get; set; }

    public virtual DbSet<EtblBudgetsPrev> EtblBudgetsPrevs { get; set; }

    public virtual DbSet<EtblCmagentContact> EtblCmagentContacts { get; set; }

    public virtual DbSet<EtblCmrejectReason> EtblCmrejectReasons { get; set; }

    public virtual DbSet<EtblDashboardLayout> EtblDashboardLayouts { get; set; }

    public virtual DbSet<EtblDelAddress> EtblDelAddresses { get; set; }

    public virtual DbSet<EtblDelAddressCode> EtblDelAddressCodes { get; set; }

    public virtual DbSet<EtblDeleted> EtblDeleteds { get; set; }

    public virtual DbSet<EtblDocCat> EtblDocCats { get; set; }

    public virtual DbSet<EtblDocCatGroup> EtblDocCatGroups { get; set; }

    public virtual DbSet<EtblDocProfile> EtblDocProfiles { get; set; }

    public virtual DbSet<EtblEftgatewayType> EtblEftgatewayTypes { get; set; }

    public virtual DbSet<EtblEftreference> EtblEftreferences { get; set; }

    public virtual DbSet<EtblEftsfileLayout> EtblEftsfileLayouts { get; set; }

    public virtual DbSet<EtblEftsfileLayoutDetail> EtblEftsfileLayoutDetails { get; set; }

    public virtual DbSet<EtblEucommodity> EtblEucommodities { get; set; }

    public virtual DbSet<EtblEucountry> EtblEucountries { get; set; }

    public virtual DbSet<EtblEunoTc> EtblEunoTcs { get; set; }

    public virtual DbSet<EtblEusupplementaryUnit> EtblEusupplementaryUnits { get; set; }

    public virtual DbSet<EtblFiscalDatum> EtblFiscalData { get; set; }

    public virtual DbSet<EtblFiscalPrinter> EtblFiscalPrinters { get; set; }

    public virtual DbSet<EtblFiscalPrinterModel> EtblFiscalPrinterModels { get; set; }

    public virtual DbSet<EtblGlaccountType> EtblGlaccountTypes { get; set; }

    public virtual DbSet<EtblGlloanAccountLink> EtblGlloanAccountLinks { get; set; }

    public virtual DbSet<EtblGlmScoaaccount> EtblGlmScoaaccounts { get; set; }

    public virtual DbSet<EtblGlmScoaglaccVerLink> EtblGlmScoaglaccVerLinks { get; set; }

    public virtual DbSet<EtblGlmScoaversion> EtblGlmScoaversions { get; set; }

    public virtual DbSet<EtblGlreportCategory> EtblGlreportCategories { get; set; }

    public virtual DbSet<EtblGlreviseBudget> EtblGlreviseBudgets { get; set; }

    public virtual DbSet<EtblGlreviseBudgetPrev> EtblGlreviseBudgetPrevs { get; set; }

    public virtual DbSet<EtblGlsegment> EtblGlsegments { get; set; }

    public virtual DbSet<EtblGlsegmentSetup> EtblGlsegmentSetups { get; set; }

    public virtual DbSet<EtblGstprepayment> EtblGstprepayments { get; set; }

    public virtual DbSet<EtblImportDeclItem> EtblImportDeclItems { get; set; }

    public virtual DbSet<EtblImportDeclItemsGllink> EtblImportDeclItemsGllinks { get; set; }

    public virtual DbSet<EtblImportDeclaration> EtblImportDeclarations { get; set; }

    public virtual DbSet<EtblImportDeclarationLine> EtblImportDeclarationLines { get; set; }

    public virtual DbSet<EtblIncidentSourceDocLink> EtblIncidentSourceDocLinks { get; set; }

    public virtual DbSet<EtblInstructionType> EtblInstructionTypes { get; set; }

    public virtual DbSet<EtblInvCostTracking> EtblInvCostTrackings { get; set; }

    public virtual DbSet<EtblInvImage> EtblInvImages { get; set; }

    public virtual DbSet<EtblInvJrBatch> EtblInvJrBatches { get; set; }

    public virtual DbSet<EtblInvJrBatchLine> EtblInvJrBatchLines { get; set; }

    public virtual DbSet<EtblInvJrBatchLineSn> EtblInvJrBatchLineSns { get; set; }

    public virtual DbSet<EtblInvPriceUpdateBatch> EtblInvPriceUpdateBatches { get; set; }

    public virtual DbSet<EtblInvPriceUpdateBatchLine> EtblInvPriceUpdateBatchLines { get; set; }

    public virtual DbSet<EtblInvSegGroup> EtblInvSegGroups { get; set; }

    public virtual DbSet<EtblInvSegType> EtblInvSegTypes { get; set; }

    public virtual DbSet<EtblInvSegValue> EtblInvSegValues { get; set; }

    public virtual DbSet<EtblInvoiceDeposit> EtblInvoiceDeposits { get; set; }

    public virtual DbSet<EtblLotStatus> EtblLotStatuses { get; set; }

    public virtual DbSet<EtblLotTracking> EtblLotTrackings { get; set; }

    public virtual DbSet<EtblLotTrackingQty> EtblLotTrackingQties { get; set; }

    public virtual DbSet<EtblLotTrackingTx> EtblLotTrackingTxes { get; set; }

    public virtual DbSet<EtblMajorIndustryCode> EtblMajorIndustryCodes { get; set; }

    public virtual DbSet<EtblManufProcess> EtblManufProcesses { get; set; }

    public virtual DbSet<EtblManufProcessItem> EtblManufProcessItems { get; set; }

    public virtual DbSet<EtblManufProcessLine> EtblManufProcessLines { get; set; }

    public virtual DbSet<EtblMcagentCriterion> EtblMcagentCriteria { get; set; }

    public virtual DbSet<EtblMcagentNotification> EtblMcagentNotifications { get; set; }

    public virtual DbSet<EtblMcdefaultCriterion> EtblMcdefaultCriteria { get; set; }

    public virtual DbSet<EtblOrderCancelReason> EtblOrderCancelReasons { get; set; }

    public virtual DbSet<EtblPaymentsBasedTax> EtblPaymentsBasedTaxes { get; set; }

    public virtual DbSet<EtblPaymentsBasedTaxPayment> EtblPaymentsBasedTaxPayments { get; set; }

    public virtual DbSet<EtblPeriod> EtblPeriods { get; set; }

    public virtual DbSet<EtblPeriodYear> EtblPeriodYears { get; set; }

    public virtual DbSet<EtblPopdefault> EtblPopdefaults { get; set; }

    public virtual DbSet<EtblPoprequisition> EtblPoprequisitions { get; set; }

    public virtual DbSet<EtblPoprequisitionLine> EtblPoprequisitionLines { get; set; }

    public virtual DbSet<EtblPoprequisitionLinesHist> EtblPoprequisitionLinesHists { get; set; }

    public virtual DbSet<EtblPoprequisitionsHist> EtblPoprequisitionsHists { get; set; }

    public virtual DbSet<EtblPosdevice> EtblPosdevices { get; set; }

    public virtual DbSet<EtblPostDatedCheque> EtblPostDatedCheques { get; set; }

    public virtual DbSet<EtblPostGlhist> EtblPostGlhists { get; set; }

    public virtual DbSet<EtblPostOutstandingExclAp> EtblPostOutstandingExclAps { get; set; }

    public virtual DbSet<EtblPostOutstandingExclAr> EtblPostOutstandingExclArs { get; set; }

    public virtual DbSet<EtblPriceListName> EtblPriceListNames { get; set; }

    public virtual DbSet<EtblPriceListPrice> EtblPriceListPrices { get; set; }

    public virtual DbSet<EtblPromotion> EtblPromotions { get; set; }

    public virtual DbSet<EtblPromotionItem> EtblPromotionItems { get; set; }

    public virtual DbSet<EtblPromotionItemList> EtblPromotionItemLists { get; set; }

    public virtual DbSet<EtblPromotionItemListLink> EtblPromotionItemListLinks { get; set; }

    public virtual DbSet<EtblPromotionItemListQty> EtblPromotionItemListQties { get; set; }

    public virtual DbSet<EtblRemittanceBatch> EtblRemittanceBatches { get; set; }

    public virtual DbSet<EtblRemittanceBatchDefault> EtblRemittanceBatchDefaults { get; set; }

    public virtual DbSet<EtblRemittanceDefault> EtblRemittanceDefaults { get; set; }

    public virtual DbSet<EtblRemittanceLine> EtblRemittanceLines { get; set; }

    public virtual DbSet<EtblRemittanceSupplier> EtblRemittanceSuppliers { get; set; }

    public virtual DbSet<EtblReplLog> EtblReplLogs { get; set; }

    public virtual DbSet<EtblReportJob> EtblReportJobs { get; set; }

    public virtual DbSet<EtblReportJobLog> EtblReportJobLogs { get; set; }

    public virtual DbSet<EtblRevaluationHistory> EtblRevaluationHistories { get; set; }

    public virtual DbSet<EtblSagePayBank> EtblSagePayBanks { get; set; }

    public virtual DbSet<EtblSagePayErrorCode> EtblSagePayErrorCodes { get; set; }

    public virtual DbSet<EtblSagePayNow> EtblSagePayNows { get; set; }

    public virtual DbSet<EtblSagePayQueue> EtblSagePayQueues { get; set; }

    public virtual DbSet<EtblSagePayServiceKey> EtblSagePayServiceKeys { get; set; }

    public virtual DbSet<EtblSettlementTerm> EtblSettlementTerms { get; set; }

    public virtual DbSet<EtblSyncInfo> EtblSyncInfos { get; set; }

    public virtual DbSet<EtblSyncInfoDetail> EtblSyncInfoDetails { get; set; }

    public virtual DbSet<EtblSystem> EtblSystems { get; set; }

    public virtual DbSet<EtblSystemDefault> EtblSystemDefaults { get; set; }

    public virtual DbSet<EtblSystemUpdate> EtblSystemUpdates { get; set; }

    public virtual DbSet<EtblTaxBadDebt> EtblTaxBadDebts { get; set; }

    public virtual DbSet<EtblTaxBoxLayout> EtblTaxBoxLayouts { get; set; }

    public virtual DbSet<EtblTaxBoxSetup> EtblTaxBoxSetups { get; set; }

    public virtual DbSet<EtblTaxDefault> EtblTaxDefaults { get; set; }

    public virtual DbSet<EtblTaxGroup> EtblTaxGroups { get; set; }

    public virtual DbSet<EtblTaxGroupTransType> EtblTaxGroupTransTypes { get; set; }

    public virtual DbSet<EtblTaxSubmissionDetail> EtblTaxSubmissionDetails { get; set; }

    public virtual DbSet<EtblTerm> EtblTerms { get; set; }

    public virtual DbSet<EtblUnit> EtblUnits { get; set; }

    public virtual DbSet<EtblUnitCategory> EtblUnitCategories { get; set; }

    public virtual DbSet<EtblUnitConversion> EtblUnitConversions { get; set; }

    public virtual DbSet<EtblVasairtimeItem> EtblVasairtimeItems { get; set; }

    public virtual DbSet<EtblVasairtimeMaster> EtblVasairtimeMasters { get; set; }

    public virtual DbSet<EtblVasairtimeNetwork> EtblVasairtimeNetworks { get; set; }

    public virtual DbSet<EtblVasairtimeProduct> EtblVasairtimeProducts { get; set; }

    public virtual DbSet<EtblVdap> EtblVdaps { get; set; }

    public virtual DbSet<EtblVdar> EtblVdars { get; set; }

    public virtual DbSet<EtblVdlnAp> EtblVdlnAps { get; set; }

    public virtual DbSet<EtblVdlnAr> EtblVdlnArs { get; set; }

    public virtual DbSet<EtblVdlnLvlAp> EtblVdlnLvlAps { get; set; }

    public virtual DbSet<EtblVdlnLvlAr> EtblVdlnLvlArs { get; set; }

    public virtual DbSet<EtblWhDefault> EtblWhDefaults { get; set; }

    public virtual DbSet<EtblWhseIbt> EtblWhseIbts { get; set; }

    public virtual DbSet<EtblWhseIbtaddCost> EtblWhseIbtaddCosts { get; set; }

    public virtual DbSet<EtblWhseIbtline> EtblWhseIbtlines { get; set; }

    public virtual DbSet<EtblWhseIbtlineSn> EtblWhseIbtlineSns { get; set; }

    public virtual DbSet<EtblWhseTransferBatch> EtblWhseTransferBatches { get; set; }

    public virtual DbSet<EtblWhseTransferBatchLine> EtblWhseTransferBatchLines { get; set; }

    public virtual DbSet<EtblWorker> EtblWorkers { get; set; }

    public virtual DbSet<EvApbatchLine> EvApbatchLines { get; set; }

    public virtual DbSet<EvAplastDebit> EvAplastDebits { get; set; }

    public virtual DbSet<EvAplastTrxDate> EvAplastTrxDates { get; set; }

    public virtual DbSet<EvAppostDatedCheque> EvAppostDatedCheques { get; set; }

    public virtual DbSet<EvArapbatch> EvArapbatches { get; set; }

    public virtual DbSet<EvArapbatchContraSplit> EvArapbatchContraSplits { get; set; }

    public virtual DbSet<EvArapbatchLine> EvArapbatchLines { get; set; }

    public virtual DbSet<EvArbatchLine> EvArbatchLines { get; set; }

    public virtual DbSet<EvArlastTrxDate> EvArlastTrxDates { get; set; }

    public virtual DbSet<EvArpostDatedCheque> EvArpostDatedCheques { get; set; }

    public virtual DbSet<EvArstatementRun> EvArstatementRuns { get; set; }

    public virtual DbSet<EvArtopSale> EvArtopSales { get; set; }

    public virtual DbSet<EvAuditingAuditedTable> EvAuditingAuditedTables { get; set; }

    public virtual DbSet<EvAuditingListTrigger> EvAuditingListTriggers { get; set; }

    public virtual DbSet<EvAutoLevelUpdateItem> EvAutoLevelUpdateItems { get; set; }

    public virtual DbSet<EvBatchPermission> EvBatchPermissions { get; set; }

    public virtual DbSet<EvCmevent> EvCmevents { get; set; }

    public virtual DbSet<EvDelAddressFull> EvDelAddressFulls { get; set; }

    public virtual DbSet<EvDocCat> EvDocCats { get; set; }

    public virtual DbSet<EvDocProfile> EvDocProfiles { get; set; }

    public virtual DbSet<EvEftsfileLayout> EvEftsfileLayouts { get; set; }

    public virtual DbSet<EvGlaccountBalancesFull> EvGlaccountBalancesFulls { get; set; }

    public virtual DbSet<EvGlaccountsAnnualOpeningBalance> EvGlaccountsAnnualOpeningBalances { get; set; }

    public virtual DbSet<EvGlaccountsFull> EvGlaccountsFulls { get; set; }

    public virtual DbSet<EvGlbatchReferenceNumber> EvGlbatchReferenceNumbers { get; set; }

    public virtual DbSet<EvGlmScoasegment> EvGlmScoasegments { get; set; }

    public virtual DbSet<EvInvCostTracking> EvInvCostTrackings { get; set; }

    public virtual DbSet<EvInvJrBatch> EvInvJrBatches { get; set; }

    public virtual DbSet<EvInvJrBatchLine> EvInvJrBatchLines { get; set; }

    public virtual DbSet<EvInvJrBatchLineSn> EvInvJrBatchLineSns { get; set; }

    public virtual DbSet<EvInvPriceUpdateBatchLine> EvInvPriceUpdateBatchLines { get; set; }

    public virtual DbSet<EvInvSegGroup> EvInvSegGroups { get; set; }

    public virtual DbSet<EvInvSegValue> EvInvSegValues { get; set; }

    public virtual DbSet<EvLotTrackingTx> EvLotTrackingTxes { get; set; }

    public virtual DbSet<EvLtlotTracking> EvLtlotTrackings { get; set; }

    public virtual DbSet<EvLtlotTrackingQty> EvLtlotTrackingQties { get; set; }

    public virtual DbSet<EvLtlotTrackingWhse> EvLtlotTrackingWhses { get; set; }

    public virtual DbSet<EvManufProcessFull> EvManufProcessFulls { get; set; }

    public virtual DbSet<EvManufProcessLinesFull> EvManufProcessLinesFulls { get; set; }

    public virtual DbSet<EvMcagentCriterion> EvMcagentCriteria { get; set; }

    public virtual DbSet<EvPbttransactionsFull> EvPbttransactionsFulls { get; set; }

    public virtual DbSet<EvPoprequisition> EvPoprequisitions { get; set; }

    public virtual DbSet<EvPoprequisitionLine> EvPoprequisitionLines { get; set; }

    public virtual DbSet<EvPoprequisitionLinesHist> EvPoprequisitionLinesHists { get; set; }

    public virtual DbSet<EvPoprequisitionsHist> EvPoprequisitionsHists { get; set; }

    public virtual DbSet<EvPosdevice> EvPosdevices { get; set; }

    public virtual DbSet<EvPriceListPrice> EvPriceListPrices { get; set; }

    public virtual DbSet<EvPriceListPricesFull> EvPriceListPricesFulls { get; set; }

    public virtual DbSet<EvStockCostsVariance> EvStockCostsVariances { get; set; }

    public virtual DbSet<EvStockEuinfo> EvStockEuinfos { get; set; }

    public virtual DbSet<EvTaxBoxReport> EvTaxBoxReports { get; set; }

    public virtual DbSet<EvTaxBoxReportUae> EvTaxBoxReportUaes { get; set; }

    public virtual DbSet<EvTaxGroup> EvTaxGroups { get; set; }

    public virtual DbSet<EvTaxGroupTransType> EvTaxGroupTransTypes { get; set; }

    public virtual DbSet<EvTaxGroupTransTypeJc> EvTaxGroupTransTypeJcs { get; set; }

    public virtual DbSet<EvTotalSalesTodayForAr> EvTotalSalesTodayForArs { get; set; }

    public virtual DbSet<EvTotalSalesTodayForSalesRep> EvTotalSalesTodayForSalesReps { get; set; }

    public virtual DbSet<EvUnitsOfMeasureConversion> EvUnitsOfMeasureConversions { get; set; }

    public virtual DbSet<EvUnitsOfMeasureFull> EvUnitsOfMeasureFulls { get; set; }

    public virtual DbSet<EvWhseIbt> EvWhseIbts { get; set; }

    public virtual DbSet<EvWhseIbtline> EvWhseIbtlines { get; set; }

    public virtual DbSet<EvWhseIbtlineSn> EvWhseIbtlineSns { get; set; }

    public virtual DbSet<EvWhseTrfBatch> EvWhseTrfBatches { get; set; }

    public virtual DbSet<EvWhseTrfBatchLine> EvWhseTrfBatchLines { get; set; }

    public virtual DbSet<Glbranch> Glbranches { get; set; }

    public virtual DbSet<GrpTbl> GrpTbls { get; set; }

    public virtual DbSet<InvNum> InvNums { get; set; }

    public virtual DbSet<JobDef> JobDefs { get; set; }

    public virtual DbSet<JobNum> JobNums { get; set; }

    public virtual DbSet<JobStock> JobStocks { get; set; }

    public virtual DbSet<JobTxTp> JobTxTps { get; set; }

    public virtual DbSet<MastOff> MastOffs { get; set; }

    public virtual DbSet<MtblMbrcategory> MtblMbrcategories { get; set; }

    public virtual DbSet<NtSupplier> NtSuppliers { get; set; }

    public virtual DbSet<NtSuppliersAudit> NtSuppliersAudits { get; set; }

    public virtual DbSet<OldAccBlnc> OldAccBlncs { get; set; }

    public virtual DbSet<OldBudget> OldBudgets { get; set; }

    public virtual DbSet<OldEtblGlprojectBalance> OldEtblGlprojectBalances { get; set; }

    public virtual DbSet<OldEtblGlprojectBudget> OldEtblGlprojectBudgets { get; set; }

    public virtual DbSet<OldEtblGlprojectPrevBalance> OldEtblGlprojectPrevBalances { get; set; }

    public virtual DbSet<OldPeriod> OldPeriods { get; set; }

    public virtual DbSet<OrdersDf> OrdersDfs { get; set; }

    public virtual DbSet<OrdersSt> OrdersSts { get; set; }

    public virtual DbSet<PckTbl> PckTbls { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<PeriodPermission> PeriodPermissions { get; set; }

    public virtual DbSet<PinnedItem> PinnedItems { get; set; }

    public virtual DbSet<PosDef> PosDefs { get; set; }

    public virtual DbSet<PostAp> PostAps { get; set; }

    public virtual DbSet<PostAr> PostArs { get; set; }

    public virtual DbSet<PostGl> PostGls { get; set; }

    public virtual DbSet<PostSt> PostSts { get; set; }

    public virtual DbSet<PrintGrp> PrintGrps { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<RecentItem> RecentItems { get; set; }

    public virtual DbSet<RecurRc> RecurRcs { get; set; }

    public virtual DbSet<RecurRdef> RecurRdefs { get; set; }

    public virtual DbSet<RecurRf> RecurRves { get; set; }

    public virtual DbSet<RecurRl> RecurRls { get; set; }

    public virtual DbSet<RecurRtx> RecurRtxes { get; set; }

    public virtual DbSet<Refer> Refers { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<RetAgentSession> RetAgentSessions { get; set; }

    public virtual DbSet<RetAgentSessionCashPickupTotal> RetAgentSessionCashPickupTotals { get; set; }

    public virtual DbSet<RetAgentSessionDenomination> RetAgentSessionDenominations { get; set; }

    public virtual DbSet<RetAgentSessionPettyCashTotal> RetAgentSessionPettyCashTotals { get; set; }

    public virtual DbSet<RetAgentSessionTenderTotal> RetAgentSessionTenderTotals { get; set; }

    public virtual DbSet<RetCashPickup> RetCashPickups { get; set; }

    public virtual DbSet<RetCashPickupDenomination> RetCashPickupDenominations { get; set; }

    public virtual DbSet<RetDefault> RetDefaults { get; set; }

    public virtual DbSet<RetDenomination> RetDenominations { get; set; }

    public virtual DbSet<RetDiscountReason> RetDiscountReasons { get; set; }

    public virtual DbSet<RetDocketLock> RetDocketLocks { get; set; }

    public virtual DbSet<RetLayBy> RetLayBys { get; set; }

    public virtual DbSet<RetPettyCash> RetPettyCashes { get; set; }

    public virtual DbSet<RetPettyCashLine> RetPettyCashLines { get; set; }

    public virtual DbSet<RetPettyCashType> RetPettyCashTypes { get; set; }

    public virtual DbSet<RetPosMenu> RetPosMenus { get; set; }

    public virtual DbSet<RetPoslogFile> RetPoslogFiles { get; set; }

    public virtual DbSet<RetPoslogLink> RetPoslogLinks { get; set; }

    public virtual DbSet<RetPosmenuSetup> RetPosmenuSetups { get; set; }

    public virtual DbSet<RetPostender> RetPostenders { get; set; }

    public virtual DbSet<RetPostransaction> RetPostransactions { get; set; }

    public virtual DbSet<RetPriceOverrideReason> RetPriceOverrideReasons { get; set; }

    public virtual DbSet<RetReturnReason> RetReturnReasons { get; set; }

    public virtual DbSet<RetTenderType> RetTenderTypes { get; set; }

    public virtual DbSet<RetTill> RetTills { get; set; }

    public virtual DbSet<RetTillSecurity> RetTillSecurities { get; set; }

    public virtual DbSet<RetTillStationery> RetTillStationeries { get; set; }

    public virtual DbSet<RetTradingSession> RetTradingSessions { get; set; }

    public virtual DbSet<RetVariableBarcode> RetVariableBarcodes { get; set; }

    public virtual DbSet<RevAgentSession> RevAgentSessions { get; set; }

    public virtual DbSet<RevAgentSessionCashUp> RevAgentSessionCashUps { get; set; }

    public virtual DbSet<RevAgentSessionCashUpDenomination> RevAgentSessionCashUpDenominations { get; set; }

    public virtual DbSet<RevAgentSessionCashUpTenderTotal> RevAgentSessionCashUpTenderTotals { get; set; }

    public virtual DbSet<RevCashPickupDenominationFull> RevCashPickupDenominationFulls { get; set; }

    public virtual DbSet<RevCashPickupFull> RevCashPickupFulls { get; set; }

    public virtual DbSet<RevEftTransaction> RevEftTransactions { get; set; }

    public virtual DbSet<RevLayBy> RevLayBys { get; set; }

    public virtual DbSet<RevLayBysFull> RevLayBysFulls { get; set; }

    public virtual DbSet<RevPaymentByTenderType> RevPaymentByTenderTypes { get; set; }

    public virtual DbSet<RevPaymentByTenderTypeReport> RevPaymentByTenderTypeReports { get; set; }

    public virtual DbSet<RevPaymentHistoryPickSlip> RevPaymentHistoryPickSlips { get; set; }

    public virtual DbSet<RevPettyCashAdvance> RevPettyCashAdvances { get; set; }

    public virtual DbSet<RevPettyCashProcessed> RevPettyCashProcesseds { get; set; }

    public virtual DbSet<RevPoslogFull> RevPoslogFulls { get; set; }

    public virtual DbSet<RevPostenderFull> RevPostenderFulls { get; set; }

    public virtual DbSet<RevPromotionItem> RevPromotionItems { get; set; }

    public virtual DbSet<RevReceiptPrinting> RevReceiptPrintings { get; set; }

    public virtual DbSet<RevTrCode> RevTrCodes { get; set; }

    public virtual DbSet<RevTradingSession> RevTradingSessions { get; set; }

    public virtual DbSet<Rfq> Rfqs { get; set; }

    public virtual DbSet<RfqAgentCostCentreMap> RfqAgentCostCentreMaps { get; set; }

    public virtual DbSet<RfqAgentSectorMapping> RfqAgentSectorMappings { get; set; }

    public virtual DbSet<RfqApshareholderLink> RfqApshareholderLinks { get; set; }

    public virtual DbSet<RfqAudit> RfqAudits { get; set; }

    public virtual DbSet<RfqAuditTable> RfqAuditTables { get; set; }

    public virtual DbSet<RfqCostCentre> RfqCostCentres { get; set; }

    public virtual DbSet<RfqDeviation> RfqDeviations { get; set; }

    public virtual DbSet<RfqDeviationReason> RfqDeviationReasons { get; set; }

    public virtual DbSet<RfqEvent> RfqEvents { get; set; }

    public virtual DbSet<RfqFileAttachment> RfqFileAttachments { get; set; }

    public virtual DbSet<RfqNewQuotationParam> RfqNewQuotationParams { get; set; }

    public virtual DbSet<RfqNewTender> RfqNewTenders { get; set; }

    public virtual DbSet<RfqNewTenderDetail> RfqNewTenderDetails { get; set; }

    public virtual DbSet<RfqNewTenderParam> RfqNewTenderParams { get; set; }

    public virtual DbSet<RfqNote> RfqNotes { get; set; }

    public virtual DbSet<RfqParameterCriterion> RfqParameterCriteria { get; set; }

    public virtual DbSet<RfqParameterUdf> RfqParameterUdfs { get; set; }

    public virtual DbSet<RfqPeopleLink> RfqPeopleLinks { get; set; }

    public virtual DbSet<RfqQuotationParameter> RfqQuotationParameters { get; set; }

    public virtual DbSet<RfqRecordQuotationParam> RfqRecordQuotationParams { get; set; }

    public virtual DbSet<RfqRecordTender> RfqRecordTenders { get; set; }

    public virtual DbSet<RfqRecordTenderDetail> RfqRecordTenderDetails { get; set; }

    public virtual DbSet<RfqRecordTenderParam> RfqRecordTenderParams { get; set; }

    public virtual DbSet<RfqReportLayout> RfqReportLayouts { get; set; }

    public virtual DbSet<RfqSector> RfqSectors { get; set; }

    public virtual DbSet<RfqStockLink> RfqStockLinks { get; set; }

    public virtual DbSet<RfqSupplierFiltering> RfqSupplierFilterings { get; set; }

    public virtual DbSet<RfqSupplierPreference> RfqSupplierPreferences { get; set; }

    public virtual DbSet<RfqTenderDf> RfqTenderDfs { get; set; }

    public virtual DbSet<RfqTenderParameter> RfqTenderParameters { get; set; }

    public virtual DbSet<RfqUdf> RfqUdfs { get; set; }

    public virtual DbSet<RfqVendor> RfqVendors { get; set; }

    public virtual DbSet<RfqVendorParameter> RfqVendorParameters { get; set; }

    public virtual DbSet<RfqVendorScore> RfqVendorScores { get; set; }

    public virtual DbSet<RfqWorkflowLink> RfqWorkflowLinks { get; set; }

    public virtual DbSet<Rfqdf> Rfqdfs { get; set; }

    public virtual DbSet<RtblAgent> RtblAgents { get; set; }

    public virtual DbSet<RtblAgentGroup> RtblAgentGroups { get; set; }

    public virtual DbSet<RtblAgentGroupMember> RtblAgentGroupMembers { get; set; }

    public virtual DbSet<RtblAgentLockedOut> RtblAgentLockedOuts { get; set; }

    public virtual DbSet<RtblBusClass> RtblBusClasses { get; set; }

    public virtual DbSet<RtblBusDept> RtblBusDepts { get; set; }

    public virtual DbSet<RtblBusDesig> RtblBusDesigs { get; set; }

    public virtual DbSet<RtblBusType> RtblBusTypes { get; set; }

    public virtual DbSet<RtblClass> RtblClasses { get; set; }

    public virtual DbSet<RtblCmdefault> RtblCmdefaults { get; set; }

    public virtual DbSet<RtblCompetitor> RtblCompetitors { get; set; }

    public virtual DbSet<RtblCompetitorProduct> RtblCompetitorProducts { get; set; }

    public virtual DbSet<RtblCompetitorProductLink> RtblCompetitorProductLinks { get; set; }

    public virtual DbSet<RtblContract> RtblContracts { get; set; }

    public virtual DbSet<RtblContractDocLink> RtblContractDocLinks { get; set; }

    public virtual DbSet<RtblContractTemplate> RtblContractTemplates { get; set; }

    public virtual DbSet<RtblContractTx> RtblContractTxes { get; set; }

    public virtual DbSet<RtblCountry> RtblCountries { get; set; }

    public virtual DbSet<RtblDocCat> RtblDocCats { get; set; }

    public virtual DbSet<RtblDocLink> RtblDocLinks { get; set; }

    public virtual DbSet<RtblDocStore> RtblDocStores { get; set; }

    public virtual DbSet<RtblEscalateGrp> RtblEscalateGrps { get; set; }

    public virtual DbSet<RtblEscalateGrpMember> RtblEscalateGrpMembers { get; set; }

    public virtual DbSet<RtblIncident> RtblIncidents { get; set; }

    public virtual DbSet<RtblIncidentAction> RtblIncidentActions { get; set; }

    public virtual DbSet<RtblIncidentCat> RtblIncidentCats { get; set; }

    public virtual DbSet<RtblIncidentLog> RtblIncidentLogs { get; set; }

    public virtual DbSet<RtblIncidentLogArchive> RtblIncidentLogArchives { get; set; }

    public virtual DbSet<RtblIncidentPriority> RtblIncidentPriorities { get; set; }

    public virtual DbSet<RtblIncidentStatus> RtblIncidentStatuses { get; set; }

    public virtual DbSet<RtblIncidentTemplate> RtblIncidentTemplates { get; set; }

    public virtual DbSet<RtblIncidentType> RtblIncidentTypes { get; set; }

    public virtual DbSet<RtblIncidentsArchive> RtblIncidentsArchives { get; set; }

    public virtual DbSet<RtblKbadocLink> RtblKbadocLinks { get; set; }

    public virtual DbSet<RtblKbcategoryLink> RtblKbcategoryLinks { get; set; }

    public virtual DbSet<RtblKbdescriptionLink> RtblKbdescriptionLinks { get; set; }

    public virtual DbSet<RtblKbdescriptionSetup> RtblKbdescriptionSetups { get; set; }

    public virtual DbSet<RtblKnowledgeBase> RtblKnowledgeBases { get; set; }

    public virtual DbSet<RtblKnowledgeBaseCat> RtblKnowledgeBaseCats { get; set; }

    public virtual DbSet<RtblKnowledgeBaseCatValue> RtblKnowledgeBaseCatValues { get; set; }

    public virtual DbSet<RtblKnowledgeBaseLink> RtblKnowledgeBaseLinks { get; set; }

    public virtual DbSet<RtblNotify> RtblNotifies { get; set; }

    public virtual DbSet<RtblOpportunity> RtblOpportunities { get; set; }

    public virtual DbSet<RtblOpportunityCompetitor> RtblOpportunityCompetitors { get; set; }

    public virtual DbSet<RtblOpportunityDocLink> RtblOpportunityDocLinks { get; set; }

    public virtual DbSet<RtblOpportunitySource> RtblOpportunitySources { get; set; }

    public virtual DbSet<RtblOpportunityStage> RtblOpportunityStages { get; set; }

    public virtual DbSet<RtblOpportunityStatus> RtblOpportunityStatuses { get; set; }

    public virtual DbSet<RtblPeopleLink> RtblPeopleLinks { get; set; }

    public virtual DbSet<RtblPerson> RtblPeople { get; set; }

    public virtual DbSet<RtblProspect> RtblProspects { get; set; }

    public virtual DbSet<RtblRefBase> RtblRefBases { get; set; }

    public virtual DbSet<RtblRefBook> RtblRefBooks { get; set; }

    public virtual DbSet<RtblStockLink> RtblStockLinks { get; set; }

    public virtual DbSet<RtblUserDict> RtblUserDicts { get; set; }

    public virtual DbSet<RtblWorkCal> RtblWorkCals { get; set; }

    public virtual DbSet<RtblWorkCalExDate> RtblWorkCalExDates { get; set; }

    public virtual DbSet<RvCmstockFull> RvCmstockFulls { get; set; }

    public virtual DbSet<RvContract> RvContracts { get; set; }

    public virtual DbSet<RvEscGrpAgent> RvEscGrpAgents { get; set; }

    public virtual DbSet<RvIncidentLog> RvIncidentLogs { get; set; }

    public virtual DbSet<RvIncidentLogFull> RvIncidentLogFulls { get; set; }

    public virtual DbSet<RvIncidentLogFullArchive> RvIncidentLogFullArchives { get; set; }

    public virtual DbSet<RvIncidentType> RvIncidentTypes { get; set; }

    public virtual DbSet<RvIncidentsFull> RvIncidentsFulls { get; set; }

    public virtual DbSet<RvIncidentsFullArchive> RvIncidentsFullArchives { get; set; }

    public virtual DbSet<RvIncidentsFullPro> RvIncidentsFullPros { get; set; }

    public virtual DbSet<RvKnowledgeBaseCategoryFull> RvKnowledgeBaseCategoryFulls { get; set; }

    public virtual DbSet<RvKnowledgeBaseFull> RvKnowledgeBaseFulls { get; set; }

    public virtual DbSet<RvOpportunityCompetitorFull> RvOpportunityCompetitorFulls { get; set; }

    public virtual DbSet<RvOpportunityFull> RvOpportunityFulls { get; set; }

    public virtual DbSet<RvProspect> RvProspects { get; set; }

    public virtual DbSet<SalesRep> SalesReps { get; set; }

    public virtual DbSet<SerialMf> SerialMfs { get; set; }

    public virtual DbSet<SerialTx> SerialTxes { get; set; }

    public virtual DbSet<SimpleSetting> SimpleSettings { get; set; }

    public virtual DbSet<SimtblDefault> SimtblDefaults { get; set; }

    public virtual DbSet<SimtblReportLayout> SimtblReportLayouts { get; set; }

    public virtual DbSet<SimtblReqHeader> SimtblReqHeaders { get; set; }

    public virtual DbSet<SimtblReqLine> SimtblReqLines { get; set; }

    public virtual DbSet<SimtblStkIssueLine> SimtblStkIssueLines { get; set; }

    public virtual DbSet<SimtblStockIssueLineSn> SimtblStockIssueLineSns { get; set; }

    public virtual DbSet<SimtblStockIssueMaster> SimtblStockIssueMasters { get; set; }

    public virtual DbSet<SlipLay> SlipLays { get; set; }

    public virtual DbSet<StDfTbl> StDfTbls { get; set; }

    public virtual DbSet<StkItem> StkItems { get; set; }

    public virtual DbSet<TaxRate> TaxRates { get; set; }

    public virtual DbSet<Tender> Tenders { get; set; }

    public virtual DbSet<Till> Tills { get; set; }

    public virtual DbSet<TrCode> TrCodes { get; set; }

    public virtual DbSet<VenClass> VenClasses { get; set; }

    public virtual DbSet<VenDef> VenDefs { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<WhseMst> WhseMsts { get; set; }

    public virtual DbSet<WhseStk> WhseStks { get; set; }

    public virtual DbSet<WhtBatch> WhtBatches { get; set; }

    public virtual DbSet<WhtBatchStatus> WhtBatchStatuses { get; set; }

    public virtual DbSet<WhtDefaultSetting> WhtDefaultSettings { get; set; }

    public virtual DbSet<WhtState> WhtStates { get; set; }

    public virtual DbSet<WhtTaxMaster> WhtTaxMasters { get; set; }

    public virtual DbSet<WhtUserDetail> WhtUserDetails { get; set; }

    public virtual DbSet<WtblIpadDetail> WtblIpadDetails { get; set; }

    public virtual DbSet<WtblIpadUser> WtblIpadUsers { get; set; }

    public virtual DbSet<WtblMapIpadUserToInvCount> WtblMapIpadUserToInvCounts { get; set; }

    public virtual DbSet<WtblPemmobilityModule> WtblPemmobilityModules { get; set; }

    public virtual DbSet<WtblSystem> WtblSystems { get; set; }

    public virtual DbSet<WvDeviceUser> WvDeviceUsers { get; set; }

    public virtual DbSet<WvIiactiveRequisition> WvIiactiveRequisitions { get; set; }

    public virtual DbSet<WvIiincidentFull> WvIiincidentFulls { get; set; }

    public virtual DbSet<WvIiinventoryIssueNote> WvIiinventoryIssueNotes { get; set; }

    public virtual DbSet<WvIinonWorkflowIncidentType> WvIinonWorkflowIncidentTypes { get; set; }

    public virtual DbSet<WvIirequisition> WvIirequisitions { get; set; }

    public virtual DbSet<WvIistockIssueNoteList> WvIistockIssueNoteLists { get; set; }

    public virtual DbSet<WvIiwarehouseList> WvIiwarehouseLists { get; set; }

    public virtual DbSet<WvIiworkflowIncidentType> WvIiworkflowIncidentTypes { get; set; }

    public virtual DbSet<WvIiworkflowRequisition> WvIiworkflowRequisitions { get; set; }

    public virtual DbSet<WvIncinvCntBatchByDeviceUser> WvIncinvCntBatchByDeviceUsers { get; set; }

    public virtual DbSet<WvIncinventoryCountBatch> WvIncinventoryCountBatches { get; set; }

    public virtual DbSet<WvRfqevoRestrictedSupplier> WvRfqevoRestrictedSuppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");


        modelBuilder.Entity<FiscalInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FiscalIn__3214EC07D2C75532"); //Be wary of dependancies on keys

            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<AccPrev>(entity =>
        {
            entity.HasKey(e => new { e.LedgerLink, e.ITxBranchPrevId }).HasName("PK_AccPrev_LedgerLink_iTxBranchPrevID");

            entity.Property(e => e.ITxBranchPrevId).HasDefaultValue(-1);
            entity.Property(e => e.AccPrevChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountLink)
                .HasName("PK_ACCOUNTS")
                .IsClustered(false);

            entity.HasIndex(e => e.CaseAcc, "idxCaseAcc").HasFillFactor(90);

            entity.HasIndex(e => e.Description, "idxDescription").HasFillFactor(90);

            entity.HasIndex(e => e.MasterSubAccount, "idxMasterSubAccount").HasFillFactor(90);

            entity.Property(e => e.AccountsChecksum).IsFixedLength();
            entity.Property(e => e.ActiveAccount).HasDefaultValue(true);
            entity.Property(e => e.BRevalueWithSellingRate).HasDefaultValue(true);
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.IdAreas)
                .HasName("PK_AREAS")
                .IsClustered(false);

            entity.Property(e => e.AreasChecksum).IsFixedLength();
        });

        modelBuilder.Entity<AtblBulkEmailAccount>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailAccount).HasName("PK__atblBulkEmailAccounts_idBulkEmailAccount");
        });

        modelBuilder.Entity<AtblBulkEmailFilter>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailFilter).HasName("PK__atblBulkEmailFilters_idBulkEmailFilter");
        });

        modelBuilder.Entity<AtblBulkEmailHistory>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailHistory).HasName("PK__atblBulkEmailHistory_idBulkEmailHistory");
        });

        modelBuilder.Entity<AtblBulkEmailHistoryDocument>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailHistoryDocument).HasName("PK__atblBulkEmailHistoryDocuments_idBulkEmailHistoryDocument");
        });

        modelBuilder.Entity<AtblBulkEmailTemplate>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailTemplate).HasName("PK__atblBulkEmailTemplates_idBulkEmailTemplate");
        });

        modelBuilder.Entity<AtblBulkEmailTemplateDatum>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailTemplateData).HasName("PK__atblBulkEmailTemplateData_idBulkEmailTemplateData");
        });

        modelBuilder.Entity<AtblBulkEmailUdffilter>(entity =>
        {
            entity.HasKey(e => e.IdBulkEmailUdffilter).HasName("PK__atblBulkEmailUDFFilters_idBulkEmailUDFFilter");
        });

        modelBuilder.Entity<AtblColumn>(entity =>
        {
            entity.HasKey(e => e.IdColumn).HasName("PK__atblColumns_idColumn");
        });

        modelBuilder.Entity<AtblColumnLookup>(entity =>
        {
            entity.HasKey(e => e.IdColumnLookup).HasName("PK__atblColumnLookups_idColumnLookup");
        });

        modelBuilder.Entity<AtblColumnLookupValue>(entity =>
        {
            entity.HasKey(e => e.IdColumnLookupValue).HasName("PK__atblColumnLookupValues_idColumnLookupValue");
        });

        modelBuilder.Entity<AtblDocDefault>(entity =>
        {
            entity.HasKey(e => e.IdDocDefault).HasName("PK__atblDocDefaults_idDocDefault");
        });

        modelBuilder.Entity<AtblDocImportDocumentTemplate>(entity =>
        {
            entity.HasKey(e => e.IdDocImportDocumentTemplate).HasName("PK__atblDocImportDocumentTemplates_idDocImportDocumentTemplate");
        });

        modelBuilder.Entity<AtblDocImportDocumentTemplateTable>(entity =>
        {
            entity.HasKey(e => e.IdDocumentTemplateTable).HasName("PK__atblDocImportDocumentTemplateTables_idDocumentTemplateTable");
        });

        modelBuilder.Entity<AtblDocImportDocumentType>(entity =>
        {
            entity.HasKey(e => e.IdDocImportDocumentTypes).HasName("PK__atblDocImportDocumentTypes_idDocImportDocumentTypes");
        });

        modelBuilder.Entity<AtblDocImportFieldMapping>(entity =>
        {
            entity.HasKey(e => e.IdDocImportFieldMapping).HasName("PK__atblDocImportFieldMappings_idDocImportFieldMapping");
        });

        modelBuilder.Entity<AtblEmailAccount>(entity =>
        {
            entity.HasKey(e => e.IdEmailAccount).HasName("PK__atblEmailAccounts_idEmailAccount");
        });

        modelBuilder.Entity<AtblExportDefault>(entity =>
        {
            entity.HasKey(e => e.IdExportDefault).HasName("PK__atblExportDefaults_idExportDefault");
        });

        modelBuilder.Entity<AtblExportFieldMapping>(entity =>
        {
            entity.HasKey(e => e.IdExportFieldMapping).HasName("PK__atblExportFieldMappings_idExportFieldMapping");
        });

        modelBuilder.Entity<AtblExportTemplate>(entity =>
        {
            entity.HasKey(e => e.IdExportTemplate).HasName("PK__atblExportTemplates_idExportTemplate");
        });

        modelBuilder.Entity<AtblTable>(entity =>
        {
            entity.HasKey(e => e.IdTable).HasName("PK__atblTables_idTable");
        });

        modelBuilder.Entity<AtblTableRelationship>(entity =>
        {
            entity.HasKey(e => e.IdTableRelationship).HasName("PK__atblTableRelationships_idTableRelationship");
        });

        modelBuilder.Entity<AvCustomerAging>(entity =>
        {
            entity.ToView("_avCustomerAging");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
        });

        modelBuilder.Entity<AvTableTemplate>(entity =>
        {
            entity.ToView("_avTableTemplates");
        });

        modelBuilder.Entity<BankMain>(entity =>
        {
            entity.HasKey(e => e.Counter)
                .HasName("PK_BANKMAIN")
                .IsClustered(false);

            entity.HasIndex(e => e.BankName, "idxBankName").HasFillFactor(90);

            entity.Property(e => e.BankMainChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BomComp>(entity =>
        {
            entity.HasKey(e => e.BomComponentKey)
                .HasName("PK_BOMCOMP")
                .IsClustered(false);

            entity.HasIndex(e => new { e.BomMasterKey, e.ComponentStockLink }, "idxBomComponent").HasFillFactor(90);

            entity.HasIndex(e => new { e.BomMasterKey, e.ComponentIndex }, "idxBomMasterKey").HasFillFactor(90);

            entity.HasIndex(e => e.ComponentStockLink, "idxComponentStockLink").HasFillFactor(90);

            entity.Property(e => e.BomCompChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BomDef>(entity =>
        {
            entity.HasKey(e => e.IdBomDef)
                .HasName("PK_BomDef_idBomDef")
                .IsClustered(false);

            entity.Property(e => e.BPickSlipPrintLastSessionLines).HasDefaultValue(true);
            entity.Property(e => e.BomDefChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BomMast>(entity =>
        {
            entity.HasKey(e => e.BomId)
                .HasName("PK_BOMMAST")
                .IsClustered(false);

            entity.HasIndex(e => e.BomStockCode, "idxBomStockCode").HasFillFactor(90);

            entity.HasIndex(e => e.BomStockLink, "idxBomStockLink").HasFillFactor(90);

            entity.HasIndex(e => e.BomDescription, "idxDescription").HasFillFactor(90);

            entity.Property(e => e.BExplodeOnDocument).HasDefaultValue(false);
            entity.Property(e => e.BomMastChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblAge>(entity =>
        {
            entity.Property(e => e.BtblAgesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblAgentOption>(entity =>
        {
            entity.HasKey(e => e.IdagentOptions)
                .HasName("PK__btblAgentOptions_IDAgentOptions")
                .IsClustered(false);

            entity.Property(e => e.BCalDvshowWeekends).HasDefaultValue(true);
            entity.Property(e => e.BCalMvshowEvents).HasDefaultValue(true);
            entity.Property(e => e.BShowContactPerson).HasDefaultValue(true);
            entity.Property(e => e.BShowEscGroup).HasDefaultValue(true);
            entity.Property(e => e.BShowFixedAssets).HasDefaultValue(true);
            entity.Property(e => e.BShowIncTypeGroup).HasDefaultValue(true);
            entity.Property(e => e.BShowInvItem).HasDefaultValue(true);
            entity.Property(e => e.BShowJobCosting).HasDefaultValue(true);
            entity.Property(e => e.BShowOpportunity).HasDefaultValue(true);
            entity.Property(e => e.BShowProject).HasDefaultValue(true);
            entity.Property(e => e.BShowProspect).HasDefaultValue(true);
            entity.Property(e => e.BShowSupplier).HasDefaultValue(true);
            entity.Property(e => e.BShowWorker).HasDefaultValue(true);
            entity.Property(e => e.BShowWorkflow).HasDefaultValue(true);
            entity.Property(e => e.BtblAgentOptionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblAgentOutOffice>(entity =>
        {
            entity.HasKey(e => e.IdagentOutOffice).IsClustered(false);

            entity.Property(e => e.BtblAgentOutOfficeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblAgentOutOfficeReason>(entity =>
        {
            entity.HasKey(e => e.IAgentOutOfficeId).IsClustered(false);

            entity.Property(e => e.BtblAgentOutOfficeReasonsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblAgentSystemFunction>(entity =>
        {
            entity.Property(e => e.CAgentType).IsFixedLength();
            entity.Property(e => e.BtblAgentSystemFunctionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblAgentSystemTree>(entity =>
        {
            entity.HasIndex(e => new { e.IAgentId, e.CAgentType, e.ISystemTreeId, e.IParentAgentSystemTreeId }, "IDX__btblAgentSystemTree").HasFillFactor(90);

            entity.Property(e => e.BtblAgentSystemTreeChecksum).IsFixedLength();
            entity.Property(e => e.CAgentType).IsFixedLength();
        });

        modelBuilder.Entity<BtblBatchCheckout>(entity =>
        {
            entity.HasKey(e => e.IdBatchCheckout).HasName("PK_idBatchCheckout");

            entity.Property(e => e.BtblBatchCheckoutChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblBinlocation>(entity =>
        {
            entity.Property(e => e.BtblBinlocationChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblCbBatch>(entity =>
        {
            entity.Property(e => e.BAllowDisc).HasDefaultValue(true);
            entity.Property(e => e.BCheckedOut).HasDefaultValue(false);
            entity.Property(e => e.BDupRefs).HasDefaultValue(true);
            entity.Property(e => e.BPromptGlobalChanges).HasDefaultValue(false);
            entity.Property(e => e.BtblCbBatchesChecksum).IsFixedLength();
            entity.Property(e => e.IAgentBatchCreated).HasDefaultValue(1);
        });

        modelBuilder.Entity<BtblCbBatchDef>(entity =>
        {
            entity.Property(e => e.BBatchRefAutoNumbers).HasDefaultValue(true);
            entity.Property(e => e.BForceBatchRefNo).HasDefaultValue(true);
            entity.Property(e => e.BtblCbBatchDefsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblCbBatchLine>(entity =>
        {
            entity.Property(e => e.BtblCbBatchLinesChecksum).IsFixedLength();
            entity.Property(e => e.FFcaccountExchange).HasDefaultValue(1.0);
            entity.Property(e => e.IMbmeterId).HasDefaultValue(0);
            entity.Property(e => e.IMbportionId).HasDefaultValue(0);
            entity.Property(e => e.IMbpropertyId).HasDefaultValue(0);
            entity.Property(e => e.IMbpropertyPortionServiceId).HasDefaultValue(0);
            entity.Property(e => e.IMbserviceId).HasDefaultValue(0);
            entity.Property(e => e.ISplitType).HasDefaultValue(0);
        });

        modelBuilder.Entity<BtblCbbankImportDefault>(entity =>
        {
            entity.Property(e => e.BWindowsDateFormat).HasDefaultValue(true);
            entity.Property(e => e.BtblCbbankImportDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblCmevent>(entity =>
        {
            entity.HasIndex(e => e.IIncidentId, "IDX__btblCMEvent_iIncidentID").HasFillFactor(90);

            entity.Property(e => e.BtblCmeventChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblCmeventAttendee>(entity =>
        {
            entity.HasKey(e => e.IdCmeventAttendees)
                .HasName("PK__btblCMEventAttendees_idCMEventAttendees")
                .IsClustered(false);

            entity.HasIndex(e => new { e.IEventId, e.IAttendeeId, e.CAttendeeType }, "IDX__btblCMEventAttendees")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BtblCmeventAttendeesChecksum).IsFixedLength();
            entity.Property(e => e.CAttendeeType).IsFixedLength();
        });

        modelBuilder.Entity<BtblCmincidentTypeGroup>(entity =>
        {
            entity.Property(e => e.BtblCmincidentTypeGroupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblCmworkflow>(entity =>
        {
            entity.Property(e => e.BtblCmworkflowChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblCmworkflowMember>(entity =>
        {
            entity.Property(e => e.BAllowCloseAfterReject).HasDefaultValue(true);
            entity.Property(e => e.BtblCmworkflowMembersChecksum).IsFixedLength();
            entity.Property(e => e.CAgentType).IsFixedLength();
        });

        modelBuilder.Entity<BtblCmworkflowStatus>(entity =>
        {
            entity.Property(e => e.BtblCmworkflowStatusChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaasset>(entity =>
        {
            entity.ToTable("_btblFAAsset", tb =>
                {
                    tb.HasTrigger("_btrFAAssetCapexOrderDel");
                    tb.HasTrigger("_btrFAAssetCapexOrderIns");
                    tb.HasTrigger("_btrFAAssetCapexOrderUpd");
                });

            entity.HasIndex(e => e.CAssetCode, "idx_assetcode").HasFillFactor(90);

            entity.Property(e => e.BCgtrolloverRelief).HasDefaultValue(false);
            entity.Property(e => e.BWtwriteOffAsset).HasDefaultValue(false);
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.FCgtbaseCost).HasDefaultValue(0.0);
            entity.Property(e => e.FFinPeriod).HasDefaultValue(0);
            entity.Property(e => e.FFinRate).HasDefaultValue(0.0);
            entity.Property(e => e.FFinResidual).HasDefaultValue(0.0);
            entity.Property(e => e.FImpairmentCost).HasDefaultValue(0.0);
            entity.Property(e => e.FWtresidualValue).HasDefaultValue(0.0);
            entity.Property(e => e.IdFinMethod).HasDefaultValue(0);
        });

        modelBuilder.Entity<BtblFaassetBlock>(entity =>
        {
            entity.Property(e => e.BtblFaassetBlockChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaassetImage>(entity =>
        {
            entity.Property(e => e.BtblFaassetImagesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaassetSerialNo>(entity =>
        {
            entity.HasIndex(e => new { e.CSerialNo, e.IdSerialNo, e.CAssetCode }, "idx_serialno").HasFillFactor(90);

            entity.Property(e => e.BtblFaassetSerialNoChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaassetTracking>(entity =>
        {
            entity.Property(e => e.BDeleteAftComplete).HasDefaultValue(true);
            entity.Property(e => e.BtblFaassetTrackingChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaassetTrackingLine>(entity =>
        {
            entity.Property(e => e.BtblFaassetTrackingLinesChecksum).IsFixedLength();
            entity.Property(e => e.ITrackingAdjustment).HasDefaultValue(0);
            entity.Property(e => e.ITrackingDifference).HasDefaultValue(0);
            entity.Property(e => e.ITrackingStatus).HasDefaultValue(0);
        });

        modelBuilder.Entity<BtblFaassetType>(entity =>
        {
            entity.Property(e => e.BtblFaassetTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaassetUnitsOfUsage>(entity =>
        {
            entity.Property(e => e.BtblFaassetUnitsOfUsageChecksum).IsFixedLength();
            entity.Property(e => e.CDeprTypeInd)
                .HasDefaultValue("B")
                .IsFixedLength();
        });

        modelBuilder.Entity<BtblFacapexBudget>(entity =>
        {
            entity.Property(e => e.BtblFacapexBudgetChecksum).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
        });

        modelBuilder.Entity<BtblFacapexOrder>(entity =>
        {
            entity.ToTable("_btblFACapexOrder", tb =>
                {
                    tb.HasTrigger("_btrFACapexOrderDel");
                    tb.HasTrigger("_btrFACapexOrderIns");
                    tb.HasTrigger("_btrFACapexOrderUpd");
                });

            entity.Property(e => e.BtblFacapexOrderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFacapexPhasing>(entity =>
        {
            entity.Property(e => e.BtblFacapexPhasingChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFacompanySetup>(entity =>
        {
            entity.Property(e => e.BtblFacompanySetupChecksum).IsFixedLength();
            entity.Property(e => e.CCalcStartDateInd).IsFixedLength();
            entity.Property(e => e.CCapexInd).IsFixedLength();
            entity.Property(e => e.CDebitMethod).IsFixedLength();
            entity.Property(e => e.CDecimalInd).IsFixedLength();
            entity.Property(e => e.CGlintegrationInd).IsFixedLength();
            entity.Property(e => e.CIntegrationMethod).IsFixedLength();
        });

        modelBuilder.Entity<BtblFadepreciationMethod>(entity =>
        {
            entity.Property(e => e.BtblFadepreciationMethodChecksum).IsFixedLength();
            entity.Property(e => e.CBasisInd).IsFixedLength();
            entity.Property(e => e.CSystemInd).IsFixedLength();
        });

        modelBuilder.Entity<BtblFadepreciationYear>(entity =>
        {
            entity.Property(e => e.BtblFadepreciationYearChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFafinanceMethod>(entity =>
        {
            entity.Property(e => e.BtblFafinanceMethodChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaglbatch>(entity =>
        {
            entity.Property(e => e.BtblFaglbatchChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaglbatchAssetValue>(entity =>
        {
            entity.Property(e => e.BtblFaglbatchAssetValuesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaglbatchGlentry>(entity =>
        {
            entity.Property(e => e.BtblFaglbatchGlentriesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaglperiod>(entity =>
        {
            entity.Property(e => e.BClosedInd).HasDefaultValue(false);
            entity.Property(e => e.BReopened).HasDefaultValue(false);
            entity.Property(e => e.BtblFaglperiodChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFagltotalAssetValue>(entity =>
        {
            entity.Property(e => e.BtblFagltotalAssetValuesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFagltotalGlentry>(entity =>
        {
            entity.Property(e => e.BtblFagltotalGlentriesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFalocation>(entity =>
        {
            entity.Property(e => e.BtblFalocationChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFamovementTransaction>(entity =>
        {
            entity.Property(e => e.BtblFamovementTransactionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblFaperiodClose>(entity =>
        {
            entity.Property(e => e.BReopened).HasDefaultValue(false);
            entity.Property(e => e.BtblFaperiodCloseChecksum).IsFixedLength();
            entity.Property(e => e.CAssetCode).IsFixedLength();
            entity.Property(e => e.IdPeriodClose).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BtblFatxDefaultGlaccount>(entity =>
        {
            entity.Property(e => e.BtblFatxDefaultGlaccountsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvCount>(entity =>
        {
            entity.Property(e => e.BDeleteAftComplete).HasDefaultValue(true);
            entity.Property(e => e.BIgnoreInactive).HasDefaultValue(true);
            entity.Property(e => e.BIncludeJcwip).HasDefaultValue(true);
            entity.Property(e => e.BIncludeMfwip).HasDefaultValue(true);
            entity.Property(e => e.BIncludeSystemQty).HasDefaultValue(true);
            entity.Property(e => e.BtblInvCountChecksum).IsFixedLength();
            entity.Property(e => e.CBinLocationsChkLstInd).IsFixedLength();
            entity.Property(e => e.CGroupsChkLstInd).IsFixedLength();
            entity.Property(e => e.CInventoryTypesChkLstInd).IsFixedLength();
            entity.Property(e => e.CLotStatusChkLstInd).IsFixedLength();
            entity.Property(e => e.CPacksChkLstInd).IsFixedLength();
            entity.Property(e => e.CWarehousesChkLstInd).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvCountLine>(entity =>
        {
            entity.HasIndex(e => e.IInvCountId, "idx__btblInvCountLines").HasFillFactor(90);

            entity.Property(e => e.BtblInvCountLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvCountLinesUom>(entity =>
        {
            entity.Property(e => e.BtblInvCountLinesUomChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvCountSegFilter>(entity =>
        {
            entity.HasKey(e => e.IdInvCountSegFilter).IsClustered(false);

            entity.Property(e => e.BtblInvCountSegFiltersChecksum).IsFixedLength();
            entity.Property(e => e.CSegGroupsChkListInd).IsFixedLength();
            entity.Property(e => e.CSegValuesChkListInd).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvoiceFiscalTaxis>(entity =>
        {
            entity.HasKey(e => e.IdInvoiceTaxes)
                .HasName("PK___btblInvoiceFiscalTaxes")
                .IsClustered(false);

            entity.Property(e => e.BCreditedInv).HasDefaultValue(false);
            entity.Property(e => e.BtblInvoiceFiscalTaxesChecksum).IsFixedLength();
            entity.Property(e => e.FFiscalTotal).HasDefaultValue(0.0);
            entity.Property(e => e.ILinkedDocId).HasDefaultValue(0);
        });

        modelBuilder.Entity<BtblInvoiceGrvSplit>(entity =>
        {
            entity.HasIndex(e => e.IGrvSplitInvoiceId, "idxInvoiceID").HasFillFactor(90);

            entity.Property(e => e.BtblInvoiceGrvSplitChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvoiceLine>(entity =>
        {
            entity.HasKey(e => e.IdInvoiceLines).HasName("PK__btlInvoiceLines");

            entity.HasIndex(e => e.IInvoiceId, "idxInvoiceID").HasFillFactor(90);

            entity.Property(e => e.BChargeCom).HasDefaultValue(true);
            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.FHeight).HasDefaultValue(0.0);
            entity.Property(e => e.FLength).HasDefaultValue(0.0);
            entity.Property(e => e.FRecommendedRetailPrice).HasDefaultValue(0.0);
            entity.Property(e => e.FWidth).HasDefaultValue(0.0);
            entity.Property(e => e.IPieces).HasDefaultValue(0);
            entity.Property(e => e.IPiecesDeliver).HasDefaultValue(0);
            entity.Property(e => e.IPiecesForDelivery).HasDefaultValue(0);
            entity.Property(e => e.IPiecesLastProcess).HasDefaultValue(0);
            entity.Property(e => e.IPiecesProcessed).HasDefaultValue(0);
            entity.Property(e => e.IPiecesReserved).HasDefaultValue(0);
            entity.Property(e => e.IPiecesToProcess).HasDefaultValue(0);
        });

        modelBuilder.Entity<BtblInvoiceLineSn>(entity =>
        {
            entity.HasIndex(e => new { e.ISerialInvoiceId, e.ISerialInvoiceLineId }, "idxInvoiceID").HasFillFactor(90);

            entity.Property(e => e.BtblInvoiceLineSnChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblInvoiceMessage>(entity =>
        {
            entity.Property(e => e.BtblInvoiceMessagesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblJcinvoiceLine>(entity =>
        {
            entity.Property(e => e.BChargeCom).HasDefaultValue(true);
            entity.Property(e => e.BtblJcinvoiceLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblJcmaster>(entity =>
        {
            entity.HasIndex(e => e.CJobCode, "idxJobCode").HasFillFactor(90);

            entity.Property(e => e.BTaxPerLineEntry).HasDefaultValue(true);
            entity.Property(e => e.BtblJcmasterChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblJctxLine>(entity =>
        {
            entity.Property(e => e.BChargeCom).HasDefaultValue(true);
            entity.Property(e => e.BFiscalInvoiced).HasDefaultValue(false);
            entity.Property(e => e.BtblJctxLinesChecksum).IsFixedLength();
            entity.Property(e => e.FRecommendedRetailPrice).HasDefaultValue(0.0);
            entity.Property(e => e.FTransQtyLastInvoiced).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<BtblJobFiscalTaxis>(entity =>
        {
            entity.HasKey(e => e.IdInvoiceTaxes)
                .HasName("PK____btblJobFiscalTaxes")
                .IsClustered(false);

            entity.Property(e => e.BCreditedInv).HasDefaultValue(false);
            entity.Property(e => e.BtblJobFiscalTaxesChecksum).IsFixedLength();
            entity.Property(e => e.FFiscalTotal).HasDefaultValue(0.0);
            entity.Property(e => e.ILinkedDocId).HasDefaultValue(0);
        });

        modelBuilder.Entity<BtblJrBatch>(entity =>
        {
            entity.Property(e => e.BAccrualBatch).HasDefaultValue(false);
            entity.Property(e => e.BCheckedOut).HasDefaultValue(false);
            entity.Property(e => e.BPromptGlobalChanges).HasDefaultValue(false);
            entity.Property(e => e.BtblJrBatchesChecksum).IsFixedLength();
            entity.Property(e => e.IAgentBatchCreated).HasDefaultValue(1);
        });

        modelBuilder.Entity<BtblJrBatchDef>(entity =>
        {
            entity.Property(e => e.BBatchRefAutoNumbers).HasDefaultValue(true);
            entity.Property(e => e.BForceBatchRefNo).HasDefaultValue(true);
            entity.Property(e => e.BtblJrBatchDefsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblJrBatchLine>(entity =>
        {
            entity.Property(e => e.BAccrual).HasDefaultValue(false);
            entity.Property(e => e.BtblJrBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblLogDetail>(entity =>
        {
            entity.Property(e => e.BtblLogDetailsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblLogMaster>(entity =>
        {
            entity.Property(e => e.ILogOrdinal).ValueGeneratedNever();
            entity.Property(e => e.BtblLogMasterChecksum).IsFixedLength();
            entity.Property(e => e.IdLogMaster).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BtblNote>(entity =>
        {
            entity.Property(e => e.BtblNotesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblPostenderTx>(entity =>
        {
            entity.Property(e => e.BtblPostenderTxChecksum).IsFixedLength();
            entity.Property(e => e.CEftbudgetPeriod).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<BtblPosxztable>(entity =>
        {
            entity.Property(e => e.BtblPosxztableChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblRbfolder>(entity =>
        {
            entity.HasIndex(e => e.IdFolder, "folder_idx").HasFillFactor(90);

            entity.HasIndex(e => e.IParentId, "parent_idx").HasFillFactor(90);

            entity.Property(e => e.BtblRbfolderChecksum).IsFixedLength();
            entity.Property(e => e.IdFolder).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BtblRbitem>(entity =>
        {
            entity.HasIndex(e => new { e.IFolderId, e.IItemType, e.CItemName }, "folder_item_name_idx").HasFillFactor(90);

            entity.HasIndex(e => e.IdItem, "item_id_idx").HasFillFactor(90);

            entity.Property(e => e.BtblRbitemChecksum).IsFixedLength();
            entity.Property(e => e.IdItem).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BtblRbudefField>(entity =>
        {
            entity.HasIndex(e => new { e.CTableName, e.CFieldAlias }, "rb_table_field_alias_idx")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.CTableName, e.CFieldName }, "rb_table_field_name_idx")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BtblRbudefFieldChecksum).IsFixedLength();
            entity.Property(e => e.CAutoSearch).IsFixedLength();
            entity.Property(e => e.CMandatory).IsFixedLength();
            entity.Property(e => e.CSearchable).IsFixedLength();
            entity.Property(e => e.CSelectable).IsFixedLength();
            entity.Property(e => e.CSortable).IsFixedLength();
        });

        modelBuilder.Entity<BtblSerialNumberLink>(entity =>
        {
            entity.Property(e => e.BtblSerialNumberLinkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblState>(entity =>
        {
            entity.Property(e => e.BtblStateChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblSystemFunction>(entity =>
        {
            entity.Property(e => e.IdSystemFunction).ValueGeneratedNever();
            entity.Property(e => e.BIsSystemRule).HasDefaultValue(true);
            entity.Property(e => e.BtblSystemFunctionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblSystemTree>(entity =>
        {
            entity.Property(e => e.IdSystemTree).ValueGeneratedNever();
            entity.Property(e => e.BAllowDesign).HasDefaultValue(true);
            entity.Property(e => e.BEvolutionHandled).HasDefaultValue(0);
            entity.Property(e => e.BtblSystemTreeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblTmcalcSheet>(entity =>
        {
            entity.Property(e => e.BtblTmcalcSheetChecksum).IsFixedLength();
            entity.Property(e => e.COperation).IsFixedLength();
            entity.Property(e => e.IOrder).HasDefaultValue(1);
        });

        modelBuilder.Entity<BtblTmtaxBox>(entity =>
        {
            entity.Property(e => e.BPayroll).HasDefaultValue(true);
            entity.Property(e => e.BTax).HasDefaultValue(true);
            entity.Property(e => e.BWithHolding).HasDefaultValue(true);
            entity.Property(e => e.BtblTmtaxBoxChecksum).IsFixedLength();
            entity.Property(e => e.IGlsign).HasDefaultValue(1);
        });

        modelBuilder.Entity<BtblTmtaxPeriod>(entity =>
        {
            entity.Property(e => e.BPayroll).HasDefaultValue(true);
            entity.Property(e => e.BTax).HasDefaultValue(true);
            entity.Property(e => e.BWithHolding).HasDefaultValue(true);
            entity.Property(e => e.BtblTmtaxPeriodChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblTmtaxPeriodYear>(entity =>
        {
            entity.Property(e => e.BtblTmtaxPeriodYearChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BtblTmtaxTotal>(entity =>
        {
            entity.Property(e => e.BtblTmtaxTotalsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvApaccountsFull>(entity =>
        {
            entity.ToView("_bvAPAccountsFull");

            entity.Property(e => e.VendorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvAptransactionsFull>(entity =>
        {
            entity.ToView("_bvAPTransactionsFull");

            entity.Property(e => e.PostApChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvAraccountsFull>(entity =>
        {
            entity.ToView("_bvARAccountsFull");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvArauditLinkedAccRep>(entity =>
        {
            entity.ToView("_bvARAuditLinkedAccRep");
        });

        modelBuilder.Entity<BvArtransactionsFull>(entity =>
        {
            entity.ToView("_bvARTransactionsFull");

            entity.Property(e => e.PostArChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvBomcompStock>(entity =>
        {
            entity.ToView("_bvBOMCompStock");

            entity.Property(e => e.BomCompChecksum).IsFixedLength();
            entity.Property(e => e.BomMastChecksum).IsFixedLength();
            entity.Property(e => e.BtblBinlocationChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvBomstock>(entity =>
        {
            entity.ToView("_bvBOMStock");

            entity.Property(e => e.BomMastChecksum).IsFixedLength();
            entity.Property(e => e.BtblBinlocationChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCapexBudgetAndAssetForCostCentre>(entity =>
        {
            entity.ToView("_bvCapexBudgetAndAssetForCostCentre");
        });

        modelBuilder.Entity<BvCashbookLine>(entity =>
        {
            entity.ToView("_bvCashbookLines");

            entity.Property(e => e.BtblCbBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCcclient>(entity =>
        {
            entity.ToView("_bvCCClients");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.Dclink).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvCccustomer>(entity =>
        {
            entity.ToView("_bvCCCustomer");
        });

        modelBuilder.Entity<BvCcmanagement>(entity =>
        {
            entity.ToView("_bvCCManagement");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.Dclink).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvCcreminder>(entity =>
        {
            entity.ToView("_bvCCReminder");

            entity.Property(e => e.Autoidx).ValueGeneratedOnAdd();
            entity.Property(e => e.ReminderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCcreminderType>(entity =>
        {
            entity.ToView("_bvCCReminderType");

            entity.Property(e => e.Autoidx).ValueGeneratedOnAdd();
            entity.Property(e => e.CredMntChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCmcontractTxFull>(entity =>
        {
            entity.ToView("_bvCMContractTxFull");
        });

        modelBuilder.Entity<BvCmcontractsFull>(entity =>
        {
            entity.ToView("_bvCMContractsFull");

            entity.Property(e => e.RtblContractsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCmcustomerFull>(entity =>
        {
            entity.ToView("_bvCMCustomerFull");
        });

        modelBuilder.Entity<BvCmcustomerInventory>(entity =>
        {
            entity.ToView("_bvCMCustomerInventory");
        });

        modelBuilder.Entity<BvCmdocumentFull>(entity =>
        {
            entity.ToView("_bvCMDocumentFull");

            entity.Property(e => e.RtblDocStoreChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCmeventAttendee>(entity =>
        {
            entity.ToView("_bvCMEventAttendees");

            entity.Property(e => e.BtblCmeventAttendeesChecksum).IsFixedLength();
            entity.Property(e => e.BtblCmeventChecksum).IsFixedLength();
            entity.Property(e => e.CAttendeeType).IsFixedLength();
        });

        modelBuilder.Entity<BvCmgroupAgent>(entity =>
        {
            entity.ToView("_bvCMGroupAgents");
        });

        modelBuilder.Entity<BvCmitgrpMember>(entity =>
        {
            entity.ToView("_bvCMITGrpMembers");

            entity.Property(e => e.RtblIncidentTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvCmstockFull>(entity =>
        {
            entity.ToView("_bvCMStockFull");

            entity.Property(e => e.ItemId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvCmworkflowMember>(entity =>
        {
            entity.ToView("_bvCMWorkflowMembers");

            entity.Property(e => e.BtblCmworkflowMembersChecksum).IsFixedLength();
            entity.Property(e => e.CAgentType).IsFixedLength();
        });

        modelBuilder.Entity<BvCurrencyRevaluation>(entity =>
        {
            entity.ToView("_bvCurrencyRevaluation");

            entity.Property(e => e.EtblRevaluationHistoryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvDmRowAp>(entity =>
        {
            entity.ToView("_bvDmRowAP");
        });

        modelBuilder.Entity<BvDmRowAr>(entity =>
        {
            entity.ToView("_bvDmRowAR");
        });

        modelBuilder.Entity<BvDmcolAp>(entity =>
        {
            entity.ToView("_bvDMColAP");
        });

        modelBuilder.Entity<BvDmcolAr>(entity =>
        {
            entity.ToView("_bvDMColAR");
        });

        modelBuilder.Entity<BvEntitiesFull>(entity =>
        {
            entity.ToView("_bvEntitiesFull");

            entity.Property(e => e.EntitiesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFaactiveCostCenter>(entity =>
        {
            entity.ToView("_bvFAActiveCostCenters");

            entity.Property(e => e.CostCntrChecksum).IsFixedLength();
            entity.Property(e => e.Counter).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvFaasset>(entity =>
        {
            entity.ToView("_bvFAAsset");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetBlock>(entity =>
        {
            entity.ToView("_bvFAAssetBlock");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetLookupForBlock>(entity =>
        {
            entity.ToView("_bvFAAssetLookupForBlock");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetRevaluation>(entity =>
        {
            entity.ToView("_bvFAAssetRevaluation");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetTakeOn>(entity =>
        {
            entity.ToView("_bvFAAssetTakeOn");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetTracking>(entity =>
        {
            entity.ToView("_bvFAAssetTracking");

            entity.Property(e => e.BtblFaassetTrackingChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetTrackingFull>(entity =>
        {
            entity.ToView("_bvFAAssetTrackingFull");
        });

        modelBuilder.Entity<BvFaassetTypeLookupDepr>(entity =>
        {
            entity.ToView("_bvFAAssetTypeLookupDepr");

            entity.Property(e => e.BtblFaassetTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFaassetUnit>(entity =>
        {
            entity.ToView("_bvFAAssetUnits");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFacapexBudget>(entity =>
        {
            entity.ToView("_bvFACapexBudget");

            entity.Property(e => e.BtblFacapexBudgetChecksum).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFacapexCashFlow>(entity =>
        {
            entity.ToView("_bvFACapexCashFlow");

            entity.Property(e => e.CBasisInd).IsFixedLength();
            entity.Property(e => e.NewInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFacapexOderBudgetLookup>(entity =>
        {
            entity.ToView("_bvFACapexOderBudgetLookup");

            entity.Property(e => e.BtblFacapexOrderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFacapexOrder>(entity =>
        {
            entity.ToView("_bvFACapexOrder");

            entity.Property(e => e.NewInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFacapexPhasing>(entity =>
        {
            entity.ToView("_bvFACapexPhasing");

            entity.Property(e => e.NewInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFacapexSummary>(entity =>
        {
            entity.ToView("_bvFACapexSummary");

            entity.Property(e => e.CBasisInd).IsFixedLength();
            entity.Property(e => e.NewInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFacostCenterDepartmentLookup>(entity =>
        {
            entity.ToView("_bvFACostCenterDepartmentLookup");

            entity.Property(e => e.CostCntrChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFacurrentAsset>(entity =>
        {
            entity.ToView("_bvFACurrentAsset");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFacurrentAssetUnit>(entity =>
        {
            entity.ToView("_bvFACurrentAssetUnits");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFacurrentUnsoldAsset>(entity =>
        {
            entity.ToView("_bvFACurrentUnsoldAsset");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFadepreciationMethod>(entity =>
        {
            entity.ToView("_bvFADepreciationMethod");

            entity.Property(e => e.CBasisInd).IsFixedLength();
            entity.Property(e => e.CSystemInd).IsFixedLength();
            entity.Property(e => e.IdDepreciationNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvFadepreciationMethodYear>(entity =>
        {
            entity.ToView("_bvFADepreciationMethodYears");

            entity.Property(e => e.CBasisInd).IsFixedLength();
            entity.Property(e => e.CSystemInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFaendDate>(entity =>
        {
            entity.ToView("_bvFAEndDate");
        });

        modelBuilder.Entity<BvFaglbatch>(entity =>
        {
            entity.ToView("_bvFAGLBatch");
        });

        modelBuilder.Entity<BvFaglperiod>(entity =>
        {
            entity.ToView("_bvFAGLPeriod");

            entity.Property(e => e.IdGlperiodNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvFainitialAllowancePerc>(entity =>
        {
            entity.ToView("_bvFAInitialAllowancePerc");
        });

        modelBuilder.Entity<BvFamasterAsset>(entity =>
        {
            entity.ToView("_bvFAMasterAsset");

            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.IdAssetNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvFamovement>(entity =>
        {
            entity.ToView("_bvFAMovement");

            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.RtblPeopleChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFamovementDate>(entity =>
        {
            entity.ToView("_bvFAMovementDate");

            entity.Property(e => e.BtblFamovementTransactionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFaoverrideAsset>(entity =>
        {
            entity.ToView("_bvFAOverrideAssets");

            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.BtblFaassetTypeChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFarepAssetType>(entity =>
        {
            entity.ToView("_bvFARepAssetType");

            entity.Property(e => e.BookBasisInd).IsFixedLength();
            entity.Property(e => e.TaxBasisInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFarevaluedAsset>(entity =>
        {
            entity.ToView("_bvFARevaluedAsset");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFatakeOnBalancesForPeriod>(entity =>
        {
            entity.ToView("_bvFATakeOnBalancesForPeriod");
        });

        modelBuilder.Entity<BvFatakeOnDate>(entity =>
        {
            entity.ToView("_bvFATakeOnDate");

            entity.Property(e => e.BtblFaglperiodChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvFatransferredAsset>(entity =>
        {
            entity.ToView("_bvFATransferredAsset");

            entity.Property(e => e.BookBasis).IsFixedLength();
            entity.Property(e => e.BtblFaassetChecksum).IsFixedLength();
            entity.Property(e => e.CCurrentInd).IsFixedLength();
            entity.Property(e => e.CReplacementNewInd).IsFixedLength();
            entity.Property(e => e.CTransferInd).IsFixedLength();
            entity.Property(e => e.TaxBasis).IsFixedLength();
        });

        modelBuilder.Entity<BvFaunitsUsed>(entity =>
        {
            entity.ToView("_bvFAUnitsUsed");
        });

        modelBuilder.Entity<BvFauu>(entity =>
        {
            entity.ToView("_bvFAUU");

            entity.Property(e => e.CDeprTypeInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFauudate>(entity =>
        {
            entity.ToView("_bvFAUUDate");

            entity.Property(e => e.BtblFaassetUnitsOfUsageChecksum).IsFixedLength();
            entity.Property(e => e.CDeprTypeInd).IsFixedLength();
        });

        modelBuilder.Entity<BvFiscalCopySale>(entity =>
        {
            entity.ToView("_bvFiscalCopySale");
        });

        modelBuilder.Entity<BvFiscalInspurDatum>(entity =>
        {
            entity.ToView("_bvFiscalInspurData");
        });

        modelBuilder.Entity<BvFiscalNormalSale>(entity =>
        {
            entity.ToView("_bvFiscalNormalSale");
        });

        modelBuilder.Entity<BvGlaccountsFinancial>(entity =>
        {
            entity.ToView("_bvGLAccountsFinancial");

            entity.Property(e => e.AccountsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvGlperiodsFull>(entity =>
        {
            entity.ToView("_bvGLPeriodsFull");

            entity.Property(e => e.EtblPeriodChecksum).IsFixedLength();
            entity.Property(e => e.EtblPeriodYearChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvGltransactionsFull>(entity =>
        {
            entity.ToView("_bvGLTransactionsFull");

            entity.Property(e => e.PostGlChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvGltransactionsHistFull>(entity =>
        {
            entity.ToView("_bvGLTransactionsHistFull");

            entity.Property(e => e.EtblPostGlhistChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvAdditionalChargesFull>(entity =>
        {
            entity.ToView("_bvInvAdditionalChargesFull");

            entity.Property(e => e.EtblAdditionalInvoiceChargesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvCountLine>(entity =>
        {
            entity.ToView("_bvInvCountLines");

            entity.Property(e => e.BtblInvCountLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvCountVarianceListing>(entity =>
        {
            entity.ToView("_bvInvCountVarianceListing");

            entity.Property(e => e.BtblInvCountLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvLinesFull>(entity =>
        {
            entity.ToView("_bvInvLinesFull");

            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvNumApfull>(entity =>
        {
            entity.ToView("_bvInvNumAPFull");

            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.VendorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvNumAplookupDatum>(entity =>
        {
            entity.ToView("_bvInvNumAPLookupData");
        });

        modelBuilder.Entity<BvInvNumArap>(entity =>
        {
            entity.ToView("_bvInvNumARAP");

            entity.Property(e => e.InvNumChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvNumArfull>(entity =>
        {
            entity.ToView("_bvInvNumARFull");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvInvNumArlookupDatum>(entity =>
        {
            entity.ToView("_bvInvNumARLookupData");
        });

        modelBuilder.Entity<BvJcdocPrint>(entity =>
        {
            entity.ToView("_bvJCDocPrint");
        });

        modelBuilder.Entity<BvJcdocPrintPslip>(entity =>
        {
            entity.ToView("_bvJCDocPrintPSlip");
        });

        modelBuilder.Entity<BvJcinvoiceLinesFull>(entity =>
        {
            entity.ToView("_bvJCInvoiceLinesFull");

            entity.Property(e => e.BtblJcinvoiceLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvJcmasterFull>(entity =>
        {
            entity.ToView("_bvJCMasterFull");

            entity.Property(e => e.BtblJcmasterChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvJctxLinesFull>(entity =>
        {
            entity.ToView("_bvJCTxLinesFull");

            entity.Property(e => e.BtblJctxLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvJobNumFull>(entity =>
        {
            entity.ToView("_bvJobNumFull");

            entity.Property(e => e.JobNumChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvJobStockFull>(entity =>
        {
            entity.ToView("_bvJobStockFull");

            entity.Property(e => e.JobStockChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvJobTotal>(entity =>
        {
            entity.ToView("_bvJobTotals");
        });

        modelBuilder.Entity<BvKeepAsidesFull>(entity =>
        {
            entity.ToView("_bvKeepAsidesFull");

            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvNote>(entity =>
        {
            entity.ToView("_bvNotes");
        });

        modelBuilder.Entity<BvPosTillsFull>(entity =>
        {
            entity.ToView("_bvPosTillsFull");

            entity.Property(e => e.TillsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvPosxztenderTxFull>(entity =>
        {
            entity.ToView("_bvPOSXZTenderTxFull");

            entity.Property(e => e.BtblPostenderTxChecksum).IsFixedLength();
            entity.Property(e => e.BtblPosxztableChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvPurchaseOrdersFull>(entity =>
        {
            entity.ToView("_bvPurchaseOrdersFull");

            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
            entity.Property(e => e.VendorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvQuotesFull>(entity =>
        {
            entity.ToView("_bvQuotesFull");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvQuotesLine>(entity =>
        {
            entity.ToView("_bvQuotesLines");

            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvRecurRevApfixed>(entity =>
        {
            entity.ToView("_bvRecurRevAPFixed");

            entity.Property(e => e.RecurRfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvRecurRevApfull>(entity =>
        {
            entity.ToView("_bvRecurRevAPFull");
        });

        modelBuilder.Entity<BvRecurRevArfixed>(entity =>
        {
            entity.ToView("_bvRecurRevARFixed");

            entity.Property(e => e.RecurRfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvRecurRevArfull>(entity =>
        {
            entity.ToView("_bvRecurRevARFull");
        });

        modelBuilder.Entity<BvRecurrTransFull>(entity =>
        {
            entity.ToView("_bvRecurrTransFull");
        });

        modelBuilder.Entity<BvRecurrTransFullWithTx>(entity =>
        {
            entity.ToView("_bvRecurrTransFullWithTx");
        });

        modelBuilder.Entity<BvRepArtransaction>(entity =>
        {
            entity.ToView("_bvRepARTransactions");

            entity.Property(e => e.SalesRepChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvRepTransactionsFull>(entity =>
        {
            entity.ToView("_bvRepTransactionsFull");
        });

        modelBuilder.Entity<BvRepTransactionsPaid>(entity =>
        {
            entity.ToView("_bvRepTransactionsPaid");
        });

        modelBuilder.Entity<BvSalesOrdersFull>(entity =>
        {
            entity.ToView("_bvSalesOrdersFull");

            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvSalesOrdersManufFull>(entity =>
        {
            entity.ToView("_bvSalesOrdersManufFull");

            entity.Property(e => e.BomMastChecksum).IsFixedLength();
            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.EtblManufProcessChecksum).IsFixedLength();
            entity.Property(e => e.IStatus).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.ManufStatus).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvSerialMasterFull>(entity =>
        {
            entity.ToView("_bvSerialMasterFull");

            entity.Property(e => e.SerialMfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvSerialNumberLink>(entity =>
        {
            entity.ToView("_bvSerialNumberLink");

            entity.Property(e => e.BtblSerialNumberLinkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvSerialNumbersFull>(entity =>
        {
            entity.ToView("_bvSerialNumbersFull");

            entity.Property(e => e.SerialMfChecksum).IsFixedLength();
            entity.Property(e => e.SerialTxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvStockAndWhseItem>(entity =>
        {
            entity.ToView("_bvStockAndWhseItems");
        });

        modelBuilder.Entity<BvStockAndWhseItemsExPl>(entity =>
        {
            entity.ToView("_bvStockAndWhseItemsExPL");
        });

        modelBuilder.Entity<BvStockFull>(entity =>
        {
            entity.ToView("_bvStockFull");

            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvStockFullExPl>(entity =>
        {
            entity.ToView("_bvStockFullExPL");

            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvStockGroup>(entity =>
        {
            entity.ToView("_bvStockGroups");

            entity.Property(e => e.GrpTblChecksum).IsFixedLength();
            entity.Property(e => e.IdGrpTbl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvStockItemsAndPromotionId>(entity =>
        {
            entity.ToView("_bvStockItemsAndPromotionID");

            entity.Property(e => e.StkItemChecksum).IsFixedLength();
            entity.Property(e => e.StockLink).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BvStockWhseLotItem>(entity =>
        {
            entity.ToView("_bvStockWhseLotItems");
        });

        modelBuilder.Entity<BvStockWhseLotItemsExPl>(entity =>
        {
            entity.ToView("_bvStockWhseLotItemsExPL");
        });

        modelBuilder.Entity<BvSttransactionsFull>(entity =>
        {
            entity.ToView("_bvSTTransactionsFull");

            entity.Property(e => e.PostStChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvSttransactionsPivot>(entity =>
        {
            entity.ToView("_bvSTTransactionsPivot");
        });

        modelBuilder.Entity<BvSttransactionsPivotFull>(entity =>
        {
            entity.ToView("_bvSTTransactionsPivotFull");
        });

        modelBuilder.Entity<BvSttransactionsPivotLinked>(entity =>
        {
            entity.ToView("_bvSTTransactionsPivotLinked");
        });

        modelBuilder.Entity<BvTrCodesAp>(entity =>
        {
            entity.ToView("_bvTrCodesAP");

            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvTrCodesAr>(entity =>
        {
            entity.ToView("_bvTrCodesAR");

            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvTrCodesGl>(entity =>
        {
            entity.ToView("_bvTrCodesGL");

            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvTrCodesI>(entity =>
        {
            entity.ToView("_bvTrCodesI");

            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvTrCodesJc>(entity =>
        {
            entity.ToView("_bvTrCodesJC");

            entity.Property(e => e.JobTxTpChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvTrCodesPo>(entity =>
        {
            entity.ToView("_bvTrCodesPOS");

            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvVolumeDiscountAp>(entity =>
        {
            entity.ToView("_bvVolumeDiscountAP");

            entity.Property(e => e.EtblVdapChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvVolumeDiscountAr>(entity =>
        {
            entity.ToView("_bvVolumeDiscountAR");

            entity.Property(e => e.EtblVdarChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvVolumeDiscountLinesAp>(entity =>
        {
            entity.ToView("_bvVolumeDiscountLinesAP");

            entity.Property(e => e.EtblVdlnApChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvVolumeDiscountLinesAr>(entity =>
        {
            entity.ToView("_bvVolumeDiscountLinesAR");

            entity.Property(e => e.EtblVdlnArChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvWarehouseFull>(entity =>
        {
            entity.ToView("_bvWarehouseFull");

            entity.Property(e => e.WhseMstChecksum).IsFixedLength();
            entity.Property(e => e.WhseStkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<BvWarehouseStockFull>(entity =>
        {
            entity.ToView("_bvWarehouseStockFull");
        });

        modelBuilder.Entity<BvWhseMst>(entity =>
        {
            entity.ToView("_bvWhseMst");

            entity.Property(e => e.WhseMstChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Ccdef>(entity =>
        {
            entity.HasKey(e => e.IdCcdefs).HasName("PK_CCDEFS");

            entity.Property(e => e.CcdefsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Ccdetail>(entity =>
        {
            entity.HasKey(e => e.DebtorLink)
                .HasName("PK_CCDETAIL")
                .IsClustered(false);

            entity.Property(e => e.DebtorLink).ValueGeneratedNever();
            entity.Property(e => e.BankCode).HasDefaultValue((short)8);
            entity.Property(e => e.BankRd).HasDefaultValue(false);
            entity.Property(e => e.CcdetailChecksum).IsFixedLength();
            entity.Property(e => e.Granted).HasDefaultValue(false);
        });

        modelBuilder.Entity<CliClass>(entity =>
        {
            entity.HasKey(e => e.IdCliClass).HasName("PK_CLICLASS");

            entity.Property(e => e.CliClassChecksum).IsFixedLength();
        });

        modelBuilder.Entity<CliDef>(entity =>
        {
            entity.Property(e => e.BForceAuthorisedBy).HasDefaultValue(false);
            entity.Property(e => e.BForceClaimNumber).HasDefaultValue(false);
            entity.Property(e => e.BForceExcessAccCont1).HasDefaultValue(false);
            entity.Property(e => e.BForceExcessAccCont2).HasDefaultValue(false);
            entity.Property(e => e.BForceExcessAccName).HasDefaultValue(false);
            entity.Property(e => e.BForceIncidentDate).HasDefaultValue(false);
            entity.Property(e => e.BForcePolicyNumber).HasDefaultValue(false);
            entity.Property(e => e.BUseAllocStoredProc).HasDefaultValue(true);
            entity.Property(e => e.BUseInsurance).HasDefaultValue(false);
            entity.Property(e => e.CliDefChecksum).IsFixedLength();
            entity.Property(e => e.FilterStartLength).HasDefaultValue(0);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Dclink).HasName("PK_CLIENT");

            entity.HasIndex(e => e.Account, "idxAccount").HasFillFactor(90);

            entity.HasIndex(e => e.Name, "idxName").HasFillFactor(90);

            entity.HasIndex(e => e.IAreasId, "idx_CLIENT_iAreasID").HasFillFactor(90);

            entity.HasIndex(e => e.IClassId, "idx_CLIENT_iClassID").HasFillFactor(90);

            entity.Property(e => e.BInsuranceCustomer).HasDefaultValue(false);
            entity.Property(e => e.BSourceDocPrint).HasDefaultValue(true);
            entity.Property(e => e.BTaxPrompt).HasDefaultValue(true);
            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.Ct).HasDefaultValue(true);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.AutoIdx)
                .HasName("PK_CONTACT")
                .IsClustered(false);

            entity.HasIndex(e => e.DebtorLink, "idxDebtorLink").HasFillFactor(90);

            entity.Property(e => e.ContactChecksum).IsFixedLength();
            entity.Property(e => e.Time)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Cost>(entity =>
        {
            entity.HasKey(e => e.Autoidx)
                .HasName("PK_COST")
                .IsClustered(false);

            entity.HasIndex(e => e.DebtorAccNo, "idxAccNo").HasFillFactor(90);

            entity.Property(e => e.CostChecksum).IsFixedLength();
        });

        modelBuilder.Entity<CostCntr>(entity =>
        {
            entity.HasKey(e => e.Counter)
                .HasName("PK_COSTCNTR")
                .IsClustered(false);

            entity.HasIndex(e => e.CostCode, "idxCostCode").HasFillFactor(90);

            entity.Property(e => e.CostCntrChecksum).IsFixedLength();
        });

        modelBuilder.Entity<CrDiscHd>(entity =>
        {
            entity.HasKey(e => e.IdCrDiscHd).HasName("PK_CRDISCHD");

            entity.Property(e => e.CrDiscHdChecksum).IsFixedLength();
        });

        modelBuilder.Entity<CrDiscMx>(entity =>
        {
            entity.HasKey(e => e.IdCrDiscMx).HasName("PK_CRDISCMX");

            entity.Property(e => e.CrDiscMxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<CredApp>(entity =>
        {
            entity.HasKey(e => e.Autoidx)
                .HasName("PK_CREDAPP")
                .IsClustered(false);

            entity.HasIndex(e => new { e.AccountNo, e.ApplicationDate }, "idxAccount").HasFillFactor(90);

            entity.HasIndex(e => new { e.CompanyName, e.ApplicationDate }, "idxName").HasFillFactor(90);

            entity.Property(e => e.ApplicationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.BankRd).HasDefaultValue(false);
            entity.Property(e => e.CredAppChecksum).IsFixedLength();
            entity.Property(e => e.DateGranted).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Granted).HasDefaultValue((short)0);
            entity.Property(e => e.International).HasDefaultValue(false);
            entity.Property(e => e.Judgement).HasDefaultValue(false);
            entity.Property(e => e.LatestFinan).HasDefaultValue(false);
            entity.Property(e => e.OwnerList).HasDefaultValue("8");
            entity.Property(e => e.SameOwner).HasDefaultValue(false);
            entity.Property(e => e.Terms).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<CredMnt>(entity =>
        {
            entity.HasKey(e => e.Autoidx)
                .HasName("PK_CREDMNT")
                .IsClustered(false);

            entity.HasIndex(e => new { e.Category, e.Description }, "idxDesc").HasFillFactor(90);

            entity.Property(e => e.CredMntChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyLink)
                .HasName("PK_CURRENCY")
                .IsClustered(false);

            entity.HasIndex(e => e.CurrencyCode, "idxCurrencyCode").HasFillFactor(90);

            entity.Property(e => e.CurrencyChecksum).IsFixedLength();
        });

        modelBuilder.Entity<CurrencyHist>(entity =>
        {
            entity.Property(e => e.CurrencyHistChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Cwratio>(entity =>
        {
            entity.HasKey(e => e.IdCwRatio).HasName("PK_CWRATIO");

            entity.Property(e => e.CwratioChecksum).IsFixedLength();
        });

        modelBuilder.Entity<DelTbl>(entity =>
        {
            entity.HasKey(e => e.Counter).HasName("PK_DELTBL");

            entity.HasIndex(e => e.Counter, "idxCounter").HasFillFactor(90);

            entity.Property(e => e.BForDelivery).HasDefaultValue(true);
            entity.Property(e => e.DelTblChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.IdDept)
                .HasName("PK_DEPT")
                .IsClustered(false);

            entity.Property(e => e.DeptChecksum).IsFixedLength();
        });

        modelBuilder.Entity<DrDiscHd>(entity =>
        {
            entity.HasKey(e => e.IdDrDiscHd).HasName("PK_DRDISCHD");

            entity.Property(e => e.DrDiscHdChecksum).IsFixedLength();
        });

        modelBuilder.Entity<DrDiscMx>(entity =>
        {
            entity.HasKey(e => e.IdDrDiscMx).HasName("PK_DRDISCMX");

            entity.Property(e => e.DrDiscMxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity.HasKey(e => e.IdEntities)
                .HasName("PK_Entities_idEntities")
                .IsClustered(false);

            entity.Property(e => e.BSingleEntityReporting).HasDefaultValue(true);
            entity.Property(e => e.EntitiesChecksum).IsFixedLength();
            entity.Property(e => e.IBinPort).HasDefaultValue(12000);
            entity.Property(e => e.ShowInactiveGl).HasDefaultValue(true);
            entity.Property(e => e.ShowInactiveProjects).HasDefaultValue(true);
        });

        modelBuilder.Entity<EtblAccBlnc>(entity =>
        {
            entity.Property(e => e.EtblAccBlncChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAccPrev>(entity =>
        {
            entity.Property(e => e.EtblAccPrevChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAddInRegister>(entity =>
        {
            entity.HasKey(e => e.IdAddIn).HasName("PK__etblAddInRegister_idAddIn");

            entity.Property(e => e.EtblAddinRegisterChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAdditionalCharge>(entity =>
        {
            entity.Property(e => e.EtblAdditionalChargesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAdditionalChargeSetting>(entity =>
        {
            entity.Property(e => e.EtblAdditionalChargeSettingsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAdditionalInvoiceCharge>(entity =>
        {
            entity.Property(e => e.EtblAdditionalInvoiceChargesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAgentDocProfile>(entity =>
        {
            entity.Property(e => e.EtblAgentDocProfilesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAgentPwdHistory>(entity =>
        {
            entity.Property(e => e.EtblAgentPwdHistoryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAllocTemp>(entity =>
        {
            entity.Property(e => e.TmpLineId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EtblAllocsDclinkRangeTemp>(entity =>
        {
            entity.Property(e => e.Dclink).ValueGeneratedNever();
        });

        modelBuilder.Entity<EtblAllocsTemp>(entity =>
        {
            entity.HasIndex(e => e.IAccountId, "idxallocstemp_accountid").HasFillFactor(90);
        });

        modelBuilder.Entity<EtblApshareholder>(entity =>
        {
            entity.Property(e => e.BDisabled).HasDefaultValue(false);
            entity.Property(e => e.BYouth).HasDefaultValue(false);
            entity.Property(e => e.EtblApshareholdersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblApshareholderLink>(entity =>
        {
            entity.Property(e => e.BDirector).HasDefaultValue(false);
            entity.Property(e => e.EtblApshareholderLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArapbatch>(entity =>
        {
            entity.Property(e => e.BEnterExclOnGlContraSplit).HasDefaultValue(true);
            entity.Property(e => e.BModuleAp).HasDefaultValue(true);
            entity.Property(e => e.BModuleAr).HasDefaultValue(true);
            entity.Property(e => e.BModuleGl).HasDefaultValue(true);
            entity.Property(e => e.BValidateOverLimit).HasDefaultValue(true);
            entity.Property(e => e.BValidateOverTerms).HasDefaultValue(true);
            entity.Property(e => e.EtblArapbatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArapbatchContraSplit>(entity =>
        {
            entity.Property(e => e.EtblArapbatchContraSplitChecksum).IsFixedLength();
            entity.Property(e => e.FAmountIncl).HasDefaultValue(0.0);
            entity.Property(e => e.FAmountInclForeign).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EtblArapbatchContraSplitHistory>(entity =>
        {
            entity.Property(e => e.EtblArapbatchContraSplitHistoryChecksum).IsFixedLength();
            entity.Property(e => e.FAmountInclForeign).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EtblArapbatchDefault>(entity =>
        {
            entity.Property(e => e.EtblArapbatchDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArapbatchHistory>(entity =>
        {
            entity.Property(e => e.EtblArapbatchHistoryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArapbatchHistoryLine>(entity =>
        {
            entity.Property(e => e.EtblArapbatchHistoryLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArapbatchLine>(entity =>
        {
            entity.Property(e => e.EtblArapbatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArapbatchSettDiscLine>(entity =>
        {
            entity.Property(e => e.EtblArapbatchSettDiscLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArstatement>(entity =>
        {
            entity.Property(e => e.EtblArstatementsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArstatementRun>(entity =>
        {
            entity.Property(e => e.EtblArstatementRunChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblArstatementRunOption>(entity =>
        {
            entity.Property(e => e.EtblArstatementRunOptionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAutoLevelUpdateItem>(entity =>
        {
            entity.Property(e => e.BUseAveragePerDay).HasDefaultValue(true);
            entity.Property(e => e.CItemType).IsFixedLength();
            entity.Property(e => e.EtblAutoLevelUpdateItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblAutoString>(entity =>
        {
            entity.Property(e => e.BPublic).HasDefaultValue(true);
            entity.Property(e => e.EtblAutoStringsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblBankDetail>(entity =>
        {
            entity.HasKey(e => e.IdBankDetail).HasName("PK_idBankDetail");

            entity.Property(e => e.EtblBankDetailsChecksum).IsFixedLength();
            entity.Property(e => e.IEftsautoNumPadLength).HasDefaultValue(3);
        });

        modelBuilder.Entity<EtblBatchPermission>(entity =>
        {
            entity.Property(e => e.BBatchVisible).HasDefaultValue(true);
            entity.Property(e => e.CAgentType).HasDefaultValue("A");
            entity.Property(e => e.CBatchType).HasDefaultValue("C");
            entity.Property(e => e.DDatePermissionCreated).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EtblBatchPermissionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblBranch>(entity =>
        {
            entity.HasKey(e => e.IdBranch).IsClustered(false);

            entity.Property(e => e.BBranchActive).HasDefaultValue(true);
            entity.Property(e => e.BSyncEnabled).HasDefaultValue(true);
            entity.Property(e => e.EtblBranchChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblBudget>(entity =>
        {
            entity.Property(e => e.EtblBudgetsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblBudgetsPrev>(entity =>
        {
            entity.Property(e => e.EtblBudgetsPrevChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblCmagentContact>(entity =>
        {
            entity.HasIndex(e => e.IAgentId, "IDX__etblCMAgentContact_iAgentID").HasFillFactor(90);

            entity.Property(e => e.CContactType).IsFixedLength();
            entity.Property(e => e.EtblCmagentContactChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblCmrejectReason>(entity =>
        {
            entity.Property(e => e.EtblCmrejectReasonChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblDashboardLayout>(entity =>
        {
            entity.Property(e => e.EtblDashboardLayoutsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblDelAddress>(entity =>
        {
            entity.HasIndex(e => new { e.IAccountId, e.IDcmodule }, "idx_etblDelAddress_AccountID").HasFillFactor(90);

            entity.HasIndex(e => new { e.IDelAddressCodeId, e.IDcmodule }, "idx_etblDelAddress_iDelAddressCodeID").HasFillFactor(90);

            entity.Property(e => e.EtblDelAddressChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblDelAddressCode>(entity =>
        {
            entity.Property(e => e.EtblDelAddressCodeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblDeleted>(entity =>
        {
            entity.HasKey(e => e.IdDeleted).IsClustered(false);

            entity.Property(e => e.KeyFieldsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblDocCat>(entity =>
        {
            entity.HasKey(e => e.IdDocCat).IsClustered(false);

            entity.Property(e => e.EtblDocCatChecksum).IsFixedLength();
            entity.Property(e => e.IDocCatGroupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblDocCatGroup>(entity =>
        {
            entity.HasKey(e => e.IdDocCatGroup).IsClustered(false);

            entity.Property(e => e.EtblDocCatGroupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblDocProfile>(entity =>
        {
            entity.Property(e => e.BAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BUniqueNum).HasDefaultValue(false);
            entity.Property(e => e.EtblDocProfilesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEftgatewayType>(entity =>
        {
            entity.HasKey(e => e.GatewayId)
                .HasName("PK__etblEFtGatewayType")
                .IsClustered(false);

            entity.Property(e => e.EtblEftgatewayTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEftreference>(entity =>
        {
            entity.HasKey(e => e.IdNumber).IsClustered(false);

            entity.Property(e => e.EtblEftreferenceChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEftsfileLayout>(entity =>
        {
            entity.Property(e => e.BSystemLayout).HasDefaultValue(true);
            entity.Property(e => e.EtblEftsfileLayoutChecksum).IsFixedLength();
            entity.Property(e => e.ISourceLayoutId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblEftsfileLayoutDetail>(entity =>
        {
            entity.Property(e => e.BFieldInUse).HasDefaultValue(true);
            entity.Property(e => e.EtblEftsfileLayoutDetailsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEucommodity>(entity =>
        {
            entity.Property(e => e.EtblEucommodityChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEucountry>(entity =>
        {
            entity.Property(e => e.EtblEucountryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEunoTc>(entity =>
        {
            entity.Property(e => e.EtblEunoTcChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblEusupplementaryUnit>(entity =>
        {
            entity.Property(e => e.EtblEusupplementaryUnitChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblFiscalDatum>(entity =>
        {
            entity.HasKey(e => e.IdFiscalData)
                .HasName("PK___etblFiscalData")
                .IsClustered(false);

            entity.Property(e => e.EtblFiscalDataChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblFiscalPrinter>(entity =>
        {
            entity.HasKey(e => e.IFiscalPrinterId).HasName("_etblFiscalPrinters_pk");

            entity.Property(e => e.EtblFiscalPrintersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblFiscalPrinterModel>(entity =>
        {
            entity.HasKey(e => e.IFiscalPrinterModelsId).HasName("_etblFiscalPrinterModels_pk");

            entity.Property(e => e.BAllowAlphaNumDoc).HasDefaultValue(true);
            entity.Property(e => e.BIsPrinter).HasDefaultValue(true);
            entity.Property(e => e.EtblFiscalPrinterModelsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlaccountType>(entity =>
        {
            entity.Property(e => e.IdGlaccountType).ValueGeneratedNever();
            entity.Property(e => e.BIsBalanceSheet).HasDefaultValue(true);
            entity.Property(e => e.BIsDebit).HasDefaultValue(true);
            entity.Property(e => e.EtblGlaccountTypesChecksum).IsFixedLength();
            entity.Property(e => e.IReportingGroup).HasDefaultValue(1);
            entity.Property(e => e.IReportingGroupSort).HasDefaultValue(1);
        });

        modelBuilder.Entity<EtblGlloanAccountLink>(entity =>
        {
            entity.Property(e => e.EtblGlloanAccountLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlmScoaaccount>(entity =>
        {
            entity.Property(e => e.BPostingLevel).HasDefaultValue(true);
            entity.Property(e => e.EtblGlmScoaaccountsChecksum).IsFixedLength();
            entity.Property(e => e.Mscoacheck).IsFixedLength();
            entity.Property(e => e.NextSubAccountNumber).HasDefaultValue(1);
        });

        modelBuilder.Entity<EtblGlmScoaglaccVerLink>(entity =>
        {
            entity.Property(e => e.EtblGlmScoaglaccVerLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlmScoaversion>(entity =>
        {
            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.EtblGlmScoaversionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlreportCategory>(entity =>
        {
            entity.Property(e => e.EtblGlreportCategoryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlreviseBudget>(entity =>
        {
            entity.HasIndex(e => new { e.IGlaccountId, e.IProjectId, e.IPeriod }, "idx_etblGLReviseBudget_iGLAccountID_iProjectID_iPeriod").HasFillFactor(90);

            entity.Property(e => e.EtblGlreviseBudgetChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlreviseBudgetPrev>(entity =>
        {
            entity.Property(e => e.EtblGlreviseBudgetPrevChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlsegment>(entity =>
        {
            entity.HasIndex(e => e.ISegmentNo, "idx__etblGLSegment_iSegmentNo").HasFillFactor(90);

            entity.Property(e => e.EtblGlsegmentChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGlsegmentSetup>(entity =>
        {
            entity.Property(e => e.IdSegmentNo).ValueGeneratedNever();
            entity.Property(e => e.BInUse).HasDefaultValue(true);
            entity.Property(e => e.EtblGlsegmentSetupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblGstprepayment>(entity =>
        {
            entity.Property(e => e.AllocTxDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EtblGstprepaymentsChecksum).IsFixedLength();
            entity.Property(e => e.TxDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<EtblImportDeclItem>(entity =>
        {
            entity.Property(e => e.EtblImportDeclItemsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblImportDeclItemsGllink>(entity =>
        {
            entity.Property(e => e.EtblImportDeclItemsGllinkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblImportDeclaration>(entity =>
        {
            entity.Property(e => e.EtblImportDeclarationChecksum).IsFixedLength();
            entity.Property(e => e.FExRate).HasDefaultValue(0.0);
            entity.Property(e => e.FForeignTotalAmount).HasDefaultValue(0.0);
            entity.Property(e => e.FGstamount).HasDefaultValue(0.0);
            entity.Property(e => e.FTaxAmount).HasDefaultValue(0.0);
            entity.Property(e => e.FTotalAmount).HasDefaultValue(0.0);
            entity.Property(e => e.ITaxRate).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EtblImportDeclarationLine>(entity =>
        {
            entity.Property(e => e.EtblImportDeclarationLineChecksum).IsFixedLength();
            entity.Property(e => e.FExRate).HasDefaultValue(0.0);
            entity.Property(e => e.FForeignTotalAmount).HasDefaultValue(0.0);
            entity.Property(e => e.FTotalAmount).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EtblIncidentSourceDocLink>(entity =>
        {
            entity.Property(e => e.EtblIncidentSourceDocLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInstructionType>(entity =>
        {
            entity.HasKey(e => e.IInstructionTypeId).IsClustered(false);

            entity.Property(e => e.EtblInstructionTypesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvImage>(entity =>
        {
            entity.HasKey(e => e.IdInvImage).HasName("PK_InvImages_id");

            entity.Property(e => e.EtblInvImagesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvJrBatch>(entity =>
        {
            entity.Property(e => e.BAllowDupRef).HasDefaultValue(true);
            entity.Property(e => e.BClearAfterPost).HasDefaultValue(true);
            entity.Property(e => e.EtblInvJrBatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvJrBatchLine>(entity =>
        {
            entity.HasKey(e => new { e.IdInvJrBatchLines, e.IInvJrBatchId }).IsClustered(false);

            entity.Property(e => e.IdInvJrBatchLines).ValueGeneratedOnAdd();
            entity.Property(e => e.EtblInvJrBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvJrBatchLineSn>(entity =>
        {
            entity.Property(e => e.EtblInvJrBatchLineSnChecksum).IsFixedLength();
            entity.Property(e => e.IdinvJrBatchLineSn).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EtblInvPriceUpdateBatch>(entity =>
        {
            entity.Property(e => e.BIgnoreInactive).HasDefaultValue(true);
            entity.Property(e => e.EtblInvPriceUpdateBatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvPriceUpdateBatchLine>(entity =>
        {
            entity.Property(e => e.EtblInvPriceUpdateBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvSegGroup>(entity =>
        {
            entity.Property(e => e.EtblInvSegGroupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvSegType>(entity =>
        {
            entity.Property(e => e.EtblInvSegTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvSegValue>(entity =>
        {
            entity.Property(e => e.EtblInvSegValueChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblInvoiceDeposit>(entity =>
        {
            entity.Property(e => e.EtblInvoiceDepositsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblLotStatus>(entity =>
        {
            entity.Property(e => e.BAllowPurchases).HasDefaultValue(true);
            entity.Property(e => e.BAllowSales).HasDefaultValue(true);
            entity.Property(e => e.EtblLotStatusChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblLotTracking>(entity =>
        {
            entity.Property(e => e.BIsActive).HasDefaultValue(true);
            entity.Property(e => e.EtblLotTrackingChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblLotTrackingQty>(entity =>
        {
            entity.ToTable("_etblLotTrackingQty", tb => tb.HasTrigger("trgLotTrackingQtyNegStock"));

            entity.Property(e => e.EtblLotTrackingQtyChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblLotTrackingTx>(entity =>
        {
            entity.Property(e => e.EtblLotTrackingTxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblMajorIndustryCode>(entity =>
        {
            entity.Property(e => e.EtblMajorIndustryCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblManufProcess>(entity =>
        {
            entity.Property(e => e.BOverrideCompWhse).HasDefaultValue(true);
            entity.Property(e => e.EtblManufProcessChecksum).IsFixedLength();
            entity.Property(e => e.IStatus).IsFixedLength();
        });

        modelBuilder.Entity<EtblManufProcessItem>(entity =>
        {
            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.EtblManufProcessItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblManufProcessLine>(entity =>
        {
            entity.Property(e => e.EtblManufProcessLineChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblMcagentCriterion>(entity =>
        {
            entity.Property(e => e.EtblMcagentCriteriaChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblMcagentNotification>(entity =>
        {
            entity.Property(e => e.EtblMcagentNotificationsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblMcdefaultCriterion>(entity =>
        {
            entity.Property(e => e.EtblMcdefaultCriteriaChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblOrderCancelReason>(entity =>
        {
            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.EtblOrderCancelReasonChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPaymentsBasedTax>(entity =>
        {
            entity.Property(e => e.EtblPaymentsBasedTaxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPaymentsBasedTaxPayment>(entity =>
        {
            entity.HasKey(e => e.IdPaymentsBasedTaxPayments).HasName("PK___etblPay__C7F370F825FF9040");

            entity.Property(e => e.EtblPaymentsBasedTaxPaymentsChecksum).IsFixedLength();
            entity.Property(e => e.IAllocatedPostingId).HasDefaultValue(0L);
        });

        modelBuilder.Entity<EtblPeriod>(entity =>
        {
            entity.Property(e => e.IdPeriod).ValueGeneratedNever();
            entity.Property(e => e.EtblPeriodChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPeriodYear>(entity =>
        {
            entity.Property(e => e.IdYear).ValueGeneratedNever();
            entity.Property(e => e.EtblPeriodYearChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPopdefault>(entity =>
        {
            entity.HasKey(e => e.IdPopdefaults).IsClustered(false);

            entity.Property(e => e.BAutoRequisition).HasDefaultValue(true);
            entity.Property(e => e.EtblPopdefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPoprequisition>(entity =>
        {
            entity.HasKey(e => e.IdPoprequisitions).IsClustered(false);

            entity.Property(e => e.EtblPoprequisitionsChecksum).IsFixedLength();
            entity.Property(e => e.IAgentId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblPoprequisitionLine>(entity =>
        {
            entity.HasKey(e => e.IdPoprequisitionLines).IsClustered(false);

            entity.HasIndex(e => new { e.IRequisitionId, e.IAgentId }, "idxRequisitionsID").HasFillFactor(90);

            entity.Property(e => e.EtblPoprequisitionLinesChecksum).IsFixedLength();
            entity.Property(e => e.FActualPrice).HasDefaultValue(0.0);
            entity.Property(e => e.IPoinvoiceId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblPoprequisitionLinesHist>(entity =>
        {
            entity.HasKey(e => e.IdPoprequisitionLinesHist).IsClustered(false);

            entity.HasIndex(e => new { e.IRequisitionHistId, e.IAgentId }, "idxRequisitionHistID").HasFillFactor(90);

            entity.HasIndex(e => new { e.IRequisitionId, e.IAgentId }, "idxRequisitionID").HasFillFactor(90);

            entity.Property(e => e.EtblPoprequisitionLinesHistChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPoprequisitionsHist>(entity =>
        {
            entity.HasKey(e => e.IdPoprequisitionsHist).IsClustered(false);

            entity.HasIndex(e => new { e.IRequisitionId, e.IVersion }, "idxRequisitionID").HasFillFactor(90);

            entity.Property(e => e.EtblPoprequisitionsHistChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPosdevice>(entity =>
        {
            entity.Property(e => e.EtblPosdevicesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPostDatedCheque>(entity =>
        {
            entity.Property(e => e.EtblPostDatedChequesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPostGlhist>(entity =>
        {
            entity.Property(e => e.EtblPostGlhistChecksum).IsFixedLength();
            entity.Property(e => e.IImportDeclarationId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblPostOutstandingExclAp>(entity =>
        {
            entity.Property(e => e.EtblPostOutstandingExclApChecksum).IsFixedLength();
            entity.Property(e => e.IdPostOutstandingExcl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EtblPostOutstandingExclAr>(entity =>
        {
            entity.Property(e => e.EtblPostOutstandingExclArChecksum).IsFixedLength();
            entity.Property(e => e.IdPostOutstandingExcl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EtblPriceListName>(entity =>
        {
            entity.Property(e => e.EtblPriceListNameChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPriceListPrice>(entity =>
        {
            entity.HasIndex(e => new { e.IPriceListNameId, e.IStockId, e.IWarehouseId }, "idx_etblPriceListPrices_PriceListStockID").HasFillFactor(90);

            entity.Property(e => e.EtblPriceListPricesChecksum).IsFixedLength();
            entity.Property(e => e.IWarehouseId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblPromotion>(entity =>
        {
            entity.HasKey(e => e.IPromotionId).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.BInclusive).HasDefaultValue(true);
            entity.Property(e => e.EtblPromotionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPromotionItem>(entity =>
        {
            entity.HasKey(e => e.IPromotionItemId).IsClustered(false);

            entity.Property(e => e.EtblPromotionItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPromotionItemList>(entity =>
        {
            entity.HasKey(e => e.IPromotionItemListId).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.EtblPromotionItemListChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPromotionItemListLink>(entity =>
        {
            entity.HasKey(e => e.IPromotionItemListLinkId).HasName("PK___etblPro__C31A3AEF52793849");

            entity.Property(e => e.EtblPromotionItemListLinkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblPromotionItemListQty>(entity =>
        {
            entity.HasKey(e => e.IPromotionItemListQtyid).HasName("PK___etblPro__6087CC745832119F");

            entity.Property(e => e.EtblPromotionItemListQtyChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblRemittanceBatch>(entity =>
        {
            entity.Property(e => e.BAllInvoicesPaid).HasDefaultValue(true);
            entity.Property(e => e.BAllocateToOldest).HasDefaultValue(false);
            entity.Property(e => e.BAllowSettDisc).HasDefaultValue(false);
            entity.Property(e => e.BApplyTerms).HasDefaultValue(true);
            entity.Property(e => e.BAutoAllocOutstanding).HasDefaultValue(false);
            entity.Property(e => e.BChequeEftsrun).HasDefaultValue(true);
            entity.Property(e => e.BDefaultEftsproc).HasDefaultValue(false);
            entity.Property(e => e.BDefaultPrintCheque).HasDefaultValue(true);
            entity.Property(e => e.BEftsautoDateForward).HasDefaultValue(false);
            entity.Property(e => e.BEftsduplicateFile).HasDefaultValue(false);
            entity.Property(e => e.BEftsexportOrderLetter).HasDefaultValue(false);
            entity.Property(e => e.BEftstxProofOfPayment).HasDefaultValue(false);
            entity.Property(e => e.BIncDescription).HasDefaultValue(false);
            entity.Property(e => e.BIncReference).HasDefaultValue(false);
            entity.Property(e => e.BInclOutstandingDebits).HasDefaultValue(false);
            entity.Property(e => e.BIncludeSupOnHold).HasDefaultValue(true);
            entity.Property(e => e.BPreviewBeforePrint).HasDefaultValue(true);
            entity.Property(e => e.BPrintAlsoChequeOrEfts).HasDefaultValue(true);
            entity.Property(e => e.BPrintChequeOrEftsonly).HasDefaultValue(false);
            entity.Property(e => e.BPrintRemittance).HasDefaultValue(true);
            entity.Property(e => e.BPrintSamePageRemCheq).HasDefaultValue(false);
            entity.Property(e => e.BPromptValidationOnClose).HasDefaultValue(true);
            entity.Property(e => e.BTxOnHold).HasDefaultValue(false);
            entity.Property(e => e.BTxOnHoldRemove).HasDefaultValue(false);
            entity.Property(e => e.BWarnNotIncludedInRun).HasDefaultValue(true);
            entity.Property(e => e.EtblRemittanceBatchesChecksum).IsFixedLength();
            entity.Property(e => e.IProjectId).HasDefaultValue(0);
            entity.Property(e => e.IStatus).HasDefaultValue(1);
        });

        modelBuilder.Entity<EtblRemittanceBatchDefault>(entity =>
        {
            entity.Property(e => e.BAutoNumbers).HasDefaultValue(false);
            entity.Property(e => e.BAutoRefNumbers).HasDefaultValue(false);
            entity.Property(e => e.EtblRemittanceBatchDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblRemittanceDefault>(entity =>
        {
            entity.HasKey(e => e.IdremittanceDefaults).HasName("PK_IDRemittanceDefaults");

            entity.Property(e => e.BAllInvoicesPaid).HasDefaultValue(true);
            entity.Property(e => e.BApplyTerms).HasDefaultValue(true);
            entity.Property(e => e.BChequeEftsrun).HasDefaultValue(true);
            entity.Property(e => e.BDefaultPrintCheque).HasDefaultValue(true);
            entity.Property(e => e.BIncludeSupOnHold).HasDefaultValue(true);
            entity.Property(e => e.BLoadDefaults).HasDefaultValue(false);
            entity.Property(e => e.BPreviewBeforePrint).HasDefaultValue(true);
            entity.Property(e => e.BPrintAlsoChequeOrEfts).HasDefaultValue(true);
            entity.Property(e => e.BPrintRemittance).HasDefaultValue(true);
            entity.Property(e => e.BPromptValidationOnClose).HasDefaultValue(true);
            entity.Property(e => e.BWarnNotIncludedInRun).HasDefaultValue(true);
            entity.Property(e => e.EtblRemittanceDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblRemittanceLine>(entity =>
        {
            entity.HasKey(e => e.IdremittanceLines).HasName("PK_IDRemittanceLines");

            entity.Property(e => e.CInvDescription).HasDefaultValue("");
            entity.Property(e => e.CInvReference1).HasDefaultValue("");
            entity.Property(e => e.CInvReference2).HasDefaultValue("");
            entity.Property(e => e.EtblRemittanceLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblRemittanceSupplier>(entity =>
        {
            entity.HasKey(e => e.IdremittanceSuppliers).HasName("PK_IDRemittanceSuppliers");

            entity.Property(e => e.EtblRemittanceSuppliersChecksum).IsFixedLength();
            entity.Property(e => e.FUnallocatedCredits).HasDefaultValue(0.0);
            entity.Property(e => e.IConfiguredCount).HasDefaultValue(0.0);
            entity.Property(e => e.IInvoiceCount).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblReplLog>(entity =>
        {
            entity.Property(e => e.CAction).IsFixedLength();
            entity.Property(e => e.DInitDateUtc).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<EtblReportJob>(entity =>
        {
            entity.HasIndex(e => e.IReportJobAgentId, "idxReportJobAgentID").HasFillFactor(90);

            entity.Property(e => e.EtblReportJobsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblReportJobLog>(entity =>
        {
            entity.HasIndex(e => e.IReportJobId, "idxReportJobID").HasFillFactor(90);

            entity.Property(e => e.EtblReportJobLogChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblRevaluationHistory>(entity =>
        {
            entity.Property(e => e.EtblRevaluationHistoryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSagePayBank>(entity =>
        {
            entity.Property(e => e.EtblSagePayBanksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSagePayErrorCode>(entity =>
        {
            entity.Property(e => e.EtblSagePayErrorCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSagePayNow>(entity =>
        {
            entity.HasKey(e => e.IdSagePayNow).HasName("PK__etblSagePayNowidSagePayNow");

            entity.Property(e => e.EtblSagePayNowChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSagePayQueue>(entity =>
        {
            entity.HasKey(e => e.IdSpqueue).HasName("PK_etblSagePayQueue");

            entity.Property(e => e.EtblSagePayQueueChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSagePayServiceKey>(entity =>
        {
            entity.HasKey(e => e.IdSagePayServiceKey).HasName("PK_etblSagePayServiceKeys");

            entity.Property(e => e.EtblSagePayServiceKeysChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSettlementTerm>(entity =>
        {
            entity.Property(e => e.EtblSettlementTermsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSyncInfoDetail>(entity =>
        {
            entity.Property(e => e.RowChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblSystem>(entity =>
        {
            entity.HasKey(e => e.IdSystem).IsClustered(false);

            entity.HasIndex(e => e.CIdentity, "idxIdentity")
                .IsClustered()
                .HasFillFactor(90);
        });

        modelBuilder.Entity<EtblSystemDefault>(entity =>
        {
            entity.Property(e => e.BExceptionTrapping).HasDefaultValue(false);
            entity.Property(e => e.BUpdateGlbalances).HasDefaultValue(true);
            entity.Property(e => e.BUseCom).HasDefaultValue(false);
            entity.Property(e => e.BUseLocalService).HasDefaultValue(true);
            entity.Property(e => e.BUseMapi).HasDefaultValue(true);
            entity.Property(e => e.BUseTls).HasDefaultValue(0);
            entity.Property(e => e.CSmtpbccAddresss).HasDefaultValueSql("((0))");
            entity.Property(e => e.EtblSystemDefaultsChecksum).IsFixedLength();
            entity.Property(e => e.IFssessionTimeOut).HasDefaultValue(20);
            entity.Property(e => e.IGlrelinkCheckInterval).HasDefaultValue(1);
            entity.Property(e => e.SmartFilter).HasDefaultValue(true);
        });

        modelBuilder.Entity<EtblSystemUpdate>(entity =>
        {
            entity.Property(e => e.EtblSystemUpdateChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTaxBadDebt>(entity =>
        {
            entity.HasKey(e => e.ITaxBadDebtId).HasName("PK___etblTax__3E32A3DE3887FF6D");

            entity.Property(e => e.TxDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<EtblTaxBoxLayout>(entity =>
        {
            entity.Property(e => e.EtblTaxBoxLayoutChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTaxBoxSetup>(entity =>
        {
            entity.Property(e => e.EtblTaxBoxSetupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTaxDefault>(entity =>
        {
            entity.Property(e => e.BForceClientTaxIdentification).HasDefaultValue(false);
            entity.Property(e => e.BForceSupplierTaxIdentification).HasDefaultValue(false);
            entity.Property(e => e.BPrincipalVendor).HasDefaultValue(false);
            entity.Property(e => e.BValidateTaxGroups).HasDefaultValue(true);
            entity.Property(e => e.EtblTaxDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTaxGroup>(entity =>
        {
            entity.Property(e => e.EtblTaxGroupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTaxGroupTransType>(entity =>
        {
            entity.Property(e => e.EtblTaxGroupTransTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTaxSubmissionDetail>(entity =>
        {
            entity.Property(e => e.EtblTaxSubmissionDetailsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblTerm>(entity =>
        {
            entity.Property(e => e.EtblTermsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblUnit>(entity =>
        {
            entity.Property(e => e.EtblUnitsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblUnitCategory>(entity =>
        {
            entity.Property(e => e.EtblUnitCategoryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblUnitConversion>(entity =>
        {
            entity.HasIndex(e => new { e.IUnitAid, e.IUnitBid }, "_etblUnitConversion_idxAB").HasFillFactor(90);

            entity.HasIndex(e => new { e.IUnitBid, e.IUnitAid }, "_etblUnitConversion_idxBA").HasFillFactor(90);

            entity.Property(e => e.EtblUnitConversionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblVasairtimeItem>(entity =>
        {
            entity.HasKey(e => e.IdVasairtimeItem).HasName("PK_VASAirtimeItem");

            entity.Property(e => e.EtblVasairtimeItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblVasairtimeMaster>(entity =>
        {
            entity.HasKey(e => e.IdVasairtimeMaster).HasName("PK_VASAirtimeMaster");

            entity.Property(e => e.EtblVasairtimeMasterChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblVasairtimeNetwork>(entity =>
        {
            entity.HasKey(e => e.IdVasairtimeNetwork).HasName("PK_VASAirtimeNetwork");

            entity.Property(e => e.EtblVasairtimeNetworkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblVasairtimeProduct>(entity =>
        {
            entity.HasKey(e => e.IdVasairtimeProduct).HasName("PK_VASAirtimeProduct");

            entity.Property(e => e.EtblVasairtimeProductChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblVdap>(entity =>
        {
            entity.HasIndex(e => e.IArapid, "idx_etblVDAP_iARAPID").HasFillFactor(90);

            entity.HasIndex(e => new { e.IGroupId, e.ICurrencyId }, "idx_etblVDAP_iGroupID_iCurrencyID").HasFillFactor(90);

            entity.Property(e => e.BArapall).HasDefaultValue(false);
            entity.Property(e => e.EtblVdapChecksum).IsFixedLength();
            entity.Property(e => e.IGroupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblVdar>(entity =>
        {
            entity.HasIndex(e => e.IArapid, "idx_etblVDAR_iARAPID").HasFillFactor(90);

            entity.HasIndex(e => new { e.IGroupId, e.ICurrencyId }, "idx_etblVDAR_iGroupID_iCurrencyID").HasFillFactor(90);

            entity.Property(e => e.BArapall).HasDefaultValue(false);
            entity.Property(e => e.EtblVdarChecksum).IsFixedLength();
            entity.Property(e => e.IGroupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblVdlnAp>(entity =>
        {
            entity.HasIndex(e => new { e.IStGroupId, e.ICurrencyId }, "idx_etblVDLnAP_iStGroupID_iCurrencyID").HasFillFactor(90);

            entity.HasIndex(e => new { e.IVdid, e.IStockId }, "idx_etblVDLnAP_iVDID_iStockID").HasFillFactor(90);

            entity.Property(e => e.BStockAll).HasDefaultValue(false);
            entity.Property(e => e.CEnterInclExcl).HasDefaultValue("E");
            entity.Property(e => e.EtblVdlnApChecksum).IsFixedLength();
            entity.Property(e => e.IStGroupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblVdlnAr>(entity =>
        {
            entity.HasIndex(e => new { e.IStGroupId, e.ICurrencyId }, "idx_etblVDLnAR_iStGroupID_iCurrencyID").HasFillFactor(90);

            entity.HasIndex(e => new { e.IVdid, e.IStockId }, "idx_etblVDLnAR_iVDID_iStockID").HasFillFactor(90);

            entity.Property(e => e.BStockAll).HasDefaultValue(false);
            entity.Property(e => e.CEnterInclExcl).HasDefaultValue("E");
            entity.Property(e => e.EtblVdlnArChecksum).IsFixedLength();
            entity.Property(e => e.IStGroupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<EtblVdlnLvlAp>(entity =>
        {
            entity.HasIndex(e => new { e.IVdlnId, e.ILevel }, "idx_etblVDLnLvlAP_iVDLnID_iLevel").HasFillFactor(90);

            entity.Property(e => e.EtblVdlnLvlApChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblVdlnLvlAr>(entity =>
        {
            entity.HasIndex(e => new { e.IVdlnId, e.ILevel }, "idx_etblVDLnLvlAR_iVDLnID_iLevel").HasFillFactor(90);

            entity.Property(e => e.EtblVdlnLvlArChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhDefault>(entity =>
        {
            entity.Property(e => e.BIbtdelNoteAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BIbtnumAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BIbtrequestNumAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BWhTfBatchAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BWhTfRefAutoNum).HasDefaultValue(true);
            entity.Property(e => e.EtblWhDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhseIbt>(entity =>
        {
            entity.Property(e => e.EtblWhseIbtChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhseIbtaddCost>(entity =>
        {
            entity.HasIndex(e => e.IWhseIbtid, "idx_etblWhseIBTAddCosts_iWhseIBTID").HasFillFactor(90);

            entity.Property(e => e.EtblWhseIbtaddCostsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhseIbtline>(entity =>
        {
            entity.Property(e => e.EtblWhseIbtlinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhseIbtlineSn>(entity =>
        {
            entity.HasIndex(e => new { e.IWhseIbtid, e.ISngroupId }, "idx_etblWhseIBTLineSN_iSNGroupID").HasFillFactor(90);

            entity.Property(e => e.EtblWhseIbtlineSnChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhseTransferBatch>(entity =>
        {
            entity.Property(e => e.BAllowDuplicateRef).HasDefaultValue(true);
            entity.Property(e => e.BClearBatchAfterPost).HasDefaultValue(true);
            entity.Property(e => e.BPrintJournal).HasDefaultValue(true);
            entity.Property(e => e.EtblWhseTransferBatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWhseTransferBatchLine>(entity =>
        {
            entity.Property(e => e.EtblWhseTransferBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EtblWorker>(entity =>
        {
            entity.HasKey(e => e.IdWorkers).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.EtblWorkersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvApbatchLine>(entity =>
        {
            entity.ToView("_evAPBatchLines");

            entity.Property(e => e.EtblArapbatchLinesChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
            entity.Property(e => e.VendorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvAplastDebit>(entity =>
        {
            entity.ToView("_evAPLastDebit");
        });

        modelBuilder.Entity<EvAplastTrxDate>(entity =>
        {
            entity.ToView("_evAPLastTrxDate");
        });

        modelBuilder.Entity<EvAppostDatedCheque>(entity =>
        {
            entity.ToView("_evAPPostDatedCheques");

            entity.Property(e => e.EtblPostDatedChequesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArapbatch>(entity =>
        {
            entity.ToView("_evARAPBatch");

            entity.Property(e => e.CurrencyChecksum).IsFixedLength();
            entity.Property(e => e.EtblArapbatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArapbatchContraSplit>(entity =>
        {
            entity.ToView("_evARAPBatchContraSplit");

            entity.Property(e => e.AccountsChecksum).IsFixedLength();
            entity.Property(e => e.EtblArapbatchContraSplitChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArapbatchLine>(entity =>
        {
            entity.ToView("_evARAPBatchLines");

            entity.Property(e => e.EtblArapbatchLinesChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArbatchLine>(entity =>
        {
            entity.ToView("_evARBatchLines");

            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.EtblArapbatchLinesChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArlastTrxDate>(entity =>
        {
            entity.ToView("_evARLastTrxDate");
        });

        modelBuilder.Entity<EvArpostDatedCheque>(entity =>
        {
            entity.ToView("_evARPostDatedCheques");

            entity.Property(e => e.EtblPostDatedChequesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArstatementRun>(entity =>
        {
            entity.ToView("_evARStatementRun");

            entity.Property(e => e.EtblArstatementRunChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvArtopSale>(entity =>
        {
            entity.ToView("_evARTopSales");
        });

        modelBuilder.Entity<EvAuditingAuditedTable>(entity =>
        {
            entity.ToView("_evAuditingAuditedTables");
        });

        modelBuilder.Entity<EvAuditingListTrigger>(entity =>
        {
            entity.ToView("_evAuditingListTriggers");
        });

        modelBuilder.Entity<EvAutoLevelUpdateItem>(entity =>
        {
            entity.ToView("_evAutoLevelUpdateItems");

            entity.Property(e => e.CItemType).IsFixedLength();
            entity.Property(e => e.EtblAutoLevelUpdateItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvBatchPermission>(entity =>
        {
            entity.ToView("_evBatchPermissions");

            entity.Property(e => e.EtblBatchPermissionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvCmevent>(entity =>
        {
            entity.ToView("_evCMEvent");

            entity.Property(e => e.BtblCmeventChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvDelAddressFull>(entity =>
        {
            entity.ToView("_evDelAddressFull");

            entity.Property(e => e.EtblDelAddressChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvDocCat>(entity =>
        {
            entity.ToView("_evDocCat");

            entity.Property(e => e.EtblDocCatChecksum).IsFixedLength();
            entity.Property(e => e.EtblDocCatGroupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvDocProfile>(entity =>
        {
            entity.ToView("_evDocProfiles");

            entity.Property(e => e.EtblDocProfilesChecksum).IsFixedLength();
            entity.Property(e => e.IdDocProfiles).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EvEftsfileLayout>(entity =>
        {
            entity.ToView("_evEFTSFileLayout");
        });

        modelBuilder.Entity<EvGlaccountBalancesFull>(entity =>
        {
            entity.ToView("_evGLAccountBalancesFull");

            entity.Property(e => e.AccountsChecksum).IsFixedLength();
            entity.Property(e => e.EtblAccBlncChecksum).IsFixedLength();
            entity.Property(e => e.EtblBudgetsChecksum).IsFixedLength();
            entity.Property(e => e.EtblPeriodChecksum).IsFixedLength();
            entity.Property(e => e.EtblPeriodYearChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvGlaccountsAnnualOpeningBalance>(entity =>
        {
            entity.ToView("_evGLAccountsAnnualOpeningBalances");
        });

        modelBuilder.Entity<EvGlaccountsFull>(entity =>
        {
            entity.ToView("_evGLAccountsFull");

            entity.Property(e => e.AccountsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvGlbatchReferenceNumber>(entity =>
        {
            entity.ToView("_evGLBatchReferenceNumber");
        });

        modelBuilder.Entity<EvGlmScoasegment>(entity =>
        {
            entity.ToView("_evGLmSCOASegments");

            entity.Property(e => e.EtblGlmScoaaccountsChecksum).IsFixedLength();
            entity.Property(e => e.EtblGlmScoaversionsChecksum).IsFixedLength();
            entity.Property(e => e.EtblGlsegmentChecksum).IsFixedLength();
            entity.Property(e => e.Mscoacheck).IsFixedLength();
        });

        modelBuilder.Entity<EvInvCostTracking>(entity =>
        {
            entity.ToView("_evInvCostTracking");
        });

        modelBuilder.Entity<EvInvJrBatch>(entity =>
        {
            entity.ToView("_evInvJrBatches");

            entity.Property(e => e.EtblInvJrBatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvInvJrBatchLine>(entity =>
        {
            entity.ToView("_evInvJrBatchLines");

            entity.Property(e => e.EtblInvJrBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvInvJrBatchLineSn>(entity =>
        {
            entity.ToView("_evInvJrBatchLineSN");

            entity.Property(e => e.EtblInvJrBatchLineSnChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvInvPriceUpdateBatchLine>(entity =>
        {
            entity.ToView("_evInvPriceUpdateBatchLines");

            entity.Property(e => e.EtblInvPriceUpdateBatchLinesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvInvSegGroup>(entity =>
        {
            entity.ToView("_evInvSegGroup");

            entity.Property(e => e.EtblInvSegGroupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvInvSegValue>(entity =>
        {
            entity.ToView("_evInvSegValue");

            entity.Property(e => e.EtblInvSegValueChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvLotTrackingTx>(entity =>
        {
            entity.ToView("_evLotTrackingTx");

            entity.Property(e => e.EtblLotTrackingTxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvLtlotTracking>(entity =>
        {
            entity.ToView("_evLTLotTracking");

            entity.Property(e => e.EtblLotStatusChecksum).IsFixedLength();
            entity.Property(e => e.EtblLotTrackingChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvLtlotTrackingQty>(entity =>
        {
            entity.ToView("_evLTLotTrackingQty");

            entity.Property(e => e.EtblLotTrackingChecksum).IsFixedLength();
            entity.Property(e => e.EtblLotTrackingQtyChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvLtlotTrackingWhse>(entity =>
        {
            entity.ToView("_evLTLotTrackingWhse");

            entity.Property(e => e.EtblLotStatusChecksum).IsFixedLength();
            entity.Property(e => e.EtblLotTrackingChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvManufProcessFull>(entity =>
        {
            entity.ToView("_evManufProcessFull");

            entity.Property(e => e.BomMastChecksum).IsFixedLength();
            entity.Property(e => e.EtblManufProcessChecksum).IsFixedLength();
            entity.Property(e => e.IStatus).IsFixedLength();
            entity.Property(e => e.ManufStatus).IsFixedLength();
        });

        modelBuilder.Entity<EvManufProcessLinesFull>(entity =>
        {
            entity.ToView("_evManufProcessLinesFull");

            entity.Property(e => e.BomMastChecksum).IsFixedLength();
            entity.Property(e => e.EtblManufProcessChecksum).IsFixedLength();
            entity.Property(e => e.IStatus).IsFixedLength();
            entity.Property(e => e.ManufStatus).IsFixedLength();
        });

        modelBuilder.Entity<EvMcagentCriterion>(entity =>
        {
            entity.ToView("_evMCAgentCriteria");

            entity.Property(e => e.EtblMcagentCriteriaChecksum).IsFixedLength();
            entity.Property(e => e.IdAgentCriteria).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EvPbttransactionsFull>(entity =>
        {
            entity.ToView("_evPBTTransactionsFull");
        });

        modelBuilder.Entity<EvPoprequisition>(entity =>
        {
            entity.ToView("_evPOPRequisitions");

            entity.Property(e => e.EtblPoprequisitionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvPoprequisitionLine>(entity =>
        {
            entity.ToView("_evPOPRequisitionLines");

            entity.Property(e => e.EtblPoprequisitionLinesChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvPoprequisitionLinesHist>(entity =>
        {
            entity.ToView("_evPOPRequisitionLinesHist");

            entity.Property(e => e.EtblPoprequisitionLinesHistChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvPoprequisitionsHist>(entity =>
        {
            entity.ToView("_evPOPRequisitionsHist");

            entity.Property(e => e.EtblPoprequisitionsHistChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvPosdevice>(entity =>
        {
            entity.ToView("_evPOSDevices");

            entity.Property(e => e.EtblPosdevicesChecksum).IsFixedLength();
            entity.Property(e => e.IdPosdevices).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EvPriceListPrice>(entity =>
        {
            entity.ToView("_evPriceListPrices");

            entity.Property(e => e.CurrencyChecksum).IsFixedLength();
            entity.Property(e => e.EtblPriceListNameChecksum).IsFixedLength();
            entity.Property(e => e.EtblPriceListPricesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvPriceListPricesFull>(entity =>
        {
            entity.ToView("_evPriceListPricesFull");

            entity.Property(e => e.EtblPriceListNameChecksum).IsFixedLength();
            entity.Property(e => e.EtblPriceListPricesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvStockCostsVariance>(entity =>
        {
            entity.ToView("_evStockCostsVariance");
        });

        modelBuilder.Entity<EvStockEuinfo>(entity =>
        {
            entity.ToView("_evStockEUInfo");
        });

        modelBuilder.Entity<EvTaxBoxReport>(entity =>
        {
            entity.ToView("_evTaxBoxReport");
        });

        modelBuilder.Entity<EvTaxBoxReportUae>(entity =>
        {
            entity.ToView("_evTaxBoxReportUAE");
        });

        modelBuilder.Entity<EvTaxGroup>(entity =>
        {
            entity.ToView("_evTaxGroups");

            entity.Property(e => e.IdTrCodes).ValueGeneratedOnAdd();
            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvTaxGroupTransType>(entity =>
        {
            entity.ToView("_evTaxGroupTransType");
        });

        modelBuilder.Entity<EvTaxGroupTransTypeJc>(entity =>
        {
            entity.ToView("_evTaxGroupTransTypeJC");
        });

        modelBuilder.Entity<EvTotalSalesTodayForAr>(entity =>
        {
            entity.ToView("_evTotalSalesTodayForAR");

            entity.Property(e => e.Dclink).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EvTotalSalesTodayForSalesRep>(entity =>
        {
            entity.ToView("_evTotalSalesTodayForSalesRep");

            entity.Property(e => e.IdSalesRep).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EvUnitsOfMeasureConversion>(entity =>
        {
            entity.ToView("_evUnitsOfMeasureConversions");

            entity.Property(e => e.EtblUnitsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvUnitsOfMeasureFull>(entity =>
        {
            entity.ToView("_evUnitsOfMeasureFull");

            entity.Property(e => e.EtblUnitsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvWhseIbt>(entity =>
        {
            entity.ToView("_evWhseIBT");

            entity.Property(e => e.EtblWhseIbtChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvWhseIbtline>(entity =>
        {
            entity.ToView("_evWhseIBTLines");

            entity.Property(e => e.EtblWhseIbtlinesChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvWhseIbtlineSn>(entity =>
        {
            entity.ToView("_evWhseIBTLineSN");

            entity.Property(e => e.EtblWhseIbtlineSnChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvWhseTrfBatch>(entity =>
        {
            entity.ToView("_evWhseTrfBatch");

            entity.Property(e => e.EtblWhseTransferBatchesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<EvWhseTrfBatchLine>(entity =>
        {
            entity.ToView("_evWhseTrfBatchLines");

            entity.Property(e => e.EtblWhseTransferBatchLinesChecksum).IsFixedLength();
            entity.Property(e => e.ProjectChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Glbranch>(entity =>
        {
            entity.HasKey(e => e.IdGlbranch)
                .HasName("PK_BRANCH")
                .IsClustered(false);

            entity.Property(e => e.GlbranchChecksum).IsFixedLength();
        });

        modelBuilder.Entity<GrpTbl>(entity =>
        {
            entity.HasKey(e => e.IdGrpTbl).HasName("PK_GRPTBL");

            entity.Property(e => e.GrpTblChecksum).IsFixedLength();
        });

        modelBuilder.Entity<InvNum>(entity =>
        {
            entity.HasKey(e => e.AutoIndex).HasName("PK_INVNUM");

            entity.ToTable("InvNum", tb => tb.HasTrigger("_trgRFQ_InvNumReqExeternalOrderNum"));

            entity.HasIndex(e => new { e.AccountId, e.DocType }, "idxAccountID_DocType").HasFillFactor(90);

            entity.HasIndex(e => new { e.DocType, e.DocState, e.InvNumber }, "idxDocType").HasFillFactor(90);

            entity.HasIndex(e => e.IOpportunityId, "idx_INVNUM_iOpportunityID").HasFillFactor(90);

            entity.Property(e => e.BTaxPerLine).HasDefaultValue(true);
            entity.Property(e => e.CPermitNumber).HasDefaultValue("");
            entity.Property(e => e.IImportDeclarationId).HasDefaultValue(0);
            entity.Property(e => e.IMergedDocId).HasDefaultValue(0);
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
        });

        modelBuilder.Entity<JobDef>(entity =>
        {
            entity.HasKey(e => e.IdJobDef)
                .HasName("PK_JobDef_idJobDef")
                .IsClustered(false);

            entity.Property(e => e.BPrintAllLines).HasDefaultValue(true);
            entity.Property(e => e.BStrictWip).HasDefaultValue(true);
            entity.Property(e => e.JobDefChecksum).IsFixedLength();
        });

        modelBuilder.Entity<JobNum>(entity =>
        {
            entity.HasKey(e => e.AutoIndex)
                .HasName("PK_JOBNUM")
                .IsClustered(false);

            entity.Property(e => e.BTaxPerLine).HasDefaultValue(true);
            entity.Property(e => e.JobNumChecksum).IsFixedLength();
        });

        modelBuilder.Entity<JobStock>(entity =>
        {
            entity.HasIndex(e => e.JobStock1, "PK_JOBSTOCK")
                .IsUnique()
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.JobStock1).ValueGeneratedOnAdd();
            entity.Property(e => e.JobStockChecksum).IsFixedLength();
        });

        modelBuilder.Entity<JobTxTp>(entity =>
        {
            entity.HasKey(e => e.IdJobTxTp)
                .HasName("PK_JOBTXTP")
                .IsClustered(false);

            entity.HasIndex(e => e.Description, "idxDescription").HasFillFactor(90);

            entity.Property(e => e.BSalesFilter).HasDefaultValue(true);
            entity.Property(e => e.JobTxTpChecksum).IsFixedLength();
        });

        modelBuilder.Entity<MastOff>(entity =>
        {
            entity.HasKey(e => e.IdMastOffs)
                .HasName("PK_MASTOFFS")
                .IsClustered(false);

            entity.Property(e => e.MastOffsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<MtblMbrcategory>(entity =>
        {
            entity.Property(e => e.MtblMbrcategoriesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<NtSupplier>(entity =>
        {
            entity.Property(e => e.NtSuppliersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<NtSuppliersAudit>(entity =>
        {
            entity.Property(e => e.NtSupplierAuditDModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<OldAccBlnc>(entity =>
        {
            entity.HasKey(e => new { e.MasterSubLink, e.ITxBranchBlncId }).HasName("PK_AccBlnc_MasterSubLink_iTxBranchBlncID");

            entity.Property(e => e.ITxBranchBlncId).HasDefaultValue(-1);
            entity.Property(e => e.OldAccBlncChecksum).IsFixedLength();
        });

        modelBuilder.Entity<OldBudget>(entity =>
        {
            entity.HasKey(e => new { e.Gllink, e.ITxBranchBudgetId }).HasName("PK_Budgets_GLLink_iTxBranchBudgetID");

            entity.Property(e => e.ITxBranchBudgetId).HasDefaultValue(-1);
            entity.Property(e => e.OldBudgetsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<OldEtblGlprojectBalance>(entity =>
        {
            entity.HasKey(e => new { e.IGlaccountId, e.IProjectId, e.ITxBranchProjectId }).HasName("PK__etblProjectBalances");

            entity.Property(e => e.ITxBranchProjectId).HasDefaultValue(-1);
            entity.Property(e => e.OldEtblGlprojectBalancesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<OldEtblGlprojectBudget>(entity =>
        {
            entity.HasKey(e => new { e.IGlaccountId, e.IProjectId, e.ITxBranchProjectBudgetId }).HasName("PK__etblProjectBudgets");

            entity.Property(e => e.ITxBranchProjectBudgetId).HasDefaultValue(-1);
            entity.Property(e => e.OldEtblGlprojectBudgetsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<OldEtblGlprojectPrevBalance>(entity =>
        {
            entity.HasKey(e => new { e.IGlaccountId, e.IProjectId, e.ITxBranchProjectPrevId }).HasName("PK__etblProjectPrevBalances");

            entity.Property(e => e.ITxBranchProjectPrevId).HasDefaultValue(-1);
            entity.Property(e => e.OldEtblGlprojectPrevBalancesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<OldPeriod>(entity =>
        {
            entity.HasKey(e => e.Per).HasName("PK_PERIOD");

            entity.Property(e => e.Per).ValueGeneratedNever();
        });

        modelBuilder.Entity<OrdersDf>(entity =>
        {
            entity.HasKey(e => e.DefaultCounter)
                .HasName("PK_ORDERSDF")
                .IsClustered(false);

            entity.Property(e => e.BPoexclusive).HasDefaultValue(true);
            entity.Property(e => e.BPrintProcessedSops).HasDefaultValue(true);
            entity.Property(e => e.BUseDeliveryManagement).HasDefaultValue(false);
            entity.Property(e => e.OrdersDfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<OrdersSt>(entity =>
        {
            entity.HasKey(e => e.StatusCounter)
                .HasName("PK_ORDERSST")
                .IsClustered(false);

            entity.HasIndex(e => e.StatusDescrip, "idxStatusDescrip").HasFillFactor(90);

            entity.Property(e => e.OrdersStChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PckTbl>(entity =>
        {
            entity.HasKey(e => e.IdPckTbl).HasName("PK_PCKTBL");

            entity.Property(e => e.PckTblChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity.ToView("Period");
        });

        modelBuilder.Entity<PeriodPermission>(entity =>
        {
            entity.Property(e => e.PeriodPermissionsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PosDef>(entity =>
        {
            entity.HasKey(e => e.Idposdefs)
                .HasName("PK_POSDefs_IDPOSDefs")
                .IsClustered(false);

            entity.Property(e => e.BUseDocumentRoundingOnTender).HasDefaultValue(false);
            entity.Property(e => e.ITenderIddefCash).HasDefaultValue(1);
            entity.Property(e => e.PosDefsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PostAp>(entity =>
        {
            entity.HasIndex(e => e.AccountLink, "idxAccountLink").HasFillFactor(90);

            entity.HasIndex(e => e.TxDate, "idxDate").HasFillFactor(90);

            entity.Property(e => e.PostApChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PostAr>(entity =>
        {
            entity.HasIndex(e => e.AccountLink, "idxAccountLink").HasFillFactor(90);

            entity.HasIndex(e => e.TxDate, "idxDate").HasFillFactor(90);

            entity.HasIndex(e => e.LinkAccCode, "idx_PostAR_LinkAccCode").HasFillFactor(90);

            entity.Property(e => e.PostArChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PostGl>(entity =>
        {
            entity.HasIndex(e => e.TxDate, "idxDate").HasFillFactor(90);

            entity.HasIndex(e => e.Period, "idxPeriod").HasFillFactor(90);

            entity.Property(e => e.IImportDeclarationId).HasDefaultValue(0);
            entity.Property(e => e.PostGlChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PostSt>(entity =>
        {
            entity.HasIndex(e => e.AccountLink, "idxAccountLink").HasFillFactor(90);

            entity.HasIndex(e => e.TxDate, "idxDate").HasFillFactor(90);

            entity.Property(e => e.BChargeCom).HasDefaultValue(true);
            entity.Property(e => e.IMajorIndustryCodeId).HasDefaultValue(0);
            entity.Property(e => e.PostStChecksum).IsFixedLength();
        });

        modelBuilder.Entity<PrintGrp>(entity =>
        {
            entity.HasKey(e => e.AutoIdx)
                .HasName("PK_PRINTGRP")
                .IsClustered(false);

            entity.HasIndex(e => e.Descrip, "idxDesc").HasFillFactor(90);

            entity.Property(e => e.PrintGrpChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectLink).HasName("PK_PROJECT");

            entity.HasIndex(e => e.MasterSubProject, "idxMasterSubProject").HasFillFactor(90);

            entity.HasIndex(e => e.ProjectCode, "idxProjectCode").HasFillFactor(90);

            entity.Property(e => e.ProjectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RecurRc>(entity =>
        {
            entity.HasKey(e => e.AutoIdx)
                .HasName("PK_RECURRC")
                .IsClustered(false);

            entity.HasIndex(e => e.Description, "idxDescription").HasFillFactor(90);

            entity.Property(e => e.RecurRcChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RecurRdef>(entity =>
        {
            entity.Property(e => e.BAlwaysLoad).HasDefaultValue(true);
            entity.Property(e => e.IdRecurrDef).ValueGeneratedOnAdd();
            entity.Property(e => e.RecurRdefChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RecurRf>(entity =>
        {
            entity.HasKey(e => e.AutoIdx)
                .HasName("PK_RECURRF")
                .IsClustered(false);

            entity.HasIndex(e => e.Descrip, "idxDescription").HasFillFactor(90);

            entity.Property(e => e.BaseHome).HasDefaultValue(true);
            entity.Property(e => e.RecurRfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RecurRl>(entity =>
        {
            entity.HasKey(e => e.AutoIdx).HasName("PK_RECURRL");

            entity.Property(e => e.BAllowSettlementTerms).HasDefaultValue(true);
            entity.Property(e => e.RecurRlChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RecurRtx>(entity =>
        {
            entity.HasKey(e => e.AutoIdx).HasName("PK_RECURRTX");

            entity.Property(e => e.RecurRtxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Refer>(entity =>
        {
            entity.HasKey(e => e.AutoIdx)
                .HasName("PK_REFER")
                .IsClustered(false);

            entity.HasIndex(e => e.NameOfRef, "idxAcc").HasFillFactor(90);

            entity.HasIndex(e => new { e.Category, e.DebtorAccNo, e.NameOfRef }, "idxAll").HasFillFactor(90);

            entity.HasIndex(e => e.DebtorAccNo, "idxDeb").HasFillFactor(90);

            entity.Property(e => e.ReferChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.HasKey(e => e.Autoidx)
                .HasName("PK_REMINDER")
                .IsClustered(false);

            entity.HasIndex(e => e.CompanyName, "idxComp").HasFillFactor(90);

            entity.HasIndex(e => new { e.Status, e.UserName, e.RemindDate }, "idxRemind").HasFillFactor(90);

            entity.HasIndex(e => e.TypeofRemind, "idxType").HasFillFactor(90);

            entity.Property(e => e.ReminderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetAgentSession>(entity =>
        {
            entity.Property(e => e.BCashedUp).HasDefaultValue(false);
            entity.Property(e => e.RetAgentSessionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetAgentSessionCashPickupTotal>(entity =>
        {
            entity.Property(e => e.RetAgentSessionCashPickupTotalsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetAgentSessionDenomination>(entity =>
        {
            entity.Property(e => e.RetAgentSessionDenominationChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetAgentSessionPettyCashTotal>(entity =>
        {
            entity.Property(e => e.RetAgentSessionPettyCashTotalsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetAgentSessionTenderTotal>(entity =>
        {
            entity.HasKey(e => e.IdAgentSessionTenderTotals).HasName("PK__rebtAgentSessionTenderTotals");

            entity.Property(e => e.RetAgentSessionTenderTotalsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetCashPickup>(entity =>
        {
            entity.Property(e => e.RetCashPickupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetCashPickupDenomination>(entity =>
        {
            entity.Property(e => e.RetCashPickupDenominationChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetDefault>(entity =>
        {
            entity.Property(e => e.BDisplayDocketPromotionCode).HasDefaultValue(true);
            entity.Property(e => e.BRoundingOnCashTenderOnly).HasDefaultValue(false);
            entity.Property(e => e.BUseDocketRoundingOnTender).HasDefaultValue(false);
            entity.Property(e => e.BUseVasairtime).HasDefaultValue(false);
            entity.Property(e => e.IKeepAsideDaysToExpiry).HasDefaultValue(7);
            entity.Property(e => e.IPromoAutoAlphaLength).HasDefaultValue(3);
            entity.Property(e => e.IPromoAutoLength).HasDefaultValue(6);
            entity.Property(e => e.IPromoItemListAutoAlphaLength).HasDefaultValue(3);
            entity.Property(e => e.IPromoItemListAutoLength).HasDefaultValue(6);
            entity.Property(e => e.RetDefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetDenomination>(entity =>
        {
            entity.HasKey(e => e.IdDenomination).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.RetDenominationChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetDiscountReason>(entity =>
        {
            entity.HasKey(e => e.IdDiscountReason).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.RetDiscountReasonChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetLayBy>(entity =>
        {
            entity.Property(e => e.RetLayBysChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPettyCash>(entity =>
        {
            entity.Property(e => e.RetPettyCashChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPettyCashLine>(entity =>
        {
            entity.Property(e => e.RetPettyCashLineChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPettyCashType>(entity =>
        {
            entity.HasKey(e => e.IdPettyCashType).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.RetPettyCashTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPosMenu>(entity =>
        {
            entity.HasKey(e => e.IdPosmenu).HasName("PK__retPOSMenu");

            entity.Property(e => e.IMid).HasDefaultValue(0);
            entity.Property(e => e.IStockLink).HasDefaultValue(0);
            entity.Property(e => e.RetPosmenuChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPoslogFile>(entity =>
        {
            entity.Property(e => e.RetPoslogFileChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPoslogLink>(entity =>
        {
            entity.Property(e => e.RetPoslogLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPosmenuSetup>(entity =>
        {
            entity.Property(e => e.RetPosmenuSetupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPostender>(entity =>
        {
            entity.HasKey(e => e.IdPostender).HasName("PK__rebtPOSTender");

            entity.Property(e => e.CEftbudgetPeriod).HasDefaultValueSql("((0))");
            entity.Property(e => e.RetPostenderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPostransaction>(entity =>
        {
            entity.HasKey(e => e.IdPostransaction).HasName("PK__rebtPOSTransaction");

            entity.Property(e => e.RetPostransactionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetPriceOverrideReason>(entity =>
        {
            entity.HasKey(e => e.IdPriceOverrideReason).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.RetPriceOverrideReasonChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetReturnReason>(entity =>
        {
            entity.HasKey(e => e.IdReturnReason).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.RetReturnReasonChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetTenderType>(entity =>
        {
            entity.HasKey(e => e.IdTenderType).IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.BApplyDocketRounding).HasDefaultValue(false);
            entity.Property(e => e.RetTenderTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetTill>(entity =>
        {
            entity.HasKey(e => e.IdTill)
                .HasName("PK__retBranchTill")
                .IsClustered(false);

            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.BAutoNumPrependBranch).HasDefaultValue(true);
            entity.Property(e => e.BUseOnScreenKeyboard).HasDefaultValue(false);
            entity.Property(e => e.RetTillChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetTillSecurity>(entity =>
        {
            entity.Property(e => e.RetTillSecurityChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetTillStationery>(entity =>
        {
            entity.Property(e => e.RetTillStationeryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetTradingSession>(entity =>
        {
            entity.Property(e => e.RetTradingSessionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RetVariableBarcode>(entity =>
        {
            entity.Property(e => e.RetVariableBarcodeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevAgentSession>(entity =>
        {
            entity.ToView("_revAgentSession");

            entity.Property(e => e.RetAgentSessionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevAgentSessionCashUp>(entity =>
        {
            entity.ToView("_revAgentSessionCashUp");
        });

        modelBuilder.Entity<RevAgentSessionCashUpDenomination>(entity =>
        {
            entity.ToView("_revAgentSessionCashUpDenomination");
        });

        modelBuilder.Entity<RevAgentSessionCashUpTenderTotal>(entity =>
        {
            entity.ToView("_revAgentSessionCashUpTenderTotals");
        });

        modelBuilder.Entity<RevCashPickupDenominationFull>(entity =>
        {
            entity.ToView("_revCashPickupDenominationFull");
        });

        modelBuilder.Entity<RevCashPickupFull>(entity =>
        {
            entity.ToView("_revCashPickupFull");
        });

        modelBuilder.Entity<RevEftTransaction>(entity =>
        {
            entity.ToView("_revEFtTransaction");

            entity.Property(e => e.RetPostenderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevLayBy>(entity =>
        {
            entity.ToView("_revLayBys");

            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.RetLayBysChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevLayBysFull>(entity =>
        {
            entity.ToView("_revLayBysFull");

            entity.Property(e => e.BtblInvoiceLinesChecksum).IsFixedLength();
            entity.Property(e => e.ClientChecksum).IsFixedLength();
            entity.Property(e => e.InvNumChecksum).IsFixedLength();
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevPaymentByTenderType>(entity =>
        {
            entity.ToView("_revPaymentByTenderType");

            entity.Property(e => e.RetPostenderChecksum).IsFixedLength();
            entity.Property(e => e.RetTenderTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevPaymentByTenderTypeReport>(entity =>
        {
            entity.ToView("_revPaymentByTenderTypeReport");
        });

        modelBuilder.Entity<RevPaymentHistoryPickSlip>(entity =>
        {
            entity.ToView("_revPaymentHistoryPickSlip");
        });

        modelBuilder.Entity<RevPettyCashAdvance>(entity =>
        {
            entity.ToView("_revPettyCashAdvance");
        });

        modelBuilder.Entity<RevPettyCashProcessed>(entity =>
        {
            entity.ToView("_revPettyCashProcessed");
        });

        modelBuilder.Entity<RevPoslogFull>(entity =>
        {
            entity.ToView("_revPOSLogFull");
        });

        modelBuilder.Entity<RevPostenderFull>(entity =>
        {
            entity.ToView("_revPOSTenderFull");
        });

        modelBuilder.Entity<RevPromotionItem>(entity =>
        {
            entity.ToView("_revPromotionItems");
        });

        modelBuilder.Entity<RevReceiptPrinting>(entity =>
        {
            entity.ToView("_revReceiptPrinting");
        });

        modelBuilder.Entity<RevTrCode>(entity =>
        {
            entity.ToView("_revTrCodes");

            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RevTradingSession>(entity =>
        {
            entity.ToView("_revTradingSession");

            entity.Property(e => e.RetTradingSessionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Rfq>(entity =>
        {
            entity.Property(e => e.Archived).HasDefaultValue(false);
            entity.Property(e => e.BRecommend).HasDefaultValue(false);
            entity.Property(e => e.FQuotedPrice).HasDefaultValue(0.0);
            entity.Property(e => e.FQuotedQuantity).HasDefaultValue(0.0);
            entity.Property(e => e.ICriteriaId).HasDefaultValue(0);
            entity.Property(e => e.IHodagent1).HasDefaultValue(0);
            entity.Property(e => e.RfqChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqAgentCostCentreMap>(entity =>
        {
            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.RfqAgentCostCentreMaps).HasConstraintName("FK_RFQ_AgentCostCentreMap__rtblAgents");
        });

        modelBuilder.Entity<RfqAgentSectorMapping>(entity =>
        {
            entity.HasKey(e => e.IdAgentSectorMap).HasName("PK__RFQ_Agen__AC99061092E163CC");

            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdAgentsNavigation).WithMany(p => p.RfqAgentSectorMappings).HasConstraintName("FK__RFQ_Agent__idAgents");
        });

        modelBuilder.Entity<RfqApshareholderLink>(entity =>
        {
            entity.Property(e => e.BDirector).HasDefaultValue(false);
        });

        modelBuilder.Entity<RfqAudit>(entity =>
        {
            entity.Property(e => e.Application).HasDefaultValueSql("(app_name())");
            entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UserName).HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
        });

        modelBuilder.Entity<RfqAuditTable>(entity =>
        {
            entity.HasKey(e => e.IAuditTableId).HasName("PK__RFQ_AuditTables");

            entity.Property(e => e.BIsAudit).HasDefaultValue(false);
            entity.Property(e => e.BIsAuditing).HasDefaultValue(false);
        });

        modelBuilder.Entity<RfqCostCentre>(entity =>
        {
            entity.Property(e => e.RfqCostcentreChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqDeviation>(entity =>
        {
            entity.HasKey(e => e.IdDeviation).HasName("PK_RFQ_Deviation");
        });

        modelBuilder.Entity<RfqDeviationReason>(entity =>
        {
            entity.Property(e => e.BDefault).HasDefaultValue(false);
            entity.Property(e => e.DCreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqDeviationReasonChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqNewQuotationParam>(entity =>
        {
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<RfqNewTender>(entity =>
        {
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqNewTenderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqNewTenderDetail>(entity =>
        {
            entity.HasKey(e => e.PkNewTenderDetailId)
                .HasName("PK__RFQ_NewTenderDetails")
                .IsClustered(false);

            entity.Property(e => e.BHasParameters).HasDefaultValue(false);
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FActualPrice).HasDefaultValue(0.0);
            entity.Property(e => e.IIncidentId).HasDefaultValue(0);
            entity.Property(e => e.IPoinvoiceId).HasDefaultValue(0);

            entity.HasOne(d => d.FkNewTender).WithMany(p => p.RfqNewTenderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQ_NewTenderDetails_RFQ_NewTender");
        });

        modelBuilder.Entity<RfqNewTenderParam>(entity =>
        {
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.FkNewTenderDetail).WithMany(p => p.RfqNewTenderParams).HasConstraintName("FK_RFQ_NewTenderParams_RFQ_NewTenderDetails");

            entity.HasOne(d => d.FkTenderParam).WithMany(p => p.RfqNewTenderParams).HasConstraintName("FK_RFQ_NewTenderParams_RFQ_TenderParameters");
        });

        modelBuilder.Entity<RfqParameterCriterion>(entity =>
        {
            entity.Property(e => e.BRandomSelection).HasDefaultValue(false);
            entity.Property(e => e.RfqParameterCriteriaChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqParameterUdf>(entity =>
        {
            entity.Property(e => e.BWeightage).HasDefaultValue(false);
        });

        modelBuilder.Entity<RfqQuotationParameter>(entity =>
        {
            entity.HasKey(e => e.PkQuotationParamId).HasName("PK_QuotationParameters");

            entity.Property(e => e.BIsActive).HasDefaultValue(true);
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqQuotationParametersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqRecordQuotationParam>(entity =>
        {
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<RfqRecordTender>(entity =>
        {
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqRecordTenderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqRecordTenderDetail>(entity =>
        {
            entity.HasKey(e => e.PkRecordTenderDetailId)
                .HasName("PK__RFQ_RecordTenderDetails")
                .IsClustered(false);

            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FActualPrice).HasDefaultValue(0.0);
            entity.Property(e => e.IPoinvoiceId).HasDefaultValue(0);

            entity.HasOne(d => d.FkRecordTender).WithMany(p => p.RfqRecordTenderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQ_RecordTenderDetails_RFQ_RecordTenderDetails");
        });

        modelBuilder.Entity<RfqRecordTenderParam>(entity =>
        {
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.FkRecordTenderDetail).WithMany(p => p.RfqRecordTenderParams).HasConstraintName("FK_RFQ_RecordTenderParams_RFQ_RecordTenderDetails");

            entity.HasOne(d => d.FkTenderParam).WithMany(p => p.RfqRecordTenderParams).HasConstraintName("FK_RFQ_RecordTenderParams_RFQ_TenderParameters");
        });

        modelBuilder.Entity<RfqReportLayout>(entity =>
        {
            entity.Property(e => e.IdReportLayout).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RfqSector>(entity =>
        {
            entity.Property(e => e.CDescription).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CSector).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.RfqSectorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqStockLink>(entity =>
        {
            entity.HasKey(e => e.IdStockLinks).HasName("PK_RFQ_ItemLinks");

            entity.Property(e => e.BItemActive).HasDefaultValue(true);
            entity.Property(e => e.FLastGrvcost).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<RfqSupplierFiltering>(entity =>
        {
            entity.Property(e => e.CFieldName).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<RfqSupplierPreference>(entity =>
        {
            entity.Property(e => e.CFieldName).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<RfqTenderDf>(entity =>
        {
            entity.Property(e => e.AutoNewTenderNo).HasDefaultValue(true);
            entity.Property(e => e.AutoRecordTenderNo).HasDefaultValue(true);
            entity.Property(e => e.RfqTenderDfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqTenderParameter>(entity =>
        {
            entity.HasKey(e => e.PkTenderParamId).HasName("PK_TenderParameters");

            entity.Property(e => e.BIsActive).HasDefaultValue(true);
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqTenderParametersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqUdf>(entity =>
        {
            entity.Property(e => e.DModifiedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<RfqVendor>(entity =>
        {
            entity.Property(e => e.BApproved).HasDefaultValue(false);
            entity.Property(e => e.BExportToEvo).HasDefaultValue(false);
            entity.Property(e => e.BRejected).HasDefaultValue(false);
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqVendorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqVendorParameter>(entity =>
        {
            entity.Property(e => e.BIsActive).HasDefaultValue(false);
            entity.Property(e => e.BIsMandatory).HasDefaultValue(false);
            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqVendorParameterChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RfqVendorScore>(entity =>
        {
            entity.HasKey(e => e.IdVendorScore).HasName("PK_RFQ_Score");

            entity.Property(e => e.DLastModifiedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RfqVendorScoreChecksum).IsFixedLength();

            entity.HasOne(d => d.IParameter).WithMany(p => p.RfqVendorScores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQ_Score_RFQ_VendorParameter");

            entity.HasOne(d => d.IVendor).WithMany(p => p.RfqVendorScores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQ_Score_RFQ_Vendor");
        });

        modelBuilder.Entity<RfqWorkflowLink>(entity =>
        {
            entity.HasOne(d => d.IEvent).WithMany(p => p.RfqWorkflowLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQ_WorkflowLink_RFQ_Event");

            entity.HasOne(d => d.IWorkflowMember).WithMany(p => p.RfqWorkflowLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RFQ_WorkflowLink__btblCMWorkflowMembers");
        });

        modelBuilder.Entity<Rfqdf>(entity =>
        {
            entity.Property(e => e.AutoNewRfqno).HasDefaultValue(true);
            entity.Property(e => e.BIsLinkedSupplier).HasDefaultValue(true);
            entity.Property(e => e.BIsPrefSupplier).HasDefaultValue(true);
            entity.Property(e => e.BSupplierRotation).HasDefaultValue(true);
            entity.Property(e => e.Dclink).HasDefaultValue(1);
            entity.Property(e => e.IRandomSupplier).HasDefaultValue(5);
            entity.Property(e => e.IRfqautorization).HasDefaultValue(1);
            entity.Property(e => e.IsGl).HasDefaultValue(true);
            entity.Property(e => e.IsOther).HasDefaultValue(true);
            entity.Property(e => e.RfqdfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblAgent>(entity =>
        {
            entity.HasKey(e => e.IdAgents).HasName("PK__rtblUsers");

            entity.HasIndex(e => e.CAgentName, "idxUserName").HasFillFactor(90);

            entity.Property(e => e.BAgentActive).HasDefaultValue(true);
            entity.Property(e => e.BCanAssign).HasDefaultValue(true);
            entity.Property(e => e.BCanSetOutOfOffice).HasDefaultValue(true);
            entity.Property(e => e.BCbagOwnVisible).HasDefaultValue(true);
            entity.Property(e => e.BExitWarning).HasDefaultValue(true);
            entity.Property(e => e.BIncludeApnoGroups).HasDefaultValue(true);
            entity.Property(e => e.BIncludeArnoGroups).HasDefaultValue(true);
            entity.Property(e => e.BJragOwnVisible).HasDefaultValue(true);
            entity.Property(e => e.BKnowledgeBaseWarning).HasDefaultValue(true);
            entity.Property(e => e.BPoexclusive).HasDefaultValue(true);
            entity.Property(e => e.BPouseGrpDefaults).HasDefaultValue(true);
            entity.Property(e => e.BPwdCanChange).HasDefaultValue(true);
            entity.Property(e => e.BPwdMustChange).HasDefaultValue(true);
            entity.Property(e => e.BSupervisorAgent).HasDefaultValue(false);
            entity.Property(e => e.BUseDefaultTree).HasDefaultValue(true);
            entity.Property(e => e.CAccessApgroupChkLstInd)
                .HasDefaultValueSql("((2))")
                .IsFixedLength();
            entity.Property(e => e.CAccessArgroupChkLstInd)
                .HasDefaultValueSql("((2))")
                .IsFixedLength();
            entity.Property(e => e.CAccessBranchChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessDocCatChkLstInd)
                .HasDefaultValueSql("((2))")
                .IsFixedLength();
            entity.Property(e => e.CAccessDocCatGroupChkLstInd)
                .HasDefaultValueSql("((2))")
                .IsFixedLength();
            entity.Property(e => e.CAccessIncidentTypeChkLstInd)
                .HasDefaultValueSql("((2))")
                .IsFixedLength();
            entity.Property(e => e.CAccessIncidentTypeGroupChkLstInd)
                .HasDefaultValueSql("((2))")
                .IsFixedLength();
            entity.Property(e => e.CAccessOtherTxWhChkLstInd)
                .HasDefaultValue("2")
                .IsFixedLength();
            entity.Property(e => e.CAccessProjectChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessPurchaseWhChkLstInd)
                .HasDefaultValue("2")
                .IsFixedLength();
            entity.Property(e => e.CAccessRepChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessSalesWhChkLstInd)
                .HasDefaultValue("2")
                .IsFixedLength();
            entity.Property(e => e.MaxDisc).HasDefaultValue(100.0);
            entity.Property(e => e.MaxLdisc).HasDefaultValue(100.0);
            entity.Property(e => e.RtblAgentsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblAgentGroup>(entity =>
        {
            entity.HasKey(e => e.IdAgentGroups)
                .HasName("PK__rtblUserGroups")
                .IsClustered(false);

            entity.HasIndex(e => e.CGroupName, "idxGroupName")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.BCanAssign).HasDefaultValue(true);
            entity.Property(e => e.BCbgrpAgentVisible).HasDefaultValue(true);
            entity.Property(e => e.BJrgrpAgentVisible).HasDefaultValue(true);
            entity.Property(e => e.BPoexclusive).HasDefaultValue(true);
            entity.Property(e => e.BPouseDefaults).HasDefaultValue(true);
            entity.Property(e => e.BUseDefaultTree).HasDefaultValue(true);
            entity.Property(e => e.RtblAgentGroupsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblAgentGroupMember>(entity =>
        {
            entity.HasKey(e => new { e.IGroupId, e.IAgentId })
                .HasName("PK__rtblUserGroupMembers")
                .IsClustered(false);

            entity.Property(e => e.RtblAgentGroupMembersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblAgentLockedOut>(entity =>
        {
            entity.Property(e => e.RtblAgentLockedOutChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblBusClass>(entity =>
        {
            entity.Property(e => e.RtblBusClassChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblBusDept>(entity =>
        {
            entity.Property(e => e.RtblBusDeptChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblBusDesig>(entity =>
        {
            entity.Property(e => e.RtblBusDesigChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblBusType>(entity =>
        {
            entity.Property(e => e.RtblBusTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblClass>(entity =>
        {
            entity.HasKey(e => e.IdClass).HasName("PK__rtblTaskClass");

            entity.Property(e => e.IdClass).ValueGeneratedNever();
            entity.Property(e => e.RtblClassChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblCmdefault>(entity =>
        {
            entity.HasKey(e => e.IdCmdefaults)
                .HasName("PK__rtblCMDefaults_idCMDefaults")
                .IsClustered(false);

            entity.Property(e => e.BColorCodeOverDueDate).HasDefaultValue(false);
            entity.Property(e => e.BPostIncidentOnHoldCust).HasDefaultValue(true);
            entity.Property(e => e.BRestrictAgents).HasDefaultValue(true);
            entity.Property(e => e.BRestrictInActiveAgents).HasDefaultValue(false);
            entity.Property(e => e.BSfaopportunityAutoNum).HasDefaultValue(true);
            entity.Property(e => e.RtblCmdefaultsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblCompetitor>(entity =>
        {
            entity.Property(e => e.RtblCompetitorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblCompetitorProduct>(entity =>
        {
            entity.Property(e => e.RtblCompetitorProductChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblCompetitorProductLink>(entity =>
        {
            entity.Property(e => e.RtblCompetitorProductLinkChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblContract>(entity =>
        {
            entity.Property(e => e.BAllowOverride).HasDefaultValue(true);
            entity.Property(e => e.RtblContractsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblContractDocLink>(entity =>
        {
            entity.Property(e => e.ILinkSource).HasDefaultValue(0);
            entity.Property(e => e.RtblContractDocLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblContractTemplate>(entity =>
        {
            entity.Property(e => e.BAllowOverride).HasDefaultValue(true);
            entity.Property(e => e.RtblContractTemplatesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblContractTx>(entity =>
        {
            entity.HasIndex(e => e.IContractId, "idxContractID").HasFillFactor(90);

            entity.HasIndex(e => e.IIncidentId, "idxTaskID").HasFillFactor(90);

            entity.Property(e => e.RtblContractTxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblCountry>(entity =>
        {
            entity.Property(e => e.RtblCountryChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblDocCat>(entity =>
        {
            entity.Property(e => e.RtblDocCatChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblDocLink>(entity =>
        {
            entity.HasIndex(e => new { e.ILinkId, e.IdDocLinks, e.IDocStoreId, e.ILinkSource }, "idx_LinkSrc_LinkID").HasFillFactor(90);

            entity.Property(e => e.RtblDocLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblDocStore>(entity =>
        {
            entity.Property(e => e.BIsActive).HasDefaultValue(true);
            entity.Property(e => e.RtblDocStoreChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblEscalateGrp>(entity =>
        {
            entity.Property(e => e.RtblEscalateGrpChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblEscalateGrpMember>(entity =>
        {
            entity.HasIndex(e => e.IAgentGroupId, "idxAgentGroupID").HasFillFactor(90);

            entity.HasIndex(e => e.IEscalateGrpId, "idxEscalateGrpID").HasFillFactor(90);

            entity.Property(e => e.RtblEscalateGrpMembersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncident>(entity =>
        {
            entity.HasKey(e => e.IdIncidents).HasName("PK__rtblTasks");

            entity.ToTable("_rtblIncidents", tb => tb.HasTrigger("_rtgIncidentModified"));

            entity.HasIndex(e => e.IDebtorId, "idxCompany").HasFillFactor(90);

            entity.HasIndex(e => e.DCreated, "idxCreated").HasFillFactor(90);

            entity.HasIndex(e => e.ICurrentAgentId, "idxCurrentAgent").HasFillFactor(90);

            entity.HasIndex(e => e.DLastModified, "idxLastModified").HasFillFactor(90);

            entity.HasIndex(e => e.IPersonId, "idxPerson").HasFillFactor(90);

            entity.Property(e => e.IIncidentCatId).HasDefaultValue(0);
            entity.Property(e => e.RtblIncidentsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentAction>(entity =>
        {
            entity.HasKey(e => e.IdIncidentAction).HasName("PK__rtblTaskAction");

            entity.Property(e => e.IdIncidentAction).ValueGeneratedNever();
            entity.Property(e => e.RtblIncidentActionChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentCat>(entity =>
        {
            entity.HasKey(e => e.IdIncidentCat).HasName("PK__rtblTaskCat");

            entity.Property(e => e.RtblIncidentCatChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentLog>(entity =>
        {
            entity.HasKey(e => e.IdIncidentLog).HasName("PK__rtblTaskLog");

            entity.HasIndex(e => new { e.DActionDate, e.IIncidentActionId, e.INewAgentId }, "idxActionDate").HasFillFactor(90);

            entity.HasIndex(e => e.IIncidentId, "idxTaskID").HasFillFactor(90);

            entity.HasIndex(e => e.IAgentId, "idx_rtblIncidentLog_iAgentID").HasFillFactor(90);

            entity.Property(e => e.CSourceId).HasDefaultValue("");
            entity.Property(e => e.RtblIncidentLogChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentLogArchive>(entity =>
        {
            entity.HasIndex(e => new { e.DActionDate, e.IIncidentActionId, e.INewAgentId }, "idxActionDate").HasFillFactor(90);

            entity.HasIndex(e => e.IIncidentId, "idxTaskID").HasFillFactor(90);

            entity.HasIndex(e => e.IAgentId, "idx_rtblIncidentLog_iAgentID").HasFillFactor(90);

            entity.Property(e => e.IdIncidentLog).ValueGeneratedNever();
            entity.Property(e => e.CSourceId).HasDefaultValue("");
            entity.Property(e => e.RtblIncidentLogArchiveChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentPriority>(entity =>
        {
            entity.HasKey(e => e.IdIncidentPriority).HasName("PK__rtblTaskPriority");

            entity.Property(e => e.IdIncidentPriority).ValueGeneratedNever();
            entity.Property(e => e.BDefault).HasDefaultValue(false);
            entity.Property(e => e.RtblIncidentPriorityChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentStatus>(entity =>
        {
            entity.HasKey(e => e.IdIncidentStatus).HasName("PK__rtblTaskStatus");

            entity.Property(e => e.IdIncidentStatus).ValueGeneratedNever();
            entity.Property(e => e.RtblIncidentStatusChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentTemplate>(entity =>
        {
            entity.HasKey(e => e.IdIncidentTemplates).HasName("PK__rtblTaskTemplates");

            entity.Property(e => e.RtblIncidentTemplatesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentType>(entity =>
        {
            entity.Property(e => e.BActive).HasDefaultValue(true);
            entity.Property(e => e.BAllowOverride).HasDefaultValue(true);
            entity.Property(e => e.BAllowOverrideIncidentType).HasDefaultValue(true);
            entity.Property(e => e.RtblIncidentTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblIncidentsArchive>(entity =>
        {
            entity.Property(e => e.RtblIncidentsArchiveChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKbadocLink>(entity =>
        {
            entity.Property(e => e.ILinkSource).HasDefaultValue(0);
            entity.Property(e => e.RtblKbadocLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKbcategoryLink>(entity =>
        {
            entity.Property(e => e.RtblKbcategoryLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKbdescriptionLink>(entity =>
        {
            entity.Property(e => e.RtblKbdescriptionLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKbdescriptionSetup>(entity =>
        {
            entity.HasKey(e => e.IdKbdescriptionSetup)
                .HasName("PK__rtblKBDescriptionSetup_idKBDescriptionSetup")
                .IsClustered(false);

            entity.Property(e => e.RtblKbdescriptionSetupChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKnowledgeBase>(entity =>
        {
            entity.Property(e => e.BIsActive).HasDefaultValue(true);
            entity.Property(e => e.CArticleNumber).HasDefaultValueSql("((0))");
            entity.Property(e => e.IStockId).HasDefaultValue(0);
            entity.Property(e => e.RtblKnowledgeBaseChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKnowledgeBaseCat>(entity =>
        {
            entity.HasKey(e => e.IdKnowledgeBaseCat).HasName("PK__rtblKnowledgeBaseCatGroupSetup");

            entity.Property(e => e.IdKnowledgeBaseCat).ValueGeneratedNever();
            entity.Property(e => e.RtblKnowledgeBaseCatChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKnowledgeBaseCatValue>(entity =>
        {
            entity.HasKey(e => e.IdKnowledgeBaseCatValue).HasName("PK__rtblKnowledgeBaseCat");

            entity.Property(e => e.RtblKnowledgeBaseCatValueChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblKnowledgeBaseLink>(entity =>
        {
            entity.HasKey(e => e.IdKnowledgeBaseLinks)
                .HasName("PK__rtblProductHistoryLinks")
                .IsClustered(false);

            entity.Property(e => e.RtblKnowledgeBaseLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblNotify>(entity =>
        {
            entity.HasKey(e => e.IdNotify).IsClustered(false);

            entity.HasIndex(e => e.IForAgentId, "idx_ForAgent").HasFillFactor(90);

            entity.Property(e => e.RtblNotifyChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblOpportunity>(entity =>
        {
            entity.Property(e => e.RtblOpportunityChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblOpportunityCompetitor>(entity =>
        {
            entity.Property(e => e.RtblOpportunityCompetitorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblOpportunityDocLink>(entity =>
        {
            entity.Property(e => e.RtblOpportunityDocLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblOpportunitySource>(entity =>
        {
            entity.Property(e => e.RtblOpportunitySourceChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblOpportunityStage>(entity =>
        {
            entity.Property(e => e.RtblOpportunityStageChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblOpportunityStatus>(entity =>
        {
            entity.Property(e => e.RtblOpportunityStatusChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblPeopleLink>(entity =>
        {
            entity.HasKey(e => e.IdPeopleLinks).IsClustered(false);

            entity.HasIndex(e => e.IDebtorId, "idxCompanyID").HasFillFactor(90);

            entity.HasIndex(e => e.IPeopleId, "idxPeopleID")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.RtblPeopleLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblPerson>(entity =>
        {
            entity.Property(e => e.RtblPeopleChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblProspect>(entity =>
        {
            entity.Property(e => e.BChargeTax).HasDefaultValue(true);
            entity.Property(e => e.RtblProspectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblRefBase>(entity =>
        {
            entity.HasKey(e => e.IdRefBase).IsClustered(false);

            entity.HasIndex(e => e.CRefType, "IX__rtblRefBase_cRefType").HasFillFactor(90);

            entity.Property(e => e.INextNo).HasDefaultValue(100000);
            entity.Property(e => e.RtblRefBaseChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblRefBook>(entity =>
        {
            entity.HasIndex(e => new { e.IRefBaseId, e.IBookedNo }, "IX__rtblRefBook_iRefBaseID_iBookedNo").HasFillFactor(90);

            entity.Property(e => e.RtblRefBookChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblStockLink>(entity =>
        {
            entity.HasKey(e => e.IdStockLinks).HasName("PK__rtblProdLinks");

            entity.HasIndex(e => e.IDclink, "idxStockLinks_DCLink").HasFillFactor(90);

            entity.HasIndex(e => e.IStockId, "idxStockLinks_StockID").HasFillFactor(90);

            entity.HasIndex(e => e.IWhseId, "idxStockLinks_WhseID").HasFillFactor(90);

            entity.Property(e => e.BItemActive).HasDefaultValue(true);
            entity.Property(e => e.ITaxTypeId).HasDefaultValue(0);
            entity.Property(e => e.RtblStockLinksChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblUserDict>(entity =>
        {
            entity.HasIndex(e => e.CTableName, "idxcTableName").HasFillFactor(90);

            entity.Property(e => e.RtblUserDictChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblWorkCal>(entity =>
        {
            entity.Property(e => e.RtblWorkCalChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RtblWorkCalExDate>(entity =>
        {
            entity.Property(e => e.RtblWorkCalExDatesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvCmstockFull>(entity =>
        {
            entity.ToView("_rvCMStockFull");

            entity.Property(e => e.StkItemChecksum).IsFixedLength();
            entity.Property(e => e.StockLink).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RvContract>(entity =>
        {
            entity.ToView("_rvContracts");

            entity.Property(e => e.RtblContractsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvEscGrpAgent>(entity =>
        {
            entity.ToView("_rvEscGrpAgents");

            entity.Property(e => e.CAccessApgroupChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessArgroupChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessBranchChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessDocCatChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessDocCatGroupChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessIncidentTypeChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessIncidentTypeGroupChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessOtherTxWhChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessProjectChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessPurchaseWhChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessRepChkLstInd).IsFixedLength();
            entity.Property(e => e.CAccessSalesWhChkLstInd).IsFixedLength();
            entity.Property(e => e.RtblAgentsChecksum).IsFixedLength();
            entity.Property(e => e.RtblEscalateGrpMembersChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvIncidentLog>(entity =>
        {
            entity.ToView("_rvIncidentLog");
        });

        modelBuilder.Entity<RvIncidentLogFull>(entity =>
        {
            entity.ToView("_rvIncidentLogFull");
        });

        modelBuilder.Entity<RvIncidentLogFullArchive>(entity =>
        {
            entity.ToView("_rvIncidentLogFull_Archive");
        });

        modelBuilder.Entity<RvIncidentType>(entity =>
        {
            entity.ToView("_rvIncidentTypes");

            entity.Property(e => e.RtblIncidentTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvIncidentsFull>(entity =>
        {
            entity.ToView("_rvIncidentsFull");
        });

        modelBuilder.Entity<RvIncidentsFullArchive>(entity =>
        {
            entity.ToView("_rvIncidentsFull_Archive");
        });

        modelBuilder.Entity<RvIncidentsFullPro>(entity =>
        {
            entity.ToView("_rvIncidentsFull_Pro");
        });

        modelBuilder.Entity<RvKnowledgeBaseCategoryFull>(entity =>
        {
            entity.ToView("_rvKnowledgeBaseCategoryFull");

            entity.Property(e => e.RtblKnowledgeBaseCatValueChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvKnowledgeBaseFull>(entity =>
        {
            entity.ToView("_rvKnowledgeBaseFull");

            entity.Property(e => e.RtblKnowledgeBaseChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvOpportunityCompetitorFull>(entity =>
        {
            entity.ToView("_rvOpportunityCompetitorFull");

            entity.Property(e => e.RtblOpportunityCompetitorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvOpportunityFull>(entity =>
        {
            entity.ToView("_rvOpportunityFull");

            entity.Property(e => e.RtblOpportunityChecksum).IsFixedLength();
        });

        modelBuilder.Entity<RvProspect>(entity =>
        {
            entity.ToView("_rvProspects");

            entity.Property(e => e.RtblProspectChecksum).IsFixedLength();
        });

        modelBuilder.Entity<SalesRep>(entity =>
        {
            entity.HasKey(e => e.IdSalesRep).HasName("PK_SALESREP");

            entity.HasIndex(e => e.Code, "idxCode").HasFillFactor(90);

            entity.Property(e => e.SalesRepChecksum).IsFixedLength();
        });

        modelBuilder.Entity<SerialMf>(entity =>
        {
            entity.HasKey(e => e.SerialCounter).HasName("PK_SERIALMF");

            entity.HasIndex(e => new { e.SnstockLink, e.CurrentLoc, e.SerialNumber }, "idxCode_Loc_Serial").HasFillFactor(90);

            entity.HasIndex(e => e.SerialNumber, "idxSerial").HasFillFactor(90);

            entity.HasIndex(e => new { e.SerialNumber, e.SnstockLink }, "idxSerial_Code").HasFillFactor(90);

            entity.Property(e => e.SerialMfChecksum).IsFixedLength();
        });

        modelBuilder.Entity<SerialTx>(entity =>
        {
            entity.HasKey(e => e.SntxCounter).HasName("PK_SERIALTX");

            entity.Property(e => e.SerialTxChecksum).IsFixedLength();
        });

        modelBuilder.Entity<SimpleSetting>(entity =>
        {
            entity.HasKey(e => e.SimpleSettingId).HasName("PK_CentralSearchSettings");
        });

        modelBuilder.Entity<SimtblReportLayout>(entity =>
        {
            entity.Property(e => e.IdReportLayout).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SimtblReqLine>(entity =>
        {
            entity.Property(e => e.BIsLot).HasDefaultValue(false);
            entity.Property(e => e.BIsSerialItem).HasDefaultValue(false);
            entity.Property(e => e.CType).IsFixedLength();
            entity.Property(e => e.IStockingUnitCategoryId).HasDefaultValue(0);
            entity.Property(e => e.IStockingUnitId).HasDefaultValue(0);
            entity.Property(e => e.IUnitCategoryId).HasDefaultValue(0);
        });

        modelBuilder.Entity<SimtblStkIssueLine>(entity =>
        {
            entity.Property(e => e.BIsSerialItem).HasDefaultValue(false);
            entity.Property(e => e.CProject).IsFixedLength();
            entity.Property(e => e.CType).IsFixedLength();
            entity.Property(e => e.CTypeDetails).IsFixedLength();
            entity.Property(e => e.IStockingUnitCategoryId).HasDefaultValue(0);
            entity.Property(e => e.IStockingUnitId).HasDefaultValue(0);
            entity.Property(e => e.IUnitCategoryId).HasDefaultValue(0);
        });

        modelBuilder.Entity<SimtblStockIssueMaster>(entity =>
        {
            entity.Property(e => e.CType).IsFixedLength();
        });

        modelBuilder.Entity<SlipLay>(entity =>
        {
            entity.HasKey(e => e.IdslipLay)
                .HasName("PK_SlipLay_IDSlipLay")
                .IsClustered(false);

            entity.Property(e => e.SlipLayChecksum).IsFixedLength();
        });

        modelBuilder.Entity<StDfTbl>(entity =>
        {
            entity.HasKey(e => e.IdStDfTbl).HasName("PK_STDFTBL");

            entity.Property(e => e.AutoInvNum).HasDefaultValue(false);
            entity.Property(e => e.BAutoCgrnumber).HasDefaultValue(true);
            entity.Property(e => e.BAutoGivnumber).HasDefaultValue(true);
            entity.Property(e => e.BAutoSbsinumber).HasDefaultValue(true);
            entity.Property(e => e.BBuyUsingDimensions).HasDefaultValue(false);
            entity.Property(e => e.BCalculateTaxPerLine).HasDefaultValue(true);
            entity.Property(e => e.BFinLinePostDocDesc).HasDefaultValue(true);
            entity.Property(e => e.BGrvSplitUseExemptTax).HasDefaultValue(true);
            entity.Property(e => e.BInvGrvSplit).HasDefaultValue(false);
            entity.Property(e => e.BInvJrBatchAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BInvJrRefAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BInvLinePostDocDesc).HasDefaultValue(true);
            entity.Property(e => e.BInvPrcUpdBatchAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BInvPrcUpdRefAutoNum).HasDefaultValue(true);
            entity.Property(e => e.BIsInclusive).HasDefaultValue(true);
            entity.Property(e => e.BIsPerpetual).HasDefaultValue(true);
            entity.Property(e => e.BPostCostVarianceGlline).HasDefaultValue(true);
            entity.Property(e => e.BSellUsingDimensions).HasDefaultValue(false);
            entity.Property(e => e.BUseDimensions).HasDefaultValue(false);
            entity.Property(e => e.BUseUom).HasDefaultValue(true);
            entity.Property(e => e.CCostPriceEncodingKey).HasDefaultValue("ABCDFGHJKL.");
            entity.Property(e => e.CDefMeasurement).HasDefaultValueSql("((0))");
            entity.Property(e => e.CMeasurementRounding).HasDefaultValueSql("((0))");
            entity.Property(e => e.CRoundingOption).HasDefaultValueSql("((0))");
            entity.Property(e => e.DefaultAdjDesc).HasDefaultValue(false);
            entity.Property(e => e.FilterStartLength).HasDefaultValue(0);
            entity.Property(e => e.StDfTblChecksum).IsFixedLength();
        });

        modelBuilder.Entity<StkItem>(entity =>
        {
            entity.HasKey(e => e.StockLink).HasName("PK_STKITEM");

            entity.ToTable("StkItem", tb => tb.HasTrigger("trgStkItemNegStock"));

            entity.HasIndex(e => e.BarCode, "idxBarCode").HasFillFactor(90);

            entity.HasIndex(e => e.Description1, "idxDescription1").HasFillFactor(90);

            entity.HasIndex(e => e.ItemGroup, "idxGroup").HasFillFactor(90);

            entity.Property(e => e.BCommissionItem).HasDefaultValue(true);
            entity.Property(e => e.BLotMustExpire).HasDefaultValue(true);
            entity.Property(e => e.BOverrideSell).HasDefaultValue(false);
            entity.Property(e => e.CBuyUnit).HasDefaultValueSql("((0))");
            entity.Property(e => e.CBuyWeight).HasDefaultValue(0.0);
            entity.Property(e => e.CEachDescription).HasDefaultValueSql("((0))");
            entity.Property(e => e.CMeasurement).HasDefaultValueSql("((0))");
            entity.Property(e => e.CSellUnit).HasDefaultValueSql("((0))");
            entity.Property(e => e.CSellWeight).HasDefaultValue(0.0);
            entity.Property(e => e.FBuyArea).HasDefaultValue(0.0);
            entity.Property(e => e.FBuyHeight).HasDefaultValue(0.0);
            entity.Property(e => e.FBuyLength).HasDefaultValue(0.0);
            entity.Property(e => e.FBuyVolume).HasDefaultValue(0.0);
            entity.Property(e => e.FBuyWidth).HasDefaultValue(0.0);
            entity.Property(e => e.FSellArea).HasDefaultValue(0.0);
            entity.Property(e => e.FSellHeight).HasDefaultValue(0.0);
            entity.Property(e => e.FSellLength).HasDefaultValue(0.0);
            entity.Property(e => e.FSellVolume).HasDefaultValue(0.0);
            entity.Property(e => e.FSellWidth).HasDefaultValue(0.0);
            entity.Property(e => e.ItemActive).HasDefaultValue(true);
            entity.Property(e => e.StkItemChecksum).IsFixedLength();
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.HasKey(e => e.IdTaxRate).HasName("PK_TAXRATE");

            entity.Property(e => e.BActiveTaxType).HasDefaultValue(true);
            entity.Property(e => e.BRequireRrp).HasDefaultValue(false);
            entity.Property(e => e.TaxRateChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Tender>(entity =>
        {
            entity.HasKey(e => e.IdTender).HasName("PK_TENDER");

            entity.HasIndex(e => e.Description, "idxDesc").HasFillFactor(90);

            entity.Property(e => e.BApplyDocumentRounding).HasDefaultValue(false);
            entity.Property(e => e.TenderChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Till>(entity =>
        {
            entity.HasKey(e => e.IdTills).HasName("PK_TILLS");

            entity.Property(e => e.TillsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<TrCode>(entity =>
        {
            entity.Property(e => e.DebitTrans).HasDefaultValue(true);
            entity.Property(e => e.TrCodesChecksum).IsFixedLength();
        });

        modelBuilder.Entity<VenClass>(entity =>
        {
            entity.HasKey(e => e.IdVenClass).HasName("PK_VENCLASS");

            entity.Property(e => e.VenClassChecksum).IsFixedLength();
        });

        modelBuilder.Entity<VenDef>(entity =>
        {
            entity.Property(e => e.BUseAllocStoredProc).HasDefaultValue(true);
            entity.Property(e => e.VenDefChecksum).IsFixedLength();
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Dclink).HasName("PK_VENDOR");

            entity.HasIndex(e => e.Account, "idxAccount").HasFillFactor(90);

            entity.HasIndex(e => e.Name, "idxName").HasFillFactor(90);

            entity.HasIndex(e => e.IAreasId, "idx_VENDOR_iAreasID").HasFillFactor(90);

            entity.HasIndex(e => e.IClassId, "idx_VENDOR_iClassID").HasFillFactor(90);

            entity.Property(e => e.BRemittanceChequeEfts).HasDefaultValue(true);
            entity.Property(e => e.BSourceDocPrint).HasDefaultValue(true);
            entity.Property(e => e.UbApbeecompliant).HasDefaultValue(true);
            entity.Property(e => e.UbApblacklistedbyGovt).HasDefaultValue(true);
            entity.Property(e => e.UbApconfirmCompany).HasDefaultValue(true);
            entity.Property(e => e.UbApfailToDeliver).HasDefaultValue(true);
            entity.Property(e => e.UbApworkforGovt).HasDefaultValue(true);
            entity.Property(e => e.VendorChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhseMst>(entity =>
        {
            entity.HasKey(e => e.WhseLink).HasName("PK_WHSEMST");

            entity.Property(e => e.BAllowToBuyInto).HasDefaultValue(true);
            entity.Property(e => e.BAllowToSellFrom).HasDefaultValue(true);
            entity.Property(e => e.WhseMstChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhseStk>(entity =>
        {
            entity.HasKey(e => e.IdWhseStk).HasName("PK_WHSESTK");

            entity.ToTable("WhseStk", tb => tb.HasTrigger("trgWhseStkNegStock"));

            entity.HasIndex(e => e.WhstockLink, "idxWhseStk_StockLink").HasFillFactor(90);

            entity.HasIndex(e => e.WhwhseId, "idxWhseStk_WhseID").HasFillFactor(90);

            entity.HasIndex(e => new { e.WhwhseId, e.WhstockLink }, "idxWhseStock").HasFillFactor(90);

            entity.Property(e => e.WhseStkChecksum).IsFixedLength();
            entity.Property(e => e.WhuseDefaultDefs).HasDefaultValue(true);
            entity.Property(e => e.WhuseInfoDefs).HasDefaultValue(true);
            entity.Property(e => e.WhuseOrderDefs).HasDefaultValue(true);
            entity.Property(e => e.WhusePriceDefs).HasDefaultValue(true);
            entity.Property(e => e.WhuseSupplierDefs).HasDefaultValue(true);
        });

        modelBuilder.Entity<WhtBatch>(entity =>
        {
            entity.Property(e => e.WhtBatchChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhtBatchStatus>(entity =>
        {
            entity.Property(e => e.WhtBatchStatusChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhtDefaultSetting>(entity =>
        {
            entity.Property(e => e.IsGlItemToShow).HasDefaultValue(true);
            entity.Property(e => e.IsServiceItemToShow).HasDefaultValue(true);
            entity.Property(e => e.IsStItemToShow).HasDefaultValue(true);
            entity.Property(e => e.WhtDefaultSettingsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhtState>(entity =>
        {
            entity.Property(e => e.WhtStateChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhtTaxMaster>(entity =>
        {
            entity.Property(e => e.WhtTaxMasterChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WhtUserDetail>(entity =>
        {
            entity.Property(e => e.WhtUserDetailsChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WtblIpadDetail>(entity =>
        {
            entity.Property(e => e.BIsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<WtblIpadUser>(entity =>
        {
            entity.ToTable("_wtblIPadUser", tb => tb.HasTrigger("_wtrINCDeleteDeviceUserInvCountLink"));

            entity.Property(e => e.BUseInvoice).HasDefaultValue(false);
        });

        modelBuilder.Entity<WtblMapIpadUserToInvCount>(entity =>
        {
            entity.Property(e => e.WtblMapIpadUserToInvCountChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WtblSystem>(entity =>
        {
            entity.Property(e => e.CIdentity).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CValue).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<WvDeviceUser>(entity =>
        {
            entity.ToView("_wvDeviceUsers");
        });

        modelBuilder.Entity<WvIiactiveRequisition>(entity =>
        {
            entity.ToView("_wvIIActiveRequisition");
        });

        modelBuilder.Entity<WvIiincidentFull>(entity =>
        {
            entity.ToView("_wvIIIncidentFull");
        });

        modelBuilder.Entity<WvIiinventoryIssueNote>(entity =>
        {
            entity.ToView("_wvIIInventoryIssueNote");
        });

        modelBuilder.Entity<WvIinonWorkflowIncidentType>(entity =>
        {
            entity.ToView("_wvIINonWorkflowIncidentTypes");

            entity.Property(e => e.RtblIncidentTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WvIirequisition>(entity =>
        {
            entity.ToView("_wvIIRequisition");
        });

        modelBuilder.Entity<WvIistockIssueNoteList>(entity =>
        {
            entity.ToView("_wvIIStockIssueNoteList");

            entity.Property(e => e.CType).IsFixedLength();
            entity.Property(e => e.IAccOrJobId).IsFixedLength();
        });

        modelBuilder.Entity<WvIiwarehouseList>(entity =>
        {
            entity.ToView("_wvIIWarehouseList");

            entity.Property(e => e.WhseMstChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WvIiworkflowIncidentType>(entity =>
        {
            entity.ToView("_wvIIWorkflowIncidentTypes");

            entity.Property(e => e.RtblIncidentTypeChecksum).IsFixedLength();
        });

        modelBuilder.Entity<WvIiworkflowRequisition>(entity =>
        {
            entity.ToView("_wvIIWorkflowRequisition");
        });

        modelBuilder.Entity<WvIncinvCntBatchByDeviceUser>(entity =>
        {
            entity.ToView("_wvINCInvCntBatchByDeviceUser");
        });

        modelBuilder.Entity<WvIncinventoryCountBatch>(entity =>
        {
            entity.ToView("_wvINCInventoryCountBatch");

            entity.Property(e => e.CBinLocationsChkLstInd).IsFixedLength();
            entity.Property(e => e.CGroupsChkLstInd).IsFixedLength();
            entity.Property(e => e.CInventoryTypesChkLstInd).IsFixedLength();
            entity.Property(e => e.CLotStatusChkLstInd).IsFixedLength();
            entity.Property(e => e.CPacksChkLstInd).IsFixedLength();
            entity.Property(e => e.CWarehousesChkLstInd).IsFixedLength();
        });

        modelBuilder.Entity<WvRfqevoRestrictedSupplier>(entity =>
        {
            entity.ToView("_wvRFQEvoRestrictedSupplier");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
