using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTuyChon
{
    public int IdTuyChon { get; set; }

    public string? TuyChon { get; set; }

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucHoatDongKhongLoiNhuanNavigations { get; set; } = new List<TbCoSoGiaoDuc>();

    public  ICollection<TbCoSoGiaoDuc> TbCoSoGiaoDucTuChuGiaoDucQpanNavigations { get; set; } = new List<TbCoSoGiaoDuc>();

    public  ICollection<TbCongTrinhCoSoVatChat> TbCongTrinhCoSoVatChats { get; set; } = new List<TbCongTrinhCoSoVatChat>();

    public  ICollection<TbDanhSachNganhDaoTao> TbDanhSachNganhDaoTaoHinhThucDaoTaoTheoChuyenNguNavigations { get; set; } = new List<TbDanhSachNganhDaoTao>();

    public  ICollection<TbDanhSachNganhDaoTao> TbDanhSachNganhDaoTaoNganhDaoTaoLienKetNuocNgoaiNavigations { get; set; } = new List<TbDanhSachNganhDaoTao>();

    public  ICollection<TbDanhSachNganhDaoTao> TbDanhSachNganhDaoTaoUuTienDaoTaoNhanLucDuLichCnttNavigations { get; set; } = new List<TbDanhSachNganhDaoTao>();

    public  ICollection<TbNguoiHocVayTinDung> TbNguoiHocVayTinDungs { get; set; } = new List<TbNguoiHocVayTinDung>();
}
