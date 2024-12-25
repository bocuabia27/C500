using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTonGiao
{
    public int IdTonGiao { get; set; }

    public string? TonGiao { get; set; }

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();
}
