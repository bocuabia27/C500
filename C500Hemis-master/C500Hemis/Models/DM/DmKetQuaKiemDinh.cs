using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmKetQuaKiemDinh
{
    public int IdKetQuaKiemDinh { get; set; }

    public string? KetQuaKiemDinh { get; set; }

    public  ICollection<TbThongTinKiemDinhCuaChuongTrinh> TbThongTinKiemDinhCuaChuongTrinhs { get; set; } = new List<TbThongTinKiemDinhCuaChuongTrinh>();

    public  ICollection<TbToChucKiemDinh> TbToChucKiemDinhs { get; set; } = new List<TbToChucKiemDinh>();
}
