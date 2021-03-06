﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGKShop.Models
{
    public class Giohang
    {
        NGKDataDataContext data = new NGKDataDataContext();

        public int iMaMH { set; get; }

        public string sTenMH { set; get; }

        public string sHinhSP { set; get; }

        public Double dDonGia { set; get; }

        public int iSoluong { set; get; }

        public Double kKhuyenmai { set; get; }

        public Double dThanhtien
        {
            get { return (iSoluong * dDonGia)-(iSoluong * dDonGia *(Double)(kKhuyenmai/100)); }
        }
        public Giohang(int MaMH)
        {
            iMaMH = MaMH;
            MATHANG ngk = data.MATHANGs.Single(n => n.MaMH == iMaMH);
            sTenMH = ngk.TenMH;
            sHinhSP = ngk.HinhSP;
            kKhuyenmai = (Double)ngk.KhuyenMai;
            dDonGia = double.Parse(ngk.GiaBan.ToString());
            iSoluong = 1;
        }
    }
}