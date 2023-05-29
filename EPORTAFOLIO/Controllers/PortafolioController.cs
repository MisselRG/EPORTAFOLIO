using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPORTAFOLIO.Controllers
{
    public class PortafolioController : Controller
    {
        // GET: Portafolio
        public ActionResult Index()
        {
            return View();
        }
    }
}