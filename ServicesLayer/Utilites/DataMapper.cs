using DataLayer.Models;
using ServicesLayer.DTOs;
using VSDCAPI;

namespace ServicesLayer.Utilites;

public static class DataMapper
{
    public static ItemList MapDataItem(ZraStockMaster import, int itemSeq)
    {
        return new ItemList
        {
            itemSeq = itemSeq,
            itemCd = import.ItemCode ?? "",
            itemClsCd = import.ItemClassificationCode ?? "",
            itemTyCd = import.ItemTypeCode ?? "",
            itemNm = import.OriginNationCode ?? "",
            pkgUnitCd = import.PackagingUnitCode ?? "",
            qtyUnitCd = import.QuantityUnitCode ?? "",
            qty = import.Quantity,
            prc = import.Prc ?? 0,
            splyAmt = import.SplyAmt ?? 0,
            vatCatCd = import.VatCatCd ?? "",
            taxblAmt = (double)(import.TaxblAmt ?? 0),
            taxAmt = (double)(import.TaxAmt ?? 0),
            totAmt = import.TotAmt ?? 0
        };
    }

    public static UpdateItemRequest MapData(ZRASTockAdjustment import)
    {
        return new UpdateItemRequest
        {
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            itemCd = import.ItemClsCd ?? "",
            itemClsCd = Convert.ToInt32(import.ItemClsCd ?? "0"),
            itemTyCd = import.ItemTyCd.ToString(),
            itemNm = import.ItemNm ?? "",
            orgnNatCd = "ZM",
            pkgUnitCd = import.PkgUnitCd ?? "",
            qtyUnitCd = import.QtyUnitCd ?? "",
            vatCatCd = import.VatCatCd ?? "",
            iplCatCd = null,
            tlCatCd = null,
            exciseTxCatCd = null,
            btchNo = null,
            dftPrc = Math.Round((import.SplyAmt ?? 0.0000d), 4),
            isrcAplcbYn = "N",
            useYn = "Y",
            regrNm = DeviceDetails.regrNm,
            regrId = DeviceDetails.regrId,
            modrNm = DeviceDetails.modrNm,
            modrId = DeviceDetails.modrId
        };
    }

    public static UpdateItemRequest MapData(ZraInvoiceItem import)
    {
        return new UpdateItemRequest
        {
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            itemCd = import.ItemCode ?? "",
            itemClsCd = Convert.ToInt32(import.ItemClassificationCode ?? "0"),
            itemTyCd = import.itemTyCd.ToString(),
            itemNm = import.ItemSequenceNumber.ToString() ?? "",
            orgnNatCd = "ZM",
            pkgUnitCd = import.PackagingUnitCode ?? "",
            qtyUnitCd = import.QuantityUnitCode ?? "",
            vatCatCd = import.vatCatCd ?? "",
            iplCatCd = null,
            tlCatCd = null,
            exciseTxCatCd = null,
            btchNo = null,
            dftPrc = (double)import.UnitPrice,
            isrcAplcbYn = "N",
            useYn = "Y",
            regrNm = DeviceDetails.regrNm,
            regrId = DeviceDetails.regrId,
            modrNm = DeviceDetails.modrNm,
            modrId = DeviceDetails.modrId
        };
    }

