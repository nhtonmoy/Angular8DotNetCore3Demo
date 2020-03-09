using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DevClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DevClassAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost("GetCredentials")]
        public async Task<IActionResult> GetCredentials([FromBody]DevLogin devLogin)
        {
            DevLogin login = new DevLogin
            {
                Username = "secl",
                Password = "2013"
            };

            DevLogin loginToken = new DevLogin();
            //var client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:44361/");

            if (devLogin.Username == login.Username && devLogin.Password == login.Password)
            {
                //HttpResponseMessage resStudent = await client.PostAsync("api/Login/GetCredentials", new StringContent(JsonConvert.SerializeObject(devLogin), Encoding.UTF8, "application/json"));

                //loginToken = JsonConvert.DeserializeObject<DevLogin>(resStudent.ReadAsStringAsync());

                loginToken.Username = devLogin.Username;
                loginToken.Token = "12345";
                return Ok(loginToken.Token);
            }
            else
            {
                return Ok("");
            }

            return BadRequest(new { message = "Username or Password is incorrect" });
        }

    }
}