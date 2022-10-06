using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class ShowPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
