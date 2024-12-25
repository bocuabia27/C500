using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbKhoaBoiDuongTapHuanThamGiaCuaCanBo
{
    public int IdKhoaBoiDuongTapHuanThamGiaCuaCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public string? TenKhoaBoiDuongTapHuan { get; set; }

    public string? DonViToChuc { get; set; }

    public int? IdLoaiBoiDuong { get; set; }

    public string? DiaDiemToChuc { get; set; }

    public DateOnly? ThoiGianBatDau { get; set; }

    public DateOnly? ThoiGianKetThuc { get; set; }

    public int? IdNguonKinhPhi { get; set; }

    public string? ChungChi { get; set; }

    public DateOnly? NgayCap { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmLoaiBoiDuong? IdLoaiBoiDuongNavigation { get; set; }

    public  DmNguonKinhPhi? IdNguonKinhPhiNavigation { get; set; }
}
