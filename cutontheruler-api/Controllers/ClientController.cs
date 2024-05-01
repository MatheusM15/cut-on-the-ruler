using Microsoft.AspNetCore.Mvc;

namespace cutontheruler_api.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
