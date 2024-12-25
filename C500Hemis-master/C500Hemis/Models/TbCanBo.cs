using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using C500Hemis.Models.DM;
using Microsoft.AspNetCore.Authorization;

namespace C500Hemis.Models;

[Authorize]
public partial class TbCanBo
{
    [Display(Name = "Id cán bộ")]
    public int IdCanBo { get; set; }
    [Display(Name = "Id người")]
    public int? IdNguoi { get; set; }
    [Display(Name = "Mã cán bộ")]
    public string? MaCanBo { get; set; }
    [Display(Name = "Id chức vụ công tác")]
    public int? IdChucVuCongTac { get; set; }
    [Display(Name = "Số bảo hiểm xã hội")]
    public string? SoBaoHiemXaHoi { get; set; }
    [Display(Name = "Id xã")]
    public int? IdXa { get; set; }
    [Display(Name = "Id huyện")]
    public int? IdHuyen { get; set; }
    [Display(Name = "Id tỉnh")]
    public int? IdTinh { get; set; }
    [Display(Name = "Email")]
    public string? Email { get; set; }
    [Display(Name = "Điện thoại")]
    public string? DienThoai { get; set; }
    [Display(Name = "Id trạng thái làm việc")]
    public int? IdTrangThaiLamViec { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Ngày chuyển trạng thái")]
    public DateOnly? NgayChuyenTrangThai { get; set; }
    [Display(Name = "Số quyết định hưu nghỉ việc")]
    public string? SoQuyetDinhHuuNghiViec { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Ngày quyết định hưu nghỉ việc")]
    public DateOnly? NgayQuyetDinhHuuNghiViec { get; set; }
    [Display(Name = "Hình thức chuyển đến")]
    public string? HinhThucChuyenDen { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Ngày kết thúc tạm nghỉ")]
    public DateOnly? NgayKetThucTamNghi { get; set; }
    [Display(Name = "Id chức danh nghề nghiệp")]
    public int? IdChucDanhNgheNghiep { get; set; }
    [Display(Name = "Id chức danh giảng viên")]
    public int? IdChucDanhGiangVien { get; set; }
    [Display(Name = "Id chức danh nghiên cứu khoa học")]
    public int? IdChucDanhNghienCuuKhoaHoc { get; set; }
    [Display(Name = "Id nghạch")]
    public int? IdNgach { get; set; }
    [Display(Name = "Cơ quan công tác")]
    public string? CoQuanCongTac { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Ngày tuyển dụng")]
    public DateOnly? NgayTuyenDung { get; set; }
    [Display(Name = "Chứng chỉ sư phạm giảng viên")]
    public bool? ChungChiSuPhamGiangVien { get; set; }
    [Display(Name = "Là công chức")]
    public bool? LaCongChuc { get; set; }
    [Display(Name = "Là viên chức")]
    public bool? LaVienChuc { get; set; }
    [Display(Name = "Có dạy môn Mác-Lênin")]
    public bool? CoDayMonMacLeNin { get; set; }
    [Display(Name = "Có dạy môn sư phạm")]
    public bool? CoDayMonSuPham { get; set; }
    [Display(Name = "Số giấy phép lao động")]

    public string? SoGiayPhepLaoDong { get; set; }
    [Display(Name = "Thâm niên công tác")]

    public int? ThamNienCongTac { get; set; }
    [Display(Name = "Tên doanh nghiệp")]

    public string? TenDoanhNghiep { get; set; }
    [Display(Name = "Năm kinh nghiệm giảng dạy")]

    public int? NamKinhNghiemGiangDay { get; set; }
    [Display(Name = "Giảng viên đáp ứng TT03")]

    public bool? GiangVienDapUngTt03 { get; set; }
    [Display(Name = "Id chức danh giảng viên")]

    public  DmChucDanhGiangVien? IdChucDanhGiangVienNavigation { get; set; }
    [Display(Name = "Id chức danh nghề nghiệp")]

    public  DmChucDanhNgheNghiep? IdChucDanhNgheNghiepNavigation { get; set; }
    [Display(Name = "Id chức danh nghiên cứu khoa học")]

    public  DmChucDanhNckh? IdChucDanhNghienCuuKhoaHocNavigation { get; set; }
    [Display(Name = "Id chức vụ công tác")]

    public  DmChucVu? IdChucVuCongTacNavigation { get; set; }
    [Display(Name = "Id huyện")]

    public  DmHuyen? IdHuyenNavigation { get; set; }
    [Display(Name = "Id nghạch")]

    public  DmNgach? IdNgachNavigation { get; set; }
    [Display(Name = "Id người")]

    public  TbNguoi? IdNguoiNavigation { get; set; }
    [Display(Name = "Id tỉnh")]

    public  DmTinh? IdTinhNavigation { get; set; }
    [Display(Name = "Id trạng thái việc làm")]

    public  DmTrangThaiCanBo? IdTrangThaiLamViecNavigation { get; set; }
    [Display(Name = "Id xã")]

    public  DmXa? IdXaNavigation { get; set; }

    public  ICollection<TbCanBoHuongDanThanhCongSinhVien> TbCanBoHuongDanThanhCongSinhViens { get; set; } = new List<TbCanBoHuongDanThanhCongSinhVien>();

    public  ICollection<TbChucDanhKhoaHocCuaCanBo> TbChucDanhKhoaHocCuaCanBos { get; set; } = new List<TbChucDanhKhoaHocCuaCanBo>();

    public  ICollection<TbDanhGiaXepLoaiCanBo> TbDanhGiaXepLoaiCanBos { get; set; } = new List<TbDanhGiaXepLoaiCanBo>();

    public  ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo> TbDanhHieuThiDuaGiaiThuongKhenThuongCanBos { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo>();

    public  ICollection<TbDienBienLuong> TbDienBienLuongs { get; set; } = new List<TbDienBienLuong>();

    public  ICollection<TbDoiTuongChinhSachCanBo> TbDoiTuongChinhSachCanBos { get; set; } = new List<TbDoiTuongChinhSachCanBo>();

    public  ICollection<TbDonViCongTacCuaCanBo> TbDonViCongTacCuaCanBos { get; set; } = new List<TbDonViCongTacCuaCanBo>();

    public  ICollection<TbDonViThinhGiangCuaCanBo> TbDonViThinhGiangCuaCanBos { get; set; } = new List<TbDonViThinhGiangCuaCanBo>();

    public  ICollection<TbGiangVienNn> TbGiangVienNns { get; set; } = new List<TbGiangVienNn>();

    public  ICollection<TbGiaoVienQpan> TbGiaoVienQpans { get; set; } = new List<TbGiaoVienQpan>();

    public  ICollection<TbGvduocCuDiDaoTao> TbGvduocCuDiDaoTaos { get; set; } = new List<TbGvduocCuDiDaoTao>();

    public  ICollection<TbHopDongThinhGiang> TbHopDongThinhGiangs { get; set; } = new List<TbHopDongThinhGiang>();

    public  ICollection<TbHopDong> TbHopDongs { get; set; } = new List<TbHopDong>();

    public  ICollection<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo> TbKhoaBoiDuongTapHuanThamGiaCuaCanBos { get; set; } = new List<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo>();

    public  ICollection<TbKyLuatCanBo> TbKyLuatCanBos { get; set; } = new List<TbKyLuatCanBo>();

    public  ICollection<TbLinhVucNghienCuuCuaCanBo> TbLinhVucNghienCuuCuaCanBos { get; set; } = new List<TbLinhVucNghienCuuCuaCanBo>();

    public  ICollection<TbNganhDungTenGiangDay> TbNganhDungTenGiangDays { get; set; } = new List<TbNganhDungTenGiangDay>();

    public  ICollection<TbNganhGiangDayCuaCanBo> TbNganhGiangDayCuaCanBos { get; set; } = new List<TbNganhGiangDayCuaCanBo>();

    public  ICollection<TbPhuCap> TbPhuCaps { get; set; } = new List<TbPhuCap>();

    public  ICollection<TbQuaTrinhCongTacCuaCanBo> TbQuaTrinhCongTacCuaCanBos { get; set; } = new List<TbQuaTrinhCongTacCuaCanBo>();

    public  ICollection<TbQuaTrinhDaoTaoCuaCanBo> TbQuaTrinhDaoTaoCuaCanBos { get; set; } = new List<TbQuaTrinhDaoTaoCuaCanBo>();

    public  ICollection<TbThanhPhanThamGiaDoanCongTac> TbThanhPhanThamGiaDoanCongTacs { get; set; } = new List<TbThanhPhanThamGiaDoanCongTac>();

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhIdNguoiHuongDanChinhNavigations { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhIdNguoiHuongDanPhuNavigations { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();

    public  ICollection<TbTrinhDoTiengDanToc> TbTrinhDoTiengDanTocs { get; set; } = new List<TbTrinhDoTiengDanToc>();
}
