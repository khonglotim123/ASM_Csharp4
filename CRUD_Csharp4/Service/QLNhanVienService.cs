using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.Service
{
    public class QLNhanVienService: IQLNhanVienService
    {
        private INhanVienRepository _ch;
        public QLNhanVienService()
        {
            _ch = new NhanVienRepository();
        }

        public bool Create(NhanVien nhanVien)
        {
            _ch.Create(nhanVien);
            return true;
        }

        public bool Delete(int id)
        {
            _ch.Delete(id);
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _ch.GetAll();            
        }

        public bool Update(NhanVien nhanVien)
        {
            _ch.Update(nhanVien);
            return true;
        }
    }
}
