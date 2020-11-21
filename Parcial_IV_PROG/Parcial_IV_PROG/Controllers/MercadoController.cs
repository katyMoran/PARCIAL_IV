using Parcial_IV_PROG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_IV_PROG.Controllers
{
    public class MercadoController : Controller
    {
        // GET: Mercado
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mercado()
        {
            double Descuento;
            Mercado Mer = new Mercado();
            Mer.Nombre= Request.Form["Nombre"].ToString();
            Mer.Precio = Double.Parse(Request.Form["Precio"].ToString());
            Mer.Cantidad = Int32.Parse(Request.Form["Cantidad"].ToString());
            Mer.Total = Mer.Precio * Mer.Cantidad;
            if (Mer.Total > 100000)
            {
                Descuento = Mer.Total * 0.20;
                Mer.Desc = Mer.Total - Descuento;
            }
            else
            {
               
                Mer.Desc = Mer.Total;
            }
            return View("Mercado",Mer);
        }
    }
}