using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
