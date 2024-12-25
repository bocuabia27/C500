using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmDoiTuongDauVao
{
    public int IdDoiTuongDauVao { get; set; }

    public string? DoiTuongDauVao { get; set; }

    public  ICollection<TbDuLieuTrungTuyen> TbDuLieuTrungTuyens { get; set; } = new List<TbDuLieuTrungTuyen>();

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
