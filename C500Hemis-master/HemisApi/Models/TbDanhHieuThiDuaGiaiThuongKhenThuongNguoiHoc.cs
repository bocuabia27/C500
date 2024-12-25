using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc
{
    public int IdDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc { get; set; }

    public int? IdHocVien { get; set; }

    public int? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public int? IdDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public string? SoQuyetDinhKhenThuong { get; set; }

    public int? IdPhuongThucKhenThuong { get; set; }

    public string? NamKhenThuong { get; set; }

    public int? IdCapKhenThuong { get; set; }

    public  DmCapKhenThuong? IdCapKhenThuongNavigation { get; set; }

    public  DmThiDuaGiaiThuongKhenThuong? IdDanhHieuThiDuaGiaiThuongKhenThuongNavigation { get; set; }

    public  TbHocVien? IdHocVienNavigation { get; set; }

    public  DmLoaiDanhHieuThiDuaGiaiThuongKhenThuong? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuongNavigation { get; set; }

    public  DmPhuongThucKhenThuong? IdPhuongThucKhenThuongNavigation { get; set; }
}
