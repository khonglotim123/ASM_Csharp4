using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using CRUD_Csharp4.Service;
using CRUD_Csharp4.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Controllers
{
    public class HoaDonController : Controller
    {
        private IQLCTSanPhamService _ctsp;
        private IQLHoaDonService _Hd;
        private IQLSanPhamService _sp;
        private IQLMauSacService _mausac;
        private IQLDongSPService _dongsp;
        private IQLNSXService _nsx;
        private IQLHoaDonChiTiet _ct;

        public HoaDonController()
        {
            _Hd = new QLHoaDonService();
            _sp = new QLSanPhamService();
            _mausac = new QlMauSacService();
            _dongsp = new QlDongSPService();
            _nsx = new QLNSXService();
            _ct = new QLHoaDonChiTietService();
            _ctsp = new CTSanPhamService();

        }
        [HttpGet]
        public IActionResult Index()
        {            
            return View(_Hd.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HoaDon hoaDon)
        {
            hoaDon.IdNV = 1;
            hoaDon.IdKH = 1;
            if (hoaDon!=null)
            {
                _Hd.Create(hoaDon);
                return RedirectToAction("Index", "HoaDon");
            }
            return RedirectToAction("Create","HoaDon");
        }
        public IActionResult ThemSP()
        {
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();
            return View(_ctsp.GetAll());
        }
    }
}
