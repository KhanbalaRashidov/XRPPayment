using System.Text.Json.Serialization;

namespace XRP.API.Models
{
    public class AccountResult
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; }
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
    }

}
