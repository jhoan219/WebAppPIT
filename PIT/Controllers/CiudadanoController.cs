using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PIT.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient; 
namespace PIT.Controllers
{
    public class CiudadanoController : Controller
    {
        // GET: Ciudadano
        private  PITEntities2 bd = new PITEntities2();

        public ActionResult Listar()
        {
            return View(bd.ciudadano1.ToList());
        }

        public ActionResult Modifica(string id)
        {
            return View(new ciudadano1());
        }


        public ActionResult Agrega()
        {
            return View(new ciudadano1());
        }

        [HttpPost]
        public ActionResult Agrega(ciudadano1 ciudadano1)
        {
            if (!ModelState.IsValid)
                return View(ciudadano1);

            string Mensaje = string.Empty;

        
            ViewBag.Mensaje = Mensaje;
            return View(ciudadano1);
        }
   

    }
}