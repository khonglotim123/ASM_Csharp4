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
    public class DongSPController : Controller
    {
        private IQLDongSPService _dsp;
        public DongSPController()
        {
            _dsp = new QlDongSPService();
        }
        public IActionResult Index()
        {
            return View(_dsp.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DongSP dongSP)
        {
            if (dongSP != null)
            {
                _dsp.Create(dongSP);
                return RedirectToAction("Index", "DongSP");
            }
            return RedirectToAction("Create", "DongSP");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            DongSP sv = _dsp.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(DongSP dongSP)
        {
            if (dongSP != null)
            {
                _dsp.Update(dongSP);
                return RedirectToAction("Index", "DongSP");
            }
            return RedirectToAction("Update", "DongSP");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            DongSP sv = _dsp.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            DongSP sv = _dsp.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(DongSP dongSP)
        {
            if (dongSP != null)
            {
                _dsp.Delete(dongSP.Id);
                return RedirectToAction("Index", "DongSP");
            }
            return RedirectToAction("Delete", "DongSP");
        }
    }
}
