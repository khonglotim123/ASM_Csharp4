using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;

namespace CRUD_Csharp4.Service
{
    public class QlDongSPService: IQLDongSPService
    {
        private IDongSPRepository _dsp;
        public QlDongSPService()
        {
            _dsp = new DongSPRepository();
        }

        public bool Create(DongSP dongSP)
        {
            _dsp.Create(dongSP);
            return true;
        }

        public bool Delete(int id)
        {
            _dsp.Delete(id);
            return true;
        }

        public List<DongSP> GetAll()
        {
            return _dsp.GetAll();
        }

        public bool Update(DongSP dongSP)
        {
            _dsp.Update(dongSP);
            return true;
        }
    }
}
