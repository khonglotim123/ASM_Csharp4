
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
    public class SanPhamController : Controller
    {
        private IQLSanPhamService _sp;
        public SanPhamController()
        {
            _sp = new QLSanPhamService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<SanPham> lst = _sp.GetAll();
            return View(lst);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham sanPham)
        {
            if (sanPham != null)
            {
                _sp.Create(sanPham);
                return RedirectToAction("Index", "SanPham");
            }
            return RedirectToAction("Create", "SanPham");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            SanPham sv = _sp.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(SanPham sanPham)
        {
            if (sanPham!=null)
            {
                _sp.Update(sanPham);
                return RedirectToAction("Index", "SanPham");
            }
            return RedirectToAction("Update", "SanPham");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            SanPham sv = _sp.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            SanPham sv = _sp.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(SanPham sanPham)
        {
            if (sanPham!=null)
            {
                _sp.Delete(sanPham.Id);
                return RedirectToAction("Index", "SanPham");
            }
            return RedirectToAction("Delete", "SanPham");
        }
    }
}
