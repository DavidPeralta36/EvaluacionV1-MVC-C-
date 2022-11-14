using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Negocio;
namespace EvaluacionV1.Controllers
{
    public class JefeComputoController : Controller
    {
        Class1 reporte = new Class1();
        public IActionResult Index()
        {
            return View(reporte.ListarReportes());
        }

        public ActionResult EditReport(int IdReporte)
        {
            return View(reporte.Buscar(IdReporte));
        }

        [HttpPost]
        public ActionResult EditReport(ClassLibrary1.Reportes itm)
        {
            reporte.Modificar(itm);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReport(int IdReporte)
        {
            return View(reporte.Buscar(IdReporte));
        }
        [HttpPost]
        public ActionResult DeleteReporte(int IdReporte)
        {
            reporte.Eliminar(IdReporte);

            return RedirectToAction(nameof(Index));
        }
    }
}
