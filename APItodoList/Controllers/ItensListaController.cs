using APItodoList.Context;
using APItodoList.Model;
using Microsoft.AspNetCore.Mvc;

namespace APItodoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItensListaController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ItensListaController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult AddItem(ItensListaModel itensLista)
        {
            if (itensLista == null)
            {
                return NotFound();
            }
            _context.itensLista.Add(itensLista);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IEnumerable<ItensListaModel> MostraItensLista()
        {
            return _context.itensLista;
        }


        [HttpGet("{id}")]
        public IActionResult MostraItemID(int id)
        {

            var item = _context.itensLista.FirstOrDefault(itens => itens.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _context.itensLista.FirstOrDefault(itens => itens.Id == id);

            if (item == null)
            {
                return NotFound();
            }


            _context.Remove(item);
            _context.SaveChanges();

            return NoContent();
        }




    }
}
