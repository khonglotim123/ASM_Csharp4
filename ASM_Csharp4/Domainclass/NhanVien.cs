using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_13Bang.Models
{

    public class NhanVien
    {       
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenDem { get; set; }
        public string Ho { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public  string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public int IdCH { get; set; }
        public int IdCV { get; set; }
        public int IdGuiBc { get; set; }
        public List<HoaDon> hoaDons { get; set; }
        public IList<NhanVien> nhanViens { get; set; }
        public ChucVu chucVu { get; set; }
        public NhanVien nhanVien { get; set; }
        public CuaHang cuaHang { get; set; }

    }
}
