using PregledPrograma.DB;
using PregledPrograma.Helpers;
using PregledPrograma.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PregledPrograma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime datum = DateTime.Today;
            List<KosuljicaViewModel> sveKosuljiceModeli = KosuljiceHelper.VratiKosuljice(datum);
            ViewBag.Datum = datum;
            return View(sveKosuljiceModeli);
        }

        [HttpPost]
        public ActionResult Update(DateTime datum, int[] ids)
        {
            KosuljiceHelper.UpdateKosuljica(datum, ids);
            return Content("");
        }
    }
}
