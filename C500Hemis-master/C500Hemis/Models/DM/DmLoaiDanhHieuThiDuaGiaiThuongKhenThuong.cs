using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmLoaiDanhHieuThiDuaGiaiThuongKhenThuong
{
    public int IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public string? LoaiDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo> TbDanhHieuThiDuaGiaiThuongKhenThuongCanBos { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd> TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGds { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc> TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHocs { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc>();
}
