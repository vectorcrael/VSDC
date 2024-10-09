using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SaveSalesRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public int orgInvcNo { get; set; }
        public string cisInvcNo { get; set; }
        public string custTpin { get; set; }
        public string custNm { get; set; }
        public string salesTyCd { get; set; }
        public string rcptTyCd { get; set; }
        public string pmtTyCd { get; set; }
        public string salesSttsCd { get; set; }
        public string cfmDt { get; set; }
        public string salesDt { get; set; }
        public object stockRlsDt { get; set; }
        public object cnclReqDt { get; set; }
        public object cnclDt { get; set; }
        public object rfdDt { get; set; }
        public object rfdRsnCd { get; set; }
        public int totItemCnt { get; set; }
        public double taxblAmtA { get; set; }
        public double taxblAmtB { get; set; }
        public double taxblAmtC1 { get; set; }
        public double taxblAmtC2 { get; set; }
        public double taxblAmtC3 { get; set; }
        public double taxblAmtD { get; set; }
        public double taxblAmtRvat { get; set; }
        public double taxblAmtE { get; set; }
        public double taxblAmtF { get; set; }
        public double taxblAmtIpl1 { get; set; }
        public int taxblAmtIpl2 { get; set; }
        public double taxblAmtTl { get; set; }
        public int taxblAmtEcm { get; set; }
        public double taxblAmtExeeg { get; set; }
        public double taxblAmtTot { get; set; }
        public int taxRtA { get; set; }
        public int taxRtB { get; set; }
        public int taxRtC1 { get; set; }
        public int taxRtC2 { get; set; }
        public int taxRtC3 { get; set; }
        public int taxRtD { get; set; }
        public double tlAmt { get; set; }
        public int taxRtRvat { get; set; }
        public int taxRtE { get; set; }
        public int taxRtF { get; set; }
        public int taxRtIpl1 { get; set; }
        public int taxRtIpl2 { get; set; }
        public double taxRtTl { get; set; }
        public int taxRtEcm { get; set; }
        public int taxRtExeeg { get; set; }
        public int taxRtTot { get; set; }
        public double taxAmtA { get; set; }
        public double taxAmtB { get; set; }
        public double taxAmtC1 { get; set; }
        public double taxAmtC2 { get; set; }
        public double taxAmtC3 { get; set; }
        public double taxAmtD { get; set; }
        public double taxAmtRvat { get; set; }
        public double taxAmtE { get; set; }
        public double taxAmtF { get; set; }
        public double taxAmtIpl1 { get; set; }
        public double taxAmtIpl2 { get; set; }
        public double taxAmtTl { get; set; }
        public double taxAmtEcm { get; set; }
        public double taxAmtExeeg { get; set; }
        public double taxAmtTot { get; set; }
        public double totTaxblAmt { get; set; }
        public double totTaxAmt { get; set; }
        public int totAmt { get; set; }
        public string prchrAcptcYn { get; set; }
        public string remark { get; set; }
        public string regrId { get; set; }
        public string regrNm { get; set; }
        public string modrId { get; set; }
        public string modrNm { get; set; }
        public string saleCtyCd { get; set; }
        public object lpoNumber { get; set; }
        public string currencyTyCd { get; set; }
        public string exchangeRt { get; set; }
        public string destnCountryCd { get; set; }
        public string dbtRsnCd { get; set; }
        public string invcAdjustReason { get; set; }

        public List<ItemList3> itemList { get; set; }
    }

    public class ItemList3
    {
        public int itemSeq { get; set; }
        public string itemCd { get; set; }
        public string itemClsCd { get; set; }
        public string itemNm { get; set; }
        public string bcd { get; set; }
        public string pkgUnitCd { get; set; }
        public double pkg { get; set; }
        public string qtyUnitCd { get; set; }
        public double qty { get; set; }
        public int prc { get; set; }
        public int splyAmt { get; set; }
        public double dcRt { get; set; }
        public double dcAmt { get; set; }
        public string isrccCd { get; set; }
        public string isrccNm { get; set; }
        public double isrcRt { get; set; }
        public double isrcAmt { get; set; }
        public string vatCatCd { get; set; }
        public object exciseTxCatCd { get; set; }
        public object tlCatCd { get; set; }
        public string iplCatCd { get; set; }
        public double vatTaxblAmt { get; set; }
        public double vatAmt { get; set; }
        public int exciseTaxblAmt { get; set; }
        public double tlTaxblAmt { get; set; }
        public double iplTaxblAmt { get; set; }
        public double iplAmt { get; set; }
        public double tlAmt { get; set; }
        public int exciseTxAmt { get; set; }
        public int totAmt { get; set; }
    }
}