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
    public class MauSacController : Controller
    {
        private IQLMauSacService _ms;
        public MauSacController()
        {
            _ms = new QlMauSacService();
        }
        public IActionResult Index()
        {
            return View(_ms.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MauSac mauSac)
        {
            if (mauSac != null)
            {
                _ms.Create(mauSac);
                return RedirectToAction("Index", "MauSac");
            }
            return RedirectToAction("Create", "MauSac");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            MauSac sv = _ms.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Update(MauSac mauSac)
        {
            if (mauSac != null)
            {
                _ms.Update(mauSac);
                return RedirectToAction("Index", "MauSac");
            }
            return RedirectToAction("Update", "MauSac");
        }
        [HttpGet]
        public IActionResult Chitiet(int id)
        {
            MauSac sv = _ms.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            MauSac sv = _ms.GetAll().FirstOrDefault(c => c.Id == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Delete(MauSac mauSac)
        {
            if (mauSac != null)
            {
                _ms.Delete(mauSac.Id);
                return RedirectToAction("Index", "MauSac");
            }
            return RedirectToAction("Delete", "MauSac");
        }
    }
}
