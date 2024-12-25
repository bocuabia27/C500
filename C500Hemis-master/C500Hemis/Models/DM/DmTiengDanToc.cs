using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmTiengDanToc
{
    public int IdTiengDanToc { get; set; }

    public string? TiengDanToc { get; set; }

    public  ICollection<TbTrinhDoTiengDanToc> TbTrinhDoTiengDanTocs { get; set; } = new List<TbTrinhDoTiengDanToc>();
}
