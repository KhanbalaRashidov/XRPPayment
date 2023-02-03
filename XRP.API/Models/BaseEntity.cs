using System.Text.Json.Serialization;

namespace XRP.API.Models
{
    public class BaseEntity:IBaseEntity
    {
        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}
