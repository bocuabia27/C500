using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmNguonKinhPhi
{
    public int IdNguonKinhPhi { get; set; }

    public string? NguonKinhPhi { get; set; }

    public ICollection<TbHoatDongBaoVeMoiTruong> TbHoatDongBaoVeMoiTruongs { get; set; } = new List<TbHoatDongBaoVeMoiTruong>();

    public ICollection<TbHoiThaoHoiNghi> TbHoiThaoHoiNghis { get; set; } = new List<TbHoiThaoHoiNghi>();

    public ICollection<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo> TbKhoaBoiDuongTapHuanThamGiaCuaCanBos { get; set; } = new List<TbKhoaBoiDuongTapHuanThamGiaCuaCanBo>();

    public ICollection<TbNhiemVuKhcn> TbNhiemVuKhcns { get; set; } = new List<TbNhiemVuKhcn>();
}
