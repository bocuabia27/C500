using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmKhungNangLucNgoaiNgu
{
    public int IdKhungNangLucNgoaiNgu { get; set; }

    public string? TenKhungNangLucNgoaiNgu { get; set; }

    public  ICollection<TbNgonNguGiangDay> TbNgonNguGiangDays { get; set; } = new List<TbNgonNguGiangDay>();

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();

    public  ICollection<TbTrinhDoTiengDanToc> TbTrinhDoTiengDanTocs { get; set; } = new List<TbTrinhDoTiengDanToc>();
}
