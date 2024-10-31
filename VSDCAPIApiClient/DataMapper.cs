﻿using System;
using System.IO.Compression;
using DataLayer.Models2;
using VSDCAPI;
using VSDCAPIApiClient.DTOs;

namespace VSDCAPIApiClient
{
    public class DataMapper
    {


        public static class DeviceDetails
        {
            public static string Tpin { get; set; } = "1002546945";
            public static string BhfId { get; set; } = "000";
            public static string DvcSrlNo { get; set; } = "CHC-EVO";
            public static string LastReqDt { get; set; } = "20241025201419";
        }

        public static SavePurchasesRequest ConvertPurchase(PurchaseInfo purchase)
        {
            var list = new List<ItemList2>();
            var listItem = new ItemList2
            {
                itemSeq = 1,
                itemCd = "ZM2BGKG0000001",
                itemClsCd = "50102517",
                itemNm = "Item Name1",
                bcd = null,
                pkgUnitCd = "BG",
                pkg = 0,
                qtyUnitCd = "KG",
                qty = 1,
                prc = 100,
                splyAmt = 100,
                dcRt = 0,
                dcAmt = 0,
                taxTyCd = "A",
                iplCatCd = null,
                tlCatCd = null,
                taxblAmt = 86.21,
                vatCatCd = "A",
                iplTaxblAmt = null,
                tlTaxblAmt = null,
                taxAmt = 13.79,
                totAmt = 100.00
            };

            return new SavePurchasesRequest
            {
                tpin = DeviceDetails.Tpin,
                bhfId = DeviceDetails.BhfId,
                invcNo = Convert.ToInt32(purchase.InvoiceNumber),
                orgInvcNo = 0,
                spplrTpin = "9999999990",
                spplrBhfId = "000",
                spplrNm = "Supplier Name1",
                spplrInvcNo = "INV0001",
                regTyCd = "M",
                pchsTyCd = "N",
                rcptTyCd = "P",
                pmtTyCd = "01",
                pchsSttsCd = "02",
                cfmDt = "20240509210300",
                pchsDt = "20240509",
                cnclReqDt = "",
                cnclDt = "",
                totItemCnt = list.Count,
                totTaxblAmt = list.Sum(item => item.taxblAmt),
                totTaxAmt = list.Sum(item => item.taxAmt),
                totAmt = list.Sum(item => item.totAmt),
                remark = "remarks",
                regrNm = "ADMIN",
                regrId = "ADMIN",
                modrNm = "ADMIN",
                modrId = "ADMIN",
                itemList = list
            };
        }

        public static SaveSalesRequest ConvertInvoice(ZraInvoice zraInvoice)
        {
            var custPin = new string(zraInvoice.CustomerTpin!.Where(char.IsDigit).ToArray());
            var noVatOnPatent = zraInvoice.invtottax == 0 ? true : false;

            SaveSalesRequest invoice = new SaveSalesRequest
            {

                bhfId = DeviceDetails.BhfId,
                tpin = DeviceDetails.Tpin,
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
                taxblAmtTot = noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.VatableAmount),
                taxAmtTot = noVatOnPatent ? 0 : (double)zraInvoice.Items.Sum(item => item.TaxAmount),
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
                totItemCnt = zraInvoice.Items.Count

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

            return invoice;
        }

        public static UpdateItemRequest MapToUpdateItemRequest(ItemList3 item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            return new UpdateItemRequest
            {
                itemCd = item.itemCd,
                itemClsCd =  item.itemClsCd,
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
    }
}

