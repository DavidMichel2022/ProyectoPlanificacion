using Microsoft.AspNetCore.Mvc;

namespace SistemaPlanificacion.AplicacionWeb.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
