using Microsoft.AspNetCore.Mvc;

namespace WilkinsHSayHello_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class SayingHelloController : ControllerBase
{
        [HttpGet]
        [Route("username/{userName}")]
    public string Hello(string userName)
    {
        return $"HELLO /{userName}! NICE TO MEET YOU!";
    }
}
