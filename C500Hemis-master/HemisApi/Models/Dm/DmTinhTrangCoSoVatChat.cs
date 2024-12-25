using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTinhTrangCoSoVatChat
{
    public int IdTinhTrangCoSoVatChat { get; set; }

    public string? TinhTrangCoSoVatChat { get; set; }

    public  ICollection<TbCongTrinhCoSoVatChat> TbCongTrinhCoSoVatChats { get; set; } = new List<TbCongTrinhCoSoVatChat>();

    public  ICollection<TbKiTucXa> TbKiTucXas { get; set; } = new List<TbKiTucXa>();

    public  ICollection<TbPhongHocGiangDuongHoiTruong> TbPhongHocGiangDuongHoiTruongs { get; set; } = new List<TbPhongHocGiangDuongHoiTruong>();
}
