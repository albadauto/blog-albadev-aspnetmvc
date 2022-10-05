using BlogDoDautin.Models;
using BlogDoDautin.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsrepository;
        public NewsController(INewsRepository newsrepository)
        {
            _newsrepository = newsrepository;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewPost(NewsModel news)
        {
            _newsrepository.createPost(news);
            TempData["success"] = "Sucesso!";
            return RedirectToAction("Index");
        }
    }
}
