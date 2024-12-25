using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbCanBo
{
    public int IdCanBo { get; set; }

    public int? IdNguoi { get; set; }

    public string? MaCanBo { get; set; }

    public int? IdChucVuCongTac { get; set; }

    public string? SoBaoHiemXaHoi { get; set; }

    public int? IdXa { get; set; }

    public int? IdHuyen { get; set; }

    public int? IdTinh { get; set; }

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public int? IdTrangThaiLamViec { get; set; }

    public DateOnly? NgayChuyenTrangThai { get; set; }

    public string? SoQuyetDinhHuuNghiViec { get; set; }

    public DateOnly? NgayQuyetDinhHuuNghiViec { get; set; }

    public string? HinhThucChuyenDen { get; set; }

    public DateOnly? NgayKetThucTamNghi { get; set; }

    public int? IdChucDanhNgheNghiep { get; set; }

    public int? IdChucDanhGiangVien { get; set; }

    public int? IdChucDanhNghienCuuKhoaHoc { get; set; }

    public int? IdNgach { get; set; }

    public string? CoQuanCongTac { get; set; }

    public DateOnly? NgayTuyenDung { get; set; }

    public bool? ChungChiSuPhamGiangVien { get; set; }

    public bool? LaCongChuc { get; set; }

    public bool? LaVienChuc { get; set; }

    public bool? CoDayMonMacLeNin { get; set; }

    public bool? CoDayMonSuPham { get; set; }

    public string? SoGiayPhepLaoDong { get; set; }

    public int? ThamNienCongTac { get; set; }

    public string? TenDoanhNghiep { get; set; }

    public int? NamKinhNghiemGiangDay { get; set; }

    public bool? GiangVienDapUngTt03 { get; set; }

    public DmChucDanhGiangVien? IdChucDanhGiangVienNavigation { get; set; }

    public DmChucDanhNgheNghiep? IdChucDanhNgheNghiepNavigation { get; set; }

    public DmChucDanhNckh? IdChucDanhNghienCuuKhoaHocNavigation { get; set; }

    public DmChucVu? IdChucVuCongTacNavigation { get; set; }

    public DmHuyen? IdHuyenNavigation { get; set; }

    public DmNgach? IdNgachNavigation { get; set; }

    public TbNguoi? IdNguoiNavigation { get; set; }

    public DmTinh? IdTinhNavigation { get; set; }

    public DmTrangThaiCanBo? IdTrangThaiLamViecNavigation { get; set; }

    public DmXa? IdXaNavigation { get; set; }

    public ICollection<TbCanBoHuongDanThanhCongSinhVien> TbCanBoHuongDanThanhCongSinhViens { get; set; } = new List<TbCanBoHuongDanThanhCongSinhVien>();

    public ICollection<TbChucDanhKhoaHocCuaCanBo> TbChucDanhKhoaHocCuaCanBos { get; set; } = new List<TbChucDanhKhoaHocCuaCanBo>();

    public ICollection<TbDanhGiaXepLoaiCanBo> TbDanhGiaXepLoaiCanBos { get; set; } = new List<TbDanhGiaXepLoaiCanBo>();

    public ICollection<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo> TbDanhHieuThiDuaGiaiThuongKhenThuongCanBos { get; set; } = new List<TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo>();

    public ICollection<TbDienBienLuong> TbDienBienLuongs { get; set; } = new List<TbDienBienLuong>();

    public ICollection<TbDoiTuongChinhSachCanBo> TbDoiTuongChinhSachCanBos { get; set; } = new List<TbDoiTuongChinhSachCanBo>();

    public ICollection<TbDonViCongTacCuaCanBo> TbDonViCongTacCuaCanBos { get; set; } = new List<TbDonViCongTacCuaCanBo>();

    public ICollection<TbDonViThinhGiangCuaCanBo> TbDonViThinhGiangCuaCanBos { get; set; } = new List<TbDonViThinhGiangCuaCanBo>();

    public ICollection<TbGiangVienNn> TbGiangVienNns { get; set; } = new List<TbGiangVienNn>();

    public ICollection<TbGiaoVienQpan> TbGiaoVienQpans { get; set; } = new List<TbGiaoVienQpan>();

    public ICollection<TbGvduocCuDiDaoTao> TbGvduocCuDiDaoTaos { get; set; } = new List<TbGvduocCuDiDaoTao>();

    public ICollection<TbHopDongThinhGiang> TbHopDongThinhGiangs { get; set; } = new List<TbHopDongThinhGiang>();

    public ICollection<TbHopDong> TbHopDongs { get; set; } = new List<TbHopDong>();

    public ICollection<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo> TbKhoaBoiDuongTapHuanThamGiaCuaCanBos { get; set; } = new List<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo>();

    public ICollection<TbKyLuatCanBo> TbKyLuatCanBos { get; set; } = new List<TbKyLuatCanBo>();

    public ICollection<TbLinhVucNghienCuuCuaCanBo> TbLinhVucNghienCuuCuaCanBos { get; set; } = new List<TbLinhVucNghienCuuCuaCanBo>();

    public ICollection<TbNganhDungTenGiangDay> TbNganhDungTenGiangDays { get; set; } = new List<TbNganhDungTenGiangDay>();

    public ICollection<TbNganhGiangDayCuaCanBo> TbNganhGiangDayCuaCanBos { get; set; } = new List<TbNganhGiangDayCuaCanBo>();

    public ICollection<TbPhuCap> TbPhuCaps { get; set; } = new List<TbPhuCap>();

    public ICollection<TbQuaTrinhCongTacCuaCanBo> TbQuaTrinhCongTacCuaCanBos { get; set; } = new List<TbQuaTrinhCongTacCuaCanBo>();

    public ICollection<TbQuaTrinhDaoTaoCuaCanBo> TbQuaTrinhDaoTaoCuaCanBos { get; set; } = new List<TbQuaTrinhDaoTaoCuaCanBo>();

    public ICollection<TbThanhPhanThamGiaDoanCongTac> TbThanhPhanThamGiaDoanCongTacs { get; set; } = new List<TbThanhPhanThamGiaDoanCongTac>();

    public ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhIdNguoiHuongDanChinhNavigations { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();

    public ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhIdNguoiHuongDanPhuNavigations { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();

    public ICollection<TbTrinhDoTiengDanToc> TbTrinhDoTiengDanTocs { get; set; } = new List<TbTrinhDoTiengDanToc>();
}
