using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGKShop.Models;

namespace NGKShop.Controllers
{
    public class HomePageController : Controller
    {
        NGKDataDataContext data = new NGKDataDataContext();
        // GET: HomePage
        private List<MATHANG> Laymathangngk(int count)
        {
            return data.MATHANGs.Take(count).ToList();
        }
        public ActionResult Index()
        {
            var mathang = Laymathangngk(6);
            return View(mathang);
        }
        public ActionResult LoaiNGK()
        {
            var loaingk = from lngk in data.LOAINGKs select lngk;
            return PartialView(loaingk);
        }
        public ActionResult Details(int id)
        {
            var ngk = from s in data.MATHANGs where s.MaMH == id  select s;
            return View(ngk.Single());
        }
        public ActionResult SPTheoLNGK(int id)
        {
            var ngk = from n in data.MATHANGs where n.MaLH == id select n;
            var loaihang = data.LOAINGKs.SingleOrDefault(n => n.MaLH == id);
            ViewBag.TenLH = loaihang.TenLH;
            return View(ngk);
        }
       
    }
}