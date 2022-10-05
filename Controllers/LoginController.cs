using BlogDoDautin.Models;
using BlogDoDautin.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoDautin.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _repository;
        public LoginController(IUserRepository userrepository)
        {
            _repository = userrepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerifyLogin(UserModel user)
        {
            try
            {
                var result = _repository.verifyLogin(user);
                if(result != null)
                {
                    //Id do usuário na sessão SEMPRE deverá ser do tipo INT
                    HttpContext.Session.SetInt32("id_user", result.Id);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["errorLoginMessage"] = "Erro: Login ou senha incorretos";
                    return RedirectToAction("Index");

                }
            }
            catch(Exception err)
            {
                throw new Exception(err.ToString());
            }
        }

        public IActionResult RemoveSession()
        {
            HttpContext.Session.Remove("id_user");
            return RedirectToAction("Index");
        }
    }
}
