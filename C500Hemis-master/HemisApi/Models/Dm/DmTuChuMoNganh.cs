using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTuChuMoNganh
{
    public int IdTuChuMoNganh { get; set; }

    public string? TuChuMoNganh { get; set; }

    public  ICollection<TbDanhSachNganhDaoTao> TbDanhSachNganhDaoTaos { get; set; } = new List<TbDanhSachNganhDaoTao>();
}
