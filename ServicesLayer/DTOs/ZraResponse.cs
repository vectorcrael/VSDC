using Newtonsoft.Json;

namespace ServicesLayer.DTOs;

public class ZraResponse
{
    [JsonProperty("data")] public object? Data;

    [JsonProperty("resultCd")] public string ResultCd;

    [JsonProperty("resultDt")] public string ResultDt;

    [JsonProperty("resultMsg")] public string ResultMsg;
}