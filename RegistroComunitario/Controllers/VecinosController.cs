using Microsoft.AspNetCore.Mvc;
using RegistroComunitario.Models;
using RegistroComunitario.Data;

namespace RegistroComunitario.Controllers
{
    public class VecinosController : Controller
    {
        public IActionResult Index()
        {
            var vecinos = RepositorioVecinos.ObtenerTodos();
            return View(vecinos);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Vecino v)
        {
            if (ModelState.IsValid)
            {
                RepositorioVecinos.Agregar(v);
                return RedirectToAction("Index");
            }
            return View(v);
        }
    }
}