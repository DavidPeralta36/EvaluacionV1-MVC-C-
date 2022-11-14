using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace EvaluacionV1.Controllers
{
    public class RolesController : Controller
    {
        Class1 roles = new Class1();
        public IActionResult Index()
        {
            return View(roles.ListarRoles());
        }
    }
}
