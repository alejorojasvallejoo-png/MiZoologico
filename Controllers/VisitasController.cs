
using Microsoft.AspNetCore.Mvc;
using MiZoologico.Models;

namespace MiZoologico.Controllers
{
    public class VisitasController : Controller
    {
        [HttpGet]
        public IActionResult Crear()
        {
            return View(new Visita());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Visita visita)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmacion", visita);
            }

            return View(visita);
        }
    }
}
