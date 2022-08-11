using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_13Bang.Models
{

    public class KhachHang
    {
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenDem { get; set; }
        public string Ho { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public  string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public string MatKhau { get; set; }
        public List<GioHang> gioHangs { get; set; }
        public List<HoaDon> hoaDons { get; set; }

    }
}
