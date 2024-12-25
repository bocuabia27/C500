﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using C500Hemis.Models.DM;
using Microsoft.AspNetCore.Authorization;

namespace C500Hemis.Models;

[Authorize]
public partial class TbChuongTrinhDaoTao
{
    [DisplayName(" ID chương trình đào tạo")]
    public int IdChuongTrinhDaoTao { get; set; }


    [DisplayName("Mã chương trình đào tạo ")]
    public string? MaChuongTrinhDaoTao { get; set; }


    [DisplayName("Ngành đào tạo")]
    public int? IdNganhDaoTao { get; set; }


    [DisplayName("Tên chương trình")]
    public string? TenChuongTrinh { get; set; }


    [DisplayName("Tên chương trình bằng tiếng Anh")]
    public string? TenChuongTrinhBangTiengAnh { get; set; }


    [DisplayName("Năm bắt đầu tuyển sinh")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateOnly? NamBatDauTuyenSinh { get; set; }


    [DisplayName("Tên cơ sở đào tạo nước ngoài")]
    public string? TenCoSoDaoTaoNuocNgoai { get; set; }


    [DisplayName("Loại chương trình đào tạo ")]
    public int? IdLoaiChuongTrinhDaoTao { get; set; }


    [DisplayName("Loại chương trình liên kết đào tạo")]
    public int? IdLoaiChuongTrinhLienKetDaoTao { get; set; }


    [DisplayName("Địa điểm đào tạo")]
    public string? DiaDiemDaoTao { get; set; }


    [DisplayName("Học chế đào tạo")]
    public int? IdHocCheDaoTao { get; set; }


    [DisplayName("Quốc gia trụ sở chính")]
    public int? IdQuocGiaCuaTruSoChinh { get; set; }


    [DisplayName("Ngày ban hành chuẩn đầu ra")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateOnly? NgayBanHanhChuanDauRa { get; set; }


    [DisplayName("Trình độ đào tạo")]
    public int? IdTrinhDoDaoTao { get; set; }


    [DisplayName("Thời gian đào tạo chuẩn")]
    public int? ThoiGianDaoTaoChuan { get; set; }


    [DisplayName("Chuẩn đầu ra")]
    public string? ChuanDauRa { get; set; }


    [DisplayName("Đơn vị cấp bằng")]
    public int? IdDonViCapBang { get; set; }


    [DisplayName("Loại chứng chỉ được chấp thuận")]
    public string? LoaiChungChiDuocChapThuan { get; set; }


    [DisplayName("Đơn vị thực hiện chương trình")]
    public string? DonViThucHienChuongTrinh { get; set; }


    [DisplayName("Trạng thái của chương trình")]
    public int? IdTrangThaiCuaChuongTrinh { get; set; }


    [DisplayName("Chuẩn đầu ra về ngoại ngữ")]
    public string? ChuanDauRaVeNgoaiNgu { get; set; }


    [DisplayName("Chuẩn đầu ra về tin học")]
    public string? ChuanDauRaVeTinHoc { get; set; }


    [DisplayName("Học phí tại Việt Nam")]
    public int? HocPhiTaiVietNam { get; set; }


    [DisplayName("Học phí tại nước ngoài")]
    public int? HocPhiTaiNuocNgoai { get; set; }


    [DisplayName("Đơn Vị Cấp Bằng Navigation ")]
    public  DmDonViCapBang? IdDonViCapBangNavigation { get; set; }


    [DisplayName("Học Chế Đào Tạo Navigation ")]
    public  DmHocCheDaoTao? IdHocCheDaoTaoNavigation { get; set; }


    [DisplayName("Loại Chương Trình Đào Tạo Navigation ")]
    public  DmLoaiChuongTrinhDaoTao? IdLoaiChuongTrinhDaoTaoNavigation { get; set; }


    [DisplayName("Loại Chương Trình Liên Kết Đào Tạo Navigation ")]
    public  DmLoaiChuongTrinhLienKetDaoTao? IdLoaiChuongTrinhLienKetDaoTaoNavigation { get; set; }


    [DisplayName("Ngành Đào Tạo Navigation ")]
    public  DmNganhDaoTao? IdNganhDaoTaoNavigation { get; set; }


    [DisplayName("Quốc Gia Của Trụ Sở Chính Navigation ")]
    public  DmQuocTich? IdQuocGiaCuaTruSoChinhNavigation { get; set; }


    [DisplayName("Trạng Thái Của Chương Trình Navigation ")]
    public  DmTrangThaiChuongTrinhDaoTao? IdTrangThaiCuaChuongTrinhNavigation { get; set; }


    [DisplayName(" Trình Độ Đào Tạo Navigation ")]
    public  DmTrinhDoDaoTao? IdTrinhDoDaoTaoNavigation { get; set; }


    [DisplayName("Gia Hạn Chương Trình Đào Tạo ")]
    public  ICollection<TbGiaHanChuongTrinhDaoTao> TbGiaHanChuongTrinhDaoTaos { get; set; } = new List<TbGiaHanChuongTrinhDaoTao>();


    [DisplayName("Năm Áp Dụng Chương Trình ")]
    public  ICollection<TbNamApDungChuongTrinh> TbNamApDungChuongTrinhs { get; set; } = new List<TbNamApDungChuongTrinh>();

    
    [DisplayName("Ngôn Ngữ Giảng Dạy ")]
    public  ICollection<TbNgonNguGiangDay> TbNgonNguGiangDays { get; set; } = new List<TbNgonNguGiangDay>();


    [DisplayName("Quyết Định Cấp Phép Chương Trình Dùng Cho Chương Trình Nước Ngoài ")]
    public  ICollection<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai> TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoais { get; set; } = new List<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai>();


    [DisplayName("Thông Tin Kiểm Định Của Chương Trình ")]
    public  ICollection<TbThongTinKiemDinhCuaChuongTrinh> TbThongTinKiemDinhCuaChuongTrinhs { get; set; } = new List<TbThongTinKiemDinhCuaChuongTrinh>();
}