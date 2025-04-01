using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercios2.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            return View();
        }
   
        public ActionResult Casas()
        {
            
            return View();
        }
        public ActionResult Criaturas()
        {
            return View();
        }
        public ActionResult Hechizos()
        {
            return View();
        }

        public ActionResult Actores()
        {
            return View();
        }

    }
}