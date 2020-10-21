using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DemoMVC.Controllers
{

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
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
            return Redirect("/Home/Index");
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
        public ActionResult Edit(Emp empUpdated)
        {
          
                var v = ViewBag.Message;
                Emp empToBeEdited = (from emp in dbObj.Emps.ToList()
                                     where emp.No == empUpdated.No
                                     select emp).First();

                empToBeEdited.Name = empUpdated.Name;
                empToBeEdited.Address = empUpdated.Address;

                dbObj.SaveChanges();//This will update the database

                return Redirect("/Home/Index");
           
        }
        public ActionResult Create()
        {
                ViewBag.UserName = User.Identity.Name;
                return View();
        }

        [HttpPost]
        public ActionResult Create(Emp empToBeAdded)
        {
                dbObj.Emps.Add(empToBeAdded);
                dbObj.SaveChanges();

                return Redirect("/Home/Index");
           
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.MyTitle = "About Us!";
            ViewBag.UserName = User.Identity.Name;

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.UserName = User.Identity.Name;

            ViewBag.MyTitle = "Contact Us Here!";
            ViewBag.action = "/Home/Contact";
            ViewBag.method = "POST";
            ViewBag.message = "You will error here in case of problems!";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel contactDetails)
        {
          
                string emailuserName = ConfigurationManager.AppSettings["email"];
                string emailpassword = ConfigurationManager.AppSettings["password"];

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailuserName);
                mail.To.Add(contactDetails.EMail);
                mail.CC.Add("shubhamkulkarni2016@gmail.com");
                mail.CC.Add("mahesh@bonaventuresystems.com");

                mail.Subject = "New Query Received!";
                mail.Body = " <h6>" + contactDetails.ToString() + " </h6>";
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential(emailuserName, emailpassword);

                smtp.EnableSsl = true;

                smtp.Send(mail);
                ViewBag.message = "Your Query submitted Successfully";
                return View();
           
        }
    }
}