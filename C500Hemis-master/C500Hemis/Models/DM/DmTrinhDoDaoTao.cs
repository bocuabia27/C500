using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmTrinhDoDaoTao
{
    public int IdTrinhDoDaoTao { get; set; }

    public string? TrinhDoDaoTao { get; set; }

    public  ICollection<TbChuongTrinhDaoTao> TbChuongTrinhDaoTaos { get; set; } = new List<TbChuongTrinhDaoTao>();

    public  ICollection<TbDienBienLuong> TbDienBienLuongs { get; set; } = new List<TbDienBienLuong>();

    public  ICollection<TbNganhGiangDayCuaCanBo> TbNganhGiangDayCuaCanBos { get; set; } = new List<TbNganhGiangDayCuaCanBo>();

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();

    public  ICollection<TbQuaTrinhDaoTaoCuaCanBo> TbQuaTrinhDaoTaoCuaCanBos { get; set; } = new List<TbQuaTrinhDaoTaoCuaCanBo>();
}
