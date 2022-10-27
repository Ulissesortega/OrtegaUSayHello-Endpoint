//Name: Ulises Ortega
//Date: 10.25.22
//Project: Say Hello - EndPoit
//Description: This EndPoint will take the user input in the url and then output in screen Say Hello and the user name.
//in the example bellow your local host will change, all you need to do is enter your name where it say Your name goes here
//Example: https://localhost:7242/SayHello/Hello/Your Name Goes Here
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

