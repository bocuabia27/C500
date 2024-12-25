using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmPhuongThucKhenThuong
{
    public int IdPhuongThucKhenThuong { get; set; }

    public string? PhuongThucKhenThuong { get; set; }

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo> TbDanhHieuThiDuaGiaiThuongKhenThuongCanBos { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd> TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGds { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc> TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHocs { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc>();
}
