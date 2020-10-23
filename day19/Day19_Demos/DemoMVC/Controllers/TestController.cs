using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class TestController : BaseController
    {
        public ActionResult Index(int? id)
        {

            ActionResult result = null;
            switch (id)
            {
                case 1:
                    Emp emp = new Emp() { No = 100, Name = "Rajat", Address = "Pune" };
                    result =  View(emp);
                    break;
                case 2:
                    result =  new JsonResult() { Data= dbObj.Emps.ToList(), 
                                              JsonRequestBehavior= JsonRequestBehavior.AllowGet };
                    break;
                case 3:
                    result =  new JavaScriptResult() { Script = "alert('Hello from JS');" };
                    break;
                case 4:
                    return View("Display");
                default:
                    result = new ContentResult() { ContentType = "text/plain", Content = "Hello from Server" };
                    break;
            }
            return result;
        }

       
    }
}