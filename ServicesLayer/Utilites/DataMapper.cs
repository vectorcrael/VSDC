using System;
using System.IO.Compression;
using DataLayer.Models;
using ServicesLayer.DTOs;
using VSDCAPI;

namespace ServicesLayer
{
    public class DataMapper
    {


        public static class DeviceDetails
        {
            public static string Tpin { get; set; } = "1002546945";
            public static string BhfId { get; set; } = "000";
            public static string DvcSrlNo { get; set; } = "CHC-EVO";
            public static string LastReqDt { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");
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
                modrNm = "ADMIN",
                modrId = "ADMIN",
                itemList = list
            };
        }

        private static int ParseNumber(string invoiceNumber)
        {
            if (string.IsNullOrWhiteSpace(invoiceNumber))
            {
                return 0; // Return 0 if the input is null or empty
            }

            return int.TryParse(invoiceNumber, out int result) ? result : 0; // Return parsed value or 0
        }

        public static SaveSalesRequest ConvertInvoice(ZraInvoice zraInvoice)
        {
            var custPin = new string(zraInvoice.CustomerTpin!.Where(char.IsDigit).ToArray());
            var noVatOnPatent = zraInvoice.invtottax == 0 ? true : false;

            SaveSalesRequest invoice = new SaveSalesRequest
            {

                bhfId = DeviceDetails.BhfId,
                tpin = DeviceDetails.Tpin,
                orgSdcId = "SDC0010001160",//to be automated by Nigel
                orgInvcNo = (int)zraInvoice.OriginalInvoiceNumber,
                cisInvcNo = zraInvoice.InvoiceNumber,
                custTpin = string.IsNullOrWhiteSpace(custPin) ? null : custPin, //verify this
                custNm = zraInvoice.CustomerName,
                salesTyCd = "N",
                rcptTyCd = zraInvoice.ReceiptTypeCode,
                pmtTyCd = zraInvoice.PaymentTypeCode,
                salesSttsCd = "02",
                cfmDt = zraInvoice.SaleDate.ToString("yyyyMMddHHmmss"),
                salesDt = (zraInvoice.SaleDate.Date < DateTime.Today.AddDays(-30)) ? DateTime.Today.ToString("yyyyMMdd") : zraInvoice.SaleDate.ToString("yyyyMMdd"),
                rfdRsnCd = zraInvoice.RefundReasonCode,
                taxblAmtA = noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.VatableAmount),
                taxblAmtD = noVatOnPatent ? (double)zraInvoice.Items.Sum(item => item.VatableAmount) : 0,
                taxblAmtTot = 0,//noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.VatableAmount),
                taxAmtTot = 0,//noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.TaxAmount),
                prchrAcptcYn = "N",
                //regrId = zraInvoice.RefundReasonCode,
                regrNm = "admin",
                modrId = "admin",
                modrNm = "admin",
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
            {

                invoice.itemList.Add(new ItemList3
                {
                    itemSeq = item.ItemSequenceNumber,
                    itemCd = item.ItemCode,
                    //itemClsCd = item.ItemClassificationCode,
                    itemNm = item.RefId.ToString(),
                    bcd = "",
                    pkgUnitCd = item.PackagingUnitCode!.ToString(),
                    pkg = 0,
                    qtyUnitCd = item.QuantityUnitCode!.ToString(),
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
            };

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
                //itemTyCd=item.itemTyCd,
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
                itemTyCd = null,
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
            if (sale == null)
            {
                throw new ArgumentNullException(nameof(sale), "Sale cannot be null.");
            }

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
    }
}

