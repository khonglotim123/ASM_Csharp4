using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_Csharp4.Repositories;
using CodeFirst_13Bang.Models;
using CRUD_Csharp4.IServices;

namespace CRUD_Csharp4.Service
{
    public class QlMauSacService : IQLMauSacService
    {
        private IMauSacRepository _ms;
        public QlMauSacService()
        {
            _ms = new MauSacRepository();
        }
        public bool Create(MauSac mauSac)
        {
            _ms.Create(mauSac);
            return true;
        }

        public bool Delete(int id)
        {
            _ms.Delete(id);
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _ms.GetAll();
        }

        public bool Update(MauSac mauSac)
        {
            _ms.Update(mauSac);
            return true;
        }
    }
}
