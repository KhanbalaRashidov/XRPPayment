using System.Text.Json.Serialization;

namespace XRP.API.Models.Response.Account;

public class AccountData
{

    [JsonPropertyName("Account")]
    public string Account { get; set; }
    [JsonPropertyName("Balance")]

    public string Balance { get; set; }
    [JsonPropertyName("Flags")]

    public int Flags { get; set; }
    [JsonPropertyName("LedgerEntryType")]

    public string LedgerEntryType { get; set; }
    [JsonPropertyName("OwnerCount")]

    public int OwnerCount { get; set; }
    [JsonPropertyName("PreviousTxnID")]

    public string PreviousTxnID { get; set; }
    [JsonPropertyName("PreviousTxnLgrSeq")]

    public int PreviousTxnLgrSeq { get; set; }
    [JsonPropertyName("Sequence")]

    public int Sequence { get; set; }
    [JsonPropertyName("index")]
    public string index { get; set; }
}