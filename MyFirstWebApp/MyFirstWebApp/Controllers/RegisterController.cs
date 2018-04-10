using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{   
    public class RegisterController : Controller
    {
        
        // GET: Signup
       
        public ActionResult Registration()
        {
            return View();
        }
    }
}