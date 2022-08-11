using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_13Bang.Models
{

    public class GioHang
    {
        
        public int Id { get; set; }
        public int IdNV { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string TenNguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public int TinhTrang { get; set; }
        public int IdKH { get; set; }
        public KhachHang khachHang { get; set; }
        public IList<GioHangChiTiet> GioHangChiTiets { get; set; }

    }
}
