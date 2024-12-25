using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmTrangThaiHoc
{
    public int IdTrangThaiHoc { get; set; }

    public string? TrangThaiHoc { get; set; }

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
