using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;

namespace CRUD_Csharp4.Service
{
    public class QlChucVuService : IQLChucVuService
    {
        private IChucVuRepository _cv;
        public QlChucVuService()
        {
            _cv = new ChucVuRepository();
        }

        public bool Create(ChucVu chucVu)
        {
            _cv.Create(chucVu);
            return true;
        }

        public bool Delete(int id)
        {
            _cv.Delete(id);
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _cv.GetAll();
        }

        public bool Update(ChucVu chucVu)
        {
            _cv.Update(chucVu);
            return true;
        }
    }
}
