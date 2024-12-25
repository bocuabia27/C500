using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmPhanLoaiDoanRaDoanVao
{
    public int IdPhanLoaiDoanRaDoanVao { get; set; }

    public string? PhanLoaiDoanRaDoanVao { get; set; }

    public  ICollection<TbDoanCongTac> TbDoanCongTacs { get; set; } = new List<TbDoanCongTac>();
}