    public static SaveStockItemRequest MapStockData(ZraInvoice import)
    {
        var itemList = new List<ItemList>();
        foreach (var item in import!.Items)
        {
            itemList.Add(
                new ItemList()
                {
                    itemSeq = item.ItemSequenceNumber,
                    itemCd = item.ItemCode ?? "0",
                    itemClsCd = item.ItemClassificationCode ?? "0",
                    itemNm = item.ItemDesc ?? "",
                    pkgUnitCd = item.PackagingUnitCode ?? "",
                    pkg = item.Quantity,
                    qtyUnitCd = item.QuantityUnitCode ?? "",
                    qty = item.Quantity,
                    prc = (double)item.UnitPrice,
                    splyAmt = (double)item.UnitPrice,
                    totDcAmt =(double) item.DiscountAmount,
                    taxblAmt = (double)item.VatableAmount,
                    vatCatCd = item.vatCatCd,
                    taxAmt = (double)item.TaxAmount,
                    totAmt = (double)item.TotalAmount
                }
            );
        }
        
        return new SaveStockItemRequest
        {
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            orgSarNo = Convert.ToInt32(import.OriginalInvoiceNumber),
            regTyCd = "0",
            custTpin = string.IsNullOrWhiteSpace(import.CustomerTpin) ? null: import.CustomerTpin,
            custNm = import.CustomerName,
            custBhfId = import.BranchId,
            sarTyCd ="02",
            ocrnDt = import.SaleDate.ToString("yyyyMMdd"),
            totItemCnt = import.Items.Count,
            totTaxblAmt = (double)import.Items.Sum(item => item.VatableAmount),
            totTaxAmt = (double)import.Items.Sum(item => item.TaxAmount),
            totAmt = (double)import.Items.Sum(item => item.TotalAmount),
            remark = "Imported from Service",
            regrNm = DeviceDetails.regrNm,
            regrId = DeviceDetails.regrId,
            modrNm = DeviceDetails.modrNm,
            modrId = DeviceDetails.modrId,
            itemList = itemList
        };
    }

    public static SaveStockItemRequest MapStockData(ZraPurchase import)
    {
        var itemList = new List<ItemList>();
        foreach (var item in import!.Items)
        {
            itemList.Add(
                new ItemList()
                {
                    itemSeq = item.ItemSequenceNumber,
                    itemCd = item.ItemCode ?? "0",
                    itemClsCd = item.ItemClassificationCode ?? "0",
                    itemNm = item.ItemDesc ?? "",
                    pkgUnitCd = item.PackagingUnitCode ?? "",
                    pkg = item.Quantity,
                    qtyUnitCd = item.QuantityUnitCode ?? "",
                    qty = item.Quantity,
                    prc = (double)item.UnitPrice,
                    splyAmt = (double)item.UnitPrice,
                    totDcAmt =(double) item.DiscountAmount,
                    taxblAmt = (double)item.taxblAmt,
                    vatCatCd = item.vatCatCd,
                    taxAmt = (double)item.taxAmt,
                    totAmt = (double)item.TotalAmount
                }
            );
        }

        return new SaveStockItemRequest
        {
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            //sarNo = Convert.ToInt32(import.SupplierInvoiceNumber),
            orgSarNo = Convert.ToInt32(import.OriginalInvoiceNumber),
            regTyCd = import.regTyCd,
            custTpin = string.IsNullOrWhiteSpace(import.CustomerTpin) ? null: import.CustomerTpin,
            custNm = import.CustomerName,
            custBhfId = import.BranchId,
            sarTyCd ="02",
            ocrnDt = import.SaleDate.ToString("yyyyMMdd"),
            totItemCnt = import.Items.Count,
            totTaxblAmt = (double)import.Items.Sum(item => item.taxblAmt),
            totTaxAmt = (double)import.Items.Sum(item => item.taxAmt),
            totAmt = (double)import.Items.Sum(item => item.TotalAmount),
            remark = "Imported from Service",
            regrNm = DeviceDetails.regrNm,
            regrId = DeviceDetails.regrId,
            modrNm = DeviceDetails.modrNm,
            modrId = DeviceDetails.modrId,
            itemList = itemList
        };
    }

    public static UpdateItemRequest MapData(ZraStockMaster import)
    {
        return new UpdateItemRequest
        {
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            itemCd = import.ItemCode ?? "",
            itemClsCd = Convert.ToInt32(import.ItemClassificationCode ?? "0"),
            itemTyCd = import.ItemTypeCode ?? "",
            itemNm = import.Description ?? "",
            orgnNatCd = import.OriginNationCode ?? "",
            pkgUnitCd = import.PackagingUnitCode ?? "",
            qtyUnitCd = import.QuantityUnitCode ?? "",
            vatCatCd = import.VatCatCd ?? "",
            iplCatCd = null,
            tlCatCd = null,
            exciseTxCatCd = null,
            btchNo = null,
            dftPrc = import.Prc ?? 0d,
            isrcAplcbYn = "N",
            useYn = "Y",
            regrNm = DeviceDetails.regrNm,
            regrId = DeviceDetails.regrId,
            modrNm = DeviceDetails.modrNm,
            modrId = DeviceDetails.modrId
        };
    }

