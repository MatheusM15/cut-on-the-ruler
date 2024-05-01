using Microsoft.AspNetCore.Mvc;

namespace cutontheruler_api.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
