
using System.Web.Mvc;
using BookReadingEvent1.Basic1;
using BookReadingEvent1.Common;
using BookReadingEvent1.Helper;
using BookReadingEvent1.Models;

namespace BookReadingEvent1.Controllers
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
        public ActionResult RegisterPost(RegisterUser userModel)
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