    public static ZraImportData MapData(DTOs.Item import)
    {
        return new ZraImportData
        {
            taskCd = import.taskCd,
            dclDe = import.dclDe,
            itemSeq = import.itemSeq,
            dclNo = import.dclNo,
            hsCd = import.hsCd,
            itemNm = import.itemNm,
            orgnNatCd = import.orgnNatCd,
            exptNatCd = import.exptNatCd,
            pkg = import.pkg,
            pkgUnitCd = import.pkgUnitCd,
            qty = import.qty,
            qtyUnitCd = import.qtyUnitCd,
            totWt = import.totWt,
            netWt = import.netWt,
            spplrNm = import.spplrNm,
            agntNm = import.agntNm,
            invcFcurAmt = import.invcFcurAmt,
            invcFcurCd = import.invcFcurCd,
            invcFcurExcrt = import.invcFcurExcrt,
            dclRefNum = import.dclRefNum
        };
    }

    public static SavePurchasesRequest ConvertPurchase(ZraPurchase purchase)
    {
        var list = new List<ItemList2>();
        foreach (var item in purchase!.Items)
        {
            var listItem = new ItemList2
            {
                itemSeq = item.ItemSequenceNumber,
                itemCd = item.ItemCode,
                itemClsCd = item.ItemClassificationCode,
                itemNm = item.ItemDesc,
                bcd = null,
                pkgUnitCd = item.PackagingUnitCode,
                pkg = 0,
                qtyUnitCd = item.QuantityUnitCode,
                qty = item.Quantity,
                prc = Math.Round(item.UnitPrice, 4),
                splyAmt = Math.Round(item.TotalAmount, 4),
                dcRt = 0,
                dcAmt = 0,
                taxTyCd = item.vatCatCd,
                iplCatCd = null,
                tlCatCd = null,
                taxblAmt = (double)item.taxblAmt,
                vatCatCd = item.vatCatCd,
                iplTaxblAmt = null,
                tlTaxblAmt = null,
                taxAmt = (double)item.taxAmt,
                totAmt = (double)item.TotalAmount
            };
            list.Add(listItem);
        }

        return new SavePurchasesRequest
        {
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            invcNo = ParseNumber(purchase.Id),
            orgInvcNo = ParseNumber(purchase.OriginalInvoiceNumber),
            //spplrTpin = purchase.CustomerTpin ?? "9999999990",
            spplrBhfId = "000",
            spplrNm = purchase.CustomerName,
            spplrInvcNo = purchase.InvoiceNumber,
            regTyCd = purchase.regTyCd,
            pchsTyCd = "N",
            rcptTyCd = purchase.ReceiptTypeCode,
            pmtTyCd = purchase.PaymentTypeCode,
            pchsSttsCd = "02",
            cfmDt = purchase.SaleDate.ToString("yyyyMMddHHmmss") ?? DateTime.Now.ToString("yyyyMMddHHmmss"),
            pchsDt = purchase.SaleDate.ToString("yyyyMMdd") ?? DateTime.Today.ToString("yyyyMMdd"),
            cnclReqDt = "",
            cnclDt = "",
            totItemCnt = list.Count,
            totTaxblAmt = list.Sum(item => item.taxblAmt),
            totTaxAmt = list.Sum(item => item.taxAmt),
            totAmt = list.Sum(item => item.totAmt),
            remark = "remarks",
            regrNm = purchase.IssuerName,
            regrId = purchase.IssuerId,
            modrNm = DeviceDetails.modrNm,
            modrId = DeviceDetails.modrId,
            itemList = list
        };
    }

