using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeSeVenta.Models;
using WeSeVenta.Models.Request;
using WeSeVenta.Models.Respuesta;

namespace WeSeVenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Mrespuesta mrespuesta = new Mrespuesta();
            try
            {
                using (VentaRealContext bd = new VentaRealContext())
                {
                    var lst = bd.Clientes.ToList();
                    mrespuesta.Exito = 1;
                    mrespuesta.Data = lst;

                }
            }
            catch (Exception ex)
            {
                mrespuesta.Mensaje = ex.Message;
                mrespuesta.Exito = 0;
            }
            return Ok(mrespuesta.Data);

        }

        [HttpPost]
        //atencion a los parametros para agregar mediante request
        public IActionResult Add(ClienteRequest clienteRequest)
        {
            using (VentaRealContext bd = new VentaRealContext())
            {
                Mrespuesta objres = new Mrespuesta();
                try
                {
                    //este cliente probiene de la bdd
                    Cliente modelCliente = new Cliente();
                    modelCliente.Nombre = clienteRequest.Nombre;
                    //agregamos el request a la bdd
                    bd.Clientes.Add(modelCliente);
                    bd.SaveChanges();
                    objres.Exito = 1;
                    objres.Mensaje = "Conexion Post exitosa";
                    //objres.Data = lst;

                }
                catch (Exception ex)
                {
                    objres.Exito = 0;
                    objres.Mensaje = ex.Message;
                    //throw ex;
                }
                return Ok(objres);//Ok metodo de interface,ok convierte a json el objeto
            }
        }

        [HttpPut]
        //atencion a los parametros para agregar mediante request
        public IActionResult Edit(ClienteRequest clienteRequest)
        {
            using (VentaRealContext bd = new VentaRealContext())
            {
                Mrespuesta objres = new Mrespuesta();
                try
                {
                    //Elta linea busca el id del cliente es muy importante
                    Cliente modelCliente = bd.Clientes.Find(clienteRequest.id);
                    modelCliente.Nombre = clienteRequest.Nombre;
                    //agregamos el request a la bdd
                    bd.Clientes.Entry(modelCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    bd.SaveChanges();
                    objres.Exito = 1;
                    objres.Mensaje = "Conexion Put exitosa";
                    //objres.Data = lst;

                }
                catch (Exception ex)
                {
                    objres.Exito = 0;
                    objres.Mensaje = ex.Message;
                    //throw ex;
                }
                return Ok(objres);//Ok metodo de interface,ok convierte a json el objeto
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (VentaRealContext bd = new VentaRealContext())
            {
                Mrespuesta objres = new Mrespuesta();
                try
                {
                    //Esta linea busca el id del cliente
                    Cliente modelCliente = bd.Clientes.Find(id);
                    bd.Remove(modelCliente);
                    bd.SaveChanges();
                    objres.Exito = 1;
                    objres.Mensaje = "Conexion delete exitosa";
                    //objres.Data = lst;

                }
                catch (Exception ex)
                {
                    objres.Exito = 0;
                    objres.Mensaje = ex.Message;
                    //throw ex;
                }
                return Ok(objres);//Ok metodo de interface,ok convierte a json el objeto
            }
        }






    }
}
