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
    public class NhanVienController : Controller
    {
        private IQLNhanVienService _ch;
        private IQLChucVuService _cv;
        private IQLCuaHangService _cuahang;
        public NhanVienController()
        {
            _ch = new QLNhanVienService();
            _cv = new QlChucVuService();
            _cuahang = new QLCuaHangService();
        }
        public IActionResult Index()
        {
            ViewData["cuahang"] = _cuahang.GetAll();
            ViewData["chucvu"] = _cv.GetAll();
            return View(_ch.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["cuahang"] = _cuahang.GetAll();
            ViewData["chucvu"] = _cv.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(NhanVien cuaHang)
        {
            if (cuaHang != null)
            {
                _ch.Create(cuaHang);
                return RedirectToAction("Index", "NhanVien");
            }
            return RedirectToAction("Create", "NhanVien");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            NhanVien sv = _ch.GetAll().FirstOrDefault(c => c.Id == id);
            ViewData["cuahang"] = _cuahang.GetAll();
            ViewData["chucvu"] = _cv.GetAll();
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(NhanVien cuaHang)
        {
            if (cuaHang != null)
            {
                _ch.Update(cuaHang);
                return RedirectToAction("Index", "NhanVien");
            }
            return RedirectToAction("Update", "NhanVien");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            NhanVien sv = _ch.GetAll().FirstOrDefault(c => c.Id == id);
            ViewData["cuahang"] = _cuahang.GetAll();
            ViewData["chucvu"] = _cv.GetAll();
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            NhanVien sv = _ch.GetAll().FirstOrDefault(c => c.Id == id);
            ViewData["cuahang"] = _cuahang.GetAll();
            ViewData["chucvu"] = _cv.GetAll();
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(CuaHang cuaHang)
        {
            if (cuaHang != null)
            {
                _ch.Delete(cuaHang.Id);
                return RedirectToAction("Index", "NhanVien");
            }
            return RedirectToAction("Delete", "NhanVien");
        }
    }
}
