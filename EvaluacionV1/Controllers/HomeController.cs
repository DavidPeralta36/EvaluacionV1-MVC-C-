using EvaluacionV1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ClassLibrary1;

namespace EvaluacionV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ErrorMessage = "Llena todos los campos para poder iniciar secion";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Login (string NombreUsr, string ContraseñaUsr)
        {
            ProyectoEntities db = new ProyectoEntities();

            string user = NombreUsr;
            string pass = ContraseñaUsr;

            var puesto = (from p in db.Usuarios where p.NombreUsr == user && p.ContraseñaUsr == pass select p.IdUser).FirstOrDefault();

            //ViewBag.test = "hola";

            if (string.IsNullOrEmpty(NombreUsr) && string.IsNullOrEmpty(ContraseñaUsr))
            {
                ViewBag.ErrorMessage = "Llena todos los campos para poder iniciar secion";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (puesto == 1)
                {
                    return RedirectToAction("Index", "JefeComputo");

                }
                else if (puesto == 2)
                {
                    return RedirectToAction("Index", "JefeArea");
                }
                else
                {
                    return RedirectToAction("Privacy", "Home");
                }
            }

            
        }
    }
}