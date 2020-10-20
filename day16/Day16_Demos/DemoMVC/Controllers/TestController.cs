using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class TestController : Controller
    {
        SunbeamDBEntities dbObj = new SunbeamDBEntities();

        #region Show hard coded Emp in UI
        //public ActionResult Show()
        //{
        //    Emp emp = new Emp() 
        //                { No = 1, Name = "mahesh",Address = "Pune" };


        //    return View("XYZ", emp);
        //}
        #endregion

        #region Show hard coded collection in UI
        //public ActionResult Show()
        //{
        //    List<Emp> allEmps = new List<Emp>() {
        //        new Emp{ No = 11, Name = "mahesh1", Address = "pune1" },
        //        new Emp{ No = 12, Name = "mahesh2", Address = "pune2" },
        //        new Emp{ No = 13, Name = "mahesh3", Address = "pune3" },
        //        new Emp{ No = 14, Name = "mahesh4", Address = "pune4" }
        //        };


        //    return View(allEmps);
        //}
        #endregion

        public ActionResult Show()
        {
            try
            {
                //ViewData["myMessage"] = "Welcome to my application";
                //ViewData["myMessage2"] = "This is Mahesh";

                ViewBag.myMessage = "Welcome to My application";
                ViewBag.myMessage2 = "This is Mahesh";

                var allEmps = dbObj.Emps.ToList();
                return View(allEmps);
            }
            catch (Exception ex)
            {
                return View("Error", ex);      
            }
        }
        public ActionResult Delete(int id)
        {

            try
            {
                Emp empToBeDeleted = (from emp in dbObj.Emps.ToList()
                                      where emp.No == id
                                      select emp).First();
                dbObj.Emps.Remove(empToBeDeleted);
                dbObj.SaveChanges();
                return Redirect("/Test/Show");

            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }
       
        public ActionResult Edit(int id)
        {

            try
            {
                ViewBag.Message = "Please Update Record Here!";

                Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
                                     where emp.No == id
                                     select emp).First();

                return View(empToBeEdited);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        [HttpPost]
        public ActionResult Edit(Emp empUpdated)
        {
            try
            {
                var v = ViewBag.Message;
                Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
                                     where emp.No == empUpdated.No
                                     select emp).First();

                empToBeEdited.Name = empUpdated.Name;
                empToBeEdited.Address = empUpdated.Address;

                dbObj.SaveChanges();//This will update the database

                return Redirect("/Test/Show");
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        //public ActionResult AfterEdit(Emp empUpdated)
        //{
        //    try
        //    {
        //        Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
        //                             where emp.No == empUpdated.No
        //                             select emp).First();

        //        empToBeEdited.Name = empUpdated.Name;
        //        empToBeEdited.Address = empUpdated.Address;

        //        dbObj.SaveChanges();//This will update the database

        //        return Redirect("/Test/Show");
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error", ex);
        //    }
        //}

        //public ActionResult AfterEdit(FormCollection entireForm)
        //{
        //    try
        //    {
        //        int NoOfTheEmpToEdit = Convert.ToInt32(entireForm["No"]);

        //        //below query is giving you reference and not a copy!
        //        Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
        //                             where emp.No == NoOfTheEmpToEdit
        //                             select emp).First();

        //        empToBeEdited.Name = entireForm["Name"].ToString();
        //        empToBeEdited.Address = entireForm["Address"].ToString();

        //        dbObj.SaveChanges();//This will update the database

        //        return Redirect("/Test/Show");
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error", ex);
        //    }
        //}
        public ActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        [HttpPost]
        public ActionResult Create(Emp empToBeAdded)
        {
            try
            {
                dbObj.Emps.Add(empToBeAdded);
                dbObj.SaveChanges();

                return Redirect("/Test/Show");
            }
            catch (Exception ex)
            {

                //Do the log using Singleton logger!
                //File IO
                return View("Error", ex);
            }
        }



        //public ActionResult AfterCreate(Emp empToBeAdded)
        //{
        //    try
        //    {
        //        dbObj.Emps.Add(empToBeAdded);
        //        dbObj.SaveChanges();

        //        return Redirect("/Test/Show");
        //    }
        //    catch (Exception ex)
        //    {

        //        //Do the log using Singleton logger!
        //        //File IO
        //        return View("Error", ex);
        //    }
        //}

        //public ActionResult AfterCreate(FormCollection entireForm)
        //{
        //    try
        //    {
        //        Emp empToBeAdded = new Emp()
        //        {
        //            No = Convert.ToInt32(entireForm["No"]),
        //            Name = entireForm["Name"].ToString(),
        //            Address = entireForm["Address"].ToString()
        //        };

        //        dbObj.Emps.Add(empToBeAdded);
        //        dbObj.SaveChanges();

        //        return Redirect("/Test/Show");
        //    }
        //    catch (Exception ex)
        //    {

        //        //Do the log using Singleton logger!
        //        //File IO
        //        return View("Error", ex);
        //    }
        //}

    }
}