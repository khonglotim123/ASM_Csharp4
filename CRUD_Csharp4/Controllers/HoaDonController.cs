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
        private IQLHoaDonService _Hd;
        public HoaDonController()
        {
            _Hd = new QLHoaDonService();
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
    }
}
