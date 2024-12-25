using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using C500Hemis.Models.DM;

namespace C500Hemis.Models;

public partial class TbHocVien
{
    [Display(Name = "ID học viên")]
    public int IdHocVien { get; set; }

    [Display(Name = "Mã học viên")]
    public string? MaHocVien { get; set; }

    [Display(Name = "ID người")]
    public int? IdNguoi { get; set; }

    [Display(Name = "Email")]
    public string? Email { get; set; }
    [Display(Name = "Số điện thoại")]
    public string? Sdt { get; set; }
    [Display(Name = "Số sổ bảo hiểm")]
    public string? SoSoBaoHiem { get; set; }
    [Display(Name = "ID loại khuyết tật")]

    public int? IdLoaiKhuyetTat { get; set; }
    [Display(Name = "ID tỉnh")]
    public int? IdTinh { get; set; }
    [Display(Name = "ID Huyện")]
    public int? IdHuyen { get; set; }
    [Display(Name = "ID xã")]
    public int? IdXa { get; set; }
    [Display(Name = "Nơi sinh")]
    public string? NoiSinh { get; set; }
    [Display(Name = "Quê quán")]
    public string? QueQuan { get; set; }

    [Display(Name = "Huyện")]
    public  DmHuyen? IdHuyenNavigation { get; set; }

    [Display(Name = "Loại khuyết tật")]
    public  DmLoaiKhuyetTat? IdLoaiKhuyetTatNavigation { get; set; }

    [Display(Name = "Người")]
    public  TbNguoi? IdNguoiNavigation { get; set; }

    [Display(Name = "Tỉnh")]
    public  DmTinh? IdTinhNavigation { get; set; }

    [Display(Name = "Xã")]
    public  DmXa? IdXaNavigation { get; set; }

    [Display(Name = "Danh hiệu thi đua và giải thưởng người học")]
    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc> TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHocs { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongNguoiHoc>();

    [Display(Name = "Danh sách văn bằng chứng chỉ")]
    public  ICollection<TbDanhSachVanBangChungChi> TbDanhSachVanBangChungChis { get; set; } = new List<TbDanhSachVanBangChungChi>();

    [Display(Name = "Kỷ luật người học")]
    public  ICollection<TbKyLuatNguoiHoc> TbKyLuatNguoiHocs { get; set; } = new List<TbKyLuatNguoiHoc>();

    [Display(Name = "Người học vay tín dụng")]
    public  ICollection<TbNguoiHocVayTinDung> TbNguoiHocVayTinDungs { get; set; } = new List<TbNguoiHocVayTinDung>();

    [Display(Name = "Thông tin học bổng")]
    public  ICollection<TbThongTinHocBong> TbThongTinHocBongs { get; set; } = new List<TbThongTinHocBong>();

    [Display(Name = "Thông tin học tập nghiên cứu sinh")]
    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();

    [Display(Name = "Thông tin GDTC của người học")]
    public  ICollection<TbThongTinNguoiHocGdtc> TbThongTinNguoiHocGdtcs { get; set; } = new List<TbThongTinNguoiHocGdtc>();

    [Display(Name = "Thông tin vi phạm")]
    public  ICollection<TbThongTinViPham> TbThongTinViPhams { get; set; } = new List<TbThongTinViPham>();

    [Display(Name = "Thông tin việc làm sau tốt nghiệp")]
    public  ICollection<TbThongTinViecLamSauTotNghiep> TbThongTinViecLamSauTotNghieps { get; set; } = new List<TbThongTinViecLamSauTotNghiep>();
}