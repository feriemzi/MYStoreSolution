using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
namespace FruitStore.Controllers;


[ApiController]
//[Route("[controller]")]
public class FruitStoreController:ControllerBase
{
    [HttpGet]
    [Route("Get")]
    public IActionResult Get(string message,string cellphone)
    {
        return Ok(true);
    }
    [HttpGet]
    [Route("Get2")]
    public IActionResult Get2(string message,string cellphone)
    {
        return Ok(true);
    }
    [HttpPost]
    [Route("Insert")]
    public bool Insert(string message,string cellphone)
    {
        return true;
    }

    [HttpPut]
    [Route("Update")]
    public bool Update(string message,string cellphone)
    {
        return true;
    }

    [HttpDelete]
    [Route("Delete")]
    public bool Delete(string message,string cellphone)
    {
        return true;
    }
    public List<Product> products =new(){
        new(){Id="1",Name="Apple"},
        new(){Id="2",Name="Banana"},
        new(){Id="3",Name="Blueberry"}
        };
}