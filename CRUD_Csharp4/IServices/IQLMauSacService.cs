using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Csharp4.IServices
{
    public interface IQLMauSacService
    {
        bool Create(MauSac mauSac);
        bool Update(MauSac mauSac);
        bool Delete(int id);
        List<MauSac> GetAll();
    }
}
