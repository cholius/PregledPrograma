using PregledPrograma.DB;
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
            List<KosuljicaViewModel> sveKosuljiceModeli = new List<KosuljicaViewModel>();
            using (BazaContext db = new BazaContext())
            {
                List<Kosuljica> sveKosuljiceIzBaze = db.Kosuljice.ToList();
                foreach (Kosuljica kosuljicaDB in sveKosuljiceIzBaze)
                {
                    KosuljicaViewModel kosuljicaModel = new KosuljicaViewModel();
                    kosuljicaModel.ID = kosuljicaDB.ID;
                    kosuljicaModel.StartEmisije = kosuljicaDB.StartEmisije;
                    kosuljicaModel.DuracijaEmisije = kosuljicaDB.DuracijaEmisije;
                    kosuljicaModel.NaslovEmisije = kosuljicaDB.NaslovEmisije;
                    kosuljicaModel.Zanr = kosuljicaDB.Zanr != null ? kosuljicaDB.Zanr.NazivZanra : "";
                    kosuljicaModel.TipEmitovanja =  kosuljicaDB.TipEmitovanja != null ? kosuljicaDB.TipEmitovanja.Tip : "";
                    kosuljicaModel.NazivRedakcije = kosuljicaDB.Redakcija != null ? kosuljicaDB.Redakcija.NazivRedakcije : "";
                    kosuljicaModel.BrojEpizode = kosuljicaDB.BrojEpizode;
                    kosuljicaModel.OpisEmisije = kosuljicaDB.OpisEmisije;
                    kosuljicaModel.Rejting = kosuljicaDB.Rejting != null ? kosuljicaDB.Rejting.OznakaRejtinga : "";
                    kosuljicaModel.Komentar = kosuljicaDB.Komentar;
                    kosuljicaModel.CodSat = kosuljicaDB.CodSat;
                    //
                    sveKosuljiceModeli.Add(kosuljicaModel);
                }
            }

            return View(sveKosuljiceModeli);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
// Sema
