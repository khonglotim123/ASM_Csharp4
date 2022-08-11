using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_13Bang.Models
{

    public class GioHangChiTiet
    {
        public int IdGioHang { get; set; }
        public int IdChiTietSP { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int DonGiaKhiGiam { get; set; }
        public GioHang gioHang { get; set; }
        public ChiTietSP chiTietSP { get; set; }

    }
}
