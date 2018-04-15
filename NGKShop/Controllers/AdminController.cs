using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGKShop.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;
using Microsoft.AspNet.Identity;
using System.Web.Hosting;

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
        public ActionResult NCC(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(data.NCCs.ToList().OrderBy(n => n.MaNCC).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult ThemNGK()
        {
            ViewBag.MaLH = new SelectList(data.LOAINGKs.ToList().OrderBy(n => n.TenLH), "MaLH", "TenLH");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemNGK(MATHANG ngk, HttpPostedFileBase fileupload)
        {
            ViewBag.MaLH = new SelectList(data.LOAINGKs.ToList().OrderBy(n => n.TenLH), "MaLH", "TenLH");
            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }

            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Hinhsp/"), fileName);
                    if (System.IO.File.Exists(path))
                    { 
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                        
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    ngk.HinhSP= fileName;
                    data.MATHANGs.InsertOnSubmit(ngk);
                    data.SubmitChanges();
                }
                return RedirectToAction("NGK");
            }

        }
        public ActionResult ChitietNGK(int id)
        {
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH== id);
            ViewBag.MaMH = ngk.MaMH;
            if (ngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ngk);
        }
        [HttpGet]
        public ActionResult XoaNGK(int id)
        {
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH== id);
            ViewBag.MaMH = ngk.MaMH;
            if (ngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ngk);
        }
        [HttpPost, ActionName("XoaNGK")]
        public ActionResult XacnhanxoaNGK(int id)
        {
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH== id);
            ViewBag.MaMH = ngk.MaMH;
            if (ngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.MATHANGs.DeleteOnSubmit(ngk);
            data.SubmitChanges();
            return RedirectToAction("NGK");
        }
        [HttpGet]
        public string getImage(int id)
        {
            return data.MATHANGs.SingleOrDefault(n => n.MaMH == id).HinhSP;
        }
        public ActionResult SuaNGK(int id)
        {
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH == id);
            ViewBag.MaMH = ngk.MaMH;
            if (ngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaLH = new SelectList(data.LOAINGKs.ToList().OrderBy(n => n.TenLH), "MaLH", "TenLH", ngk.MaLH);
            return View(ngk);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaNGK(MATHANG ngk, HttpPostedFileBase fileupload)
        {
            
            MATHANG nngk= data.MATHANGs.SingleOrDefault(n => n.MaMH == ngk.MaMH);
            var MaLH = ngk.MaLH;
            var TenMH = ngk.TenMH;
            var Donvitinh = ngk.DonViTinh;
            var Mota = ngk.MoTa;
            var Giaban = ngk.GiaBan;
            var Khuyenmai = ngk.KhuyenMai;

            nngk.MaLH = MaLH;
            nngk.TenMH = TenMH;
            nngk.DonViTinh = Donvitinh;
            nngk.MoTa = Mota;
            nngk.GiaBan = Giaban;
            nngk.KhuyenMai = Khuyenmai;

            ViewBag.MaLH = new SelectList(data.LOAINGKs.ToList().OrderBy(n => n.TenLH), "MaLH", "TenLH");
            if (fileupload == null)
            {
                nngk.HinhSP = getImage(ngk.MaMH);
            }

            else
            {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(HostingEnvironment.MapPath("~/Content/Hinhsp"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                        return View();
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                        nngk.HinhSP = fileName;
                    }   
               }
            UpdateModel(nngk);
            data.SubmitChanges();
            return RedirectToAction("NGK");
        }
        
    }
}