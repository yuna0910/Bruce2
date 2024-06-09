using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bruce2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string answer, object feedback)
        {
            
            if (answer == "0626")
            {
                feedback = "正确答案!";
                feedback = "green";
            }
            else
            {
                feedback = "错误答案，请再试一次。";
                feedback = "red";
            }
            return View();
        }
    }
}