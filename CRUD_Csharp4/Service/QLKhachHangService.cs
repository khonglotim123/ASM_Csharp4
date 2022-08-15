using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Service
{
    public class QLKhachHangService: IQLKhachHangService
    {
        private IKhachHangRepository _ch;
        public QLKhachHangService()
        {
            _ch = new KhachHangRepository();
        }

        public bool Create(KhachHang khachHang)
        {
            _ch.Create(khachHang);
            return true;
        }

        public bool Delete(int id)
        {
            _ch.Delete(id);
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _ch.GetAll();
        }

        public bool Update(KhachHang khachHang)
        {
            _ch.Update(khachHang);
            return true;
        }
    }
}
