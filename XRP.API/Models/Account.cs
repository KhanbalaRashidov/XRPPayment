using System.Text.Json.Serialization;

namespace XRP.API.Models;

public class Account
{
    [JsonPropertyName("xAddress")]
    public string XAddress { get; set; }
    [JsonPropertyName("secret")]
    public string Secret { get; set; }
    [JsonPropertyName("classicAddress")]
    public string ClassicAddress { get; set; }
    [JsonPropertyName("address")]
    public string Address { get; set; }
}