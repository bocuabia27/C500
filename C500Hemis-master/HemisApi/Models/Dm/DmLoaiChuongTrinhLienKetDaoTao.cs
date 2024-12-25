using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiChuongTrinhLienKetDaoTao
{
    public int IdLoaiChuongTrinhLienKetDaoTao { get; set; }

    public string? LoaiChuongTrinhLienKetDaoTao { get; set; }

    public  ICollection<TbChuongTrinhDaoTao> TbChuongTrinhDaoTaos { get; set; } = new List<TbChuongTrinhDaoTao>();
}
