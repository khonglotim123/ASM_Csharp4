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
        private IQLCTSanPhamService _sp;

        public HoaDonChiTietController()
        {

            _ct = new QLHoaDonChiTietService();
            _sp = new CTSanPhamService();
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            return View(_ct.GetAll().Where(c => c.IdHoaDon == id || c.IdHoaDon == ChiTietSPController.idhd).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet!=null)
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
        [HttpPost]
        public IActionResult ThemSP(int a)
        {
            HoaDonChiTiet hoaDonChiTiet = _ct.GetAll().FirstOrDefault(c => c.IdChiTietSP == a && c.IdHoaDon == ChiTietSPController.idhd);
            if (hoaDonChiTiet!=null)
            {
                hoaDonChiTiet.SoLuong++;
                hoaDonChiTiet.DonGia =hoaDonChiTiet.DonGia + Convert.ToInt32(_sp.GetAll().Where(c => c.Id == a).Select(c => c.GiaBan));
                _ct.Update(hoaDonChiTiet);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
            else
            {
                hoaDonChiTiet.IdChiTietSP = a;
                hoaDonChiTiet.IdHoaDon = ChiTietSPController.idhd;
                hoaDonChiTiet.SoLuong++;
                hoaDonChiTiet.DonGia = Convert.ToInt32(_sp.GetAll().Where(c => c.Id == a).Select(c => c.GiaBan));
                _ct.Create(hoaDonChiTiet);
                return RedirectToAction("Index", "HoaDonChiTiet");
            }
            
        }
    }
}
