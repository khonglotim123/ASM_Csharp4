using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using CRUD_Csharp4.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Controllers
{
    public class ChiTietSPController : Controller
    {
        private IQLCTSanPhamService _ctsp;
        private IQLSanPhamService _sp;
        private IQLMauSacService _mausac;
        private IQLDongSPService _dongsp;
        private IQLNSXService _nsx;
        private IQLHoaDonChiTiet _ct;
        private int idsp;
        public static int idhd;

        public ChiTietSPController()
        {
            _ctsp = new CTSanPhamService();
            _sp = new QLSanPhamService();
            _mausac = new QlMauSacService();
            _dongsp = new QlDongSPService();
            _nsx = new QLNSXService();
            _ct = new QLHoaDonChiTietService();
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();
            idhd = id;
            return View(_ctsp.GetAll());           
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();
            return View();
            
        }
        [HttpPost]
        public IActionResult Create(ChiTietSP chiTietSP)
        {
            if (chiTietSP!=null)
            {
                _ctsp.Create(chiTietSP);
                return RedirectToAction("Index", "ChiTietSP");
            }
            return RedirectToAction("Create", "ChiTietSP");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            idsp = id;
            ViewData["chitietsp"] = _ctsp.GetAll().FirstOrDefault(c=>c.Id==id);
            ViewData["idhd"] = idhd;           
            return View();
        }
        [HttpPost]
        public IActionResult Update()
        {
            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
             hoaDonChiTiet = _ct.GetAll().FirstOrDefault(c => c.IdChiTietSP == idsp && c.IdHoaDon == idhd);            
            if (hoaDonChiTiet != null)
            {
                hoaDonChiTiet.SoLuong++;
                hoaDonChiTiet.DonGia += _ctsp.GetAll().FirstOrDefault(c=>c.Id==idsp).GiaBan;
                _ct.Update(hoaDonChiTiet);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
            else
            {
                HoaDonChiTiet ht = new HoaDonChiTiet();
                ht.IdChiTietSP = idsp;
                ht.IdHoaDon = idhd;
                ht.DonGia = _ctsp.GetAll().FirstOrDefault(c => c.Id == idsp).GiaBan;
                ht.SoLuong++;                
                _ct.Create(ht);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
        }

    }
}
