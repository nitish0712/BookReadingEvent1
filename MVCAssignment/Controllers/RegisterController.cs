using Common;
using System.Web.Mvc;
using BookReading.Models;
using BookReading.Helper;
using BusinessLayer;
namespace BookReading.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        [ActionName("Register")]
        public ActionResult RegisterPost(RegisterUserModel userModel)
            {
            User user = new RegisterUserModelToUserHelper().RegisterUserModelToUserMapping(userModel);
            if (ModelState.IsValid)
                {
                new RegisterUser1().AddUser(user);
                return RedirectToAction("Login", "Login");
                }
            return View();

            }
    }
}