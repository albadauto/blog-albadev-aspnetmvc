using BlogDoDautin.Models;
using BlogDoDautin.Repository;
using BlogDoDautin.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class MyPostsController : Controller
    {
        private readonly INewsRepository _repo;
        public MyPostsController(INewsRepository newsRepository)
        {
            _repo = newsRepository;
        }
        public IActionResult Index()
        {
            List<NewsModel> news = _repo.getAll(HttpContext.Session.GetInt32("id_user"));
            return View(news);
        }
    }
}
