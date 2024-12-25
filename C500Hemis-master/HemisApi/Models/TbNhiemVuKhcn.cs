using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbNhiemVuKhcn
{
    public int IdNhiemVuKhcn { get; set; }

    public string? MaNhiemVu { get; set; }

    public string? TenNhiemVu { get; set; }

    public int? IdCapQuanLyNhiemVu { get; set; }

    public int? IdCoQuanChuQuan { get; set; }

    public string? CoQuanChuTri { get; set; }

    public string? NguoiChuTri { get; set; }

    public int? IdPhanLoaiNhiemVu { get; set; }

    public string? ThuocNhiemVu { get; set; }

    public int? IdLinhVucNghienCuu { get; set; }

    public string? TongKinhPhiCuaNhiemVu { get; set; }

    public int? IdNguonKinhPhi { get; set; }

    public DateOnly? ThoiGianBatDau { get; set; }

    public DateOnly? ThoiGianKetThuc { get; set; }

    public string? DanhGiaKetQuaNhiemVu { get; set; }

    public string? SanPhamChinhCuaNhiemVu { get; set; }

    public int? IdTinhTrangNhiemVu { get; set; }

    public DmPhanCapNhiemVu? IdCapQuanLyNhiemVuNavigation { get; set; }

    public DmCoQuanChuQuan? IdCoQuanChuQuanNavigation { get; set; }

    public DmLinhVucNghienCuu? IdLinhVucNghienCuuNavigation { get; set; }

    public DmNguonKinhPhi? IdNguonKinhPhiNavigation { get; set; }

    public DmLoaiNhiemVu? IdPhanLoaiNhiemVuNavigation { get; set; }

    public DmTinhTrangNhiemVu? IdTinhTrangNhiemVuNavigation { get; set; }

    public ICollection<TbBaiBaoKhdaCongBo> TbBaiBaoKhdaCongBos { get; set; } = new List<TbBaiBaoKhdaCongBo>();

    public ICollection<TbChuyenGiaoCongNgheVaDaoTao> TbChuyenGiaoCongNgheVaDaoTaos { get; set; } = new List<TbChuyenGiaoCongNgheVaDaoTao>();

    public ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();

    public ICollection<TbSachDaXuatBan> TbSachDaXuatBans { get; set; } = new List<TbSachDaXuatBan>();

    public ICollection<TbTaiSanTriTue> TbTaiSanTriTues { get; set; } = new List<TbTaiSanTriTue>();
}
