using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Newtonsoft.Json;
using XRP.API.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using XRP.API.Models.Request.Account;
using XRP.API.Models.Response.Account;

namespace XRP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public AccountController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://s.altnet.rippletest.net:51234/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        [HttpGet]
        public IActionResult AccountCreateAdress()
        {

            using HttpClient client = new HttpClient();

           
            var stringContent = new StringContent("", Encoding.UTF8, "application/json");
            var result = client.PostAsync("https://faucet.altnet.rippletest.net/accounts", stringContent).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            var json = JsonConvert.DeserializeObject<AccountResult>(result);
            return Ok(json);

        }

        [HttpPost("AccountInfo")]
        public IActionResult AccountInfo([FromBody] AccountInfoRequestModel request)
        {
        
            var result = _httpClient.PostAsJsonAsync("", request).Result.Content.ReadAsStringAsync().Result;
            var json = JsonConvert.DeserializeObject<AccountInfoResponseModel>(result);
            return Ok(json);
        }

    }
}
