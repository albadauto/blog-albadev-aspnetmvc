using BlogDoDautin.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class ShowPostController : Controller
    {
        private readonly INewsRepository _newsrepository;
        public ShowPostController(INewsRepository newsrepository)
        {
            _newsrepository = newsrepository;
        }
        public IActionResult Index(int id)
        {
            var result = _newsrepository.getById(id);
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
