using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmHinhThucSoHuu
{
    public int IdHinhThucSoHuu { get; set; }

    public string? HinhThucSoHuu { get; set; }

    public  ICollection<TbCongTrinhCoSoVatChat> TbCongTrinhCoSoVatChats { get; set; } = new List<TbCongTrinhCoSoVatChat>();

    public  ICollection<TbDatDai> TbDatDais { get; set; } = new List<TbDatDai>();

    public  ICollection<TbKiTucXa> TbKiTucXas { get; set; } = new List<TbKiTucXa>();

    public  ICollection<TbPhongHocGiangDuongHoiTruong> TbPhongHocGiangDuongHoiTruongs { get; set; } = new List<TbPhongHocGiangDuongHoiTruong>();
}
