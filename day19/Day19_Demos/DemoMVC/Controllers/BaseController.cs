using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Filters;
using System.Data.SqlClient;

namespace DemoMVC.Controllers
{
    //[Authorize]
    //[CustomFilter]

    //[HandleError(ExceptionType = typeof(SqlException), View = "Error1")]
    //[HandleError(ExceptionType = typeof(ArgumentException), View = "Error2")]
    //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "Error3")]
    //[HandleError(ExceptionType = typeof(Exception), View = "Error")]
    public class BaseController : Controller
    {
        protected SunbeamDBEntities dbObj { get; set; }
        public BaseController()
        {
            this.dbObj = new SunbeamDBEntities();
        }
    }
}