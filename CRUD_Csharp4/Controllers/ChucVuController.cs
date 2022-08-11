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
    public class ChucVuController : Controller
    {
        private IQLChucVuService _cv;
        public ChucVuController()
        {
            _cv = new QlChucVuService();
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
        public IActionResult Create(ChucVu chucVu)
        {
            if (chucVu != null)
            {
                _cv.Create(chucVu);
                return RedirectToAction("Index", "ChucVu");
            }
            return RedirectToAction("Create", "ChucVu");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ChucVu sv = _cv.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(ChucVu chucVu)
        {
            if (chucVu != null)
            {
                _cv.Update(chucVu);
                return RedirectToAction("Index", "ChucVu");
            }
            return RedirectToAction("Update", "ChucVu");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            ChucVu sv = _cv.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ChucVu sv = _cv.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(ChucVu chucVu)
        {
            if (chucVu != null)
            {
                _cv.Delete(chucVu.Id);
                return RedirectToAction("Index", "ChucVu");
            }
            return RedirectToAction("Delete", "ChucVu");
        }
    }
}
