using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGKShop.Models;
using PagedList;
using PagedList.Mvc;
namespace NGKShop.Controllers
{
    public class AdminController : Controller
    {
        NGKDataDataContext data = new NGKDataDataContext();
        // GET: Admin
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                Admin ad = data.Admins.SingleOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                if (ad != null)
                {
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NGK(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(data.MATHANGs.ToList().OrderBy(n => n.MaMH).ToPagedList(pageNumber, pageSize));
        }
        public ActionResult LoaiHang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(data.LOAINGKs.ToList().OrderBy(n => n.MaLH).ToPagedList(pageNumber, pageSize));
        }
        public ActionResult KhachHang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(data.KHACHHANGs.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize));
        }
    }
}