using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Csharp4.IServices;
using CRUD_Csharp4.Service;
using CRUD_Csharp4.IServices;
using CRUD_Csharp4.Service;
using CodeFirst_13Bang.Models;

namespace CRUD_Csharp4.Controllers
{
    public class NSXController : Controller
    {
        private IQLNSXService _nsx;
        public NSXController()
        {
            _nsx = new QLNSXService();
        }
        public IActionResult Index()
        {
            return View(_nsx.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(NSX nSX)
        {
            if (nSX != null)
            {
                _nsx.Create(nSX);
                return RedirectToAction("Index", "NSX");
            }
            return RedirectToAction("Create", "NSX");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            NSX sv = _nsx.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(NSX nSX)
        {
            if (nSX != null)
            {
                _nsx.Update(nSX);
                return RedirectToAction("Index", "NSX");
            }
            return RedirectToAction("Update", "NSX");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            NSX sv = _nsx.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            NSX sv = _nsx.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(NSX nSX)
        {
            if (nSX != null)
            {
                _nsx.Delete(nSX.Id);
                return RedirectToAction("Index", "NSX");
            }
            return RedirectToAction("Delete", "NSX");
        }
    }
}
