//Importa el espacio de nombres necesarios para la autorizacion
using Microsoft.AspNetCore.Authorization;
//Importa el espacio de nombres necesarios para trabajar con controladores
using Microsoft.AspNetCore.Mvc;


namespace BMSR20230906Cookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //Aplica la autorizacion a este controlador, lo que significa solo
    //los usuarios autenticados podran acceder a sus acciones
    [Authorize]
    public class ProtetedController : ControllerBase
    {
        //Crea una lista de objetos 'data' para almacenar informacion
        static List<object> data = new List<object>();

        [HttpGet]
        public IEnumerable<object> Get()
        {
            //Devuelve los datos almacenados en la lista 'data' en respuesta a una solicitud GET
            return data;
        }
        [HttpPost]
        public IActionResult Post(string name, string lastname)
        {
            //Agrega un nuevo objeto anonimo con 'name' y 'lastName'
            //a la lista 'data' en respuesta a una solicitud POST 
            data.Add(new { name, lastname });
            //Devuelve una respuesta HTTP exitosa
            return Ok();
        }
        
    }
}
