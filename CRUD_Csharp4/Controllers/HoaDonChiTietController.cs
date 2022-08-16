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
    public class HoaDonChiTietController : Controller
    {
        private IQLHoaDonChiTiet _ct;
        private IQLCTSanPhamService _spct;
        private IQLSanPhamService _sp;
        private int idsp;
        public HoaDonChiTietController()
        {
            _ct = new QLHoaDonChiTietService();
            _spct = new CTSanPhamService();
            _sp = new QLSanPhamService();
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewData["chitietsp"] = _spct.GetAll();
            ViewData["sanpham"] = _sp.GetAll();
            int tong=0;
            if (HoaDonController.idhd==0)
            {
                HoaDonController.idhd = id;
            }
            foreach (var x in _ct.GetAll().Where(c => c.IdHoaDon ==HoaDonController.idhd))
            {
                tong += x.DonGia;                
            }
            ViewData["tongtien"] = tong;
            return View(_ct.GetAll().Where(c =>c.IdHoaDon == HoaDonController.idhd).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet != null)
            {
                _ct.Create(hoaDonChiTiet);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
            return RedirectToAction("Create", "HoaDonChiTiet");
        }
        [HttpGet]
        public IActionResult Update(int a, int b)
        {
            HoaDonChiTiet hoaDonChiTiet = _ct.GetAll().FirstOrDefault(c => c.IdChiTietSP == a && c.IdHoaDon == b);
            return View(hoaDonChiTiet);
        }
        [HttpPost]
        public IActionResult Upate(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet != null)
            {
                _ct.Update(hoaDonChiTiet);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
            return RedirectToAction("Update", "HoaDonChiTiet");
        }

        //public IActionResult ThemSP(int id)
        //{
        //    idsp = id;
        //    return Ok();
        //}
        [HttpGet]
        public IActionResult ThemSP(int id)
        {
            idsp = id;
            HoaDonChiTiet hoaDonChiTiet = _ct.GetAll().FirstOrDefault(c => c.IdChiTietSP == idsp && c.IdHoaDon == HoaDonController.idhd);
            if (hoaDonChiTiet != null)
            {
                hoaDonChiTiet.SoLuong++;
                hoaDonChiTiet.DonGia += _spct.GetAll().FirstOrDefault(c => c.Id == idsp).GiaBan;
                _ct.Update(hoaDonChiTiet);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
            else
            {
                HoaDonChiTiet hoaDonChiTiet1 = new HoaDonChiTiet();
                hoaDonChiTiet1.IdChiTietSP = idsp;
                hoaDonChiTiet1.IdHoaDon = HoaDonController.idhd;
                hoaDonChiTiet1.SoLuong++;
                hoaDonChiTiet1.DonGia = _spct.GetAll().FirstOrDefault(c => c.Id == idsp).GiaBan;
                _ct.Create(hoaDonChiTiet1);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }

        }
    }
}
