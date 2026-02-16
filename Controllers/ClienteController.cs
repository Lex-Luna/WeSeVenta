using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeSeVenta.Models;

namespace WeSeVenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //
            using (VentaRealContext bd  = new VentaRealContext())
            {
                var lst = bd.Clientes.ToList();
                return Ok(lst);
            }

        }
    }
}
