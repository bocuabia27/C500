using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbChuongTrinhDaoTao
{
    public int IdChuongTrinhDaoTao { get; set; }

    public string? MaChuongTrinhDaoTao { get; set; }

    public int? IdNganhDaoTao { get; set; }

    public string? TenChuongTrinh { get; set; }

    public string? TenChuongTrinhBangTiengAnh { get; set; }

    public DateOnly? NamBatDauTuyenSinh { get; set; }

    public string? TenCoSoDaoTaoNuocNgoai { get; set; }

    public int? IdLoaiChuongTrinhDaoTao { get; set; }

    public int? IdLoaiChuongTrinhLienKetDaoTao { get; set; }

    public string? DiaDiemDaoTao { get; set; }

    public int? IdHocCheDaoTao { get; set; }

    public int? IdQuocGiaCuaTruSoChinh { get; set; }

    public DateOnly? NgayBanHanhChuanDauRa { get; set; }

    public int? IdTrinhDoDaoTao { get; set; }

    public int? ThoiGianDaoTaoChuan { get; set; }

    public string? ChuanDauRa { get; set; }

    public int? IdDonViCapBang { get; set; }

    public string? LoaiChungChiDuocChapThuan { get; set; }

    public string? DonViThucHienChuongTrinh { get; set; }

    public int? IdTrangThaiCuaChuongTrinh { get; set; }

    public string? ChuanDauRaVeNgoaiNgu { get; set; }

    public string? ChuanDauRaVeTinHoc { get; set; }

    public int? HocPhiTaiVietNam { get; set; }

    public int? HocPhiTaiNuocNgoai { get; set; }

    public  DmDonViCapBang? IdDonViCapBangNavigation { get; set; }

    public  DmHocCheDaoTao? IdHocCheDaoTaoNavigation { get; set; }

    public  DmLoaiChuongTrinhDaoTao? IdLoaiChuongTrinhDaoTaoNavigation { get; set; }

    public  DmLoaiChuongTrinhLienKetDaoTao? IdLoaiChuongTrinhLienKetDaoTaoNavigation { get; set; }

    public  DmNganhDaoTao? IdNganhDaoTaoNavigation { get; set; }

    public  DmQuocTich? IdQuocGiaCuaTruSoChinhNavigation { get; set; }

    public  DmTrangThaiChuongTrinhDaoTao? IdTrangThaiCuaChuongTrinhNavigation { get; set; }

    public  DmTrinhDoDaoTao? IdTrinhDoDaoTaoNavigation { get; set; }

    public  ICollection<TbGiaHanChuongTrinhDaoTao> TbGiaHanChuongTrinhDaoTaos { get; set; } = new List<TbGiaHanChuongTrinhDaoTao>();

    public  ICollection<TbNamApDungChuongTrinh> TbNamApDungChuongTrinhs { get; set; } = new List<TbNamApDungChuongTrinh>();

    public  ICollection<TbNgonNguGiangDay> TbNgonNguGiangDays { get; set; } = new List<TbNgonNguGiangDay>();

    public  ICollection<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai> TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoais { get; set; } = new List<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai>();

    public  ICollection<TbThongTinKiemDinhCuaChuongTrinh> TbThongTinKiemDinhCuaChuongTrinhs { get; set; } = new List<TbThongTinKiemDinhCuaChuongTrinh>();
}
