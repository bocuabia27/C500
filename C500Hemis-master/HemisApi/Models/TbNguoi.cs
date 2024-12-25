using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbNguoi
{
    public int IdNguoi { get; set; }

    public string? Ho { get; set; }

    public string? Ten { get; set; }

    public int? IdQuocTich { get; set; }

    public string? SoCccd { get; set; }

    public DateOnly? NgayCapCccd { get; set; }

    public string? NoiCapCccd { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public int? IdGioiTinh { get; set; }

    public int? IdDanToc { get; set; }

    public int? IdTonGiao { get; set; }

    public DateOnly? NgayVaoDoan { get; set; }

    public DateOnly? NgayVaoDang { get; set; }

    public DateOnly? NgayVaoDangChinhThuc { get; set; }

    public DateOnly? NgayNhapNgu { get; set; }

    public DateOnly? NgayXuatNgu { get; set; }

    public int? IdThuongBinhHang { get; set; }

    public int? IdGiaDinhChinhSach { get; set; }

    public int? IdChucDanhKhoaHoc { get; set; }

    public int? IdTrinhDoDaoTao { get; set; }

    public int? IdChuyenMonDaoTao { get; set; }

    public int? IdNgoaiNgu { get; set; }

    public int? IdKhungNangLucNgoaiNguc { get; set; }

    public int? IdTrinhDoLyLuanChinhTri { get; set; }

    public int? IdTrinhDoQuanLyNhaNuoc { get; set; }

    public int? IdTrinhDoTinHoc { get; set; }

    public  DmChucDanhKhoaHoc? IdChucDanhKhoaHocNavigation { get; set; }

    public  DmNganhDaoTao? IdChuyenMonDaoTaoNavigation { get; set; }

    public  DmDanToc? IdDanTocNavigation { get; set; }

    public  DmHoGiaDinhChinhSach? IdGiaDinhChinhSachNavigation { get; set; }

    public  DmGioiTinh? IdGioiTinhNavigation { get; set; }

    public  DmKhungNangLucNgoaiNgu? IdKhungNangLucNgoaiNgucNavigation { get; set; }

    public  DmNgoaiNgu? IdNgoaiNguNavigation { get; set; }

    public  DmQuocTich? IdQuocTichNavigation { get; set; }

    public  DmHangThuongBinh? IdThuongBinhHangNavigation { get; set; }

    public  DmTonGiao? IdTonGiaoNavigation { get; set; }

    public  DmTrinhDoDaoTao? IdTrinhDoDaoTaoNavigation { get; set; }

    public  DmTrinhDoLyLuanChinhTri? IdTrinhDoLyLuanChinhTriNavigation { get; set; }

    public  DmTrinhDoQuanLyNhaNuoc? IdTrinhDoQuanLyNhaNuocNavigation { get; set; }

    public  DmTrinhDoTinHoc? IdTrinhDoTinHocNavigation { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();

    public  ICollection<TbDoiTuongThamGium> TbDoiTuongThamGia { get; set; } = new List<TbDoiTuongThamGium>();

    public  ICollection<TbHocVien> TbHocViens { get; set; } = new List<TbHocVien>();
}
