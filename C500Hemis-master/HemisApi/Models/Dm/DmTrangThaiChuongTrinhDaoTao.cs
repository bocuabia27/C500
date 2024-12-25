using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTrangThaiChuongTrinhDaoTao
{
    public int IdTrangThaiChuongTrinhDaoTao { get; set; }

    public string? TrangThaiChuongTrinhDaoTao { get; set; }

    public  ICollection<TbChuongTrinhDaoTao> TbChuongTrinhDaoTaos { get; set; } = new List<TbChuongTrinhDaoTao>();
}
