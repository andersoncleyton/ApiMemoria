using System.Collections.Generic;
using System.Threading.Tasks;
using ApiMemoria.Data;
using ApiMemoria.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMemoria.Controllers
{
    [ApiController]
    [Route("Filme")]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Filme>>> Get([FromServices] DataContext context){
            var filmes = await  context.Filmes.Include(x=>x.Categoria).ToListAsync();   
            return filmes;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<string>> Post([FromServices] DataContext context,[FromBody] Filme model){
            if(ModelState.IsValid){
                context.Filmes.Add(model);
                await context.SaveChangesAsync();
            }else{
                return BadRequest(model);
            }
            return "sucesso";
        }
    }
}