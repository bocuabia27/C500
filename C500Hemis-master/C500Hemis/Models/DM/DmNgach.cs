using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmNgach
{
    public int IdNgach { get; set; }

    public string? Ngach { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();
}
