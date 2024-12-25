using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDanhSachNganhDaoTao
{
    public int IdDanhSachNganhDaoTao { get; set; }

    public int? IdNganhDaoTao { get; set; }

    public string? SoQuyetDinhChoPhepMoNganh { get; set; }

    public DateOnly? NgayBanHanhVanBanQuyetDinhMoNganh { get; set; }

    public string? MaNganhMoLanDau { get; set; }

    public string? TenNganhMoLanDau { get; set; }

    public string? CoQuanBanHanh { get; set; }

    public string? NguoiKy { get; set; }

    public string? SoQuyetDinhChoPhepDoiTenNganh { get; set; }

    public DateOnly? NgayBanHanhVanBanQuyetDinhDoiTenNganh { get; set; }

    public int? HinhThucDaoTaoTheoChuyenNgu { get; set; }

    public string? NamBatDauDaoTao { get; set; }

    public int? IdQuyetDinhTuChu { get; set; }

    public int? IdTuChuMoNganh { get; set; }

    public int? SoNamDaoTaoThSts { get; set; }

    public string? NamTuyenSinhVaDaoTaoGanNhat { get; set; }

    public int? TongSoNamDaoTaoCuaNganh { get; set; }

    public int? UuTienDaoTaoNhanLucDuLichCntt { get; set; }

    public string? NamBatDauThucHienUuTienDaoTaoNhanLucDuLichCntt { get; set; }

    public string? SoQuyetDinhDaoTaoTuXa { get; set; }

    public DateOnly? NgayQuyetDinhDaoTaoTuXa { get; set; }

    public string? NamBatDauDaoTaoTuXa { get; set; }

    public int? NganhDaoTaoLienKetNuocNgoai { get; set; }

    public int? IdTrangThaiDaoTao { get; set; }

    public  DmTuyChon? HinhThucDaoTaoTheoChuyenNguNavigation { get; set; }

    public  DmNganhDaoTao? IdNganhDaoTaoNavigation { get; set; }

    public  DmQuyetDinhTuChu? IdQuyetDinhTuChuNavigation { get; set; }

    public  DmTrangThaiDaoTao? IdTrangThaiDaoTaoNavigation { get; set; }

    public  DmTuChuMoNganh? IdTuChuMoNganhNavigation { get; set; }

    public  DmTuyChon? NganhDaoTaoLienKetNuocNgoaiNavigation { get; set; }

    public  DmTuyChon? UuTienDaoTaoNhanLucDuLichCnttNavigation { get; set; }
}
