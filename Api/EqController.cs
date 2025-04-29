using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-vuelos")]
    public IActionResult ListarVuelos(){
        return Ok();
    }
}