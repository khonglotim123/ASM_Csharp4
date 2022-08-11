using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Csharp4.IServices;
using CRUD_Csharp4.Service;
using CodeFirst_13Bang.Models;

namespace CRUD_Csharp4.Controllers
{
    public class CuaHangController : Controller
    {
        private IQLCuaHangService _ch;
        public CuaHangController()
        {
            _ch = new QLCuaHangService();
        }
        public IActionResult Index()
        {
            return View(_ch.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CuaHang cuaHang)
        {
            if (cuaHang != null)
            {
                _ch.Create(cuaHang);
                return RedirectToAction("Index", "CuaHang");
            }
            return RedirectToAction("Create", "CuaHang");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            CuaHang sv = _ch.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(CuaHang cuaHang)
        {
            if (cuaHang != null)
            {
                _ch.Update(cuaHang);
                return RedirectToAction("Index", "CuaHang");
            }
            return RedirectToAction("Update", "CuaHang");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            CuaHang sv = _ch.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            CuaHang sv = _ch.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(CuaHang cuaHang)
        {
            if (cuaHang != null)
            {
                _ch.Delete(cuaHang.Id);
                return RedirectToAction("Index", "CuaHang");
            }
            return RedirectToAction("Delete", "CuaHang");
        }
    }
}
