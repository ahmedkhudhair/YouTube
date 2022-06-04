using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTube.Models;

namespace YouTube.Controllers
{
    public class LoginController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            if(TempData["Message"]!=null)
            ViewBag.Message = TempData["Message"];
            return View();
        }

        // GET: Login
        [HttpGet]
        public ActionResult SignIn(User user)
        {
            bool ok = user.SignIn();
            if(ok)
            {
                TempData["Message"] = "Success";
            }
            else
            {
                TempData["Message"] = "Faild";
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            bool exception = false;
            try
            {
                user.SignUp();
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                exception = true;
            }
            
            if(!exception)
            {
                TempData["Message"] = "Rigestered";
            }

            return RedirectToAction("index");
        }
    }
}