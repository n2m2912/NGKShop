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
                    var path = Path.Combine(Server.MapPath("~/Content/Hinhsp"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                        return View();
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    ngk.HinhSP = fileName;
                    data.MATHANGs.InsertOnSubmit(ngk);
                    data.SubmitChanges();
                }
                return RedirectToAction("NGK");
            }

        }
        public ActionResult ChitietNGK(int id)
        {
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH == id);
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
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH == id);
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
            MATHANG ngk = data.MATHANGs.SingleOrDefault(n => n.MaMH == id);
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
        [ValidateAntiForgeryToken]
        public ActionResult SuaNGK(MATHANG ngk, HttpPostedFileBase fileUpload)
        {
            
            MATHANG nngk = data.MATHANGs.SingleOrDefault(n => n.MaMH == ngk.MaMH);
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

            if (ModelState.IsValid)
            {
                ViewBag.MaLH = new SelectList(data.LOAINGKs.ToList().OrderBy(n => n.TenLH), "MaLH", "TenLH");
                if (fileUpload == null)
                {
                    nngk.HinhSP = getImage(ngk.MaMH);
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        var fileName = Path.GetFileName(fileUpload.FileName);
                        var path = Path.Combine(Server.MapPath("~/Content/Hinhsp"), fileName);
                        if (System.IO.File.Exists(path))
                        {
                            ngk.HinhSP = fileName;
                            ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                            return View(ngk);
                        }
                        else
                        {
                            fileUpload.SaveAs(path);
                            nngk.HinhSP = fileName;
                        }
                    }
                }
                data.SubmitChanges();
            }
            return RedirectToAction("NGK");
        }
        public ActionResult LoaiHang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(data.LOAINGKs.ToList().OrderBy(n => n.MaLH).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult ThemLH()
        {
            ViewBag.MaNCC = new SelectList(data.NCCs.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemLH(LOAINGK lngk)
        {
            ViewBag.MaNCC = new SelectList(data.NCCs.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            
                if (ModelState.IsValid)
                {
                    data.LOAINGKs.InsertOnSubmit(lngk);
                    data.SubmitChanges();
                }
                return RedirectToAction("LoaiHang");
         }

        public ActionResult ChitietLH(int id)
        {
            LOAINGK lngk = data.LOAINGKs.SingleOrDefault(n => n.MaLH == id);
            ViewBag.MaLH = lngk.MaLH;
            if (lngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(lngk);
        }
        [HttpGet]
        public ActionResult XoaLH(int id)
        {
            LOAINGK lngk = data.LOAINGKs.SingleOrDefault(n => n.MaLH == id);
            ViewBag.MaLH = lngk.MaLH;
            if (lngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(lngk);
        }
        [HttpPost, ActionName("XoaLH")]
        public ActionResult XacnhanxoaLH(int id)
        {
            LOAINGK lngk = data.LOAINGKs.SingleOrDefault(n => n.MaLH == id);
            ViewBag.MaLH = lngk.MaLH;
            if (lngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.LOAINGKs.DeleteOnSubmit(lngk);
            data.SubmitChanges();
            return RedirectToAction("LoaiHang");
        }
        public ActionResult SuaLH(int id)
        {
            LOAINGK lngk = data.LOAINGKs.SingleOrDefault(n => n.MaLH == id);
            ViewBag.MaLH = lngk.MaLH;
            if (lngk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaNCC = new SelectList(data.NCCs.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC", lngk.MaNCC);
            return View(lngk);
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult SuaLH(LOAINGK lngk)
        {

            LOAINGK nlngk = data.LOAINGKs.SingleOrDefault(n => n.MaLH == lngk.MaLH);
            var MaNCC = lngk.MaNCC;
            var TenLH = lngk.TenLH;


            nlngk.TenLH = TenLH;
            nlngk.MaNCC = MaNCC;
            
            if (ModelState.IsValid)
            {
                ViewBag.MaNCC = new SelectList(data.NCCs.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC", lngk.MaNCC);
                data.SubmitChanges();
            }
            return RedirectToAction("LoaiHang");
        }
        public ActionResult KhachHang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(data.KHACHHANGs.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize));
        }
        public ActionResult ChitietKH(int id)
        {
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = kh.MaKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(kh);
        }
        [HttpGet]
        public ActionResult XoaKH(int id)
        {
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = kh.MaKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(kh);
        }
        [HttpPost, ActionName("XoaKH")]
        public ActionResult XacnhanxoaKH(int id)
        {
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = kh.MaKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.KHACHHANGs.DeleteOnSubmit(kh);
            data.SubmitChanges();
            return RedirectToAction("KhachHang");
        }
        public ActionResult NCC(int? page)
        {
             int pageNumber = (page ?? 1);
             int pageSize = 7;
            return View(data.NCCs.ToList().OrderBy(n => n.MaNCC).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult ThemNCC()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemNCC(NCC ncc)
        {
            if (ModelState.IsValid)
            {
                data.NCCs.InsertOnSubmit(ncc);
                data.SubmitChanges();
            }
            return RedirectToAction("NCC");
        }

        public ActionResult ChitietNCC(int id)
        {
            NCC ncc = data.NCCs.SingleOrDefault(n => n.MaNCC== id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ncc);
        }
        [HttpGet]
        public ActionResult XoaNCC(int id)
        {
            NCC ncc = data.NCCs.SingleOrDefault(n => n.MaNCC == id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ncc);
        }
        [HttpPost, ActionName("NCC")]
        public ActionResult XacnhanxoaNCC(int id)
        {
            NCC ncc = data.NCCs.SingleOrDefault(n => n.MaNCC == id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.NCCs.DeleteOnSubmit(ncc);
            data.SubmitChanges();
            return RedirectToAction("NCC");
        }
        public ActionResult SuaNCC(int id)
        {
            NCC ncc = data.NCCs.SingleOrDefault(n => n.MaNCC== id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ncc);
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult SuaNCC(NCC ncc)
        {

            NCC nncc = data.NCCs.SingleOrDefault(n => n.MaNCC == ncc.MaNCC);
            
            var TenNCC = ncc.TenNCC;
            var DiaChi = ncc.DiaChiNCC;
            var SDT = ncc.SDTNCC;


            nncc.TenNCC = TenNCC;
            nncc.DiaChiNCC = DiaChi;
            nncc.SDTNCC = SDT;

            if (ModelState.IsValid)
            {
                data.SubmitChanges();
            }
            return RedirectToAction("NCC");
        }
    }

}