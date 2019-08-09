using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHaris.Controllers
{
    public class HomeController : Controller
    {
        //Default Action
        public ViewResult index()
        {
            return View();
        }

        //Parameterized
        //public ViewResult IndexSubmit(string name, string pwd)
        //{
        //    return View("index");
        //}

        //Context Objects Query String
        //public ViewResult IndexSubmit()
        //{
        //    string name = Request["name"];
        //    string pwd = Request["pwd"];

        //    return View("index");
        //}

        //Context Objects Form Data
        public ViewResult IndexSubmit()
        {
            string name = Request.Form["name"];
            string pwd = Request.Form["pwd"];

            return View("index");
        }
    }
}