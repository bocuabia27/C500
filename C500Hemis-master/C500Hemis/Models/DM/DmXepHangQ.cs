using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmXepHangQ
{
    public int IdXepHangQ { get; set; }

    public string? XepHangQ { get; set; }

    public  ICollection<TbBaiBaoKhdaCongBo> TbBaiBaoKhdaCongBos { get; set; } = new List<TbBaiBaoKhdaCongBo>();
}
