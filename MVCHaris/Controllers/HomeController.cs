using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHaris.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult index()
        {
            return View();
        }

        //Parameterized
        //public ViewResult IndexSubmit(string name, string pwd)
        //{
        //    return View("index");
        //}

        //Context Objects
        public ViewResult IndexSubmit(FormCollection fc)
        {
            string name = fc["name"];
            string pwd = fc["pwd"];

            return View("index");
        }
    }
}