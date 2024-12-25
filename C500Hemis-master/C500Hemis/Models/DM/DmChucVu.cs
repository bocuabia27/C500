using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmChucVu
{
    public int IdChucVu { get; set; }

    public string? ChucVu { get; set; }

    public  ICollection<TbCanBo> TbCanBos { get; set; } = new List<TbCanBo>();

    public  ICollection<TbDonViCongTacCuaCanBo> TbDonViCongTacCuaCanBos { get; set; } = new List<TbDonViCongTacCuaCanBo>();

    public  ICollection<TbQuaTrinhCongTacCuaCanBo> TbQuaTrinhCongTacCuaCanBos { get; set; } = new List<TbQuaTrinhCongTacCuaCanBo>();
}
