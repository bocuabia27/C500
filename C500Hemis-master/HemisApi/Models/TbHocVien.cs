using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbHocVien
{
    public int IdHocVien { get; set; }

    public string? MaHocVien { get; set; }

    public int? IdNguoi { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public string? SoSoBaoHiem { get; set; }

    public int? IdLoaiKhuyetTat { get; set; }

    public int? IdTinh { get; set; }

    public int? IdHuyen { get; set; }

    public int? IdXa { get; set; }

    public string? NoiSinh { get; set; }

    public string? QueQuan { get; set; }

    public  DmHuyen? IdHuyenNavigation { get; set; }

    public  DmLoaiKhuyetTat? IdLoaiKhuyetTatNavigation { get; set; }

    public  TbNguoi? IdNguoiNavigation { get; set; }

    public  DmTinh? IdTinhNavigation { get; set; }

    public  DmXa? IdXaNavigation { get; set; }

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc> TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHocs { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc>();

    public  ICollection<TbDanhSachVanBangChungChi> TbDanhSachVanBangChungChis { get; set; } = new List<TbDanhSachVanBangChungChi>();

    public  ICollection<TbKyLuatNguoiHoc> TbKyLuatNguoiHocs { get; set; } = new List<TbKyLuatNguoiHoc>();

    public  ICollection<TbNguoiHocVayTinDung> TbNguoiHocVayTinDungs { get; set; } = new List<TbNguoiHocVayTinDung>();

    public  ICollection<TbThongTinHocBong> TbThongTinHocBongs { get; set; } = new List<TbThongTinHocBong>();

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();

    public  ICollection<TbThongTinNguoiHocGdtc> TbThongTinNguoiHocGdtcs { get; set; } = new List<TbThongTinNguoiHocGdtc>();

    public  ICollection<TbThongTinViPham> TbThongTinViPhams { get; set; } = new List<TbThongTinViPham>();

    public  ICollection<TbThongTinViecLamSauTotNghiep> TbThongTinViecLamSauTotNghieps { get; set; } = new List<TbThongTinViecLamSauTotNghiep>();
}
