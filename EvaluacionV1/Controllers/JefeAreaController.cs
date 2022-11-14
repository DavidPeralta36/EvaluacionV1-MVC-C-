using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace EvaluacionV1.Controllers
{
    public class JefeAreaController : Controller
    {

        Class1 reportes = new Class1();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddReport()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReporte(ClassLibrary1.Reportes itm)
        {
            reportes.Agregar(itm);
            return RedirectToAction("Index");
        }

        public IActionResult LastDetails(int IdReporte)
        {
            return View(reportes.Buscar(IdReporte));
        }

        public IActionResult ListR()
        {
            return View(reportes.ListarReportes());
        }

    }
}
