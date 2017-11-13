using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M_Interativo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Rpedido()
        {
            return View();
        }
        public ActionResult CardapioFull()
        {
            return View();
        }
    }
}