    private static int ParseNumber(string invoiceNumber)
    {
        if (string.IsNullOrWhiteSpace(invoiceNumber)) return 0; // Return 0 if the input is null or empty
        return int.TryParse(invoiceNumber, out var result) ? result : 0; // Return parsed value or 0
    }

    public static SaveSalesRequest ConvertInvoice(ZraInvoice zraInvoice)
    {
        var custPin = new string(zraInvoice.CustomerTpin!.Where(char.IsDigit).ToArray());
        var noVatOnPatent = zraInvoice.invtottax == 0 ? true : false;

        var invoice = new SaveSalesRequest
        {
            bhfId = DeviceDetails.BhfId,
            tpin = DeviceDetails.Tpin,
            orgSdcId = "SDC0010001160", //to be automated by Nigel
            orgInvcNo = (int)zraInvoice.OriginalInvoiceNumber,
            cisInvcNo = zraInvoice.InvoiceNumber,
            custTpin = string.IsNullOrWhiteSpace(custPin) ? null : custPin, //verify this
            custNm = zraInvoice.CustomerName,
            salesTyCd = "N",
            rcptTyCd = zraInvoice.ReceiptTypeCode,
            pmtTyCd = zraInvoice.PaymentTypeCode,
            salesSttsCd = "02",
            cfmDt = zraInvoice.SaleDate.ToString("yyyyMMddHHmmss"),
            salesDt = zraInvoice.SaleDate.Date < DateTime.Today.AddDays(-30)
                ? DateTime.Today.ToString("yyyyMMdd")
                : zraInvoice.SaleDate.ToString("yyyyMMdd"),
            rfdRsnCd = zraInvoice.RefundReasonCode,
            taxblAmtA = noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.VatableAmount),
            taxblAmtD = noVatOnPatent ? (double)zraInvoice.Items.Sum(item => item.VatableAmount) : 0,
            taxblAmtTot = 0, //noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.VatableAmount),
            taxAmtTot = 0, //noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.TaxAmount),
            prchrAcptcYn = "N",
            //regrId = zraInvoice.RefundReasonCode,
            regrNm = DeviceDetails.regrNm,
            modrId = DeviceDetails.modrId,
            modrNm = DeviceDetails.modrNm,
            saleCtyCd = "1",
            lpoNumber = zraInvoice.LocalPurchaseOrder,
            currencyTyCd = zraInvoice.CurrencyType,
            exchangeRt = zraInvoice.ConversionRate.ToString("F2"),
            destnCountryCd = zraInvoice.DestinationCountryCode,
            dbtRsnCd = "",
            invcAdjustReason = "",
            totAmt = (double)zraInvoice.Items.Sum(item => item.TotalAmount),
            vatTaxblAmt = noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.VatableAmount),
            totTaxblAmt = (double)zraInvoice.Items.Sum(item => item.VatableAmount),
            totItemCnt = zraInvoice.Items.Count,
            totTaxAmt = (double)zraInvoice.Items.Sum(item => item.TaxAmount)
        };

        invoice.itemList = new List<ItemList3>();

        foreach (var item in zraInvoice.Items)
            invoice.itemList.Add(new ItemList3
            {
                itemSeq = item.ItemSequenceNumber,
                itemCd = item.ItemCode,
                //itemClsCd = item.ItemClassificationCode,
                itemNm = item.RefId.ToString(),
                bcd = "",
                pkgUnitCd = item.PackagingUnitCode!,
                pkg = 0,
                qtyUnitCd = item.QuantityUnitCode!,
                qty = (double)item.Quantity,
                prc = (double)item.UnitPrice,
                splyAmt = (double)item.TotalAmount,
                dcRt = 0,
                dcAmt = 0,
                isrccCd = item.IsTaxInclusive.ToString(),
                isrccNm = "",
                isrcRt = 0,
                isrcAmt = 0,
                vatCatCd = noVatOnPatent ? "D" : "A",
                exciseTxCatCd = "",
                tlCatCd = item.TaxLabel,
                iplCatCd = "",
                vatTaxblAmt = (double)item.VatableAmount,
                vatAmt = (double)item.TaxAmount,
                exciseTaxblAmt = 0,
                tlTaxblAmt = 0,
                iplTaxblAmt = 0,
                iplAmt = 0,
                tlAmt = 0,
                exciseTxAmt = 0,
                totAmt = (double)item.TotalAmount
            });
        ;

        invoice.taxAmtA = invoice.itemList
            .Where(item => item.vatCatCd == "A")
            .Sum(item => item.vatAmt);

        invoice.taxAmtA = invoice.itemList
            .Where(item => item.vatCatCd == "A")
            .Sum(item => item.vatAmt);

        return invoice;
    }

    public static UpdateItemRequest MapToUpdateItemRequest(ItemList3 item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        return new UpdateItemRequest
        {
            itemCd = item.itemCd,
            itemClsCd = item.itemClsCd,
            itemTyCd = item.itemTyCd,
            itemNm = item.itemNm,
            pkgUnitCd = item.pkgUnitCd,
            qtyUnitCd = item.qtyUnitCd,
            vatCatCd = item.vatCatCd,
            iplCatCd = item.iplCatCd,
            tlCatCd = item.tlCatCd,
            exciseTxCatCd = item.exciseTxCatCd,
            // bcd = item.bcd,
            dftPrc = item.prc,
            tpin = DeviceDetails.Tpin,
            bhfId = DeviceDetails.BhfId,
            // itemTyCd = null,
            itemStdNm = null,
            orgnNatCd = null,
            btchNo = null,
            addInfo = null,
            sftyQty = 0,
            isrcAplcbYn = null,
            useYn = null,
            regrNm = null,
            modrNm = null,
            modrId = null
        };
    }

    public static DeviceInit MapToDeviceInit(Device.Info deviceInfo)
    {
        return new DeviceInit
        {
            Tpin = deviceInfo.tin,
            TaxprNm = deviceInfo.taxprNm,
            BsnsActv = deviceInfo.bsnsActv,
            BhfId = deviceInfo.bhfId,
            BhfNm = deviceInfo.bhfNm,
            BhfOpenDt = deviceInfo.bhfOpenDt,
            PrvncNm = deviceInfo.prvncNm,
            DstrtNm = deviceInfo.dstrtNm,
            SctrNm = deviceInfo.sctrNm,
            LocDesc = deviceInfo.locDesc,
            HqYn = deviceInfo.hqYn,
            MgrNm = deviceInfo.mgrNm,
            MgrTelNo = deviceInfo.mgrTelNo,
            MgrEmail = deviceInfo.mgrEmail,
            SdicId = deviceInfo.sdcId,
            MrcNo = deviceInfo.mrcNo,
            LastSaleInvcNo = deviceInfo.lastSaleInvcNo,
            LastPchsInvcNo = deviceInfo.lastPchsInvcNo,
            LastSaleRcptNo = deviceInfo.lastSaleRcptNo,
            LastInvcNo = deviceInfo.lastInvcNo,
            LastTrainInvcNo = deviceInfo.lastTrainInvcNo,
            LastProfrmInvcNo = deviceInfo.lastProfrmInvcNo,
            LastCopyInvcNo = deviceInfo.lastCopyInvcNo
        };
    }

    public static ZraSelectCode MapSelectCode(DetailInfo code)
    {
        return new ZraSelectCode
        {
            Cd = code.cd,
            CdNm = code.cdNm,
            UserDfnNm1 = code.userDfnCd1
        };
    }

    public static ZraClassCode MapClassCode(ItemClass code)
    {
        return new ZraClassCode
        {
            ResultDt = DateTime.Now.ToString("yyyyMMddHHmmss"),
            TemClsCd = code.itemClsCd,
            ItemClsNm = code.itemClsNm,
            ItemClsLvl = code.itemClsLvl,
            TaxTyCd = code.taxTyCd,
            MjrTgYn = code.mjrTgYn,
            UseYn = code.useYn
        };
    }

    public static SmartPurchase MapToSmartPurchase(Sale sale)
    {
        if (sale == null) throw new ArgumentNullException(nameof(sale), "Sale cannot be null.");

        // Create the SmartPurchase object
        var smartPurchase = new SmartPurchase
        {
            SpplrTpin = sale.spplrTpin,
            SpplrNm = sale.spplrNm,
            SpplrBhfId = sale.spplrBhfId,
            SpplrInvcNo = sale.spplrInvcNo,
            RcptTyCd = sale.rcptTyCd,
            PmtTyCd = sale.pmtTyCd,
            CfmDt = sale.cfmDt,
            SalesDt = sale.salesDt,
            StockRlsDt = sale.stockRlsDt,
            TotItemCnt = sale.totItemCnt,
            TotTaxblAmt = sale.totTaxblAmt,
            TotTaxAmt = sale.totTaxAmt,
            TotAmt = sale.totAmt,
            Remark = sale.remark,
            // Assuming you want to map the first item in itemList to SmartPurchase
            ItemSeq = sale.itemList?.FirstOrDefault()?.itemSeq,
            ItemCd = sale.itemList?.FirstOrDefault()?.itemCd,
            ItemClsCd = sale.itemList?.FirstOrDefault()?.itemClsCd,
            ItemNm = sale.itemList?.FirstOrDefault()?.itemNm,
            Bcd = sale.itemList?.FirstOrDefault()?.bcd,
            PkgUnitCd = sale.itemList?.FirstOrDefault()?.pkgUnitCd,
            Pkg = sale.itemList?.FirstOrDefault()?.pkg,
            QtyUnitCd = sale.itemList?.FirstOrDefault()?.qtyUnitCd,
            Qty = sale.itemList?.FirstOrDefault()?.qty,
            Prc = sale.itemList?.FirstOrDefault()?.prc,
            SplyAmt = sale.itemList?.FirstOrDefault()?.splyAmt,
            DcRt = sale.itemList?.FirstOrDefault()?.dcRt,
            DcAm = sale.itemList?.FirstOrDefault()?.dcAmt,
            VatCatCd = sale.itemList?.FirstOrDefault()?.vatCatCd,
            IplCatCd = sale.itemList?.FirstOrDefault()?.iplCatCd,
            TlCatCd = sale.itemList?.FirstOrDefault()?.tlCatCd,
            ExciseTxCatC = sale.itemList?.FirstOrDefault()?.exciseTxCatCd,
            VatTaxblAmt = sale.itemList?.FirstOrDefault()?.vatTaxblAmt,
            ExciseTaxblAmt = sale.itemList?.FirstOrDefault()?.exciseTaxblAmt,
            IplTaxblAmt = sale.itemList?.FirstOrDefault()?.iplTaxblAmt,
            TlTaxblAmt = sale.itemList?.FirstOrDefault()?.tlTaxblAmt,
            TaxblAmt = sale.itemList?.FirstOrDefault()?.taxblAmt,
            VatAmt = sale.itemList?.FirstOrDefault()?.vatAmt,
            IplAmt = sale.itemList?.FirstOrDefault()?.iplAmt,
            TlAmt = sale.itemList?.FirstOrDefault()?.tlAmt,
            ExciseTxAmt = sale.itemList?.FirstOrDefault()?.exciseTxAmt,
            TtotAmt = sale.itemList?.FirstOrDefault()?.totAmt
        };

        return smartPurchase;
    }

    public static class DeviceDetails
    {
        public static string Tpin { get; set; } = "1002546945";
        public static string BhfId { get; set; } = "000";
        public static string DvcSrlNo { get; set; } = "CHC-EVO";
        public static string LastReqDt { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");
        public static string regrNm { get; set; } = "ADMIN";
        public static string regrId { get; set; } = "ADMIN";
        public static string modrNm { get; set; } = "ADMIN";
        public static string modrId { get; set; } = "ADMIN";
    }
}