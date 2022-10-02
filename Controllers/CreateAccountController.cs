using BlogDoDautin.Models;
using BlogDoDautin.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class CreateAccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        public CreateAccountController(IUserRepository user)
        {
            _userRepository = user;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewUser(UserModel usermodel)
        {
            try
            {
                _userRepository.createUser(usermodel);
                TempData["success"] = "Criado com sucesso!";
                return RedirectToAction("Index");
            }
            catch(Exception error)
            {
                throw new Exception("Erro" + error.ToString());
            }
            
        }
    }
}
