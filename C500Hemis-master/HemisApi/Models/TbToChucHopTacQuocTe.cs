using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbToChucHopTacQuocTe
{
    public int IdToChucHopTacQuocTe { get; set; }

    public string? MaHopTac { get; set; }

    public string? TenToChuc { get; set; }

    public int? IdQuocGia { get; set; }

    public string? NoiDung { get; set; }

    public DateOnly? ThoiGianKyKet { get; set; }

    public string? KetQuaHopTac { get; set; }

    public string? LoaiToChuc { get; set; }

    public  DmQuocTich? IdQuocGiaNavigation { get; set; }

    public  ICollection<TbThongTinHopTac> TbThongTinHopTacs { get; set; } = new List<TbThongTinHopTac>();
}
