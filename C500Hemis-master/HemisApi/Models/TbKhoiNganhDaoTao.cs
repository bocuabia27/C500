using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbKhoiNganhDaoTao
{
    public int IdKhoiNganhDaoTao { get; set; }

    public string? KhoiNganhDaoTao { get; set; }

    public  ICollection<DmKhoiNganhLinhVucDaoTao> DmKhoiNganhLinhVucDaoTaos { get; set; } = new List<DmKhoiNganhLinhVucDaoTao>();

    public  ICollection<TbThongTinLinhVucDaoTao> TbThongTinLinhVucDaoTaos { get; set; } = new List<TbThongTinLinhVucDaoTao>();
}
