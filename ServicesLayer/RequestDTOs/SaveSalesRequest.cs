namespace VSDCAPI;

public class SaveSalesRequest
{
    public string tpin { get; set; }
    public string bhfId { get; set; }
    public string orgSdcId { get; set; }
    public int orgInvcNo { get; set; }
    public string cisInvcNo { get; set; }
    public string? custTpin { get; set; }
    public string custNm { get; set; }
    public string salesTyCd { get; set; }
    public string rcptTyCd { get; set; }
    public string pmtTyCd { get; set; }
    public string salesSttsCd { get; set; }
    public string cfmDt { get; set; }
    public string salesDt { get; set; }
    public object stockRlsDt { get; set; } = null;
    public object cnclReqDt { get; set; } = null;
    public object cnclDt { get; set; } = null;
    public object rfdDt { get; set; } = null;
    public object rfdRsnCd { get; set; }
    public int totItemCnt { get; set; }

    public double taxblAmtA { get; set; } = 0;
    public double taxblAmtB { get; set; } = 0;
    public double taxblAmtC1 { get; set; } = 0;
    public double taxblAmtC2 { get; set; } = 0;
    public double taxblAmtC3 { get; set; } = 0;
    public double taxblAmtD { get; set; } = 0;
    public double taxblAmtRvat { get; set; } = 0;
    public double taxblAmtE { get; set; } = 0;
    public double taxblAmtF { get; set; } = 0;
    public double taxblAmtIpl1 { get; set; } = 0;
    public int taxblAmtIpl2 { get; set; } = 0;
    public double taxblAmtTl { get; set; } = 0;
    public int taxblAmtEcm { get; set; } = 0;
    public double taxblAmtExeeg { get; set; } = 0;
    public double taxblAmtTot { get; set; } = 0;
    public int taxRtA { get; set; } = 16;
    public int taxRtB { get; set; } = 16;
    public int taxRtC1 { get; set; } = 0;
    public int taxRtC2 { get; set; } = 0;
    public int taxRtC3 { get; set; } = 0;
    public int taxRtD { get; set; } = 0;
    public double tlAmt { get; set; } = 0;
    public string taxRtRvat { get; set; } = "16";
    public int taxRtE { get; set; } = 0;
    public int taxRtF { get; set; } = 10;
    public int taxRtIpl1 { get; set; } = 5;
    public int taxRtIpl2 { get; set; } = 0;
    public double taxRtTl { get; set; } = 1.5;
    public int taxRtEcm { get; set; } = 5;
    public int taxRtExeeg { get; set; } = 3;
    public int taxRtTot { get; set; } = 0;
    public double taxAmtA { get; set; } = 0;
    public double taxAmtB { get; set; } = 0;
    public double taxAmtC1 { get; set; } = 0;
    public double taxAmtC2 { get; set; } = 0;
    public double taxAmtC3 { get; set; } = 0;
    public double taxAmtD { get; set; } = 0;
    public double taxAmtRvat { get; set; } = 0;
    public double taxAmtE { get; set; } = 0;
    public double taxAmtF { get; set; } = 0;
    public double taxAmtIpl1 { get; set; } = 0;
    public double taxAmtIpl2 { get; set; } = 0;
    public double taxAmtTl { get; set; } = 0;
    public double taxAmtEcm { get; set; } = 0;
    public double taxAmtExeeg { get; set; } = 0;
    public double taxAmtTot { get; set; } = 0;
    public double totTaxblAmt { get; set; } = 0;
    public double totTaxAmt { get; set; } = 0;
    public double vatTaxblAmt { get; set; } = 0;
    public double totAmt { get; set; } = 0;
    public string prchrAcptcYn { get; set; }
    public string remark { get; set; } = null;
    public string regrId { get; set; } = "admin";
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

    public List<ItemList3> itemList { get; set; } = new();
}

public class ItemList3
{
    public int itemSeq { get; set; }
    public string itemCd { get; set; }
    public int itemClsCd { get; set; } = 0;
    public string itemNm { get; set; }
    public string itemTyCd { get; set; }
    public string bcd { get; set; }
    public string pkgUnitCd { get; set; }
    public double pkg { get; set; }
    public string qtyUnitCd { get; set; }
    public double qty { get; set; }
    public double prc { get; set; }
    public double splyAmt { get; set; }
    public double dcRt { get; set; }
    public double dcAmt { get; set; }
    public string isrccCd { get; set; }
    public string isrccNm { get; set; }
    public double isrcRt { get; set; }
    public double isrcAmt { get; set; }
    public string vatCatCd { get; set; }
    public string exciseTxCatCd { get; set; }
    public string tlCatCd { get; set; }
    public string iplCatCd { get; set; }
    public double vatTaxblAmt { get; set; }
    public double vatAmt { get; set; }
    public int exciseTaxblAmt { get; set; }
    public double tlTaxblAmt { get; set; }
    public double iplTaxblAmt { get; set; }
    public double iplAmt { get; set; }
    public double tlAmt { get; set; }
    public int exciseTxAmt { get; set; }
    public double totAmt { get; set; }
}