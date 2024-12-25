using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbThongTinHocTapSinhVien
{
    public int IdThongTinHocTapHocVien { get; set; }

    public int? IdHocVien { get; set; }

    public int? IdDoiTuongDauVao { get; set; }

    public string? SoQuyetDinhTrungTuyen { get; set; }

    public DateOnly? NgayKyQuyetDinhTrungTuyen { get; set; }

    public int? IdSinhVienNam { get; set; }

    public string? KetQuaTuyenSinh { get; set; }

    public int? IdChuongTrinhDaoTao { get; set; }

    public int? IdLoaiHinhDaoTao { get; set; }

    public DateOnly? DaoTaoTuNam { get; set; }

    public DateOnly? DaoTaoDenNam { get; set; }

    public string? Khoa { get; set; }

    public string? Lop { get; set; }

    public int? BangTotNghiepLienThong { get; set; }

    public int? DangOnoiTru { get; set; }

    public DateOnly? NgayNhapHoc { get; set; }

    public int? IdTrangThaiHoc { get; set; }

    public DateOnly? NgayChuyenTrangThai { get; set; }

    public string? SoQuyetDinhThoiHoc { get; set; }

    public DateOnly? ThoiGianTotNghiep { get; set; }

    public int? IdLoaiTotNghiep { get; set; }

    public string? SoQuyetDinhTotNghiep { get; set; }

    public DateOnly? NgayQuyetDinhCongNhanTotNghiep { get; set; }

    public  DmTuyChon? BangTotNghiepLienThongNavigation { get; set; }

    public  DmTuyChon? DangOnoiTruNavigation { get; set; }

    public  DmChuongTrinhDaoTao? IdChuongTrinhDaoTaoNavigation { get; set; }

    public  DmDoiTuongDauVao? IdDoiTuongDauVaoNavigation { get; set; }

    public  TbHocVien? IdHocVienNavigation { get; set; }

    public  DmLoaiHinhDaoTao? IdLoaiHinhDaoTaoNavigation { get; set; }

    public  DmLoaiTotNghiep? IdLoaiTotNghiepNavigation { get; set; }

    public  DmSinhVienNam? IdSinhVienNamNavigation { get; set; }

    public  DmTrangThaiHoc? IdTrangThaiHocNavigation { get; set; }
}
