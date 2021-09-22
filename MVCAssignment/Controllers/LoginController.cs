
using System.Web.Mvc;

using BookReading.Models;
using BookReading.Helper;
using BusinessLayer;
using System.Web.Security;
namespace BookReading.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
            {
              
            return View();
            }

        [ActionName("Login")]
        [HttpPost]
        public ActionResult LoginPost(UserModel user)
            {
            UserValidation1 userValidation = new UserValidation1();

            if (userValidation.UserExists(new UserModelToUserHelper().UserModelToUserMapping(user)))
                {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("About", "Home");

                }
            else
                {
                ViewBag.Message = "Invalid UserName or Password";
                return View();
                }
            


            }

        public ActionResult LogOut()
            {
            FormsAuthentication.SignOut();
           
            return Redirect("/Home/About");
            }
        }
}