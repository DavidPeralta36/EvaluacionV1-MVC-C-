using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace EvaluacionV1.Controllers
{
    public class TrabajadoresController : Controller
    {
        Class1 trabajadores =new Class1();
        public IActionResult Index()
        {
            return View(trabajadores.ListarTrabajadores());
        }
    }
}
