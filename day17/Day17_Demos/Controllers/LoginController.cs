using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using System.Web.Security;
using DemoMVC.Filters;
namespace DemoMVC.Controllers
{
    [CustomFilter]
    public class LoginController : Controller
    {
        SunbeamDBEntities dbObj = new SunbeamDBEntities();
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(HRLoginInfo loginObject, string ReturnUrl )
        {
            var MatchCount = (from hr in dbObj.HRLoginInfoes.ToList()
                         where hr.UserName.ToLower() ==loginObject.UserName.ToLower() 
                         && hr.Password == loginObject.Password
                         select hr).ToList().Count();

            if (MatchCount == 1)
            {
                //Since User Details are correct ..
                //Create a Session ... 
                //Create / send cookie to client 
                FormsAuthentication.SetAuthCookie(loginObject.UserName, false);

                //Give instruction to shoot a call for "/Home/Index" or any page asked earlier in Querystring;
                if (ReturnUrl!=null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "User Name or Password is incorrect";
                return View();
            }

        }

        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home/Index");
        }
    }
}