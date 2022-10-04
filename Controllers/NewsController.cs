using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
