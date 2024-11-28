namespace VSDCAPI;

public class GetImportsRequest
{
    public string tpin { get; set; }
    public string bhfId { get; set; }
    public string lastReqDt { get; set; }
    public string DclRefNum { get; set; }
}