using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class SampleController : BaseController
    {
        public ActionResult Index()
        {
            Emp e = new Emp() { Name = "1234", No = 999, Address = "pqr" };
            ViewBag.MyTitle = "Welcome Home";
            ViewBag.UserName = User.Identity.Name;

            var allEmps = dbObj.Emps.ToList();
            return View(allEmps);
        }
        public ActionResult Delete(int id)
        {
            Emp empToBeDeleted = (from emp in dbObj.Emps.ToList()
                                  where emp.No == id
                                  select emp).First();
            dbObj.Emps.Remove(empToBeDeleted);
            dbObj.SaveChanges();
            return Redirect("/Sample/Index");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Message = "Please Update Record Here!";
            ViewBag.UserName = User.Identity.Name;

            Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
                                 where emp.No == id
                                 select emp).First();

            return View(empToBeEdited);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Emp empUpdated)
        {

            var v = ViewBag.Message;
            Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
                                 where emp.No == empUpdated.No
                                 select emp).First();

            empToBeEdited.Name = empUpdated.Name;
            empToBeEdited.Address = empUpdated.Address;

            dbObj.SaveChanges();//This will update the database

            return Redirect("/Sample/Index");

        }
        public ActionResult Create()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }

        public JsonResult Validate(int id)
        {
            int Count  = (from emp in dbObj.Emps.ToList()
                                 where emp.No == id
                                 select emp).Count();
            return new JsonResult() { Data = Count, JsonRequestBehavior = JsonRequestBehavior.AllowGet };    
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Emp empToBeAdded)
        {
            if(ModelState.IsValid)
            {
                dbObj.Emps.Add(empToBeAdded);
                dbObj.SaveChanges();

                return Redirect("/Sample/Index");
            }
            else
            {
                return View(empToBeAdded);
            }

        }
    }
}