using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbChiTietTaiSanDonVi
{
    public int IdChiTietTaiSanDonVi { get; set; }

    public int? IdTaiSanDonVi { get; set; }

    public string? MaTaiSan { get; set; }

    public string? TenTaiSan { get; set; }

    public int? NguyenGia { get; set; }

    public int? IdTinhTrangThietBi { get; set; }

    public int? IdChuSoHuu { get; set; }

    public DmChuSoHuu? IdChuSoHuuNavigation { get; set; }

    public TbTaiSanDonVi? IdTaiSanDonViNavigation { get; set; }

    public DmTinhTrangThietBi? IdTinhTrangThietBiNavigation { get; set; }
}
