﻿using BlogDoDautin.Models;
using BlogDoDautin.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogDoDautin.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsRepository _repository;
        public HomeController(INewsRepository newsrepository)
        {
            _repository = newsrepository;
        }
        public IActionResult Index()
        {
            var result = _repository.getAllNews();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}