using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace EvaluacionV1.Controllers
{
    public class ReportesController : Controller
    {
        Class1 reportes = new Class1();
        public IActionResult Index()
        {
            return View(reportes.ListarReportes());
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

        public IActionResult DetailsReport(int IdReporte)
        {
            return View(reportes.Buscar(IdReporte));
        }

        public ActionResult EditReport(int IdReporte)
        {
            return View(reportes.Buscar(IdReporte));
        }

        [HttpPost]
        public ActionResult EditReport(ClassLibrary1.Reportes itm)
        {
            reportes.Modificar(itm);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReport(int IdReporte)
        {
            return View(reportes.Buscar(IdReporte));
        }
        [HttpPost]
        public ActionResult DeleteReporte(int IdReporte)
        {
            reportes.Eliminar(IdReporte);

            return RedirectToAction(nameof(Index));
        }

    }
}
