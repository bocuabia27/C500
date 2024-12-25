using System;
using System.Collections.Generic;

namespace C500Hemis.Models.DM;

public partial class DmTrangThaiHopDong
{
    public int IdTrangThaiHopDong { get; set; }

    public string? TrangThaiHopDong { get; set; }

    public  ICollection<TbChuyenGiaoCongNgheVaDaoTao> TbChuyenGiaoCongNgheVaDaoTaos { get; set; } = new List<TbChuyenGiaoCongNgheVaDaoTao>();

    public  ICollection<TbHopDongThinhGiang> TbHopDongThinhGiangs { get; set; } = new List<TbHopDongThinhGiang>();
}
