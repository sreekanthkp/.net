using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest.Models;

namespace MvcTest.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(); 
   }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult CheckCountValue(int i)
        {
            if (i < 20)
            {
                //business logic goes here  
            }
            else
            {
                throw (new Exception("Out of the Range"));
            }

            return View();
        }
    }
    }
