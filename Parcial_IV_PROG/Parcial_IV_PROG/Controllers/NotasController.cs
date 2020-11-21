using Parcial_IV_PROG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_IV_PROG.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Notas()
        {
            Notas N = new Notas();
            N.Nombre = Request.Form["Nombre"].ToString();
            N.Nombre_Materia = Request.Form["Materia"].ToString();
            N.Codigo = Int32.Parse(Request.Form["Codigo"].ToString());
            N.N1 = Double.Parse(Request.Form["N1"].ToString());
            N.N2 = Double.Parse(Request.Form["N2"].ToString());
            N.N3 = Double.Parse(Request.Form["N3"].ToString());
            N.promedio = N.N1 + N.N2 + N.N3 / 3;
            if (N.promedio >= 4.0)
            {
                N.Msj = "aprobo";
            }
            if (N.promedio < 4.0)
            {
                N.Msj = " Reprobo";
            }

            return View("Notas",N);
        }
    }
}