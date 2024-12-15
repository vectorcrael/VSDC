using System.Collections.Generic;
using Newtonsoft.Json;

namespace ServicesLayer.DTOs;

public class StockList
{
    public List<StockItem> stockItemList { get; set; }
}

public class StockItem
{
    [JsonProperty("itemCode")]
    public string itemCode { get; set; }

    [JsonProperty("quantity")]
    public double quantity { get; set; }
}