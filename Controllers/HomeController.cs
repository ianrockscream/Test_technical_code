using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_technical_code.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetResult(int inputangka, string type)
        {
            if(type == "ganjil")
            {
                if (inputangka % 2 != 0)
                    return Content("true");
                else
                    return Content("false");
            }
            if(type == "prima")
            {
                if (inputangka % inputangka == 0)
                    return Content("false");
                else return Content("true");
            }
            if (type == "segitiga")
            {
                string input = inputangka.ToString();
                int length = input.Length;
                string text = string.Empty;
                for (int i = 1; i <= length; i++)
                {
                    text += input.Substring(i - 1, 1).PadRight(i+1, '0') + ",";
                }
                return Content(text);
            }
            else
                throw new Exception("Invalid operation");
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
    }
}