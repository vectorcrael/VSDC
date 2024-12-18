using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZRAImportsRec
{
    public string? taskCd { get; set; }
    public string? dclDe { get; set; }
    public string? hsCd { get; set; }
    public string? dclNo { get; set; }
    public List<ZRAImportsRecItem>? lines { get; set; }
}

[Keyless]
public class ZRAImportsRecItem
{
    public string? itemClsCd { get; set; }
    public string? itemCd { get; set; }
    public int? imptItemSttsCd { get; set; }

}