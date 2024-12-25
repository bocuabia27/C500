using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmDanhGiaCongChucVienChuc
{
    public int IdDanhGiaCongChucVienChuc { get; set; }

    public string? DanhGiaCongChucVienChuc { get; set; }

    public  ICollection<TbDanhGiaXepLoaiCanBo> TbDanhGiaXepLoaiCanBos { get; set; } = new List<TbDanhGiaXepLoaiCanBo>();
}
