using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmNgoaiNgu
{
    public int IdNgoaiNgu { get; set; }

    public string? NgoaiNgu { get; set; }

    public  ICollection<TbNgonNguGiangDay> TbNgonNguGiangDays { get; set; } = new List<TbNgonNguGiangDay>();

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();
}
