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
        public IActionResult Index()
        {
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();            
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
            
            ViewData["chitietsp"] = _ctsp.GetAll().FirstOrDefault(c=>c.Id==id);
                      
            return View();
        }        
        [HttpGet]
        public IActionResult Sua(int id)
        {
            ChiTietSP sv = _ctsp.GetAll().FirstOrDefault(c => c.Id == id);
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();
            return View(sv);
        }
        [HttpPost]
        public IActionResult Sua(ChiTietSP chucVu)
        {
            if (chucVu != null)
            {
                _ctsp.Update(chucVu);
                return RedirectToAction("Index", "ChiTietSP");
            }
            return RedirectToAction("Update", "ChiTietSP");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            ChiTietSP sv = _ctsp.GetAll().FirstOrDefault(c => c.Id == id);
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ChiTietSP sv = _ctsp.GetAll().FirstOrDefault(c => c.Id == id);
            ViewData["sanpham"] = _sp.GetAll();
            ViewData["mausac"] = _mausac.GetAll();
            ViewData["nsx"] = _nsx.GetAll();
            ViewData["dongsp"] = _dongsp.GetAll();
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(ChiTietSP chucVu)
        {
            if (chucVu != null)
            {
                _ctsp.Delete(chucVu.Id);
                return RedirectToAction("Index", "ChiTietSP");
            }
            return RedirectToAction("Delete", "ChiTietSP");
        }
    }
}
