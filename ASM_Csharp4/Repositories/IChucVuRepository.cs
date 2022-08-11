using CodeFirst_13Bang.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Repositories
{
    public interface IChucVuRepository
    {
        bool Create(ChucVu chucVu);
        bool Update(ChucVu chucVu);
        bool Delete(int id);
        List<ChucVu> GetAll();
    }
}
