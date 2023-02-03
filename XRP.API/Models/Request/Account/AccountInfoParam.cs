using System.Text.Json.Serialization;

namespace XRP.API.Models.Request.Account;

public class AccountInfoParam
{
    [JsonPropertyName("account")]
    public string account { get; set; }
    [JsonPropertyName("strict")]
    public bool strict { get; set; }
    [JsonPropertyName("ledger_index")]
    public string ledger_index { get; set; }
    [JsonPropertyName("queue")]
    public bool queue { get; set; }
}