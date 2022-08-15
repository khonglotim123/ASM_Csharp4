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
    public class KhachHangController : Controller
    {
        private IQLKhachHangService _cv;
        public KhachHangController()
        {
            _cv = new QLKhachHangService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_cv.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(KhachHang chucVu)
        {
            if (chucVu != null)
            {
                _cv.Create(chucVu);
                return RedirectToAction("Index", "KhachHang");
            }
            return RedirectToAction("Create", "KhachHang");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            KhachHang sv = _cv.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(KhachHang chucVu)
        {
            if (chucVu != null)
            {
                _cv.Update(chucVu);
                return RedirectToAction("Index", "KhachHang");
            }
            return RedirectToAction("Update", "KhachHang");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            KhachHang sv = _cv.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            KhachHang sv = _cv.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(KhachHang chucVu)
        {
            if (chucVu != null)
            {
                _cv.Delete(chucVu.Id);
                return RedirectToAction("Index", "KhachHang");
            }
            return RedirectToAction("Delete", "KhachHang");
        }
    }
}
