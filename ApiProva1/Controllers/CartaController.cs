using ApiProva1.Helpers;
using ApiProva1.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiProva1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Carta>> Buscar()
        {

            List<Carta> cartas = ReadFile.Read();
            return Ok(cartas);
        }

        [HttpPost]
        public async Task<ActionResult<Carta>> Adicionar(Carta model)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }


            SaveInFile.Save(model);
            return Ok(model);
        }

    }
}
