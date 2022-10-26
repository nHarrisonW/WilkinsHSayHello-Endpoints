//N. Harrison Wilkins
//10-26-2022
//SAY HELLO - ENDPOINTS
//THIS CONTROLLER WILL CONTROL ALL ENDPOINTS WITHIN THE PROJECT,  WILL WORK WITH WEB API'S
//PEER REVIEW BY : 


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
