using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLDongSPService
    {
        bool Create(DongSP dongSP);
        bool Update(DongSP dongSP);
        bool Delete(int id);
        List<DongSP> GetAll();
    }
}
