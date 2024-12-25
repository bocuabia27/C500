using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmNhomNganh
{
    public int IdNhomNganh { get; set; }

    public string? NhomNganh { get; set; }

    public  ICollection<DmLinhVucNhomNganh> DmLinhVucNhomNganhs { get; set; } = new List<DmLinhVucNhomNganh>();

    public  ICollection<TbNhomNganhDaoTao> TbNhomNganhDaoTaos { get; set; } = new List<TbNhomNganhDaoTao>();
}
