using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd
{
    public int IdDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGd { get; set; }

    public int? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public int? IdDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public string? SoQuyetDinhKhenThuong { get; set; }

    public int? IdPhuongThucKhenThuong { get; set; }

    public string? NamKhenThuong { get; set; }

    public int? IdCapKhenThuong { get; set; }

    public  DmCapKhenThuong? IdCapKhenThuongNavigation { get; set; }

    public  DmThiDuaGiaiThuongKhenThuong IdDanhHieuThiDuaGiaiThuongKhenThuongCuaCoSoGdNavigation { get; set; } = null!;

    public  DmLoaiDanhHieuThiDuaGiaiThuongKhenThuong? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuongNavigation { get; set; }

    public  DmPhuongThucKhenThuong? IdPhuongThucKhenThuongNavigation { get; set; }
}
