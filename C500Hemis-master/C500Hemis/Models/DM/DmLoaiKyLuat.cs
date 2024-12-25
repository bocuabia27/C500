using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmLoaiKyLuat
{
    public int IdLoaiKyLuat { get; set; }

    public string? LoaiKyLuat { get; set; }

    public  ICollection<TbKyLuatCanBo> TbKyLuatCanBos { get; set; } = new List<TbKyLuatCanBo>();

    public  ICollection<TbKyLuatNguoiHoc> TbKyLuatNguoiHocs { get; set; } = new List<TbKyLuatNguoiHoc>();
}
