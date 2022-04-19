using Microsoft.AspNetCore.Mvc;

namespace CowsAndBulls.Controllers
{
    public class CowsAndBullaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
