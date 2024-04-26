using Dulce_Sabor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dulce_Sabor.Controllers
{
	public class DulceSaborController : Controller
	{


        private readonly dulceSaborDbContext _context;

        public DulceSaborController(dulceSaborDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var platos = _context.platos.ToList(); // Obtener todos los platos de la base de datos
            return View(platos); // Pasar los platos a la vista
        }







        [HttpPost]
        public IActionResult ActualizarEstado(int platoId, string nuevoEstado)
        {
            var detallePedido = _context.Detalle_Pedido.FirstOrDefault(dp => dp.Id_plato == platoId);
            if (detallePedido != null)
            {
                detallePedido.Estado = nuevoEstado;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }






    }
}
