using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHaris.Controllers
{
    public class DepartmentController : Controller
    {
        public string GetInfo()
        {
            return "Welcome to MVC from Departments";
        }

        public string Index()
        {
            return "Hello from Index";
        }
    }
}