using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using XRP.Console;

public class Program
{
     static HttpClient httpClient = new HttpClient();
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting connections\n\n");
      
        AccountInfo("rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Connections done");
       
        Console.ReadLine();
    }



    static void AccountInfo(string token)
    {
        httpClient.BaseAddress = new Uri("http://s1.ripple.com:51234/");
        var header = new Root()
        {
            method = "account_info",
            @params = new List<Param>
            {
                new Param()
                {
                    account = token,
                    strict = true,
                    ledger_index = "current",
                   queue = true
                }
            }
        };

        var content = JsonSerializer.Serialize(header);
        var stringContent = new StringContent(content, Encoding.UTF8, "application/json");
        var result = httpClient.PostAsync("", stringContent).Result.Content.ReadAsStringAsync().Result;
        Console.WriteLine(result);
    }
}



