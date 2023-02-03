namespace XRP.API.Models.Response.Account;

public class AccountInfoResult
{
        
    public AccountData account_data { get; set; }
        
    public int ledger_current_index { get; set; }
        
    public QueueData queue_data { get; set; }
      
    public string status { get; set; }
      
    public bool validated { get; set; }
}