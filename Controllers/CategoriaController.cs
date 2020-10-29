using System.Collections.Generic;
using System.Threading.Tasks;
using ApiMemoria.Data;
using ApiMemoria.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ApiMemoria.Controllers
{
    [ApiController]
    [Route("Categoria")]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Categoria>>> Get([FromServices] DataContext context){
            var categorias = await  context.Categorias.ToListAsync();
            return categorias;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<string>> Post([FromServices] DataContext context,[FromBody] Categoria model){
            if(ModelState.IsValid){
                context.Categorias.Add(model);
                await context.SaveChangesAsync();
            }else{
                return BadRequest(model);
            }
            return "sucesso";
        } 
    }
}