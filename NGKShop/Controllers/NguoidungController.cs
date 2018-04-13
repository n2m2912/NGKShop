using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGKShop.Models;

namespace NGKShop.Controllers
{
    public class NguoidungController : Controller
    {
        NGKDataDataContext data = new NGKDataDataContext();
        // GET: Nguoidung
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(FormCollection collection, KHACHHANG kh)
        {
            var hoten = collection["Name"];
            var tendn = collection["Username"];
            var matkhau = collection["Password"];
            var diachi = collection["Address"];
            var email = collection["Email"];
            var dienthoai = collection["Phone"];
            
                kh.TenKH = hoten;
                kh.TenDN = tendn;
                kh.MatKhau = matkhau;
                kh.email = email;
                kh.DiaChi = diachi;
                kh.SDT = dienthoai;
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("GioHang","GioHang");

            return this.DangKy();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var tendn = collection["Username"];
            var matkhau = collection["Password"];
                KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.TenDN == tendn && n.MatKhau == matkhau);
                if (kh != null)
                {
                    /*ViewBag.Thongbao = "Chúc mừng đăng nhập thành công";*/
                    Session["Taikhoan"] = kh;
                    return RedirectToAction("GioHang", "GioHang");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            
            return View();
        }

        public ActionResult DangnhapPartial()
        {
            KHACHHANG kh = (KHACHHANG)Session["Taikhoan"];
            if (Session["Taikhoan"] == null)
            {
                ViewBag.TK = "Guest";
            }
            else
            {
                ViewBag.TK = kh.TenKH;
            }
            return PartialView();
        }
    }
}