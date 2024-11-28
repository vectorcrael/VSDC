namespace VSDCAPI;

public class BranchCustomersRequest
{
    public string tpin { get; set; }
    public string bhfId { get; set; }
    public string lastReqDt { get; set; }
    public string custNo { get; set; }
    public string custtpin { get; set; }
    public string custNm { get; set; }
    public object adrs { get; set; }
    public object email { get; set; }
    public object faxNo { get; set; }
    public string useYn { get; set; }
    public object remark { get; set; }
    public string regrNm { get; set; }
    public string regrId { get; set; }
    public string modrNm { get; set; }
    public string modrId { get; set; }
}