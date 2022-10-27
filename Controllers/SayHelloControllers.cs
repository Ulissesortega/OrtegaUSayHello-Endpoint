//Name: Ulises Ortega
//Date: 10.25.22
//Project: Say Hello - EndPoit
//Description: This EndPoint will take the user input and then output in screen Say Hello and the user name.
//Peer Review: ARELY MARTINEZ -- THE PROGRAM WORKS WELL. IN POSTMAN I INSERTED MY NAME AFTER THE ROUTE AND IT OUTPUT WHAT'S UP AREALY
//

using Microsoft.AspNetCore.Mvc;
namespace OrtegaUSayHello_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    public string SayHello(string name)
    {
        return $"Hello {name}";
    }
}

