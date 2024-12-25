using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmDangTaiLieu
{
    public int IdDangTaiLieu { get; set; }

    public string? DangTaiLieu { get; set; }

    public  ICollection<TbSachDaXuatBan> TbSachDaXuatBans { get; set; } = new List<TbSachDaXuatBan>();
}
