using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmHoatDongTaiChinh
{
    public int IdHoatDongTaiChinh { get; set; }

    public string? HoatDongTaiChinh { get; set; }

    public  ICollection<TbHoatDongTaiChinh> TbHoatDongTaiChinhs { get; set; } = new List<TbHoatDongTaiChinh>();
}
