using System.Text.Json.Serialization;

namespace XRP.API.Models.Request.Account
{
    public class AccountInfoRequestModel : BaseEntity
    {
        [JsonPropertyName("params")]
        public List<AccountInfoParam> @params { get; set; }

      
    }
}

