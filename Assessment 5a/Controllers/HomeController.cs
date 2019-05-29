using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment_5a.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Calculator()
        {
            return View();
        }
        public ActionResult Result(int num1, int num2, string operation)
        {
            int result;
            switch(operation)
            {
                case "Plus":
                    {
                        result = num1 + num2;
                        ViewBag.Result = result.ToString();
                        break;
                    }
                case "Minus":
                    {
                        result = num1 - num2;
                        ViewBag.Result = result.ToString();
                        break;
                    }
                case "Multiply":
                    {
                        result = num1 * num2;
                        ViewBag.Result = result.ToString();
                        break;
                    }
                case "Divide":
                    {
                        result = num1 / num2;
                        ViewBag.Result = result.ToString();
                        break;
                    }
            }
            
            ViewBag.Operation = operation;
            return View();
        }
    }
}