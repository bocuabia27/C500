using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmCapKhenThuong
{
    public int IdCapKhenThuong { get; set; }

    public string? CapKhenThuong { get; set; }

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo> TbDanhHieuThiDuaGiaiThuongKhenThuongCanBos { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd> TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGds { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc> TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHocs { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc>();

    public  ICollection<TbKyLuatCanBo> TbKyLuatCanBos { get; set; } = new List<TbKyLuatCanBo>();

    public  ICollection<TbKyLuatNguoiHoc> TbKyLuatNguoiHocs { get; set; } = new List<TbKyLuatNguoiHoc>();
}
