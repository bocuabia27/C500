using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HemisApi.Models;

public partial class TbBaiBaoKhdaCongBo
{
    public int IdBaiBaoKhdaCongBo { get; set; }

    public int? IdNhiemVuKhcn { get; set; }

    public string? MaBaiBaoKh { get; set; }

    public string? TenBaiBaoKh { get; set; }

    public string? TenTapChi { get; set; }

    public int? IdTapChiTrongNuoc { get; set; }

    public int? IdTapChiQuocTe { get; set; }

    public int? IdXepHangQ { get; set; }

    public string? GhiChuDuongDanBaiBao { get; set; }

    public int? TapSo { get; set; }

    public int? Trang { get; set; }

    public string? NamCongBo { get; set; }

    public TbNhiemVuKhcn? IdNhiemVuKhcnNavigation { get; set; }

    public DmTapChiKhoaHocQuocTe? IdTapChiQuocTeNavigation { get; set; }

    public DmTapChiTrongNuoc? IdTapChiTrongNuocNavigation { get; set; }

    public DmXepHangQ? IdXepHangQNavigation { get; set; }
}
